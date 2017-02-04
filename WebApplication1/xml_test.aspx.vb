Imports System.Xml
Imports System.IO

Public Class xml_test
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim xtw As XmlTextWriter
        xtw = New XmlTextWriter("C:\Users\Gian\Desktop", Encoding.UTF8)
        xtw.WriteStartDocument()
        xtw.WriteStartElement("Customers")
        xtw.WriteEndElement()
        xtw.Close()

    End Sub

End Class