'Imports Microsoft.WindowsAPICodePack.Dialogs
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports KPreisser.UI

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

                If cusRealtimeServerCheck.Checked = True Then
                    My.Settings.dataImgChannel = cusRealtimeServer.Text
                    My.Settings.dataChannel = cusRealtimeServer.Text & "data/map_img"

                End If


                ' MsgBox(selDT.ToLongTimeString)
            End If
        End If


    End Sub

    Private Sub frmReplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        selectionEvent.Format = DateTimePickerFormat.Custom
        selectionEvent.CustomFormat = "MM/dd/yyyy HH:mm:ss"

        'Handle Translations
        ' Dim iniPath As String = Application.StartupPath & "\assets\localization\rewind.ini"
        ' MsgBox(iniPath)
        ' Dim objIniFile As New clsIni(iniPath)
        ' Dim indexKey As String
        '     If My.Settings.prefixLang.ToLower() = "en" Then
        'indexKey = "EN"
        ' Else
        ' indexKey = "JP"
        ' End If


        ' titleText.Text = objIniFile.GetString(indexKey, "headingText", "")
        ' capText.Text = objIniFile.GetString(indexKey, "captionText", "")
        ' selectPrompt.Text = objIniFile.GetString(indexKey, "datePrompt", "")
        ' btnRewind.Text = objIniFile.GetString(indexKey, "rewindBtn", "")
        ' btnStop.Text = objIniFile.GetString(indexKey, "stopBtn", "")
        ' realtimeServerPrompt.Text = objIniFile.GetString(indexKey, "realtimeServerPrompt", "")
        ' jsonServerPrompt.Text = objIniFile.GetString(indexKey, "jsonServerPrompt", "")
        ' cusJsonServerCheck.Text = objIniFile.GetString(indexKey, "checkBoxJson", "")
        ' cusRealtimeServerCheck.Text = objIniFile.GetString(indexKey, "checkBoxRealtime", "")
        ' curRew.Text = objIniFile.GetString(indexKey, "rewindText", "")
        '  Me.Text = objIniFile.GetString(indexKey, "formTitle", "")

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click

        apiTimer.rwTime = "0"
        btnStop.Enabled = False
        btnRewind.Enabled = True
    End Sub

    Private Sub cusJsonServerCheck_CheckedChanged(sender As Object, e As EventArgs) Handles cusJsonServerCheck.CheckedChanged
        If cusJsonServerCheck.Checked = True Then
            cusJsonserver.Enabled = True
        Else
            cusJsonserver.Enabled = False
            cusJsonserver.Text = "www.kmoni.bosai.go.jp"
        End If
    End Sub

    Private Sub cusRealtimeServerCheck_CheckedChanged(sender As Object, e As EventArgs) Handles cusRealtimeServerCheck.CheckedChanged
        If cusRealtimeServerCheck.Checked = True Then
            cusRealtimeServer.Enabled = True
        Else
            cusRealtimeServer.Enabled = False
            cusRealtimeServer.Text = "http://www.kmoni.bosai.go.jp/data/map_img"

        End If
    End Sub

    Private Sub tpDocker_Paint(sender As Object, e As PaintEventArgs) Handles tpDocker.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        selectionEvent.Value = "01/22/2022 01:08:35"
    End Sub
End Class