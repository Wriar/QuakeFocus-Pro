Public Class globalSettings
    Private Sub globalSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabControl1_DrawItem(sender As Object, e As DrawItemEventArgs)
        Dim g As Graphics
        Dim sText As String
        Dim iX As Integer
        Dim iY As Integer
        Dim sizeText As SizeF
        Dim ctlTab As TabControl


        Dim r As New RectangleF(e.Bounds.X, e.Bounds.Y + 2, e.Bounds.Width, e.Bounds.Height - 2)

        ctlTab = CType(sender, TabControl)

        g = e.Graphics
        sText = ctlTab.TabPages(e.Index).Text
        sizeText = g.MeasureString(sText, ctlTab.Font)
        iX = e.Bounds.Left + 6
        iY = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2

        If TabControl1.SelectedIndex = e.Index Then 'Selected Tab
            g.FillRectangle(SystemBrushes.ControlLightLight, e.Bounds) '<--- My modification
            'Else 
            'This code is unnecessary because the control will automatically paint non-selected tabs
            '    g.FillRectangle(New SolidBrush(Color.LightBlue), e.Bounds)
        End If

        g.DrawString(sText, ctlTab.Font, Brushes.Black, iX, iY)
    End Sub

    Private Sub btnCS1_Click(sender As Object, e As EventArgs) Handles btnCS1.Click
        MessageBox.Show("Custom Variables can be used to dynamically create Web or CMD requests.
For example, to echo a CMD request about the 'shaking prefecture' in 'light shaking', use 'echo ~detectprefecture~' where '~' surrounds the custom variable.

Custom Variables Available:

~detectprefecture~ -> Prefecture(s) where Light Shaking is detected, seperated by a comma (In Japanese).
~detectstations~ -> Station(s) where Light Shaking is detected, seperated by a comma (In Japanese)

カスタム変数は、WebリクエストやCMDリクエストを動的に作成するために使用できます。
例えば、「light shaking」の「shaking prefecture」に関するCMDリクエストをエコーするには、「echo ~detectprefecture~」とし、「~」でカスタム変数を囲みます。

使用できるカスタム変数

~detectprefecture~ -> 光の揺れが検出された都道府県をカンマで区切ってください。
~detectstations~ -> 光の揺れが検出された駅（複数可）、コンマで区切る（日本語で)
", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub
End Class