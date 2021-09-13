Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class FormChangePersonalInfo
    Sub ClearErrorProvider()
        Dim formControl As Control
        Dim txtBox As TextBox
        Dim comBox As ComboBox
        For Each formControl In Me.Controls
            If TypeOf formControl Is TextBox Then
                txtBox = TryCast(formControl, TextBox)
                ErrorProviderOK.SetError(txtBox, "")
                ErrorProviderNO.SetError(txtBox, "")
            ElseIf TypeOf formControl Is ComboBox Then
                comBox = TryCast(formControl, ComboBox)
                ErrorProviderOK.SetError(comBox, "")
                ErrorProviderNO.SetError(comBox, "")
            End If
        Next
        ErrorProviderOK.SetError(TanggalLahirDateTimePicker, "")
        ErrorProviderNO.SetError(TanggalLahirDateTimePicker, "")
    End Sub

    Private Sub FormChangePersonalInfo_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        NIPTextBox.MaxLength = 18
        TeleponTextBox.MaxLength = 13
        TanggalLahirDateTimePicker.Format = DateTimePickerFormat.Custom
        TanggalLahirDateTimePicker.CustomFormat = "dd MMMM yyyy"
    End Sub

    Private Sub FormChangePersonalInfo_Load(sender As Object, e As EventArgs) Handles Me.Load
        NIPTextBox.Text = UserInformationForm.NIPLabel.Text
        NamaTextBox.Text = UserInformationForm.NamaLabel.Text
        TempatLahirTextBox.Text = UserInformationForm.TempatLahirLabel.Text
        TanggalLahirDateTimePicker.Value = UserInformationForm.TanggalLahirLabel.Text
        JenisKelaminComboBox.Text = UserInformationForm.JenisKelaminLabel.Text
        AgamaComboBox.Text = UserInformationForm.AgamaLabel.Text
        TeleponTextBox.Text = UserInformationForm.TeleponLabel.Text
        EmailTextBox.Text = UserInformationForm.EmailLabel.Text
        AlamatTextBox.Text = UserInformationForm.AlamatLabel.Text
    End Sub

    Private Sub NIPTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NIPTextBox.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub NIPTextBox_Validating(sender As Object, e As CancelEventArgs) Handles NIPTextBox.Validating
        If NIPTextBox.Text = "" Then
            ErrorProviderOK.SetError(NIPTextBox, "Correct")
            ErrorProviderNO.SetError(NIPTextBox, "")
        ElseIf NIPTextBox.Text.Length < 18 Then
            ErrorProviderNO.SetError(NIPTextBox, "Isikan NIP dengan benar")
            ErrorProviderOK.SetError(NIPTextBox, "")
            e.Cancel = True
            Return
        Else
            ErrorProviderOK.SetError(NIPTextBox, "Correct")
            ErrorProviderNO.SetError(NIPTextBox, "")
        End If
    End Sub

    Private Sub NamaTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NamaTextBox.KeyPress
        If e.KeyChar = Chr(13) Then
            TempatLahirTextBox.Focus()
        End If
    End Sub

    Private Sub NamaTextBox_Validating(sender As Object, e As CancelEventArgs) Handles NamaTextBox.Validating
        If NamaTextBox.Text = "" Then
            ErrorProviderNO.SetError(NamaTextBox, "Must be filled")
            ErrorProviderOK.SetError(NamaTextBox, "")
            e.Cancel = True
            Return
        Else
            ErrorProviderOK.SetError(NamaTextBox, "Correct")
            ErrorProviderNO.SetError(NamaTextBox, "")
        End If
    End Sub

    Private Sub TempatLahirTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TempatLahirTextBox.KeyPress
        If e.KeyChar = Chr(13) Then
            TanggalLahirDateTimePicker.Focus()
        End If
    End Sub

    Private Sub TempatLahirTextBox_Validating(sender As Object, e As CancelEventArgs) Handles TempatLahirTextBox.Validating
        If TempatLahirTextBox.Text = "" Then
            ErrorProviderNO.SetError(TempatLahirTextBox, "Must be filled")
            ErrorProviderOK.SetError(TempatLahirTextBox, "")
            e.Cancel = True
            Return
        Else
            ErrorProviderOK.SetError(TempatLahirTextBox, "Correct")
            ErrorProviderNO.SetError(TempatLahirTextBox, "")
        End If
    End Sub

    Private Sub TanggalLahirDateTimePicker_Validating(sender As Object, e As CancelEventArgs) Handles TanggalLahirDateTimePicker.Validating
        If TanggalLahirDateTimePicker.Value.Date = Date.Today Then
            ErrorProviderNO.SetError(TanggalLahirDateTimePicker, "Choose Date of Birth")
            ErrorProviderOK.SetError(TanggalLahirDateTimePicker, "")
            e.Cancel = True
            Return
        ElseIf TanggalLahirDateTimePicker.Value.Date > Date.Today Then
            ErrorProviderNO.SetError(TanggalLahirDateTimePicker, "Pilih Tanggal Lahir Dengan Benar")
            ErrorProviderOK.SetError(TanggalLahirDateTimePicker, "")
            e.Cancel = True
            Return
        ElseIf TanggalLahirDateTimePicker.Value.Date > #01/01/2005# Then
            ErrorProviderNO.SetError(TanggalLahirDateTimePicker, "Pilih Tanggal Lahir Dengan Benar")
            ErrorProviderOK.SetError(TanggalLahirDateTimePicker, "")
            e.Cancel = True
            Return
        Else
            ErrorProviderOK.SetError(TanggalLahirDateTimePicker, "Correct")
            ErrorProviderNO.SetError(TanggalLahirDateTimePicker, "")
        End If
    End Sub

    Private Sub JenisKelaminComboBox_Validating(sender As Object, e As CancelEventArgs) Handles JenisKelaminComboBox.Validating
        If JenisKelaminComboBox.Text = "Laki - Laki" Then
            ErrorProviderOK.SetError(JenisKelaminComboBox, "Correct")
            ErrorProviderNO.SetError(JenisKelaminComboBox, "")
        ElseIf JenisKelaminComboBox.Text = "Perempuan" Then
            ErrorProviderOK.SetError(JenisKelaminComboBox, "Correct")
            ErrorProviderNO.SetError(JenisKelaminComboBox, "")
        ElseIf JenisKelaminComboBox.Text = "" Then
            ErrorProviderNO.SetError(JenisKelaminComboBox, "Must be filled")
            ErrorProviderOK.SetError(JenisKelaminComboBox, "")
            e.Cancel = True
            Return
        Else
            ErrorProviderNO.SetError(JenisKelaminComboBox, "Pilih jenis kelamin")
            ErrorProviderOK.SetError(JenisKelaminComboBox, "")
            e.Cancel = True
            Return
        End If
    End Sub

    Private Sub AgamaComboBox_Validating(sender As Object, e As CancelEventArgs) Handles AgamaComboBox.Validating
        If AgamaComboBox.Text = "Islam" Then
            ErrorProviderOK.SetError(AgamaComboBox, "Correct")
            ErrorProviderNO.SetError(AgamaComboBox, "")
        ElseIf AgamaComboBox.Text = "Katolik" Then
            ErrorProviderOK.SetError(AgamaComboBox, "Correct")
            ErrorProviderNO.SetError(AgamaComboBox, "")
        ElseIf AgamaComboBox.Text = "Protestan" Then
            ErrorProviderOK.SetError(AgamaComboBox, "Correct")
            ErrorProviderNO.SetError(AgamaComboBox, "")
        ElseIf AgamaComboBox.Text = "Hindu" Then
            ErrorProviderOK.SetError(AgamaComboBox, "Correct")
            ErrorProviderNO.SetError(AgamaComboBox, "")
        ElseIf AgamaComboBox.Text = "Buddha" Then
            ErrorProviderOK.SetError(AgamaComboBox, "Correct")
            ErrorProviderNO.SetError(AgamaComboBox, "")
        ElseIf AgamaComboBox.Text = "Khonghucu" Then
            ErrorProviderOK.SetError(AgamaComboBox, "Correct")
            ErrorProviderNO.SetError(AgamaComboBox, "")
        ElseIf AgamaComboBox.Text = "" Then
            ErrorProviderNO.SetError(AgamaComboBox, "Must be filled")
            ErrorProviderOK.SetError(AgamaComboBox, "")
            e.Cancel = True
            Return
        Else
            ErrorProviderNO.SetError(AgamaComboBox, "Pilih Agama")
            ErrorProviderOK.SetError(AgamaComboBox, "")
            e.Cancel = True
            Return
        End If
    End Sub

    Private Sub TeleponTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TeleponTextBox.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub TeleponTextBox_Validating(sender As Object, e As CancelEventArgs) Handles TeleponTextBox.Validating
        If TeleponTextBox.Text = "" Then
            ErrorProviderNO.SetError(TeleponTextBox, "Must be filled")
            ErrorProviderOK.SetError(TeleponTextBox, "")
            e.Cancel = True
            Return
        ElseIf TeleponTextBox.Text.Length < 12 Then
            ErrorProviderNO.SetError(TeleponTextBox, "Anda Yakin No Telepon Sudah Benar?")
            ErrorProviderOK.SetError(TeleponTextBox, "")
            e.Cancel = True
            Return
        Else
            ErrorProviderOK.SetError(TeleponTextBox, "Correct")
            ErrorProviderNO.SetError(TeleponTextBox, "")
        End If
    End Sub

    Private Sub EmailTextBox_Validating(sender As Object, e As CancelEventArgs) Handles EmailTextBox.Validating
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        If System.Text.RegularExpressions.Regex.Match(EmailTextBox.Text, pattern).Success Then
            ErrorProviderOK.SetError(EmailTextBox, "Correct")
            ErrorProviderNO.SetError(EmailTextBox, "")
        Else
            ErrorProviderNO.SetError(EmailTextBox, "Invalid email Address!")
            ErrorProviderOK.SetError(EmailTextBox, "")
            e.Cancel = True
            Return
        End If
    End Sub

    Private Sub AlamatTextBox_Validating(sender As Object, e As CancelEventArgs) Handles AlamatTextBox.Validating
        If AlamatTextBox.Text = "" Then
            ErrorProviderNO.SetError(AlamatTextBox, "Must be filled")
            ErrorProviderOK.SetError(AlamatTextBox, "")
            e.Cancel = True
            Return
        Else
            ErrorProviderOK.SetError(AlamatTextBox, "Correct")
            ErrorProviderNO.SetError(AlamatTextBox, "")
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If ValidateChildren() Then
            Try
                Call OpenConnection()
                Using OLECMD As New MySqlCommand("UPDATE user SET nip=@NIP, nama=@nama, tempatlahir=@tempatlahir, tanggallahir=@tanggallahir, jeniskelamin=@jeniskelamin, agama=@agama, telepon=@telepon, email=@email, alamat=@alamat WHERE  username='" & MainMenu.UserNameToolStripStatusLabel.Text & "'", conn)
                    OLECMD.Parameters.AddWithValue("@NIP", (NIPTextBox.Text))
                    OLECMD.Parameters.AddWithValue("@nama", (NamaTextBox.Text))
                    OLECMD.Parameters.AddWithValue("@tempatlahir", (TempatLahirTextBox.Text))
                    OLECMD.Parameters.AddWithValue("@tanggallahir", (TanggalLahirDateTimePicker.Value))
                    OLECMD.Parameters.AddWithValue("@jeniskelamin", (JenisKelaminComboBox.Text))
                    OLECMD.Parameters.AddWithValue("@agama", (AgamaComboBox.Text))
                    OLECMD.Parameters.AddWithValue("@telepon", (TeleponTextBox.Text))
                    OLECMD.Parameters.AddWithValue("@email", (EmailTextBox.Text))
                    OLECMD.Parameters.AddWithValue("@alamat", (AlamatTextBox.Text))
                    OLECMD.ExecuteNonQuery()
                End Using
                conn.Close()
                    Call ClearErrorProvider()
                MsgBox("Profil Anda Sudah Diupdate", vbInformation, "Success")
                UserInformationForm.NIPLabel.Text = NIPTextBox.Text
                UserInformationForm.NamaLabel.Text = NamaTextBox.Text
                UserInformationForm.TempatLahirLabel.Text = TempatLahirTextBox.Text
                Dim TglL As Date = TanggalLahirDateTimePicker.Value
                Dim formatted As String = TglL.ToString("dd MMMM yyyy")
                UserInformationForm.TanggalLahirLabel.Text = formatted
                UserInformationForm.JenisKelaminLabel.Text = JenisKelaminComboBox.Text
                UserInformationForm.AgamaLabel.Text = AgamaComboBox.Text
                UserInformationForm.TeleponLabel.Text = TeleponTextBox.Text
                UserInformationForm.EmailLabel.Text = EmailTextBox.Text
                UserInformationForm.AlamatLabel.Text = AlamatTextBox.Text
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        Else
            MsgBox("Please check your entry data", MessageBoxIcon.Stop, "Attention")
        End If
    End Sub
End Class