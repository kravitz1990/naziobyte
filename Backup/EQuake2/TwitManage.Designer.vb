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
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(133, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "ตรวจสอบ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.Location = New System.Drawing.Point(211, 83)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 27)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "ขอรหัส PIN"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(138, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "รหัส PIN :"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(201, 32)
        Me.TextBox1.MaxLength = 7
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(160, 23)
        Me.TextBox1.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button3.Location = New System.Drawing.Point(289, 83)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 27)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "ยกเลิกใช้"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TwitManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(405, 135)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TwitManage"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เข้าสู่ระบบ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
