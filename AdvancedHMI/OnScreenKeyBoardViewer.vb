Imports System.Threading
Imports System.IO
Imports log4net
Imports System.Runtime.InteropServices



''' <summary>
''' Simply wrapper class for showing TabTip.exe and hiding it
''' </summary>
''' <remarks></remarks>
Public Class OnScreenKeyBoardViewer


    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Integer

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Private Shared Function PostMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Boolean
    End Function

    Private Shared _log As ILog = LogManager.GetLogger(GetType(OnScreenKeyBoardViewer))
    Private Shared oskProcess As Process

    Public Shared Sub ShowOnScreenKeyboard()
        Try


            Dim progFiles As String = "C:\Program Files\Common Files\Microsoft Shared\ink"
            Dim keyboardPath As String = Path.Combine(progFiles, "TabTip.exe")
            oskProcess = Process.Start(keyboardPath)

        Catch ex As Exception
            _log.Error("Error starting onscreen keyboard TabTip.exe, " & ex.ToString())
        End Try

    End Sub

    Public Shared Sub CloseOnScreenKeyboard()

        Try

            Dim WM_SYSCOMMAND As UInteger = 274
            Dim SC_CLOSE As UInteger = 61536
            Dim KeyboardWnd As IntPtr = FindWindow("IPTip_Main_Window", Nothing)
            PostMessage(KeyboardWnd, WM_SYSCOMMAND, SC_CLOSE, 0)

        Catch ex As Exception
            _log.Error(ex.Message)
        End Try
    End Sub

End Class
