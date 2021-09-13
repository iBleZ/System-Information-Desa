Imports MySql.Data.MySqlClient
Public Class FormKependudukan
    Sub IsiTabel()
        Dim i As Integer = KartuKeluarga1.DataGridView1.Rows.Add()
        KartuKeluarga1.DataGridView1.Rows.Item(i).Cells("nama").Value = AddDataPenduduk1.NamaLengkap.Text
        KartuKeluarga1.DataGridView1.Rows.Item(i).Cells("NIK").Value = AddDataPenduduk1.NIK.Text
        KartuKeluarga1.DataGridView1.Rows.Item(i).Cells("jeniskelamin").Value = AddDataPenduduk1.JenisKelamin.Text
        KartuKeluarga1.DataGridView1.Rows.Item(i).Cells("tempatlahir").Value = AddDataPenduduk1.TempatLahir.Text
        KartuKeluarga1.DataGridView1.Rows.Item(i).Cells("tanggallahir").Value = AddDataPenduduk1.TanggalLahir.Text
        KartuKeluarga1.DataGridView1.Rows.Item(i).Cells("agama").Value = AddDataPenduduk1.Agama.Text
        KartuKeluarga1.DataGridView1.Rows.Item(i).Cells("pendidikan").Value = AddDataPenduduk1.Pendidikan.Text
        KartuKeluarga1.DataGridView1.Rows.Item(i).Cells("jenispekarjaan").Value = AddDataPenduduk1.JenisPekarjaan.Text
        KartuKeluarga1.DataGridView1.Rows.Item(i).Cells("golongandarah").Value = AddDataPenduduk1.GolonganDarah.Text
        KartuKeluarga1.DataGridView1.Rows.Item(i).Cells("status").Value = AddDataPenduduk1.StatusPerkawinan.Text
        KartuKeluarga1.DataGridView1.Rows.Item(i).Cells("tglperkawinan").Value = AddDataPenduduk1.TanggalPerkawinan.Text
        KartuKeluarga1.DataGridView1.Rows.Item(i).Cells("statushubungan").Value = AddDataPenduduk1.StatusHubunganDalamKeluarga.Text
        KartuKeluarga1.DataGridView1.Rows.Item(i).Cells("kewarganegaraan").Value = AddDataPenduduk1.Kewarganegaraan.Text
        KartuKeluarga1.DataGridView1.Rows.Item(i).Cells("paspor").Value = AddDataPenduduk1.NoPaspor.Text
        KartuKeluarga1.DataGridView1.Rows.Item(i).Cells("kitap").Value = AddDataPenduduk1.NoKitap.Text
        KartuKeluarga1.DataGridView1.Rows.Item(i).Cells("ayah").Value = AddDataPenduduk1.Ayah.Text
        KartuKeluarga1.DataGridView1.Rows.Item(i).Cells("ibu").Value = AddDataPenduduk1.Ibu.Text
    End Sub

    Private Sub FormKependudukan_Load(sender As Object, e As EventArgs) Handles Me.Load
        ButtonClose.Focus()
    End Sub

    Private Sub InsertButton_Click(sender As Object, e As EventArgs) Handles InsertButton.Click
        If AddDataPenduduk1.ValidateChildren Then
            IsiTabel()
            For rowNum As Integer = 0 To KartuKeluarga1.DataGridView1.Rows.Count - 1
                KartuKeluarga1.DataGridView1.Rows(rowNum).HeaderCell.Value = (rowNum + 1).ToString
            Next
            AddDataPenduduk1.ClearErp()
            ClearTextBoxInBox(AddDataPenduduk1.GroupBox2)
        Else
            MsgBox("Please check your entry data", MessageBoxIcon.Stop, "Attention")
        End If
    End Sub

    Private Sub CancelButton1_Click(sender As Object, e As EventArgs) Handles CancelButton1.Click
        If Not AddDataPenduduk1.ValidateChildren Then
            ClearTextBoxInBox(AddDataPenduduk1.GroupBox1)
            ClearTextBoxInBox(AddDataPenduduk1.GroupBox2)
            AddDataPenduduk1.ClearErp()
        End If
    End Sub

    Private Sub ClearTabelButton_Click(sender As Object, e As EventArgs) Handles ClearTabelButton.Click
        KartuKeluarga1.DataGridView1.Rows.Clear()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub SaveButton1_Click(sender As Object, e As EventArgs) Handles SaveButton1.Click
        If KartuKeluarga1.DataGridView1.CurrentCell Is Nothing Then
            MsgBox("Anda belum mengentry data ke tabel", MessageBoxIcon.Stop, "Attention")
        Else
            Try
                For Each row As DataGridViewRow In KartuKeluarga1.DataGridView1.Rows
                    Str = ("select*from penduduk where NIK = '" & row.Cells("NIK").Value & "'")
                    Call OpenConnection()
                    OLECMD = New MySqlCommand(Str, conn)
                    OLEDR = OLECMD.ExecuteReader
                    OLEDR.Read()
                    If OLEDR.HasRows Then
                        Call OpenConnection()
                        Str = "UPDATE penduduk SET nama=@2, jeniskelamin=@3, tempatlahir=@4, tanggallahir=@5, agama=@6, pendidikan=@7, pekerjaan=@8, golongandarah=@9, statusperkawinan=@10, tanggalperkawinan=@11, statushubungan=@12, kewarganegaraan=@13, paspor=@14, kitap=@15, ayah=@16, ibu=@17, nokk=@18, kepalakeluarga=@19, alamat=@20, rt=@21, rw=@22, kodepos=@23, desa=@24, kecamatan=@25, kabupaten=@26, provinsi=@27 WHERE NIK = '" & row.Cells("NIK").Value & "'"
                        Using OLECMD As New MySqlCommand(Str, conn)
                            With OLECMD
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
                                .Parameters.AddWithValue("@18", AddDataPenduduk1.KK.Text)
                                .Parameters.AddWithValue("@19", AddDataPenduduk1.KepalaKeluarga.Text)
                                .Parameters.AddWithValue("@20", AddDataPenduduk1.Alamat.Text)
                                .Parameters.AddWithValue("@21", AddDataPenduduk1.RT.Text)
                                .Parameters.AddWithValue("@22", AddDataPenduduk1.RW.Text)
                                .Parameters.AddWithValue("@23", AddDataPenduduk1.KodePos.Text)
                                .Parameters.AddWithValue("@24", AddDataPenduduk1.DesaKelurahan.Text)
                                .Parameters.AddWithValue("@25", AddDataPenduduk1.Kecamatan.Text)
                                .Parameters.AddWithValue("@26", AddDataPenduduk1.KabupatenKota.Text)
                                .Parameters.AddWithValue("@27", AddDataPenduduk1.Provinsi.Text)
                                .ExecuteNonQuery()
                                conn.Close()
                            End With
                        End Using
                    Else
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
                                .Parameters.AddWithValue("@18", AddDataPenduduk1.KK.Text)
                                .Parameters.AddWithValue("@19", AddDataPenduduk1.KepalaKeluarga.Text)
                                .Parameters.AddWithValue("@20", AddDataPenduduk1.Alamat.Text)
                                .Parameters.AddWithValue("@21", AddDataPenduduk1.RT.Text)
                                .Parameters.AddWithValue("@22", AddDataPenduduk1.RW.Text)
                                .Parameters.AddWithValue("@23", AddDataPenduduk1.KodePos.Text)
                                .Parameters.AddWithValue("@24", AddDataPenduduk1.DesaKelurahan.Text)
                                .Parameters.AddWithValue("@25", AddDataPenduduk1.Kecamatan.Text)
                                .Parameters.AddWithValue("@26", AddDataPenduduk1.KabupatenKota.Text)
                                .Parameters.AddWithValue("@27", AddDataPenduduk1.Provinsi.Text)
                                .ExecuteNonQuery()
                                conn.Close()
                            End With
                        End Using
                    End If
                Next
                MsgBox("Save successfully", vbInformation, "Success")
                ClearTextBoxInBox(AddDataPenduduk1.GroupBox1)
                ClearTextBoxInBox(AddDataPenduduk1.GroupBox2)
                AddDataPenduduk1.ClearErp()
                KartuKeluarga1.DataGridView1.Rows.Clear()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class