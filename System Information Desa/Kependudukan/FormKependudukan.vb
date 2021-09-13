Imports MySql.Data.MySqlClient
Public Class FormKependudukan
    Sub IsiTabel()
        Dim i As Integer = KartuKeluarga1.DataGridView1.Rows.Add()
        KartuKeluarga1.DataGridView1.Rows.Item(i).Cells("nama").Value = AddDataPenduduk2.NamaLengkap.Text
        KartuKeluarga1.DataGridView1.Rows.Item(i).Cells("NIK").Value = AddDataPenduduk2.NIK.Text
        KartuKeluarga1.DataGridView1.Rows.Item(i).Cells("jeniskelamin").Value = AddDataPenduduk2.JenisKelamin.Text
        KartuKeluarga1.DataGridView1.Rows.Item(i).Cells("tempatlahir").Value = AddDataPenduduk2.TempatLahir.Text
        KartuKeluarga1.DataGridView1.Rows.Item(i).Cells("tanggallahir").Value = AddDataPenduduk2.TanggalLahir.Text
        KartuKeluarga1.DataGridView1.Rows.Item(i).Cells("agama").Value = AddDataPenduduk2.Agama.Text
        KartuKeluarga1.DataGridView1.Rows.Item(i).Cells("pendidikan").Value = AddDataPenduduk2.Pendidikan.Text
        KartuKeluarga1.DataGridView1.Rows.Item(i).Cells("jenispekarjaan").Value = AddDataPenduduk2.JenisPekarjaan.Text
        KartuKeluarga1.DataGridView1.Rows.Item(i).Cells("golongandarah").Value = AddDataPenduduk2.GolonganDarah.Text
        KartuKeluarga1.DataGridView2.Rows.Item(i).Cells("status").Value = AddDataPenduduk2.StatusPerkawinan.Text
        KartuKeluarga1.DataGridView2.Rows.Item(i).Cells("tglperkawinan").Value = AddDataPenduduk2.TanggalPerkawinan.Text
        KartuKeluarga1.DataGridView2.Rows.Item(i).Cells("statushubungan").Value = AddDataPenduduk2.StatusHubunganDalamKeluarga.Text
        KartuKeluarga1.DataGridView2.Rows.Item(i).Cells("kewarganegaraan").Value = AddDataPenduduk2.Kewarganegaraan.Text
        KartuKeluarga1.DataGridView2.Rows.Item(i).Cells("paspor").Value = AddDataPenduduk2.NoPaspor.Text
        KartuKeluarga1.DataGridView2.Rows.Item(i).Cells("kitap").Value = AddDataPenduduk2.NoKitap.Text
        KartuKeluarga1.DataGridView2.Rows.Item(i).Cells("ayah").Value = AddDataPenduduk2.Ayah.Text
        KartuKeluarga1.DataGridView2.Rows.Item(i).Cells("ibu").Value = AddDataPenduduk2.Ibu.Text
    End Sub

    Private Sub InsertButton_Click(sender As Object, e As EventArgs) Handles InsertButton.Click
        If AddDataPenduduk2.ValidateChildren Then
            IsiTabel()
            For rowNum As Integer = 0 To KartuKeluarga1.DataGridView1.Rows.Count - 1
                KartuKeluarga1.DataGridView1.Rows(rowNum).HeaderCell.Value = (rowNum + 1).ToString
            Next
            For rowNum As Integer = 0 To KartuKeluarga1.DataGridView2.Rows.Count - 1
                KartuKeluarga1.DataGridView2.Rows(rowNum).HeaderCell.Value = (rowNum + 1).ToString
            Next
            AddDataPenduduk2.ClearErp()
            ClearTextBoxInBox(AddDataPenduduk2.GroupBox2)
        Else
            MsgBox("Please check your entry data", MessageBoxIcon.Stop, "Attention")
        End If
    End Sub

    Private Sub CancelButton1_Click(sender As Object, e As EventArgs) Handles CancelButton1.Click
        If AddDataPenduduk2.ValidateChildren Then
            ClearTextBoxInBox(AddDataPenduduk2.GroupBox1)
            ClearTextBoxInBox(AddDataPenduduk2.GroupBox2)
            AddDataPenduduk2.ClearErp()
        Else
            ClearTextBoxInBox(AddDataPenduduk2.GroupBox1)
            ClearTextBoxInBox(AddDataPenduduk2.GroupBox2)
            AddDataPenduduk2.ClearErp()
        End If
    End Sub

    Private Sub ClearTabelButton_Click(sender As Object, e As EventArgs) Handles ClearTabelButton.Click
        KartuKeluarga1.DataGridView1.Rows.Clear()
        KartuKeluarga1.DataGridView2.Rows.Clear()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub SaveButton1_Click(sender As Object, e As EventArgs) Handles SaveButton1.Click
        Try
            For Each row As DataGridViewRow In KartuKeluarga1.DataGridView1.Rows
                Str = ("select*from penduduk where NIK = '" & row.Cells("NIK").Value & "'")
                Call OpenConnection()
                OLECMD = New MySqlCommand(Str, conn)
                OLEDR = OLECMD.ExecuteReader
                OLEDR.Read()
                If OLEDR.HasRows Then

                    MsgBox("data ada", vbInformation, "Success")

                Else
                    Try
                        Call OpenConnection()
                        Str = "INSERT INTO penduduk VALUES (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@16,@17,@18,@19,@20,@21,@22,@23,@24,@25,@26,@27)"
                        Using OLECMD As New MySqlCommand(Str, conn)
                            With OLECMD
                                .Parameters.AddWithValue("@1", row.Cells("NIK").Value)
                                .Parameters.AddWithValue("@2", row.Cells("nama").Value)
                                .Parameters.AddWithValue("@3", row.Cells("jeniskelamin").Value)
                                .Parameters.AddWithValue("@4", row.Cells("tempatlahir").Value)
                                .Parameters.AddWithValue("@5", row.Cells("tanggallahir").Value)
                                .Parameters.AddWithValue("@6", row.Cells("agama").Value)
                                .Parameters.AddWithValue("@7", row.Cells("pendidikan").Value)
                                .Parameters.AddWithValue("@8", row.Cells("jenispekarjaan").Value)
                                .Parameters.AddWithValue("@9", row.Cells("golongandarah").Value)

                                .Parameters.AddWithValue("@10", row.Cells("status").Value)
                                .Parameters.AddWithValue("@11", row.Cells("tglperkawinan").Value)
                                .Parameters.AddWithValue("@12", row.Cells("statushubungan").Value)
                                .Parameters.AddWithValue("@13", row.Cells("kewarganegaraan").Value)
                                .Parameters.AddWithValue("@14", row.Cells("paspor").Value)
                                .Parameters.AddWithValue("@15", row.Cells("kitap").Value)
                                .Parameters.AddWithValue("@16", row.Cells("ayah").Value)
                                .Parameters.AddWithValue("@17", row.Cells("ibu").Value)

                                .Parameters.AddWithValue("@18", AddDataPenduduk2.KK.Text)
                                .Parameters.AddWithValue("@19", AddDataPenduduk2.KepalaKeluarga.Text)
                                .Parameters.AddWithValue("@20", AddDataPenduduk2.Alamat.Text)
                                .Parameters.AddWithValue("@21", AddDataPenduduk2.RT.Text)
                                .Parameters.AddWithValue("@22", AddDataPenduduk2.RW.Text)
                                .Parameters.AddWithValue("@23", AddDataPenduduk2.KodePos.Text)
                                .Parameters.AddWithValue("@24", AddDataPenduduk2.DesaKelurahan.Text)
                                .Parameters.AddWithValue("@25", AddDataPenduduk2.Kecamatan.Text)
                                .Parameters.AddWithValue("@26", AddDataPenduduk2.KabupatenKota.Text)
                                .Parameters.AddWithValue("@27", AddDataPenduduk2.Provinsi.Text)
                                .ExecuteNonQuery()
                                conn.Close()
                                MsgBox("Save successfully", vbInformation, "Success")
                            End With
                        End Using
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                    End Try

                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
End Class