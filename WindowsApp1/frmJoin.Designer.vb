<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmJoin
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
        Me.btnReady = New System.Windows.Forms.Button()
        Me.lblPlayer2Score = New System.Windows.Forms.Label()
        Me.lblPlayer1Score = New System.Windows.Forms.Label()
        Me.playGround = New System.Windows.Forms.GroupBox()
        Me.objPlayer1 = New System.Windows.Forms.Label()
        Me.objBall = New System.Windows.Forms.Label()
        Me.objPlayer2 = New System.Windows.Forms.Label()
        Me.playGround.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnReady
        '
        Me.btnReady.Location = New System.Drawing.Point(463, 71)
        Me.btnReady.Name = "btnReady"
        Me.btnReady.Size = New System.Drawing.Size(75, 23)
        Me.btnReady.TabIndex = 13
        Me.btnReady.TabStop = False
        Me.btnReady.Text = "Ready!"
        Me.btnReady.UseVisualStyleBackColor = True
        '
        'lblPlayer2Score
        '
        Me.lblPlayer2Score.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer2Score.Location = New System.Drawing.Point(743, 71)
        Me.lblPlayer2Score.Name = "lblPlayer2Score"
        Me.lblPlayer2Score.Size = New System.Drawing.Size(52, 30)
        Me.lblPlayer2Score.TabIndex = 12
        Me.lblPlayer2Score.Text = "0"
        '
        'lblPlayer1Score
        '
        Me.lblPlayer1Score.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer1Score.Location = New System.Drawing.Point(209, 71)
        Me.lblPlayer1Score.Name = "lblPlayer1Score"
        Me.lblPlayer1Score.Size = New System.Drawing.Size(52, 30)
        Me.lblPlayer1Score.TabIndex = 11
        Me.lblPlayer1Score.Text = "0"
        '
        'playGround
        '
        Me.playGround.Controls.Add(Me.objPlayer1)
        Me.playGround.Controls.Add(Me.objBall)
        Me.playGround.Controls.Add(Me.objPlayer2)
        Me.playGround.Location = New System.Drawing.Point(122, 104)
        Me.playGround.Name = "playGround"
        Me.playGround.Size = New System.Drawing.Size(763, 497)
        Me.playGround.TabIndex = 10
        Me.playGround.TabStop = False
        '
        'objPlayer1
        '
        Me.objPlayer1.BackColor = System.Drawing.Color.MediumBlue
        Me.objPlayer1.Location = New System.Drawing.Point(6, 201)
        Me.objPlayer1.Name = "objPlayer1"
        Me.objPlayer1.Size = New System.Drawing.Size(15, 69)
        Me.objPlayer1.TabIndex = 3
        '
        'objBall
        '
        Me.objBall.BackColor = System.Drawing.Color.Orange
        Me.objBall.Location = New System.Drawing.Point(367, 230)
        Me.objBall.Name = "objBall"
        Me.objBall.Size = New System.Drawing.Size(13, 14)
        Me.objBall.TabIndex = 5
        '
        'objPlayer2
        '
        Me.objPlayer2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.objPlayer2.Location = New System.Drawing.Point(742, 201)
        Me.objPlayer2.Name = "objPlayer2"
        Me.objPlayer2.Size = New System.Drawing.Size(15, 69)
        Me.objPlayer2.TabIndex = 4
        Me.objPlayer2.Text = "Label2"
        '
        'frmJoin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 643)
        Me.Controls.Add(Me.btnReady)
        Me.Controls.Add(Me.lblPlayer2Score)
        Me.Controls.Add(Me.lblPlayer1Score)
        Me.Controls.Add(Me.playGround)
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(1004, 682)
        Me.MinimumSize = New System.Drawing.Size(734, 516)
        Me.Name = "frmJoin"
        Me.Text = "Player 2 : Ping Pong"
        Me.playGround.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnReady As Button
    Friend WithEvents lblPlayer2Score As Label
    Friend WithEvents lblPlayer1Score As Label
    Friend WithEvents playGround As GroupBox
    Friend WithEvents objPlayer1 As Label
    Friend WithEvents objBall As Label
    Friend WithEvents objPlayer2 As Label
End Class
