Imports MySql.Data.MySqlClient
Imports System.IO
Public Class KopSuratForm
    Private PathFile As String = Nothing
    Private Sub KopSuratForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelKopsurat.Visible = False
        LabelLokasi.Visible = False
        BrowseButton.Focus()
        SaveButton.Visible = False

        Call OpenConnection()
        Str = ("select*from kop")
        Dim OLECMD = New MySqlCommand(Str, conn)
        Dim OLEDR As MySqlDataReader
        OLEDR = OLECMD.ExecuteReader
        OLEDR.Read()
        If OLEDR.HasRows Then
            Dim bytes As [Byte]() = OLEDR.Item("kopsurat")
            Dim ms As New MemoryStream(bytes)
            Kopsurat.Image = Image.FromStream(ms)
        Else
            Kopsurat.Image = Nothing
        End If
    End Sub

    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
        On Error Resume Next
        OpenFileDialog1.Filter = "JPG Files(*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|GIF Files(*.gif)|*.gif|PNG Files(*.png)|*.png|BMP Files(*.bmp)|*.bmp|TIFF Files(*.tiff)|*.tiff"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Kopsurat.SizeMode = PictureBoxSizeMode.StretchImage
            Kopsurat.Image = New Bitmap(OpenFileDialog1.FileName)
            PathFile = OpenFileDialog1.FileName
            LabelKopsurat.Text = PathFile.Substring(PathFile.LastIndexOf("\") + 1)
            LabelLokasi.Text = OpenFileDialog1.FileName
            Kopsurat.Image = Image.FromFile(LabelKopsurat.Text)
            LabelKopsurat.Visible = True
            LabelLokasi.Visible = True
            SaveButton.Visible = True
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim imgByte() As Byte
        Dim ms As New MemoryStream
        Dim gambar As New Bitmap(Kopsurat.Image)
        gambar.Save(ms, Imaging.ImageFormat.Jpeg)
        imgByte = ms.ToArray
        Call OpenConnection()
        Str = ("select*from kop")
        Dim OLECMD = New MySqlCommand(Str, conn)
        Dim OLEDR As MySqlDataReader
        OLEDR = OLECMD.ExecuteReader
        OLEDR.Read()
        If OLEDR.HasRows Then
            Try
                Call OpenConnection()
                Using CMD As New MySqlCommand("UPDATE kop SET kopsurat=@kopsurat", conn)
                    CMD.Parameters.AddWithValue("kopsurat", (imgByte))
                    CMD.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        Else
            Try
                Call OpenConnection()
                Str = "insert into kop (kopsurat) values (@1)"
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
        MsgBox("Kop Surat has been changed", vbInformation, "Success")
        conn.Close()
        Me.Close()
    End Sub

    Private Sub ClsoeButton_Click(sender As Object, e As EventArgs) Handles ClsoeButton.Click
        Me.Close()
    End Sub
End Class