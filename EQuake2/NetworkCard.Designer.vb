<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NetworkCard
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.netGrid = New System.Windows.Forms.DataGridView()
        Me.IP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.netGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(130, 48)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(216, 22)
        Me.ComboBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "เลือก Network Card:"
        '
        'netGrid
        '
        Me.netGrid.AllowUserToAddRows = False
        Me.netGrid.AllowUserToDeleteRows = False
        Me.netGrid.AllowUserToResizeColumns = False
        Me.netGrid.AllowUserToResizeRows = False
        Me.netGrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.netGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.netGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IP, Me.Column2, Me.Column1})
        Me.netGrid.Location = New System.Drawing.Point(12, 86)
        Me.netGrid.MultiSelect = False
        Me.netGrid.Name = "netGrid"
        Me.netGrid.ReadOnly = True
        Me.netGrid.RowHeadersVisible = False
        Me.netGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.netGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.netGrid.Size = New System.Drawing.Size(334, 291)
        Me.netGrid.TabIndex = 4
        '
        'IP
        '
        Me.IP.HeaderText = "Host"
        Me.IP.Name = "IP"
        Me.IP.ReadOnly = True
        Me.IP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.IP.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Port"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column2.Width = 80
        '
        'Column1
        '
        Me.Column1.HeaderText = "Protocol"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'btnsave
        '
        Me.btnsave.Enabled = False
        Me.btnsave.Image = Global.EarthQuake_Realtime_Checker.My.Resources.Resources.save
        Me.btnsave.Location = New System.Drawing.Point(12, 383)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(27, 27)
        Me.btnsave.TabIndex = 8
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Image = Global.EarthQuake_Realtime_Checker.My.Resources.Resources.list_remove
        Me.btnRemove.Location = New System.Drawing.Point(286, 383)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(27, 27)
        Me.btnRemove.TabIndex = 7
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.EarthQuake_Realtime_Checker.My.Resources.Resources.list_add
        Me.btnAdd.Location = New System.Drawing.Point(319, 383)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(27, 27)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 12)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(77, 18)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "เปิดใช้งาน"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'NetworkCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 413)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.netGrid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NetworkCard"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Network Manager (Client)"
        CType(Me.netGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents netGrid As System.Windows.Forms.DataGridView
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents IP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
