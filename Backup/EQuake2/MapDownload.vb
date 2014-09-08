Imports System.Threading
Imports System.IO
Module MapDownloader

    'http://maps.googleapis.com/maps/api/staticmap?center=40.714728,-73.998672&zoom=12&size=400x400&maptype=satellite&sensor=true
    '<img src="http://maps.googleapis.com/maps/api/staticmap?center=40.714728,-73.998672&zoom=12&size=400x400&maptype=satellite&sensor=true">

    Dim trd As Thread
    Dim strLeft As String = "http://maps.googleapis.com/maps/api/staticmap?center="
    Dim strRight As String = "&maptype=satellite&sensor=false"
    Public DWWait As Boolean = False
    Dim latty As String
    Dim wrb As StreamWriter

    Public Sub FillMapAsync()


        trd = New Thread(AddressOf DownloadMapAsync)
        trd.IsBackground = True
        trd.Start()

    End Sub

    Private Sub DownloadMapAsync()

        wrb = File.CreateText("C:\Users\Budick\Desktop\ZZZ\mapgent.html")
        wrb.Write("<img src=" & "http://maps.googleapis.com/maps/api/staticmap?center=" & InfoPanel.getLat_Long.Replace(" ", "") & "&zoom=12&size=400x400&maptype=satellite&sensor=true" & ">")
        wrb.Close()

        'For Each LATLONG As String In ari2
        'My.Computer.Network.DownloadFile(strLeft & LATLONG.Replace(" ", "") & strRight, "C:\Users\Budick\Desktop\ZZZ\" & LATLONG & ".png")
        'Thread.Sleep(1000)
        'Next
        'DWWait = True


    End Sub


    Public Function ShowMap() As String

        Return "PATH"

    End Function

End Module




