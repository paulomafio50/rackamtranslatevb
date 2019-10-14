Public Class Remplacement
    Private Sub Buttonadd_Click(sender As Object, e As EventArgs) Handles Buttonadd.Click

        Dim x As Integer
        x = Me.ListView1.Items.Count
        Me.ListView1.Items.Add(TextBoxremp1.Text)
        ListView1.Items(x).SubItems.Add(TextBoxremp2.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Buttonremoveitemselct.Click

        Dim i As Integer

        If ListView1.SelectedItems.Count = 0 Then
            MsgBox("Vous devez sélectionner un élément pour pouvoir le supprimer !", vbYes, "Erreur")
            'Sinon, on récupère le numéro de ligne
        Else
            i = ListView1.SelectedIndices(0)


            ListView1.Items.RemoveAt(i)



        End If
    End Sub



    Private Sub Buttonapplyremp_Click(sender As Object, e As EventArgs) Handles Buttonapplyremp.Click
        Dim x As Integer = 0
        For Each item In Me.ListView1.Items

            For Each texbox In Principal.dynamicTxt2list

                texbox.Text = texbox.Text.Replace(ListView1.Items(x).Text, ListView1.Items(x).SubItems(1).Text)



            Next
            x += 1
        Next
    End Sub

    Private Sub Buttonrestoreremp_Click(sender As Object, e As EventArgs) Handles Buttonrestoreremp.Click
        Dim x As Integer = 0
        For Each item In Me.ListView1.Items

            For Each texbox In Principal.dynamicTxt2list

                texbox.Text = texbox.Text.Replace(ListView1.Items(x).SubItems(1).Text, ListView1.Items(x).Text)



            Next
            x += 1
        Next
    End Sub

End Class