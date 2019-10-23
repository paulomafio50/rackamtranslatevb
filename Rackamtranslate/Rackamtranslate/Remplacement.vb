Imports System.ComponentModel

Public Class Remplacement
    Private Sub Buttonadd_Click(sender As Object, e As EventArgs) Handles Buttonadd.Click
        If TextBoxremp1.Text = "" Then
            MsgBox("First box empty")
        Else
            If TextBoxremp2.Text = "" Then
                MsgBox("Second box empty")
            Else
                Dim S() As String = Split(TextBoxremp1.Text & "¤:¤" & TextBoxremp2.Text, "¤:¤")
                Dim I As New ListViewItem With {
                .Text = S(0)
            }
                I.SubItems.Add(S(1))
                ListView1.Items.Add(I)

                'remove doublon
                For H = 0 To ListView1.Items.Count - 2
                    For j = H + 1 To ListView1.Items.Count - 1
                        If ListView1.Items(H).Text = ListView1.Items(j).Text Then
                            ListView1.Items(H).Remove()
                        End If
                    Next
                Next
                'sauvegarde listview
                Dim bf As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()

                Using fs As New System.IO.FileStream("savelistR.txt", IO.FileMode.Create)
                    bf.Serialize(fs, New ArrayList(ListView1.Items))
                End Using
            End If
        End If
        ListView1.Refresh()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

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

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Remplacement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sauvegarde listview
        Try
            Dim bf As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
            Using fs As New System.IO.FileStream("savelistR.txt", IO.FileMode.Open)
                ListView1.Items.AddRange(bf.Deserialize(fs).ToArray(GetType(ListViewItem)))
            End Using
        Catch ex As Exception

        End Try



    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim i As Integer

        If ListView1.SelectedItems.Count = 0 Then
            MsgBox(My.Resources.Globalstrings.Messagelistview1, vbYes, "Erreur")
            'Sinon, on récupère le numéro de ligne
        Else
            If ListView1.SelectedItems.Count > 0 Then
                i = ListView1.SelectedIndices(0)



                ListView1.Items.RemoveAt(i)


            End If
        End If
        Dim bf As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        Using fs As New System.IO.FileStream("savelistR.txt", IO.FileMode.Create)
            bf.Serialize(fs, New ArrayList(ListView1.Items))
        End Using
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        ListView1.Clear()
        Dim bf As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        Using fs As New System.IO.FileStream("savelistR.txt", IO.FileMode.Create)
            bf.Serialize(fs, New ArrayList(ListView1.Items))
        End Using
    End Sub
End Class