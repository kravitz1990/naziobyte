Module Temp

    Public oldTime, lastTime As DateTime
    Public xBuild As New ArrayList
    Public auth1, auth2 As String


    'Map size :788, 635 (default)
    Public mwWidth As Integer = 788
    Public mwHeight As Integer = 635
    Public mapStyle As String = ""



    'Twitter
    'Public consumer As String = My.Settings.consumer
    'Public consumersecret As String = My.Settings.consumersecret

    'Public pbFile1 As String = CurDir() & "\aMake_0Auth1.dat"
    'Public pbFile2 As String = CurDir() & "\zMake_0Auth2.dat"

    'Public oauthtocken As String
    'Public oauthtockensecret As String

    'Facebook
    'Public Fbo_AppId As String = "238494026282229"
    'Public Fbo_AppSecret As String = "c4193cd60343631023ebf0949946ae68"
    'Public Fbo_scope As String = "publish_stream,manage_pages"



    'Color
    Public ATP_colorCardSlot As Integer



    'Tsunami Data
    Public DS_pacific As String = "http://ptwc.weather.gov/feeds/ptwc_rss_pacific.xml"
    Public DS_hawaii As String = "http://ptwc.weather.gov/feeds/ptwc_rss_hawaii.xml"
    Public DS_indian As String = "http://ptwc.weather.gov/feeds/ptwc_rss_indian.xml"
    Public DS_caribe As String = "http://ptwc.weather.gov/feeds/ptwc_rss_caribe.xml"
    Public TsuTemp, TsuTitle As String



End Module
