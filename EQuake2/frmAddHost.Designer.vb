<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddHost
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtHost = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(83, 101)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "ทดสอบการเชื่อมต่อ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(300, 23)
        Me.txtPort.MaxLength = 5
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(51, 22)
        Me.txtPort.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"TCP", "UDP"})
        Me.ComboBox1.Location = New System.Drawing.Point(87, 54)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(65, 22)
        Me.ComboBox1.TabIndex = 2
        '
        'txtHost
        '
        Me.txtHost.Location = New System.Drawing.Point(87, 23)
        Me.txtHost.Name = "txtHost"
        Me.txtHost.Size = New System.Drawing.Size(167, 22)
        Me.txtHost.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(251, 101)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(47, 27)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "ตกลง"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(304, 101)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(47, 27)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "ยกเลิก"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 14)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "IP Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(260, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Port:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Protocol:"
        '
        'frmAddHost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 135)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtHost)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddHost"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เพิ่มเครือข่าย"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtHost As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
