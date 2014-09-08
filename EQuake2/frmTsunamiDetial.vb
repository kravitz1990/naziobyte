Imports System.Threading
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Xml


Public Class frmTsunamiDetial

    Dim trd As Thread
    Dim ans As String
  
    Dim doc As XmlDocument
    Dim node As XmlNodeList

    Private Sub frmTsunamiDetial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "รายงานการเฝ้าระวังสึนามิ " & TsuTitle
        WebBrowser1.Visible = False
        StatusStrip1.Visible = False
        picload.Visible = True
        txtPreload.Visible = True
        WebBrowser1.IsWebBrowserContextMenuEnabled = False
        StatusStrip1.Cursor = Cursors.Hand


        doc = New XmlDataDocument
        node = doc.SelectNodes("/rss/channel/item")

        BackgroundWorker1.RunWorkerAsync()


    End Sub




    Private Sub txtSent_Click(sender As System.Object, e As System.EventArgs) Handles txtSent.Click


        Select Case TsuTemp

            Case DS_pacific
                Process.Start("http://ptwc.weather.gov/ptwc/index.php?region=1")
             
            Case DS_hawaii
                Process.Start("http://ptwc.weather.gov/ptwc/index.php?region=2")
            Case DS_indian

                Process.Start("http://ptwc.weather.gov/ptwc/index.php?region=3")

            Case DS_caribe

                Process.Start("http://ptwc.weather.gov/ptwc/index.php?region=4")

        End Select


    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        PreLoad()

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted


        Select Case TsuTemp

            Case DS_pacific

                txtSent.Text = node.Item(0).ChildNodes(13).InnerText & " ขนาด " & Double.Parse(node.Item(0).ChildNodes(12).InnerText).ToString("##.0") & " ริกเตอร์  เมื่อ " & ToLocalTime(node.Item(0).ChildNodes(1).InnerText) & "  (" & node.Item(0).ChildNodes(10).InnerText & ")"

            Case DS_hawaii

                txtSent.Text = node.Item(0).ChildNodes(11).InnerText & " ขนาด " & Double.Parse(node.Item(0).ChildNodes(10).InnerText).ToString("##.0") & " ริกเตอร์  เมื่อ " & ToLocalTime(node.Item(0).ChildNodes(1).InnerText) & "  (" & node.Item(0).ChildNodes(9).InnerText & ")"

            Case DS_indian

                txtSent.Text = node.Item(0).ChildNodes(13).InnerText & " ขนาด " & Double.Parse(node.Item(0).ChildNodes(12).InnerText).ToString("##.0") & " ริกเตอร์  เมื่อ " & ToLocalTime(node.Item(0).ChildNodes(1).InnerText) & "  (" & node.Item(0).ChildNodes(10).InnerText & ")"

            Case DS_caribe

                txtSent.Text = node.Item(0).ChildNodes(11).InnerText & " ขนาด " & Double.Parse(node.Item(0).ChildNodes(10).InnerText).ToString("##.0") & " ริกเตอร์  เมื่อ " & ToLocalTime(node.Item(0).ChildNodes(1).InnerText) & "  (" & node.Item(0).ChildNodes(9).InnerText & ")"


        End Select

        WebBrowser1.Visible = True
        StatusStrip1.Visible = True
        picload.Visible = False
        txtPreload.Visible = False
        WebBrowser1.Navigate(ans)





    End Sub


    Private Sub PreLoad()


        doc.Load(TsuTemp)
        ans = ("http://ptwc.weather.gov/ptwc/text.php?id=" & node.Item(0).ChildNodes(3).InnerText)


    End Sub


End Class