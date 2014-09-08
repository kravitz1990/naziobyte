Imports System.Net
Imports System.Net.WebClient
Imports System.Text.RegularExpressions


Public Class soundDownloader
    Private WithEvents Wb As WebClient


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub soundDownloader_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim rx As New Regex(".wav")

        If rx.IsMatch(Clipboard.GetText) = True Then

            TextBox1.Text = Clipboard.GetText

        End If


    End Sub

    Private Sub Wb_DownloadFileCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles Wb.DownloadFileCompleted

        MsgBox("การนำเข้าเสร็จสมบูรณ์", MsgBoxStyle.Information, "          ")
        Label3.Visible = False
        Button1.Enabled = True
        frmConfig.LoadSoundsFile()
        TextBox1.Enabled = True
        TextBox2.Enabled = True

    End Sub

    Private Sub Wb_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles Wb.DownloadProgressChanged

        Label3.Text = "ความคืบหน้า " & e.ProgressPercentage & "%"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text <> "" Or TextBox2.Text <> "" Then

            Try
                Wb = New WebClient()
                Wb.DownloadFileAsync(New Uri(TextBox1.Text), CurDir() & "\sounds\" & TextBox2.Text & ".wav")
                Button1.Enabled = False
                Label3.Visible = True
                TextBox1.Enabled = False
                TextBox2.Enabled = False

            Catch ex As Exception

                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

            End Try
           

        Else
            MsgBox("โปรดกรอกข้อมูลให้ครบก่อนดาวน์โหลด", MsgBoxStyle.Critical, "Error")
        End If


    End Sub
End Class