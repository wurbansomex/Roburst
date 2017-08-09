Imports AdvancedHMIDrivers
Imports log4net

''' <summary>
''' Contains a couple of utility methods for reading and writing tag values in PLC
''' </summary>
''' <remarks></remarks>
Public Class PlcDriverUtilities

    Shared _log As ILog = LogManager.GetLogger(GetType(PlcDriverUtilities))

    ''' <summary>
    ''' Reads value from PLC and returns as generic type T
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="tag"></param>
    ''' <returns>PLC value of type T</returns>
    ''' <remarks>The AdvancedHMI .Read method always returns an array of strings, no matter what type the tag is</remarks>
    Public Shared Function ReadPLCValue(Of T)(ByVal tag As String, ByRef plcDriver As AdvancedHMIDrivers.EthernetIPforCLXCom) As T
        Try
            Dim TempAry() As String
            Dim TempIndex As Integer
            Dim TryParseOk As Boolean

            TempAry = plcDriver.Read(tag, 1)
            TempIndex = InStrRev(tag, ".")

            If (GetType(T) = GetType(Boolean) And TempIndex > 0) Then
                Dim TempBitValue As Integer
                Dim TrueValue As Boolean
                TryParseOk = Integer.TryParse(tag.Substring(TempIndex), TempBitValue)
                If (TryParseOk) Then
                    TrueValue = IIf(((Convert.ToInt32(TempAry(0)) And (2 ^ TempBitValue)) > 0), True, False)
                    Return DirectCast(Convert.ChangeType(TrueValue, GetType(T)), T)
                End If
            End If

            Return DirectCast(Convert.ChangeType(TempAry(0), GetType(T)), T)

        Catch ex As Exception
            _log.Error(String.Format("Could not read PLC tag '{0}', Error: '{1}'", tag, ex.ToString()))
        End Try

    End Function

    Public Shared Sub WritePlcValue(tag As String, value As Object, ByRef plcDriver As AdvancedHMIDrivers.EthernetIPforCLXCom)
        Try
            If (TypeOf value Is Double) Then
                'plcDriver.Write(tag, Convert.ToSingle(value))
                plcDriver.BeginWrite(tag, 1, New String() {Convert.ToString(Convert.ToSingle(value))})
            Else
                plcDriver.BeginWrite(tag, 1, New String() {Convert.ToString(value)})
            End If
        Catch ex As Exception
            _log.Error(String.Format("Could not write PLC tag '{0}', Value: '{1}', Error: '{2}'", tag, value.ToString(), ex.ToString()))
        End Try

    End Sub

    Public Shared Sub PulsePlcTag(tag As String, isRisingEdge As Boolean, ByRef plcDriver As AdvancedHMIDrivers.EthernetIPforCLXCom)

        Try

            plcDriver.Write(tag, IIf(isRisingEdge, 1, 0))
            System.Threading.Thread.Sleep(500)
            plcDriver.Write(tag, IIf(isRisingEdge, 0, 1))

        Catch ex As Exception
            _log.Error(String.Format("Could not pulse PLC tag '{0}', Error: '{1}'", tag, ex.ToString()))
        End Try

    End Sub


End Class
