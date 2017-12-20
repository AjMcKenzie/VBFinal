<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Shop
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
        Me.picCharacter1 = New System.Windows.Forms.PictureBox()
        CType(Me.picCharacter1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCharacter1
        '
        Me.picCharacter1.Location = New System.Drawing.Point(95, 101)
        Me.picCharacter1.Name = "picCharacter1"
        Me.picCharacter1.Size = New System.Drawing.Size(100, 50)
        Me.picCharacter1.TabIndex = 0
        Me.picCharacter1.TabStop = False
        '
        'Shop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 389)
        Me.Controls.Add(Me.picCharacter1)
        Me.Name = "Shop"
        Me.Text = "Shop"
        CType(Me.picCharacter1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picCharacter1 As System.Windows.Forms.PictureBox
End Class
