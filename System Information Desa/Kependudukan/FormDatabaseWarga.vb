Imports MySql.Data.MySqlClient
Public Class FormDatabaseWarga
    Private searchIndex As Integer = -1
    Sub RefreshDataView()
        Call OpenConnection()
        Dim AccessQuery As String = " SELECT * FROM penduduk "
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
                .Rows.Add(dt.Rows(i)("NIK"), dt.Rows(i)("nokk"), dt.Rows(i)("nama"), dt.Rows(i)("jeniskelamin"), dt.Rows(i)("tempatlahir"), dt.Rows(i)("tanggallahir"), dt.Rows(i)("alamat"), dt.Rows(i)("rt"), dt.Rows(i)("rw"), dt.Rows(i)("desa"))
            End With
        Next
        For rowNum As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(rowNum).HeaderCell.Value = (rowNum + 1).ToString
        Next
        conn.Close()
    End Sub

    Private Sub FormDatabaseWarga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDataView()
        CariTextBox.Focus()
        CariTextBox.MaxLength = 16
    End Sub

    Private Sub CariTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CariTextBox.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub CariTextBox_TextChanged(sender As Object, e As EventArgs) Handles CariTextBox.TextChanged
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            searchIndex = (searchIndex + 1) Mod DataGridView1.Rows.Count
            Dim row As DataGridViewRow = DataGridView1.Rows(searchIndex)
            If row.Cells("NIK").Value Is Nothing Then
                MsgBox("NIK Not Found", MsgBoxStyle.Critical, "Info")
                CariTextBox.Text = ""
                CariTextBox.Focus()
                Continue For
            End If

            If row.Cells("NIK").Value.ToString().Trim() = CariTextBox.Text Then
                DataGridView1.CurrentCell = row.Cells("NIK")
                DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.Rows(row.Index).Index
                Return
            End If
        Next
    End Sub

    Private Sub Buttoncari_Click(sender As Object, e As EventArgs) Handles Buttoncari.Click
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            searchIndex = (searchIndex + 1) Mod DataGridView1.Rows.Count
            Dim row As DataGridViewRow = DataGridView1.Rows(searchIndex)
            If row.Cells("NIK").Value Is Nothing Then
                MsgBox("NIK Not Found", MsgBoxStyle.Critical, "Info")
                CariTextBox.Text = ""
                CariTextBox.Focus()
                Continue For
            End If

            If row.Cells("NIK").Value.ToString().Trim() = CariTextBox.Text Then
                DataGridView1.CurrentCell = row.Cells("NIK")
                DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.Rows(row.Index).Index
                Return
            End If
        Next
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Dim i As Integer
        i = DataGridView1.SelectedCells(0).RowIndex
        EditDataPenduduk.Label17.Text = DataGridView1.Rows(i).Cells(0).Value.ToString()
        MainMenu.EditDataToolStripMenuItem.PerformClick()
        Me.Close()
    End Sub
End Class