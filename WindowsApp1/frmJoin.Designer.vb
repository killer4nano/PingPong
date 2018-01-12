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
        Me.lblIp = New System.Windows.Forms.Label()
        Me.objPlayer1 = New System.Windows.Forms.Label()
        Me.objPlayer2 = New System.Windows.Forms.Label()
        Me.objBall = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblIp
        '
        Me.lblIp.AutoSize = True
        Me.lblIp.Location = New System.Drawing.Point(106, 22)
        Me.lblIp.Name = "lblIp"
        Me.lblIp.Size = New System.Drawing.Size(0, 13)
        Me.lblIp.TabIndex = 0
        '
        'objPlayer1
        '
        Me.objPlayer1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.objPlayer1.Location = New System.Drawing.Point(12, 204)
        Me.objPlayer1.Name = "objPlayer1"
        Me.objPlayer1.Size = New System.Drawing.Size(15, 69)
        Me.objPlayer1.TabIndex = 1
        Me.objPlayer1.Text = "Label1"
        '
        'objPlayer2
        '
        Me.objPlayer2.BackColor = System.Drawing.SystemColors.Highlight
        Me.objPlayer2.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.objPlayer2.Location = New System.Drawing.Point(691, 204)
        Me.objPlayer2.Name = "objPlayer2"
        Me.objPlayer2.Size = New System.Drawing.Size(15, 69)
        Me.objPlayer2.TabIndex = 2
        '
        'objBall
        '
        Me.objBall.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.objBall.Location = New System.Drawing.Point(353, 231)
        Me.objBall.Name = "objBall"
        Me.objBall.Size = New System.Drawing.Size(13, 14)
        Me.objBall.TabIndex = 6
        '
        'frmJoin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 477)
        Me.Controls.Add(Me.objBall)
        Me.Controls.Add(Me.objPlayer2)
        Me.Controls.Add(Me.objPlayer1)
        Me.Controls.Add(Me.lblIp)
        Me.MaximumSize = New System.Drawing.Size(734, 516)
        Me.MinimumSize = New System.Drawing.Size(734, 516)
        Me.Name = "frmJoin"
        Me.Text = "Player 2 : Ping Pong"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIp As Label
    Friend WithEvents objPlayer1 As Label
    Friend WithEvents objPlayer2 As Label
    Friend WithEvents objBall As Label
End Class
