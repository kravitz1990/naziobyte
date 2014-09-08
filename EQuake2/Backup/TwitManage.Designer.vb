<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TwitManage
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
        Me.btnChkTw = New System.Windows.Forms.Button()
        Me.btnQespin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnTwLogout = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnChkTw
        '
        Me.btnChkTw.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnChkTw.Location = New System.Drawing.Point(139, 88)
        Me.btnChkTw.Name = "btnChkTw"
        Me.btnChkTw.Size = New System.Drawing.Size(72, 27)
        Me.btnChkTw.TabIndex = 0
        Me.btnChkTw.Text = "ตรวจสอบ"
        Me.btnChkTw.UseVisualStyleBackColor = True
        '
        'btnQespin
        '
        Me.btnQespin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnQespin.Location = New System.Drawing.Point(217, 88)
        Me.btnQespin.Name = "btnQespin"
        Me.btnQespin.Size = New System.Drawing.Size(72, 27)
        Me.btnQespin.TabIndex = 1
        Me.btnQespin.Text = "ขอรหัส PIN"
        Me.btnQespin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(144, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "รหัส PIN :"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(207, 37)
        Me.TextBox1.MaxLength = 7
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(160, 23)
        Me.TextBox1.TabIndex = 3
        '
        'btnTwLogout
        '
        Me.btnTwLogout.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnTwLogout.Location = New System.Drawing.Point(295, 88)
        Me.btnTwLogout.Name = "btnTwLogout"
        Me.btnTwLogout.Size = New System.Drawing.Size(72, 27)
        Me.btnTwLogout.TabIndex = 4
        Me.btnTwLogout.Text = "ยกเลิกใช้"
        Me.btnTwLogout.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources._120px_Twitter_bird_logo_2012_svg
        Me.PictureBox1.Location = New System.Drawing.Point(12, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'TwitManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(405, 135)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnTwLogout)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnQespin)
        Me.Controls.Add(Me.btnChkTw)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TwitManage"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เข้าสู่ระบบ"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnChkTw As System.Windows.Forms.Button
    Friend WithEvents btnQespin As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnTwLogout As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
