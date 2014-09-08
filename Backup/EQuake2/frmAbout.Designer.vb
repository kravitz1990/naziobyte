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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EarthQuake Realtime Checker"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(211, 231)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 22)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "ตกลง"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "รุ่น 2.0.0.0"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(82, 81)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(130, 13)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "kiratisonic555@gmail.com"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Support :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Homepage :"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(82, 103)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(164, 13)
        Me.LinkLabel2.TabIndex = 2
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "http://zunmegasoft.blogspot.com"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Facebook API by :", "Twitter API by : TRocket "})
        Me.ListBox1.Location = New System.Drawing.Point(12, 156)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(299, 69)
        Me.ListBox1.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Credit :"
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 269)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เกี่ยวกับโปรแกรม"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
