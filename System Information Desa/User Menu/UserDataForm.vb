Imports MySql.Data.MySqlClient
Public Class UserDataForm
    Sub RefreshDataView()
        Call OpenConnection()
        Dim AccessQuery As String = " SELECT * FROM user "
        Dim OLECMD As New MySqlCommand
        Dim OLEDA As New MySqlDataAdapter
        Dim dt As New DataTable
        With OLECMD
            .CommandText = AccessQuery
            .Connection = conn
        End With
        With OLEDA
            .SelectCommand = OLECMD
            .Fill(dt)
        End With
        DataGridView1.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            With DataGridView1
                .Rows.Add(dt.Rows(i)("username"), dt.Rows(i)("jabatan"), dt.Rows(i)("nip"), dt.Rows(i)("nama"), dt.Rows(i)("telepon"), dt.Rows(i)("email"))
            End With
        Next
        For rowNum As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(rowNum).HeaderCell.Value = (rowNum + 1).ToString
        Next
    End Sub

    Private Sub UserDataForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call RefreshDataView()
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Dim baris = DataGridView1.CurrentRow.Index
        With DataGridView1
            MainMenu.EditUserToolStripMenuItem.PerformClick()
            EditUserForm.CariTextBox.Text = .Item(0, baris).Value
            EditUserForm.CariButton.PerformClick()
            Me.Close()
        End With
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class