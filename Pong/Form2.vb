Public Class frmMenu

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        frmPong.Show()
        frmPong.setSettings(rdb1Player.Checked, (chkImpossible.Checked And chkImpossible.Visible))
        Me.Hide()

    End Sub

    Private Sub rdb2Player_CheckedChanged(sender As Object, e As EventArgs) Handles rdb2Player.CheckedChanged
        chkImpossible.Hide()
    End Sub

    Private Sub rdb1Player_CheckedChanged(sender As Object, e As EventArgs) Handles rdb1Player.CheckedChanged
        chkImpossible.Show()
    End Sub
End Class