Public Class localPane
    Private Sub localPane_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Localize Control

        If My.Settings.prefixLang = "en" Then
            Label1.Text = "Local" & vbCrLf & "PGA:"
            Label3.Text = "Local" & vbCrLf & "Int:"
            ReplayToolStripMenuItem.Text = "リプレイ"
            SettingsToolStripMenuItem.Text = "設定"
        Else
            Label1.Text = "ローカル" & vbCrLf & "PGA:"
            Label3.Text = "ローカル" & vbCrLf & "Int:"
            ReplayToolStripMenuItem.Text = "Replay"
            SettingsToolStripMenuItem.Text = "Settings"
        End If

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Public Function requestLocalizeRefresh()

        If My.Settings.prefixLang = "en" Then
            Label1.Text = "Local" & vbCrLf & "PGA:"
            Label3.Text = "Local" & vbCrLf & "Int:"
            ReplayToolStripMenuItem.Text = "Replay"
            SettingsToolStripMenuItem.Text = "Settings"

        Else
            Label1.Text = "ローカル" & vbCrLf & "PGA:"
            Label3.Text = "ローカル" & vbCrLf & "Int:"
            ReplayToolStripMenuItem.Text = "リプレイ"
            SettingsToolStripMenuItem.Text = "設定"

        End If
    End Function

    Private Sub settingsBTN_Click(sender As Object, e As EventArgs) Handles settingsBTN.Click
        '   MessageBox.Show("申し訳ありませんが、この機能はINDEV-V0.15ではまだ利用できません。" & vbCrLf & vbCrLf & "We're sorry, but this feature is not available in INDEV-V0.15", "設定/SETTINGS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Dim btnSender As Button = CType(sender, Button)
        Dim ptLowerLeft As Point = New Point(0, btnSender.Height)
        ptLowerLeft = btnSender.PointToScreen(ptLowerLeft)
        ctxHlp.Show(ptLowerLeft)

    End Sub

    Private Sub ReplayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReplayToolStripMenuItem.Click
        frmReplay.Show()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click

    End Sub
End Class
