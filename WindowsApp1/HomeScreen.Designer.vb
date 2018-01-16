<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeScreen))
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnJoin = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.btnCntrls = New System.Windows.Forms.Button()
        Me.txtRules = New System.Windows.Forms.RichTextBox()
        Me.btnRules2 = New System.Windows.Forms.Button()
        Me.txtNames = New System.Windows.Forms.TextBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.Lavender
        Me.btnCreate.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnCreate.Location = New System.Drawing.Point(12, 229)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(144, 45)
        Me.btnCreate.TabIndex = 0
        Me.btnCreate.Text = "Create Game"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'btnJoin
        '
        Me.btnJoin.BackColor = System.Drawing.Color.Lavender
        Me.btnJoin.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJoin.ForeColor = System.Drawing.Color.Red
        Me.btnJoin.Location = New System.Drawing.Point(196, 234)
        Me.btnJoin.Name = "btnJoin"
        Me.btnJoin.Size = New System.Drawing.Size(140, 40)
        Me.btnJoin.TabIndex = 1
        Me.btnJoin.Text = "Join Game"
        Me.btnJoin.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(124, 144)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(107, 45)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.DarkOrange
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox1.Font = New System.Drawing.Font("Vineta BT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Khaki
        Me.TextBox1.Location = New System.Drawing.Point(-2, 65)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(352, 36)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = " ExXxtreme PONG"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(124, 305)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(107, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(296, 144)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(107, 45)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(-60, 144)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(107, 45)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(-60, 305)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(107, 45)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 8
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(296, 305)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(107, 45)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 9
        Me.PictureBox6.TabStop = False
        '
        'btnCntrls
        '
        Me.btnCntrls.BackColor = System.Drawing.Color.Lavender
        Me.btnCntrls.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCntrls.ForeColor = System.Drawing.Color.OliveDrab
        Me.btnCntrls.Location = New System.Drawing.Point(124, 118)
        Me.btnCntrls.Name = "btnCntrls"
        Me.btnCntrls.Size = New System.Drawing.Size(107, 45)
        Me.btnCntrls.TabIndex = 13
        Me.btnCntrls.Text = "Rules"
        Me.btnCntrls.UseVisualStyleBackColor = False
        '
        'txtRules
        '
        Me.txtRules.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtRules.Font = New System.Drawing.Font("Lucida Bright", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRules.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtRules.Location = New System.Drawing.Point(12, 169)
        Me.txtRules.Name = "txtRules"
        Me.txtRules.ReadOnly = True
        Me.txtRules.Size = New System.Drawing.Size(324, 220)
        Me.txtRules.TabIndex = 15
        Me.txtRules.Text = ""
        Me.txtRules.Visible = False
        '
        'btnRules2
        '
        Me.btnRules2.BackColor = System.Drawing.Color.Lavender
        Me.btnRules2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRules2.ForeColor = System.Drawing.Color.OliveDrab
        Me.btnRules2.Location = New System.Drawing.Point(124, 118)
        Me.btnRules2.Name = "btnRules2"
        Me.btnRules2.Size = New System.Drawing.Size(107, 45)
        Me.btnRules2.TabIndex = 16
        Me.btnRules2.Text = "Rules"
        Me.btnRules2.UseVisualStyleBackColor = False
        '
        'txtNames
        '
        Me.txtNames.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtNames.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtNames.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNames.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNames.Location = New System.Drawing.Point(-2, -1)
        Me.txtNames.Multiline = True
        Me.txtNames.Name = "txtNames"
        Me.txtNames.ReadOnly = True
        Me.txtNames.Size = New System.Drawing.Size(352, 24)
        Me.txtNames.TabIndex = 17
        Me.txtNames.Text = " Created By : Ali, Ethan & Seaton"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(296, -22)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(107, 45)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 18
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(124, -22)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(107, 45)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 19
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(-60, -22)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(107, 45)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 20
        Me.PictureBox9.TabStop = False
        '
        'HomeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(344, 396)
        Me.Controls.Add(Me.txtRules)
        Me.Controls.Add(Me.btnRules2)
        Me.Controls.Add(Me.btnCntrls)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnJoin)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtNames)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox9)
        Me.Name = "HomeScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ping Pong"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCreate As Button
    Friend WithEvents btnJoin As Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCntrls As System.Windows.Forms.Button
    Friend WithEvents txtRules As System.Windows.Forms.RichTextBox
    Friend WithEvents btnRules2 As System.Windows.Forms.Button
    Friend WithEvents txtNames As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
End Class
