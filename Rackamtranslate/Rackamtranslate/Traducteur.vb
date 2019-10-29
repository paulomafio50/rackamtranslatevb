
Imports Gecko
Imports Gecko.DOM



Public Class Traducteur


    Private Sub Traducteur_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Me.ComboBox1.Items.Count > 0 Then
            Me.ComboBox1.SelectedIndex = 0
        End If
        Select Case ComboBoxtraducteur.Text
            Case "Deepl"
                GeckoWebBrowser1.Navigate("https://www.deepl.com/translator")
            Case "Google"
                GeckoWebBrowser1.Navigate("https://translate.google.com")
            Case "Yandex"
                GeckoWebBrowser1.Navigate("https://translate.yandex.com")
        End Select


        Try
            Dim line = Returnrichbox.Lines(Me.NumericUpDown1.Value - 1)
            Me.Textsource.Text = line
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


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
                GeckoWebBrowser1.Navigate("https://www.deepl.com/translator#" & Lang(ComboBoxLangsourceDeepl.Text) & "/" & Lang(ComboBoxLangtargetDeepl.Text) & "/" & Textsource.Text)
            Case "Google"
                GeckoWebBrowser1.Navigate("https://translate.google.com/#view=home&op=translate&sl=" & Lang(ComboBoxLangsourceGog.Text) & "&tl=" & Lang(ComboBoxLangtargetGog.Text) & "&text=" & Textsource.Text)
            Case "Yandex"
                GeckoWebBrowser1.Navigate("https://translate.yandex.com/?lang=" & Lang(ComboBoxLangsourceYand.Text) & "-" & Lang(ComboBoxLangtargetYand.Text) & "&text=" & Textsource.Text)
        End Select



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
                text = Extract("/html/body/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/div[3]/div[1]/div[2]/div", "text")
            Case "Yandex"
                text = Extract("/html/body/div[2]/div[2]/div[2]/div[2]/div/pre/span", "text")
        End Select

        If text <> "" Then

            Dim lines() As String = Returnrichbox.Lines
            lines(Me.NumericUpDown1.Value - 1) = text
            Returnrichbox.Lines = lines
            Me.NumericUpDown1.Value += 1
            Select Case Me.ComboBoxtraducteur.Text
                Case "Deepl"
                    GeckoWebBrowser1.Navigate("https://www.deepl.com/translator#" & Lang(ComboBoxLangsourceDeepl.Text) & "/" & Lang(ComboBoxLangtargetDeepl.Text) & "/" & Textsource.Text)
                Case "Google"
                    GeckoWebBrowser1.Navigate("https://translate.google.com/#view=home&op=translate&sl=" & Lang(ComboBoxLangsourceGog.Text) & "&tl=" & Lang(ComboBoxLangtargetGog.Text) & "&text=" & Textsource.Text)
                Case "Yandex"
                    GeckoWebBrowser1.Navigate("https://translate.yandex.com/?lang=" & Lang(ComboBoxLangsourceYand.Text) & "-" & Lang(ComboBoxLangtargetYand.Text) & "&text=" & Textsource.Text)
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
                GeckoWebBrowser1.Navigate("https://www.deepl.com/translator")
                Me.ComboBoxLangsourceDeepl.Visible = True
                Me.ComboBoxLangtargetDeepl.Visible = True
                Me.ComboBoxLangsourceGog.Visible = False
                Me.ComboBoxLangtargetGog.Visible = False
                Me.ComboBoxLangsourceYand.Visible = False
                Me.ComboBoxLangtargetYand.Visible = False
            Case "Google"
                GeckoWebBrowser1.Navigate("https://translate.google.com")
                Me.ComboBoxLangsourceDeepl.Visible = False
                Me.ComboBoxLangtargetDeepl.Visible = False
                Me.ComboBoxLangsourceGog.Visible = True
                Me.ComboBoxLangtargetGog.Visible = True
                Me.ComboBoxLangsourceYand.Visible = False
                Me.ComboBoxLangtargetYand.Visible = False
                'combobox Langsource

            Case "Yandex"
                GeckoWebBrowser1.Navigate("https://translate.yandex.com/")
                Me.ComboBoxLangsourceDeepl.Visible = False
                Me.ComboBoxLangtargetDeepl.Visible = False
                Me.ComboBoxLangsourceGog.Visible = False
                Me.ComboBoxLangtargetGog.Visible = False
                Me.ComboBoxLangsourceYand.Visible = True
                Me.ComboBoxLangtargetYand.Visible = True
        End Select

    End Sub
    Public Function Lang(ByVal Source As String) As String
        Select Case Source
            Case "Afrikaans"
                Lang = "af"
            Case "Albanian"
                Lang = "sq"
            Case "Amharic"
                Lang = "am"
            Case "Arabic"
                Lang = "ar"
            Case "Armenian"
                Lang = "hy"
            Case "Azerbaijani"
                Lang = "az"
            Case "Basque"
                Lang = "eu"
            Case "Belarusian"
                Lang = "be"
            Case "Bengah"
                Lang = "bn"
            Case "Bosnian"
                Lang = "bs"
            Case "Bulgarian"
                Lang = "bg"
            Case "Catalan"
                Lang = "ca"
            Case "Cebuano"
                Lang = "ceb"
            Case "Chichewa"
                Lang = "ny"
            Case "Chinese"
                Lang = "zh-CN"
            Case "Corsican"
                Lang = "co"
            Case "Croatian"
                Lang = "hr"
            Case "Czech"
                Lang = "cs"
            Case "Danish"
                Lang = "da"
            Case "Dutch"
                Lang = "nl"
            Case "English"
                Lang = "en"
            Case "Esperanto"
                Lang = "eo"
            Case "Estonian"
                Lang = "et"
            Case "Filipino"
                Lang = "tl"
            Case "Finnish"
                Lang = "fi"
            Case "French"
                Lang = "fr"
            Case "Frisian"
                Lang = "fy"
            Case "Galician"
                Lang = "gl"
            Case "Georgian"
                Lang = "ka"
            Case "German"
                Lang = "de"
            Case "Greek"
                Lang = "el"
            Case "Gujarati"
                Lang = "gu"
            Case "Haitian Creole"
                Lang = "ht"
            Case "Hausa"
                Lang = "ha"
            Case "Hawaiian"
                Lang = "haw"
            Case "Hebrew"
                Lang = "iw"
            Case "Hindi"
                Lang = "hi"
            Case "Hmong"
                Lang = "hmn"
            Case "Hunganan"
                Lang = "hu"
            Case "Icelandic"
                Lang = "is"
            Case "lgbo"
                Lang = "ig"
            Case "Indonesian"
                Lang = "id"
            Case "Irish"
                Lang = "ga"
            Case "Italian"
                Lang = "it"
            Case "Japanese"
                Lang = "ja"
            Case "Javanese"
                Lang = "jw"
            Case "Kannada"
                Lang = "kn"
            Case "Kazakh"
                Lang = "kk"
            Case "Khmer"
                Lang = "km"
            Case "Korean"
                Lang = "ko"
            Case "Kurdish(Kurmanji)"
                Lang = "ku"
            Case "Kyrgyz"
                Lang = "ky"
            Case "Lao"
                Lang = "lo"
            Case "Latin"
                Lang = "la"
            Case "Latvian"
                Lang = "lv"
            Case "Lithuanian"
                Lang = "lt"
            Case "Luxembourgish"
                Lang = "lb"
            Case "Macedonian"
                Lang = "mk"
            Case "Malagasy"
                Lang = "mg"
            Case "Malay"
                Lang = "ms"
            Case "Malayalam"
                Lang = "ml"
            Case "Maltese"
                Lang = "mt"
            Case "Maori"
                Lang = "mi"
            Case "Marathi"
                Lang = "mr"
            Case "Mongolian"
                Lang = "mn"
            Case "Myanmar(Burmese)"
                Lang = "my"
            Case "Nepali"
                Lang = "ne"
            Case "Norwegian"
                Lang = "no"
            Case "Pashto"
                Lang = "ps"
            Case "Persian"
                Lang = "fa"
            Case "Polish"
                Lang = "pl"
            Case "Portuguese"
                Lang = "pt"
            Case "Punjabi"
                Lang = "pa"
            Case "Romanian"
                Lang = "ro"
            Case "Russian"
                Lang = "ru"
            Case "Samoan"
                Lang = "sm"
            Case "Scots Gaelic"
                Lang = "gd"
            Case "Serbian"
                Lang = "sr"
            Case "Sesotho"
                Lang = "st"
            Case "Shona"
                Lang = "sn"
            Case "Sindhi"
                Lang = "sd"
            Case "Sinhala"
                Lang = "si"
            Case "Slovak"
                Lang = "sk"
            Case "Slovenian"
                Lang = "sl"
            Case "Somali"
                Lang = "so"
            Case "Spanish"
                Lang = "es"
            Case "Sundanese"
                Lang = "su"
            Case "Swahili"
                Lang = "sw"
            Case "Swedish"
                Lang = "sv"
            Case "Tajik"
                Lang = "tg"
            Case "Tamil"
                Lang = "ta"
            Case "Telugu"
                Lang = "te"
            Case "Thai"
                Lang = "th"
            Case "Turkish"
                Lang = "tr"
            Case "Ukrainian"
                Lang = "uk"
            Case "Urdu"
                Lang = "ur"
            Case "Uzbek"
                Lang = "uz"
            Case "Vietnamese"
                Lang = "vi"
            Case "Welsh"
                Lang = "cy"
            Case "Xhosa"
                Lang = "xh"
            Case "Yiddish"
                Lang = "yi"
            Case "Yoruba"
                Lang = "yo"
            Case "Zulu"
                Lang = "zu"
            Case Else
                Lang = ""
        End Select

        Return Lang

    End Function
End Class