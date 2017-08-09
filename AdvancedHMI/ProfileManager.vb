Imports System.Linq
Imports System.Collections.Generic
Imports System.Collections
Imports System.IO
Imports Somex.Roburst.Integration.Common
Imports System.Xml
Imports System.Xml.Linq
Imports log4net


''' <summary>
''' Manages loading and saving of profiles stored in an xml file
''' </summary>
''' <remarks></remarks>
Public Class ProfileManager


    Private Shared _storagePath As String
    Private Shared _storageFileName As String
    Public Shared _profiles As RoburstProfiles
    Private Shared _log As ILog = LogManager.GetLogger(GetType(ProfileManager))

    ''' <summary>
    ''' Builds up the save path and loads the profiles from disk
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared Sub Initialise()

        _storageFileName = "Profiles.xml"
        _storagePath = HmiSettingsResolver.GetSettingValue("Misc", "ProfilesSavePath")

        ' load the profiles from disk
        _profiles = LoadProfiles()

    End Sub

    Private Shared Function LoadProfiles() As RoburstProfiles

        Dim xmlSavePath As String = String.Empty

        Try

            xmlSavePath = Path.Combine(_storagePath, _storageFileName)

            ' display a message to user if file does not exist
            If (Not File.Exists(xmlSavePath)) Then
                MessageBox.Show(LanguageManager.GetUserMessage(LanguageManager.UserMessages.ProfileFileNotFound), "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return Nothing
            End If

            Dim profileString As String = XDocument.Load(xmlSavePath).ToString()
            Return ProfileSerialiser.DeserialiseXML(Of RoburstProfiles)(profileString)

        Catch ex As Exception
            _log.Error("Error loading profiles from " & xmlSavePath & "," & ex.ToString())
            MessageBox.Show(LanguageManager.GetUserMessage(LanguageManager.UserMessages.ErrorLoadingProfiles) & "," & ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        Return Nothing


    End Function


    Public Shared Function GetProfileNumbersFor(line As Integer) As List(Of String)

        If (_profiles Is Nothing) Then Return New List(Of String)

        Return _profiles.Profiles.Where(Function(p As ProfileDetails) p.LineNumber = line).Select(Function(p As ProfileDetails) p.Number).ToList()

    End Function

    Public Shared Function GetAllProfileNumbers() As List(Of String)

        If (_profiles Is Nothing) Then Return New List(Of String)

        Return _profiles.Profiles.Select(Function(p As ProfileDetails) p.Number).ToList()

    End Function


    ''' <summary>
    ''' Returns list of distinct line numbers across all profiles in xml file
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetListOfDistinctLines() As List(Of Integer)

        If (_profiles Is Nothing) Then Return New List(Of Integer)

        Return _profiles.Profiles.Select(Function(p As ProfileDetails) p.LineNumber).Distinct().OrderBy(Function(x) x).ToList()

    End Function

    ''' <summary>
    ''' Returns the lowest profile number
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function FirstProfile() As ProfileDetails
        If (_profiles Is Nothing) Then
            Return Nothing
        Else
            Return _profiles.Profiles.FirstOrDefault()
        End If
    End Function


    ''' <summary>
    ''' Returns the lowest profile number for specific line
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function FirstProfile(line As String) As ProfileDetails
        If (_profiles Is Nothing) Then
            Return Nothing
        Else
            Return _profiles.Profiles.Where(Function(p As ProfileDetails) p.LineNumber = line).FirstOrDefault()
        End If
    End Function

    ''' <summary>
    ''' Returns the largest profile number in list for specifc line
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function LastProfile(line As String) As ProfileDetails
        If (_profiles Is Nothing) Then
            Return Nothing
        Else
            Return _profiles.Profiles.Where(Function(p As ProfileDetails) p.LineNumber = line).LastOrDefault()
        End If
    End Function


    ''' <summary>
    ''' Returns the largest profile number in list
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function LastProfile() As ProfileDetails
        If (_profiles Is Nothing) Then
            Return Nothing
        Else
            Return _profiles.Profiles.LastOrDefault()
        End If
    End Function


    ''' <summary>
    ''' Gets the next profile number for matching line
    ''' </summary>
    Public Shared Function GetNextProfileNumber(currentProfile As ProfileDetails, line As Integer) As ProfileDetails
        If (_profiles Is Nothing) Then
            Return Nothing
        Else
            Dim nextProfile As ProfileDetails = _profiles.Profiles.Where(Function(p As ProfileDetails) p.LineNumber = line).SkipWhile(Function(profile As ProfileDetails) profile.UID <> currentProfile.UID).Skip(1).FirstOrDefault()
            If (nextProfile Is Nothing) Then
                Return _profiles.Profiles.First()
            Else
                Return nextProfile
            End If
        End If

    End Function


    ''' <summary>
    ''' Return the next profile number after the current number
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetNextProfileNumber(currentProfile As ProfileDetails) As ProfileDetails
        If (_profiles Is Nothing) Then
            Return Nothing
        Else

            Dim nextProfile As ProfileDetails = _profiles.Profiles.SkipWhile(Function(profile As ProfileDetails) profile.UID <> currentProfile.UID).Skip(1).FirstOrDefault()
            If (nextProfile Is Nothing) Then
                Return _profiles.Profiles.First()
            Else
                Return nextProfile
            End If
        End If

    End Function


    Public Shared Function GetPreviousProfile(currentProfile As ProfileDetails, line As Integer) As ProfileDetails
        If (_profiles Is Nothing) Then
            Return Nothing
        Else
            Dim nextProfile As ProfileDetails = _profiles.Profiles.Where(Function(p As ProfileDetails) p.LineNumber = line).TakeWhile(Function(profile As ProfileDetails) profile.UID <> currentProfile.UID).LastOrDefault()
            If (nextProfile Is Nothing) Then
                Return _profiles.Profiles.First()
            Else
                Return nextProfile
            End If
        End If

    End Function

    Public Shared Function GetPreviousProfile(currentProfile As ProfileDetails) As ProfileDetails
        If (_profiles Is Nothing) Then
            Return Nothing
        Else
            Dim nextProfile As ProfileDetails = _profiles.Profiles.TakeWhile(Function(profile As ProfileDetails) profile.UID <> currentProfile.UID).LastOrDefault()
            If (nextProfile Is Nothing) Then
                Return _profiles.Profiles.First()
            Else
                Return nextProfile
            End If
        End If

    End Function


    Public Shared Function IsProfileNumberInUse(number As String, line As Integer)
        Return Not (_profiles.Profiles.Where(Function(p As ProfileDetails) p.Number.ToLower() = number.ToLower() And p.LineNumber = line).FirstOrDefault() Is Nothing)
    End Function

    Public Shared Sub DeleteProfile(profile As ProfileDetails)

        If (_profiles Is Nothing) Then Return

        Dim matchingProfile = _profiles.Profiles.Where(Function(p As ProfileDetails) p.UID = profile.UID) _
                                                .FirstOrDefault()

        If (matchingProfile Is Nothing) Then Return

        ' remove from list
        _profiles.Profiles.Remove(matchingProfile)

        ' save the new list
        SaveProfiles()


    End Sub


    ''' <summary>
    ''' Returns profile matching the number passed as argument
    ''' </summary>
    ''' <param name="number"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetProfileForNumber(number As String) As ProfileDetails

        If (_profiles Is Nothing) Then Return Nothing

        Dim matchingProfile = _profiles.Profiles.Where(Function(p As ProfileDetails) p.Number.ToLower() = number.ToLower()) _
                                                .FirstOrDefault()

        Return matchingProfile

    End Function

    ''' <summary>
    ''' Returns profile matching the number passed as argument
    ''' </summary>
    ''' <param name="number"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetProfileForNumber(number As String, line As Integer)

        If (_profiles Is Nothing) Then Return Nothing

        Dim matchingProfile = _profiles.Profiles.Where(Function(p As ProfileDetails) p.Number.ToLower() = number.ToLower() And p.LineNumber = line) _
                                                .FirstOrDefault()

        Return matchingProfile

    End Function



    Public Shared Sub SaveProfile(profile As ProfileDetails)

        Dim matchingProfile As ProfileDetails = _profiles.Profiles.Where(Function(p As ProfileDetails) p.UID = profile.UID) _
                                                                       .FirstOrDefault()

        If (matchingProfile Is Nothing) Then
            profile.UID = Date.Now.Ticks
            _profiles.Profiles.Add(profile)
        Else
            matchingProfile = profile.CopyTo(matchingProfile)
        End If

        SaveProfiles()

    End Sub


    Public Shared Function SaveProfiles() As Boolean


        ' update the edit date
        _profiles.LastEditedOn = DateTime.Now.ToString("dd MMM yyyy HH:mm:ss")

        Dim serialisedProfiles = ProfileSerialiser.Serialise(_profiles)
        Dim xmlSavePath = Path.Combine(_storagePath, _storageFileName)
        Dim archiveDirectory = Path.Combine(_storagePath, "Archive")
        Dim archiveFilePath = Path.Combine(archiveDirectory, DateTime.Now.ToString("ddMMyyyy HHmmss fff") & ".xml")


        '' create archive directory is not already exists
        If Not Directory.Exists(archiveDirectory) Then
            Directory.CreateDirectory(archiveDirectory)
        End If

        '' archive the existing xml file, if it exists
        If (File.Exists(xmlSavePath)) Then
            File.Move(xmlSavePath, archiveFilePath)
        End If

        '' save update file
        File.WriteAllText(xmlSavePath, serialisedProfiles)

        Return File.Exists(xmlSavePath)

    End Function

    Public Shared Sub LoadProfileInPLC(profile As ProfileDetails, plcDriver As AdvancedHMIDrivers.EthernetIPforCLXCom)

        Try

            PlcDriverUtilities.WritePlcValue("ProfileLoad.PlacePositionAdjust", CType(profile.ContainerPlaceHeightAdjustment, Single), plcDriver)
            PlcDriverUtilities.WritePlcValue("ProfileLoad.BottleHeight", CType(profile.BottleHeight, Single), plcDriver)
            PlcDriverUtilities.WritePlcValue("ProfileLoad.LabelHeight", CType(profile.LabelHeight, Single), plcDriver)
            PlcDriverUtilities.WritePlcValue("ProfileLoad.FinishHeight", CType(profile.FinishHeight, Single), plcDriver)
            PlcDriverUtilities.WritePlcValue("ProfileLoad.Volume", CType(profile.BottleVolume, Single), plcDriver)
            PlcDriverUtilities.WritePlcValue("ProfileLoad.LBV", CType(profile.LowBurstValue, Single), plcDriver)
            PlcDriverUtilities.WritePlcValue("ProfileLoad.NeckGrip", CType(profile.NeckBurstSize, Single), plcDriver)
            PlcDriverUtilities.WritePlcValue("ProfileLoad.Units", GetPressureUnit(profile.PressureUnits), plcDriver)
            PlcDriverUtilities.WritePlcValue("ProfileLoad.P60", IIf(profile.P60orPr.ToLower() = "p60", 1, 0), plcDriver)
            PlcDriverUtilities.WritePlcValue("ProfileLoad.SP1", CType(profile.PressureSetpoint1, Single), plcDriver)
            PlcDriverUtilities.WritePlcValue("ProfileLoad.Ramp1", CType(profile.RampRate1, Single), plcDriver)
            PlcDriverUtilities.WritePlcValue("ProfileLoad.DwellTime1", CType(profile.DwellTime1, Single), plcDriver)
            PlcDriverUtilities.WritePlcValue("ProfileLoad.SP2", CType(profile.PressureSetpoint2, Single), plcDriver)
            PlcDriverUtilities.WritePlcValue("ProfileLoad.Ramp2", CType(profile.RampRate2, Single), plcDriver)
            PlcDriverUtilities.WritePlcValue("ProfileLoad.DwellTime2", CType(profile.DwellTime2, Single), plcDriver)
            PlcDriverUtilities.WritePlcValue("ProfileLoad.No", IIf(profile.Number Is Nothing, String.Empty, profile.Number), plcDriver)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    ''' <summary>
    ''' Pressure units are stored in the PLC as DINTs so this method
    ''' converts the string value to DINT
    ''' </summary>
    ''' <returns>DINT representing unit</returns>
    ''' <remarks></remarks>
    Public Shared Function GetPressureUnit(unit As String) As Integer

        Dim unitLower As String = unit.ToLower()
        If (unitLower = "barG") Then Return 0
        If (unitLower = "psi") Then Return 1
        If (unitLower = "kg/cm2") Then Return 2

    End Function



    Public Shared Function GetProfilesByName(nameToSearch As String) As List(Of String)

        If (_profiles Is Nothing) Then Return New List(Of String)

        Dim profiles As List(Of String) = (From element In _profiles.Profiles
                                           Where element.Number.IndexOf(nameToSearch, StringComparison.OrdinalIgnoreCase) >= 0
                                           Select element.Number).ToList()

        Return profiles

    End Function

    Public Shared Function GetProfilesByName(nameToSearch As String, lineToSearch As Integer) As List(Of String)

        If (_profiles Is Nothing) Then Return New List(Of String)

        Dim profiles As List(Of String) = (From element In _profiles.Profiles
                                           Where element.Number.IndexOf(nameToSearch, StringComparison.OrdinalIgnoreCase) >= 0 And
                                           element.LineNumber = lineToSearch
                                           Select element.Number).ToList()

        Return profiles

    End Function




End Class
