Public Class Pong
    Dim x1, ballx, bally, xspeed, yspeed, score As Integer
    Dim rand As New Random
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ballx > 770 Then xspeed = -10
        If ballx < 10 Then xspeed = 10
        If bally < 10 Then yspeed = 10
        If bally > 480 Then
            If ballx > x1 - 60 And ballx < x1 + 50 Then
                yspeed = -10
                score = score + 1
                Scorebox.Text = score
                If Timer1.Interval > 10 Then Timer1.Interval = Timer1.Interval - 5
            Else
                Timer1.Enabled = False
                MsgBox("The End! Score was" & score)
                Close()
            End If
        End If
        ballx = ballx + xspeed
        bally = bally + yspeed
        Ball.Left = ballx
        Ball.Top = bally
    End Sub

    Private Sub Pong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        xspeed = rand.Next(2)
        If xspeed >= 1 Then xspeed = 10 Else xspeed = -10
        yspeed = -10
        ballx = rand.Next(400)
        bally = 460
        score = 0
        Timer1.Enabled = True
    End Sub

    Private Sub Pong_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        x1 = e.X
        Bat.Left = x1 - 50

    End Sub
End Class
