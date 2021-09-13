<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PejabatDesaForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PejabatDesaForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KadesRadioButton = New System.Windows.Forms.RadioButton()
        Me.SekdesRadioButton = New System.Windows.Forms.RadioButton()
        Me.AlamatTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.TeleponTextBox = New System.Windows.Forms.TextBox()
        Me.AgamaComboBox = New System.Windows.Forms.ComboBox()
        Me.JenisKelaminComboBox = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Labeljeniskelamin = New System.Windows.Forms.Label()
        Me.TanggalLahirDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TempatLahirTextBox = New System.Windows.Forms.TextBox()
        Me.NamaTextBox = New System.Windows.Forms.TextBox()
        Me.Labeltanggallahir = New System.Windows.Forms.Label()
        Me.Labeltempatlahir = New System.Windows.Forms.Label()
        Me.LabelNama = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ErrorProviderNO = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderOK = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ButtonClose = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderNO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderOK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(29, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Menu Perubahan Pejabat Desa"
        '
        'KadesRadioButton
        '
        Me.KadesRadioButton.AutoSize = True
        Me.KadesRadioButton.Location = New System.Drawing.Point(94, 116)
        Me.KadesRadioButton.Name = "KadesRadioButton"
        Me.KadesRadioButton.Size = New System.Drawing.Size(104, 20)
        Me.KadesRadioButton.TabIndex = 2
        Me.KadesRadioButton.TabStop = True
        Me.KadesRadioButton.Text = "Kepala Desa"
        Me.KadesRadioButton.UseVisualStyleBackColor = True
        '
        'SekdesRadioButton
        '
        Me.SekdesRadioButton.AutoSize = True
        Me.SekdesRadioButton.Location = New System.Drawing.Point(94, 142)
        Me.SekdesRadioButton.Name = "SekdesRadioButton"
        Me.SekdesRadioButton.Size = New System.Drawing.Size(122, 20)
        Me.SekdesRadioButton.TabIndex = 3
        Me.SekdesRadioButton.TabStop = True
        Me.SekdesRadioButton.Text = "Sekretaris Desa"
        Me.SekdesRadioButton.UseVisualStyleBackColor = True
        '
        'AlamatTextBox
        '
        Me.AlamatTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlamatTextBox.Location = New System.Drawing.Point(206, 383)
        Me.AlamatTextBox.Multiline = True
        Me.AlamatTextBox.Name = "AlamatTextBox"
        Me.AlamatTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.AlamatTextBox.Size = New System.Drawing.Size(238, 48)
        Me.AlamatTextBox.TabIndex = 34
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(206, 355)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(238, 22)
        Me.EmailTextBox.TabIndex = 33
        '
        'TeleponTextBox
        '
        Me.TeleponTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeleponTextBox.Location = New System.Drawing.Point(206, 327)
        Me.TeleponTextBox.Name = "TeleponTextBox"
        Me.TeleponTextBox.Size = New System.Drawing.Size(153, 22)
        Me.TeleponTextBox.TabIndex = 32
        '
        'AgamaComboBox
        '
        Me.AgamaComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgamaComboBox.FormattingEnabled = True
        Me.AgamaComboBox.Items.AddRange(New Object() {"Islam", "Katolik", "Protestan", "Hindu", "Buddha", "Khonghucu"})
        Me.AgamaComboBox.Location = New System.Drawing.Point(206, 297)
        Me.AgamaComboBox.Name = "AgamaComboBox"
        Me.AgamaComboBox.Size = New System.Drawing.Size(153, 24)
        Me.AgamaComboBox.TabIndex = 31
        '
        'JenisKelaminComboBox
        '
        Me.JenisKelaminComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JenisKelaminComboBox.FormattingEnabled = True
        Me.JenisKelaminComboBox.Items.AddRange(New Object() {"Laki - Laki", "Perempuan"})
        Me.JenisKelaminComboBox.Location = New System.Drawing.Point(206, 267)
        Me.JenisKelaminComboBox.Name = "JenisKelaminComboBox"
        Me.JenisKelaminComboBox.Size = New System.Drawing.Size(153, 24)
        Me.JenisKelaminComboBox.TabIndex = 30
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(57, 386)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 16)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Alamat"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(57, 358)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 16)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Alamat e-mail"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(57, 330)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 16)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Telpon / Hp"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(57, 300)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 16)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Agama"
        '
        'Labeljeniskelamin
        '
        Me.Labeljeniskelamin.AutoSize = True
        Me.Labeljeniskelamin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeljeniskelamin.Location = New System.Drawing.Point(57, 270)
        Me.Labeljeniskelamin.Name = "Labeljeniskelamin"
        Me.Labeljeniskelamin.Size = New System.Drawing.Size(90, 16)
        Me.Labeljeniskelamin.TabIndex = 25
        Me.Labeljeniskelamin.Text = "Jenis Kelamin"
        '
        'TanggalLahirDateTimePicker
        '
        Me.TanggalLahirDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TanggalLahirDateTimePicker.Location = New System.Drawing.Point(206, 239)
        Me.TanggalLahirDateTimePicker.Name = "TanggalLahirDateTimePicker"
        Me.TanggalLahirDateTimePicker.Size = New System.Drawing.Size(171, 22)
        Me.TanggalLahirDateTimePicker.TabIndex = 24
        '
        'TempatLahirTextBox
        '
        Me.TempatLahirTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempatLahirTextBox.Location = New System.Drawing.Point(206, 211)
        Me.TempatLahirTextBox.Name = "TempatLahirTextBox"
        Me.TempatLahirTextBox.Size = New System.Drawing.Size(238, 22)
        Me.TempatLahirTextBox.TabIndex = 23
        '
        'NamaTextBox
        '
        Me.NamaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaTextBox.Location = New System.Drawing.Point(206, 183)
        Me.NamaTextBox.Name = "NamaTextBox"
        Me.NamaTextBox.Size = New System.Drawing.Size(238, 22)
        Me.NamaTextBox.TabIndex = 22
        '
        'Labeltanggallahir
        '
        Me.Labeltanggallahir.AutoSize = True
        Me.Labeltanggallahir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeltanggallahir.Location = New System.Drawing.Point(57, 244)
        Me.Labeltanggallahir.Name = "Labeltanggallahir"
        Me.Labeltanggallahir.Size = New System.Drawing.Size(90, 16)
        Me.Labeltanggallahir.TabIndex = 21
        Me.Labeltanggallahir.Text = "Tanggal Lahir"
        '
        'Labeltempatlahir
        '
        Me.Labeltempatlahir.AutoSize = True
        Me.Labeltempatlahir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeltempatlahir.Location = New System.Drawing.Point(57, 214)
        Me.Labeltempatlahir.Name = "Labeltempatlahir"
        Me.Labeltempatlahir.Size = New System.Drawing.Size(86, 16)
        Me.Labeltempatlahir.TabIndex = 20
        Me.Labeltempatlahir.Text = "Tempat Lahir"
        '
        'LabelNama
        '
        Me.LabelNama.AutoSize = True
        Me.LabelNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNama.Location = New System.Drawing.Point(57, 186)
        Me.LabelNama.Name = "LabelNama"
        Me.LabelNama.Size = New System.Drawing.Size(100, 16)
        Me.LabelNama.TabIndex = 19
        Me.LabelNama.Text = "Nama Lengkap"
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(219, 464)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 25)
        Me.SaveButton.TabIndex = 35
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'ErrorProviderNO
        '
        Me.ErrorProviderNO.ContainerControl = Me
        '
        'ErrorProviderOK
        '
        Me.ErrorProviderOK.ContainerControl = Me
        Me.ErrorProviderOK.Icon = CType(resources.GetObject("ErrorProviderOK.Icon"), System.Drawing.Icon)
        '
        'ButtonClose
        '
        Me.ButtonClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClose.Location = New System.Drawing.Point(427, 505)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 25)
        Me.ButtonClose.TabIndex = 36
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'PejabatDesaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 542)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.AlamatTextBox)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.TeleponTextBox)
        Me.Controls.Add(Me.AgamaComboBox)
        Me.Controls.Add(Me.JenisKelaminComboBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Labeljeniskelamin)
        Me.Controls.Add(Me.TanggalLahirDateTimePicker)
        Me.Controls.Add(Me.TempatLahirTextBox)
        Me.Controls.Add(Me.NamaTextBox)
        Me.Controls.Add(Me.Labeltanggallahir)
        Me.Controls.Add(Me.Labeltempatlahir)
        Me.Controls.Add(Me.LabelNama)
        Me.Controls.Add(Me.SekdesRadioButton)
        Me.Controls.Add(Me.KadesRadioButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PejabatDesaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pejabat yang berwenang menandatangani"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderNO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderOK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents KadesRadioButton As RadioButton
    Friend WithEvents SekdesRadioButton As RadioButton
    Friend WithEvents AlamatTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents TeleponTextBox As TextBox
    Friend WithEvents AgamaComboBox As ComboBox
    Friend WithEvents JenisKelaminComboBox As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Labeljeniskelamin As Label
    Friend WithEvents TanggalLahirDateTimePicker As DateTimePicker
    Friend WithEvents TempatLahirTextBox As TextBox
    Friend WithEvents NamaTextBox As TextBox
    Friend WithEvents Labeltanggallahir As Label
    Friend WithEvents Labeltempatlahir As Label
    Friend WithEvents LabelNama As Label
    Friend WithEvents SaveButton As Button
    Friend WithEvents ErrorProviderNO As ErrorProvider
    Friend WithEvents ErrorProviderOK As ErrorProvider
    Friend WithEvents ButtonClose As Button
End Class
