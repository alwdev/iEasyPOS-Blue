<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelAddZone
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
        Me.PanelShowAddZone = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'PanelShowAddZone
        '
        Me.PanelShowAddZone.Location = New System.Drawing.Point(-1, -1)
        Me.PanelShowAddZone.Name = "PanelShowAddZone"
        Me.PanelShowAddZone.Size = New System.Drawing.Size(323, 647)
        Me.PanelShowAddZone.TabIndex = 0
        '
        'PanelAddZone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 645)
        Me.Controls.Add(Me.PanelShowAddZone)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelAddZone"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Zone"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelShowAddZone As Panel
End Class
