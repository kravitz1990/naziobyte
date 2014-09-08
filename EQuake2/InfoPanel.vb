Module InfoPanel

    Private quakelevel, dept, locate, publish, latlong, link As String
    Private DTime As DateTime

    Public Sub setQaukeLevel(ByVal level As String)

        quakelevel = level

    End Sub


    Public Sub setURL(ByVal url As String)


        If (url.IndexOf("usgs.gov") <> -1) Then

            Dim tmp, result As String
            tmp = Mid(url, url.LastIndexOf("/") + 2).Replace(".php", "")
            result = "http://origin-earthquake.usgs.gov/earthquakes/eventpage/" & tmp
            link = result

        Else

            link = url

        End If

    End Sub

    Public Sub setDept(ByVal _dept As String)

        dept = _dept

    End Sub


    Public Sub setLat_Long(ByVal latTong As String)

        latlong = latTong

    End Sub


    Public Sub setLocation(ByVal location As String)

        locate = location

    End Sub

    Public Sub setDateTime(ByVal datetime As DateTime)

        DTime = datetime


    End Sub

    Public Sub setPublisher(ByVal pubisher As String)

        publish = pubisher


    End Sub


    Public Function getQaukeLevel() As String

        Return quakelevel

    End Function


    Public Function getDept() As String

        Return dept

    End Function


    Public Function getLocation() As String

        Return locate

    End Function

    Public Function getDateTime() As DateTime

        Return DTime

    End Function


    Public Function getPublisher() As String

        Return publish

    End Function



    Public Function getLat_Long() As String

        Return latlong

    End Function

    Public Function getURL() As String

        Return link

    End Function

End Module
