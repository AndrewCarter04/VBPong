<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPong
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
        Me.components = New System.ComponentModel.Container()
        Me.lblPaddle1 = New System.Windows.Forms.Label()
        Me.lblPaddle2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblP1Score = New System.Windows.Forms.Label()
        Me.lblP2Score = New System.Windows.Forms.Label()
        Me.pctBall = New System.Windows.Forms.PictureBox()
        Me.tmrBallMove = New System.Windows.Forms.Timer(Me.components)
        Me.lblSpace = New System.Windows.Forms.Label()
        Me.tmrCpu = New System.Windows.Forms.Timer(Me.components)
        Me.lblWinner = New System.Windows.Forms.Label()
        CType(Me.pctBall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPaddle1
        '
        Me.lblPaddle1.BackColor = System.Drawing.Color.White
        Me.lblPaddle1.Location = New System.Drawing.Point(12, 141)
        Me.lblPaddle1.Name = "lblPaddle1"
        Me.lblPaddle1.Size = New System.Drawing.Size(10, 93)
        Me.lblPaddle1.TabIndex = 0
        '
        'lblPaddle2
        '
        Me.lblPaddle2.BackColor = System.Drawing.Color.White
        Me.lblPaddle2.Location = New System.Drawing.Point(912, 141)
        Me.lblPaddle2.Name = "lblPaddle2"
        Me.lblPaddle2.Size = New System.Drawing.Size(10, 93)
        Me.lblPaddle2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(474, -18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(2, 550)
        Me.Label1.TabIndex = 2
        '
        'lblP1Score
        '
        Me.lblP1Score.BackColor = System.Drawing.Color.Black
        Me.lblP1Score.Font = New System.Drawing.Font("Microsoft YaHei", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1Score.ForeColor = System.Drawing.Color.White
        Me.lblP1Score.Location = New System.Drawing.Point(398, 9)
        Me.lblP1Score.Name = "lblP1Score"
        Me.lblP1Score.Size = New System.Drawing.Size(70, 50)
        Me.lblP1Score.TabIndex = 3
        Me.lblP1Score.Text = "0"
        Me.lblP1Score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblP2Score
        '
        Me.lblP2Score.BackColor = System.Drawing.Color.Black
        Me.lblP2Score.Font = New System.Drawing.Font("Microsoft YaHei", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP2Score.ForeColor = System.Drawing.Color.White
        Me.lblP2Score.Location = New System.Drawing.Point(482, 9)
        Me.lblP2Score.Name = "lblP2Score"
        Me.lblP2Score.Size = New System.Drawing.Size(70, 50)
        Me.lblP2Score.TabIndex = 4
        Me.lblP2Score.Text = "0"
        Me.lblP2Score.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pctBall
        '
        Me.pctBall.Image = Global.Pong.My.Resources.Resources.pong_ball
        Me.pctBall.Location = New System.Drawing.Point(466, 245)
        Me.pctBall.Name = "pctBall"
        Me.pctBall.Size = New System.Drawing.Size(20, 20)
        Me.pctBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBall.TabIndex = 5
        Me.pctBall.TabStop = False
        '
        'tmrBallMove
        '
        Me.tmrBallMove.Interval = 10
        '
        'lblSpace
        '
        Me.lblSpace.AutoSize = True
        Me.lblSpace.BackColor = System.Drawing.Color.Black
        Me.lblSpace.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpace.ForeColor = System.Drawing.Color.White
        Me.lblSpace.Location = New System.Drawing.Point(401, 68)
        Me.lblSpace.Name = "lblSpace"
        Me.lblSpace.Size = New System.Drawing.Size(153, 31)
        Me.lblSpace.TabIndex = 6
        Me.lblSpace.Text = "Press space"
        Me.lblSpace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tmrCpu
        '
        Me.tmrCpu.Interval = 50
        '
        'lblWinner
        '
        Me.lblWinner.AutoSize = True
        Me.lblWinner.BackColor = System.Drawing.Color.Black
        Me.lblWinner.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinner.ForeColor = System.Drawing.Color.White
        Me.lblWinner.Location = New System.Drawing.Point(417, 114)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(121, 31)
        Me.lblWinner.TabIndex = 7
        Me.lblWinner.Text = "P1 Wins!"
        Me.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmPong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(934, 511)
        Me.Controls.Add(Me.lblWinner)
        Me.Controls.Add(Me.lblSpace)
        Me.Controls.Add(Me.pctBall)
        Me.Controls.Add(Me.lblP2Score)
        Me.Controls.Add(Me.lblP1Score)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPaddle2)
        Me.Controls.Add(Me.lblPaddle1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmPong"
        Me.Text = "Pong"
        CType(Me.pctBall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPaddle1 As Label
    Friend WithEvents lblPaddle2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblP1Score As Label
    Friend WithEvents lblP2Score As Label
    Friend WithEvents pctBall As PictureBox
    Friend WithEvents tmrBallMove As Timer
    Friend WithEvents lblSpace As Label
    Friend WithEvents tmrCpu As Timer
    Friend WithEvents lblWinner As Label
End Class
