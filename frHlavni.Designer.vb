<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frHlavni
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frHlavni))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.SouborToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtevřítToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UložítToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ObrazekToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.labelVystup = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.LabelPB = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBoxMultiline = New System.Windows.Forms.TextBox()
        Me.ButtonESC = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip2.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 33)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1200, 32)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SouborToolStripMenuItem, Me.ObrazekToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1200, 33)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'SouborToolStripMenuItem
        '
        Me.SouborToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OtevřítToolStripMenuItem, Me.UložítToolStripMenuItem})
        Me.SouborToolStripMenuItem.Name = "SouborToolStripMenuItem"
        Me.SouborToolStripMenuItem.Size = New System.Drawing.Size(87, 29)
        Me.SouborToolStripMenuItem.Text = "Soubor"
        '
        'OtevřítToolStripMenuItem
        '
        Me.OtevřítToolStripMenuItem.Name = "OtevřítToolStripMenuItem"
        Me.OtevřítToolStripMenuItem.Size = New System.Drawing.Size(168, 34)
        Me.OtevřítToolStripMenuItem.Text = "Otevřít"
        '
        'UložítToolStripMenuItem
        '
        Me.UložítToolStripMenuItem.Name = "UložítToolStripMenuItem"
        Me.UložítToolStripMenuItem.Size = New System.Drawing.Size(168, 34)
        Me.UložítToolStripMenuItem.Text = "Uložít"
        '
        'ObrazekToolStripMenuItem
        '
        Me.ObrazekToolStripMenuItem.Image = CType(resources.GetObject("ObrazekToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ObrazekToolStripMenuItem.Name = "ObrazekToolStripMenuItem"
        Me.ObrazekToolStripMenuItem.Size = New System.Drawing.Size(40, 29)
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(82, 120)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(61, 26)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(180, 118)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(62, 26)
        Me.TextBox2.TabIndex = 3
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(279, 118)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(80, 26)
        Me.NumericUpDown1.TabIndex = 4
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Location = New System.Drawing.Point(78, 183)
        Me.lblSum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(64, 20)
        Me.lblSum.TabIndex = 5
        Me.lblSum.Text = "Součet:"
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(82, 228)
        Me.TrackBar1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(267, 69)
        Me.TrackBar1.TabIndex = 6
        Me.TrackBar1.TickFrequency = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(99, 332)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Součet * TrackBar = "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(94, 277)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Posuvníkem nastaveno:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(94, 395)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(252, 28)
        Me.ComboBox1.TabIndex = 9
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(427, 308)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(67, 24)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.Text = "delší"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(426, 338)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(68, 24)
        Me.CheckBox2.TabIndex = 12
        Me.CheckBox2.Text = "vyšší"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(427, 368)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(76, 24)
        Me.CheckBox3.TabIndex = 13
        Me.CheckBox3.Text = "hlubší"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(534, 283)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(219, 164)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Materiál"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(12, 128)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(62, 24)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "sklo"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(12, 98)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(68, 24)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "plast"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(12, 68)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(58, 24)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "kov"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(12, 38)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(73, 24)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "dřevo"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'labelVystup
        '
        Me.labelVystup.AutoSize = True
        Me.labelVystup.Location = New System.Drawing.Point(95, 450)
        Me.labelVystup.Name = "labelVystup"
        Me.labelVystup.Size = New System.Drawing.Size(0, 20)
        Me.labelVystup.TabIndex = 15
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(99, 497)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(653, 56)
        Me.ProgressBar1.TabIndex = 16
        '
        'LabelPB
        '
        Me.LabelPB.AutoSize = True
        Me.LabelPB.Location = New System.Drawing.Point(99, 574)
        Me.LabelPB.Name = "LabelPB"
        Me.LabelPB.Size = New System.Drawing.Size(223, 20)
        Me.LabelPB.TabIndex = 17
        Me.LabelPB.Text = "ProgressBar bude běžet ještě:"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(779, 497)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 56)
        Me.Button1.TabIndex = 18
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'TextBoxMultiline
        '
        Me.TextBoxMultiline.Location = New System.Drawing.Point(440, 66)
        Me.TextBoxMultiline.Multiline = True
        Me.TextBoxMultiline.Name = "TextBoxMultiline"
        Me.TextBoxMultiline.Size = New System.Drawing.Size(515, 189)
        Me.TextBoxMultiline.TabIndex = 19
        '
        'ButtonESC
        '
        Me.ButtonESC.Location = New System.Drawing.Point(825, 298)
        Me.ButtonESC.Name = "ButtonESC"
        Me.ButtonESC.Size = New System.Drawing.Size(86, 54)
        Me.ButtonESC.TabIndex = 21
        Me.ButtonESC.Text = "ESC = konec"
        Me.ButtonESC.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.Yellow
        Me.ToolTip1.ShowAlways = True
        '
        'frHlavni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.ButtonESC)
        Me.Controls.Add(Me.TextBoxMultiline)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelPB)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.labelVystup)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.lblSum)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frHlavni"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "První cvičný formulář"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As Windows.Forms.MenuStrip
    Friend WithEvents MenuStrip2 As Windows.Forms.MenuStrip
    Friend WithEvents SouborToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtevřítToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents UložítToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ObrazekToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents TextBox2 As Windows.Forms.TextBox
    Friend WithEvents NumericUpDown1 As Windows.Forms.NumericUpDown
    Friend WithEvents lblSum As Windows.Forms.Label
    Friend WithEvents TrackBar1 As Windows.Forms.TrackBar
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents ComboBox1 As Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents RadioButton4 As Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As Windows.Forms.RadioButton
    Friend WithEvents labelVystup As Windows.Forms.Label
    Friend WithEvents ProgressBar1 As Windows.Forms.ProgressBar
    Friend WithEvents LabelPB As Windows.Forms.Label
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents Timer1 As Windows.Forms.Timer
    Friend WithEvents TextBoxMultiline As Windows.Forms.TextBox
    Friend WithEvents ButtonESC As Windows.Forms.Button
    Friend WithEvents ToolTip1 As Windows.Forms.ToolTip
End Class
