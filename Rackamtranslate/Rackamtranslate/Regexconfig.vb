Imports System.Text.RegularExpressions
Imports System.Text



Public Class Regexconfig




    Private Sub ButtonRempav_Click(sender As Object, e As EventArgs) Handles ButtonRempav.Click

        Av1a()
        Av2a()

        ' TextBoxRegexav1.Text = TextBoxRegexav1.Text.Replace(TextBoxRegexrempav.Text, TextBoxRegexparav.Text)
        ' TextBoxRegexav2.Text = TextBoxRegexav2.Text.Replace(TextBoxRegexrempav.Text, TextBoxRegexparav.Text)
    End Sub

    Private Sub ButtonRestav_Click(sender As Object, e As EventArgs) Handles ButtonRestav.Click
        Av1b()
        Av2b()
        ' TextBoxRegexav1.Text = TextBoxRegexav1.Text.Replace(TextBoxRegexparav.Text, TextBoxRegexrempav.Text)
        '  TextBoxRegexav2.Text = TextBoxRegexav2.Text.Replace(TextBoxRegexparav.Text, TextBoxRegexrempav.Text)
    End Sub
    Sub Av1a()
        Dim t As Integer = 0

        For Each texbox In Principal.dynamicTxtlist
            Dim Output As New StringBuilder

            'Search your RichTextBox.Text line by line (Use String.Split instead of Regex to get the lines. This will prevent blank lines occuring in the results.)

            Dim Lines() As String = Principal.dynamicTxtlist(t).Text.Split(({vbCrLf, vbCr, vbLf}), StringSplitOptions.None)
            For Each Line As String In Lines
                'If this line contains any of the SI values you want to replace
                If Regex.IsMatch(Line, TextBoxRegexav1.Text) Then
                    'Create a link to the MatchConversion function that will allow you to apply logic when replacing search results

                    'Regex.Replace effectively splits the text using your searchpattern as the marker for each split


                    Principal.dynamicTxtlist(t).Text = Principal.dynamicTxtlist(t).Text.Replace(Line, (Line.Replace(TextBoxRegexrempav.Text, TextBoxRegexparav.Text)))
                    'If there are no SI Values in this row, then just add the row as is to the stringbuilder
                Else
                End If
            Next Line

            'Replace the RichTextBox.Text with the Stringbuilder output
            'Principal.dynamicTxtlist(t).Text = Output.ToString
            t += 1
        Next



        TextBoxRegexav1.Text = TextBoxRegexav1.Text.Replace(TextBoxRegexrempav.Text, TextBoxRegexparav.Text)

    End Sub
    Sub Av2a()
        Dim t As Integer = 0

        For Each texbox In Principal.dynamicTxtlist
            Dim Output As New StringBuilder

            'Search your RichTextBox.Text line by line (Use String.Split instead of Regex to get the lines. This will prevent blank lines occuring in the results.)

            Dim Lines() As String = Principal.dynamicTxtlist(t).Text.Split(({vbCrLf, vbCr, vbLf}), StringSplitOptions.None)
            For Each Line As String In Lines
                'If this line contains any of the SI values you want to replace
                If Regex.IsMatch(Line, TextBoxRegexav2.Text) Then
                    'Create a link to the MatchConversion function that will allow you to apply logic when replacing search results

                    'Regex.Replace effectively splits the text using your searchpattern as the marker for each split


                    Principal.dynamicTxtlist(t).Text = Principal.dynamicTxtlist(t).Text.Replace(Line, (Line.Replace(TextBoxRegexrempav.Text, TextBoxRegexparav.Text)))
                    'If there are no SI Values in this row, then just add the row as is to the stringbuilder
                Else
                End If
            Next Line

            'Replace the RichTextBox.Text with the Stringbuilder output
            'Principal.dynamicTxtlist(t).Text = Output.ToString
            t += 1
        Next



        TextBoxRegexav2.Text = TextBoxRegexav2.Text.Replace(TextBoxRegexrempav.Text, TextBoxRegexparav.Text)



    End Sub
    Sub Av1b()
        Dim t As Integer = 0

        For Each texbox In Principal.dynamicTxtlist
            Dim Output As New StringBuilder

            'Search your RichTextBox.Text line by line (Use String.Split instead of Regex to get the lines. This will prevent blank lines occuring in the results.)

            Dim Lines() As String = Principal.dynamicTxtlist(t).Text.Split(({vbCrLf, vbCr, vbLf}), StringSplitOptions.None)
            For Each Line As String In Lines
                'If this line contains any of the SI values you want to replace
                If Regex.IsMatch(Line, TextBoxRegexav1.Text) Then
                    'Create a link to the MatchConversion function that will allow you to apply logic when replacing search results

                    'Regex.Replace effectively splits the text using your searchpattern as the marker for each split


                    Principal.dynamicTxtlist(t).Text = Principal.dynamicTxtlist(t).Text.Replace(Line, (Line.Replace(TextBoxRegexparav.Text, TextBoxRegexrempav.Text)))
                    'If there are no SI Values in this row, then just add the row as is to the stringbuilder
                Else
                End If
            Next Line

            'Replace the RichTextBox.Text with the Stringbuilder output
            'Principal.dynamicTxtlist(t).Text = Output.ToString
            t += 1
        Next


        TextBoxRegexav1.Text = TextBoxRegexav1.Text.Replace(TextBoxRegexparav.Text, TextBoxRegexrempav.Text)




    End Sub
    Sub Av2b()
        Dim t As Integer = 0

        For Each texbox In Principal.dynamicTxtlist
            Dim Output As New StringBuilder

            'Search your RichTextBox.Text line by line (Use String.Split instead of Regex to get the lines. This will prevent blank lines occuring in the results.)

            Dim Lines() As String = Principal.dynamicTxtlist(t).Text.Split(({vbCrLf, vbCr, vbLf}), StringSplitOptions.None)
            For Each Line As String In Lines
                'If this line contains any of the SI values you want to replace
                If Regex.IsMatch(Line, TextBoxRegexav2.Text) Then
                    'Create a link to the MatchConversion function that will allow you to apply logic when replacing search results

                    'Regex.Replace effectively splits the text using your searchpattern as the marker for each split


                    Principal.dynamicTxtlist(t).Text = Principal.dynamicTxtlist(t).Text.Replace(Line, (Line.Replace(TextBoxRegexparav.Text, TextBoxRegexrempav.Text)))
                    'If there are no SI Values in this row, then just add the row as is to the stringbuilder
                Else
                End If
            Next Line

            'Replace the RichTextBox.Text with the Stringbuilder output
            'Principal.dynamicTxtlist(t).Text = Output.ToString
            t += 1
        Next
        TextBoxRegexav2.Text = TextBoxRegexav2.Text.Replace(TextBoxRegexparav.Text, TextBoxRegexrempav.Text)

    End Sub

    Private Sub Regexconfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class