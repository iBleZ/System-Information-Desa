<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KopSuratForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KopSuratForm))
        Me.Kopsurat = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelLokasi = New System.Windows.Forms.Label()
        Me.LabelKopsurat = New System.Windows.Forms.Label()
        Me.BrowseButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ClsoeButton = New System.Windows.Forms.Button()
        CType(Me.Kopsurat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Kopsurat
        '
        Me.Kopsurat.Location = New System.Drawing.Point(12, 12)
        Me.Kopsurat.Name = "Kopsurat"
        Me.Kopsurat.Size = New System.Drawing.Size(614, 121)
        Me.Kopsurat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Kopsurat.TabIndex = 0
        Me.Kopsurat.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(558, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Note* Buat terlebih dahulu kop surat menggunakan photoshop atau editor lainya, gu" &
    "nakan ekstensi file berformat .jpg"
        '
        'LabelLokasi
        '
        Me.LabelLokasi.AutoSize = True
        Me.LabelLokasi.Location = New System.Drawing.Point(12, 184)
        Me.LabelLokasi.Name = "LabelLokasi"
        Me.LabelLokasi.Size = New System.Drawing.Size(67, 13)
        Me.LabelLokasi.TabIndex = 8
        Me.LabelLokasi.Text = "Label Lokasi"
        '
        'LabelKopsurat
        '
        Me.LabelKopsurat.AutoSize = True
        Me.LabelKopsurat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelKopsurat.Location = New System.Drawing.Point(15, 160)
        Me.LabelKopsurat.Name = "LabelKopsurat"
        Me.LabelKopsurat.Size = New System.Drawing.Size(81, 13)
        Me.LabelKopsurat.TabIndex = 7
        Me.LabelKopsurat.Text = "Label Kop surat"
        '
        'BrowseButton
        '
        Me.BrowseButton.Location = New System.Drawing.Point(18, 223)
        Me.BrowseButton.Name = "BrowseButton"
        Me.BrowseButton.Size = New System.Drawing.Size(75, 25)
        Me.BrowseButton.TabIndex = 9
        Me.BrowseButton.Text = "Browse"
        Me.BrowseButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(136, 223)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 25)
        Me.SaveButton.TabIndex = 10
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ClsoeButton
        '
        Me.ClsoeButton.Location = New System.Drawing.Point(551, 254)
        Me.ClsoeButton.Name = "ClsoeButton"
        Me.ClsoeButton.Size = New System.Drawing.Size(75, 25)
        Me.ClsoeButton.TabIndex = 11
        Me.ClsoeButton.Text = "Close"
        Me.ClsoeButton.UseVisualStyleBackColor = True
        '
        'KopSuratForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 291)
        Me.Controls.Add(Me.ClsoeButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.BrowseButton)
        Me.Controls.Add(Me.LabelLokasi)
        Me.Controls.Add(Me.LabelKopsurat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Kopsurat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "KopSuratForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KopSurat"
        CType(Me.Kopsurat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Kopsurat As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelLokasi As Label
    Friend WithEvents LabelKopsurat As Label
    Friend WithEvents BrowseButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ClsoeButton As Button
End Class
