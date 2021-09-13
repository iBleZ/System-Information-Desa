Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.ComponentModel
Public Class EditUserForm
    Private PathFile As String = Nothing
    Sub Clear()
        Call ClearTextBoxInBox(GroupBox1)
        GroupBox1.Visible = False
        Call ClearTextBoxInBox(GroupBox2)
        GroupBox2.Visible = False
        PhotoPictureBox.Image = Nothing
        ShowPasswordCheckBox.Checked = False
        LabelPhoto.Text = ""
        LabelPhoto.Visible = False
        LabelLokasiFile.Text = ""
        LabelLokasiFile.Visible = False
        TanggalLahirDateTimePicker.Value = Date.Today
        TanggalLahirDateTimePicker.Format = DateTimePickerFormat.Custom
        TanggalLahirDateTimePicker.CustomFormat = "dd MMMM yyyy"
        BrowseButton.Visible = False
        SaveButton.Visible = False
        DeleteButton.Visible = False
        ButtonCancel.Visible = False
        UserNameLabel.Visible = False
        CariTextBox.Text = ""
        conn.Close()
    End Sub

    Sub ClearErrorProvider()
        ErrorProviderOK.SetError(NIPTextBox, "")
        ErrorProviderNO.SetError(NIPTextBox, "")
        ErrorProviderOK.SetError(NamaTextBox, "")
        ErrorProviderNO.SetError(NamaTextBox, "")
        ErrorProviderOK.SetError(TempatLahirTextBox, "")
        ErrorProviderNO.SetError(TempatLahirTextBox, "")
        ErrorProviderOK.SetError(TanggalLahirDateTimePicker, "")
        ErrorProviderNO.SetError(TanggalLahirDateTimePicker, "")
        ErrorProviderOK.SetError(JenisKelaminComboBox, "")
        ErrorProviderNO.SetError(JenisKelaminComboBox, "")
        ErrorProviderOK.SetError(AlamatTextBox, "")
        ErrorProviderNO.SetError(AlamatTextBox, "")
        ErrorProviderOK.SetError(AgamaComboBox, "")
        ErrorProviderNO.SetError(AgamaComboBox, "")
        ErrorProviderOK.SetError(TeleponTextBox, "")
        ErrorProviderNO.SetError(TeleponTextBox, "")
        ErrorProviderOK.SetError(EmailTextBox, "")
        ErrorProviderNO.SetError(EmailTextBox, "")
        ErrorProviderOK.SetError(PasswordTextBox, "")
        ErrorProviderNO.SetError(PasswordTextBox, "")
        ErrorProviderOK.SetError(ConfirmPasswordTextBox, "")
        ErrorProviderNO.SetError(ConfirmPasswordTextBox, "")
        ErrorProviderOK.SetError(JabatanComboBox, "")
        ErrorProviderNO.SetError(JabatanComboBox, "")
    End Sub

    Private Sub EditUserForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        PasswordTextBox.PasswordChar = "•"
        ConfirmPasswordTextBox.PasswordChar = "•"
        NIPTextBox.MaxLength = 18
        TeleponTextBox.MaxLength = 13
        TanggalLahirDateTimePicker.Format = DateTimePickerFormat.Custom
        TanggalLahirDateTimePicker.CustomFormat = "dd MMMM yyyy"
        LabelPertanyaan.Text = ""
        LabelPertanyaan.Visible = False
        LabelJawaban.Text = ""
        LabelJawaban.Visible = False
        ButtonCancel.Focus()
        Call Clear()
    End Sub

    Private Sub CariTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CariTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call OpenConnection()
            Str = ("select*from user where username ='" & CariTextBox.Text & "'")
            Dim OLECMD = New MySqlCommand(Str, conn)
            Dim OLEDR As MySqlDataReader
            OLEDR = OLECMD.ExecuteReader
            OLEDR.Read()
            If OLEDR.HasRows Then
                UserNameLabel.Text = OLEDR.Item("username")
                NIPTextBox.Text = OLEDR.Item("nip")
                NamaTextBox.Text = OLEDR.Item("nama")
                TempatLahirTextBox.Text = OLEDR.Item("tempatlahir")
                TanggalLahirDateTimePicker.Text = OLEDR.Item("tanggallahir")
                JenisKelaminComboBox.Text = OLEDR.Item("jeniskelamin")
                AlamatTextBox.Text = OLEDR.Item("alamat")
                AgamaComboBox.Text = OLEDR.Item("agama")
                TeleponTextBox.Text = OLEDR.Item("telepon")
                EmailTextBox.Text = OLEDR.Item("email")
                JabatanComboBox.Text = OLEDR.Item("jabatan")
                Dim bytes As [Byte]() = OLEDR.Item("foto")
                Dim ms As New MemoryStream(bytes)
                PhotoPictureBox.Image = Image.FromStream(ms)
                GroupBox1.Visible = True
                GroupBox2.Visible = True
                PhotoPictureBox.Visible = True
                BrowseButton.Visible = True
                SaveButton.Visible = True
                DeleteButton.Visible = True
                ButtonCancel.Visible = True
                conn.Close()
            Else
                MsgBox("User Tidak Ditemukan", vbCritical, "Warning")
                CariButton.Text = ""
                CariTextBox.Focus()
                Call Clear()
            End If
        End If
    End Sub

    Private Sub CariButton_Click(sender As Object, e As EventArgs) Handles CariButton.Click
        Call OpenConnection()
        Str = ("select*from user where username ='" & CariTextBox.Text & "'")
        Dim OLECMD = New MySqlCommand(Str, conn)
        Dim OLEDR As MySqlDataReader
        OLEDR = OLECMD.ExecuteReader
        OLEDR.Read()
        If OLEDR.HasRows Then
            UserNameLabel.Text = OLEDR.Item("username")
            NIPTextBox.Text = OLEDR.Item("nip")
            NamaTextBox.Text = OLEDR.Item("nama")
            TempatLahirTextBox.Text = OLEDR.Item("tempatlahir")
            TanggalLahirDateTimePicker.Text = OLEDR.Item("tanggallahir")
            JenisKelaminComboBox.Text = OLEDR.Item("jeniskelamin")
            AlamatTextBox.Text = OLEDR.Item("alamat")
            AgamaComboBox.Text = OLEDR.Item("agama")
            TeleponTextBox.Text = OLEDR.Item("telepon")
            EmailTextBox.Text = OLEDR.Item("email")
            JabatanComboBox.Text = OLEDR.Item("jabatan")
            Dim bytes As [Byte]() = OLEDR.Item("foto")
            Dim ms As New MemoryStream(bytes)
            PhotoPictureBox.Image = Image.FromStream(ms)
            GroupBox1.Visible = True
            GroupBox2.Visible = True
            PhotoPictureBox.Visible = True
            BrowseButton.Visible = True
            SaveButton.Visible = True
            DeleteButton.Visible = True
            ButtonCancel.Visible = True
            conn.Close()
        Else
            MsgBox("User Tidak Ditemukan", vbCritical, "Warning")
            CariTextBox.Text = ""
            CariTextBox.Focus()
            Call Clear()
        End If
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

    Private Sub PasswordTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PasswordTextBox.KeyPress
        If Asc(e.KeyChar) = 32 Then
            PasswordTextBox.Text = ""
            PasswordTextBox.Focus()
            MsgBox("Tidak Boleh Menggunakan Spasi !!!", vbInformation, "Information")
        End If
    End Sub

    Private Sub PasswordTextBox_Validating(sender As Object, e As CancelEventArgs) Handles PasswordTextBox.Validating
        If PasswordTextBox.Text = "" Then
            ErrorProviderOK.SetError(PasswordTextBox, "Correct")
            ErrorProviderNO.SetError(PasswordTextBox, "")
        ElseIf PasswordTextBox.Text.Length < 10 Then
            MsgBox("Password Terlalu Pendek!!", vbExclamation, "Warning - Tidak Aman")
            PasswordTextBox.Text = ""
        ElseIf PasswordTextBox.Text <> ConfirmPasswordTextBox.Text Then
            ErrorProviderOK.SetError(PasswordTextBox, "")
            ErrorProviderNO.SetError(PasswordTextBox, "Password tidak sama dengan ConfirmPassword")
        End If
    End Sub

    Private Sub ConfirmPasswordTextBox_Validating(sender As Object, e As CancelEventArgs) Handles ConfirmPasswordTextBox.Validating
        If PasswordTextBox.Text <> ConfirmPasswordTextBox.Text Then
            MsgBox("Password Tidak Sama,Ketik Ulang Password !", vbInformation, "Information")
            PasswordTextBox.Text = ""
            ConfirmPasswordTextBox.Text = ""
            PasswordTextBox.Focus()
        ElseIf PasswordTextBox.Text = ConfirmPasswordTextBox.Text Then
            ErrorProviderOK.SetError(PasswordTextBox, "Correct")
            ErrorProviderNO.SetError(PasswordTextBox, "")
            ErrorProviderOK.SetError(ConfirmPasswordTextBox, "Correct")
            ErrorProviderNO.SetError(ConfirmPasswordTextBox, "")
        End If
    End Sub

    Private Sub ShowPasswordCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPasswordCheckBox.CheckedChanged
        If ShowPasswordCheckBox.Checked Then
            PasswordTextBox.PasswordChar = ""
            ConfirmPasswordTextBox.PasswordChar = ""
        Else
            PasswordTextBox.PasswordChar = "•"
            ConfirmPasswordTextBox.PasswordChar = "•"
        End If
    End Sub

    Private Sub JabatanComboBox_Validating(sender As Object, e As CancelEventArgs) Handles JabatanComboBox.Validating
        If JabatanComboBox.Text = "Administrator" Then
            ErrorProviderOK.SetError(JabatanComboBox, "Correct")
            ErrorProviderNO.SetError(JabatanComboBox, "")
        ElseIf JabatanComboBox.Text = "Operator" Then
            ErrorProviderOK.SetError(JabatanComboBox, "Correct")
            ErrorProviderNO.SetError(JabatanComboBox, "")
        ElseIf JabatanComboBox.Text = "Pengawas" Then
            ErrorProviderOK.SetError(JabatanComboBox, "Correct")
            ErrorProviderNO.SetError(JabatanComboBox, "")
        Else
            ErrorProviderNO.SetError(JabatanComboBox, "Pilih Level Jabatan")
            ErrorProviderOK.SetError(JabatanComboBox, "")
            e.Cancel = True
            Return
        End If
    End Sub

    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
        On Error Resume Next
        OpenFileDialog1.Filter = "JPG Files(*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|GIF Files(*.gif)|*.gif|PNG Files(*.png)|*.png|BMP Files(*.bmp)|*.bmp|TIFF Files(*.tiff)|*.tiff"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PhotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
            PhotoPictureBox.Image = New Bitmap(OpenFileDialog1.FileName)
            PathFile = OpenFileDialog1.FileName
            LabelPhoto.Text = PathFile.Substring(PathFile.LastIndexOf("\") + 1)
            LabelLokasiFile.Text = OpenFileDialog1.FileName
            PhotoPictureBox.Image = Image.FromFile(LabelPhoto.Text)
            LabelLokasiFile.Visible = True
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If ValidateChildren() Then
            If ConfirmPasswordTextBox.Text = "" Then
                Dim pesan As String = MsgBox("Apakah anda tidak ingin mengganti password user account " & UserNameLabel.Text & " ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
                If pesan = vbYes Then
                    Dim imgByte() As Byte
                    Dim ms As New MemoryStream
                    Dim gambar As New Bitmap(PhotoPictureBox.Image)
                    gambar.Save(ms, Imaging.ImageFormat.Jpeg)
                    imgByte = ms.ToArray
                    Try
                        Call OpenConnection()
                        Using OLECMD As New MySqlCommand("UPDATE user SET nip=@NIP, nama=@nama, jabatan=@jabatan, tempatlahir=@tempatlahir, tanggallahir=@tanggallahir, jeniskelamin=@jeniskelamin, alamat=@alamat, agama=@agama, telepon=@telepon, email=@email, foto=@photo  WHERE  username='" & UserNameLabel.Text & "'", conn)
                            OLECMD.Parameters.AddWithValue("@NIP", (NIPTextBox.Text))
                            OLECMD.Parameters.AddWithValue("@nama", (NamaTextBox.Text))
                            OLECMD.Parameters.AddWithValue("@jabatan", (JabatanComboBox.Text))
                            OLECMD.Parameters.AddWithValue("@tempatlahir", (TempatLahirTextBox.Text))
                            OLECMD.Parameters.AddWithValue("@tanggallahir", (TanggalLahirDateTimePicker.Value))
                            OLECMD.Parameters.AddWithValue("@jeniskelamin", (JenisKelaminComboBox.Text))
                            OLECMD.Parameters.AddWithValue("@alamat", (AlamatTextBox.Text))
                            OLECMD.Parameters.AddWithValue("@agama", (AgamaComboBox.Text))
                            OLECMD.Parameters.AddWithValue("@telepon", (TeleponTextBox.Text))
                            OLECMD.Parameters.AddWithValue("@email", (EmailTextBox.Text))
                            OLECMD.Parameters.AddWithValue("@photo", (imgByte))
                            OLECMD.ExecuteNonQuery()
                        End Using
                        MsgBox("Data " & UserNameLabel.Text & " Sebagai " & JabatanComboBox.Text & " Sudah Diupdate", vbInformation, "Success")
                        Call Clear()
                        Call ClearErrorProvider()
                        UserNameLabel.Text = ""
                        CariButton.Text = ""
                        CariButton.Focus()
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                    End Try
                ElseIf pesan = vbNo Then
                    PasswordTextBox.Focus()
                End If
            Else
                Dim imgByte() As Byte
                Dim ms As New MemoryStream
                Dim gambar As New Bitmap(PhotoPictureBox.Image)
                gambar.Save(ms, Imaging.ImageFormat.Jpeg)
                imgByte = ms.ToArray
                Dim HashedPass As String = ""
                Using MD5hash As MD5 = MD5.Create()
                    HashedPass = System.Convert.ToBase64String(MD5hash.ComputeHash(System.Text.Encoding.ASCII.GetBytes(ConfirmPasswordTextBox.Text)))
                End Using
                Try
                    Call OpenConnection()
                    Using OLECMD As New MySqlCommand("UPDATE user SET password= @password, nip=@NIP, nama=@nama, jabatan=@jabatan, tempatlahir=@tempatlahir, tanggallahir=@tanggallahir, jeniskelamin=@jeniskelamin, alamat=@alamat, agama=@agama, telepon=@telepon, email=@email, foto=@photo  WHERE  username='" & UserNameLabel.Text & "'", conn)
                        OLECMD.Parameters.AddWithValue("@password", (HashedPass))
                        OLECMD.Parameters.AddWithValue("@NIP", (NIPTextBox.Text))
                        OLECMD.Parameters.AddWithValue("@nama", (NamaTextBox.Text))
                        OLECMD.Parameters.AddWithValue("@jabatan", (JabatanComboBox.Text))
                        OLECMD.Parameters.AddWithValue("@tempatlahir", (TempatLahirTextBox.Text))
                        OLECMD.Parameters.AddWithValue("@tanggallahir", (TanggalLahirDateTimePicker.Value))
                        OLECMD.Parameters.AddWithValue("@jeniskelamin", (JenisKelaminComboBox.Text))
                        OLECMD.Parameters.AddWithValue("@alamat", (AlamatTextBox.Text))
                        OLECMD.Parameters.AddWithValue("@agama", (AgamaComboBox.Text))
                        OLECMD.Parameters.AddWithValue("@telepon", (TeleponTextBox.Text))
                        OLECMD.Parameters.AddWithValue("@email", (EmailTextBox.Text))
                        OLECMD.Parameters.AddWithValue("@photo", (imgByte))
                        OLECMD.ExecuteNonQuery()
                    End Using
                    MsgBox("Data " & UserNameLabel.Text & " Sebagai " & JabatanComboBox.Text & " Sudah Diupdate", vbInformation, "Success")
                    UserNameLabel.Text = ""
                    CariButton.Text = ""
                    CariButton.Focus()
                    Call Clear()
                    Call ClearErrorProvider()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
            End If
        Else
            MsgBox("Please check your entry data", MessageBoxIcon.Stop, "Attention")
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Call OpenConnection()
        Dim hapus As String = "DELETE FROM user WHERE username='" & UserNameLabel.Text & "'"
        Try
            Dim pesan As String = MsgBox("Are you sure want to delete the user account " & UserNameLabel.Text & " ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
            If pesan = vbYes Then
                Dim OLECMD As New MySqlCommand(hapus, conn)
                OLECMD.ExecuteNonQuery()
                MsgBox("User Account " & UserNameLabel.Text & " has been deleted", vbInformation, "Success")
                Call Clear()
                Call ClearErrorProvider()
            Else
                ButtonCancel.Focus()
            End If
        Catch ex As Exception
            MsgBox("Data " & UserNameLabel.Text & "Gagal Didelete", vbExclamation, "Warning")
        End Try
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Call Clear()
        Call ClearErrorProvider()
        UserNameLabel.Text = ""
        Me.Close()
    End Sub
End Class