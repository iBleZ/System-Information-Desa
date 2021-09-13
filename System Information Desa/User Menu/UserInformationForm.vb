Imports MySql.Data.MySqlClient
Imports System.IO
Public Class UserInformationForm
    Private Sub PHOTOBULAT()
        Dim GambarBulat As New System.Drawing.Drawing2D.GraphicsPath()
        GambarBulat.AddEllipse(0, 0, PhotoPictureBox.Width - 0, PhotoPictureBox.Height - 0)
        Dim theRegion As New Region(GambarBulat)
        PhotoPictureBox.Region = theRegion
    End Sub
    Private Sub UserInformationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call PHOTOBULAT()
        Call OpenConnection()
        Str = ("select*from user where username ='" & MainMenu.UserNameToolStripStatusLabel.Text & "'")
        Dim OLECMD = New MySqlCommand(Str, conn)
        Dim OLEDR As MySqlDataReader
        OLEDR = OLECMD.ExecuteReader
        OLEDR.Read()
        If OLEDR.HasRows Then
            UserNameLabel.Text = OLEDR.Item("username")
            NIPLabel.Text = OLEDR.Item("nip")
            NamaLabel.Text = OLEDR.Item("nama")
            TempatLahirLabel.Text = OLEDR.Item("tempatlahir")
            Dim TglL As Date = OLEDR.Item("tanggallahir")
            Dim formatted As String = TglL.ToString("dd MMMM yyyy")
            TanggalLahirLabel.Text = formatted
            JenisKelaminLabel.Text = OLEDR.Item("jeniskelamin")
            AlamatLabel.Text = OLEDR.Item("alamat")
            AgamaLabel.Text = OLEDR.Item("agama")
            TeleponLabel.Text = OLEDR.Item("telepon")
            EmailLabel.Text = OLEDR.Item("email")
            JabatanLabel.Text = OLEDR.Item("jabatan")
            Dim bytes As [Byte]() = OLEDR.Item("foto")
            Dim ms As New MemoryStream(bytes)
            PhotoPictureBox.Image = Image.FromStream(ms)
        End If
        conn.Close()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If PertanyaanComboBox.Text = "" Then
            MsgBox("Pilih pertanyaan", vbInformation, " Pertanyaan Pengaman")
            PertanyaanComboBox.Focus()
        ElseIf JawabanTextBox.Text = "" Then
            MsgBox("Berikan Jawaban", vbInformation, " Pertanyaan Pengaman")
            JawabanTextBox.Focus()
        Else
            Try
                Call OpenConnection()

                Using OLECMD As New MySqlCommand("UPDATE user SET pertanyaan=@pertanyaan, jawaban=@jawaban  WHERE  username='" & UserNameLabel.Text & "'", conn)
                    OLECMD.Parameters.AddWithValue("@pertanyaan", (PertanyaanComboBox.Text))
                    OLECMD.Parameters.AddWithValue("@jawaban", (JawabanTextBox.Text))
                    OLECMD.ExecuteNonQuery()
                End Using
                MsgBox("Questions and answers have been saved", vbInformation, "Success")
                PertanyaanComboBox.Text = ""
                JawabanTextBox.Text = ""
                CloseButton.Focus()
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub ChangePasswordButton_Click(sender As Object, e As EventArgs) Handles ChangePasswordButton.Click
        FormChangePassword.ShowDialog()
    End Sub

    Private Sub ChangePhotoButton_Click(sender As Object, e As EventArgs) Handles ChangePhotoButton.Click
        FormChangePhoto.ShowDialog()
    End Sub

    Private Sub ChangeProfilButton_Click(sender As Object, e As EventArgs) Handles ChangeProfilButton.Click
        FormChangePersonalInfo.ShowDialog()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class