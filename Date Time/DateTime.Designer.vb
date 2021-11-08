<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DateTime
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
        Me.timepanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.toolbar = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.exitt = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.themepanel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.savetheme = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.theme4 = New System.Windows.Forms.RadioButton()
        Me.theme3 = New System.Windows.Forms.RadioButton()
        Me.theme2 = New System.Windows.Forms.RadioButton()
        Me.theme1 = New System.Windows.Forms.RadioButton()
        Me.defaullt = New System.Windows.Forms.RadioButton()
        Me.formElipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.timepanel.SuspendLayout()
        Me.toolbar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.themepanel.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timepanel
        '
        Me.timepanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.timepanel.Controls.Add(Me.Label1)
        Me.timepanel.Location = New System.Drawing.Point(41, 132)
        Me.timepanel.Name = "timepanel"
        Me.timepanel.Size = New System.Drawing.Size(580, 136)
        Me.timepanel.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Sitka Small", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(548, 63)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DATE                     TIME"
        '
        'toolbar
        '
        Me.toolbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.toolbar.Controls.Add(Me.PictureBox1)
        Me.toolbar.Controls.Add(Me.exitt)
        Me.toolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.toolbar.Location = New System.Drawing.Point(0, 0)
        Me.toolbar.Name = "toolbar"
        Me.toolbar.Size = New System.Drawing.Size(658, 29)
        Me.toolbar.TabIndex = 24
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Date_Time.My.Resources.Resources.dash
        Me.PictureBox1.Location = New System.Drawing.Point(597, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 23)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'exitt
        '
        Me.exitt.BackColor = System.Drawing.Color.Transparent
        Me.exitt.Image = Global.Date_Time.My.Resources.Resources.exitt
        Me.exitt.Location = New System.Drawing.Point(629, 1)
        Me.exitt.Name = "exitt"
        Me.exitt.Size = New System.Drawing.Size(29, 28)
        Me.exitt.TabIndex = 25
        Me.exitt.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'themepanel
        '
        Me.themepanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.themepanel.Controls.Add(Me.Label2)
        Me.themepanel.Controls.Add(Me.savetheme)
        Me.themepanel.Controls.Add(Me.PictureBox3)
        Me.themepanel.Controls.Add(Me.theme4)
        Me.themepanel.Controls.Add(Me.theme3)
        Me.themepanel.Controls.Add(Me.theme2)
        Me.themepanel.Controls.Add(Me.theme1)
        Me.themepanel.Controls.Add(Me.defaullt)
        Me.themepanel.Location = New System.Drawing.Point(36, 89)
        Me.themepanel.Name = "themepanel"
        Me.themepanel.Size = New System.Drawing.Size(590, 225)
        Me.themepanel.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(487, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "© 2021 Theemain"
        '
        'savetheme
        '
        Me.savetheme.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.savetheme.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savetheme.ForeColor = System.Drawing.Color.White
        Me.savetheme.Location = New System.Drawing.Point(399, 20)
        Me.savetheme.Name = "savetheme"
        Me.savetheme.Size = New System.Drawing.Size(132, 33)
        Me.savetheme.TabIndex = 5
        Me.savetheme.Text = "Save"
        Me.savetheme.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Date_Time.My.Resources.Resources.exit1
        Me.PictureBox3.Location = New System.Drawing.Point(482, 59)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(47, 45)
        Me.PictureBox3.TabIndex = 27
        Me.PictureBox3.TabStop = False
        '
        'theme4
        '
        Me.theme4.AutoSize = True
        Me.theme4.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.theme4.ForeColor = System.Drawing.Color.White
        Me.theme4.Location = New System.Drawing.Point(93, 184)
        Me.theme4.Name = "theme4"
        Me.theme4.Size = New System.Drawing.Size(103, 20)
        Me.theme4.TabIndex = 4
        Me.theme4.TabStop = True
        Me.theme4.Text = "Theme 4"
        Me.theme4.UseVisualStyleBackColor = True
        '
        'theme3
        '
        Me.theme3.AutoSize = True
        Me.theme3.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.theme3.ForeColor = System.Drawing.Color.White
        Me.theme3.Location = New System.Drawing.Point(93, 143)
        Me.theme3.Name = "theme3"
        Me.theme3.Size = New System.Drawing.Size(103, 20)
        Me.theme3.TabIndex = 3
        Me.theme3.TabStop = True
        Me.theme3.Text = "Theme 3"
        Me.theme3.UseVisualStyleBackColor = True
        '
        'theme2
        '
        Me.theme2.AutoSize = True
        Me.theme2.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.theme2.ForeColor = System.Drawing.Color.White
        Me.theme2.Location = New System.Drawing.Point(93, 102)
        Me.theme2.Name = "theme2"
        Me.theme2.Size = New System.Drawing.Size(103, 20)
        Me.theme2.TabIndex = 2
        Me.theme2.TabStop = True
        Me.theme2.Text = "Theme 2"
        Me.theme2.UseVisualStyleBackColor = True
        '
        'theme1
        '
        Me.theme1.AutoSize = True
        Me.theme1.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.theme1.ForeColor = System.Drawing.Color.White
        Me.theme1.Location = New System.Drawing.Point(93, 61)
        Me.theme1.Name = "theme1"
        Me.theme1.Size = New System.Drawing.Size(103, 20)
        Me.theme1.TabIndex = 1
        Me.theme1.TabStop = True
        Me.theme1.Text = "Theme 1"
        Me.theme1.UseVisualStyleBackColor = True
        '
        'defaullt
        '
        Me.defaullt.AutoSize = True
        Me.defaullt.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.defaullt.ForeColor = System.Drawing.Color.White
        Me.defaullt.Location = New System.Drawing.Point(93, 20)
        Me.defaullt.Name = "defaullt"
        Me.defaullt.Size = New System.Drawing.Size(103, 20)
        Me.defaullt.TabIndex = 0
        Me.defaullt.TabStop = True
        Me.defaullt.Text = "Default"
        Me.defaullt.UseVisualStyleBackColor = True
        '
        'formElipse
        '
        Me.formElipse.ElipseRadius = 20
        Me.formElipse.TargetControl = Me
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Date_Time.My.Resources.Resources.settings
        Me.PictureBox2.Location = New System.Drawing.Point(12, 320)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 36)
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.toolbar
        Me.BunifuDragControl1.Vertical = True
        '
        'DateTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(658, 368)
        Me.Controls.Add(Me.themepanel)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.toolbar)
        Me.Controls.Add(Me.timepanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DateTime"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Date Time"
        Me.TopMost = True
        Me.timepanel.ResumeLayout(False)
        Me.timepanel.PerformLayout()
        Me.toolbar.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.themepanel.ResumeLayout(False)
        Me.themepanel.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents timepanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents toolbar As Panel
    Friend WithEvents exitt As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents themepanel As Panel
    Friend WithEvents defaullt As RadioButton
    Friend WithEvents theme4 As RadioButton
    Friend WithEvents theme3 As RadioButton
    Friend WithEvents theme2 As RadioButton
    Friend WithEvents theme1 As RadioButton
    Friend WithEvents savetheme As Button
    Friend WithEvents formElipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Label2 As Label
End Class
