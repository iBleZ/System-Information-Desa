Imports MySql.Data.MySqlClient
Module Module1
    Public OLECMD As New MySqlCommand
    Public OLEDR As MySqlDataReader
    Public OLEDA As New MySqlDataAdapter
    Public conn As New MySqlConnection
    Public ds As New DataSet
    Public dt As New DataTable
    Public lokasidata As String
    Public Str As String
    Public Sub OpenConnection()
        Try
            Dim lokasidata As String = "Server=localhost;user id=root;password=;database=systeminformation"
            conn = New MySqlConnection(lokasidata)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Connection to database failed ", MsgBoxStyle.Critical, "Error")
            LoginForm.Close()
        End Try
    End Sub
    Public Sub ClearTextBoxInBox(ByVal grb As GroupBox)
        For Each Control As Control In grb.Controls
            If TypeOf Control Is TextBox Then
                CType(Control, TextBox).Text = String.Empty
            ElseIf TypeOf Control Is ComboBox Then
                CType(Control, ComboBox).Text = String.Empty
            End If
        Next
    End Sub
End Module
