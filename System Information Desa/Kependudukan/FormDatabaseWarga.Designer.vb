<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDatabaseWarga
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDatabaseWarga))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CariTextBox = New System.Windows.Forms.TextBox()
        Me.Buttoncari = New System.Windows.Forms.Button()
        Me.NIK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nokk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jeniskelamin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tempatlahir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggallahir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rw = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 25)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Database Warga Desa"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(29, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NIK, Me.nokk, Me.nama, Me.jeniskelamin, Me.tempatlahir, Me.tanggallahir, Me.alamat, Me.rt, Me.rw, Me.desa})
        Me.DataGridView1.Location = New System.Drawing.Point(29, 128)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 50
        Me.DataGridView1.Size = New System.Drawing.Size(1207, 390)
        Me.DataGridView1.TabIndex = 21
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(1125, 524)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 25)
        Me.ButtonClose.TabIndex = 22
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 528)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Cari NIK"
        '
        'CariTextBox
        '
        Me.CariTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CariTextBox.Location = New System.Drawing.Point(95, 523)
        Me.CariTextBox.Name = "CariTextBox"
        Me.CariTextBox.Size = New System.Drawing.Size(133, 22)
        Me.CariTextBox.TabIndex = 24
        '
        'Buttoncari
        '
        Me.Buttoncari.Image = CType(resources.GetObject("Buttoncari.Image"), System.Drawing.Image)
        Me.Buttoncari.Location = New System.Drawing.Point(234, 522)
        Me.Buttoncari.Name = "Buttoncari"
        Me.Buttoncari.Size = New System.Drawing.Size(75, 25)
        Me.Buttoncari.TabIndex = 25
        Me.Buttoncari.UseVisualStyleBackColor = True
        '
        'NIK
        '
        Me.NIK.HeaderText = "NIK"
        Me.NIK.Name = "NIK"
        Me.NIK.ReadOnly = True
        Me.NIK.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NIK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NIK.Width = 150
        '
        'nokk
        '
        Me.nokk.HeaderText = "No. Kartu Keluarga"
        Me.nokk.Name = "nokk"
        Me.nokk.ReadOnly = True
        Me.nokk.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.nokk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.nokk.Width = 150
        '
        'nama
        '
        Me.nama.HeaderText = "Nama Lengkap"
        Me.nama.Name = "nama"
        Me.nama.ReadOnly = True
        Me.nama.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.nama.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.nama.Width = 160
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
        Me.tempatlahir.Width = 120
        '
        'tanggallahir
        '
        Me.tanggallahir.HeaderText = "Tanggal Lahir"
        Me.tanggallahir.Name = "tanggallahir"
        Me.tanggallahir.ReadOnly = True
        Me.tanggallahir.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tanggallahir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.tanggallahir.Width = 120
        '
        'alamat
        '
        Me.alamat.HeaderText = "Alamat"
        Me.alamat.Name = "alamat"
        Me.alamat.ReadOnly = True
        Me.alamat.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.alamat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.alamat.Width = 135
        '
        'rt
        '
        Me.rt.HeaderText = "RT"
        Me.rt.Name = "rt"
        Me.rt.ReadOnly = True
        Me.rt.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.rt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.rt.Width = 50
        '
        'rw
        '
        Me.rw.HeaderText = "RW"
        Me.rw.Name = "rw"
        Me.rw.ReadOnly = True
        Me.rw.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.rw.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.rw.Width = 50
        '
        'desa
        '
        Me.desa.HeaderText = "Desa / Kelurahan"
        Me.desa.Name = "desa"
        Me.desa.ReadOnly = True
        Me.desa.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.desa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.desa.Width = 120
        '
        'FormDatabaseWarga
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1264, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.Buttoncari)
        Me.Controls.Add(Me.CariTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormDatabaseWarga"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Database Warga"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonClose As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents CariTextBox As TextBox
    Friend WithEvents Buttoncari As Button
    Friend WithEvents NIK As DataGridViewTextBoxColumn
    Friend WithEvents nokk As DataGridViewTextBoxColumn
    Friend WithEvents nama As DataGridViewTextBoxColumn
    Friend WithEvents jeniskelamin As DataGridViewTextBoxColumn
    Friend WithEvents tempatlahir As DataGridViewTextBoxColumn
    Friend WithEvents tanggallahir As DataGridViewTextBoxColumn
    Friend WithEvents alamat As DataGridViewTextBoxColumn
    Friend WithEvents rt As DataGridViewTextBoxColumn
    Friend WithEvents rw As DataGridViewTextBoxColumn
    Friend WithEvents desa As DataGridViewTextBoxColumn
End Class
