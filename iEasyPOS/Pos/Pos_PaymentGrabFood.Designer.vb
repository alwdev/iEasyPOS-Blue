<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pos_PaymentGrabFood
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pos_PaymentGrabFood))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtGrabNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnGrabCancle = New System.Windows.Forms.Button()
        Me.BtnGrabPay = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Controls.Add(Me.txtGrabNumber)
        Me.PanelControl1.Location = New System.Drawing.Point(142, 220)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(246, 34)
        Me.PanelControl1.TabIndex = 62
        '
        'txtGrabNumber
        '
        Me.txtGrabNumber.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGrabNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGrabNumber.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtGrabNumber.Location = New System.Drawing.Point(4, 5)
        Me.txtGrabNumber.Name = "txtGrabNumber"
        Me.txtGrabNumber.Size = New System.Drawing.Size(238, 24)
        Me.txtGrabNumber.TabIndex = 48
        Me.txtGrabNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(101, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 24)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "GF-"
        '
        'BtnGrabCancle
        '
        Me.BtnGrabCancle.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BtnGrabCancle.FlatAppearance.BorderSize = 0
        Me.BtnGrabCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrabCancle.Font = New System.Drawing.Font("Kanit", 13.0!, System.Drawing.FontStyle.Bold)
        Me.BtnGrabCancle.ForeColor = System.Drawing.Color.White
        Me.BtnGrabCancle.Location = New System.Drawing.Point(128, 306)
        Me.BtnGrabCancle.Name = "BtnGrabCancle"
        Me.BtnGrabCancle.Size = New System.Drawing.Size(119, 53)
        Me.BtnGrabCancle.TabIndex = 61
        Me.BtnGrabCancle.Text = "ยกเลิก"
        Me.BtnGrabCancle.UseVisualStyleBackColor = False
        '
        'BtnGrabPay
        '
        Me.BtnGrabPay.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnGrabPay.FlatAppearance.BorderSize = 0
        Me.BtnGrabPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrabPay.Font = New System.Drawing.Font("Kanit", 13.0!, System.Drawing.FontStyle.Bold)
        Me.BtnGrabPay.ForeColor = System.Drawing.Color.White
        Me.BtnGrabPay.Location = New System.Drawing.Point(253, 306)
        Me.BtnGrabPay.Name = "BtnGrabPay"
        Me.BtnGrabPay.Size = New System.Drawing.Size(135, 53)
        Me.BtnGrabPay.TabIndex = 60
        Me.BtnGrabPay.Text = "ยืนยัน"
        Me.BtnGrabPay.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Kanit", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(184, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 31)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Order number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Kanit", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(133, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 43)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "ชำระเงิน Grab Food"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(27, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 63
        Me.PictureBox1.TabStop = False
        '
        'Pos_PaymentGrabFood
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 450)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnGrabCancle)
        Me.Controls.Add(Me.BtnGrabPay)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Pos_PaymentGrabFood"
        Me.Text = "Pos_PaymentGrabFood"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtGrabNumber As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnGrabCancle As Button
    Friend WithEvents BtnGrabPay As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
End Class
