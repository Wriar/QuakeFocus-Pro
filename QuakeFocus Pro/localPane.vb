Public Class localPane
    Private Sub localPane_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub settingsBTN_Click(sender As Object, e As EventArgs) Handles settingsBTN.Click
        MessageBox.Show("申し訳ありませんが、この機能はINDEV-V0.15ではまだ利用できません。" & vbCrLf & vbCrLf & "We're sorry, but this feature is not available in INDEV-V0.15", "設定/SETTINGS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
End Class
