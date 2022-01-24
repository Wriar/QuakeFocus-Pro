<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class isdDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(isdDialog))
        Me.i8nTitle = New System.Windows.Forms.Label()
        Me.lblPromptOne = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lSel = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnInstallFont = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblFontPrompt = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.warnCheck = New System.Windows.Forms.CheckBox()
        Me.warText2 = New System.Windows.Forms.Label()
        Me.warText1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.headWar = New System.Windows.Forms.Label()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'i8nTitle
        '
        Me.i8nTitle.AutoSize = True
        Me.i8nTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.i8nTitle.Location = New System.Drawing.Point(12, 20)
        Me.i8nTitle.Name = "i8nTitle"
        Me.i8nTitle.Size = New System.Drawing.Size(355, 28)
        Me.i8nTitle.TabIndex = 0
        Me.i8nTitle.Text = "Welcome to QuakeFocus Professional"
        '
        'lblPromptOne
        '
        Me.lblPromptOne.AutoSize = True
        Me.lblPromptOne.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromptOne.Location = New System.Drawing.Point(44, 13)
        Me.lblPromptOne.Name = "lblPromptOne"
        Me.lblPromptOne.Size = New System.Drawing.Size(405, 40)
        Me.lblPromptOne.TabIndex = 1
        Me.lblPromptOne.Text = "Please set your desired language. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This has already been filled based on your sy" &
    "stem language."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lSel)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblPromptOne)
        Me.Panel1.Location = New System.Drawing.Point(13, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(573, 100)
        Me.Panel1.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "1"
        '
        'lSel
        '
        Me.lSel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lSel.FormattingEnabled = True
        Me.lSel.Items.AddRange(New Object() {"やまと / Japanese", "English / 英語"})
        Me.lSel.Location = New System.Drawing.Point(244, 62)
        Me.lSel.Name = "lSel"
        Me.lSel.Size = New System.Drawing.Size(178, 24)
        Me.lSel.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(108, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "言語 / Language:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnInstallFont)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.lblFontPrompt)
        Me.Panel2.Location = New System.Drawing.Point(13, 200)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(573, 100)
        Me.Panel2.TabIndex = 4
        '
        'btnInstallFont
        '
        Me.btnInstallFont.Location = New System.Drawing.Point(47, 59)
        Me.btnInstallFont.Name = "btnInstallFont"
        Me.btnInstallFont.Size = New System.Drawing.Size(141, 32)
        Me.btnInstallFont.TabIndex = 6
        Me.btnInstallFont.Text = "&Install Now"
        Me.btnInstallFont.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "2"
        '
        'lblFontPrompt
        '
        Me.lblFontPrompt.AutoSize = True
        Me.lblFontPrompt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFontPrompt.Location = New System.Drawing.Point(44, 13)
        Me.lblFontPrompt.Name = "lblFontPrompt"
        Me.lblFontPrompt.Size = New System.Drawing.Size(326, 40)
        Me.lblFontPrompt.TabIndex = 1
        Me.lblFontPrompt.Text = "Please install required fonts." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Note: This is optional, but highly recommended."
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.warnCheck)
        Me.Panel3.Controls.Add(Me.warText2)
        Me.Panel3.Controls.Add(Me.warText1)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.headWar)
        Me.Panel3.Location = New System.Drawing.Point(13, 325)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(573, 194)
        Me.Panel3.TabIndex = 8
        '
        'warnCheck
        '
        Me.warnCheck.AutoSize = True
        Me.warnCheck.Checked = True
        Me.warnCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.warnCheck.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.warnCheck.Location = New System.Drawing.Point(43, 161)
        Me.warnCheck.Name = "warnCheck"
        Me.warnCheck.Size = New System.Drawing.Size(277, 21)
        Me.warnCheck.TabIndex = 10
        Me.warnCheck.Text = "I am not legally bound by these guidelines"
        Me.warnCheck.UseVisualStyleBackColor = True
        '
        'warText2
        '
        Me.warText2.AutoSize = True
        Me.warText2.Font = New System.Drawing.Font("Segoe UI Semibold", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.warText2.Location = New System.Drawing.Point(40, 96)
        Me.warText2.Name = "warText2"
        Me.warText2.Size = New System.Drawing.Size(450, 45)
        Me.warText2.TabIndex = 9
        Me.warText2.Text = resources.GetString("warText2.Text")
        '
        'warText1
        '
        Me.warText1.AutoSize = True
        Me.warText1.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.warText1.Location = New System.Drawing.Point(41, 43)
        Me.warText1.Name = "warText1"
        Me.warText1.Size = New System.Drawing.Size(522, 45)
        Me.warText1.TabIndex = 8
        Me.warText1.Text = resources.GetString("warText1.Text")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "3"
        '
        'headWar
        '
        Me.headWar.AutoSize = True
        Me.headWar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headWar.Location = New System.Drawing.Point(41, 13)
        Me.headWar.Name = "headWar"
        Me.headWar.Size = New System.Drawing.Size(199, 20)
        Me.headWar.TabIndex = 1
        Me.headWar.Text = "Warning for Users In Japan"
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(474, 541)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(112, 32)
        Me.btnContinue.TabIndex = 8
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'isdDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 596)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.i8nTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "isdDialog"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setup"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents i8nTitle As Label
    Friend WithEvents lblPromptOne As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents lSel As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnInstallFont As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lblFontPrompt As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents warnCheck As CheckBox
    Friend WithEvents warText2 As Label
    Friend WithEvents warText1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents headWar As Label
    Friend WithEvents btnContinue As Button
End Class
