<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacebookManage
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EarthQuake_Realtime_Checker.My.Resources.Resources.facebook_logo
        Me.PictureBox1.Location = New System.Drawing.Point(20, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 135)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(284, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 14)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "หากยังไม่มีบัญชี Application"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(242, 99)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(44, 14)
        Me.LinkLabel1.TabIndex = 16
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "คลิกที่นี่"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(165, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 14)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "App Secret :"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(248, 59)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(223, 22)
        Me.TextBox2.TabIndex = 14
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(382, 143)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 26)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "ยกเลิกใช้"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(287, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 26)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "เชื่อมต่อ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(189, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 14)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "App ID :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(248, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(223, 22)
        Me.TextBox1.TabIndex = 10
        '
        'FacebookManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 185)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FacebookManage"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facebook Manager"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
