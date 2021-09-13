<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KartuKeluarga
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NIK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jeniskelamin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tempatlahir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggallahir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.agama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pendidikan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenispekarjaan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.golongandarah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tglperkawinan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.statushubungan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kewarganegaraan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paspor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kitap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ayah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ibu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nama, Me.NIK, Me.jeniskelamin, Me.tempatlahir, Me.tanggallahir, Me.agama, Me.pendidikan, Me.jenispekarjaan, Me.golongandarah, Me.status, Me.tglperkawinan, Me.statushubungan, Me.kewarganegaraan, Me.paspor, Me.kitap, Me.ayah, Me.ibu})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 50
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Size = New System.Drawing.Size(2273, 413)
        Me.DataGridView1.TabIndex = 0
        '
        'nama
        '
        Me.nama.HeaderText = "Nama Lengkap"
        Me.nama.Name = "nama"
        Me.nama.ReadOnly = True
        Me.nama.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.nama.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.nama.Width = 150
        '
        'NIK
        '
        Me.NIK.HeaderText = "NIK"
        Me.NIK.Name = "NIK"
        Me.NIK.ReadOnly = True
        Me.NIK.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NIK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NIK.Width = 130
        '
        'jeniskelamin
        '
        Me.jeniskelamin.HeaderText = "Jenis Kelamin"
        Me.jeniskelamin.Name = "jeniskelamin"
        Me.jeniskelamin.ReadOnly = True
        Me.jeniskelamin.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.jeniskelamin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'tempatlahir
        '
        Me.tempatlahir.HeaderText = "Tempat Lahir"
        Me.tempatlahir.Name = "tempatlahir"
        Me.tempatlahir.ReadOnly = True
        Me.tempatlahir.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tempatlahir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.tempatlahir.Width = 150
        '
        'tanggallahir
        '
        Me.tanggallahir.HeaderText = "Tanggal Lahir"
        Me.tanggallahir.Name = "tanggallahir"
        Me.tanggallahir.ReadOnly = True
        Me.tanggallahir.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tanggallahir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.tanggallahir.Width = 150
        '
        'agama
        '
        Me.agama.HeaderText = "Agama"
        Me.agama.Name = "agama"
        Me.agama.ReadOnly = True
        Me.agama.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.agama.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'pendidikan
        '
        Me.pendidikan.HeaderText = "Pendidikan"
        Me.pendidikan.Name = "pendidikan"
        Me.pendidikan.ReadOnly = True
        Me.pendidikan.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.pendidikan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.pendidikan.Width = 150
        '
        'jenispekarjaan
        '
        Me.jenispekarjaan.HeaderText = "Jenis Pekerjaan"
        Me.jenispekarjaan.Name = "jenispekarjaan"
        Me.jenispekarjaan.ReadOnly = True
        Me.jenispekarjaan.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.jenispekarjaan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.jenispekarjaan.Width = 150
        '
        'golongandarah
        '
        Me.golongandarah.HeaderText = "Golongan Darah"
        Me.golongandarah.Name = "golongandarah"
        Me.golongandarah.ReadOnly = True
        Me.golongandarah.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.golongandarah.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'status
        '
        Me.status.HeaderText = "Status Perkawinan"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.status.Width = 150
        '
        'tglperkawinan
        '
        Me.tglperkawinan.HeaderText = "Tanggal Perkawinan"
        Me.tglperkawinan.Name = "tglperkawinan"
        Me.tglperkawinan.ReadOnly = True
        Me.tglperkawinan.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tglperkawinan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'statushubungan
        '
        Me.statushubungan.HeaderText = "Status Hubungan Dalam Keluarga"
        Me.statushubungan.Name = "statushubungan"
        Me.statushubungan.ReadOnly = True
        Me.statushubungan.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.statushubungan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.statushubungan.Width = 150
        '
        'kewarganegaraan
        '
        Me.kewarganegaraan.HeaderText = "Kewarganegaraan"
        Me.kewarganegaraan.Name = "kewarganegaraan"
        Me.kewarganegaraan.ReadOnly = True
        Me.kewarganegaraan.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.kewarganegaraan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.kewarganegaraan.Width = 135
        '
        'paspor
        '
        Me.paspor.HeaderText = "No. Paspor"
        Me.paspor.Name = "paspor"
        Me.paspor.ReadOnly = True
        Me.paspor.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.paspor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.paspor.Width = 130
        '
        'kitap
        '
        Me.kitap.HeaderText = "No. KITAP"
        Me.kitap.Name = "kitap"
        Me.kitap.ReadOnly = True
        Me.kitap.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.kitap.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.kitap.Width = 130
        '
        'ayah
        '
        Me.ayah.HeaderText = "Ayah"
        Me.ayah.Name = "ayah"
        Me.ayah.ReadOnly = True
        Me.ayah.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ayah.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ayah.Width = 120
        '
        'ibu
        '
        Me.ibu.HeaderText = "Ibu"
        Me.ibu.Name = "ibu"
        Me.ibu.ReadOnly = True
        Me.ibu.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ibu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ibu.Width = 120
        '
        'KartuKeluarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "KartuKeluarga"
        Me.Size = New System.Drawing.Size(2273, 413)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents nama As DataGridViewTextBoxColumn
    Friend WithEvents NIK As DataGridViewTextBoxColumn
    Friend WithEvents jeniskelamin As DataGridViewTextBoxColumn
    Friend WithEvents tempatlahir As DataGridViewTextBoxColumn
    Friend WithEvents tanggallahir As DataGridViewTextBoxColumn
    Friend WithEvents agama As DataGridViewTextBoxColumn
    Friend WithEvents pendidikan As DataGridViewTextBoxColumn
    Friend WithEvents jenispekarjaan As DataGridViewTextBoxColumn
    Friend WithEvents golongandarah As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents tglperkawinan As DataGridViewTextBoxColumn
    Friend WithEvents statushubungan As DataGridViewTextBoxColumn
    Friend WithEvents kewarganegaraan As DataGridViewTextBoxColumn
    Friend WithEvents paspor As DataGridViewTextBoxColumn
    Friend WithEvents kitap As DataGridViewTextBoxColumn
    Friend WithEvents ayah As DataGridViewTextBoxColumn
    Friend WithEvents ibu As DataGridViewTextBoxColumn
End Class
