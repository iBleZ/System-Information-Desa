Imports MySql.Data.MySqlClient
Imports System.IO
Public Class FormChangePhoto
    Private PathFile As String = Nothing

    Private Sub FormChangePhoto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelPhoto.Visible = False
        LabelLokasi.Visible = False
        BrowseButton.Focus()
        SaveButton.Visible = False
        PhotoPictureBox.Image = UserInformationForm.PhotoPictureBox.Image
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
            LabelLokasi.Text = OpenFileDialog1.FileName
            PhotoPictureBox.Image = Image.FromFile(LabelPhoto.Text)
            LabelPhoto.Visible = True
            LabelLokasi.Visible = True
            SaveButton.Visible = True
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            Dim imgByte() As Byte
            Dim ms As New MemoryStream
            Dim gambar As New Bitmap(PhotoPictureBox.Image)
            gambar.Save(ms, Imaging.ImageFormat.Jpeg)
            imgByte = ms.ToArray
            Call OpenConnection()
            Using OLECMD As New MySqlCommand("UPDATE user SET foto=@photo  WHERE  username='" & MainMenu.UserNameToolStripStatusLabel.Text & "'", conn)
                OLECMD.Parameters.AddWithValue("@photo", (imgByte))
                OLECMD.ExecuteNonQuery()
            End Using
            MsgBox("Photo has been changed", vbInformation, "Success")
            UserInformationForm.PhotoPictureBox.Image = PhotoPictureBox.Image
            MainMenu.PhotoUserToolStripButton.Image = PhotoPictureBox.Image
            conn.Close()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class