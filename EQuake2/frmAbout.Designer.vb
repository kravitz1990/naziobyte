<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtver = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.Location = New System.Drawing.Point(238, 185)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(55, 29)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "ตกลง"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtver
        '
        Me.txtver.AutoSize = True
        Me.txtver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtver.Location = New System.Drawing.Point(121, 67)
        Me.txtver.Name = "txtver"
        Me.txtver.Size = New System.Drawing.Size(61, 16)
        Me.txtver.TabIndex = 0
        Me.txtver.Text = "รุ่น 2.0.0.4"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.Location = New System.Drawing.Point(76, 132)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(145, 14)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "kiratisonic555@gmail.com"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 14)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ติดต่อ :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 14)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "โฮมเพจ :"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel2.Location = New System.Drawing.Point(76, 158)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(193, 14)
        Me.LinkLabel2.TabIndex = 2
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "http://zunmegasoft.blogspot.com"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "EarthQuake Realtime Checker"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txtver)
        Me.GroupBox1.Location = New System.Drawing.Point(-29, -14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(401, 105)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EarthQuake_Realtime_Checker.My.Resources.Resources.globe_vista1
        Me.PictureBox1.Location = New System.Drawing.Point(41, 28)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(177, 185)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 29)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "เครดิต"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LinkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel3.Location = New System.Drawing.Point(76, 107)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(220, 14)
        Me.LinkLabel3.TabIndex = 11
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "https://www.facebook.com/ajer.arin.1"
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 223)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เกี่ยวกับโปรแกรม"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtver As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
End Class
