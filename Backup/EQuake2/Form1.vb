Imports System.IO
Imports System.Windows.Forms
Imports System.Drawing
Imports System
Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports System.Threading


Public Class Form1


    Dim QNews As New QuakeAlert

    Dim usgsLink As String = "http://earthquake.usgs.gov/earthquakes/catalogs/eqs1day-M0.xml"
    Dim geofonLink As String = "http://geofon.gfz-potsdam.de/eqinfo/list.php?fmt=rss"
    Dim emscLink As String = "http://www.emsc-csem.org/service/rss/rss.php?typ=emsc"
    Dim tmdLink As String = "http://www.seismology.tmd.go.th/feed/rss_inside.xml"
    Dim rq As New RssFeeder
    Dim tms As New TSunamiWarning
    Dim trd1, trd2 As Thread
    Dim ck_m As Boolean
    Dim lastEvent As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        rq.ReadQuake(usgsLink, geofonLink, emscLink, tmdLink)
        FillGridData()
        ConfigurationSystem()

        oldTime = ari4(0)
        'Tsu.updateListNow()
        'pw_pacific.Text = tms.bwc(0)
        'pw_hawaii.Text = tms.bwc(1)
        'pw_indian.Text = tms.bwc(2)
        'pw_caribe.Text = tms.bwc(3)
        BackgroundWorker1.RunWorkerAsync()


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

    Private Sub ConfigurationSystem()

        SyncNTPServer()
        grid.CellBorderStyle = DataGridViewCellBorderStyle.None
        grid.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grid.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        GenerateGridLevelColor()
        setLastUpdate()
        newsQuake.Text = "เหตุการณ์ล่าสุด : " & getLastUpdate() & "    "


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

        Check_CellClickEvent()

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

    Private Sub grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid.CellContentClick
    End Sub

    Private Sub waitThread_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles waitThread.Tick

        'If DWWait = True Then
        'BackgroundWorker1.RunWorkerAsync()
        'waitThread.Enabled = False
        'End If


    End Sub

    Private Sub grid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid.KeyDown
        Check_CellClickEvent()
    End Sub

    Private Sub grid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid.KeyUp

        Check_CellClickEvent()

    End Sub

    Private Sub ขอมลเพมเตมToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ขอมลเพมเตมToolStripMenuItem.Click

        System.Diagnostics.Process.Start(InfoPanel.getURL)

    End Sub

    
    Private Sub selCol1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selCol1.Click

        If ColDlg.ShowDialog = Windows.Forms.DialogResult.OK Then

            selCol1.Checked = True
            nonselCol1.Checked = False
            ColStripA.BackColor = ColDlg.Color

            setColorLevel_1(ColDlg.Color)


        Else

            If nonselCol1.Checked = True Then
                selCol1.Checked = False
            End If

        End If


    End Sub

    Private Sub nonselCol1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nonselCol1.Click

        nonselCol1.Checked = True
        selCol1.Checked = False
        ColStripA.BackColor = Nothing

        unSetColorLevel_1()
      

    End Sub

    Private Sub selCol2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selCol2.Click


        If ColDlg.ShowDialog = Windows.Forms.DialogResult.OK Then

            selCol2.Checked = True
            nonSelCol2.Checked = False
            ColStripB.BackColor = ColDlg.Color

            setColorLevel_2(ColDlg.Color)

        Else

            If nonSelCol2.Checked = True Then
                selCol2.Checked = False
            End If

        End If


    End Sub

    Private Sub nonSelCol2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nonSelCol2.Click

        nonSelCol2.Checked = True
        selCol2.Checked = False
        ColStripB.BackColor = Nothing

        unSetColorLevel_2()


    End Sub

    Private Sub selCol3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selCol3.Click



        If ColDlg.ShowDialog = Windows.Forms.DialogResult.OK Then

            selCol3.Checked = True
            nonSelCol3.Checked = False
            ColStripC.BackColor = ColDlg.Color

            setColorLevel_3(ColDlg.Color)

        Else

            If nonSelCol3.Checked = True Then
                selCol3.Checked = False
            End If

        End If



    End Sub

    Private Sub nonSelCol3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nonSelCol3.Click

        nonSelCol3.Checked = True
        selCol3.Checked = False
        ColStripC.BackColor = Nothing

        unSetColorLevel_3()

    End Sub

    Private Sub selCol4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selCol4.Click


        If ColDlg.ShowDialog = Windows.Forms.DialogResult.OK Then

            selCol4.Checked = True
            nonSelCol4.Checked = False
            ColStripD.BackColor = ColDlg.Color

            setColorLevel_4(ColDlg.Color)

        Else

            If nonSelCol4.Checked = True Then
                selCol4.Checked = False
            End If

        End If



    End Sub

    Private Sub nonSelCol4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nonSelCol4.Click

        nonSelCol4.Checked = True
        selCol4.Checked = False
        ColStripD.BackColor = Nothing

        unSetColorLevel_4()


    End Sub

    Private Sub selCol5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selCol5.Click



        If ColDlg.ShowDialog = Windows.Forms.DialogResult.OK Then

            selCol5.Checked = True
            nonSelCol5.Checked = False
            ColStripE.BackColor = ColDlg.Color

            setColorLevel_5(ColDlg.Color)

        Else

            If nonSelCol5.Checked = True Then
                selCol5.Checked = False
            End If

        End If


    End Sub

    Private Sub nonSelCol5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nonSelCol5.Click


        nonSelCol5.Checked = True
        selCol5.Checked = False
        ColStripE.BackColor = Nothing

        unSetColorLevel_5()


    End Sub

    Private Sub celCol6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles celCol6.Click


        If ColDlg.ShowDialog = Windows.Forms.DialogResult.OK Then

            celCol6.Checked = True
            nonSelCol6.Checked = False
            ColStripF.BackColor = ColDlg.Color

            setColorLevel_6(ColDlg.Color)

        Else

            If nonSelCol6.Checked = True Then
                celCol6.Checked = False
            End If

        End If


    End Sub

    Private Sub nonSelCol6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nonSelCol6.Click


        nonSelCol6.Checked = True
        celCol6.Checked = False
        ColStripF.BackColor = Nothing


        unSetColorLevel_6()

    End Sub

    Private Sub selCol7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selCol7.Click


        If ColDlg.ShowDialog = Windows.Forms.DialogResult.OK Then

            selCol7.Checked = True
            nonSelCol7.Checked = False
            ColStripG.BackColor = ColDlg.Color

            setColorLevel_7(ColDlg.Color)

        Else

            If nonSelCol7.Checked = True Then
                selCol7.Checked = False
            End If

        End If



    End Sub

    Private Sub nonSelCol7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nonSelCol7.Click


        nonSelCol7.Checked = True
        selCol7.Checked = False
        ColStripG.BackColor = Nothing

        unSetColorLevel_7()


    End Sub

    Private Sub selCol8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selCol8.Click


        If ColDlg.ShowDialog = Windows.Forms.DialogResult.OK Then

            selCol8.Checked = True
            nonSelCol8.Checked = False
            ColStripH.BackColor = ColDlg.Color

            setColorLevel_8(ColDlg.Color)

        Else

            If nonSelCol8.Checked = True Then
                selCol8.Checked = False
            End If

        End If


    End Sub

    Private Sub nonSelCol8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nonSelCol8.Click

        nonSelCol8.Checked = True
        selCol8.Checked = False
        ColStripH.BackColor = Nothing

        unSetColorLevel_8()


    End Sub

    Private Sub selCol9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selCol9.Click

        If ColDlg.ShowDialog = Windows.Forms.DialogResult.OK Then

            selCol9.Checked = True
            nonSelCol9.Checked = False
            ColStripI.BackColor = ColDlg.Color

            setColorLevel_9(ColDlg.Color)

        Else

            If nonSelCol9.Checked = True Then
                selCol9.Checked = False
            End If

        End If

    End Sub

    Private Sub nonSelCol9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nonSelCol9.Click

        nonSelCol9.Checked = True
        selCol9.Checked = False
        ColStripI.BackColor = Nothing

        unSetColorLevel_9()



    End Sub

    Private Sub selCol10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selCol10.Click



        If ColDlg.ShowDialog = Windows.Forms.DialogResult.OK Then

            selCol10.Checked = True
            nonSelCol10.Checked = False
            ColStripJ.BackColor = ColDlg.Color

        Else

            If nonSelCol10.Checked = True Then
                selCol10.Checked = False
            End If

        End If


    End Sub

    Private Sub nonSelCol10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nonSelCol10.Click

        nonSelCol10.Checked = True
        selCol10.Checked = False
        ColStripJ.BackColor = Nothing

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

    Private Sub notifyAlert_BalloonTipClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles notifyAlert.BalloonTipClosed
        StopSound()
    End Sub

  
    Private Sub notifyAlert_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles notifyAlert.MouseDoubleClick

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

        Thread.Sleep(50000)
        rq.ReadQuake(usgsLink, geofonLink, emscLink, tmdLink)
        Console.WriteLine("Old Time is : " & oldTime)
        Console.WriteLine("Last Time is : " & lastTime)
        Console.WriteLine("-----------------------------")


    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        If rq.isLastUpdate = True Then

          
            QNews.SendPersonalMessage()

            FillGridData()
            GenerateGridLevelColor()
            setLastUpdate()
            newsQuake.Text = "เหตุการณ์ล่าสุด : " & getLastUpdate() & "    "

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

        'QNews.SendNetworkMessage()
        'QNews.SendFacebookMessage()
        'QNews.SendTwitterMessage()

    End Sub


    Private Sub ToolStripButton10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton10.Click

        FillGridData()
        GenerateGridLevelColor()
        rq.DefragQuakeList()


    End Sub
    
    Sub BackgroundWorker1DoWork(sender As Object, e As DoWorkEventArgs)
    	
    End Sub
End Class
