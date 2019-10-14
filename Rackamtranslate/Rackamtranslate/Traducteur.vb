
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





    Private _browser As Gecko.GeckoWebBrowser
    'Dim Mytab As TabPage = Principal.TabControl2.SelectedTab

    '    Dim MyRb As RichTextBox = Mytab.Controls.Find("textbtrad" & Mytab.Tag, False).First()
    '    'MsgBox(MyRb.Name)


    Private Sub Traducteur_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GeckoWebBrowser1.Navigate("https://www.deepl.com/translator")


    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim Mytab As TabPage = Principal.TabControl2.SelectedTab
        Dim MyRb As RichTextBox = Mytab.Controls.Find("textbtrad" & Mytab.Tag, False).First()
        Dim currentCharIndex As Long = MyRb.GetFirstCharIndexOfCurrentLine

        Dim currentLineIndex As Long = MyRb.GetLineFromCharIndex(currentCharIndex)
        'Dim currentLineText As String = MyRb.Lines(currentLineIndex)


        Dim index As Long = MyRb.SelectionStart
        Dim line As Long = MyRb.GetLineFromCharIndex(index)



        If TextBox1.Text = "" Then
            Label1.Text = "cursor at line " & line.ToString()
            Label2.Text = Mytab.Tag.ToString()
            Me.TextBox1.Text = line
            Label3.Text = MyRb.Lines(line)
        Else
            TextBox1.Text = TextBox1.Text + 1
            Label2.Text = Mytab.Tag.ToString()
            Label3.Text = MyRb.Lines(TextBox1.Text)
        End If




        ' MyRb.SelectionStart = (MyRb.GetFirstCharIndexFromLine(line) + MyRb.Lines(line).Count) + 1

    End Sub




    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim myElement As Gecko.GeckoHtmlElement = Nothing
        Dim elements = GeckoWebBrowser1.DomDocument.GetElementsByClassName("lmt__inner_textarea_container").Item(0)

        Dim myDoc As Gecko.GeckoDocument = GeckoWebBrowser1.Window.Document
        myElement = myDoc.GetHtmlElementById("lmt__inner_textarea_container")



        Dim text = extract("/html/body/div[2]/div[1]/div[1]/div[3]/div[3]/div[1]/textarea", "text")
        MessageBox.Show(text)

    End Sub

    'test
    Public Function extract(ByVal xpath As String, ByVal type As String) As String
        Dim result As String = String.Empty
        Dim elm As GeckoHtmlElement = Nothing
        Dim wb As GeckoWebBrowser = GeckoWebBrowser1

        If wb IsNot Nothing Then
            elm = GetElement(wb, xpath)

            If elm IsNot Nothing Then

                If elm IsNot Nothing Then

                    Select Case type
                        Case "html"
                            result = elm.OuterHtml
                        Case "text"

                            If elm.[GetType]().Name = "GeckoTextAreaElement" Then
                                result = (CType(elm, GeckoTextAreaElement)).Value
                            Else
                                result = elm.TextContent.Trim()
                            End If

                        Case "value"
                            result = (CType(elm, GeckoInputElement)).Value
                        Case Else
                            result = extractData(elm, type)
                    End Select
                End If
            End If
        End If

        Return result
    End Function

    Private Function extractData(ByVal ele As GeckoHtmlElement, ByVal attribute As String) As String
        Dim result = String.Empty

        If ele IsNot Nothing Then
            Dim tmp = ele.GetAttribute(attribute)
            If tmp IsNot Nothing Then result = tmp.Trim()
        End If

        Return result
    End Function


    'test

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
        Dim element As GeckoHtmlElement = Nothing
        Dim geckoDomElement = doc.DocumentElement

        If TypeOf geckoDomElement Is GeckoHtmlElement Then
            element = CType(geckoDomElement, GeckoHtmlElement)
            result = element.InnerHtml
        End If

        Return result
    End Function


End Class