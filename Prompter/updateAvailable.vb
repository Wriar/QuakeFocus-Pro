Imports System.Windows.Forms

Public Class updateAvailable
    Private PromtMsg As String
    Sub New(ByVal promtmsg As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' set global field with the argument that was passed to the constructor
        Me.PromtMsg = promtmsg
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.No
        Me.Close()
    End Sub

    Private Sub updateAvailable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.infoText.Text = Me.PromtMsg
    End Sub

    Private Sub updateAvailable_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.TopMost = True

    End Sub
End Class
