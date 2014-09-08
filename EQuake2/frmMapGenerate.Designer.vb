<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMapGenerate
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
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VvvToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(782, 611)
        Me.WebBrowser1.TabIndex = 1
        Me.WebBrowser1.Url = New System.Uri("C:\Users\Quantim\Desktop\naber.html", System.UriKind.Absolute)
        '
        'SaveFileDialog1
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DddToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(782, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'DddToolStripMenuItem
        '
        Me.DddToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VvvToolStripMenuItem})
        Me.DddToolStripMenuItem.Name = "DddToolStripMenuItem"
        Me.DddToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.DddToolStripMenuItem.Text = "ddd"
        '
        'VvvToolStripMenuItem
        '
        Me.VvvToolStripMenuItem.Name = "VvvToolStripMenuItem"
        Me.VvvToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.VvvToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VvvToolStripMenuItem.Text = "vvv"
        '
        'frmMapGenerate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 611)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMapGenerate"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ดูแผนที่ (คำแนะนำ : คุณสามารกด Ctrl + S เพื่อบันทึกรูปแผนที่)"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VvvToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
