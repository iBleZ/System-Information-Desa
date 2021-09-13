Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.ComponentModel

Public Class AddUserForm
    Private PathFile As String = Nothing

    Sub Clear()
        Dim Rm As Resources.ResourceManager
        Rm = New Resources.ResourceManager("System_Information_Desa.Resources", System.Reflection.Assembly.GetExecutingAssembly)
        Call ClearTextBoxInBox(GroupBox1)
        Call ClearTextBoxInBox(GroupBox2)
        PhotoPictureBox.Image = Rm.GetObject("insertimage")
        ShowPasswordCheckBox.Checked = False
        LabelPhoto.Text = "Photo"
        LabelLokasiFile.Text = ""
        LabelLokasiFile.Visible = False
        TanggalLahirDateTimePicker.Value = Date.Today
        TanggalLahirDateTimePicker.Format = DateTimePickerFormat.Custom
        TanggalLahirDateTimePicker.CustomFormat = "dd MMMM yyyy"
        conn.Close()
        CancelBtn.Focus()
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
        ErrorProviderOK.SetError(UserNameTextBox, "")
        ErrorProviderNO.SetError(UserNameTextBox, "")
        ErrorProviderOK.SetError(PasswordTextBox, "")
        ErrorProviderNO.SetError(PasswordTextBox, "")
        ErrorProviderOK.SetError(ConfirmPasswordTextBox, "")
        ErrorProviderNO.SetError(ConfirmPasswordTextBox, "")
        ErrorProviderOK.SetError(JabatanComboBox, "")
        ErrorProviderNO.SetError(JabatanComboBox, "")
    End Sub
    Private Sub AddUserForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        PasswordTextBox.PasswordChar = "•"
        ConfirmPasswordTextBox.PasswordChar = "•"
        NIPTextBox.MaxLength = 18
        TeleponTextBox.MaxLength = 13
        UserNameTextBox.MaxLength = 20
        TanggalLahirDateTimePicker.Format = DateTimePickerFormat.Custom
        TanggalLahirDateTimePicker.CustomFormat = "dd MMMM yyyy"
        LabelPertanyaan.Text = ""
        LabelPertanyaan.Visible = False
        LabelJawaban.Text = ""
        LabelJawaban.Visible = False
        CancelBtn.Focus()
        Call Clear()
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

    Private Sub UserNameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UserNameTextBox.KeyPress
        If Asc(e.KeyChar) = 32 Then
            UserNameTextBox.Text = ""
            UserNameTextBox.Focus()
            MsgBox("Tidak Boleh Menggunakan Spasi !!!", vbInformation, "Information")
        End If
    End Sub

    Private Sub UserNameTextBox_Validating(sender As Object, e As CancelEventArgs) Handles UserNameTextBox.Validating
        Dim pattern As String = "^[a-zA-Z0-9]*$"
        Call OpenConnection()
        Dim OLECMD As New MySqlDataAdapter("SELECT * FROM user WHERE username = '" & UserNameTextBox.Text & "'", conn)
        Dim OLEDR As New DataTable
        OLECMD.Fill(OLEDR)
        If UserNameTextBox.Text = "" Then
            ErrorProviderNO.SetError(UserNameTextBox, "Must be filled")
            ErrorProviderOK.SetError(UserNameTextBox, "")
            e.Cancel = True
            Return
        ElseIf OLEDR.Rows.Count <> 0 Then
            MsgBox("User Name " & UserNameTextBox.Text & " Sudah Ada", vbInformation)
            UserNameTextBox.Text = ""
            ErrorProviderNO.SetError(UserNameTextBox, "Try again")
            ErrorProviderOK.SetError(UserNameTextBox, "")
            e.Cancel = True
            Return
        ElseIf UserNameTextBox.Text.Length < 5 Then
            ErrorProviderNO.SetError(UserNameTextBox, "User Name hanya diizinkan 5 - 20 karakter!!")
            ErrorProviderOK.SetError(UserNameTextBox, "")
            e.Cancel = True
            Return
        ElseIf System.Text.RegularExpressions.Regex.Match(UserNameTextBox.Text, pattern).Success Then
            ErrorProviderOK.SetError(UserNameTextBox, "Correct")
            ErrorProviderNO.SetError(UserNameTextBox, "")
        Else
            ErrorProviderNO.SetError(UserNameTextBox, "Tidak boleh menggunakan spesial Karakter")
            ErrorProviderOK.SetError(UserNameTextBox, "")
            UserNameTextBox.Text = ""
            e.Cancel = True
            Return
        End If
        conn.Close()
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
            ErrorProviderNO.SetError(PasswordTextBox, "Must be filled")
            ErrorProviderOK.SetError(PasswordTextBox, "")
            e.Cancel = True
            Return
        ElseIf PasswordTextBox.Text.Length < 10 Then
            MsgBox("Password Terlalu Pendek!!", vbExclamation, "Warning - Tidak Aman")
            PasswordTextBox.Text = ""
            e.Cancel = True
            Return
        ElseIf PasswordTextBox.Text <> ConfirmPasswordTextBox.Text Then
            ErrorProviderOK.SetError(PasswordTextBox, "")
            ErrorProviderNO.SetError(PasswordTextBox, "Password tidak sama dengan ConfirmPassword")
        End If
    End Sub

    Private Sub ConfirmPasswordTextBox_Validating(sender As Object, e As CancelEventArgs) Handles ConfirmPasswordTextBox.Validating
        If ConfirmPasswordTextBox.Text = "" Then
            ErrorProviderNO.SetError(ConfirmPasswordTextBox, "Must be filled")
            ErrorProviderOK.SetError(ConfirmPasswordTextBox, "")
            e.Cancel = True
            Return
        ElseIf PasswordTextBox.Text <> ConfirmPasswordTextBox.Text Then
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
            Dim HashedPass As String = ""
            Using MD5hash As MD5 = MD5.Create()
                HashedPass = System.Convert.ToBase64String(MD5hash.ComputeHash(System.Text.Encoding.ASCII.GetBytes(ConfirmPasswordTextBox.Text)))
            End Using
            Str = "INSERT INTO user values (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15)"
            Try
                Dim imgByte() As Byte
                Dim ms As New MemoryStream
                Dim gambar As New Bitmap(PhotoPictureBox.Image)
                gambar.Save(ms, Imaging.ImageFormat.Jpeg)
                imgByte = ms.ToArray
                Call OpenConnection()
                Using OLECMD As New MySqlCommand(Str, conn)
                    With OLECMD
                        .Parameters.AddWithValue("@1", (UserNameTextBox.Text))
                        .Parameters.AddWithValue("@2", (HashedPass))
                        .Parameters.AddWithValue("@3", (NIPTextBox.Text))
                        .Parameters.AddWithValue("@4", (NamaTextBox.Text))
                        .Parameters.AddWithValue("@5", (JabatanComboBox.Text))
                        .Parameters.AddWithValue("@6", (TempatLahirTextBox.Text))
                        .Parameters.AddWithValue("@7", (TanggalLahirDateTimePicker.Value))
                        .Parameters.AddWithValue("@8", (JenisKelaminComboBox.Text))
                        .Parameters.AddWithValue("@9", (AlamatTextBox.Text))
                        .Parameters.AddWithValue("@10", (AgamaComboBox.Text))
                        .Parameters.AddWithValue("@11", (TeleponTextBox.Text))
                        .Parameters.AddWithValue("@12", (EmailTextBox.Text))
                        .Parameters.AddWithValue("@13", (imgByte))
                        .Parameters.AddWithValue("@14", (LabelPertanyaan.Text))
                        .Parameters.AddWithValue("@15", (LabelJawaban.Text))
                        .ExecuteNonQuery()
                    End With
                End Using
                MsgBox("User " & UserNameTextBox.Text & " Sebagai " & JabatanComboBox.Text & " Sudah Ditambahkan", vbInformation, "Success")
                Call Clear()
                Call ClearErrorProvider()
                CancelBtn.Focus()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        Else
            MsgBox("Please check your entry data", MessageBoxIcon.Stop, "Attention")
        End If
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Call Clear()
        Call ClearErrorProvider()
        Me.Close()
    End Sub
End Class