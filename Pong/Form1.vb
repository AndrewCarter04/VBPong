Public Class frmPong

    Dim r As New Random

    Dim moveAmount As Integer = 5
    Dim paddleMoveAmount As Integer = 15
    Dim p1Score As Integer = 0
    Dim p2Score As Integer = 0

    Dim x As Boolean = False
    Dim y As Boolean = False
    Dim cpu As Boolean = True
    Dim spacePressed As Boolean = False
    Dim impossible As Boolean = False

    Dim a As Boolean = False
    Dim b As Boolean = False
    Dim c As Boolean = False

    Private Sub frmPong_Load(sender As Object, e As EventArgs) Handles Me.Load

        x = r.Next(2)
        y = r.Next(2)
        lblWinner.Hide()

    End Sub

    Private Sub tmrBallMove_Tick(sender As Object, e As EventArgs) Handles tmrBallMove.Tick

        If x And y Then
            pctBall.Location = New Point(pctBall.Location.X + moveAmount, pctBall.Location.Y + moveAmount)
        ElseIf x And (Not y) Then
            pctBall.Location = New Point(pctBall.Location.X + moveAmount, pctBall.Location.Y - moveAmount)
        ElseIf (Not x) And y Then
            pctBall.Location = New Point(pctBall.Location.X - moveAmount, pctBall.Location.Y + moveAmount)
        ElseIf Not (x And y) Then
            pctBall.Location = New Point(pctBall.Location.X - moveAmount, pctBall.Location.Y - moveAmount)
        End If

        'If pctBall.Left <= 2 Or pctBall.Left >= 915 Then
        '    x = Not x
        'End If

        If pctBall.Top <= 0 Or pctBall.Top >= 490 Then
            y = Not y
        End If

        checkLocation()

    End Sub

    Private Sub frmPong_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmMenu.Close()
    End Sub

    Private Sub checkLocation()

        If lblPaddle1.Visible And pctBall.Left <= lblPaddle1.Left + lblPaddle1.Width And pctBall.Left >= lblPaddle1.Left - pctBall.Width And pctBall.Top >= lblPaddle1.Top - pctBall.Height And pctBall.Top <= lblPaddle1.Top + lblPaddle1.Height Then
            x = Not x
        End If

        If lblPaddle2.Visible And pctBall.Left <= lblPaddle2.Left + lblPaddle2.Width And pctBall.Left >= lblPaddle2.Left - pctBall.Width And pctBall.Top >= lblPaddle2.Top - pctBall.Height And pctBall.Top <= lblPaddle2.Top + lblPaddle2.Height Then
            x = Not x
        End If

        If pctBall.Left < -20 Then
            score(2)
        End If

        If pctBall.Left > 970 Then
            score(1)
        End If



    End Sub

    Private Sub score(player As Integer)

        If player = 1 Then
            p1Score += 1
            x = True
        ElseIf player = 2 Then
            p2Score += 1
            x = False
        End If

        updateScore()

        y = r.Next(2)

        pctBall.Location = New Point(466, 245)

        If p1Score >= 10 Then

            win(1)

        ElseIf p2Score >= 10 Then

            win(2)

        End If

    End Sub

    Private Sub win(player As Integer)

        tmrBallMove.Stop()
        tmrCpu.Stop()
        lblSpace.Show()
        spacePressed = False

        If player = 1 And Not cpu Then
            lblWinner.Text = "P1 Wins!"
        ElseIf player = 2 And Not cpu Then
            lblWinner.Text = "P2 Wins!"
        ElseIf player = 2 And cpu Then
            lblWinner.Text = "P1 Wins!"
        Else
            lblWinner.Text = "CPU Wins!"
        End If

        lblWinner.Show()
        lblPaddle1.Show()

    End Sub

    Private Sub updateScore()

        lblP1Score.Text = p1Score
        lblP2Score.Text = p2Score

    End Sub

    Public Sub setSettings(onePlayer As Boolean, impossibleMode As Boolean)

        cpu = onePlayer
        impossible = impossibleMode

    End Sub

    Private Sub frmPong_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Space And Not spacePressed Then
            spacePressed = True
            tmrBallMove.Start()
            tmrCpu.Start()
            lblSpace.Hide()
            p1Score = 0
            p2Score = 0
            updateScore()
            lblPaddle1.Location = New Point(12, 141)
            lblPaddle2.Location = New Point(912, 141)
            lblWinner.Hide()
        End If

        If Not spacePressed Then
            Return
        End If

        If e.KeyCode = Keys.Up Then

            lblPaddle2.Top -= paddleMoveAmount

        ElseIf e.KeyCode = Keys.Down Then

            lblPaddle2.Top += paddleMoveAmount

        ElseIf e.KeyCode = Keys.W Then

            If cpu Then
                lblPaddle2.Top -= paddleMoveAmount
            Else
                lblPaddle1.Top -= paddleMoveAmount
            End If

        ElseIf e.KeyCode = Keys.S Then

            If cpu Then
                lblPaddle2.Top += paddleMoveAmount
            Else
                lblPaddle1.Top += paddleMoveAmount
            End If

        End If

        If lblPaddle2.Top < 0 Then
            lblPaddle2.Top = 0
        End If

        If lblPaddle2.Top > 418 Then
            lblPaddle2.Top = 418
        End If

        If lblPaddle1.Top < 0 Then
            lblPaddle1.Top = 0
        End If

        If lblPaddle1.Top > 418 Then
            lblPaddle1.Top = 418
        End If

        If e.KeyCode = Keys.A Then
            a = True
        ElseIf e.KeyCode = Keys.B Then
            b = True
        ElseIf e.KeyCode = Keys.C Then
            c = True
        End If

        checkABC()

    End Sub

    Private Sub checkABC()

        If a And b And c Then
            lblPaddle1.Visible = Not lblPaddle1.Visible
        End If

    End Sub

    Private Sub tmrCpu_Tick(sender As Object, e As EventArgs) Handles tmrCpu.Tick

        If cpu And Not impossible Then

            Dim paddleMid As Integer = lblPaddle1.Top - (lblPaddle1.Size.Height / 2)
            Dim ballMid As Integer = pctBall.Top - (pctBall.Size.Height / 2)

            If paddleMid > ballMid Then
                lblPaddle1.Top -= paddleMoveAmount
            Else
                lblPaddle1.Top += paddleMoveAmount
            End If

            If lblPaddle1.Top < 0 Then
                lblPaddle1.Top = 0
            End If

            If lblPaddle1.Top > 418 Then
                lblPaddle1.Top = 418
            End If

        ElseIf cpu And impossible Then

            Dim paddleMid As Integer = lblPaddle1.Top - (lblPaddle1.Size.Height / 2)

            Dim loc As Point = New Point(pctBall.Location.X, pctBall.Location.Y)
            Dim x2 As Boolean = x
            Dim y2 As Boolean = y
            Dim moveTo As Integer = -1


            If Not x Then

                While moveTo = -1

                    If x2 And y2 Then
                        loc = New Point(loc.X + moveAmount, loc.Y + moveAmount)
                    ElseIf x2 And (Not y2) Then
                        loc = New Point(loc.X + moveAmount, loc.Y - moveAmount)
                    ElseIf (Not x2) And y2 Then
                        loc = New Point(loc.X - moveAmount, loc.Y + moveAmount)
                    ElseIf Not (x2 And y2) Then
                        loc = New Point(loc.X - moveAmount, loc.Y - moveAmount)
                    End If

                    If loc.Y <= 0 Or loc.Y >= 490 Then
                        y2 = Not y2
                    End If

                    If loc.X < -20 Then
                        moveTo = loc.Y
                    End If

                End While

                lblPaddle1.Top = moveTo - (lblPaddle1.Size.Height / 2)

                If lblPaddle1.Top < 0 Then
                    lblPaddle1.Top = 0
                End If

                If lblPaddle1.Top > 418 Then
                    lblPaddle1.Top = 418
                End If

            End If

        End If

    End Sub

    Private Sub frmPong_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp

        If e.KeyCode = Keys.A Then
            a = False
        ElseIf e.KeyCode = Keys.B Then
            b = False
        ElseIf e.KeyCode = Keys.C Then
            c = False
        End If

        checkABC()

    End Sub

End Class
