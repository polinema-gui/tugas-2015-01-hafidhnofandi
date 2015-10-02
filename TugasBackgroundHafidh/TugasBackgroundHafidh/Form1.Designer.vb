<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GantiButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'GantiButton
        '
        Me.GantiButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GantiButton.Location = New System.Drawing.Point(197, 227)
        Me.GantiButton.Name = "GantiButton"
        Me.GantiButton.Size = New System.Drawing.Size(75, 23)
        Me.GantiButton.TabIndex = 0
        Me.GantiButton.Text = "Ganti Warna"
        Me.GantiButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.GantiButton)
        Me.Name = "Form1"
        Me.Text = "GantiWarnaHafidh"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GantiButton As System.Windows.Forms.Button

End Class
