<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.rdb2Player = New System.Windows.Forms.RadioButton()
        Me.rdb1Player = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkImpossible = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft YaHei", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(98, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(119, 50)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Pong"
        '
        'rdb2Player
        '
        Me.rdb2Player.AutoSize = True
        Me.rdb2Player.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb2Player.ForeColor = System.Drawing.Color.White
        Me.rdb2Player.Location = New System.Drawing.Point(12, 138)
        Me.rdb2Player.Name = "rdb2Player"
        Me.rdb2Player.Size = New System.Drawing.Size(110, 32)
        Me.rdb2Player.TabIndex = 5
        Me.rdb2Player.Text = "2 Player"
        Me.rdb2Player.UseVisualStyleBackColor = True
        '
        'rdb1Player
        '
        Me.rdb1Player.AutoSize = True
        Me.rdb1Player.Checked = True
        Me.rdb1Player.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb1Player.ForeColor = System.Drawing.Color.White
        Me.rdb1Player.Location = New System.Drawing.Point(12, 100)
        Me.rdb1Player.Name = "rdb1Player"
        Me.rdb1Player.Size = New System.Drawing.Size(181, 32)
        Me.rdb1Player.TabIndex = 6
        Me.rdb1Player.TabStop = True
        Me.rdb1Player.Text = "1 Player + CPU"
        Me.rdb1Player.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(107, 247)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 31)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chkImpossible
        '
        Me.chkImpossible.AutoSize = True
        Me.chkImpossible.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkImpossible.ForeColor = System.Drawing.SystemColors.Control
        Me.chkImpossible.Location = New System.Drawing.Point(12, 209)
        Me.chkImpossible.Name = "chkImpossible"
        Me.chkImpossible.Size = New System.Drawing.Size(204, 32)
        Me.chkImpossible.TabIndex = 8
        Me.chkImpossible.Text = "Impossible mode"
        Me.chkImpossible.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(329, 290)
        Me.Controls.Add(Me.chkImpossible)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rdb1Player)
        Me.Controls.Add(Me.rdb2Player)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmMenu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents rdb2Player As RadioButton
    Friend WithEvents rdb1Player As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents chkImpossible As CheckBox
End Class
