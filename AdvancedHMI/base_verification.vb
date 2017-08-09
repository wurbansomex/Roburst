

Public Class base_verification

    Private _selectedLanguage As LanguageManager.SupportedLanguages = 0
    Private verificationStepNumber As Integer

    '*******************************************************************************
    '* Stop polling when the form is not visible in order to reduce communications
    '* Copy this section of code to every new form created
    '*******************************************************************************
    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged


        EthernetIPforCLXCom1.DisableSubscriptions = Not Me.Visible

        AlarmsActive(base_home.AlmInd.Visible)

        ' reset verification step and tags when form is displayed
        If _selectedLanguage <> base_home.SelectedLanguage Then
            _selectedLanguage = base_home.SelectedLanguage
            LanguageManager.TranslateControlsFor(Me, _selectedLanguage)
        End If

        Me.verificationStepNumber = 1
        UpdatePLCTagsForNewVerificationStep()
        Me.CurrentStepNumberLabel1.Text = Me.verificationStepNumber.ToString()
        Me.CurrentStepNumberLabel2.Text = Me.verificationStepNumber.ToString()
        Me.PreviousStepBasicButton.Enabled = False
        Me.NextVerificationBasicButton.Enabled = True

        AddHandler base_home.AlarmsActive, AddressOf AlarmsActive
    End Sub

    Private Sub AlarmsActive(alarmState As Boolean)
        AlmInd.Visible = alarmState
    End Sub



    ''' <summary>
    ''' Updates the SP, System and Gauge tags for next verification step
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub UpdatePLCTagsForNewVerificationStep()
        Me.PressureSetPointBasicLabel.PLCAddressKeypad = "CalVer.Edit_SP" & Me.verificationStepNumber.ToString()
        Me.PressureSetPointBasicLabel.PLCAddressValue = "CalVer.Edit_SP" & Me.verificationStepNumber.ToString()

        Me.PressureSystemReadingBasicLabel.PLCAddressValue = "CalVer.Edit_System" & Me.verificationStepNumber.ToString()

        Me.PressureGaugeReadingBasicLabel.PLCAddressKeypad = "CalVer.Edit_Gauge" & Me.verificationStepNumber.ToString()
        Me.PressureGaugeReadingBasicLabel.PLCAddressValue = "CalVer.Edit_Gauge" & Me.verificationStepNumber.ToString()

        ' write the current step number to the PLC
        PlcDriverUtilities.WritePlcValue("CalVerification.Dint[0]", Me.verificationStepNumber, EthernetIPforCLXCom1)

    End Sub



    Private Sub PgOpenHomeButton_Click(sender As Object, e As EventArgs) Handles PgOpenHomeButton.Click
        base_home.Show()
        Me.Visible = False
    End Sub

    Private Sub PictureBox_key_Click(sender As Object, e As EventArgs) Handles PictureBox_key.Click
        pop_log_in_out.Show()
    End Sub

    Private Sub AlmInd_Click_1(sender As Object, e As EventArgs) Handles AlmInd.Click
        base_alarms.Show()
        Me.Visible = False
    End Sub


    Private Sub NextVerificationBasicButton_Click(sender As Object, e As EventArgs) Handles NextVerificationBasicButton.Click

        Try

            Me.verificationStepNumber += 1
            UpdatePLCTagsForNewVerificationStep()
            Me.CurrentStepNumberLabel1.Text = Me.verificationStepNumber.ToString()
            Me.CurrentStepNumberLabel2.Text = Me.verificationStepNumber.ToString()

            If (Me.verificationStepNumber = 4) Then
                Me.NextVerificationBasicButton.Enabled = False
            End If

            Me.PreviousStepBasicButton.Enabled = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub PreviousStepBasicButton_Click(sender As Object, e As EventArgs) Handles PreviousStepBasicButton.Click

        Me.verificationStepNumber -= 1
        UpdatePLCTagsForNewVerificationStep()
        Me.CurrentStepNumberLabel1.Text = Me.verificationStepNumber.ToString()
        Me.CurrentStepNumberLabel2.Text = Me.verificationStepNumber.ToString()

        If (Me.verificationStepNumber = 1) Then
            Me.PreviousStepBasicButton.Enabled = False
        End If

        Me.NextVerificationBasicButton.Enabled = True

    End Sub

    ''' <summary>
    ''' Append Step 1..4 to CSV file
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SaveVerificationBasicButton_Click(sender As Object, e As EventArgs) Handles SaveVerificationBasicButton.Click

        Try

            Dim resultDirectory As String = "C:\Somex\HMI Data\Results"
            Dim resultExport As ResultExporter = New ResultExporter()

            Dim gaugeSerialNumber As String = PlcDriverUtilities.ReadPLCValue(Of String)("CalVer.Edit_Serial", Me.EthernetIPforCLXCom1)

            Dim step1SetPoint As String = PlcDriverUtilities.ReadPLCValue(Of String)("CalVer.Edit_SP1", Me.EthernetIPforCLXCom1)
            Dim step1System As String = PlcDriverUtilities.ReadPLCValue(Of String)("CalVer.Edit_System1", Me.EthernetIPforCLXCom1)
            Dim step1Gauge As String = PlcDriverUtilities.ReadPLCValue(Of String)("CalVer.Edit_Gauge1", Me.EthernetIPforCLXCom1)

            Dim step2SetPoint As String = PlcDriverUtilities.ReadPLCValue(Of String)("CalVer.Edit_SP2", Me.EthernetIPforCLXCom1)
            Dim step2System As String = PlcDriverUtilities.ReadPLCValue(Of String)("CalVer.Edit_System2", Me.EthernetIPforCLXCom1)
            Dim step2Gauge As String = PlcDriverUtilities.ReadPLCValue(Of String)("CalVer.Edit_Gauge2", Me.EthernetIPforCLXCom1)

            Dim step3SetPoint As String = PlcDriverUtilities.ReadPLCValue(Of String)("CalVer.Edit_SP3", Me.EthernetIPforCLXCom1)
            Dim step3System As String = PlcDriverUtilities.ReadPLCValue(Of String)("CalVer.Edit_System3", Me.EthernetIPforCLXCom1)
            Dim step3Gauge As String = PlcDriverUtilities.ReadPLCValue(Of String)("CalVer.Edit_Gauge3", Me.EthernetIPforCLXCom1)

            Dim step4SetPoint As String = PlcDriverUtilities.ReadPLCValue(Of String)("CalVer.Edit_SP4", Me.EthernetIPforCLXCom1)
            Dim step4System As String = PlcDriverUtilities.ReadPLCValue(Of String)("CalVer.Edit_System4", Me.EthernetIPforCLXCom1)
            Dim step4Gauge As String = PlcDriverUtilities.ReadPLCValue(Of String)("CalVer.Edit_Gauge4", Me.EthernetIPforCLXCom1)

            resultExport.AppendVerificationREsultsToCSV(resultDirectory,
                                                        gaugeSerialNumber,
                                                        step1SetPoint, step1System, step1Gauge,
                                                        step2SetPoint, step2System, step2Gauge,
                                                        step3SetPoint, step3System, step3Gauge,
                                                        step4SetPoint, step4System, step4Gauge)

            MessageBox.Show(LanguageManager.GetUserMessage(LanguageManager.UserMessages.RemoveThePressureGauge), _
                            LanguageManager.GetUserMessage(LanguageManager.UserMessages.RemoveGauge), MessageBoxButtons.OK)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub



    Private Sub CancelVerificationBasicButton_Click(sender As Object, e As EventArgs) Handles CancelVerificationBasicButton.Click
        MessageBox.Show(LanguageManager.GetUserMessage(LanguageManager.UserMessages.RemoveThePressureGauge), _
                        LanguageManager.GetUserMessage(LanguageManager.UserMessages.RemoveGauge), MessageBoxButtons.OK)
    End Sub

    Private Sub base_verification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler base_home.AlarmsActive, AddressOf AlarmsActive
    End Sub
End Class
