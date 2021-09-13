<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKependudukan
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.KartuKeluarga1 = New System_Information_Desa.KartuKeluarga()
        Me.AddDataPenduduk1 = New System_Information_Desa.AddDataPenduduk()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.InsertButton = New System.Windows.Forms.Button()
        Me.CancelButton1 = New System.Windows.Forms.Button()
        Me.ClearTabelButton = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.SaveButton1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 24)
        Me.Label2.TabIndex = 257
        Me.Label2.Text = "Input Data Penduduk / KK"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.49183!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 618.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.KartuKeluarga1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.AddDataPenduduk1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 40)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1256, 543)
        Me.TableLayoutPanel1.TabIndex = 260
        '
        'KartuKeluarga1
        '
        Me.KartuKeluarga1.AutoScroll = True
        Me.KartuKeluarga1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KartuKeluarga1.Location = New System.Drawing.Point(639, 7)
        Me.KartuKeluarga1.Margin = New System.Windows.Forms.Padding(4)
        Me.KartuKeluarga1.Name = "KartuKeluarga1"
        Me.KartuKeluarga1.Size = New System.Drawing.Size(610, 529)
        Me.KartuKeluarga1.TabIndex = 1
        '
        'AddDataPenduduk1
        '
        Me.AddDataPenduduk1.AutoScroll = True
        Me.AddDataPenduduk1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddDataPenduduk1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddDataPenduduk1.Location = New System.Drawing.Point(7, 7)
        Me.AddDataPenduduk1.Margin = New System.Windows.Forms.Padding(4)
        Me.AddDataPenduduk1.Name = "AddDataPenduduk1"
        Me.AddDataPenduduk1.Size = New System.Drawing.Size(621, 529)
        Me.AddDataPenduduk1.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.InsertButton, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.CancelButton1, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ClearTabelButton, 4, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(16, 602)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(374, 31)
        Me.TableLayoutPanel2.TabIndex = 261
        '
        'InsertButton
        '
        Me.InsertButton.Location = New System.Drawing.Point(3, 3)
        Me.InsertButton.Name = "InsertButton"
        Me.InsertButton.Size = New System.Drawing.Size(75, 25)
        Me.InsertButton.TabIndex = 262
        Me.InsertButton.Text = "Insert"
        Me.InsertButton.UseVisualStyleBackColor = True
        '
        'CancelButton1
        '
        Me.CancelButton1.Location = New System.Drawing.Point(134, 3)
        Me.CancelButton1.Name = "CancelButton1"
        Me.CancelButton1.Size = New System.Drawing.Size(75, 25)
        Me.CancelButton1.TabIndex = 263
        Me.CancelButton1.Text = "Cancel"
        Me.CancelButton1.UseVisualStyleBackColor = True
        '
        'ClearTabelButton
        '
        Me.ClearTabelButton.Location = New System.Drawing.Point(265, 3)
        Me.ClearTabelButton.Name = "ClearTabelButton"
        Me.ClearTabelButton.Size = New System.Drawing.Size(105, 25)
        Me.ClearTabelButton.TabIndex = 264
        Me.ClearTabelButton.Text = "Clear Tabel"
        Me.ClearTabelButton.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(539, 605)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 25)
        Me.ButtonClose.TabIndex = 262
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'SaveButton1
        '
        Me.SaveButton1.Location = New System.Drawing.Point(1162, 605)
        Me.SaveButton1.Name = "SaveButton1"
        Me.SaveButton1.Size = New System.Drawing.Size(75, 25)
        Me.SaveButton1.TabIndex = 263
        Me.SaveButton1.Text = "Save"
        Me.SaveButton1.UseVisualStyleBackColor = True
        '
        'FormKependudukan
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1280, 676)
        Me.ControlBox = False
        Me.Controls.Add(Me.SaveButton1)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormKependudukan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Kependudukan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents InsertButton As Button
    Friend WithEvents CancelButton1 As Button
    Friend WithEvents ClearTabelButton As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents SaveButton1 As Button
    Friend WithEvents KartuKeluarga1 As KartuKeluarga
    Friend WithEvents AddDataPenduduk1 As AddDataPenduduk
End Class
