<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUserForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddUserForm))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.JabatanComboBox = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ShowPasswordCheckBox = New System.Windows.Forms.CheckBox()
        Me.ConfirmPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.AlamatTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.TeleponTextBox = New System.Windows.Forms.TextBox()
        Me.AgamaComboBox = New System.Windows.Forms.ComboBox()
        Me.JenisKelaminComboBox = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TanggalLahirDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TempatLahirTextBox = New System.Windows.Forms.TextBox()
        Me.NamaTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NIPTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ErrorProviderNO = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderOK = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PhotoPictureBox = New System.Windows.Forms.PictureBox()
        Me.BrowseButton = New System.Windows.Forms.Button()
        Me.LabelPhoto = New System.Windows.Forms.Label()
        Me.LabelLokasiFile = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.LabelPertanyaan = New System.Windows.Forms.Label()
        Me.LabelJawaban = New System.Windows.Forms.Label()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderNO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhotoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.JabatanComboBox)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.ShowPasswordCheckBox)
        Me.GroupBox2.Controls.Add(Me.ConfirmPasswordTextBox)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.PasswordTextBox)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.UserNameTextBox)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(539, 87)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(394, 203)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Login Informatin"
        '
        'JabatanComboBox
        '
        Me.JabatanComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JabatanComboBox.FormattingEnabled = True
        Me.JabatanComboBox.Items.AddRange(New Object() {"Administrator", "Operator", "Pengawas"})
        Me.JabatanComboBox.Location = New System.Drawing.Point(148, 154)
        Me.JabatanComboBox.Name = "JabatanComboBox"
        Me.JabatanComboBox.Size = New System.Drawing.Size(121, 24)
        Me.JabatanComboBox.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(27, 157)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 16)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Jabatan"
        '
        'ShowPasswordCheckBox
        '
        Me.ShowPasswordCheckBox.AutoSize = True
        Me.ShowPasswordCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowPasswordCheckBox.Location = New System.Drawing.Point(148, 114)
        Me.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox"
        Me.ShowPasswordCheckBox.Size = New System.Drawing.Size(122, 20)
        Me.ShowPasswordCheckBox.TabIndex = 6
        Me.ShowPasswordCheckBox.Text = "Show password"
        Me.ShowPasswordCheckBox.UseVisualStyleBackColor = True
        '
        'ConfirmPasswordTextBox
        '
        Me.ConfirmPasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPasswordTextBox.Location = New System.Drawing.Point(148, 86)
        Me.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox"
        Me.ConfirmPasswordTextBox.Size = New System.Drawing.Size(209, 22)
        Me.ConfirmPasswordTextBox.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(27, 89)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(115, 16)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Confirm password"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(148, 58)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(209, 22)
        Me.PasswordTextBox.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(27, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 16)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Password"
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameTextBox.Location = New System.Drawing.Point(148, 30)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(209, 22)
        Me.UserNameTextBox.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(27, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "User Name"
        '
        'AlamatTextBox
        '
        Me.AlamatTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlamatTextBox.Location = New System.Drawing.Point(176, 270)
        Me.AlamatTextBox.Multiline = True
        Me.AlamatTextBox.Name = "AlamatTextBox"
        Me.AlamatTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.AlamatTextBox.Size = New System.Drawing.Size(238, 48)
        Me.AlamatTextBox.TabIndex = 18
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(176, 242)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(238, 22)
        Me.EmailTextBox.TabIndex = 17
        '
        'TeleponTextBox
        '
        Me.TeleponTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeleponTextBox.Location = New System.Drawing.Point(176, 214)
        Me.TeleponTextBox.Name = "TeleponTextBox"
        Me.TeleponTextBox.Size = New System.Drawing.Size(153, 22)
        Me.TeleponTextBox.TabIndex = 16
        '
        'AgamaComboBox
        '
        Me.AgamaComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgamaComboBox.FormattingEnabled = True
        Me.AgamaComboBox.Items.AddRange(New Object() {"Islam", "Katolik", "Protestan", "Hindu", "Buddha", "Khonghucu"})
        Me.AgamaComboBox.Location = New System.Drawing.Point(176, 184)
        Me.AgamaComboBox.Name = "AgamaComboBox"
        Me.AgamaComboBox.Size = New System.Drawing.Size(153, 24)
        Me.AgamaComboBox.TabIndex = 15
        '
        'JenisKelaminComboBox
        '
        Me.JenisKelaminComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JenisKelaminComboBox.FormattingEnabled = True
        Me.JenisKelaminComboBox.Items.AddRange(New Object() {"Laki - Laki", "Perempuan"})
        Me.JenisKelaminComboBox.Location = New System.Drawing.Point(176, 154)
        Me.JenisKelaminComboBox.Name = "JenisKelaminComboBox"
        Me.JenisKelaminComboBox.Size = New System.Drawing.Size(153, 24)
        Me.JenisKelaminComboBox.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(27, 273)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 16)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Alamat"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(27, 245)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 16)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Alamat e-mail"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(27, 217)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 16)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Telpon / Hp"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 187)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Agama"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Jenis Kelamin"
        '
        'TanggalLahirDateTimePicker
        '
        Me.TanggalLahirDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TanggalLahirDateTimePicker.Location = New System.Drawing.Point(176, 126)
        Me.TanggalLahirDateTimePicker.Name = "TanggalLahirDateTimePicker"
        Me.TanggalLahirDateTimePicker.Size = New System.Drawing.Size(171, 22)
        Me.TanggalLahirDateTimePicker.TabIndex = 8
        '
        'TempatLahirTextBox
        '
        Me.TempatLahirTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempatLahirTextBox.Location = New System.Drawing.Point(176, 98)
        Me.TempatLahirTextBox.Name = "TempatLahirTextBox"
        Me.TempatLahirTextBox.Size = New System.Drawing.Size(238, 22)
        Me.TempatLahirTextBox.TabIndex = 7
        '
        'NamaTextBox
        '
        Me.NamaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaTextBox.Location = New System.Drawing.Point(176, 70)
        Me.NamaTextBox.Name = "NamaTextBox"
        Me.NamaTextBox.Size = New System.Drawing.Size(238, 22)
        Me.NamaTextBox.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Tanggal Lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Tempat Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nama Lengkap"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(180, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 12)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "*Jika tidak memiliki NIP kosongkan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "NIP"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AlamatTextBox)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Controls.Add(Me.TeleponTextBox)
        Me.GroupBox1.Controls.Add(Me.AgamaComboBox)
        Me.GroupBox1.Controls.Add(Me.JenisKelaminComboBox)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TanggalLahirDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.TempatLahirTextBox)
        Me.GroupBox1.Controls.Add(Me.NamaTextBox)
        Me.GroupBox1.Controls.Add(Me.NIPTextBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(53, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 341)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Data"
        '
        'NIPTextBox
        '
        Me.NIPTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NIPTextBox.Location = New System.Drawing.Point(176, 30)
        Me.NIPTextBox.Name = "NIPTextBox"
        Me.NIPTextBox.Size = New System.Drawing.Size(153, 22)
        Me.NIPTextBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Add User Account"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(29, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
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
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PhotoPictureBox
        '
        Me.PhotoPictureBox.Location = New System.Drawing.Point(1003, 117)
        Me.PhotoPictureBox.Name = "PhotoPictureBox"
        Me.PhotoPictureBox.Size = New System.Drawing.Size(120, 150)
        Me.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PhotoPictureBox.TabIndex = 8
        Me.PhotoPictureBox.TabStop = False
        '
        'BrowseButton
        '
        Me.BrowseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BrowseButton.Location = New System.Drawing.Point(1025, 295)
        Me.BrowseButton.Name = "BrowseButton"
        Me.BrowseButton.Size = New System.Drawing.Size(75, 25)
        Me.BrowseButton.TabIndex = 9
        Me.BrowseButton.Text = "Browse"
        Me.BrowseButton.UseVisualStyleBackColor = True
        '
        'LabelPhoto
        '
        Me.LabelPhoto.AutoSize = True
        Me.LabelPhoto.Location = New System.Drawing.Point(1006, 273)
        Me.LabelPhoto.Name = "LabelPhoto"
        Me.LabelPhoto.Size = New System.Drawing.Size(64, 13)
        Me.LabelPhoto.TabIndex = 10
        Me.LabelPhoto.Text = "Label Photo"
        '
        'LabelLokasiFile
        '
        Me.LabelLokasiFile.AutoSize = True
        Me.LabelLokasiFile.Location = New System.Drawing.Point(1006, 335)
        Me.LabelLokasiFile.Name = "LabelLokasiFile"
        Me.LabelLokasiFile.Size = New System.Drawing.Size(92, 13)
        Me.LabelLokasiFile.TabIndex = 11
        Me.LabelLokasiFile.Text = "Label Loakasi File"
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(661, 415)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 25)
        Me.SaveButton.TabIndex = 12
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'LabelPertanyaan
        '
        Me.LabelPertanyaan.AutoSize = True
        Me.LabelPertanyaan.Location = New System.Drawing.Point(373, 8)
        Me.LabelPertanyaan.Name = "LabelPertanyaan"
        Me.LabelPertanyaan.Size = New System.Drawing.Size(61, 13)
        Me.LabelPertanyaan.TabIndex = 14
        Me.LabelPertanyaan.Text = "Pertanyaan"
        '
        'LabelJawaban
        '
        Me.LabelJawaban.AutoSize = True
        Me.LabelJawaban.Location = New System.Drawing.Point(492, 8)
        Me.LabelJawaban.Name = "LabelJawaban"
        Me.LabelJawaban.Size = New System.Drawing.Size(50, 13)
        Me.LabelJawaban.TabIndex = 15
        Me.LabelJawaban.Text = "Jawaban"
        '
        'CancelBtn
        '
        Me.CancelBtn.Location = New System.Drawing.Point(787, 415)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(75, 25)
        Me.CancelBtn.TabIndex = 16
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'AddUserForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1264, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.LabelJawaban)
        Me.Controls.Add(Me.LabelPertanyaan)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.LabelLokasiFile)
        Me.Controls.Add(Me.LabelPhoto)
        Me.Controls.Add(Me.BrowseButton)
        Me.Controls.Add(Me.PhotoPictureBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AddUserForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add User Account"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderNO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents AlamatTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents TeleponTextBox As TextBox
    Friend WithEvents AgamaComboBox As ComboBox
    Friend WithEvents JenisKelaminComboBox As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TanggalLahirDateTimePicker As DateTimePicker
    Friend WithEvents TempatLahirTextBox As TextBox
    Friend WithEvents NamaTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NIPTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ErrorProviderNO As ErrorProvider
    Friend WithEvents ErrorProviderOK As ErrorProvider
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents JabatanComboBox As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents ShowPasswordCheckBox As CheckBox
    Friend WithEvents ConfirmPasswordTextBox As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents UserNameTextBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents LabelLokasiFile As Label
    Friend WithEvents LabelPhoto As Label
    Friend WithEvents BrowseButton As Button
    Friend WithEvents PhotoPictureBox As PictureBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents LabelJawaban As Label
    Friend WithEvents LabelPertanyaan As Label
    Friend WithEvents CancelBtn As Button
End Class
