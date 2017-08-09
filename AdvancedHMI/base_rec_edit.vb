Imports Somex.Roburst.Integration.Common


Public Class base_rec_edit

    Private _selectedLanguage As LanguageManager.SupportedLanguages = 0
    Private _currentProfile As ProfileDetails


    '*******************************************************************************
    '* Stop polling when the form is not visible in order to reduce communications
    '* Copy this section of code to every new form created
    '*******************************************************************************
    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged

        EthernetIPforCLXCom1.DisableSubscriptions = Not Me.Visible

        AlarmsActive(base_home.AlmInd.Visible)

        If _selectedLanguage <> base_home.SelectedLanguage Then
            _selectedLanguage = base_home.SelectedLanguage
            LanguageManager.TranslateControlsFor(Me, _selectedLanguage)
        End If

        ' show/hide keyboard
        If (Me.Visible) Then

            ' reload the profile
            _currentProfile = ProfileManager.FirstProfile()
            LoadProfilesToListBox()
            LoadProfileDetailsForIndex(_currentProfile)
        Else
            OnScreenKeyBoardViewer.CloseOnScreenKeyboard()
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


    Private Sub DataSubscriber_results_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs)
        If e.Values(0) Then
            base_results.Show()
            Me.Visible = False
        End If
    End Sub


    Private Sub PgOpenHomeButton_Click(sender As Object, e As EventArgs)
        base_home.Show()
        Me.Visible = False
    End Sub

    Private Sub OSKbtn_Click(sender As Object, e As EventArgs)
        rec_name_edit.Show()
    End Sub

    Private Sub RecSaveBtn_Click(sender As Object, e As EventArgs) Handles RecSaveBasicButton.Click

        SaveProfile()

    End Sub

    Private Sub PictureBox_key_Click(sender As Object, e As EventArgs) Handles PictureBox_key.Click
        pop_log_in_out.Show()
    End Sub

    Private Sub BasicButton3_Click(sender As Object, e As EventArgs) Handles PgOpenHomeButton.Click
        base_home.Show()
        Me.Visible = False
    End Sub

    Private Sub BasicButton7_Click(sender As Object, e As EventArgs)
        base_home.Show()
        Me.Visible = False
    End Sub



    Private Sub AlmInd_Click_1(sender As Object, e As EventArgs) Handles AlmInd.Click
        base_alarms.Show()
        Me.Visible = False
    End Sub


    Private Sub LoadProfileDetailsForIndex(profileDetails As ProfileDetails)


        If (profileDetails Is Nothing) Then Return

        Me.BottleHeightTextBox.Text = profileDetails.BottleHeight
        Me.BottleLabelHeightTextBox.Text = profileDetails.LabelHeight
        Me.BottleFinishHeightTextBox.Text = profileDetails.FinishHeight
        Me.BottleVolumeTextBox.Text = profileDetails.BottleVolume
        Me.LowBurstTextBox.Text = profileDetails.LowBurstValue
        Me.NeckGripTextBox.Text = profileDetails.NeckBurstSize
        Me.LineNumberTextBox.Text = profileDetails.LineNumber

        Me.PressureUnitBarRadioButton.Checked = IIf(profileDetails.PressureUnits.ToLower() = "barg", True, False)
        Me.PressureUnitPsiRadioButton.Checked = IIf(profileDetails.PressureUnits.ToLower() = "psi", True, False)
        Me.PressureUnitKgcm2RadioButton.Checked = IIf(profileDetails.PressureUnits.ToLower() = "kg/cm2", True, False)

        Me.P60RadioButton.Checked = IIf(profileDetails.P60orPr.ToLower() = "p60", True, False)
        Me.PrRadioButton.Checked = IIf(profileDetails.P60orPr.ToLower() = "pr", True, False)

        Me.PlaceHeightAdjustmentTextBox.Text = profileDetails.ContainerPlaceHeightAdjustment
        Me.PressureSetpoint1TextBox.Text = profileDetails.PressureSetpoint1
        Me.RampRate1TextBox.Text = profileDetails.RampRate1
        Me.DwellTime1TextBox.Text = profileDetails.DwellTime1
        Me.PressureSetpoint2TextBox.Text = profileDetails.PressureSetpoint2
        Me.RampRate2TextBox.Text = profileDetails.RampRate2
        Me.DwellTime2TextBox.Text = profileDetails.DwellTime2
        Me.ProfileNameTextBox.Text = profileDetails.Name
        Me.PressureSetPointUnitKgSqCmBasicLabel.Text = profileDetails.PressureUnits
        Me.LowBurstValueUnitKgSqCmBasicLabel.Text = profileDetails.PressureUnits
        Me.RampRateUnitKgSqCmPerSecBasicLabel.Text = profileDetails.PressureUnits & "\s"

        ' if presssure unit is BAR then we have ramp rate units in barG\s
        If (profileDetails.PressureUnits.ToLower() = "barg") Then
            Me.RampRateUnitKgSqCmPerSecBasicLabel.Text = "BarG\s"

        End If

        'Me.RecNumbDisplay.Text = profileDetails.Number

    End Sub


    ''' <summary>
    ''' Attaches error provider to first control it checks which fails validation. 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ValidateData() As Boolean

        Me.DataEntryErrorProvider.Clear()

        Dim conversionOutput As Single
        Dim tryParseStatus As Boolean

        If (String.IsNullOrEmpty(Me.ProfileNameTextBox.Text)) Then
            Me.DataEntryErrorProvider.SetError(Me.ProfileNameTextBox, "Invalid Data")
            Return False
        End If
        tryParseStatus = Single.TryParse(Me.BottleHeightTextBox.Text, conversionOutput)
        If (Not tryParseStatus Or conversionOutput < 0) Then
            Me.DataEntryErrorProvider.SetError(Me.BottleHeightTextBox, "Invalid Data")
            Return False
        End If

        tryParseStatus = Single.TryParse(Me.BottleVolumeTextBox.Text, conversionOutput)
        If (Not tryParseStatus Or conversionOutput < 0) Then
            Me.DataEntryErrorProvider.SetError(Me.BottleVolumeTextBox, "Invalid Data")
            Return False
        End If

        tryParseStatus = Single.TryParse(Me.PlaceHeightAdjustmentTextBox.Text, conversionOutput)
        If (Not tryParseStatus) Then
            Me.DataEntryErrorProvider.SetError(Me.PlaceHeightAdjustmentTextBox, "Invalid Data")
            Return False
        End If

        tryParseStatus = Single.TryParse(Me.DwellTime1TextBox.Text, conversionOutput)
        If (Not tryParseStatus Or conversionOutput < 0) Then
            Me.DataEntryErrorProvider.SetError(Me.DwellTime1TextBox, "Invalid Data")
            Return False
        End If

        tryParseStatus = Single.TryParse(Me.DwellTime2TextBox.Text, conversionOutput)
        If (Not tryParseStatus Or conversionOutput < 0) Then
            Me.DataEntryErrorProvider.SetError(Me.DwellTime2TextBox, "Invalid Data")
            Return False
        End If

        tryParseStatus = Single.TryParse(Me.BottleFinishHeightTextBox.Text, conversionOutput)
        If (Not tryParseStatus Or conversionOutput < 0) Then
            Me.DataEntryErrorProvider.SetError(Me.BottleFinishHeightTextBox, "Invalid Data")
            Return False
        End If

        tryParseStatus = Single.TryParse(Me.BottleLabelHeightTextBox.Text, conversionOutput)
        If (Not tryParseStatus Or conversionOutput < 0) Then
            Me.DataEntryErrorProvider.SetError(Me.BottleLabelHeightTextBox, "Invalid Data")
            Return False
        End If

        tryParseStatus = Single.TryParse(Me.LineNumberTextBox.Text, conversionOutput)
        If (Not tryParseStatus) Then
            Me.DataEntryErrorProvider.SetError(Me.LineNumberTextBox, "Invalid Data")
            Return False
        End If

        tryParseStatus = Single.TryParse(Me.LowBurstTextBox.Text, conversionOutput)
        If (Not tryParseStatus Or conversionOutput < 0) Then
            Me.DataEntryErrorProvider.SetError(Me.LowBurstTextBox, "Invalid Data")
            Return False
        End If

        tryParseStatus = Single.TryParse(Me.NeckGripTextBox.Text, conversionOutput)
        If (Not tryParseStatus Or conversionOutput < 0) Then
            Me.DataEntryErrorProvider.SetError(Me.NeckGripTextBox, "Invalid Data")
            Return False
        End If

        tryParseStatus = Single.TryParse(Me.PressureSetpoint1TextBox.Text, conversionOutput)
        If (Not tryParseStatus Or conversionOutput < 0) Then
            Me.DataEntryErrorProvider.SetError(Me.PressureSetpoint1TextBox, "Invalid Data")
            Return False
        End If

        tryParseStatus = Single.TryParse(Me.PressureSetpoint2TextBox.Text, conversionOutput)
        If (Not tryParseStatus Or conversionOutput < 0) Then
            Me.DataEntryErrorProvider.SetError(Me.PressureSetpoint2TextBox, "Invalid Data")
            Return False
        End If

        tryParseStatus = Single.TryParse(Me.RampRate1TextBox.Text, conversionOutput)
        If (Not tryParseStatus Or conversionOutput < 0) Then
            Me.DataEntryErrorProvider.SetError(Me.RampRate1TextBox, "Invalid Data")
            Return False
        End If

        tryParseStatus = Single.TryParse(Me.RampRate2TextBox.Text, conversionOutput)
        If (Not tryParseStatus Or conversionOutput < 0) Then
            Me.DataEntryErrorProvider.SetError(Me.RampRate2TextBox, "Invalid Data")
            Return False
        End If

        Return True



    End Function

    Private Sub SaveProfile()

        Try

            ' validate the text entries
            '
            Dim isDataValid = ValidateData()
            If (Not isDataValid) Then Return


            If (MessageBox.Show(LanguageManager.GetUserMessage(LanguageManager.UserMessages.ConfirmSaveProfile) & " " & Me.ProfileNameTextBox.Text & "?", "", _
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
                Return
            End If

            ' update properties
            Me._currentProfile.Name = Me.ProfileNameTextBox.Text
            Me._currentProfile.BottleHeight = Convert.ToDouble(Me.BottleHeightTextBox.Text)
            Me._currentProfile.BottleVolume = Convert.ToDouble(Me.BottleVolumeTextBox.Text)
            Me._currentProfile.ContainerPlaceHeightAdjustment = Convert.ToDouble(Me.PlaceHeightAdjustmentTextBox.Text)
            Me._currentProfile.DwellTime1 = Convert.ToDouble(Me.DwellTime1TextBox.Text)
            Me._currentProfile.DwellTime2 = Convert.ToDouble(Me.DwellTime2TextBox.Text)
            Me._currentProfile.FinishHeight = Convert.ToDouble(Me.BottleFinishHeightTextBox.Text)
            Me._currentProfile.LabelHeight = Convert.ToDouble(Me.BottleLabelHeightTextBox.Text)
            Me._currentProfile.LineNumber = Convert.ToDouble(Me.LineNumberTextBox.Text)
            Me._currentProfile.LowBurstValue = Convert.ToDouble(Me.LowBurstTextBox.Text)
            Me._currentProfile.NeckBurstSize = Convert.ToDouble(Me.NeckGripTextBox.Text)
            'Me._currentProfile.Number = Me.RecNumbDisplay.Text
            Me._currentProfile.P60orPr = IIf(Me.P60RadioButton.Checked, "p60", "pr")
            Me._currentProfile.PressureSetpoint1 = Convert.ToDouble(Me.PressureSetpoint1TextBox.Text)
            Me._currentProfile.PressureSetpoint2 = Convert.ToDouble(Me.PressureSetpoint2TextBox.Text)
            Me._currentProfile.RampRate1 = Convert.ToDouble(Me.RampRate1TextBox.Text)
            Me._currentProfile.RampRate2 = Convert.ToDouble(Me.RampRate2TextBox.Text)
            Me._currentProfile.LineNumber = Me.LineNumberTextBox.Text

            If (Me.PressureUnitBarRadioButton.Checked) Then Me._currentProfile.PressureUnits = "barG"
            If (Me.PressureUnitPsiRadioButton.Checked) Then Me._currentProfile.PressureUnits = "psi"
            If (Me.PressureUnitKgcm2RadioButton.Checked) Then Me._currentProfile.PressureUnits = "kg/cm2"


            ' persist the profile
            ProfileManager.SaveProfile(Me._currentProfile)

            MessageBox.Show(String.Format(LanguageManager.GetUserMessage(LanguageManager.UserMessages.ProfileSaveComplete), Me._currentProfile.Number), "", _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadProfilesToListBox()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub




    Private Sub CopyProfileButton_Click(sender As Object, e As EventArgs) Handles CopyProfileButton.Click

        Try

            Dim promptScreen As pop_profile_number = New pop_profile_number()

            OnScreenKeyBoardViewer.ShowOnScreenKeyboard()

            ' prompt user for new profile number
            Dim dialogResult As DialogResult = promptScreen.ShowDialog()
            If (dialogResult = Windows.Forms.DialogResult.Cancel) Then Return

            ' store new number and update the ui
            Dim newNumber As String = promptScreen.NewProfileNumberTextBox.Text
            If (String.IsNullOrEmpty(newNumber)) Then Return

            'Me.RecNumbDisplay.Text = newNumber

            ' just clear the profile name
            Me.ProfileNameTextBox.Text = ""

            Me._currentProfile = New ProfileDetails()
            Me._currentProfile.Number = newNumber

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            OnScreenKeyBoardViewer.CloseOnScreenKeyboard()
        End Try


    End Sub



    Private Sub base_rec_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler base_home.AlarmsActive, AddressOf AlarmsActive
    End Sub
    Private Sub AlarmsActive(alarmState As Boolean)
        AlmInd.Visible = alarmState
    End Sub

    Private Sub NewRecipeButton_Click(sender As Object, e As EventArgs) Handles NewRecipeButton.Click

        Try

            OnScreenKeyBoardViewer.ShowOnScreenKeyboard()

            Dim promptScreen As pop_profile_number = New pop_profile_number()

            ' prompt user for new profile number
            Dim dialogResult As DialogResult = promptScreen.ShowDialog()
            If (dialogResult = Windows.Forms.DialogResult.Cancel) Then Return

            ' store new number and update the ui
            Dim number As String = promptScreen.NewProfileNumberTextBox.Text
            If (String.IsNullOrEmpty(number)) Then Return

            ' update the current number displayed
            'Me.RecNumbDisplay.Text = number

            ' reset all fields
            ClearAllFields()

            Me._currentProfile = New ProfileDetails()
            Me._currentProfile.Number = number

            Me.LineNumberTextBox.Text = HmiSettingsResolver.GetSettingValue("Misc", "DefaultLineNumber")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            OnScreenKeyBoardViewer.CloseOnScreenKeyboard()
        End Try


    End Sub


    Private Sub ClearAllFields()

        Me.BottleHeightTextBox.Text = 0
        Me.BottleLabelHeightTextBox.Text = 0
        Me.BottleFinishHeightTextBox.Text = 0
        Me.BottleVolumeTextBox.Text = 0
        Me.LowBurstTextBox.Text = 0
        Me.NeckGripTextBox.Text = 0
        Me.PressureUnitBarRadioButton.Checked = True
        Me.P60RadioButton.Checked = True

        Me.PlaceHeightAdjustmentTextBox.Text = 0
        Me.PressureSetpoint1TextBox.Text = 0
        Me.RampRate1TextBox.Text = 0
        Me.DwellTime1TextBox.Text = 0
        Me.PressureSetpoint2TextBox.Text = 0
        Me.RampRate2TextBox.Text = 0
        Me.DwellTime2TextBox.Text = 0
        Me.ProfileNameTextBox.Text = ""

    End Sub

    Private Sub DeleteProfileButton_Click(sender As Object, e As EventArgs) Handles DeleteProfileButton.Click

        Try

            If (_currentProfile Is Nothing) Then Return
            If (_currentProfile.UID = 0) Then Return

            ProfileManager.DeleteProfile(_currentProfile)
            LoadProfilesToListBox()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub PressureUnitBarRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles PressureUnitBarRadioButton.CheckedChanged

        If (Me.PressureUnitBarRadioButton.Checked) Then
            PressureSetPointUnitKgSqCmBasicLabel.Text = "barG"
            LowBurstValueUnitKgSqCmBasicLabel.Text = "barG"
            RampRateUnitKgSqCmPerSecBasicLabel.Text = "barG/s"

        End If


    End Sub

    Private Sub PressureUnitPsiRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles PressureUnitPsiRadioButton.CheckedChanged
        If (Me.PressureUnitPsiRadioButton.Checked) Then
            PressureSetPointUnitKgSqCmBasicLabel.Text = "psi"
            LowBurstValueUnitKgSqCmBasicLabel.Text = "psi"
            RampRateUnitKgSqCmPerSecBasicLabel.Text = "psi/s"

        End If
    End Sub

    Private Sub PressureUnitKgcm2RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles PressureUnitKgcm2RadioButton.CheckedChanged

        If (Me.PressureUnitKgcm2RadioButton.Checked) Then
            PressureSetPointUnitKgSqCmBasicLabel.Text = "kg/cm2"
            LowBurstValueUnitKgSqCmBasicLabel.Text = "kg/cm2"
            RampRateUnitKgSqCmPerSecBasicLabel.Text = "kg/cm2/s"

        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        Try

            Dim listBox As ListBox = sender

            Dim matchingProfile As ProfileDetails = Nothing

            matchingProfile = ProfileManager.GetProfileForNumber(listBox.SelectedItem.ToString())


            If (matchingProfile Is Nothing OrElse matchingProfile.UID = _currentProfile.UID) Then Return

            LoadProfileDetailsForIndex(matchingProfile)

            _currentProfile = matchingProfile

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        LoadProfilesToListBox()
    End Sub

    Private Sub LoadProfilesToListBox()

        Try

            Dim textBox As TextBox = TextBox1
            Dim profiles As List(Of String)
            Dim parsedText As Integer = 0

            If (textBox.Text Is Nothing) Then
                textBox.Text = ""
            End If

            profiles = ProfileManager.GetProfilesByName(textBox.Text)

            ListBox1.Items.Clear()

            For Each element As String In profiles
                ListBox1.Items.Add(element)
            Next

            If ListBox1.Items.Count > 0 Then
                ListBox1.SelectedIndex = 0
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
