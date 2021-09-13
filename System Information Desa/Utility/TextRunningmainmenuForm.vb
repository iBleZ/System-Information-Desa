Imports MySql.Data.MySqlClient
Public Class TextRunningmainmenuForm
    Private Sub TextRunningmainmenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call OpenConnection()
        Str = ("select*from textmainmenu")
        Dim OLECMD = New MySqlCommand(Str, conn)
        Dim OLEDR As MySqlDataReader
        OLEDR = OLECMD.ExecuteReader
        OLEDR.Read()
        If OLEDR.HasRows Then
            TextBoxrunning.Text = OLEDR.Item("runningtext")
        Else
            TextBoxrunning.Text = ""
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Call OpenConnection()
        Str = ("select*from textmainmenu")
        Dim OLECMD = New MySqlCommand(Str, conn)
        Dim OLEDR As MySqlDataReader
        OLEDR = OLECMD.ExecuteReader
        OLEDR.Read()
        If OLEDR.HasRows Then
            Try
                Call OpenConnection()
                Using CMD As New MySqlCommand("UPDATE textmainmenu SET runningtext=@runningtext", conn)
                    CMD.Parameters.AddWithValue("runningtext", (TextBoxrunning.Text))
                    CMD.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        Else
            Try
                Call OpenConnection()
                Str = "insert into textmainmenu (runningtext) values (@1)"
                Using CMD As New MySqlCommand(Str, conn)
                    With CMD
                        .Parameters.AddWithValue("@1", (TextBoxrunning.Text))
                        .ExecuteNonQuery()
                    End With
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
        MsgBox("Running Text in Main Menu has been changed", vbInformation, "Success")
        conn.Close()
        MainMenu.RunningtextToolStripLabel.Text = TextBoxrunning.Text
        Me.Close()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub
End Class