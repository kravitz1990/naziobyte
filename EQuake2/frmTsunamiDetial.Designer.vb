<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTsunamiDetial
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
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.txtCLink = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.txtPreload = New System.Windows.Forms.Label()
        Me.picload = New System.Windows.Forms.PictureBox()
        Me.txtSent = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.picload, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(928, 727)
        Me.WebBrowser1.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.StatusStrip1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtSent, Me.txtCLink})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 730)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(928, 28)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'txtCLink
        '
        Me.txtCLink.AccessibleRole = System.Windows.Forms.AccessibleRole.Link
        Me.txtCLink.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCLink.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCLink.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
        Me.txtCLink.Name = "txtCLink"
        Me.txtCLink.Size = New System.Drawing.Size(0, 23)
        Me.txtCLink.VisitedLinkColor = System.Drawing.Color.Red
        '
        'BackgroundWorker1
        '
        '
        'txtPreload
        '
        Me.txtPreload.AutoSize = True
        Me.txtPreload.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPreload.ForeColor = System.Drawing.Color.Gray
        Me.txtPreload.Location = New System.Drawing.Point(378, 337)
        Me.txtPreload.Name = "txtPreload"
        Me.txtPreload.Size = New System.Drawing.Size(118, 29)
        Me.txtPreload.TabIndex = 2
        Me.txtPreload.Text = "Loading..."
        '
        'picload
        '
        Me.picload.Image = Global.EarthQuake_Realtime_Checker.My.Resources.Resources._350
        Me.picload.Location = New System.Drawing.Point(328, 327)
        Me.picload.Name = "picload"
        Me.picload.Size = New System.Drawing.Size(50, 50)
        Me.picload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picload.TabIndex = 3
        Me.picload.TabStop = False
        '
        'txtSent
        '
        Me.txtSent.AccessibleRole = System.Windows.Forms.AccessibleRole.Link
        Me.txtSent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSent.Image = Global.EarthQuake_Realtime_Checker.My.Resources.Resources.info
        Me.txtSent.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.txtSent.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSent.Name = "txtSent"
        Me.txtSent.Size = New System.Drawing.Size(38, 16)
        Me.txtSent.Text = "<>"
        Me.txtSent.VisitedLinkColor = System.Drawing.Color.Red
        '
        'frmTsunamiDetial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(928, 758)
        Me.Controls.Add(Me.picload)
        Me.Controls.Add(Me.txtPreload)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTsunamiDetial"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายงานการเฝ้าระวังสึนามิ"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.picload, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents txtSent As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtCLink As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtPreload As System.Windows.Forms.Label
    Friend WithEvents picload As System.Windows.Forms.PictureBox
End Class
