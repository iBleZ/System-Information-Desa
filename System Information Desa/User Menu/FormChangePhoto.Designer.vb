<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormChangePhoto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormChangePhoto))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PhotoPictureBox = New System.Windows.Forms.PictureBox()
        Me.BrowseButton = New System.Windows.Forms.Button()
        Me.LabelPhoto = New System.Windows.Forms.Label()
        Me.LabelLokasi = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        CType(Me.PhotoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PhotoPictureBox
        '
        Me.PhotoPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.PhotoPictureBox.Name = "PhotoPictureBox"
        Me.PhotoPictureBox.Size = New System.Drawing.Size(182, 206)
        Me.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PhotoPictureBox.TabIndex = 0
        Me.PhotoPictureBox.TabStop = False
        '
        'BrowseButton
        '
        Me.BrowseButton.Location = New System.Drawing.Point(12, 281)
        Me.BrowseButton.Name = "BrowseButton"
        Me.BrowseButton.Size = New System.Drawing.Size(75, 25)
        Me.BrowseButton.TabIndex = 1
        Me.BrowseButton.Text = "Browse"
        Me.BrowseButton.UseVisualStyleBackColor = True
        '
        'LabelPhoto
        '
        Me.LabelPhoto.AutoSize = True
        Me.LabelPhoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPhoto.Location = New System.Drawing.Point(12, 221)
        Me.LabelPhoto.Name = "LabelPhoto"
        Me.LabelPhoto.Size = New System.Drawing.Size(80, 16)
        Me.LabelPhoto.TabIndex = 2
        Me.LabelPhoto.Text = "Label Photo"
        '
        'LabelLokasi
        '
        Me.LabelLokasi.AutoSize = True
        Me.LabelLokasi.Location = New System.Drawing.Point(12, 245)
        Me.LabelLokasi.Name = "LabelLokasi"
        Me.LabelLokasi.Size = New System.Drawing.Size(67, 13)
        Me.LabelLokasi.TabIndex = 3
        Me.LabelLokasi.Text = "Label Lokasi"
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(119, 282)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 25)
        Me.SaveButton.TabIndex = 4
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'FormChangePhoto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(211, 340)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.LabelLokasi)
        Me.Controls.Add(Me.LabelPhoto)
        Me.Controls.Add(Me.BrowseButton)
        Me.Controls.Add(Me.PhotoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormChangePhoto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Photo"
        CType(Me.PhotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PhotoPictureBox As PictureBox
    Friend WithEvents BrowseButton As Button
    Friend WithEvents LabelPhoto As Label
    Friend WithEvents LabelLokasi As Label
    Friend WithEvents SaveButton As Button
End Class
