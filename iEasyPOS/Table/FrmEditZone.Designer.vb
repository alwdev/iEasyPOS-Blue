<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditZone
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditZone))
        Me.Panel67 = New System.Windows.Forms.Panel()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Panel69 = New System.Windows.Forms.Panel()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.ColorBoxEditZone = New Telerik.WinControls.UI.RadColorBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.BtnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtZoneName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel67.SuspendLayout
        CType(Me.ColorBoxEditZone,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Panel67
        '
        Me.Panel67.BackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Panel67.Controls.Add(Me.Button14)
        Me.Panel67.Controls.Add(Me.Panel69)
        Me.Panel67.Controls.Add(Me.Label36)
        Me.Panel67.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel67.Location = New System.Drawing.Point(0, 0)
        Me.Panel67.Name = "Panel67"
        Me.Panel67.Size = New System.Drawing.Size(387, 43)
        Me.Panel67.TabIndex = 312
        '
        'Button14
        '
        Me.Button14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Button14.BackColor = System.Drawing.Color.Transparent
        Me.Button14.BackgroundImage = CType(resources.GetObject("Button14.BackgroundImage"),System.Drawing.Image)
        Me.Button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Button14.FlatAppearance.BorderSize = 0
        Me.Button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.ForeColor = System.Drawing.Color.White
        Me.Button14.Location = New System.Drawing.Point(349, 5)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(32, 32)
        Me.Button14.TabIndex = 19
        Me.Button14.UseVisualStyleBackColor = false
        '
        'Panel69
        '
        Me.Panel69.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel69.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel69.Location = New System.Drawing.Point(0, 42)
        Me.Panel69.Name = "Panel69"
        Me.Panel69.Size = New System.Drawing.Size(387, 1)
        Me.Panel69.TabIndex = 19
        '
        'Label36
        '
        Me.Label36.AutoSize = true
        Me.Label36.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label36.Location = New System.Drawing.Point(20, 7)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(80, 29)
        Me.Label36.TabIndex = 12
        Me.Label36.Text = "แก้ไขโซน"
        '
        'ColorBoxEditZone
        '
        Me.ColorBoxEditZone.BackColor = System.Drawing.Color.Black
        Me.ColorBoxEditZone.EnableTheming = false
        Me.ColorBoxEditZone.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold)
        Me.ColorBoxEditZone.Location = New System.Drawing.Point(32, 161)
        Me.ColorBoxEditZone.Name = "ColorBoxEditZone"
        Me.ColorBoxEditZone.Padding = New System.Windows.Forms.Padding(1)
        '
        '
        '
        Me.ColorBoxEditZone.RootElement.AccessibleDescription = Nothing
        Me.ColorBoxEditZone.RootElement.AccessibleName = Nothing
        Me.ColorBoxEditZone.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.ColorBoxEditZone.RootElement.AngleTransform = 0!
        Me.ColorBoxEditZone.RootElement.FlipText = false
        Me.ColorBoxEditZone.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.ColorBoxEditZone.RootElement.Text = Nothing
        Me.ColorBoxEditZone.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.ColorBoxEditZone.Size = New System.Drawing.Size(323, 32)
        Me.ColorBoxEditZone.TabIndex = 325
        CType(Me.ColorBoxEditZone.GetChildAt(0),Telerik.WinControls.UI.RadColorBoxElement).Padding = New System.Windows.Forms.Padding(1)
        CType(Me.ColorBoxEditZone.GetChildAt(0).GetChildAt(1),Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.SystemColors.ControlDark
        CType(Me.ColorBoxEditZone.GetChildAt(0).GetChildAt(2).GetChildAt(0),Telerik.WinControls.UI.ColorEditorColorBox).BorderColor = System.Drawing.SystemColors.ActiveBorder
        CType(Me.ColorBoxEditZone.GetChildAt(0).GetChildAt(2).GetChildAt(0),Telerik.WinControls.UI.ColorEditorColorBox).BorderLeftColor = System.Drawing.SystemColors.AppWorkspace
        CType(Me.ColorBoxEditZone.GetChildAt(0).GetChildAt(2).GetChildAt(0),Telerik.WinControls.UI.ColorEditorColorBox).BorderRightColor = System.Drawing.SystemColors.AppWorkspace
        CType(Me.ColorBoxEditZone.GetChildAt(0).GetChildAt(2).GetChildAt(0),Telerik.WinControls.UI.ColorEditorColorBox).BorderBottomColor = System.Drawing.SystemColors.AppWorkspace
        CType(Me.ColorBoxEditZone.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0),Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.SystemColors.ControlDark
        CType(Me.ColorBoxEditZone.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0),Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.SystemColors.ControlDark
        CType(Me.ColorBoxEditZone.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0),Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.SystemColors.ControlDark
        CType(Me.ColorBoxEditZone.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0),Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.ControlDark
        '
        'Label23
        '
        Me.Label23.AutoSize = true
        Me.Label23.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold)
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Label23.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label23.Location = New System.Drawing.Point(23, 131)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(40, 24)
        Me.Label23.TabIndex = 324
        Me.Label23.Text = "สีปุ่ม"
        '
        'BtnCancel
        '
        Me.BtnCancel.Appearance.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BtnCancel.Appearance.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Appearance.Options.UseFont = true
        Me.BtnCancel.Appearance.Options.UseForeColor = true
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.ImageOptions.Image = CType(resources.GetObject("BtnCancel.ImageOptions.Image"),System.Drawing.Image)
        Me.BtnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.BtnCancel.Location = New System.Drawing.Point(143, 214)
        Me.BtnCancel.LookAndFeel.SkinMaskColor = System.Drawing.Color.Red
        Me.BtnCancel.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.BtnCancel.LookAndFeel.UseDefaultLookAndFeel = false
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(103, 33)
        Me.BtnCancel.TabIndex = 323
        Me.BtnCancel.Text = "ยกเลิก"
        '
        'BtnSave
        '
        Me.BtnSave.Appearance.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BtnSave.Appearance.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Appearance.Options.UseFont = true
        Me.BtnSave.Appearance.Options.UseForeColor = true
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.ImageOptions.Image = Global.iEasyPOS.My.Resources.Resources.Icon_Ok2White
        Me.BtnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.BtnSave.Location = New System.Drawing.Point(252, 214)
        Me.BtnSave.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(77,Byte),Integer), CType(CType(212,Byte),Integer), CType(CType(59,Byte),Integer))
        Me.BtnSave.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White
        Me.BtnSave.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.BtnSave.LookAndFeel.UseDefaultLookAndFeel = false
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(103, 33)
        Me.BtnSave.TabIndex = 322
        Me.BtnSave.Text = "ตกลง"
        '
        'TxtZoneName
        '
        Me.TxtZoneName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtZoneName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtZoneName.Font = New System.Drawing.Font("Kanit", 12!)
        Me.TxtZoneName.ForeColor = System.Drawing.Color.Black
        Me.TxtZoneName.Location = New System.Drawing.Point(37, 88)
        Me.TxtZoneName.Name = "TxtZoneName"
        Me.TxtZoneName.Size = New System.Drawing.Size(318, 24)
        Me.TxtZoneName.TabIndex = 319
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(23, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 24)
        Me.Label3.TabIndex = 320
        Me.Label3.Text = "ชื่อโซน"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel4.Location = New System.Drawing.Point(32, 117)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(323, 1)
        Me.Panel4.TabIndex = 321
        '
        'FrmEditZone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(387, 270)
        Me.ControlBox = false
        Me.Controls.Add(Me.ColorBoxEditZone)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TxtZoneName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel67)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEditZone"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel67.ResumeLayout(false)
        Me.Panel67.PerformLayout
        CType(Me.ColorBoxEditZone,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Panel67 As Panel
    Friend WithEvents Button14 As Button
    Friend WithEvents Panel69 As Panel
    Friend WithEvents Label36 As Label
    Friend WithEvents ColorBoxEditZone As Telerik.WinControls.UI.RadColorBox
    Friend WithEvents Label23 As Label
    Friend WithEvents BtnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtZoneName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) 

    End Sub
End Class
