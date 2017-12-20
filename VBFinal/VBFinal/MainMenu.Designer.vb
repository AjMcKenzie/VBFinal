<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.components = New System.ComponentModel.Container()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblLogoName = New System.Windows.Forms.Label()
        Me.btnExitM = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.btnShopM = New System.Windows.Forms.Button()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(155, 78)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(90, 35)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        Me.btnStart.Visible = False
        '
        'Timer1
        '
        '
        'lblLogoName
        '
        Me.lblLogoName.AutoSize = True
        Me.lblLogoName.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogoName.Location = New System.Drawing.Point(12, 282)
        Me.lblLogoName.Name = "lblLogoName"
        Me.lblLogoName.Size = New System.Drawing.Size(381, 49)
        Me.lblLogoName.TabIndex = 2
        Me.lblLogoName.Text = "TurtleEntertainments"
        '
        'btnExitM
        '
        Me.btnExitM.Location = New System.Drawing.Point(155, 182)
        Me.btnExitM.Name = "btnExitM"
        Me.btnExitM.Size = New System.Drawing.Size(90, 35)
        Me.btnExitM.TabIndex = 3
        Me.btnExitM.Text = "Exit"
        Me.btnExitM.UseVisualStyleBackColor = True
        Me.btnExitM.Visible = False
        '
        'picLogo
        '
        Me.picLogo.Image = Global.VBFinal.My.Resources.Resources.TurtleGames
        Me.picLogo.Location = New System.Drawing.Point(72, 28)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(256, 241)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 1
        Me.picLogo.TabStop = False
        '
        'btnShopM
        '
        Me.btnShopM.Location = New System.Drawing.Point(155, 131)
        Me.btnShopM.Name = "btnShopM"
        Me.btnShopM.Size = New System.Drawing.Size(90, 35)
        Me.btnShopM.TabIndex = 4
        Me.btnShopM.Text = "Shop"
        Me.btnShopM.UseVisualStyleBackColor = True
        Me.btnShopM.Visible = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 358)
        Me.Controls.Add(Me.btnShopM)
        Me.Controls.Add(Me.btnExitM)
        Me.Controls.Add(Me.lblLogoName)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.picLogo)
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblLogoName As System.Windows.Forms.Label
    Friend WithEvents btnExitM As System.Windows.Forms.Button
    Friend WithEvents btnShopM As System.Windows.Forms.Button



End Class
