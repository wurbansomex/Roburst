

Public Class MainForm

    '*******************************************************************************
    '* Stop polling when the form is not visible in order to reduce communications
    '* Copy this section of code to every new form created
    '*******************************************************************************
    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        If components IsNot Nothing Then
            Dim drv As Drivers.IComComponent
            '*****************************
            '* Search for comm components
            '*****************************
            For i As Integer = 0 To components.Components.Count - 1
                If components.Components(i).GetType.GetInterface("Drivers.IComComponent") IsNot Nothing Then
                    '* 13-JUL-14 changed to directcast
                    drv = DirectCast(components.Components.Item(i), Drivers.IComComponent)
                    'drv = components.Components.Item(i)
                    '* Stop/Start polling based on form visibility
                    drv.DisableSubscriptions = Not Me.Visible
                End If
            Next
        End If
    End Sub

    '************************************************************
    '* This will guarantee that even hidden forms are all closed
    '* when the main application is closed
    '************************************************************
    'Private Sub MainForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    '    Environment.Exit(0)
    'End Sub


    '**************************************
    '* Filling the form with a gradient
    '**************************************
    Private Sub MainForm_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        'Dim rect As New System.Drawing.Rectangle(0, 0, e.ClipRectangle.Width, e.ClipRectangle.Height)
        'Dim gradientBrush As New Drawing.Drawing2D.LinearGradientBrush(New Point(0, 0), New Point(0, Height), System.Drawing.Color.FromArgb(180, 100, 200), System.Drawing.Color.FromArgb(110, 200, 255))
        'e.Graphics.FillRectangle(gradientBrush, rect)
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On startup, open then hide all the base screens. This is to have smoother transitions.

        'base_alarms.Show()
        '.Visible = False
        base_home.Show()
        base_home.Visible = False
        base_io.Show()
        base_io.Visible = False
        base_io_2.Show()
        base_io_2.Visible = False
        base_load.Show()
        base_load.Visible = False
        base_rec_edit.Show()
        base_rec_edit.Visible = False
        base_results.Show()
        base_results.Visible = False
        'base_sec.Show()
        'base_sec.Visible = False
        base_settings.Show()
        base_settings.Visible = False

        Me.Show()

        '_inactiveTimeRetriever = New cIdleTimeStool

    End Sub


    


    Private Sub OpnPg2Btn_Click(sender As Object, e As EventArgs)
        p1_home.Show()
    End Sub

    Private Sub QuickStartLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Pg1exitButton_Click(sender As Object, e As EventArgs)
        base_home.Show()
        Me.Visible = False
    End Sub

    Private Sub BasicButton1_Click(sender As Object, e As EventArgs)
        Me.Visible = False
    End Sub

    Private Sub PictureBox_key_Click(sender As Object, e As EventArgs) Handles PictureBox_key.Click
        pop_log_in_out.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub


    'Set the PLC variable containing the security level to zero
    Private Sub SecLevelZero()
        PlcDriverUtilities.WritePlcValue("HMI.SecurityLevel", 0, EthernetIPforCLXCom1)
    End Sub



   
   


    Private Sub AlmInd_Click(sender As Object, e As EventArgs) Handles AlmInd.Click

    End Sub


End Class
