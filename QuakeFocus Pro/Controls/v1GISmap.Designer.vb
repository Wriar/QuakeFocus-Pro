<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class v1GISmap
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(v1GISmap))
        Me.SfMap1 = New EGIS.Controls.SFMap()
        Me.SuspendLayout()
        '
        'SfMap1
        '
        Me.SfMap1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.SfMap1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SfMap1.CentrePoint2D = CType(resources.GetObject("SfMap1.CentrePoint2D"), EGIS.ShapeFileLib.PointD)
        Me.SfMap1.DefaultMapCursor = System.Windows.Forms.Cursors.Default
        Me.SfMap1.DefaultSelectionCursor = System.Windows.Forms.Cursors.Arrow
        Me.SfMap1.Location = New System.Drawing.Point(0, 0)
        Me.SfMap1.MapBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.SfMap1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SfMap1.Name = "SfMap1"
        Me.SfMap1.PanSelectMode = EGIS.Controls.PanSelectMode.Pan
        Me.SfMap1.RenderQuality = EGIS.ShapeFileLib.RenderQuality.[Auto]
        Me.SfMap1.Size = New System.Drawing.Size(648, 581)
        Me.SfMap1.TabIndex = 0
        Me.SfMap1.UseMemoryStreams = False
        Me.SfMap1.UseMercatorProjection = False
        Me.SfMap1.ZoomLevel = 1.0016611295681064R
        Me.SfMap1.ZoomToSelectedExtentWhenCtrlKeydown = False
        '
        'v1GISmap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SfMap1)
        Me.Name = "v1GISmap"
        Me.Size = New System.Drawing.Size(648, 581)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SfMap1 As EGIS.Controls.SFMap
End Class
