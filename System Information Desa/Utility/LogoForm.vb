Imports MySql.Data.MySqlClient
Imports System.IO
Public Class LogoForm
    Private PathFile As String = Nothing

    Private Sub LogoForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LabelLogo.Visible = False
        LabelLokasi.Visible = False
        BrowseButton.Focus()
        SaveButton.Visible = False

        Call OpenConnection()
        Str = ("select*from logo")
        Dim OLECMD = New MySqlCommand(Str, conn)
        Dim OLEDR As MySqlDataReader
        OLEDR = OLECMD.ExecuteReader
        OLEDR.Read()
        If OLEDR.HasRows Then
            Dim bytes As [Byte]() = OLEDR.Item("gambarlogo")
            Dim ms As New MemoryStream(bytes)
            LogoPictureBox.Image = Image.FromStream(ms)
        Else
            LogoPictureBox.Image = Nothing
        End If
    End Sub

    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
        On Error Resume Next
        OpenFileDialog1.Filter = "JPG Files(*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|GIF Files(*.gif)|*.gif|PNG Files(*.png)|*.png|BMP Files(*.bmp)|*.bmp|TIFF Files(*.tiff)|*.tiff"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            LogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
            LogoPictureBox.Image = New Bitmap(OpenFileDialog1.FileName)
            PathFile = OpenFileDialog1.FileName
            LabelLogo.Text = PathFile.Substring(PathFile.LastIndexOf("\") + 1)
            LabelLokasi.Text = OpenFileDialog1.FileName
            LogoPictureBox.Image = Image.FromFile(LabelLogo.Text)
            LabelLogo.Visible = True
            LabelLokasi.Visible = True
            SaveButton.Visible = True
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim imgByte() As Byte
        Dim ms As New MemoryStream
        Dim gambar As New Bitmap(LogoPictureBox.Image)
        gambar.Save(ms, Imaging.ImageFormat.Jpeg)
        imgByte = ms.ToArray
        Call OpenConnection()
        Str = ("select*from logo")
        Dim OLECMD = New MySqlCommand(Str, conn)
        Dim OLEDR As MySqlDataReader
        OLEDR = OLECMD.ExecuteReader
        OLEDR.Read()
        If OLEDR.HasRows Then
            Try
                Call OpenConnection()
                Using CMD As New MySqlCommand("UPDATE logo SET gambarlogo=@gambarlogo", conn)
                    CMD.Parameters.AddWithValue("gambarlogo", (imgByte))
                    CMD.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        Else
            Try
                Call OpenConnection()
                Str = "insert into logo (gambarlogo) values (@1)"
                Using CMD As New MySqlCommand(Str, conn)
                    With CMD
                        .Parameters.AddWithValue("@1", (imgByte))
                        .ExecuteNonQuery()
                    End With
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
        MsgBox("Logo has been changed", vbInformation, "Success")
        conn.Close()
        Me.Close()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub
End Class