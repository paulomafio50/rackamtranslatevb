
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


        'Dim elms As GeckoNodeCollection = GeckoWebBrowser1.Document.GetElementsByClassName("lmt__target_toolbar__copy").
        '    GeckoWebBrowser1.Navigate("javascript:void( document.getElementById( 'idOfElement' ).click() ) ");
        'elms.Item(1).c
        'For Each btn As GeckoHtmlElement In elms


        '    ListBox1.Items.Add(btn.GetAttribute("copy"))

        'Next



        'Dim xpathResult As XPathResult = GeckoWebBrowser1.Document.EvaluateXPath("/html/body/div(2)/div(1)/div(1)/div(3)/div(3)/div(1)")
        'Dim foundNodes = xpathResult.GetNodes()
        '
        '    For Each node In foundNodes
        '        Dim x = node.TextContent
        '        Dim element As GeckoHtmlElement = TryCast(node, GeckoHtmlElement)
        '        Dim inner As String = element.InnerHtml
        '        Dim outer As String = element.OuterHtml
        '
        '
        '    Next
        '
        '
        '
        '    Dim textetarget As XPathResult = GeckoWebBrowser1.DomDocument.EvaluateXPath("/html/body/div[2]/div[1]/div[1]/div[3]/div[3]/div[1]")


        'test alex

        Dim text As String = GeckoWebBrowser1.DomDocument.GetElementsByClassName("lmt__inner_textarea_container").ToString

        Label4.Text = text





        'Dim capture As GeckoNodeCollection = GeckoWebBrowser1.Document.GetElementsByClassName("lmt__inner_textarea_container")

        'For Each item In capture

        '    TextBox2.Text += item.TextContent

        'Next






        'Dim elm As XPathResult
        'Dim wb As GeckoWebBrowser = GeckoWebBrowser1
        'Dim df As String
        'Dim doc As HtmlAgilityPack.HtmlDocument
        'elm = GeckoWebBrowser1.Document.EvaluateXPath("/html/body/div[2]/div[1]/div[1]/div[3]/div[3]/div[1]/div/span[1]")
        'Dim foundNodes = elm.GetNodes
        'MessageBox.Show(foundNodes.ToString)







        'TextBox2.Clear()





        'Dim source As String = GeckoWebBrowser1.Document.GetElementsByTagName("html")(0).InnerHtml

        'Dim compteur As Integer = 0



        'TextBox2.Text = source

        'Dim value As String = TextBox2.Text

        '' Invoke the Match method.
        'Dim m As Match = Regex.Match(value,
        '                 "(lmt__translations_as_text__text_btn)(.+)(</button>)(.+)(</button>)(.+)(</button>)(.+)(</button>)(.+)(</button>)(.+)(</button>)(.+)(</button>)(.+)",
        '                 RegexOptions.IgnoreCase)

        '' If successful, write the group.
        'If (m.Success) Then
        '    Dim key As String = m.Groups(2).Value
        '    MsgBox(key)
        'End If


        'Dim xpathResult As XPathResult = GeckoWebBrowser1.Document.EvaluateXPath("/html/body/div[2]/div[1]/div[1]/div[3]/div[3]/div[1]/div")
        'Dim foundNodes = xpathResult.GetNodes()

        'For Each node In foundNodes
        '    Dim x = node.TextContent
        '    Dim element As GeckoHtmlElement = TryCast(node, GeckoHtmlElement)
        '    Dim inner As String = element.InnerHtml
        '    Dim outer As String = element.OuterHtml

        '    For Each child In node.ChildNodes
        '    Next
        'Next

        'Dim htmlElementById As GeckoHtmlElement = _browser.Document.GetHtmlElementById("mw-content-text")
        'Dim byTag As GeckoElementCollection = _browser.Document.GetElementsByTagName("input")

        'For Each ele In byTag
        '    Dim y = ele.GetAttribute("value")
        'Next

        'Dim byClass = _browser.Document.GetElementsByClassName("input")

        'For Each node In byClass
        'Next

        'Dim username = (CType(_browser.Document.GetHtmlElementById("yourUsername"), GeckoInputElement)).Value
        'Dim button = New GeckoButtonElement(_browser.Document.GetElementById("myBtn").DomObject)




        'Dim fin2 As String

        '    Dim fin As String
        '    fin = Regex.Replace(TextBox2.Text, "(lmt__translations_as_text__text_btn)(.+)(</button>)(.+)(</button>)(.+)(</button>)(.+)(</button>)(.+)(</button>)(.+)(</button>)", "$2")
        '    fin2 = fin
        '    TextBox2.Text = fin2
        '    MsgBox(fin2)




        '    Dim EvaluateJavaScriptResult As Object
        '    Dim frame = _browser.GetMainFrame()
        '    Dim task = frame.EvaluateScriptAsync("(Function() { Return getElementsByClassName('lmt__inner_textarea_container')[1].innerText; })();", Nothing)

        '    MessageBox.Show(task.ToString)

        '    task.ContinueWith(Function(t)


        '                          If Not t.IsFaulted Then
        '                              Dim response = t.Result

        '                              EvaluateJavaScriptResult = If(response.Success, (If(response.Result, "null")), response.Message)
        '                              MessageBox.Show(EvaluateJavaScriptResult.ToString())
        '                          End If
        '                      End Function, TaskScheduler.FromCurrentSynchronizationContext())
    End Sub

        Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
            Dim DerniereTrouve As String = ""


            If Clipboard.ContainsText Then

                DerniereTrouve = Clipboard.GetText




                Clipboard.Clear()
                MsgBox(DerniereTrouve)
            End If
        End Sub
    End Class