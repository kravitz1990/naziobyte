Module Pubisher

    Public ari0 As New ArrayList
    Public ari1 As New ArrayList
    Public ari2 As New ArrayList
    Public ari3 As New ArrayList
    Public ari4 As New ArrayList
    Public ari5 As New ArrayList
    Public ari6 As New ArrayList


    Private puppy As String

    Function FormatPubisher(ByVal pubStr As String) As String

        If pubStr = "USGS" Then

            puppy = " U.S. Geological Survey"

        ElseIf pubStr = "EMSC - CSEM" Then

            puppy = "European Mediterranean Seismological"

        ElseIf pubStr = "GFZ" Then

            puppy = "GEOFON"

        End If

        Return puppy

    End Function


End Module


