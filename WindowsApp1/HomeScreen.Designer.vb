﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnJoin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(74, 95)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(113, 23)
        Me.btnCreate.TabIndex = 0
        Me.btnCreate.Text = "Create Game"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnJoin
        '
        Me.btnJoin.Location = New System.Drawing.Point(95, 166)
        Me.btnJoin.Name = "btnJoin"
        Me.btnJoin.Size = New System.Drawing.Size(75, 23)
        Me.btnJoin.TabIndex = 1
        Me.btnJoin.Text = "Join Game"
        Me.btnJoin.UseVisualStyleBackColor = True
        '
        'HomeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnJoin)
        Me.Controls.Add(Me.btnCreate)
        Me.Name = "HomeScreen"
        Me.Text = "Ping Pong"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCreate As Button
    Friend WithEvents btnJoin As Button
End Class
