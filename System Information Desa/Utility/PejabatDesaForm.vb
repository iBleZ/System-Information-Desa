Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class PejabatDesaForm
    Private Sub Clear()
        Dim formControl As Control
        Dim txtBox As TextBox
        Dim comBox As ComboBox
        For Each formControl In Me.Controls
            If TypeOf formControl Is TextBox Then
                txtBox = TryCast(formControl, TextBox)
                txtBox.Text = ""
                txtBox.Enabled = False
                ErrorProviderOK.SetError(txtBox, "")
                ErrorProviderNO.SetError(txtBox, "")
            ElseIf TypeOf formControl Is ComboBox Then
                comBox = TryCast(formControl, ComboBox)
                comBox.Text = ""
                comBox.Enabled = False
                ErrorProviderOK.SetError(comBox, "")
                ErrorProviderNO.SetError(comBox, "")
            End If
        Next
        TanggalLahirDateTimePicker.Value = Date.Today
        TanggalLahirDateTimePicker.Format = DateTimePickerFormat.Custom
        TanggalLahirDateTimePicker.CustomFormat = "dd MMMM yyyy"
        TanggalLahirDateTimePicker.Enabled = False
        ErrorProviderOK.SetError(TanggalLahirDateTimePicker, "")
        ErrorProviderNO.SetError(TanggalLahirDateTimePicker, "")
        SaveButton.Enabled = False
    End Sub

    Sub Enableitm()
        Dim formControl As Control
        Dim txtBox As TextBox
        Dim comBox As ComboBox
        For Each formControl In Me.Controls
            If TypeOf formControl Is TextBox Then
                txtBox = TryCast(formControl, TextBox)
                txtBox.Enabled = True
            ElseIf TypeOf formControl Is ComboBox Then
                comBox = TryCast(formControl, ComboBox)
                comBox.Enabled = True
            End If
        Next
        TanggalLahirDateTimePicker.Enabled = True
        SaveButton.Enabled = True
    End Sub

    Private Sub PejabatDesaForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TeleponTextBox.MaxLength = 13
    End Sub

    Private Sub PejabatDesaForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        KadesRadioButton.Checked = False
        SekdesRadioButton.Checked = False
        Call Clear()
    End Sub

    Private Sub KadesRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles KadesRadioButton.CheckedChanged
        Call OpenConnection()
        Str = ("select*from pejabat where jabatan ='" & KadesRadioButton.Text & "'")
        Dim OLECMD = New MySqlCommand(Str, conn)
        Dim OLEDR As MySqlDataReader
        OLEDR = OLECMD.ExecuteReader
        OLEDR.Read()
        If OLEDR.HasRows Then
            NamaTextBox.Text = OLEDR.Item("nama")
            TempatLahirTextBox.Text = OLEDR.Item("tempatlahir")
            TanggalLahirDateTimePicker.Value = OLEDR.Item("tanggallahir")
            JenisKelaminComboBox.Text = OLEDR.Item("jeniskelamin")
            AgamaComboBox.Text = OLEDR.Item("agama")
            TeleponTextBox.Text = OLEDR.Item("telepon")
            EmailTextBox.Text = OLEDR.Item("email")
            AlamatTextBox.Text = OLEDR.Item("alamat")
        Else
            Call Clear()
        End If
        conn.Close()
        Call Enableitm()
    End Sub

    Private Sub SekdesRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SekdesRadioButton.CheckedChanged
        Call OpenConnection()
        Str = ("select*from pejabat where jabatan ='" & SekdesRadioButton.Text & "'")
        Dim OLECMD = New MySqlCommand(Str, conn)
        Dim OLEDR As MySqlDataReader
        OLEDR = OLECMD.ExecuteReader
        OLEDR.Read()
        If OLEDR.HasRows Then
            NamaTextBox.Text = OLEDR.Item("nama")
            TempatLahirTextBox.Text = OLEDR.Item("tempatlahir")
            TanggalLahirDateTimePicker.Value = OLEDR.Item("tanggallahir")
            JenisKelaminComboBox.Text = OLEDR.Item("jeniskelamin")
            AgamaComboBox.Text = OLEDR.Item("agama")
            TeleponTextBox.Text = OLEDR.Item("telepon")
            EmailTextBox.Text = OLEDR.Item("email")
            AlamatTextBox.Text = OLEDR.Item("alamat")
        Else
            Call Clear()
        End If
        conn.Close()
        Call Enableitm()
    End Sub

    Private Sub NamaTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NamaTextBox.KeyPress
        If e.KeyChar = Chr(13) Then
            TempatLahirTextBox.Focus()
        End If
    End Sub

    Private Sub NamaTextBox_Validating(sender As Object, e As CancelEventArgs) Handles NamaTextBox.Validating
        If NamaTextBox.Text = "" Then
            ErrorProviderNO.SetError(NamaTextBox, "Must be filled")
            ErrorProviderOK.SetError(NamaTextBox, "")
            e.Cancel = True
            Return
        Else
            ErrorProviderOK.SetError(NamaTextBox, "Correct")
            ErrorProviderNO.SetError(NamaTextBox, "")
        End If
    End Sub

    Private Sub TempatLahirTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TempatLahirTextBox.KeyPress
        If e.KeyChar = Chr(13) Then
            TanggalLahirDateTimePicker.Focus()
        End If
    End Sub

    Private Sub TempatLahirTextBox_Validating(sender As Object, e As CancelEventArgs) Handles TempatLahirTextBox.Validating
        If TempatLahirTextBox.Text = "" Then
            ErrorProviderNO.SetError(TempatLahirTextBox, "Must be filled")
            ErrorProviderOK.SetError(TempatLahirTextBox, "")
            e.Cancel = True
            Return
        Else
            ErrorProviderOK.SetError(TempatLahirTextBox, "Correct")
            ErrorProviderNO.SetError(TempatLahirTextBox, "")
        End If
    End Sub

    Private Sub TanggalLahirDateTimePicker_Validating(sender As Object, e As CancelEventArgs) Handles TanggalLahirDateTimePicker.Validating
        If TanggalLahirDateTimePicker.Value.Date = Date.Today Then
            ErrorProviderNO.SetError(TanggalLahirDateTimePicker, "Choose Date of Birth")
            ErrorProviderOK.SetError(TanggalLahirDateTimePicker, "")
            e.Cancel = True
            Return
        ElseIf TanggalLahirDateTimePicker.Value.Date > Date.Today Then
            ErrorProviderNO.SetError(TanggalLahirDateTimePicker, "Pilih Tanggal Lahir Dengan Benar")
            ErrorProviderOK.SetError(TanggalLahirDateTimePicker, "")
            e.Cancel = True
            Return
        ElseIf TanggalLahirDateTimePicker.Value.Date > #01/01/2005# Then
            ErrorProviderNO.SetError(TanggalLahirDateTimePicker, "Pilih Tanggal Lahir Dengan Benar")
            ErrorProviderOK.SetError(TanggalLahirDateTimePicker, "")
            e.Cancel = True
            Return
        Else
            ErrorProviderOK.SetError(TanggalLahirDateTimePicker, "Correct")
            ErrorProviderNO.SetError(TanggalLahirDateTimePicker, "")
        End If
    End Sub

    Private Sub JenisKelaminComboBox_Validating(sender As Object, e As CancelEventArgs) Handles JenisKelaminComboBox.Validating
        If JenisKelaminComboBox.Text = "Laki - Laki" Then
            ErrorProviderOK.SetError(JenisKelaminComboBox, "Correct")
            ErrorProviderNO.SetError(JenisKelaminComboBox, "")
        ElseIf JenisKelaminComboBox.Text = "Perempuan" Then
            ErrorProviderOK.SetError(JenisKelaminComboBox, "Correct")
            ErrorProviderNO.SetError(JenisKelaminComboBox, "")
        ElseIf JenisKelaminComboBox.Text = "" Then
            ErrorProviderNO.SetError(JenisKelaminComboBox, "Must be filled")
            ErrorProviderOK.SetError(JenisKelaminComboBox, "")
            e.Cancel = True
            Return
        Else
            ErrorProviderNO.SetError(JenisKelaminComboBox, "Pilih jenis kelamin")
            ErrorProviderOK.SetError(JenisKelaminComboBox, "")
            e.Cancel = True
            Return
        End If
    End Sub

    Private Sub AgamaComboBox_Validating(sender As Object, e As CancelEventArgs) Handles AgamaComboBox.Validating
        If AgamaComboBox.Text = "Islam" Then
            ErrorProviderOK.SetError(AgamaComboBox, "Correct")
            ErrorProviderNO.SetError(AgamaComboBox, "")
        ElseIf AgamaComboBox.Text = "Katolik" Then
            ErrorProviderOK.SetError(AgamaComboBox, "Correct")
            ErrorProviderNO.SetError(AgamaComboBox, "")
        ElseIf AgamaComboBox.Text = "Protestan" Then
            ErrorProviderOK.SetError(AgamaComboBox, "Correct")
            ErrorProviderNO.SetError(AgamaComboBox, "")
        ElseIf AgamaComboBox.Text = "Hindu" Then
            ErrorProviderOK.SetError(AgamaComboBox, "Correct")
            ErrorProviderNO.SetError(AgamaComboBox, "")
        ElseIf AgamaComboBox.Text = "Buddha" Then
            ErrorProviderOK.SetError(AgamaComboBox, "Correct")
            ErrorProviderNO.SetError(AgamaComboBox, "")
        ElseIf AgamaComboBox.Text = "Khonghucu" Then
            ErrorProviderOK.SetError(AgamaComboBox, "Correct")
            ErrorProviderNO.SetError(AgamaComboBox, "")
        ElseIf AgamaComboBox.Text = "" Then
            ErrorProviderNO.SetError(AgamaComboBox, "Must be filled")
            ErrorProviderOK.SetError(AgamaComboBox, "")
            e.Cancel = True
            Return
        Else
            ErrorProviderNO.SetError(AgamaComboBox, "Pilih Agama")
            ErrorProviderOK.SetError(AgamaComboBox, "")
            e.Cancel = True
            Return
        End If
    End Sub

    Private Sub TeleponTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TeleponTextBox.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub TeleponTextBox_Validating(sender As Object, e As CancelEventArgs) Handles TeleponTextBox.Validating
        If TeleponTextBox.Text = "" Then
            ErrorProviderNO.SetError(TeleponTextBox, "Must be filled")
            ErrorProviderOK.SetError(TeleponTextBox, "")
            e.Cancel = True
            Return
        ElseIf TeleponTextBox.Text.Length < 12 Then
            ErrorProviderNO.SetError(TeleponTextBox, "Anda Yakin No Telepon Sudah Benar?")
            ErrorProviderOK.SetError(TeleponTextBox, "")
            e.Cancel = True
            Return
        Else
            ErrorProviderOK.SetError(TeleponTextBox, "Correct")
            ErrorProviderNO.SetError(TeleponTextBox, "")
        End If
    End Sub

    Private Sub EmailTextBox_Validating(sender As Object, e As CancelEventArgs) Handles EmailTextBox.Validating
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        If System.Text.RegularExpressions.Regex.Match(EmailTextBox.Text, pattern).Success Then
            ErrorProviderOK.SetError(EmailTextBox, "Correct")
            ErrorProviderNO.SetError(EmailTextBox, "")
        Else
            ErrorProviderNO.SetError(EmailTextBox, "Invalid email Address!")
            ErrorProviderOK.SetError(EmailTextBox, "")
            e.Cancel = True
            Return
        End If
    End Sub

    Private Sub AlamatTextBox_Validating(sender As Object, e As CancelEventArgs) Handles AlamatTextBox.Validating
        If AlamatTextBox.Text = "" Then
            ErrorProviderNO.SetError(AlamatTextBox, "Must be filled")
            ErrorProviderOK.SetError(AlamatTextBox, "")
            e.Cancel = True
            Return
        Else
            ErrorProviderOK.SetError(AlamatTextBox, "Correct")
            ErrorProviderNO.SetError(AlamatTextBox, "")
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If KadesRadioButton.Checked = True Then
            Try
                If ValidateChildren() Then
                    Call OpenConnection()
                    Str = ("select*from pejabat where jabatan ='" & KadesRadioButton.Text & "'")
                    OLECMD = New MySqlCommand(Str, conn)
                    OLEDR = OLECMD.ExecuteReader
                    OLEDR.Read()
                    If OLEDR.HasRows Then
                        Call OpenConnection()
                        Using OLECMD As New MySqlCommand("UPDATE pejabat SET nama=@nama, tempatlahir=@tempatlahir, tanggallahir=@tanggallahir, jeniskelamin=@jeniskelamin, agama=@agama, telepon=@telepon, email=@email, alamat=@alamat  WHERE jabatan='" & KadesRadioButton.Text & "'", conn)
                            OLECMD.Parameters.AddWithValue("nama", (NamaTextBox.Text))
                            OLECMD.Parameters.AddWithValue("tempatlahir", (TempatLahirTextBox.Text))
                            OLECMD.Parameters.AddWithValue("tanggallahir", (TanggalLahirDateTimePicker.Value))
                            OLECMD.Parameters.AddWithValue("jeniskelamin", (JenisKelaminComboBox.Text))
                            OLECMD.Parameters.AddWithValue("agama", (AgamaComboBox.Text))
                            OLECMD.Parameters.AddWithValue("telepon", (TeleponTextBox.Text))
                            OLECMD.Parameters.AddWithValue("email", (EmailTextBox.Text))
                            OLECMD.Parameters.AddWithValue("alamat", (AlamatTextBox.Text))
                            OLECMD.ExecuteNonQuery()
                        End Using
                    Else
                        Call OpenConnection()
                        Str = "insert into pejabat (jabatan, nama, tempatlahir, tanggallahir, jeniskelamin, agama, telepon, email, alamat) values (@1,@2,@3,@4,@5,@6,@7,@8,@9)"
                        Using OLECMD As New MySqlCommand(Str, conn)
                            With OLECMD
                                .Parameters.AddWithValue("@1", (KadesRadioButton.Text))
                                .Parameters.AddWithValue("@2", (NamaTextBox.Text))
                                .Parameters.AddWithValue("@3", (TempatLahirTextBox.Text))
                                .Parameters.AddWithValue("@4", (TanggalLahirDateTimePicker.Value))
                                .Parameters.AddWithValue("@5", (JenisKelaminComboBox.Text))
                                .Parameters.AddWithValue("@6", (AgamaComboBox.Text))
                                .Parameters.AddWithValue("@7", (TeleponTextBox.Text))
                                .Parameters.AddWithValue("@8", (EmailTextBox.Text))
                                .Parameters.AddWithValue("@9", (AlamatTextBox.Text))
                                .ExecuteNonQuery()
                            End With
                        End Using
                    End If
                    MsgBox("Save successfully", vbInformation, "Success")
                    conn.Close()
                    KadesRadioButton.Checked = False
                    SekdesRadioButton.Checked = False
                    Call Clear()
                Else
                    MsgBox("Please check your entry data", MessageBoxIcon.Stop, "Attention")
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

        ElseIf SekdesRadioButton.Checked = True Then
            Try
                If ValidateChildren() Then
                    Call OpenConnection()
                    Str = ("select*from pejabat where jabatan ='" & SekdesRadioButton.Text & "'")
                    OLECMD = New MySqlCommand(Str, conn)
                    OLEDR = OLECMD.ExecuteReader
                    OLEDR.Read()
                    If OLEDR.HasRows Then
                        Call OpenConnection()
                        Using OLECMD As New MySqlCommand("UPDATE pejabat SET nama=@nama, tempatlahir=@tempatlahir, tanggallahir=@tanggallahir, jeniskelamin=@jeniskelamin, agama=@agama, telepon=@telepon, email=@email, alamat=@alamat  WHERE jabatan='" & SekdesRadioButton.Text & "'", conn)
                            OLECMD.Parameters.AddWithValue("nama", (NamaTextBox.Text))
                            OLECMD.Parameters.AddWithValue("tempatlahir", (TempatLahirTextBox.Text))
                            OLECMD.Parameters.AddWithValue("tanggallahir", (TanggalLahirDateTimePicker.Value))
                            OLECMD.Parameters.AddWithValue("jeniskelamin", (JenisKelaminComboBox.Text))
                            OLECMD.Parameters.AddWithValue("agama", (AgamaComboBox.Text))
                            OLECMD.Parameters.AddWithValue("telepon", (TeleponTextBox.Text))
                            OLECMD.Parameters.AddWithValue("email", (EmailTextBox.Text))
                            OLECMD.Parameters.AddWithValue("alamat", (AlamatTextBox.Text))
                            OLECMD.ExecuteNonQuery()
                        End Using
                    Else
                        Call OpenConnection()
                        Str = "insert into pejabat (jabatan, nama, tempatlahir, tanggallahir, jeniskelamin, agama, telepon, email, alamat) values (@1,@2,@3,@4,@5,@6,@7,@8,@9)"
                        Using OLECMD As New MySqlCommand(Str, conn)
                            With OLECMD
                                .Parameters.AddWithValue("@1", (SekdesRadioButton.Text))
                                .Parameters.AddWithValue("@2", (NamaTextBox.Text))
                                .Parameters.AddWithValue("@3", (TempatLahirTextBox.Text))
                                .Parameters.AddWithValue("@4", (TanggalLahirDateTimePicker.Value))
                                .Parameters.AddWithValue("@5", (JenisKelaminComboBox.Text))
                                .Parameters.AddWithValue("@6", (AgamaComboBox.Text))
                                .Parameters.AddWithValue("@7", (TeleponTextBox.Text))
                                .Parameters.AddWithValue("@8", (EmailTextBox.Text))
                                .Parameters.AddWithValue("@9", (AlamatTextBox.Text))
                                .ExecuteNonQuery()
                            End With
                        End Using
                    End If
                    MsgBox("Save successfully", vbInformation, "Success")
                    conn.Close()
                    KadesRadioButton.Checked = False
                    SekdesRadioButton.Checked = False
                    Call Clear()
                Else
                    MsgBox("Please check your entry data", MessageBoxIcon.Stop, "Attention")
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub
End Class