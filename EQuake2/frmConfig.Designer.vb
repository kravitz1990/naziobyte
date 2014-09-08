<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfig
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfig))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.chkTsunami = New System.Windows.Forms.CheckBox()
        Me.chkIsSoundLoop = New System.Windows.Forms.CheckBox()
        Me.chkShowPopup = New System.Windows.Forms.CheckBox()
        Me.chkStartUp = New System.Windows.Forms.CheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.จากแฟมToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.จากเวบเซรฟเวอรToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnplay = New System.Windows.Forms.Button()
        Me.chkSound = New System.Windows.Forms.CheckBox()
        Me.btnAddSound = New System.Windows.Forms.Button()
        Me.ListSound = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTrackVal = New System.Windows.Forms.TextBox()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtgetMail = New System.Windows.Forms.Label()
        Me.txtgetDateMail = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtRitcher = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtCountSenderMail = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTwuser = New System.Windows.Forms.Label()
        Me.txtDateTw = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.txtTwEQ = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtTwCountFollow = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtgetIPv4 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtNetEQ = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCountHost = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(468, 566)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.chkTsunami)
        Me.TabPage1.Controls.Add(Me.chkIsSoundLoop)
        Me.TabPage1.Controls.Add(Me.chkShowPopup)
        Me.TabPage1.Controls.Add(Me.chkStartUp)
        Me.TabPage1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabPage1.ImageIndex = 5
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(460, 537)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ทั่วไป"
        '
        'chkTsunami
        '
        Me.chkTsunami.AutoSize = True
        Me.chkTsunami.Enabled = False
        Me.chkTsunami.Location = New System.Drawing.Point(23, 155)
        Me.chkTsunami.Name = "chkTsunami"
        Me.chkTsunami.Size = New System.Drawing.Size(173, 20)
        Me.chkTsunami.TabIndex = 0
        Me.chkTsunami.Text = "เปิดใช้งานการเฝ้าระวังสึนามิ"
        Me.chkTsunami.UseVisualStyleBackColor = True
        '
        'chkIsSoundLoop
        '
        Me.chkIsSoundLoop.AutoSize = True
        Me.chkIsSoundLoop.Location = New System.Drawing.Point(23, 116)
        Me.chkIsSoundLoop.Name = "chkIsSoundLoop"
        Me.chkIsSoundLoop.Size = New System.Drawing.Size(133, 20)
        Me.chkIsSoundLoop.TabIndex = 0
        Me.chkIsSoundLoop.Text = "ลูปเสียงสัญาณเตือน"
        Me.chkIsSoundLoop.UseVisualStyleBackColor = True
        '
        'chkShowPopup
        '
        Me.chkShowPopup.AutoSize = True
        Me.chkShowPopup.Location = New System.Drawing.Point(23, 78)
        Me.chkShowPopup.Name = "chkShowPopup"
        Me.chkShowPopup.Size = New System.Drawing.Size(216, 20)
        Me.chkShowPopup.TabIndex = 0
        Me.chkShowPopup.Text = "แสดง Popup ทุกครั้งเมื่อมีเหตุการณ์"
        Me.chkShowPopup.UseVisualStyleBackColor = True
        '
        'chkStartUp
        '
        Me.chkStartUp.AutoSize = True
        Me.chkStartUp.Location = New System.Drawing.Point(23, 37)
        Me.chkStartUp.Name = "chkStartUp"
        Me.chkStartUp.Size = New System.Drawing.Size(206, 20)
        Me.chkStartUp.TabIndex = 0
        Me.chkStartUp.Text = "เริ่มโปรแกรมทุกครั้งเมื่อเข้าสู่ระบบ"
        Me.chkStartUp.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabPage2.ImageIndex = 0
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(460, 537)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "การแจ้งเตือน"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.btnStop)
        Me.GroupBox2.Controls.Add(Me.btnplay)
        Me.GroupBox2.Controls.Add(Me.chkSound)
        Me.GroupBox2.Controls.Add(Me.btnAddSound)
        Me.GroupBox2.Controls.Add(Me.ListSound)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 156)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(438, 354)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "เสียงสัญาณเตือน"
        '
        'Button8
        '
        Me.Button8.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Button8.Image = Global.EarthQuake_Realtime_Checker.My.Resources.Resources.deletered
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(335, 293)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(87, 28)
        Me.Button8.TabIndex = 5
        Me.Button8.Text = "เอาออก"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.จากแฟมToolStripMenuItem, Me.จากเวบเซรฟเวอรToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(163, 48)
        '
        'จากแฟมToolStripMenuItem
        '
        Me.จากแฟมToolStripMenuItem.Name = "จากแฟมToolStripMenuItem"
        Me.จากแฟมToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.จากแฟมToolStripMenuItem.Text = "จากแฟ้ม"
        '
        'จากเวบเซรฟเวอรToolStripMenuItem
        '
        Me.จากเวบเซรฟเวอรToolStripMenuItem.Name = "จากเวบเซรฟเวอรToolStripMenuItem"
        Me.จากเวบเซรฟเวอรToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.จากเวบเซรฟเวอรToolStripMenuItem.Text = "จากเว็บเซิร์ฟเวอร์ "
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Image = Global.EarthQuake_Realtime_Checker.My.Resources.Resources.media_playback_stop3
        Me.btnStop.Location = New System.Drawing.Point(47, 293)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(31, 28)
        Me.btnStop.TabIndex = 6
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnplay
        '
        Me.btnplay.Image = Global.EarthQuake_Realtime_Checker.My.Resources.Resources.media_playback_start2
        Me.btnplay.Location = New System.Drawing.Point(14, 293)
        Me.btnplay.Name = "btnplay"
        Me.btnplay.Size = New System.Drawing.Size(31, 28)
        Me.btnplay.TabIndex = 5
        Me.btnplay.UseVisualStyleBackColor = True
        '
        'chkSound
        '
        Me.chkSound.AutoSize = True
        Me.chkSound.Location = New System.Drawing.Point(14, 35)
        Me.chkSound.Name = "chkSound"
        Me.chkSound.Size = New System.Drawing.Size(81, 20)
        Me.chkSound.TabIndex = 4
        Me.chkSound.Text = "เปิดใช้งาน"
        Me.chkSound.UseVisualStyleBackColor = True
        '
        'btnAddSound
        '
        Me.btnAddSound.ContextMenuStrip = Me.ContextMenuStrip1
        Me.btnAddSound.Image = Global.EarthQuake_Realtime_Checker.My.Resources.Resources.add
        Me.btnAddSound.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddSound.Location = New System.Drawing.Point(242, 293)
        Me.btnAddSound.Name = "btnAddSound"
        Me.btnAddSound.Size = New System.Drawing.Size(87, 28)
        Me.btnAddSound.TabIndex = 3
        Me.btnAddSound.Text = "เพิ่มเสียง"
        Me.btnAddSound.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddSound.UseVisualStyleBackColor = True
        '
        'ListSound
        '
        Me.ListSound.FormattingEnabled = True
        Me.ListSound.ItemHeight = 16
        Me.ListSound.Location = New System.Drawing.Point(14, 75)
        Me.ListSound.Name = "ListSound"
        Me.ListSound.Size = New System.Drawing.Size(408, 212)
        Me.ListSound.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtTrackVal)
        Me.GroupBox1.Controls.Add(Me.TrackBar1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(438, 111)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ระดับการเตือนภัย"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(348, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "แมกนิจูดขึ้นไป"
        '
        'txtTrackVal
        '
        Me.txtTrackVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTrackVal.Location = New System.Drawing.Point(286, 46)
        Me.txtTrackVal.MaxLength = 3
        Me.txtTrackVal.Name = "txtTrackVal"
        Me.txtTrackVal.ReadOnly = True
        Me.txtTrackVal.Size = New System.Drawing.Size(58, 24)
        Me.txtTrackVal.TabIndex = 1
        Me.txtTrackVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TrackBar1
        '
        Me.TrackBar1.AutoSize = False
        Me.TrackBar1.BackColor = System.Drawing.Color.White
        Me.TrackBar1.Location = New System.Drawing.Point(6, 43)
        Me.TrackBar1.Maximum = 9
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(275, 37)
        Me.TrackBar1.TabIndex = 0
        Me.TrackBar1.Value = 1
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "sound.png")
        Me.ImageList1.Images.SetKeyName(1, "audio_volume_low.png")
        Me.ImageList1.Images.SetKeyName(2, "network_local.png")
        Me.ImageList1.Images.SetKeyName(3, "internet_explorer.png")
        Me.ImageList1.Images.SetKeyName(4, "general_alt.png")
        Me.ImageList1.Images.SetKeyName(5, "general.png")
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button6)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.PictureBox2)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Location = New System.Drawing.Point(34, 650)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(424, 108)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Facebook"
        Me.GroupBox4.Visible = False
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button6.Image = Global.EarthQuake_Realtime_Checker.My.Resources.Resources.settings
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(367, 35)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(42, 53)
        Me.Button6.TabIndex = 17
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(160, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "None"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(160, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "None"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(122, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "เมื่อ :"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.EarthQuake_Realtime_Checker.My.Resources.Resources.facebook1
        Me.PictureBox2.Location = New System.Drawing.Point(17, 38)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(52, 50)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(75, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "เข้าสู่ระบบโดย :"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(385, 588)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 28)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "ยืนยัน"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.Location = New System.Drawing.Point(288, 588)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 28)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "ยกเลิก"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button3.Location = New System.Drawing.Point(191, 588)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 28)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "ตกลง"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Wav File (*.wav)|*.wav|All File (*.*)|*.*"""
        Me.OpenFileDialog1.Title = "นำเข้า"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(134, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 5
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button4.Image = Global.EarthQuake_Realtime_Checker.My.Resources.Resources.e_mail3
        Me.Button4.Location = New System.Drawing.Point(16, 33)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(78, 83)
        Me.Button4.TabIndex = 6
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(181, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 7
        '
        'txtgetMail
        '
        Me.txtgetMail.AutoSize = True
        Me.txtgetMail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtgetMail.ForeColor = System.Drawing.Color.Black
        Me.txtgetMail.Location = New System.Drawing.Point(219, 24)
        Me.txtgetMail.Name = "txtgetMail"
        Me.txtgetMail.Size = New System.Drawing.Size(32, 13)
        Me.txtgetMail.TabIndex = 8
        '
        'txtgetDateMail
        '
        Me.txtgetDateMail.AutoSize = True
        Me.txtgetDateMail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtgetDateMail.ForeColor = System.Drawing.Color.Black
        Me.txtgetDateMail.Location = New System.Drawing.Point(219, 49)
        Me.txtgetDateMail.Name = "txtgetDateMail"
        Me.txtgetDateMail.Size = New System.Drawing.Size(32, 13)
        Me.txtgetDateMail.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(115, 103)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 13)
        Me.Label12.TabIndex = 10
        '
        'txtRitcher
        '
        Me.txtRitcher.AutoSize = True
        Me.txtRitcher.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRitcher.ForeColor = System.Drawing.Color.Black
        Me.txtRitcher.Location = New System.Drawing.Point(219, 103)
        Me.txtRitcher.Name = "txtRitcher"
        Me.txtRitcher.Size = New System.Drawing.Size(32, 13)
        Me.txtRitcher.TabIndex = 11
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.Location = New System.Drawing.Point(150, 78)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(63, 13)
        Me.Label21.TabIndex = 12
        '
        'txtCountSenderMail
        '
        Me.txtCountSenderMail.AutoSize = True
        Me.txtCountSenderMail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCountSenderMail.ForeColor = System.Drawing.Color.Black
        Me.txtCountSenderMail.Location = New System.Drawing.Point(219, 78)
        Me.txtCountSenderMail.Name = "txtCountSenderMail"
        Me.txtCountSenderMail.Size = New System.Drawing.Size(32, 13)
        Me.txtCountSenderMail.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(134, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(181, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 13
        '
        'txtTwuser
        '
        Me.txtTwuser.AutoSize = True
        Me.txtTwuser.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTwuser.Location = New System.Drawing.Point(219, 27)
        Me.txtTwuser.Name = "txtTwuser"
        Me.txtTwuser.Size = New System.Drawing.Size(32, 13)
        Me.txtTwuser.TabIndex = 15
        '
        'txtDateTw
        '
        Me.txtDateTw.AutoSize = True
        Me.txtDateTw.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDateTw.Location = New System.Drawing.Point(219, 53)
        Me.txtDateTw.Name = "txtDateTw"
        Me.txtDateTw.Size = New System.Drawing.Size(32, 13)
        Me.txtDateTw.TabIndex = 16
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button7.Image = Global.EarthQuake_Realtime_Checker.My.Resources.Resources.twitter4
        Me.Button7.Location = New System.Drawing.Point(16, 36)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(78, 83)
        Me.Button7.TabIndex = 17
        Me.Button7.UseVisualStyleBackColor = True
        '
        'txtTwEQ
        '
        Me.txtTwEQ.AutoSize = True
        Me.txtTwEQ.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTwEQ.Location = New System.Drawing.Point(220, 106)
        Me.txtTwEQ.Name = "txtTwEQ"
        Me.txtTwEQ.Size = New System.Drawing.Size(32, 13)
        Me.txtTwEQ.TabIndex = 21
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(115, 106)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(98, 13)
        Me.Label15.TabIndex = 10
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.Location = New System.Drawing.Point(159, 81)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 13)
        Me.Label17.TabIndex = 20
        '
        'txtTwCountFollow
        '
        Me.txtTwCountFollow.AutoSize = True
        Me.txtTwCountFollow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTwCountFollow.Location = New System.Drawing.Point(219, 81)
        Me.txtTwCountFollow.Name = "txtTwCountFollow"
        Me.txtTwCountFollow.Size = New System.Drawing.Size(32, 13)
        Me.txtTwCountFollow.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(131, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 8
        '
        'txtgetIPv4
        '
        Me.txtgetIPv4.AutoSize = True
        Me.txtgetIPv4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtgetIPv4.Location = New System.Drawing.Point(220, 46)
        Me.txtgetIPv4.Name = "txtgetIPv4"
        Me.txtgetIPv4.Size = New System.Drawing.Size(32, 13)
        Me.txtgetIPv4.TabIndex = 11
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button5.Image = Global.EarthQuake_Realtime_Checker.My.Resources.Resources.my_network_place
        Me.Button5.Location = New System.Drawing.Point(16, 37)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(78, 83)
        Me.Button5.TabIndex = 13
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtNetEQ
        '
        Me.txtNetEQ.AutoSize = True
        Me.txtNetEQ.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtNetEQ.Location = New System.Drawing.Point(220, 97)
        Me.txtNetEQ.Name = "txtNetEQ"
        Me.txtNetEQ.Size = New System.Drawing.Size(32, 13)
        Me.txtNetEQ.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(115, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(150, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 23
        '
        'txtCountHost
        '
        Me.txtCountHost.AutoSize = True
        Me.txtCountHost.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCountHost.Location = New System.Drawing.Point(219, 72)
        Me.txtCountHost.Name = "txtCountHost"
        Me.txtCountHost.Size = New System.Drawing.Size(32, 13)
        Me.txtCountHost.TabIndex = 24
        '
        'frmConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 628)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfig"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ตั้งค่า"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents chkSound As System.Windows.Forms.CheckBox
    Friend WithEvents btnAddSound As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTrackVal As System.Windows.Forms.TextBox
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnplay As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents จากแฟมToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents จากเวบเซรฟเวอรToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkStartUp As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ListSound As System.Windows.Forms.ListBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents chkTsunami As System.Windows.Forms.CheckBox
    Friend WithEvents chkIsSoundLoop As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowPopup As System.Windows.Forms.CheckBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtgetMail As System.Windows.Forms.Label
    Friend WithEvents txtgetDateMail As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtRitcher As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtCountSenderMail As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTwuser As System.Windows.Forms.Label
    Friend WithEvents txtDateTw As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents txtTwEQ As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtTwCountFollow As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtgetIPv4 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents txtNetEQ As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCountHost As System.Windows.Forms.Label
End Class
