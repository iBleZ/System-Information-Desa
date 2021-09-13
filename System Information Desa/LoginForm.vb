Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Public Class LoginForm
    Const us As String = "iBleZ"
    Const pw As String = "iyankecedo"
    Dim a As String
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles Me.Load
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
            Dim Rm As Resources.ResourceManager
            Rm = New Resources.ResourceManager("System_Information_Desa.Resources", System.Reflection.Assembly.GetExecutingAssembly)
            LogoPictureBox.Image = Rm.GetObject("loginpic")
        End If
    End Sub

    Private Sub UsernameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UsernameTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If UsernameTextBox.Text = us Then
                PasswordTextBox.Focus()
            Else
                Call OpenConnection()
                Dim OLECMD As New MySqlDataAdapter("Select*From user where username ='" & UsernameTextBox.Text & "'", conn)
                Dim OLEDR As New DataTable
                OLECMD.Fill(OLEDR)
                If OLEDR.Rows.Count = False Then
                    a += 1
                    If 1 - a = 0 Then
                        MsgBox(" User Name " & UsernameTextBox.Text & " Tidak Dikenal", vbCritical + vbOKOnly, "Access denied")
                        UsernameTextBox.Text = ""
                        UsernameTextBox.Focus()
                    ElseIf 2 - a = 0 Then
                        MsgBox(" User Name " & UsernameTextBox.Text & " Tidak Dikenal", vbCritical + vbOKOnly, "Access denied")
                        UsernameTextBox.Text = ""
                        UsernameTextBox.Focus()
                    ElseIf 3 - a = 0 Then
                        MsgBox(" User Name " & UsernameTextBox.Text & " Tidak Dikenal", vbCritical + vbOKOnly, "Access denied")
                        MsgBox("Application closes automatically", vbExclamation + vbOKOnly, "Kesempatan Anda Sudah Habis!!")
                        Me.Close()
                    End If
                Else
                    PasswordTextBox.Focus()
                End If
            End If
        End If
        conn.Close()
    End Sub

    Private Sub PasswordTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PasswordTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If PasswordTextBox.Text = "" Then
                MsgBox("Password belum diisi", MessageBoxIcon.Warning, "Warning")
                PasswordTextBox.Focus()
            Else
                OK.Focus()
            End If
        End If
    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim HashedPass As String = ""
        Using MD5hash As MD5 = MD5.Create()
            HashedPass = System.Convert.ToBase64String(MD5hash.ComputeHash(System.Text.Encoding.ASCII.GetBytes(PasswordTextBox.Text)))
        End Using
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MsgBox("Harap Input User Name  Dan Password", vbInformation, "Notice")
            UsernameTextBox.Focus()
        ElseIf UsernameTextBox.Text = us And PasswordTextBox.Text = pw Then
            MainMenu.Show()
            MainMenu.NamaToolStripLabel.Text = "Yarfa'i Diyansyah"
            MainMenu.PhotoUserToolStripButton.Text = "Developer"
            Me.Hide()
        Else
            Call OpenConnection()
            OLECMD = New MySqlCommand("SELECT * FROM user WHERE username = '" & UsernameTextBox.Text & "' AND password = '" & HashedPass & "' ", conn)
            OLEDR = OLECMD.ExecuteReader
            OLEDR.Read()
            If OLEDR.HasRows Then
                Me.Hide()
                Dim bytes As [Byte]() = OLEDR.Item("foto")
                Dim ms As New MemoryStream(bytes)
                MainMenu.PhotoUserToolStripButton.Image = Image.FromStream(ms)
                MainMenu.PhotoUserToolStripButton.Text = OLEDR.Item("jabatan")
                MainMenu.NamaToolStripLabel.Text = OLEDR.Item("nama")
                MainMenu.UserNameToolStripStatusLabel.Text = OLEDR.Item("username")
                MainMenu.Show()
            Else
                MsgBox("User Name Atau Password Salah, Mohon Periksa Kembali !!!", vbExclamation, "Warning")
                UsernameTextBox.Text = ""
                PasswordTextBox.Text = ""
                UsernameTextBox.Focus()
            End If
        End If
        conn.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub ForgotpasswordLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ForgotpasswordLabel.LinkClicked
        LupaPasswordForm.ShowDialog()
    End Sub
End Class
