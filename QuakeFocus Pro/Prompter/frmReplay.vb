Imports Microsoft.WindowsAPICodePack.Dialogs

Public Class frmReplay
    Private Sub btnRewind_Click(sender As Object, e As EventArgs) Handles btnRewind.Click
        Dim result As DialogResult = MessageBox.Show("リプレイモードが有効な場合、リプレイモードを無効にするまで、QuakeFocus Proは現在のアラートを確認することができません。有効にする前に注意してください。本当にリプレイモードを有効にするのですか？" & vbCrLf & vbCrLf & "When replay mode is enabled, QuakeFocus Pro will not be able to check for current alerts until replay mode is disabled. Please use caution before enabling it. Are you sure you want to enable replay mode?", "警告/WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Cancel Then
            ' MessageBox.Show("Cancel pressed")
        ElseIf result = DialogResult.No Then
            'MessageBox.Show("No pressed")
        ElseIf result = DialogResult.Yes Then
            Dim dtUnsort As String = selectionEvent.Value
            'Obtain two values to calculate an offset time

            Dim selDT As Date = Date.Parse(dtUnsort)
            'Dim curDate As Date = DateTime.Now()
            Dim curDate = System.TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time"))

            Dim subSecond As Integer = (curDate - selDT).TotalSeconds()
            Console.WriteLine("Selected Seconds: " & subSecond)

            If subSecond < 1 Then
                MessageBox.Show("過去の時間帯を選択してください。" & vbCrLf & "Please select a time in the past.", "警告/WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                '  MsgBox(subSecond)

                apiTimer.rwTime = subSecond
                btnStop.Enabled = True
                btnRewind.Enabled = False


            End If


            ' MsgBox(selDT.ToLongTimeString)
        End If


    End Sub

    Private Sub frmReplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        selectionEvent.Format = DateTimePickerFormat.Custom
        selectionEvent.CustomFormat = "MM/dd/yyyy HH:mm:ss"


    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        apiTimer.rwTime = "0"
        btnStop.Enabled = False
        btnRewind.Enabled = True
    End Sub
End Class