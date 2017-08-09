Imports Somex.Roburst.Integration.Common


Public Class base_load


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

        If (Me.Visible) Then

            ' get distinct line numbers and popular combo box
            Dim distinctLines = ProfileManager.GetListOfDistinctLines()
            Me.LinesComboBox.Items.Clear()
            Me.LinesComboBox.Items.Add("All")
            distinctLines.ForEach(Sub(line As Integer) Me.LinesComboBox.Items.Add(line))

            ' set the default line number in combox box, of the first index if default isn't found
            Me.LinesComboBox.SelectedItem = "All"

            ' prime the auto complete text box for potentially new profiles 
            LoadAutoCompleteProfiles(Me.LinesComboBox.SelectedItem)

            If (Me.LinesComboBox.SelectedItem Is Nothing OrElse Me.LinesComboBox.SelectedItem = "All") Then
                _currentProfile = ProfileManager.FirstProfile()
            Else
                _currentProfile = ProfileManager.FirstProfile(Convert.ToInt32(Me.LinesComboBox.SelectedItem))
            End If


        End If

        LoadProfilesToListBox()




    End Sub


    Private Sub AlmInd_Click(sender As Object, e As EventArgs)
        base_alarms.Show()
        Me.Visible = False
    End Sub

    Private Sub LoadAutoCompleteProfiles(line As Object)

        Dim numbers As String() = Nothing

        If (line Is Nothing OrElse line.ToString = "All") Then
            numbers = ProfileManager.GetAllProfileNumbers().ToArray()
        Else
            numbers = ProfileManager.GetProfileNumbersFor(line).ToArray()
        End If

        Dim autoComplete As AutoCompleteStringCollection = New AutoCompleteStringCollection()
        autoComplete.AddRange(numbers)
        ' Me.ProfileNumberTextBox.AutoCompleteCustomSource = autoComplete
    End Sub



    Private Sub PgOpenHomeButton_Click(sender As Object, e As EventArgs) Handles PgOpenHomeButton.Click
        base_home.Show()
        Me.Visible = False
    End Sub

    Private Sub RecLoadBtn_Click(sender As Object, e As EventArgs)


        Try

            PlcDriverUtilities.PulsePlcTag("Profile_Load", True, Me.EthernetIPforCLXCom1)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Me.Visible = False
        base_home.Show()
        pop_rec_loaded.Show()

    End Sub

    Private Sub BasicButton1_Click(sender As Object, e As EventArgs)
        Me.Visible = False
        base_rec_edit.Show()
    End Sub

    Private Sub PictureBox_key_Click(sender As Object, e As EventArgs) Handles PictureBox_key.Click
        pop_log_in_out.Show()
    End Sub


    ''' <summary>
    ''' The user can change the selected recipe by entering a new value using the
    ''' AdvancedHMI keypad. But there is nothing to alert the PLC that a different record
    ''' has been selected. The PLC uses the left and right arrow clicks to copy from the array of profiles
    ''' to the active profile record. 
    ''' We're monitoring the ValueChanged event and pulsing the tag HMI_LoadEnter, forcing PLC to do an array
    ''' copy. 
    ''' It will result in unnecessary copies in the PLC as there are multiple ways the label value can change
    ''' KCarey 23 July 2015
    ''' </summary>
    Private Sub RecNumDisplay_Changed(sender As Object, e As EventArgs)

        If (Me.InvokeRequired) Then

            Me.Invoke(New MethodInvoker(AddressOf PulseRecipeChange))
        Else
            PulseRecipeChange()
        End If

    End Sub

    Private Sub PulseRecipeChange()

        Try
            PlcDriverUtilities.PulsePlcTag("HMI_LoadEnter", True, Me.EthernetIPforCLXCom1)
        Catch ex As Exception
            ' ignore catch , windows handle doesn't exist
        End Try


    End Sub

    Private Sub AlmInd_Click_1(sender As Object, e As EventArgs) Handles AlmInd.Click
        base_alarms.Show()
        Me.Visible = False
    End Sub



    Private Sub LoadProfileDetailsForIndex(profileDetails As ProfileDetails)

        If (profileDetails Is Nothing) Then Return

        Me.OverallBottleHeightValueLabel.Text = profileDetails.BottleHeight
        Me.LabelHeightValueLabel.Text = profileDetails.LabelHeight
        Me.FinishHeightValueLabel.Text = profileDetails.FinishHeight
        Me.VolumeValueLabel.Text = profileDetails.BottleVolume
        Me.LowBurstValueValueLabel.Text = profileDetails.LowBurstValue
        Me.NeckGripValueLabel.Text = profileDetails.NeckBurstSize
        Me.PressureUnitsValueKgSqCmBasicLabel.Text = profileDetails.PressureUnits
        Me.UseP60orPrValueLabel.Text = profileDetails.P60orPr
        Me.ContainerHeightAdjustmentValueLabel.Text = profileDetails.ContainerPlaceHeightAdjustment
        Me.PressureSetPointPhase1ValueBasicLabel.Text = profileDetails.PressureSetpoint1
        Me.RampRatePhase1ValueBasicLabel.Text = profileDetails.RampRate1
        Me.DwellTimePhase1ValueBasicLabel.Text = profileDetails.DwellTime1
        Me.PressureSetPointPhase2ValueBasicLabel.Text = profileDetails.PressureSetpoint2
        Me.RampRatePhase2ValueBasicLabel.Text = profileDetails.RampRate2
        Me.DwellTimePhase2ValueBasicLabel.Text = profileDetails.DwellTime2
        Me.ProfileNameLabel.Text = profileDetails.Name
        Me.PressureSetPointUnitLabel.Text = profileDetails.PressureUnits
        Me.LowBurstValueUnitLabel.Text = profileDetails.PressureUnits
        Me.RampRateUnitsPerSecLabel.Text = profileDetails.PressureUnits & "\s"
        Me.RampRateUnitsPerSecLabel2.Text = RampRateUnitsPerSecLabel.Text
        Me.PressureSetPointUnitLabel2.Text = PressureSetPointUnitLabel.Text

        ' if presssure unit is BAR then we have ramp rate units in barG\s
        If (profileDetails.PressureUnits.ToLower() = "barg") Then
            Me.RampRateUnitsPerSecLabel.Text = "BarG\s"
        End If

        '     Me.ProfileNumberTextBox.Text = profileDetails.Number.ToString()

    End Sub



    Private Sub RecUpButton_Click(sender As Object, e As EventArgs)

        Try


            Dim line As Object = Me.LinesComboBox.SelectedItem

            If (line.ToString() = "All") Then
                If (_currentProfile.UID = ProfileManager.LastProfile().UID) Then
                    _currentProfile = ProfileManager.FirstProfile()
                Else
                    _currentProfile = ProfileManager.GetNextProfileNumber(_currentProfile)
                End If
            Else

                If (_currentProfile.UID = ProfileManager.LastProfile(Convert.ToInt32(line)).UID) Then
                    _currentProfile = ProfileManager.FirstProfile(Convert.ToInt32(line))
                Else
                    _currentProfile = ProfileManager.GetNextProfileNumber(_currentProfile, Convert.ToInt32(line))
                End If

            End If


            LoadProfileDetailsForIndex(_currentProfile)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

        End Try


    End Sub

    Private Sub RecDownButton_Click_1(sender As Object, e As EventArgs)

        Try


            Dim line As Object = Me.LinesComboBox.SelectedItem

            If (line.ToString() = "All") Then


                If (_currentProfile.UID = ProfileManager.FirstProfile().UID) Then
                    _currentProfile = ProfileManager.LastProfile()
                Else
                    _currentProfile = ProfileManager.GetPreviousProfile(_currentProfile)
                End If


            Else

                If (_currentProfile.UID = ProfileManager.FirstProfile(Convert.ToInt32(line)).UID) Then
                    _currentProfile = ProfileManager.LastProfile(line)
                Else
                    _currentProfile = ProfileManager.GetPreviousProfile(_currentProfile, Convert.ToInt32(line))
                End If

            End If


            LoadProfileDetailsForIndex(_currentProfile)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

        End Try

    End Sub

    Private Sub RecLoadBtn_Click_1(sender As Object, e As EventArgs) Handles RecLoadBtn.Click


        ' load the profile data in the PLC
        Try
            If (_currentProfile Is Nothing) Then Return

            '' ask user to confirm
            If (MessageBox.Show(LanguageManager.GetUserMessage(LanguageManager.UserMessages.ConfirmLoadingOfProfile) & " " & _currentProfile.Name, "", _
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then

                ProfileManager.LoadProfileInPLC(_currentProfile, Me.EthernetIPforCLXCom1)


                MessageBox.Show(LanguageManager.GetUserMessage(LanguageManager.UserMessages.ProfileLoadComplete), "", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try




    End Sub

    Private Sub LinesComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LinesComboBox.SelectedIndexChanged

        Try

            Dim line As Object = Me.LinesComboBox.SelectedItem

            If (line Is Nothing OrElse line.ToString() = "All") Then
                _currentProfile = ProfileManager.FirstProfile()
            Else
                _currentProfile = ProfileManager.FirstProfile(line)
            End If

            LoadProfileDetailsForIndex(_currentProfile)

            LoadAutoCompleteProfiles(line)

            TextBox1.Text = ""

            LoadProfilesToListBox()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub



    Private Sub base_load_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' subscribe to changes in the profile entry text box so we can load profiles as they type
        '      AddHandler Me.ProfileNumberTextBox.KeyDown, AddressOf ProfileNumberKeyDownHander

        '   Me.ProfileNumberTextBox.AutoCompleteMode = AutoCompleteMode.Suggest
        '   Me.ProfileNumberTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource
        AddHandler base_home.AlarmsActive, AddressOf AlarmsActive
    End Sub
    Private Sub AlarmsActive(alarmState As Boolean)
        AlmInd.Visible = alarmState
    End Sub



    Private Sub ProfileNumberKeyDownHander(sender As Object, e As KeyEventArgs)

        Try
            Dim profileNumberTextBox As TextBox = CType(sender, TextBox)
            Dim line As Object = Me.LinesComboBox.SelectedItem

            ' only process if user has entered CRLF. 
            ' if no CRLF is present then this change is due to user pressing LEFT-RIGHT select buttons
            If (Not e.KeyCode = Keys.Return) Then Return
            If (String.IsNullOrEmpty(profileNumberTextBox.Text)) Then Return

            ' get matching profile for number and line
            Dim matchingProfile As ProfileDetails = Nothing
            If (line Is Nothing OrElse line.ToString = "All") Then
                matchingProfile = ProfileManager.GetProfileForNumber(profileNumberTextBox.Text)
            Else
                matchingProfile = ProfileManager.GetProfileForNumber(profileNumberTextBox.Text, Convert.ToInt32(line))
            End If

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

    Private Sub LoadProfilesToListBox()

        Try

            Dim textBox As TextBox = TextBox1
            Dim profiles As List(Of String)
            Dim parsedText As Integer = 0

            If (textBox.Text Is Nothing) Then
                textBox.Text = ""
            End If

            Dim line As ComboBox = Me.LinesComboBox

            If (Not line.SelectedItem Is Nothing And Integer.TryParse(line.SelectedItem, parsedText)) Then
                profiles = ProfileManager.GetProfilesByName(textBox.Text, parsedText)
            Else
                profiles = ProfileManager.GetProfilesByName(textBox.Text)
            End If
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
