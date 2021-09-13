Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Public Class FormChangePassword
    Private Sub FormChangePassword_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        OldPasswordTextBox.PasswordChar = "•"
        NewPasswordTextBox.PasswordChar = "•"
        ConfirmPasswordTextBox.PasswordChar = "•"
    End Sub

    Private Sub FormChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OldPasswordTextBox.Text = ""
        NewPasswordTextBox.Text = ""
        ConfirmPasswordTextBox.Text = ""
        ShowPasswordCheckBox.Checked = False
        ErrorProviderNO.SetError(OldPasswordTextBox, "")
        ErrorProviderOK.SetError(OldPasswordTextBox, "")
        ErrorProviderNO.SetError(NewPasswordTextBox, "")
        ErrorProviderOK.SetError(NewPasswordTextBox, "")
        ErrorProviderOK.SetError(ConfirmPasswordTextBox, "")
        ErrorProviderNO.SetError(ConfirmPasswordTextBox, "")
    End Sub

    Private Sub OldPasswordTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles OldPasswordTextBox.KeyPress
        Dim HashedPass As String = ""
        Using MD5hash As MD5 = MD5.Create()
            HashedPass = System.Convert.ToBase64String(MD5hash.ComputeHash(System.Text.Encoding.ASCII.GetBytes(OldPasswordTextBox.Text)))
        End Using
        If Asc(e.KeyChar) = 13 Then
            Call OpenConnection()
            OLECMD = New MySqlCommand("SELECT * FROM user WHERE username = '" & MainMenu.UserNameToolStripStatusLabel.Text & "' AND password = '" & HashedPass & "' ", conn)
            OLEDR = OLECMD.ExecuteReader
            OLEDR.Read()
            If OLEDR.HasRows Then
                NewPasswordTextBox.Focus()
                ErrorProviderOK.SetError(OldPasswordTextBox, "Correct")
                ErrorProviderNO.SetError(OldPasswordTextBox, "")
            Else
                MsgBox("Password Salah, Mohon Periksa Kembali !!!", vbExclamation, "Warning")
                OldPasswordTextBox.Text = ""
                OldPasswordTextBox.Focus()
            End If
            conn.Close()
        End If
    End Sub

    Private Sub OldPasswordTextBox_Validated(sender As Object, e As EventArgs) Handles OldPasswordTextBox.Validated
        Dim HashedPass As String = ""
        Using MD5hash As MD5 = MD5.Create()
            HashedPass = System.Convert.ToBase64String(MD5hash.ComputeHash(System.Text.Encoding.ASCII.GetBytes(OldPasswordTextBox.Text)))
        End Using
        Try
            Call OpenConnection()
            OLECMD = New MySqlCommand("SELECT * FROM user WHERE username = '" & MainMenu.UserNameToolStripStatusLabel.Text & "' AND password = '" & HashedPass & "' ", conn)
            OLEDR = OLECMD.ExecuteReader
            OLEDR.Read()
            If OLEDR.HasRows Then
                ErrorProviderOK.SetError(OldPasswordTextBox, "Correct")
                ErrorProviderNO.SetError(OldPasswordTextBox, "")
            Else
                MsgBox("Password Salah, Mohon Periksa Kembali !!!", vbExclamation, "Warning")
                OldPasswordTextBox.Text = ""
                OldPasswordTextBox.Focus()
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub NewPasswordTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NewPasswordTextBox.KeyPress
        If Asc(e.KeyChar) = 32 Then
            NewPasswordTextBox.Text = ""
            NewPasswordTextBox.Focus()
            MsgBox("Tidak Boleh Menggunakan Spasi !!!", vbInformation, "Information")
        End If
    End Sub

    Private Sub NewPasswordTextBox_Validated(sender As Object, e As EventArgs) Handles NewPasswordTextBox.Validated
        If NewPasswordTextBox.Text = "" Then
            ErrorProviderNO.SetError(NewPasswordTextBox, "Must be filled")
            ErrorProviderOK.SetError(NewPasswordTextBox, "")
            NewPasswordTextBox.Focus()
        ElseIf NewPasswordTextBox.Text.Length < 10 Then
            MsgBox("Password Terlalu Pendek!!", vbExclamation, "Warning - Tidak Aman")
            NewPasswordTextBox.Text = ""
            NewPasswordTextBox.Focus()
        Else
            ErrorProviderOK.SetError(NewPasswordTextBox, "Correct")
            ErrorProviderNO.SetError(NewPasswordTextBox, "")
        End If
    End Sub

    Private Sub ConfirmPasswordTextBox_Validated(sender As Object, e As EventArgs) Handles ConfirmPasswordTextBox.Validated
        If NewPasswordTextBox.Text <> ConfirmPasswordTextBox.Text Then
            MsgBox("Password Tidak Sama,Ketik Ulang Password !", vbInformation, "Information")
            NewPasswordTextBox.Text = ""
            ConfirmPasswordTextBox.Text = ""
            NewPasswordTextBox.Focus()
        Else
            ErrorProviderOK.SetError(ConfirmPasswordTextBox, "Correct")
            ErrorProviderNO.SetError(ConfirmPasswordTextBox, "")
        End If
    End Sub

    Private Sub ShowPasswordCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPasswordCheckBox.CheckedChanged
        If ShowPasswordCheckBox.Checked Then
            NewPasswordTextBox.PasswordChar = ""
            ConfirmPasswordTextBox.PasswordChar = ""
        Else
            NewPasswordTextBox.PasswordChar = "•"
            ConfirmPasswordTextBox.PasswordChar = "•"
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If OldPasswordTextBox.Text = "" Then
            ErrorProviderNO.SetError(OldPasswordTextBox, "Must be filled")
            ErrorProviderOK.SetError(OldPasswordTextBox, "")
            NewPasswordTextBox.Focus()
        ElseIf NewPasswordTextBox.Text = "" Then
            ErrorProviderNO.SetError(NewPasswordTextBox, "Must be filled")
            ErrorProviderOK.SetError(NewPasswordTextBox, "")
            NewPasswordTextBox.Focus()
        Else
            Dim HashedPass As String = ""
            Using MD5hash As MD5 = MD5.Create()
                HashedPass = System.Convert.ToBase64String(MD5hash.ComputeHash(System.Text.Encoding.ASCII.GetBytes(ConfirmPasswordTextBox.Text)))
            End Using
            Try
                Call OpenConnection()
                Using OLECMD As New MySqlCommand("UPDATE user SET password= @password WHERE  username='" & MainMenu.UserNameToolStripStatusLabel.Text & "'", conn)
                    OLECMD.Parameters.AddWithValue("@password", (HashedPass))
                    OLECMD.ExecuteNonQuery()
                End Using
                MsgBox("Password has been changed", vbInformation, "Success")
                conn.Close()
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class