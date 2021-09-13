<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormChangePersonalInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormChangePersonalInfo))
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
        Me.NIPTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ErrorProviderOK = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderNO = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProviderOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderNO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AlamatTextBox
        '
        Me.AlamatTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlamatTextBox.Location = New System.Drawing.Point(179, 266)
        Me.AlamatTextBox.Multiline = True
        Me.AlamatTextBox.Name = "AlamatTextBox"
        Me.AlamatTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.AlamatTextBox.Size = New System.Drawing.Size(238, 48)
        Me.AlamatTextBox.TabIndex = 37
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(179, 238)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(238, 22)
        Me.EmailTextBox.TabIndex = 36
        '
        'TeleponTextBox
        '
        Me.TeleponTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeleponTextBox.Location = New System.Drawing.Point(179, 210)
        Me.TeleponTextBox.Name = "TeleponTextBox"
        Me.TeleponTextBox.Size = New System.Drawing.Size(153, 22)
        Me.TeleponTextBox.TabIndex = 35
        '
        'AgamaComboBox
        '
        Me.AgamaComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgamaComboBox.FormattingEnabled = True
        Me.AgamaComboBox.Items.AddRange(New Object() {"Islam", "Katolik", "Protestan", "Hindu", "Buddha", "Khonghucu"})
        Me.AgamaComboBox.Location = New System.Drawing.Point(179, 180)
        Me.AgamaComboBox.Name = "AgamaComboBox"
        Me.AgamaComboBox.Size = New System.Drawing.Size(153, 24)
        Me.AgamaComboBox.TabIndex = 34
        '
        'JenisKelaminComboBox
        '
        Me.JenisKelaminComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JenisKelaminComboBox.FormattingEnabled = True
        Me.JenisKelaminComboBox.Items.AddRange(New Object() {"Laki - Laki", "Perempuan"})
        Me.JenisKelaminComboBox.Location = New System.Drawing.Point(179, 150)
        Me.JenisKelaminComboBox.Name = "JenisKelaminComboBox"
        Me.JenisKelaminComboBox.Size = New System.Drawing.Size(153, 24)
        Me.JenisKelaminComboBox.TabIndex = 33
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(30, 269)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 16)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Alamat"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(30, 241)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 16)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Alamat e-mail"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 213)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 16)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Telpon / Hp"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 16)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Agama"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 16)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Jenis Kelamin"
        '
        'TanggalLahirDateTimePicker
        '
        Me.TanggalLahirDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TanggalLahirDateTimePicker.Location = New System.Drawing.Point(179, 122)
        Me.TanggalLahirDateTimePicker.Name = "TanggalLahirDateTimePicker"
        Me.TanggalLahirDateTimePicker.Size = New System.Drawing.Size(171, 22)
        Me.TanggalLahirDateTimePicker.TabIndex = 27
        '
        'TempatLahirTextBox
        '
        Me.TempatLahirTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempatLahirTextBox.Location = New System.Drawing.Point(179, 94)
        Me.TempatLahirTextBox.Name = "TempatLahirTextBox"
        Me.TempatLahirTextBox.Size = New System.Drawing.Size(238, 22)
        Me.TempatLahirTextBox.TabIndex = 26
        '
        'NamaTextBox
        '
        Me.NamaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaTextBox.Location = New System.Drawing.Point(179, 66)
        Me.NamaTextBox.Name = "NamaTextBox"
        Me.NamaTextBox.Size = New System.Drawing.Size(238, 22)
        Me.NamaTextBox.TabIndex = 25
        '
        'NIPTextBox
        '
        Me.NIPTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NIPTextBox.Location = New System.Drawing.Point(179, 26)
        Me.NIPTextBox.Name = "NIPTextBox"
        Me.NIPTextBox.Size = New System.Drawing.Size(153, 22)
        Me.NIPTextBox.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Tanggal Lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 16)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Tempat Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Nama Lengkap"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(183, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 12)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "*Jika tidak memiliki NIP kosongkan"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(30, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 16)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "NIP"
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(189, 355)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 25)
        Me.SaveButton.TabIndex = 38
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'ErrorProviderOK
        '
        Me.ErrorProviderOK.ContainerControl = Me
        Me.ErrorProviderOK.Icon = CType(resources.GetObject("ErrorProviderOK.Icon"), System.Drawing.Icon)
        '
        'ErrorProviderNO
        '
        Me.ErrorProviderNO.ContainerControl = Me
        '
        'FormChangePersonalInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 406)
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
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TanggalLahirDateTimePicker)
        Me.Controls.Add(Me.TempatLahirTextBox)
        Me.Controls.Add(Me.NamaTextBox)
        Me.Controls.Add(Me.NIPTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label12)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormChangePersonalInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Personal Info"
        CType(Me.ErrorProviderOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderNO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents NIPTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents SaveButton As Button
    Friend WithEvents ErrorProviderOK As ErrorProvider
    Friend WithEvents ErrorProviderNO As ErrorProvider
End Class
