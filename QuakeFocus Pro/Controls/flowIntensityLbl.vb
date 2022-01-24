Public Class flowIntensityLbl
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.



    End Sub

    Private Sub flowIntensityLbl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If lblEpicenter.Text.Length > 23 Then
            lblEpicenter.Font = New Font("Arial", 10, FontStyle.Regular)
        Else
            lblEpicenter.Font = New Font("Arial", 12, FontStyle.Regular)
        End If
    End Sub
End Class
