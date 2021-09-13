Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Imports System.Security.Cryptography
Public Class LupaPasswordForm
    Private Sub LupaPasswordForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        PasswordTextBox.PasswordChar = "•"
        ConfirmPasswordTextBox.PasswordChar = "•"
        GroupBox2.Enabled = False
        UserNameTextBox.Focus()
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Call OpenConnection()
        Dim OLECMD As New MySqlDataAdapter("Select*From user where username ='" & UserNameTextBox.Text & "' AND pertanyaan ='" & PertanyaanComboBox.Text & "' AND jawaban ='" & JawabanTextBox.Text & "' ", conn)
        Dim OLEDR As New DataTable
        OLECMD.Fill(OLEDR)
        If OLEDR.Rows.Count = False Then
            MsgBox("Data yang anda berikan salah, Mohon Periksa Kembali !!!", MessageBoxIcon.Stop, "Warning")
            Call ClearTextBoxInBox(GroupBox1)
        Else
            GroupBox2.Enabled = True
            PasswordTextBox.Focus()
        End If
    End Sub

    Private Sub PasswordTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PasswordTextBox.KeyPress
        If Asc(e.KeyChar) = 32 Then
            ErrorProviderOK.SetError(PasswordTextBox, "")
            ErrorProviderNO.SetError(PasswordTextBox, "Tidak Boleh Menggunakan Spasi !!!")
            PasswordTextBox.Focus()
            PasswordTextBox.Text = ""
        ElseIf Asc(e.KeyChar) = 13 Then
            ConfirmPasswordTextBox.Focus()
        End If
    End Sub

    Private Sub PasswordTextBox_Validating(sender As Object, e As CancelEventArgs) Handles PasswordTextBox.Validating
        If PasswordTextBox.Text.Length < 10 Then
            ErrorProviderOK.SetError(PasswordTextBox, "")
            ErrorProviderNO.SetError(PasswordTextBox, "Password tidak diizinkan kurang dari 10 karakter")
            PasswordTextBox.Focus()
        Else
            ErrorProviderOK.SetError(PasswordTextBox, "Correct")
            ErrorProviderNO.SetError(PasswordTextBox, "")
        End If
    End Sub

    Private Sub ConfirmPasswordTextBox_Validating(sender As Object, e As CancelEventArgs) Handles ConfirmPasswordTextBox.Validating
        If PasswordTextBox.Text <> ConfirmPasswordTextBox.Text Then
            ErrorProviderOK.SetError(ConfirmPasswordTextBox, "")
            ErrorProviderNO.SetError(ConfirmPasswordTextBox, "Password Tidak Sama,Ketik Ulang Password !")
            ConfirmPasswordTextBox.Focus()
        ElseIf PasswordTextBox.Text = ConfirmPasswordTextBox.Text Then
            ErrorProviderOK.SetError(ConfirmPasswordTextBox, "Correct")
            ErrorProviderNO.SetError(ConfirmPasswordTextBox, "")
        Else
            ErrorProviderOK.SetError(ConfirmPasswordTextBox, "")
            ErrorProviderNO.SetError(ConfirmPasswordTextBox, "")
        End If
    End Sub

    Private Sub ConfirmPasswordTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ConfirmPasswordTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If PasswordTextBox.Text <> ConfirmPasswordTextBox.Text Then
                ErrorProviderOK.SetError(ConfirmPasswordTextBox, "")
                ErrorProviderNO.SetError(ConfirmPasswordTextBox, "Password Tidak Sama,Ketik Ulang Password !")
                ConfirmPasswordTextBox.Focus()
            Else
                ErrorProviderOK.SetError(ConfirmPasswordTextBox, "Correct")
                ErrorProviderNO.SetError(ConfirmPasswordTextBox, "")
            End If
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

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim HashedPass As String = ""
        Using MD5hash As MD5 = MD5.Create()
            HashedPass = System.Convert.ToBase64String(MD5hash.ComputeHash(System.Text.Encoding.ASCII.GetBytes(ConfirmPasswordTextBox.Text)))
        End Using
        If PasswordTextBox.Text = "" Then
            PasswordTextBox.Focus()
        ElseIf ConfirmPasswordTextBox.Text = "" Then
            ConfirmPasswordTextBox.Focus()
        ElseIf PasswordTextBox.Text <> ConfirmPasswordTextBox.Text Then
            MsgBox("Password Tidak Sama,Ketik Ulang Password", MessageBoxIcon.Stop, "Warning")
            GroupBox2.Enabled = True
            ConfirmPasswordTextBox.Focus()
        Else
            Try
                Call OpenConnection()
                Using OLECMD As New MySqlCommand("UPDATE user SET password= @password WHERE  username='" & UserNameTextBox.Text & "'", conn)
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

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Call ClearTextBoxInBox(GroupBox1)
        Call ClearTextBoxInBox(GroupBox2)
        Me.Close()
    End Sub
End Class