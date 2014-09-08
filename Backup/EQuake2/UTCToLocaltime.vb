Module UTCToLocaltime

    Public Function ToLocalTime(ByVal UniversalTime As Object) As String

        Dim dUtc As DateTime = UniversalTime
        dUtc.ToLocalTime()
        Dim format2 As String = "d MMMM yyyy H:mm:ss tt"
        dUtc.ToString(format2)

        Return dUtc.ToString(format2)

    End Function


End Module
