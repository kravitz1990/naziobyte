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
        Me.picTrue = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtLoginSuccess = New System.Windows.Forms.Label()
        Me.btnOut = New System.Windows.Forms.Button()
        CType(Me.picTrue,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'btnChkTw
        '
        Me.btnChkTw.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222,Byte))
        Me.btnChkTw.Location = New System.Drawing.Point(190, 77)
        Me.btnChkTw.Name = "btnChkTw"
        Me.btnChkTw.Size = New System.Drawing.Size(69, 27)
        Me.btnChkTw.TabIndex = 0
        Me.btnChkTw.Text = "ตรวจสอบ"
        Me.btnChkTw.UseVisualStyleBackColor = true
        '
        'btnQespin
        '
        Me.btnQespin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222,Byte))
        Me.btnQespin.Location = New System.Drawing.Point(265, 77)
        Me.btnQespin.Name = "btnQespin"
        Me.btnQespin.Size = New System.Drawing.Size(69, 27)
        Me.btnQespin.TabIndex = 1
        Me.btnQespin.Text = "ขอรหัส PIN"
        Me.btnQespin.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222,Byte))
        Me.Label1.Location = New System.Drawing.Point(124, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "รหัส PIN :"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222,Byte))
        Me.TextBox1.Location = New System.Drawing.Point(187, 30)
        Me.TextBox1.MaxLength = 7
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(206, 23)
        Me.TextBox1.TabIndex = 3
        '
        'picTrue
        '
        Me.picTrue.Image = Global.EarthQuake_Realtime_Checker.My.Resources.Resources.agt_action_success
        Me.picTrue.Location = New System.Drawing.Point(189, 26)
        Me.picTrue.Name = "picTrue"
        Me.picTrue.Size = New System.Drawing.Size(25, 28)
        Me.picTrue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTrue.TabIndex = 6
        Me.picTrue.TabStop = false
        Me.picTrue.Visible = false
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EarthQuake_Realtime_Checker.My.Resources.Resources._120px_Twitter_bird_logo_2012_svg
        Me.PictureBox1.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = false
        '
        'txtLoginSuccess
        '
        Me.txtLoginSuccess.AutoSize = true
        Me.txtLoginSuccess.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtLoginSuccess.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLoginSuccess.Location = New System.Drawing.Point(215, 35)
        Me.txtLoginSuccess.Name = "txtLoginSuccess"
        Me.txtLoginSuccess.Size = New System.Drawing.Size(27, 14)
        Me.txtLoginSuccess.TabIndex = 7
        Me.txtLoginSuccess.Text = "<>"
        Me.txtLoginSuccess.Visible = false
        '
        'btnOut
        '
        Me.btnOut.Enabled = false
        Me.btnOut.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222,Byte))
        Me.btnOut.Location = New System.Drawing.Point(340, 77)
        Me.btnOut.Name = "btnOut"
        Me.btnOut.Size = New System.Drawing.Size(53, 27)
        Me.btnOut.TabIndex = 8
        Me.btnOut.Text = "ยกเลิก"
        Me.btnOut.UseVisualStyleBackColor = true
        '
        'TwitManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.ClientSize = New System.Drawing.Size(403, 118)
        Me.Controls.Add(Me.btnOut)
        Me.Controls.Add(Me.txtLoginSuccess)
        Me.Controls.Add(Me.picTrue)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnQespin)
        Me.Controls.Add(Me.btnChkTw)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "TwitManage"
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "แจ้งเตือนเหตุการณ์ผ่านทวิตเตอร์"
        CType(Me.picTrue,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents btnChkTw As System.Windows.Forms.Button
    Friend WithEvents btnQespin As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents picTrue As System.Windows.Forms.PictureBox
    Friend WithEvents txtLoginSuccess As System.Windows.Forms.Label
    Friend WithEvents btnOut As System.Windows.Forms.Button
End Class
