<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreate
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
        Me.objPlayer2 = New System.Windows.Forms.Label()
        Me.objPlayer1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'objPlayer2
        '
        Me.objPlayer2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.objPlayer2.Location = New System.Drawing.Point(691, 204)
        Me.objPlayer2.Name = "objPlayer2"
        Me.objPlayer2.Size = New System.Drawing.Size(15, 69)
        Me.objPlayer2.TabIndex = 4
        Me.objPlayer2.Text = "Label2"
        '
        'objPlayer1
        '
        Me.objPlayer1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.objPlayer1.Location = New System.Drawing.Point(12, 204)
        Me.objPlayer1.Name = "objPlayer1"
        Me.objPlayer1.Size = New System.Drawing.Size(15, 69)
        Me.objPlayer1.TabIndex = 3
        Me.objPlayer1.Text = "Label1"
        '
        'frmCreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 477)
        Me.Controls.Add(Me.objPlayer2)
        Me.Controls.Add(Me.objPlayer1)
        Me.MaximumSize = New System.Drawing.Size(734, 516)
        Me.MinimumSize = New System.Drawing.Size(734, 516)
        Me.Name = "frmCreate"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents objPlayer2 As Label
    Friend WithEvents objPlayer1 As Label
End Class
