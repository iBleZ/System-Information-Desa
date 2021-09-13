Imports MySql.Data.MySqlClient
Public Class MainMenu
    Dim i As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim abc As String = Microsoft.VisualBasic.Left(RunningtextToolStripLabel.Text, 1)
        Dim def As String = Microsoft.VisualBasic.Right(RunningtextToolStripLabel.Text, Len(RunningtextToolStripLabel.Text) - 1)
        RunningtextToolStripLabel.Text = def + abc
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If RunningtextToolStripLabel.ForeColor = Color.Red Then
            RunningtextToolStripLabel.ForeColor = Color.Green
        ElseIf RunningtextToolStripLabel.ForeColor = Color.Green Then
            RunningtextToolStripLabel.ForeColor = Color.Blue
        ElseIf RunningtextToolStripLabel.ForeColor = Color.Blue Then
            RunningtextToolStripLabel.ForeColor = Color.White
        Else
            RunningtextToolStripLabel.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim v As Integer = i + 1
        i = v
        If i = 2 Then
            i = 0
        End If
        If i Mod 2 = 0 Then
            RunningtextToolStripLabel.Visible = True
        Else
            RunningtextToolStripLabel.Visible = False
        End If
    End Sub

    Private Sub MainMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        LoginForm.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        LoginForm.Close()
    End Sub

    Private Sub LogoutToolStripButton_Click(sender As Object, e As EventArgs) Handles LogoutToolStripButton.Click
        Me.Close()
        LoginForm.Close()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Call OpenConnection()
            Str = ("select*from textmainmenu")
            Dim OLECMD = New MySqlCommand(Str, conn)
            Dim OLEDR As MySqlDataReader
            OLEDR = OLECMD.ExecuteReader
            OLEDR.Read()
            If OLEDR.HasRows Then
                RunningtextToolStripLabel.Text = OLEDR.Item("runningtext")
            Else
                RunningtextToolStripLabel.Text = "     System Information     "
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        If PhotoUserToolStripButton.Text = "Operator" Then
            AdministratorToolStripMenuItem.Visible = False
        ElseIf PhotoUserToolStripButton.Text = "Pengawas" Then
            AdministratorToolStripMenuItem.Visible = False
        End If
    End Sub

    Private Sub HomeToolStripButton_Click(sender As Object, e As EventArgs) Handles HomeToolStripButton.Click
        For Each fc As Form In MdiChildren
            fc.Close()
            fc.Hide()
        Next
        'FormKependudukan.AddPendudukUserControl.Hide()
        'FormKependudukan.Hide()
    End Sub

    Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem.Click
        For Each fc As Form In Me.MdiChildren
            fc.Close()
        Next
        AddUserForm.Show()
        AddUserForm.MdiParent = Me
    End Sub

    Private Sub EditUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditUserToolStripMenuItem.Click
        For Each fc As Form In Me.MdiChildren
            fc.Close()
        Next
        EditUserForm.Show()
        EditUserForm.MdiParent = Me
    End Sub

    Private Sub UserDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserDataToolStripMenuItem.Click
        For Each fc As Form In Me.MdiChildren
            fc.Close()
        Next
        UserDataForm.ShowDialog()
    End Sub

    Private Sub PejabatDesaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PejabatDesaToolStripMenuItem.Click
        For Each fc As Form In Me.MdiChildren
            fc.Close()
        Next
        PejabatDesaForm.ShowDialog()
    End Sub

    Private Sub LogoDaerahToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoDaerahToolStripMenuItem.Click
        For Each fc As Form In Me.MdiChildren
            fc.Close()
        Next
        LogoForm.ShowDialog()
    End Sub

    Private Sub KopSuratToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KopSuratToolStripMenuItem.Click
        For Each fc As Form In Me.MdiChildren
            fc.Close()
        Next
        KopSuratForm.ShowDialog()
    End Sub

    Private Sub RuningTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RuningTextToolStripMenuItem.Click
        For Each fc As Form In Me.MdiChildren
            fc.Close()
        Next
        TextRunningmainmenuForm.ShowDialog()
    End Sub

    Private Sub UserInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserInformationToolStripMenuItem.Click
        For Each fc As Form In Me.MdiChildren
            fc.Close()
        Next
        UserInformationForm.Show()
        UserInformationForm.MdiParent = Me
    End Sub

    Private Sub PhotoUserToolStripButton_Click(sender As Object, e As EventArgs) Handles PhotoUserToolStripButton.Click
        For Each fc As Form In Me.MdiChildren
            fc.Close()
        Next
        UserInformationForm.Show()
        UserInformationForm.MdiParent = Me
    End Sub

    Private Sub AddDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddDataToolStripMenuItem.Click
        For Each fc As Form In Me.MdiChildren
            fc.Close()
        Next
        FormKependudukan.Show()

        FormKependudukan.MdiParent = Me
    End Sub
End Class
