Imports System.ComponentModel
Public Class AddDataPenduduk
    Sub ClearErp()
        Dim formControl As Control
        Dim txtBox As TextBox
        Dim comBox As ComboBox
        For Each formControl In GroupBox1.Controls
            If TypeOf formControl Is TextBox Then
                txtBox = TryCast(formControl, TextBox)
                ErrorProviderOK.SetError(txtBox, "")
                ErrorProviderNO.SetError(txtBox, "")
            ElseIf TypeOf formControl Is ComboBox Then
                comBox = TryCast(formControl, ComboBox)
                ErrorProviderOK.SetError(comBox, "")
                ErrorProviderNO.SetError(comBox, "")
            End If
        Next
        For Each formControl In GroupBox2.Controls
            If TypeOf formControl Is TextBox Then
                txtBox = TryCast(formControl, TextBox)
                ErrorProviderOK.SetError(txtBox, "")
                ErrorProviderNO.SetError(txtBox, "")
            ElseIf TypeOf formControl Is ComboBox Then
                comBox = TryCast(formControl, ComboBox)
                ErrorProviderOK.SetError(comBox, "")
                ErrorProviderNO.SetError(comBox, "")
            End If
        Next
        TanggalLahir.Value = Date.Today
        TanggalLahir.Format = DateTimePickerFormat.Custom
        TanggalLahir.CustomFormat = "dd MMMM yyyy"
        ErrorProviderOK.SetError(TanggalLahir, "")
        ErrorProviderNO.SetError(TanggalLahir, "")
    End Sub

    Private Sub AddDataPenduduk_Load(sender As Object, e As EventArgs) Handles Me.Load
        ClearErp()
        KK.MaxLength = 16
        KodePos.MaxLength = 6
        NIK.MaxLength = 16
        GolonganDarah.MaxLength = 15
        RT.MaxLength = 3
        RW.MaxLength = 3
    End Sub

    Private Sub KK_Validating(sender As Object, e As CancelEventArgs) Handles KK.Validating
        If KK.Text = "" Then
            ErrorProviderNO.SetError(KK, "Must be filled")
            ErrorProviderOK.SetError(KK, "")
            e.Cancel = True
            Return
        ElseIf KK.Text.Length < 16 Then
            ErrorProviderNO.SetError(KK, "Isikan No KK dengan benar!!")
            ErrorProviderOK.SetError(KK, "")
            e.Cancel = True
            Return
        ElseIf IsNumeric(KK.Text) Then
            ErrorProviderOK.SetError(KK, "Correct")
            ErrorProviderNO.SetError(KK, "")
        Else
            ErrorProviderNO.SetError(KK, "Isikan No KK dengan benar!")
            ErrorProviderOK.SetError(KK, "")
            e.Cancel = True
            Return
        End If
    End Sub

    Private Sub KepalaKeluarga_Validating(sender As Object, e As CancelEventArgs) Handles KepalaKeluarga.Validating
        If KepalaKeluarga.Text = "" Then
            ErrorProviderNO.SetError(KepalaKeluarga, "Must be filled")
            ErrorProviderOK.SetError(KepalaKeluarga, "")
            e.Cancel = True
            Return
        Else
            ErrorProviderOK.SetError(KepalaKeluarga, "Correct")
            ErrorProviderNO.SetError(KepalaKeluarga, "")
        End If
    End Sub

    Private Sub Alamat_Validating(sender As Object, e As CancelEventArgs) Handles Alamat.Validating
        If Alamat.Text = "" Then
            ErrorProviderNO.SetError(Alamat, "Must be filled")
            ErrorProviderOK.SetError(Alamat, "")
            e.Cancel = True
            Return
        Else
            ErrorProviderOK.SetError(Alamat, "Correct")
            ErrorProviderNO.SetError(Alamat, "")
        End If
    End Sub

    Private Sub RT_Validating(sender As Object, e As CancelEventArgs) Handles RT.Validating
        If RT.Text = "" Then
            ErrorProviderNO.SetError(RT, "Must be filled")
            ErrorProviderOK.SetError(RT, "")
            e.Cancel = True
            Return
        ElseIf RT.Text.Length < 3 Then
            ErrorProviderNO.SetError(RT, "Isikan RT dengan benar!!")
            ErrorProviderOK.SetError(RT, "")
            e.Cancel = True
            Return
        ElseIf IsNumeric(RT.Text) Then
            ErrorProviderOK.SetError(RT, "Correct")
            ErrorProviderNO.SetError(RT, "")
        Else
            ErrorProviderNO.SetError(RT, "Isikan RT dengan benar!")
            ErrorProviderOK.SetError(RT, "")
            e.Cancel = True
            Return
        End If
    End Sub

    Private Sub RW_Validating(sender As Object, e As CancelEventArgs) Handles RW.Validating
        If RW.Text = "" Then
            ErrorProviderNO.SetError(RW, "Must be filled")
            ErrorProviderOK.SetError(RW, "")
            e.Cancel = True
            Return
        ElseIf RW.Text.Length < 3 Then
            ErrorProviderNO.SetError(RW, "Isikan RW dengan benar!!")
            ErrorProviderOK.SetError(RW, "")
            e.Cancel = True
            Return
        ElseIf IsNumeric(RW.Text) Then
            ErrorProviderOK.SetError(RW, "Correct")
            ErrorProviderNO.SetError(RW, "")
        Else
            ErrorProviderNO.SetError(RW, "Isikan RW dengan benar!")
            ErrorProviderOK.SetError(RW, "")
            e.Cancel = True
            Return
        End If
    End Sub

    Private Sub KodePos_Validating(sender As Object, e As CancelEventArgs) Handles KodePos.Validating
        If KodePos.Text = "" Then
            ErrorProviderNO.SetError(KodePos, "Must be filled")
            ErrorProviderOK.SetError(KodePos, "")
            e.Cancel = True
            Return
        ElseIf KodePos.Text.Length < 5 Then
            ErrorProviderNO.SetError(KodePos, "Isikan Kode Pos dengan benar!!")
            ErrorProviderOK.SetError(KodePos, "")
            e.Cancel = True
            Return
        ElseIf IsNumeric(KodePos.Text) Then
            ErrorProviderOK.SetError(KodePos, "Correct")
            ErrorProviderNO.SetError(KodePos, "")
        Else
            ErrorProviderNO.SetError(KodePos, "Isikan Kode Pos dengan benar!")
            ErrorProviderOK.SetError(KodePos, "")
            e.Cancel = True
            Return
        End If
    End Sub

    Private Sub DesaKelurahan_Validating(sender As Object, e As CancelEventArgs) Handles DesaKelurahan.Validating
        If DesaKelurahan.Text = "" Then
            ErrorProviderNO.SetError(DesaKelurahan, "Must be filled")
            ErrorProviderOK.SetError(DesaKelurahan, "")
            e.Cancel = True
            Return
        Else
            ErrorProviderOK.SetError(DesaKelurahan, "Correct")
            ErrorProviderNO.SetError(DesaKelurahan, "")
        End If
    End Sub

    Private Sub Kecamatan_Validating(sender As Object, e As CancelEventArgs) Handles Kecamatan.Validating
        If Kecamatan.Text = "" Then
            ErrorProviderNO.SetError(Kecamatan, "Must be filled")
            ErrorProviderOK.SetError(Kecamatan, "")
            e.Cancel = True
            Return
        Else
            ErrorProviderOK.SetError(Kecamatan, "Correct")
            ErrorProviderNO.SetError(Kecamatan, "")
        End If
    End Sub

    Private Sub KabupatenKota_Validating(sender As Object, e As CancelEventArgs) Handles KabupatenKota.Validating
        If KabupatenKota.Text = "" Then
            ErrorProviderNO.SetError(KabupatenKota, "Must be filled")
            ErrorProviderOK.SetError(KabupatenKota, "")
            e.Cancel = True
            Return
        Else
            ErrorProviderOK.SetError(KabupatenKota, "Correct")
            ErrorProviderNO.SetError(KabupatenKota, "")
        End If
    End Sub

    Private Sub Provinsi_Validating(sender As Object, e As CancelEventArgs) Handles Provinsi.Validating
        If Provinsi.Text = "" Then
            ErrorProviderNO.SetError(Provinsi, "Must be filled")
            ErrorProviderOK.SetError(Provinsi, "")
            e.Cancel = True
            Return
        Else
            ErrorProviderOK.SetError(Provinsi, "Correct")
            ErrorProviderNO.SetError(Provinsi, "")
        End If
    End Sub

    Private Sub NIK_Validating(sender As Object, e As CancelEventArgs) Handles NIK.Validating
        If NIK.Text = "" Then
            ErrorProviderNO.SetError(NIK, "Must be filled")
            ErrorProviderOK.SetError(NIK, "")
            e.Cancel = True
            Return
        ElseIf NIK.Text.Length < 16 Then
            ErrorProviderNO.SetError(NIK, "Isikan NIK dengan benar!")
            ErrorProviderOK.SetError(NIK, "")
            e.Cancel = True
            Return
        ElseIf IsNumeric(NIK.Text) Then
            ErrorProviderOK.SetError(NIK, "Correct")
            ErrorProviderNO.SetError(NIK, "")
        Else
            ErrorProviderNO.SetError(NIK, "Isikan Nomor Induk Kependudukan dengan benar!")
            ErrorProviderOK.SetError(NIK, "")
            e.Cancel = True
            Return
        End If
    End Sub

    Private Sub NamaLengkap_Validating(sender As Object, e As CancelEventArgs) Handles NamaLengkap.Validating
        If NamaLengkap.Text = "" Then
            ErrorProviderNO.SetError(NamaLengkap, "Must be filled")
            ErrorProviderOK.SetError(NamaLengkap, "")
            e.Cancel = True
            Return
        Else
            ErrorProviderOK.SetError(NamaLengkap, "Correct")
            ErrorProviderNO.SetError(NamaLengkap, "")
        End If
    End Sub

    Private Sub JenisKelamin_Validating(sender As Object, e As CancelEventArgs) Handles JenisKelamin.Validating
        If JenisKelamin.Text = "LAKI - LAKI" Then
            ErrorProviderOK.SetError(JenisKelamin, "Correct")
            ErrorProviderNO.SetError(JenisKelamin, "")
        ElseIf JenisKelamin.Text = "PEREMPUAN" Then
            ErrorProviderOK.SetError(JenisKelamin, "Correct")
            ErrorProviderNO.SetError(JenisKelamin, "")
        ElseIf JenisKelamin.Text = "" Then
            ErrorProviderNO.SetError(JenisKelamin, "Must be filled")
            ErrorProviderOK.SetError(JenisKelamin, "")
            e.Cancel = True
            Return
        Else
            ErrorProviderNO.SetError(JenisKelamin, "Pilih jenis kelamin")
            ErrorProviderOK.SetError(JenisKelamin, "")
            e.Cancel = True
            Return
        End If
    End Sub

    Private Sub TempatLahir_Validating(sender As Object, e As CancelEventArgs) Handles TempatLahir.Validating
        If TempatLahir.Text = "" Then
            ErrorProviderNO.SetError(TempatLahir, "Must be filled")
            ErrorProviderOK.SetError(TempatLahir, "")
            e.Cancel = True
            Return
        Else
            ErrorProviderOK.SetError(TempatLahir, "Correct")
            ErrorProviderNO.SetError(TempatLahir, "")
        End If
    End Sub

    Private Sub TanggalLahir_Validating(sender As Object, e As CancelEventArgs) Handles TanggalLahir.Validating
        If TanggalLahir.Value.Date = Date.Today Then
            ErrorProviderNO.SetError(TanggalLahir, "Choose Date of Birth")
            ErrorProviderOK.SetError(TanggalLahir, "")
            e.Cancel = True
            Return
        ElseIf TanggalLahir.Value.Date > Date.Today Then
            ErrorProviderNO.SetError(TanggalLahir, "Pilih Tanggal Lahir Dengan Benar")
            ErrorProviderOK.SetError(TanggalLahir, "")
            e.Cancel = True
            Return
        ElseIf TanggalLahir.Value.Date > #01/01/2005# Then
            ErrorProviderNO.SetError(TanggalLahir, "Pilih Tanggal Lahir Dengan Benar")
            ErrorProviderOK.SetError(TanggalLahir, "")
            e.Cancel = True
            Return
        Else
            Dim TglL As Date = TanggalLahir.Value
            Dim formatted As String = TglL.ToString("dd MMMM yyyy")
            TanggalLahir.Text = formatted
            ErrorProviderOK.SetError(TanggalLahir, "Correct")
            ErrorProviderNO.SetError(TanggalLahir, "")
        End If
    End Sub

    Private Sub Agama_Validating(sender As Object, e As CancelEventArgs) Handles Agama.Validating
        If Agama.Text = "ISLAM" Then
            ErrorProviderOK.SetError(Agama, "Correct")
            ErrorProviderNO.SetError(Agama, "")
        ElseIf Agama.Text = "KATOLIK" Then
            ErrorProviderOK.SetError(Agama, "Correct")
            ErrorProviderNO.SetError(Agama, "")
        ElseIf Agama.Text = "PROTESTAN" Then
            ErrorProviderOK.SetError(Agama, "Correct")
            ErrorProviderNO.SetError(Agama, "")
        ElseIf Agama.Text = "HINDU" Then
            ErrorProviderOK.SetError(Agama, "Correct")
            ErrorProviderNO.SetError(Agama, "")
        ElseIf Agama.Text = "BUDDHA" Then
            ErrorProviderOK.SetError(Agama, "Correct")
            ErrorProviderNO.SetError(Agama, "")
        ElseIf Agama.Text = "KHONGHUCU" Then
            ErrorProviderOK.SetError(Agama, "Correct")
            ErrorProviderNO.SetError(Agama, "")
        ElseIf Agama.Text = "" Then
            ErrorProviderNO.SetError(Agama, "Must be filled")
            ErrorProviderOK.SetError(Agama, "")
            e.Cancel = True
            Return
        Else
            ErrorProviderNO.SetError(Agama, "Pilih Agama")
            ErrorProviderOK.SetError(Agama, "")
            e.Cancel = True
            Return
        End If
    End Sub

    Private Sub Pendidikan_Validating(sender As Object, e As CancelEventArgs) Handles Pendidikan.Validating
        If Pendidikan.Text = "" Then
            ErrorProviderNO.SetError(Pendidikan, "Must be filled")
            ErrorProviderOK.SetError(Pendidikan, "")
            e.Cancel = True
            Return
        Else
            ErrorProviderOK.SetError(Pendidikan, "Correct")
            ErrorProviderNO.SetError(Pendidikan, "")
        End If
    End Sub

    Private Sub JenisPekarjaan_Validating(sender As Object, e As CancelEventArgs) Handles JenisPekarjaan.Validating
        If JenisPekarjaan.Text = "" Then
            ErrorProviderNO.SetError(JenisPekarjaan, "Must be filled")
            ErrorProviderOK.SetError(JenisPekarjaan, "")
            e.Cancel = True
            Return
        Else
            ErrorProviderOK.SetError(JenisPekarjaan, "Correct")
            ErrorProviderNO.SetError(JenisPekarjaan, "")
        End If
    End Sub

    Private Sub GolonganDarah_Validating(sender As Object, e As CancelEventArgs) Handles GolonganDarah.Validating
        If GolonganDarah.Text = "" Then
            ErrorProviderNO.SetError(GolonganDarah, "Must be filled")
            ErrorProviderOK.SetError(GolonganDarah, "")
            e.Cancel = True
            Return
        Else
            ErrorProviderOK.SetError(GolonganDarah, "Correct")
            ErrorProviderNO.SetError(GolonganDarah, "")
        End If
    End Sub

    Private Sub StatusPerkawinan_Validating(sender As Object, e As CancelEventArgs) Handles StatusPerkawinan.Validating
        If StatusPerkawinan.Text = "" Then
            ErrorProviderNO.SetError(StatusPerkawinan, "Must be filled")
            ErrorProviderOK.SetError(StatusPerkawinan, "")
            e.Cancel = True
            Return
        Else
            ErrorProviderOK.SetError(StatusPerkawinan, "Correct")
            ErrorProviderNO.SetError(StatusPerkawinan, "")
        End If
    End Sub

    Private Sub TanggalPerkawinan_Validating(sender As Object, e As CancelEventArgs) Handles TanggalPerkawinan.Validating
        If TanggalPerkawinan.Text = "" Then
            TanggalPerkawinan.Text = "-"
            ErrorProviderOK.SetError(TanggalPerkawinan, "Correct")
            ErrorProviderNO.SetError(TanggalPerkawinan, "")
        Else
            ErrorProviderOK.SetError(TanggalPerkawinan, "Correct")
            ErrorProviderNO.SetError(TanggalPerkawinan, "")
        End If
    End Sub

    Private Sub StatusHubunganDalamKeluarga_Validating(sender As Object, e As CancelEventArgs) Handles StatusHubunganDalamKeluarga.Validating
        If StatusHubunganDalamKeluarga.Text = "" Then
            ErrorProviderNO.SetError(StatusHubunganDalamKeluarga, "Must be filled")
            ErrorProviderOK.SetError(StatusHubunganDalamKeluarga, "")
            e.Cancel = True
            Return
        Else
            ErrorProviderOK.SetError(StatusHubunganDalamKeluarga, "Correct")
            ErrorProviderNO.SetError(StatusHubunganDalamKeluarga, "")
        End If
    End Sub

    Private Sub Kewarganegaraan_Validating(sender As Object, e As CancelEventArgs) Handles Kewarganegaraan.Validating
        If Kewarganegaraan.Text = "WNI" Then
            ErrorProviderOK.SetError(Kewarganegaraan, "Correct")
            ErrorProviderNO.SetError(Kewarganegaraan, "")
        ElseIf Kewarganegaraan.Text = "WNA" Then
            ErrorProviderOK.SetError(Kewarganegaraan, "Correct")
            ErrorProviderNO.SetError(Kewarganegaraan, "")
        ElseIf Kewarganegaraan.Text = "" Then
            ErrorProviderNO.SetError(Kewarganegaraan, "Must be filled")
            ErrorProviderOK.SetError(Kewarganegaraan, "")
            e.Cancel = True
            Return
        Else
            ErrorProviderNO.SetError(Kewarganegaraan, "Pilih Kewarganegaraan")
            ErrorProviderOK.SetError(Kewarganegaraan, "")
            e.Cancel = True
            Return
        End If
    End Sub

    Private Sub NoPaspor_Validating(sender As Object, e As CancelEventArgs) Handles NoPaspor.Validating
        If NoPaspor.Text = "" Then
            NoPaspor.Text = "-"
            ErrorProviderOK.SetError(NoPaspor, "Correct")
            ErrorProviderNO.SetError(NoPaspor, "")
        Else
            ErrorProviderOK.SetError(NoPaspor, "Correct")
            ErrorProviderNO.SetError(NoPaspor, "")
        End If
    End Sub

    Private Sub NoKitap_Validating(sender As Object, e As CancelEventArgs) Handles NoKitap.Validating
        If NoKitap.Text = "" Then
            NoKitap.Text = "-"
            ErrorProviderOK.SetError(NoKitap, "Correct")
            ErrorProviderNO.SetError(NoKitap, "")
        Else
            ErrorProviderOK.SetError(NoKitap, "Correct")
            ErrorProviderNO.SetError(NoKitap, "")
        End If
    End Sub

    Private Sub Ayah_Validating(sender As Object, e As CancelEventArgs) Handles Ayah.Validating
        If Ayah.Text = "" Then
            ErrorProviderNO.SetError(Ayah, "Must be filled")
            ErrorProviderOK.SetError(Ayah, "")
            e.Cancel = True
            Return
        Else
            ErrorProviderOK.SetError(Ayah, "Correct")
            ErrorProviderNO.SetError(Ayah, "")
        End If
    End Sub

    Private Sub Ibu_Validating(sender As Object, e As CancelEventArgs) Handles Ibu.Validating
        If Ibu.Text = "" Then
            ErrorProviderNO.SetError(Ibu, "Must be filled")
            ErrorProviderOK.SetError(Ibu, "")
            e.Cancel = True
            Return
        Else
            ErrorProviderOK.SetError(Ibu, "Correct")
            ErrorProviderNO.SetError(Ibu, "")
        End If
    End Sub
End Class
