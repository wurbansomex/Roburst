Imports System.IO.Ports
Imports System.Text
Imports log4net

''' <summary>
''' Connects to serial port contained in settings.ini and exports result data
''' </summary>
''' <remarks></remarks>
Public Class SerialResultsExporter


    Private Shared _log As ILog = LogManager.GetLogger(GetType(SerialResultsExporter))
    Private Shared _serialPort As SerialPort
    Private Shared _isPortOpen As Boolean

    ''' <summary>
    ''' Opens serial port for exporting results, if setting is enabled. 
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared Sub OpenPort()

        Try

            ' check if serial comms is enabled
            Dim isSerialCommsEnabled = Convert.ToBoolean(HmiSettingsResolver.GetSettingValue("SerialComms", "EnableSerialComms"))
            If (Not isSerialCommsEnabled) Then Return

            _serialPort = New SerialPort()
            _serialPort.PortName = HmiSettingsResolver.GetSettingValue("SerialComms", "PortName")
            _serialPort.Parity = CType([Enum].Parse(GetType(Parity), HmiSettingsResolver.GetSettingValue("SerialComms", "Parity"), True), Parity)
            _serialPort.DataBits = HmiSettingsResolver.GetSettingValue("SerialComms", "DataBits")
            _serialPort.StopBits = CType([Enum].Parse(GetType(StopBits), HmiSettingsResolver.GetSettingValue("SerialComms", "StopBits"), True), StopBits)
            _serialPort.Handshake = CType([Enum].Parse(GetType(Handshake), HmiSettingsResolver.GetSettingValue("SerialComms", "Handshake"), True), Handshake)
            _serialPort.WriteTimeout = 1000
            _serialPort.Open()
            _isPortOpen = True

        Catch ex As Exception
            _log.Error("Error opening serial port," + ex.ToString())
        End Try
       
    End Sub



    ''' <summary>
    ''' Export results over Serial Port. 
    ''' Roburst does not wait for a response.
    ''' </summary>
    ''' <remarks>
    ''' Exceptions are are logged to the log file
    ''' </remarks>
    Public Shared Sub ExportResults(testNumber As Integer, testDate As String, testTime As String, testID As String,
                                      mouldNumber As Integer, maxPressure As Decimal, burst As Boolean, profileNo As String,
                                      profileName As String, profileUnits As Integer, profilePress1Min As Boolean, profileSp1 As Single,
                                      profileRamp1 As Single, profileDwellTime1 As Integer,
                                      profileSP2 As Single, profileRamp2 As Single,
                                      profileDwellTime2 As Integer, isResultValid As Boolean)

        Try

            ' check if serial comms is enabled
            Dim isSerialCommsEnabled = Convert.ToBoolean(HmiSettingsResolver.GetSettingValue("SerialComms", "EnableSerialComms"))
            If (Not isSerialCommsEnabled) Then Return

            ' check if the port was opened
            If (Not _isPortOpen) Then

                ' try and open it
                OpenPort()

                If (Not _isPortOpen) Then
                    _log.Error("Aborting serial write as port is not open and attempt to re-open failed")
                    Return
                End If

            End If

            ' write out the results as per email from Michael Beston on 20/11/2015
            ' MF+<Max Pressure>OMF+0BD< Burst Y/N>CN+<Mold Number>TD+0TN+<Test ID>;
            ' 
            Dim resultString As String = "MF+" & maxPressure & "OMF+" & 0 & "BD" & (IIf(burst, 1, 0)) & "CN+" & mouldNumber & "TD+" & 0 & "TN+" & testNumber & ";"
            Dim bytesToSend = Encoding.ASCII.GetBytes(resultString)
            _serialPort.Write(bytesToSend, 0, bytesToSend.Count)

            _log.Info("Serial Export Complete, " + resultString)

        Catch ex As Exception
            _log.Error(String.Format("Error exporting results over Serial Port, '{0}'", ex.ToString()))
        Finally


        End Try

    End Sub

    Public Shared Sub ClosePort()

        If (_serialPort Is Nothing) Then Return

        Try
            _serialPort.DiscardOutBuffer()
            _serialPort.Close()
        Catch ex As Exception
            _log.Error("Error closing serial port," + ex.ToString())
        End Try

    End Sub

End Class
