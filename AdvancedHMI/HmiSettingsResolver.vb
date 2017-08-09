Imports Somex.Roburst.Ini
Imports System.IO
Imports System.Configuration

''' <summary>
''' Wrapper class around ini parser
''' </summary>
''' <remarks></remarks>
Public Class HmiSettingsResolver

    Private Shared _iniParser As IniFile

    Shared Sub New()

        Dim iniPath As String = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings("SettingsFilePath").Value
        _iniParser = New IniFile(iniPath)
    End Sub


    Public Shared Function GetSettingValue(sectionName As String, settingKey As String) As String
        Return _iniParser.IniReadValue(sectionName, settingKey)
    End Function

    Public Shared Sub SaveSettingValue(sectionName As String, settingKey As String, value As Object)
        _iniParser.IniWriteValue(sectionName, settingKey, value.ToString())
    End Sub

End Class
