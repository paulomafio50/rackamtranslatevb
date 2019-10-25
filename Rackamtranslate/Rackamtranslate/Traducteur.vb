
Imports Gecko
Imports Gecko.DOM



Public Class Traducteur


    Private Sub Traducteur_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Me.ComboBox1.Items.Count > 0 Then
            Me.ComboBox1.SelectedIndex = 0
        End If
        GeckoWebBrowser1.Navigate("https://www.deepl.com/translator")

        Try
            Dim line = Returnrichbox.Lines(Me.NumericUpDown1.Value - 1)
            Me.Textsource.Text = line
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Configcombobox()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Visible = False
    End Sub






    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

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
        Try
            Me.NumericUpDown1.Value = 1
            Dim count = Returnrichbox.lines.Length - 1
            Me.NumericUpDown1.Maximum = count

        Catch ex As Exception

        End Try

        Try
            Dim line = Returnrichbox.Lines(Me.NumericUpDown1.Value - 1)
            Me.Textsource.Text = line
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Buttonok_Click(sender As Object, e As EventArgs) Handles Buttonok.Click
        Me.ButtonTraduire.Visible = True

        Select Case Me.ComboBoxtraducteur.Text
            Case "Deepl"
                GeckoWebBrowser1.Navigate("https://www.deepl.com/translator#" & ComboBoxLangsource.Text & "/" & ComboBoxLangtarget.Text & "/" & Me.Textsource.Text)
            Case "Google"
                GeckoWebBrowser1.Navigate("https://translate.google.com/#view=home&op=translate&sl=" & ComboBoxLangsource.Text & "&tl=" & ComboBoxLangtarget.Text & "&text=" & Me.Textsource.Text)
            Case "Yandex"
                GeckoWebBrowser1.Navigate("https://translate.yandex.com/?lang=" & ComboBoxLangsource.Text & "-" & ComboBoxLangtarget.Text & "&text=" & Me.Textsource.Text)
        End Select



    End Sub
    Private Sub Configcombobox()

        'combobox traducteur
        Me.ComboBoxtraducteur.Items.Clear()
        Me.ComboBoxtraducteur.Items.Add("Deepl")
        'Me.ComboBoxtraducteur.Items.Add("Google")
        'Me.ComboBoxtraducteur.Items.Add("Yandex")
        Me.ComboBoxtraducteur.Text = "Deepl"
        'combobox Langsource
        If Me.ComboBoxtraducteur.Text = "Deepl" Then
            Me.ComboBoxLangsource.Items.Clear()
            Me.ComboBoxLangsource.Items.Add("en")
            Me.ComboBoxLangsource.Items.Add("fr")
            Me.ComboBoxLangsource.Items.Add("de")
            Me.ComboBoxLangsource.Items.Add("es")
            Me.ComboBoxLangsource.Items.Add("pt")
            Me.ComboBoxLangsource.Items.Add("it")
            Me.ComboBoxLangsource.Items.Add("nl")
            Me.ComboBoxLangsource.Items.Add("pl")
            Me.ComboBoxLangsource.Items.Add("ru")
            Me.ComboBoxLangsource.Text = "en"
            'combobox Langsource
            Me.ComboBoxLangtarget.Items.Clear()
            Me.ComboBoxLangtarget.Items.Add("en")
            Me.ComboBoxLangtarget.Items.Add("fr")
            Me.ComboBoxLangtarget.Items.Add("de")
            Me.ComboBoxLangtarget.Items.Add("es")
            Me.ComboBoxLangtarget.Items.Add("pt")
            Me.ComboBoxLangtarget.Items.Add("it")
            Me.ComboBoxLangtarget.Items.Add("nl")
            Me.ComboBoxLangtarget.Items.Add("pl")
            Me.ComboBoxLangtarget.Items.Add("ru")
            Me.ComboBoxLangtarget.Text = "fr"
        End If
    End Sub




    Private Sub WaitBrowser(ByVal wb As Gecko.GeckoWebBrowser)
        While wb.IsBusy

            Application.DoEvents()
            System.Threading.Thread.Sleep(2000)
        End While

    End Sub

    Private Sub ButtonTraduire_Click(sender As Object, e As EventArgs) Handles ButtonTraduire.Click
        ButtonTraduire.Enabled = False
        Timer1.Start()
        Dim text = Extract("/html/body/div[2]/div[1]/div[1]/div[3]/div[3]/div[1]/textarea", "text")




        WaitBrowser(GeckoWebBrowser1)


        Select Case Me.ComboBoxtraducteur.Text
            Case "Deepl"
                text = Extract("/html/body/div[2]/div[1]/div[1]/div[3]/div[3]/div[1]/textarea", "text")
            Case "Google"
                text = Extract("/html/body/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/div[3]/div[1]/div[2]/div/span[1]/span", "text")
            Case "Yandex"
                text = Extract("/html/body/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]", "text")
        End Select

        If text <> "" Then

            Dim lines() As String = Returnrichbox.Lines
            lines(Me.NumericUpDown1.Value - 1) = text
            Returnrichbox.Lines = lines
            Me.NumericUpDown1.Value += 1
            Select Case Me.ComboBoxtraducteur.Text
                Case "Deepl"
                    GeckoWebBrowser1.Navigate("https://www.deepl.com/translator#" & ComboBoxLangsource.Text & "/" & ComboBoxLangtarget.Text & "/" & Me.Textsource.Text)
                Case "Google"
                    GeckoWebBrowser1.Navigate("https://translate.google.com/#view=home&op=translate&sl=" & ComboBoxLangsource.Text & "&tl=" & ComboBoxLangtarget.Text & "&text=" & Me.Textsource.Text)
                Case "Yandex"
                    GeckoWebBrowser1.Navigate("https://translate.yandex.com/?lang=" & ComboBoxLangsource.Text & "-" & ComboBoxLangtarget.Text & "&text=" & Me.Textsource.Text)
            End Select
            WaitBrowser(GeckoWebBrowser1)

        End If

    End Sub

    Private Sub Traducteur_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        ButtonTraduire.Enabled = True
    End Sub

    Private Sub ComboBoxtraducteur_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxtraducteur.SelectedIndexChanged
        Select Case Me.ComboBoxtraducteur.Text
            Case "Deepl"
                Me.ComboBoxLangsource.Items.Clear()
                Me.ComboBoxLangsource.Items.Add("en")
                Me.ComboBoxLangsource.Items.Add("fr")
                Me.ComboBoxLangsource.Items.Add("de")
                Me.ComboBoxLangsource.Items.Add("es")
                Me.ComboBoxLangsource.Items.Add("pt")
                Me.ComboBoxLangsource.Items.Add("it")
                Me.ComboBoxLangsource.Items.Add("nl")
                Me.ComboBoxLangsource.Items.Add("pl")
                Me.ComboBoxLangsource.Items.Add("ru")
                Me.ComboBoxLangsource.Text = "en"
                'combobox Langsource
                Me.ComboBoxLangtarget.Items.Clear()
                Me.ComboBoxLangtarget.Items.Add("en")
                Me.ComboBoxLangtarget.Items.Add("fr")
                Me.ComboBoxLangtarget.Items.Add("de")
                Me.ComboBoxLangtarget.Items.Add("es")
                Me.ComboBoxLangtarget.Items.Add("pt")
                Me.ComboBoxLangtarget.Items.Add("it")
                Me.ComboBoxLangtarget.Items.Add("nl")
                Me.ComboBoxLangtarget.Items.Add("pl")
                Me.ComboBoxLangtarget.Items.Add("ru")
                Me.ComboBoxLangtarget.Text = "fr"
            Case "Google"
                Me.ComboBoxLangsource.Items.Clear()
                Me.ComboBoxLangsource.Items.Add("en")
                Me.ComboBoxLangsource.Items.Add("fr")
                Me.ComboBoxLangsource.Items.Add("de")
                Me.ComboBoxLangsource.Items.Add("es")
                Me.ComboBoxLangsource.Items.Add("pt")
                Me.ComboBoxLangsource.Items.Add("it")
                Me.ComboBoxLangsource.Items.Add("nl")
                Me.ComboBoxLangsource.Items.Add("pl")
                Me.ComboBoxLangsource.Items.Add("ru")
                Me.ComboBoxLangsource.Text = "en"
                'combobox Langsource
                Me.ComboBoxLangtarget.Items.Clear()
                Me.ComboBoxLangtarget.Items.Add("en")
                Me.ComboBoxLangtarget.Items.Add("fr")
                Me.ComboBoxLangtarget.Items.Add("de")
                Me.ComboBoxLangtarget.Items.Add("es")
                Me.ComboBoxLangtarget.Items.Add("pt")
                Me.ComboBoxLangtarget.Items.Add("it")
                Me.ComboBoxLangtarget.Items.Add("nl")
                Me.ComboBoxLangtarget.Items.Add("pl")
                Me.ComboBoxLangtarget.Items.Add("ru")
                Me.ComboBoxLangtarget.Text = "fr"
            Case "Yandex"
                Me.ComboBoxLangsource.Items.Clear()
                Me.ComboBoxLangsource.Items.Add("en")
                Me.ComboBoxLangsource.Items.Add("fr")
                Me.ComboBoxLangsource.Items.Add("de")
                Me.ComboBoxLangsource.Items.Add("es")
                Me.ComboBoxLangsource.Items.Add("pt")
                Me.ComboBoxLangsource.Items.Add("it")
                Me.ComboBoxLangsource.Items.Add("nl")
                Me.ComboBoxLangsource.Items.Add("pl")
                Me.ComboBoxLangsource.Items.Add("ru")
                Me.ComboBoxLangsource.Text = "en"
                'combobox Langsource
                Me.ComboBoxLangtarget.Items.Clear()
                Me.ComboBoxLangtarget.Items.Add("en")
                Me.ComboBoxLangtarget.Items.Add("fr")
                Me.ComboBoxLangtarget.Items.Add("de")
                Me.ComboBoxLangtarget.Items.Add("es")
                Me.ComboBoxLangtarget.Items.Add("pt")
                Me.ComboBoxLangtarget.Items.Add("it")
                Me.ComboBoxLangtarget.Items.Add("nl")
                Me.ComboBoxLangtarget.Items.Add("pl")
                Me.ComboBoxLangtarget.Items.Add("ru")
                Me.ComboBoxLangtarget.Text = "fr"
        End Select

    End Sub
End Class