
Public Class frmAbout

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtver.Click

    End Sub

    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtver.Text = "รุ่น " & My.Application.Info.Version.ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Close()

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("http://zunmegasoft.blogspot.com")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("mailto:kiratisonic555@gmail.com")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MessageBox.Show("- Pacific Tsunami Warning Center : (http://ptwc.weather.gov)" & vbCrLf & vbCrLf & "- U.S. Geological Survey : (www.usgs.gov)" & vbCrLf & vbCrLf & "- GEOFON Program GFZ Potsdam : (http://geofon.gfz-potsdam.de)" & vbCrLf & vbCrLf & "- European Seismological Centre : (www.emsc-csem.org)" & vbCrLf & vbCrLf & "- สำนักเฝ้าระวังแผ่นดินไหว กรมอุตุนิยมวิทยา (www.seismology.tmd.go.th) ", "ขอขอบคุณ", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("http://on.fb.me/1m9nMnr")
    End Sub
End Class