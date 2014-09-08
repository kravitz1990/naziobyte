<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmailManage
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.listMail = New System.Windows.Forms.ListBox()
        Me.txtDisable = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(8, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(306, 406)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(298, 379)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "เข้าสู่ระบบ"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPass)
        Me.GroupBox1.Controls.Add(Me.txtUser)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(262, 299)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Live (SSL)", "Yahoo! (SSL)", "Gmail (SSL)", "GMX (No SSL)"})
        Me.ComboBox1.Location = New System.Drawing.Point(21, 178)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(226, 22)
        Me.ComboBox1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 14)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "เข้าสู่ระบบโดย :"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(80, 91)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPass.Size = New System.Drawing.Size(167, 22)
        Me.txtPass.TabIndex = 5
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(80, 52)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(167, 22)
        Me.txtUser.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "รหัสผ่าน :"
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(144, 231)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 34)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "ออกจากระบบ"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.EarthQuake_Realtime_Checker.My.Resources.Resources.security1
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(34, 231)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 34)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "ลงชื่อเข้าใช้"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชื่อบัญชี :"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.btnsave)
        Me.TabPage2.Controls.Add(Me.btnRemove)
        Me.TabPage2.Controls.Add(Me.btnAdd)
        Me.TabPage2.Controls.Add(Me.listMail)
        Me.TabPage2.Controls.Add(Me.txtDisable)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(298, 379)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "จัดการรายชื่อ"
        '
        'btnsave
        '
        Me.btnsave.Enabled = False
        Me.btnsave.Image = Global.EarthQuake_Realtime_Checker.My.Resources.Resources.save
        Me.btnsave.Location = New System.Drawing.Point(9, 328)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(27, 27)
        Me.btnsave.TabIndex = 4
        Me.btnsave.UseVisualStyleBackColor = True
        Me.btnsave.Visible = False
        '
        'btnRemove
        '
        Me.btnRemove.Image = Global.EarthQuake_Realtime_Checker.My.Resources.Resources.list_remove
        Me.btnRemove.Location = New System.Drawing.Point(226, 328)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(27, 27)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.UseVisualStyleBackColor = True
        Me.btnRemove.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.EarthQuake_Realtime_Checker.My.Resources.Resources.list_add
        Me.btnAdd.Location = New System.Drawing.Point(259, 328)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(27, 27)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.UseVisualStyleBackColor = True
        Me.btnAdd.Visible = False
        '
        'listMail
        '
        Me.listMail.FormattingEnabled = True
        Me.listMail.ItemHeight = 14
        Me.listMail.Location = New System.Drawing.Point(9, 10)
        Me.listMail.Name = "listMail"
        Me.listMail.Size = New System.Drawing.Size(276, 312)
        Me.listMail.TabIndex = 1
        Me.listMail.Visible = False
        '
        'txtDisable
        '
        Me.txtDisable.AutoSize = True
        Me.txtDisable.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDisable.ForeColor = System.Drawing.Color.Gray
        Me.txtDisable.Location = New System.Drawing.Point(84, 180)
        Me.txtDisable.Name = "txtDisable"
        Me.txtDisable.Size = New System.Drawing.Size(112, 14)
        Me.txtDisable.TabIndex = 0
        Me.txtDisable.Text = "โปรดลงชื่อเข้าใช้ก่อน"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(238, 424)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 24)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "ปิด"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(14, 341)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(236, 14)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "* หมายเหตุ: จำกัดแค่ 6.0 ริกเตอร์ขึ้นไปเท่านั้น"
        '
        'EmailManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(321, 454)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "EmailManage"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "แจ้งเตือนเหตุการณ์ไปยังอีเมลผู้อื่น"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDisable As System.Windows.Forms.Label
    Friend WithEvents listMail As System.Windows.Forms.ListBox
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
