Imports System.Xml
Imports System.Threading

Class TSunamiWarning

    Private xml(3) As XmlDocument
    Private ds(3) As XmlNodeList
    Private pacific As String = "http://ptwc.weather.gov/feeds/ptwc_rss_pacific.xml"
    Private hawaii As String = "http://ptwc.weather.gov/feeds/ptwc_rss_hawaii.xml"
    Private indian As String = "http://ptwc.weather.gov/feeds/ptwc_rss_indian.xml"
    Private caribe As String = "http://ptwc.weather.gov/feeds/ptwc_rss_caribe.xml"
    Private node As String = "/rss/channel/item"
    Public bwc As New ArrayList
    Public bwcLink As New ArrayList
    ' Private quaker As RssFeeder


    Public Sub updateListNow()

        Dim dk As New Form1

        xml(0) = New XmlDocument
        ds(0) = xml(0).SelectNodes(node)
        xml(0).Load(pacific)

        xml(1) = New XmlDocument
        ds(1) = xml(1).SelectNodes(node)
        xml(1).Load(hawaii)

        xml(2) = New XmlDocument
        ds(2) = xml(2).SelectNodes(node)
        xml(2).Load(indian)

        xml(3) = New XmlDocument
        ds(3) = xml(3).SelectNodes(node)
        xml(3).Load(caribe)


        bwc.Add("เฝ้าระวังเมื่อ " & ToLocalTime(ds(0).Item(0).ChildNodes(1).InnerText) & " (Pacific Ocean)")
        bwc.Add("เฝ้าระวังเมื่อ " & ToLocalTime(ds(1).Item(0).ChildNodes(1).InnerText) & " (Hawai`i)")
        bwc.Add("เฝ้าระวังเมื่อ " & ToLocalTime(ds(2).Item(0).ChildNodes(1).InnerText) & " (Indian Ocean)")
        bwc.Add("เฝ้าระวังเมื่อ " & ToLocalTime(ds(3).Item(0).ChildNodes(1).InnerText) & " (Caribbean Sea)")


    End Sub

End Class

