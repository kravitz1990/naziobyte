Module SystemKernal

    Public Sub SyncNTPServer()

        Shell("net start w32time", AppWinStyle.Hide)
        Shell("w32tm /resync", AppWinStyle.Hide)

    End Sub


End Module
