Imports System.Xml
Imports System.Web
Imports System.Net

Class TSunamiWarning

    Private xml(3) As XmlDocument
    Private ds(3) As XmlNodeList
    Private pacific As String = "http://ptwc.weather.gov/feeds/ptwc_rss_pacific.xml"
    Private hawaii As String = "http://ptwc.weather.gov/feeds/ptwc_rss_hawaii.xml"
    Private indian As String = "http://ptwc.weather.gov/feeds/ptwc_rss_indian.xml"
    Private caribe As String = "http://ptwc.weather.gov/feeds/ptwc_rss_caribe.xml"
    Private node As String = "/rss/channel/item"


    Public Sub updateListNow()


    End Sub


    Public Function getPacific_data() As String

        Return ""

    End Function

    Public Function getHawai_data() As String

        Return ""

    End Function


    Public Function getIndian_data() As String

        Return ""

    End Function

    Public Function getCaribbean_data() As String

        Return ""

    End Function


End Class
