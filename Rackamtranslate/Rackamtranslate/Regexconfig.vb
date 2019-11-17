Imports System.Text.RegularExpressions
Imports System.Text



Public Class Regexconfig




    Private Sub ButtonRempav_Click(sender As Object, e As EventArgs) Handles ButtonRempav.Click

        Dim t As Integer = 0



        For Each texbox In Principal.dynamicTxtlist



            Principal.dynamicTxtlist(t).Text = Regex.Replace(texbox.Text, TextBoxRegexrempav.Text, TextBoxRegexparav.Text, RegexOptions.IgnoreCase)



            t += 1
        Next


    End Sub

    Private Sub ButtonRestav_Click(sender As Object, e As EventArgs) Handles ButtonRestav.Click

        Dim t As Integer = 0



        For Each texbox In Principal.dynamicTxtlist

            Dim txt As String = texbox.Text

            Principal.dynamicTxtlist(t).Text = Regex.Replace(txt, TextBoxRegexparav.Text, TextBoxRegexrempav.Text, RegexOptions.IgnoreCase)



            t += 1
        Next

    End Sub

End Class