Imports System.IO
Imports System.Windows.Forms
Imports System.Drawing
Imports System
Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Globalization
Imports System.Xml
Imports System.Net

Public Class Form1

    Dim QNews As New QuakeAlert
    Dim usgsLink As String = "http://earthquake.usgs.gov/earthquakes/catalogs/eqs1day-M1.xml"
    Dim geofonLink As String = "http://geofon.gfz-potsdam.de/eqinfo/list.php?fmt=rss"
    Dim emscLink As String = "http://www.emsc-csem.org/service/rss/rss.php?typ=emsc"
    Dim tmdLink As String = "http://www.seismology.tmd.go.th/feed/rss_inside.xml"
    Dim rq As New RssFeeder
    Dim tms As New TSunamiWarning
    Dim trd1, trd3 As Thread
    Dim ck_m As Boolean
    Dim lastEvent As String

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        'e.Cancel = True
        'Me.Hide()
        'notifyAlert.BalloonTipText = "ซ่อนโปรแกรม"
        'notifyAlert.ShowBalloonTip(5000)

        Dim dlg As DialogResult = MessageBox.Show("คุณแน่ใจหรือว่าต้องการจะปิดโปรแกรม ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If dlg = DialogResult.No Then

            e.Cancel = True

        ElseIf dlg = DialogResult.No Then

            e.Cancel = False

        End If



    End Sub

    Private Sub fixMagging()

        If File.Exists(CurDir() & "\TwitterVB.dll") And File.Exists(CurDir() & "\Facebook.dll") Then
            File.Delete(CurDir() & "\TwitterVB.dll")
            File.Delete(CurDir() & "\Facebook.dll")
        End If

    End Sub

    Private Sub MiniLoadXML_Tsunami()

        'Dim doc(3) As XmlDocument
        'Dim node(3) As XmlNodeList

        'node(0) = doc(0).SelectNodes("/rss/channel/item")
        'node(1) = doc(1).SelectNodes("/rss/channel/item")
        'node(2) = doc(2).SelectNodes("/rss/channel/item")
        'node(3) = doc(3).SelectNodes("/rss/channel/item")

        'doc(0).Load("http://ptwc.weather.gov/feeds/ptwc_rss_caribe.xml")
        'doc(1).Load(DS_indian)
        'doc(2).Load(DS_hawaii)
        'doc(3).Load(DS_pacific)

        pw_caribe.Text = "PTWC - Caribbean Sea"
        pw_indian.Text = "PTWC - Indian Ocean"
        pw_hawaii.Text = "PTWC - Hawai`i"
        pw_pacific.Text = "PTWC - Pacific Ocean"


        'pw_caribe.Text = "PTWC - Caribbean Sea (" & ToLocalTime(node(0).Item(0).ChildNodes(1).InnerText) & ")"
        'pw_indian.Text = "PTWC - Indian Ocean (" & ToLocalTime(node(1).Item(0).ChildNodes(1).InnerText) & ")"
        'pw_hawaii.Text = "PTWC - Hawai`i (" & ToLocalTime(node(2).Item(0).ChildNodes(1).InnerText) & ")"
        'pw_pacific.Text = "PTWC - Pacific Ocean (" & ToLocalTime(node(3).Item(0).ChildNodes(1).InnerText) & ")"

    End Sub




    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '
        fixMagging()

        WCE_MLOG()

        CheckVersion()


        Try
1:
            'If File.Exists(CurDir() & "\bnb.exe") = False Then

            'Me.Hide()
            'frmfetchDownload.ShowDialog()

            'End If

            rq.ReadQuake(usgsLink, geofonLink, emscLink, tmdLink)
            MiniLoadXML_Tsunami()
            FillGridData()
            ConfigurationSystem()
            'TwitManage.readFileSetting()
            oldTime = ari4(0)
            BackgroundWorker1.RunWorkerAsync()

        Catch ex As Exception

            If MsgBox("การเชื่อมต่อล้มเหลว", MsgBoxStyle.Critical + MsgBoxStyle.RetryCancel, "ERROR") = MsgBoxResult.Retry Then

                GoTo 1
            Else

                End

            End If

        End Try

    End Sub


    Private Sub FillGridData()

        grid.Rows.Clear()

        For Each cd As String In ari0

            grid.Rows.Add(cd)

        Next
        For i = 0 To grid.Rows.Count - 1

            grid.Item(1, i).Value = ari1(i)
            grid.Item(2, i).Value = ari2(i)
            grid.Item(4, i).Value = ari3(i)
            grid.Item(5, i).Value = ari4(i)
            grid.Item(6, i).Value = ari5(i)
            grid.Item(7, i).Value = ari6(i)

        Next

        FlagCountry.MakeDataBase()
        MakeFlag()
        grid.Refresh()

    End Sub


    Private Sub WCE_MLOG()


        If File.Exists(CurDir() & "\Parnus.dll") = False Then

            MsgBox("ไม่สามารถเปิดใช้งานได้ โปรดดาวน์โหลดและติดตั้งใหม่อีกครั้ง", MsgBoxStyle.Exclamation, "  ")
            Process.Start("http://software.thaiware.com/download.php?id=10843")
            End

        End If


    End Sub


    Private Sub ConfigurationSystem()

        SyncNTPServer()


        Dim osVersion As String = System.Environment.OSVersion.VersionString
        If Mid(osVersion, 1, 24) = "Microsoft Windows NT 5.1" Then
            grid.BorderStyle = BorderStyle.None
        Else
            grid.BorderStyle = BorderStyle.Fixed3D
        End If


        'Me.Width = Screen.PrimaryScreen.Bounds.Width
        'Me.Height = Screen.PrimaryScreen.Bounds.Height
        'Me.StartPosition = FormStartPosition.CenterScreen
        '1286, 1009

        'Fix Datagrid column Size
        'Dim s1, s2, result As Integer
        'Dim k As Double
        's1 = grid.Columns(0).Width
        's2 = grid.Columns(1).Width
        'result = s1 + s2
        'k = (grid.Width - result) / grid.Columns.Count
        'grid.Columns(0).Width = s1 + k
        'grid.Columns(1).Width = s2 + k


        grid.CellBorderStyle = DataGridViewCellBorderStyle.None
        grid.DefaultCellStyle.Font = New Font("Tahoma", 8)
        grid.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grid.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        iLoadSettingAsync()
        iLoadSettingColorAsync()
        GenerateGridLevelColor()
        setLastUpdate()
        newsQuake.Text = "เหตุการณ์ล่าสุด : " & getLastUpdate() & "    "
        grid.Refresh()
        'MiniLoadXML_Tsunami()

    End Sub

    Private Sub MakeFlag()

        Dim fg As Regex

        For i = 0 To grid.Rows.Count - 1  'ตรวจที่ละ 1

            grid.Rows(i).Cells(3).Value = My.Resources.us

            For j = 0 To _prov.Count - 1  'หา Pattern ที่ตรงกัน


                fg = New Regex(_prov(j))
                If (fg.IsMatch(grid.Item(4, i).Value)) = True Then

                    grid.Rows(i).Cells(3).Value = _proPic(j)
                    Exit For

                End If
            Next
        Next

    End Sub


    Private Sub setLastUpdate()

        lastEvent = ari0(0) & " " & ari3(0) & " เมื่อ " & ari4(0)

    End Sub

    Public Function getLastUpdate() As String

        Return lastEvent

    End Function

    Private Sub ColA()

        For i = 0 To grid.ColumnCount - 1

            grid.Item(i, 0).Style.BackColor = Color.Red
            grid.Item(i, 0).Style.ForeColor = Color.White

        Next

    End Sub

    Private Sub ColB()

        For i = 0 To grid.ColumnCount - 1

            grid.Item(i, 0).Style.BackColor = Color.White
            grid.Item(i, 0).Style.ForeColor = Color.Black

        Next

    End Sub

    ' Reload FEED

    Private Sub syncFeedThread()

        rq.ReadQuake(usgsLink, geofonLink, emscLink, tmdLink)

    End Sub

    Private Sub grid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid.CellClick

        Try

            Check_CellClickEvent()


            If grid.Item(0, 0).Value Then

                'RedAnim.Enabled = False
                StopSound()

            End If


        Catch ex As Exception


        End Try



    End Sub


    Public Sub Check_CellFirstLoad()

        InfoPanel.setQaukeLevel(ari0(0))
        InfoPanel.setDept(ari1(0))
        InfoPanel.setLat_Long(ari2(0))
        InfoPanel.setLocation(ari3(0))
        InfoPanel.setDateTime(ari4(0))
        InfoPanel.setPublisher(ari5(0))
        InfoPanel.setURL(ari6(0))

    End Sub

    Private Sub Check_CellClickEvent()

        On Error Resume Next

        Dim k As Integer = grid.CurrentRow.Index
        InfoPanel.setQaukeLevel(grid.Item(0, k).Value)
        InfoPanel.setDept(grid.Item(1, k).Value)
        InfoPanel.setLat_Long(grid.Item(2, k).Value)
        InfoPanel.setLocation(grid.Item(4, k).Value)
        InfoPanel.setDateTime(grid.Item(5, k).Value)
        InfoPanel.setPublisher(grid.Item(6, k).Value)
        InfoPanel.setURL(grid.Item(7, k).Value)



    End Sub

    Private Sub waitThread_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles waitThread.Tick

        'If DWWait = True Then
        'BackgroundWorker1.RunWorkerAsync()
        'waitThread.Enabled = False
        'End If


    End Sub

    Private Sub grid_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid.CellDoubleClick

        LoadGoogleMap(mwWidth, mwHeight)

    End Sub

    Private Sub grid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid.KeyDown
        Check_CellClickEvent()
    End Sub

    Private Sub grid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid.KeyUp

        Check_CellClickEvent()

    End Sub

    Private Sub ขอมลเพมเตมToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ขอมลเพมเตมToolStripMenuItem.Click

        Try
            System.Diagnostics.Process.Start(InfoPanel.getURL)
        Catch ex As Exception
        End Try


    End Sub


    Private Sub selCol1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selCol1.Click

        ATP_colorCardSlot = 0
        XColor.ShowDialog()


    End Sub

    Private Sub nonselCol1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nonselCol1.Click

        nonselCol1.Checked = True
        selCol1.Checked = False
        ColStripA.BackColor = Nothing
        unSetColorLevel_1()
        GenerateGridLevelColor()


    End Sub

    Private Sub selCol2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selCol2.Click

        ATP_colorCardSlot = 1

        XColor.ShowDialog()
    End Sub

    Private Sub nonSelCol2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nonSelCol2.Click

        nonSelCol2.Checked = True
        selCol2.Checked = False
        ColStripB.BackColor = Nothing

        unSetColorLevel_2()
        GenerateGridLevelColor()

    End Sub

    Private Sub selCol3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selCol3.Click
        ATP_colorCardSlot = 2

        XColor.ShowDialog()



    End Sub

    Private Sub nonSelCol3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nonSelCol3.Click

        nonSelCol3.Checked = True
        selCol3.Checked = False
        ColStripC.BackColor = Nothing
        unSetColorLevel_3()
        GenerateGridLevelColor()
    End Sub

    Private Sub selCol4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selCol4.Click

        ATP_colorCardSlot = 3

        XColor.ShowDialog()

    End Sub

    Private Sub nonSelCol4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nonSelCol4.Click

        nonSelCol4.Checked = True
        selCol4.Checked = False
        ColStripD.BackColor = Nothing
        unSetColorLevel_4()
        GenerateGridLevelColor()

    End Sub

    Private Sub selCol5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selCol5.Click

        ATP_colorCardSlot = 4
        XColor.ShowDialog()

    End Sub

    Private Sub nonSelCol5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nonSelCol5.Click


        nonSelCol5.Checked = True
        selCol5.Checked = False
        ColStripE.BackColor = Nothing
        unSetColorLevel_5()
        GenerateGridLevelColor()

    End Sub

    Private Sub celCol6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles celCol6.Click


        ATP_colorCardSlot = 5

        XColor.ShowDialog()

    End Sub

    Private Sub nonSelCol6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nonSelCol6.Click


        nonSelCol6.Checked = True
        celCol6.Checked = False
        ColStripF.BackColor = Nothing
        unSetColorLevel_6()
        GenerateGridLevelColor()

    End Sub

    Private Sub selCol7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selCol7.Click


        ATP_colorCardSlot = 6
        XColor.ShowDialog()

    End Sub

    Private Sub nonSelCol7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nonSelCol7.Click


        nonSelCol7.Checked = True
        selCol7.Checked = False
        ColStripG.BackColor = Nothing
        unSetColorLevel_7()
        GenerateGridLevelColor()

    End Sub

    Private Sub selCol8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selCol8.Click


        ATP_colorCardSlot = 7

        XColor.ShowDialog()

    End Sub

    Private Sub nonSelCol8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nonSelCol8.Click

        nonSelCol8.Checked = True
        selCol8.Checked = False
        ColStripH.BackColor = Nothing
        unSetColorLevel_8()
        GenerateGridLevelColor()

    End Sub

    Private Sub selCol9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selCol9.Click

        ATP_colorCardSlot = 8
        XColor.ShowDialog()

    End Sub

    Private Sub nonSelCol9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nonSelCol9.Click

        nonSelCol9.Checked = True
        selCol9.Checked = False
        ColStripI.BackColor = Nothing
        unSetColorLevel_9()
        GenerateGridLevelColor()


    End Sub

    Private Sub selCol10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selCol10.Click


        ATP_colorCardSlot = 9

        XColor.ShowDialog()


    End Sub

    Private Sub nonSelCol10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nonSelCol10.Click

        nonSelCol10.Checked = True
        selCol10.Checked = False
        ColStripJ.BackColor = Nothing
        unSetColorLevel_10()
        GenerateGridLevelColor()

    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        If Me.WindowState = FormWindowState.Minimized Then

            Me.Hide()
            Me.Visible = False

        End If

    End Sub

    Private Sub StopSound()

        My.Computer.Audio.Stop()

    End Sub

    Private Sub notifyAlert_BalloonTipClicked(ByVal sender As Object, ByVal e As System.EventArgs) Handles notifyAlert.BalloonTipClicked

        StopSound()

        Me.Visible = True
        Me.Show()
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub notifyAlert_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles notifyAlert.MouseClick

        StopSound()

        Me.Visible = True
        Me.Show()
        Me.WindowState = FormWindowState.Maximized

    End Sub


    Private Sub notifyAlert_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles notifyAlert.MouseDoubleClick

        StopSound()

        Me.Visible = True
        Me.Show()
        Me.WindowState = FormWindowState.Maximized


    End Sub

    Private Sub ToolStripButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton11.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub ToolStripButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton14.Click

        frmConfig.ShowDialog()

    End Sub


    Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Try

retry:      Thread.Sleep(25000)
            rq.ReadQuake(usgsLink, geofonLink, emscLink, tmdLink)

        Catch ex As Exception

            GoTo retry

        End Try


    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        If rq.isLastUpdate = True Then

            FillGridData()
            GenerateGridLevelColor()
            setLastUpdate()
            ' RedAnim.Enabled = True
            newsQuake.Text = "เหตุการณ์ล่าสุด : " & getLastUpdate() & "    "


            QNews.SendPersonalMessage()
            QNews.SendTwitterMessage()
            trd1 = New Thread(AddressOf iSyncQuakeReport)
            trd1.IsBackground = True
            trd1.Start()


        End If

        BackgroundWorker1.RunWorkerAsync()

    End Sub


    Private Sub ToolStripButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        oldTime = DateTime.Now

    End Sub


    Private Sub iSyncQuakeReport()

        QNews.SendEmailMessage()
        'QNews.SendTwitterMessage()
        'QNews.SendNetworkMessage()


    End Sub

    Sub BackgroundWorker1DoWork(sender As Object, e As DoWorkEventArgs)

    End Sub

    Private Sub ToolStripButton10_Click_1(sender As Object, e As EventArgs)
        EmailManage.ShowDialog()
    End Sub

    Private Sub ดแผนทToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ดแผนทToolStripMenuItem.Click
        Try
            LoadGoogleMap(mwWidth, mwHeight)
        Catch ex As Exception
        End Try

    End Sub


    Public Sub LoadGoogleMap(ByVal width As Integer, ByVal height As Integer)



        Dim txtDept As String = InfoPanel.getDept.Replace("km", "กม.")
        Dim b1 As String = InfoPanel.getLocation & " ขนาด " & InfoPanel.getQaukeLevel & " ลึก " & txtDept & " เมื่อ " & ToLocalTime(InfoPanel.getDateTime)
        Dim b2 As String = b1.Replace(" ", "+")


        Dim oWrite As System.IO.StreamWriter
        oWrite = IO.File.CreateText(CurDir() & "\mpgent.html")

        'Dim width As Integer = frmMapGenerate.WebBrowser1.Size.Width
        'Dim heigh As Integer = frmMapGenerate.WebBrowser1.Size.Height
        '788, 635
        '906, 702
        oWrite.WriteLine("<html>")
        oWrite.WriteLine("<head>")
        oWrite.WriteLine("<style type='text/css'>")
        oWrite.WriteLine("body {margin:0;}")
        oWrite.WriteLine("</style>")
        oWrite.WriteLine("</head>")
        oWrite.WriteLine("<body>")
        oWrite.WriteLine("<iframe width=" & width & " height=" & height & " frameborder=0 scrolling=no marginheight=0 marginwidth=0 src=http://maps.google.com/maps?q=" & InfoPanel.getLat_Long.Replace(",", "+").Replace(" ", "") & "(แผ่นดินไหว+:+" & b2 & ")&amp;f=d&amp;t=p&amp;hl=e&amp;ie=UTF8&amp;ll=" & InfoPanel.getLat_Long.Replace(" ", "") & "&amp;spn=2,2&amp;z=8&amp;output=embed></iframe>")
        oWrite.WriteLine("</body>")
        oWrite.WriteLine("</html>")
        oWrite.WriteLine("")

        oWrite.Close()
        oWrite = Nothing

        frmMapGenerate.ShowDialog()


    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        'frmFileExport.ShowDialog()
        TwitManage.ShowDialog()
    End Sub



    Public Sub GenerateGridLevelColor()

        On Error Resume Next


        For i = 0 To grid.Rows.Count - 1


            If Double.Parse(grid.Item(0, i).Value) >= 0.1 And Double.Parse(grid.Item(0, i).Value) <= 0.9 Then

                grid.Item(0, i).Style.BackColor = Color.FromName(setColv1)

            End If



            If Double.Parse(grid.Item(0, i).Value) >= 1.0 And Double.Parse(grid.Item(0, i).Value) <= 1.9 Then

                grid.Item(0, i).Style.BackColor = Color.FromName(setColv2)

            End If


            If Double.Parse(grid.Item(0, i).Value) >= 2.0 And Double.Parse(grid.Item(0, i).Value) <= 2.9 Then

                grid.Item(0, i).Style.BackColor = Color.FromName(setColv3)

            End If




            If Double.Parse(grid.Item(0, i).Value) >= 3.0 And Double.Parse(grid.Item(0, i).Value) <= 3.9 Then

                grid.Item(0, i).Style.BackColor = Color.FromName(setColv4)

            End If



            If Double.Parse(grid.Item(0, i).Value) >= 4.0 And Double.Parse(grid.Item(0, i).Value) <= 4.9 Then

                grid.Item(0, i).Style.BackColor = Color.FromName(setColv5)

            End If


            If Double.Parse(grid.Item(0, i).Value) >= 5.0 And Double.Parse(grid.Item(0, i).Value) <= 5.9 Then

                grid.Item(0, i).Style.BackColor = Color.FromName(setColv6)

            End If


            If Double.Parse(grid.Item(0, i).Value) >= 6.0 And Double.Parse(grid.Item(0, i).Value) <= 6.9 Then

                grid.Item(0, i).Style.BackColor = Color.FromName(setColv7)

            End If

            If Double.Parse(grid.Item(0, i).Value) >= 7.0 And Double.Parse(grid.Item(0, i).Value) <= 7.9 Then

                grid.Item(0, i).Style.BackColor = Color.FromName(setColv8)

            End If


            If Double.Parse(grid.Item(0, i).Value) >= 8.0 And Double.Parse(grid.Item(0, i).Value) <= 8.9 Then

                grid.Item(0, i).Style.BackColor = Color.FromName(setColv9)

            End If



            If Double.Parse(grid.Item(0, i).Value) >= 9.0 Then

                grid.Item(0, i).Style.BackColor = Color.FromName(setColv10)

            End If

        Next

        ColStripA.BackColor = Color.FromName(setColv1)
        ColStripB.BackColor = Color.FromName(setColv2)
        ColStripC.BackColor = Color.FromName(setColv3)
        ColStripD.BackColor = Color.FromName(setColv4)
        ColStripE.BackColor = Color.FromName(setColv5)
        ColStripF.BackColor = Color.FromName(setColv6)
        ColStripG.BackColor = Color.FromName(setColv7)
        ColStripH.BackColor = Color.FromName(setColv8)
        ColStripI.BackColor = Color.FromName(setColv9)
        ColStripJ.BackColor = Color.FromName(setColv10)





        If IsColv1 = True Then

            selCol1.Checked = True
            nonselCol1.Checked = False

        Else
            selCol1.Checked = False
            nonselCol1.Checked = True

        End If


        If selCol2.Checked = True Then
            nonSelCol2.Checked = False

        Else
            selCol2.Checked = False
            nonSelCol2.Checked = True

        End If


        If IsColv3 = True Then

            selCol3.Checked = True
            nonSelCol3.Checked = False

        Else
            selCol3.Checked = False
            nonSelCol3.Checked = True

        End If



        If IsColv4 = True Then

            selCol4.Checked = True
            nonSelCol4.Checked = False

        Else
            selCol4.Checked = False
            nonSelCol4.Checked = True

        End If

        If IsColv5 = True Then

            selCol5.Checked = True
            nonSelCol5.Checked = False

        Else
            selCol5.Checked = False
            nonSelCol5.Checked = True

        End If

        If IsColv6 = True Then

            celCol6.Checked = True
            nonSelCol6.Checked = False

        Else
            celCol6.Checked = False
            nonSelCol6.Checked = True

        End If


        If IsColv7 = True Then

            selCol7.Checked = True
            nonSelCol7.Checked = False

        Else
            selCol7.Checked = False
            nonSelCol7.Checked = True

        End If



        If IsColv8 = True Then

            selCol8.Checked = True
            nonSelCol8.Checked = False

        Else
            selCol8.Checked = False
            nonSelCol8.Checked = True

        End If


        If IsColv9 = True Then

            selCol9.Checked = True
            nonSelCol9.Checked = False

        Else
            selCol9.Checked = False
            nonSelCol9.Checked = True
        End If




        If IsColv10 = True Then

            selCol10.Checked = True
            nonSelCol10.Checked = False

        Else
            selCol10.Checked = False
            nonSelCol10.Checked = True
        End If


    End Sub

    Private Sub pw_caribe_Click(sender As Object, e As EventArgs) Handles pw_caribe.Click

        Try

            TsuTemp = DS_caribe
            TsuTitle = pw_caribe.Text
            frmTsunamiDetial.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub pw_indian_Click(sender As Object, e As EventArgs) Handles pw_indian.Click

        Try
            TsuTemp = DS_indian
            TsuTitle = pw_indian.Text
            frmTsunamiDetial.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

        End Try


    End Sub

    Private Sub pw_hawaii_Click(sender As Object, e As EventArgs) Handles pw_hawaii.Click

        Try

            TsuTemp = DS_hawaii
            TsuTitle = pw_hawaii.Text
            frmTsunamiDetial.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try


    End Sub

    Private Sub pw_pacific_Click(sender As Object, e As EventArgs) Handles pw_pacific.Click

        Try

            TsuTemp = DS_pacific
            TsuTitle = pw_pacific.Text
            frmTsunamiDetial.ShowDialog()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

        End Try


    End Sub

    Public Sub CheckVersion()

        If LoadVer() = True Then
            Shell(CurDir() & "\QuakeUpdater.exe ibj351DrBnNsWlX7mb8vp9vp4bQm")
            End

        End If

    End Sub


    Private Function LoadVer() As Boolean

1:
        Try
            Dim TempUrl As String = GetRedirectURL("https://dl.dropbox.com/u/24250788/dsver02.cfg")

            My.Computer.Network.DownloadFile(TempUrl, CurDir() & "\ver.cfg")
            Dim scr As StreamReader
            Dim newVer As String
            scr = File.OpenText(CurDir() & "\ver.cfg")
            newVer = scr.ReadLine
            scr.Close()

            Console.WriteLine(newVer)
            Console.WriteLine(My.Application.Info.Version.ToString)

            File.Delete(CurDir() & "\ver.cfg")

            If newVer <> My.Application.Info.Version.ToString Then

                Return True

            Else

                Return False

            End If


        Catch ex As Exception

            File.Delete(CurDir() & "\ver.cfg")
            GoTo 1

        End Try

    End Function


    Private Function GetRedirectURL(ByVal URL As String) As String

        Dim wq As HttpWebRequest = WebRequest.Create(URL)
        wq.AllowAutoRedirect = False
        Dim rs As HttpWebResponse = wq.GetResponse
        Dim dUrl As String = rs.Headers.Get("Location")
        Return dUrl

    End Function



    Private Sub ปดToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ปดToolStripMenuItem.Click
        End
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click

        If mailAccept = "Yes" Then

            EmailManage.ShowDialog()


        Else

            If MsgBox("จำเป็นต้องใช้อีเมลรวมไปถึงรหัสผ่านส่วนตัวของท่านในการเข้าสู่ระบบเพื่อให้สามารถส่งข้อมูลต่อไปยังบุคคลอื่นได้ซึ่งระบบนี้อาจดูเหมือนเป็นการจงใจขโมยบัญชีของผู้อื่นแต่ทางเราไม่มีนโยบายที่จะเก็บบันทึกหรือนำข้อมูลของท่านไปใช้ประโยชน์ใดๆหากบัญชีอีเมลของท่านเกิดได้รับความเสียหายทางเราจะไม่รับผิดชอบใด ๆ ทุกกรณีเพื่อคลายข้อกังวลแนะนำโปรดสมัครอีเมลสำรองใหม่หรือปฏิเสธข้อตกลงนี้", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "คำเติอน") = MsgBoxResult.Ok Then

                EmailManage.ShowDialog()

            End If



        End If

    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click

        SaveDlg.Title = "ออกรายงาน"
        SaveDlg.FileName = String.Empty

        Dim resultDlg As DialogResult = SaveDlg.ShowDialog

        If resultDlg = System.Windows.Forms.DialogResult.OK Then

            ExportToExcel(SaveDlg.FileName)

        End If


    End Sub


    Private Sub ExportToPDF(ByVal FileName As String)

        'Dim wordApplication As ApplicationClass = New ApplicationClass()
        'Dim wordDocument As Document = Nothing
        'Dim paramSourceDocPath As String = "C:\Temp\Test.docx"
        'Dim paramExportFilePath As String = "C:\Temp\Test.xps"
        'Dim paramExportFormat = WdExportFormat.wdExportFormatXPS
        'Dim paramOpenAfterExport As Boolean = False
        'Dim paramExportOptimizeFor As WdExportOptimizeFor = WdExportOptimizeFor.wdExportOptimizeForPrint
        'Dim paramExportRange As WdExportRange = WdExportRange.wdExportAllDocument
        'Dim paramStartPage As Int32 = 0
        'Dim paramEndPage As Int32 = 0
        'Dim paramExportItem As WdExportItem = WdExportItem.wdExportDocumentContent
        'Dim paramIncludeDocProps As Boolean = True
        'Dim paramKeepIRM As Boolean = True
        ' Dim paramCreateBookmarks As WdExportCreateBookmarks = WdExportCreateBookmarks.wdExportCreateWordBookmarks
        'Dim paramDocStructureTags As Boolean = True
        'Dim paramBitmapMissingFonts As Boolean = True
        'Dim paramUseISO19005_1 As Boolean = False



        'Try
        ' Open the source document.
        '  wordDocument = wordApplication.Documents.Open(paramSourceDocPath)

        ' Export it in the specified format.
        'If Not wordDocument Is Nothing Then
        'wordDocument.ExportAsFixedFormat(paramExportFilePath, _
        ' paramExportFormat, paramOpenAfterExport, _
        'paramExportOptimizeFor, paramExportRange, paramStartPage, _
        'paramEndPage, paramExportItem, paramIncludeDocProps, _
        'paramKeepIRM, paramCreateBookmarks, _
        'paramDocStructureTags, paramBitmapMissingFonts, _
        'paramUseISO19005_1)
        'End If
        'Catch ex As Exception
        ' Respond to the error
        'Finally
        ' Close and release the Document object.
        'If Not wordDocument Is Nothing Then
        'wordDocument.Close(False)
        'wordDocument = Nothing
        'End If

        ' Quit Word and release the ApplicationClass object.
        'If Not wordApplication Is Nothing Then
        'wordApplication.Quit()
        'wordApplication = Nothing
        'End If

        'GC.Collect()
        'GC.WaitForPendingFinalizers()
        'GC.Collect()
        'GC.WaitForPendingFinalizers()
        'End Try


    End Sub

    Private Sub ExportToExcel(ByVal FileName As String)

        Me.Cursor = Cursors.WaitCursor
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")

        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.ApplicationClass
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")

        xlWorkSheet.Range("A1").EntireRow.RowHeight = 20
        xlWorkSheet.Range("A1").EntireRow.VerticalAlignment = 2

      

        xlWorkSheet.Range("A1").EntireColumn.ColumnWidth = 11.88
        xlWorkSheet.Range("B1").EntireColumn.ColumnWidth = 14.63
        xlWorkSheet.Range("C1").EntireColumn.ColumnWidth = 25
        xlWorkSheet.Range("D1").EntireColumn.ColumnWidth = 0
        xlWorkSheet.Range("E1").EntireColumn.ColumnWidth = 43.13
        xlWorkSheet.Range("F1").EntireColumn.ColumnWidth = 31.13
        xlWorkSheet.Range("G1").EntireColumn.ColumnWidth = 14.88
        xlWorkSheet.Range("H1").EntireColumn.ColumnWidth = 75

        xlWorkSheet.Range("A1").Interior.ColorIndex = XLColor.Cream
        xlWorkSheet.Range("B1").Interior.ColorIndex = XLColor.Cream
        xlWorkSheet.Range("C1").Interior.ColorIndex = XLColor.Cream
        xlWorkSheet.Range("D1").Interior.ColorIndex = XLColor.Cream
        xlWorkSheet.Range("E1").Interior.ColorIndex = XLColor.Cream
        xlWorkSheet.Range("F1").Interior.ColorIndex = XLColor.Cream
        xlWorkSheet.Range("G1").Interior.ColorIndex = XLColor.Cream
        xlWorkSheet.Range("H1").Interior.ColorIndex = XLColor.Cream


        xlWorkSheet.Range("A1").HorizontalAlignment = 3
        xlWorkSheet.Range("B1").HorizontalAlignment = 3
        xlWorkSheet.Range("C1").HorizontalAlignment = 3
        xlWorkSheet.Range("D1").HorizontalAlignment = 3
        xlWorkSheet.Range("E1").HorizontalAlignment = 3
        xlWorkSheet.Range("F1").HorizontalAlignment = 3
        xlWorkSheet.Range("G1").HorizontalAlignment = 3
        xlWorkSheet.Range("H1").HorizontalAlignment = 3


        'xlWorkSheet.Range("A1").Borders.ColorIndex = XLColor.Black
        'xlWorkSheet.Range("B1").Borders.ColorIndex = XLColor.Black
        'xlWorkSheet.Range("C1").Borders.ColorIndex = XLColor.Black
        'xlWorkSheet.Range("D1").Borders.ColorIndex = XLColor.Black
        'xlWorkSheet.Range("E1").Borders.ColorIndex = XLColor.Black
        'xlWorkSheet.Range("F1").Borders.ColorIndex = XLColor.Black
        'xlWorkSheet.Range("G1").Borders.ColorIndex = XLColor.Black
        'xlWorkSheet.Range("H1").Borders.ColorIndex = XLColor.Black

        Dim _A, _B, _C, _D, _E, _F, _G, _H As String
        Dim _arc As New ArrayList

        _arc.Clear()

        For i = 1 To grid.RowCount + 1

            _A = "A" & i
            _B = "B" & i
            _C = "C" & i
            _D = "D" & i
            _E = "E" & i
            _F = "F" & i
            _G = "G" & i
            _H = "H" & i

            xlWorkSheet.Range(_A).Borders.ColorIndex = XLColor.Black
            xlWorkSheet.Range(_B).Borders.ColorIndex = XLColor.Black
            xlWorkSheet.Range(_C).Borders.ColorIndex = XLColor.Black
            xlWorkSheet.Range(_D).Borders.ColorIndex = XLColor.Black
            xlWorkSheet.Range(_E).Borders.ColorIndex = XLColor.Black
            xlWorkSheet.Range(_F).Borders.ColorIndex = XLColor.Black
            xlWorkSheet.Range(_G).Borders.ColorIndex = XLColor.Black
            xlWorkSheet.Range(_H).Borders.ColorIndex = XLColor.Black
            xlWorkSheet.Range(_A).HorizontalAlignment = 3
            xlWorkSheet.Range(_B).HorizontalAlignment = 3
            xlWorkSheet.Range(_C).HorizontalAlignment = 3
            xlWorkSheet.Range(_G).HorizontalAlignment = 3
        Next


        For i = 0 To grid.RowCount - 1
            For j = 0 To grid.ColumnCount - 1
                For k As Integer = 1 To grid.Columns.Count
                    xlWorkSheet.Cells(1, k) = grid.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = grid(j, i).Value.ToString()

                Next
            Next
        Next


        xlWorkSheet.SaveAs(FileName)
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        Me.Cursor = Cursors.Default

        Process.Start(FileName)



    End Sub


    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub


    Public Enum XLColor
        Aqua = 42
        Black = 1
        Blue = 5
        BlueGray = 47
        BrightGreen = 4
        Brown = 53
        Cream = 19
        DarkBlue = 11
        DarkGreen = 51
        DarkPurple = 21
        DarkRed = 9
        DarkTeal = 49
        DarkYellow = 12
        Gold = 44
        Gray25 = 15
        Gray40 = 48
        Gray50 = 16
        Gray80 = 56
        Green = 10
        Indigo = 55
        Lavender = 39
        LightBlue = 41
        LightGreen = 35
        LightLavender = 24
        LightOrange = 45
        LightTurquoise = 20
        LightYellow = 36
        Lime = 43
        NavyBlue = 23
        OliveGreen = 52
        Orange = 46
        PaleBlue = 37
        Pink = 7
        Plum = 18
        PowderBlue = 17
        Red = 3
        Rose = 38
        Salmon = 22
        SeaGreen = 50
        SkyBlue = 33
        Tan = 40
        Teal = 14
        Turquoise = 8
        Violet = 13
        White = 2
        Yellow = 6
    End Enum


    Private Sub grid_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid.CellContentClick

    End Sub

    Private Sub SaveDlg_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles SaveDlg.FileOk

    End Sub
End Class


