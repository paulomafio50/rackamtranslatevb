
Imports System.Text

Imports System.IO
Imports System.Windows.Forms
Imports System.Xml.XPath
Imports System.Threading.Tasks
Imports Gecko
Imports System.Text.RegularExpressions
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports Gecko.DOM



Public Class Traducteur


    Private Sub Traducteur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.ComboBox1.Items.Count > 0 Then
            Me.ComboBox1.SelectedIndex = 0
        End If
        GeckoWebBrowser1.Navigate("https://www.deepl.com/translator")
        Dim line = Returnrichbox.Lines(Me.NumericUpDown1.Value - 1)

        Me.Textsource.Text = line
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Visible = False
    End Sub






    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click



        Dim text = Extract("/html/body/div[2]/div[1]/div[1]/div[3]/div[3]/div[1]/textarea", "text")
        MessageBox.Show(text)

    End Sub

    Public Function Extract(ByVal xpath As String, ByVal type As String) As String
        Dim result As String = String.Empty
        Dim Elm As GeckoHtmlElement
        Dim wb As GeckoWebBrowser = GeckoWebBrowser1

        If wb IsNot Nothing Then
            Elm = GetElement(wb, xpath)

            If Elm IsNot Nothing Then

                If Elm IsNot Nothing Then

                    Select Case type
                        Case "html"
                            result = Elm.OuterHtml
                        Case "text"

                            If Elm.[GetType]().Name = "GeckoTextAreaElement" Then
                                result = (CType(Elm, GeckoTextAreaElement)).Value
                            Else
                                result = Elm.TextContent.Trim()
                            End If

                        Case "value"
                            result = (CType(Elm, GeckoInputElement)).Value
                        Case Else
                            result = ExtractData(Elm, type)
                    End Select
                End If
            End If
        End If

        Return result
    End Function

    Private Function ExtractData(ByVal ele As GeckoHtmlElement, ByVal attribute As String) As String
        Dim result = String.Empty

        If ele IsNot Nothing Then
            Dim tmp = ele.GetAttribute(attribute)
            If tmp IsNot Nothing Then result = tmp.Trim()
        End If

        Return result
    End Function



    Private Function GetElement(ByVal wb As GeckoWebBrowser, ByVal xpath As String) As GeckoHtmlElement
        Dim elm As GeckoHtmlElement = Nothing

        If xpath.StartsWith("/") Then

            If xpath.Contains("@class") OrElse xpath.Contains("@data-type") Then
                Dim html = GetHtmlFromGeckoDocument(wb.Document)
                Dim doc As HtmlAgilityPack.HtmlDocument = New HtmlAgilityPack.HtmlDocument()
                doc.LoadHtml(html)
                Dim node = doc.DocumentNode.SelectSingleNode(xpath)

                If node IsNot Nothing Then
                    Dim currentXpath = "/" & node.XPath
                    elm = CType(wb.Document.EvaluateXPath(currentXpath).GetNodes().FirstOrDefault(), GeckoHtmlElement)
                End If
            Else
                elm = CType(wb.Document.EvaluateXPath(xpath).GetNodes().FirstOrDefault(), GeckoHtmlElement)
            End If
        Else
            elm = CType(wb.Document.GetElementById(xpath), GeckoHtmlElement)
        End If

        Return elm
    End Function


    Private Function GetHtmlFromGeckoDocument(ByVal doc As GeckoDocument) As String
        Dim result = String.Empty
        Dim element As GeckoHtmlElement
        Dim geckoDomElement = doc.DocumentElement

        If TypeOf geckoDomElement Is GeckoHtmlElement Then
            element = CType(geckoDomElement, GeckoHtmlElement)
            result = element.InnerHtml
        End If

        Return result
    End Function

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If Me.Visible Then
            Dim line = Returnrichbox.Lines(Me.NumericUpDown1.Value - 1)

            Me.Textsource.Text = line
        End If
    End Sub
    Private Function Returnrichbox()
        Dim Mytab As TabPage = Principal.TabControl2.TabPages("tabtrad" & Me.ComboBox1.SelectedItem)
        Dim MyRb As RichTextBox = Mytab.Controls.Find("textbtrad" & Mytab.Tag, False).First()
        Return MyRb
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.NumericUpDown1.Value = 1
        Dim count = Returnrichbox.lines.Length - 1




        Me.NumericUpDown1.Maximum = count


    End Sub
End Class