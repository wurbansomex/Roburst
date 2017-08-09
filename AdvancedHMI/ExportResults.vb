Imports System.IO
Imports System.Xml
Imports Microsoft.VisualBasic.FileIO
Imports log4net
Imports System.Xml.Linq

Public Class ResultExporter


    Shared _log As ILog = LogManager.GetLogger(GetType(ResultExporter))

    ''' <summary>
    ''' Export single result to XML file
    ''' </summary>
    ''' <param name="testNumber"></param>
    ''' <param name="testDate"></param>
    ''' <param name="testTime"></param>
    ''' <param name="testID"></param>
    ''' <param name="mouldNumber"></param>
    ''' <param name="maxPressure"></param>
    ''' <param name="burst"></param>
    ''' <param name="profileNo"></param>
    ''' <param name="profileName"></param>
    ''' <param name="profileUnits"></param>
    ''' <param name="profilePress1Min"></param>
    ''' <param name="profileSp1"></param>
    ''' <param name="profileRamp1"></param>
    ''' <param name="profileDwellTime1"></param>
    ''' <param name="profileSP2"></param>
    ''' <param name="profileRamp2"></param>
    ''' <param name="profileDwellTime2"></param>
    ''' <param name="resultsDirectory"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ExportToXML(testNumber As Integer, testDate As String, testTime As String, testID As String,
                                       mouldNumber As Integer, maxPressure As Single, burst As Boolean, profileNo As String,
                                       profileName As String, profileUnits As Integer, profilePress1Min As Boolean, profileSp1 As Single,
                                       profileRamp1 As Single, profileDwellTime1 As Integer,
                                       profileSP2 As Single, profileRamp2 As Single, profileDwellTime2 As Integer, resultsDirectory As String,
                                       isResultValid As Boolean)

        Try


            'Create a new random  XML file to store the results
            Dim randomFileName As String = resultsDirectory & "\single" & New Random().Next(99999999).ToString() & ".xml"
            Using x As New XmlTextWriter(randomFileName, System.Text.Encoding.UTF8)

                x.WriteStartDocument(True)
                x.Formatting = Formatting.Indented
                x.Indentation = 3

                x.WriteStartElement("daily")
                x.WriteStartElement("test")

                x.WriteStartElement("Time_Date")
                x.WriteString(testID)
                x.WriteEndElement()

                x.WriteStartElement("TestNumber")
                x.WriteString(testNumber)
                x.WriteEndElement()

                x.WriteStartElement("MouldNumber")
                x.WriteString(mouldNumber)
                x.WriteEndElement()

                x.WriteStartElement("MaxPressure")
                x.WriteString(maxPressure)
                x.WriteEndElement()

                x.WriteStartElement("Burst")
                If burst Then
                    x.WriteString("yes")
                Else
                    x.WriteString("no")
                End If
                x.WriteEndElement()

                x.WriteStartElement("ResultValid")
                If isResultValid Then
                    x.WriteString("yes")
                Else
                    x.WriteString("no")
                End If
                x.WriteEndElement()

                x.WriteStartElement("ProfileNo")
                x.WriteString(profileNo)
                x.WriteEndElement()

                x.WriteStartElement("ProfileName")
                x.WriteString(profileName)
                x.WriteEndElement()

                x.WriteStartElement("PressureUnits")
                If profileUnits = 0 Then
                    x.WriteString("Bar")
                ElseIf profileUnits = 1 Then
                    x.WriteString("PSI")
                Else
                    x.WriteString("kg/cm^2")
                End If
                x.WriteEndElement()

                x.WriteStartElement("OneMinEquiv")
                If profilePress1Min Then
                    x.WriteString("Yes")
                Else
                    x.WriteString("No")
                End If
                x.WriteEndElement()

                x.WriteStartElement("ProfileSP1")
                x.WriteString(profileSp1)
                x.WriteEndElement()

                x.WriteStartElement("ProfileRampRate1")
                x.WriteString(profileRamp1)
                x.WriteEndElement()

                x.WriteStartElement("ProfileDwellTime1")
                x.WriteString(profileDwellTime1)
                x.WriteEndElement()

                x.WriteStartElement("ProfileSP2")
                x.WriteString(profileSP2)
                x.WriteEndElement()

                x.WriteStartElement("ProfileRampRate2")
                x.WriteString(profileRamp2)
                x.WriteEndElement()

                x.WriteStartElement("ProfileDwellTime2")
                x.WriteString(profileDwellTime2)
                x.WriteEndElement()

                x.WriteEndElement()
                x.WriteEndElement()

                x.WriteEndDocument()
                x.Close()
            End Using

            'update the daily xml file
            UpdateDailyXml(resultsDirectory, randomFileName)

            Return True

        Catch ex As Exception
            _log.Error("Error exporting result to XML, " & ex.ToString())
        End Try

        Return False

    End Function


    Public Function AppendToCSV(testNumber As Integer, testDate As String, testTime As String, testID As String,
                                       mouldNumber As Integer, maxPressure As Single, burst As Boolean, profileNo As String,
                                       profileName As String, profileUnits As Integer, profilePress1Min As Integer, profileSp1 As Single,
                                       profileRamp1 As Single, profileDwellTime1 As Integer,
                                       profileSP2 As Single, profileRamp2 As Single, profileDwellTime2 As Integer, resultsDirectory As String, isResultValid As Boolean)

        Try



            Dim csvFile As String = resultsDirectory & "\" & DateTime.Now.ToString("yyyy-MMM-dd") & ".csv"

            ' create file and insert headers if the file does not exist
            If (Not File.Exists(csvFile)) Then

                ' write the header info to the newly created cvs file
                Dim writer As StreamWriter = New StreamWriter(csvFile)
                Dim header As String = "Time_Date,Result Valid,Test Number,MouldNumber,MaxPressure,Burst,ProfileNo," &
                                        "ProfileName,PressureUnits,P60,ProfileSP1,ProfileRampRate1,ProfileDwellTime1," &
                                        "ProfileSP2,ProfileRampRate2,ProfileDwellTime2"

                writer.WriteLine(header)
                writer.Close()
                writer.Dispose()

            End If

            ' append the results to the file
            Using writer As New StreamWriter(csvFile, True)

                Dim resultLine As String = testID & "," & IIf((CBool(isResultValid)), "yes", "no") & "," & testNumber & "," & mouldNumber & "," &
                                    maxPressure & "," & IIf(burst, "yes", "no") & "," & profileNo & "," &
                                    profileName & "," & profileUnits & "," & IIf((CBool(profilePress1Min)), "yes", "no") & "," &
                                    profileSp1 & "," & profileRamp1 & "," & profileDwellTime1 & "," &
                                    profileSP2 & "," & profileRamp2 & "," & profileDwellTime2

                writer.WriteLine(resultLine)
                writer.Close()

            End Using

            Return True

        Catch ex As Exception
            _log.Error("Error exporting result to daily csv, " & ex.ToString())
        End Try


        Return False

    End Function

   
    Public Function AppendVerificationREsultsToCSV(resultsDirectory As String, gaugeSerialNumber As String,
                                step1SetPoint As String, step1Gauge As String, step1System As String,
                                step2SetPoint As String, step2Gauge As String, step2System As String,
                                step3SetPoint As String, step3Gauge As String, step3System As String,
                                step4SetPoint As String, step4Gauge As String, step4System As String)

        Try



            Dim csvFile As String = resultsDirectory & "\" & "Verifications " & ".csv"

            ' create file and insert headers if the file does not exist
            If (Not File.Exists(csvFile)) Then

                ' write the header info to the newly created cvs file
                Dim writer As StreamWriter = New StreamWriter(csvFile)
                Dim header As String = "Timestamp, Gauge Serial Number, Step 1 Set Point,Step 1 System Measurement,Step 1 Gauge Value, " &
                                       "Step 2 Set Point,Step 2 System Measurement,Step 2 Gauge Value, " &
                                       "Step 3 Set Point,Step 3 System Measurement,Step 3 Gauge Value, " &
                                       "Step 4 Set Point,Step 4 System Measurement,Step 4 Gauge Value"

                writer.WriteLine(header)
                writer.Close()
                writer.Dispose()
            End If

            ' append the results to the file
            Using writer As New StreamWriter(csvFile, True)

                Dim resultLine As String = Date.Now.ToString("dd MMM yyyy HH:mm:ss") & "," & gaugeSerialNumber & "," &
                                                             step1SetPoint & "," & step1System & "," & step1Gauge & "," &
                                                             step2SetPoint & "," & step2System & "," & step2Gauge & "," &
                                                             step3SetPoint & "," & step3System & "," & step3Gauge & "," &
                                                             step4SetPoint & "," & step4System & "," & step4Gauge

                writer.WriteLine(resultLine)
                writer.Close()

            End Using

        Catch ex As Exception
            _log.Error("Error appending verification result to csv, " & ex.ToString())
            MessageBox.Show(ex.Message)
        End Try

        Return True

    End Function


    ''' <summary>
    ''' Appends the last XML to the current daily file. 
    ''' </summary>
    ''' <param name="reportPath">Path to store results to</param>
    ''' <param name="tempFile">Temp file cotnaining last results</param>
    ''' <remarks></remarks>
    Public Function UpdateDailyXml(reportPath As String, tempFile As String) As Boolean

        Dim dailyXMLpath = reportPath & "\" & DateTime.Now.ToString("yyyy-MMM-dd") & ".xml"

        Try

            ' merge last temp result file with daily result file
            Using writer As New StreamWriter(dailyXMLpath, True)

                Dim xDoc = XDocument.Load(tempFile)
                writer.WriteLine(Environment.NewLine)
                writer.WriteLine(xDoc.ToString())
                writer.Close()
                writer.Dispose()

            End Using

            Return True

        Catch ex As Exception
            _log.Error("Error appending to single.xml file," & ex.ToString())
        Finally
            File.Delete(tempFile)
        End Try

        Return False

    End Function


End Class
