Namespace My
    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        ' Catch an unhandled exception.
        Private Sub MyApplication_UnhandledException(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            ' If the user clicks No, then exit.
            e.ExitApplication = _
                MessageBox.Show(String.Format("An unhandled error has occured, '{0}'", e.Exception.Message) & _
                        vbCrLf & "Click Yes to Exit or No to continue using the application", "Exit Application?", _
                        MessageBoxButtons.YesNo, _
                        MessageBoxIcon.Question) _
                        = DialogResult.Yes
        End Sub

        Public Sub MyApplication_InstanceAlreadyRunning(sender As Object, e As Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventArgs) Handles Me.StartupNextInstance

            MessageBox.Show("This program is already running.  If you do not see the program running, please check your " _
                                & "Windows Task Manager for this program name in the 'Processes' Tab." & vbNewLine & vbNewLine & "WARNING: " _
                                & " If you terminate the process, you will terminate the only instance of this program!", My.Application.Info.ProductName.ToString _
                                & " is Running!", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Sub


    End Class


End Namespace

