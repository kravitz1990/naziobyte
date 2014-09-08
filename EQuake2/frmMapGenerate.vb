Imports System.Threading
Imports System.Drawing.Imaging

Public Class frmMapGenerate

    Dim tWeb As Thread
    Private Sub frmMapGenerate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tWeb = New Thread(AddressOf runWeb)
        tWeb.IsBackground = True
        tWeb.Start()

    End Sub

    Private Sub runWeb()
        WebBrowser1.Refresh()
        WebBrowser1.Navigate(CurDir() & "\mpgent.html")
        WebBrowser1.IsWebBrowserContextMenuEnabled = False
    End Sub


    Private Sub TakeScreenShot()

        Dim Img As New Bitmap(WebBrowser1.Width, WebBrowser1 .Height )

        Dim g As Graphics = Graphics.FromImage(Img)

        g.CopyFromScreen(300, 50, 0, 0, Img.Size)

        Clipboard.SetDataObject(g)

        g.Dispose()

    End Sub

    Private Function CaptureWebBrowser(ByVal wb As WebBrowser) As Image

        Try
            Dim hBitmap As Bitmap = New Bitmap(wb.Width, wb.Height)
            wb.DrawToBitmap(hBitmap, wb.Bounds)

            Dim img As Image = hBitmap
            Return img
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return Nothing

    End Function

   
  
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

        'Clipboard.Clear()
        'Clipboard.SetImage(CaptureWebBrowser(WebBrowser1))
        'ServiceUpdate.Close()

    End Sub

    Private Function TakeImage()

        Return TakeImage(Me.Location.X + 7, Me.Location.Y + 25, WebBrowser1.Width, WebBrowser1.Height)

    End Function

    Private Function TakeImage(ByVal X As Integer, ByVal Y As Integer, ByVal Width As Integer, ByVal Height As Integer)

        Dim Img As New Bitmap(Width, Height)
        Dim g As Graphics = Graphics.FromImage(Img)
        g.CopyFromScreen(X, Y, 0, 0, Img.Size)
        g.Dispose()

        Return Img


    End Function

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

        Dim ImgTemp As Bitmap
        ImgTemp = Clipboard.GetImage
        Clipboard.Clear()

        Select Case SaveFileDialog1.FilterIndex

            Case 1
                ImgTemp.Save(SaveFileDialog1.FileName, ImageFormat.Jpeg)

            Case 2
                ImgTemp.Save(SaveFileDialog1.FileName, ImageFormat.Png)

            Case 3
                ImgTemp.Save(SaveFileDialog1.FileName, ImageFormat.Gif)

        End Select


    End Sub

    Private Sub ImageToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Clipboard.SetImage(TakeImage())

        SaveFileDialog1.Filter = "PNG (*.png)|*.png|JPEG (*.jpeg)|*.jpeg|GIF (*.gif)|*.gif"
        SaveFileDialog1.Title = "บันทึกรูปแผนที่"
        SaveFileDialog1.FilterIndex = 1
        SaveFileDialog1.ShowDialog()


    End Sub

    Private Sub frmMapGenerate_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize

        If Me.Width >= mwWidth And Me.Height >= mwHeight Then

            Me.Width = mwWidth
            Me.Height = mwHeight
        ElseIf Me.Width >= mwWidth Then
            Me.Width = mwWidth

        ElseIf Me.Height >= mwHeight Then
            Me.Height = mwHeight

        End If


    End Sub


   

    Private Sub VvvToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VvvToolStripMenuItem.Click

        Clipboard.SetImage(TakeImage())

        SaveFileDialog1.Filter = "PNG (*.png)|*.png|JPEG (*.jpeg)|*.jpeg|GIF (*.gif)|*.gif"
        SaveFileDialog1.Title = "บันทึกรูปแผนที่"
        SaveFileDialog1.FilterIndex = 1
        SaveFileDialog1.ShowDialog()

    End Sub
End Class