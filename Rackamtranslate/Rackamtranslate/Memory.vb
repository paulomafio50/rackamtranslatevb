Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Text


Public Class Memory
    Public Output As New StringBuilder
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click

    End Sub

    Private Sub FilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilesToolStripMenuItem.Click


        OpenFileDialog1.Filter = "fichier rpy ou txt|*.rpy;*.txt"
        Dim nomfichier As String
        Dim chemin As String
        If OpenFileDialog1.ShowDialog() = 1 Then

            For x = 0 To OpenFileDialog1.FileNames.Count - 1
                nomfichier = Path.GetFileName(OpenFileDialog1.FileName)
                chemin = Path.GetDirectoryName(OpenFileDialog1.FileName) + "\"

                Creationtab(nomfichier, chemin)

            Next
        End If

    End Sub
    Private Sub FolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FolderToolStripMenuItem.Click
        Me.FolderBrowserDialog1.ShowDialog()
        ListFiles(Me.FolderBrowserDialog1.SelectedPath)
    End Sub
    Public Sub ListFiles(ByVal [path] As String)
        If path = "" Then
            Exit Sub
        Else
            Dim DirInfo As New DirectoryInfo(path)
            Dim FileObj As IO.FileSystemInfo


            For Each FileObj In DirInfo.GetFileSystemInfos
                If FileObj.Attributes = FileAttributes.Directory Then
                    ListFiles(FileObj.FullName)
                Else
                    If FileObj.Extension = ".rpy" Then


                        Creationtab(FileObj.Name, path & "\")
                    End If
                    If FileObj.Extension = ".txt" Then


                        Creationtab(FileObj.Name, path & "\")
                    End If
                End If
            Next
        End If
    End Sub
    Public Sub Creationtab(ByVal nom As String, ByVal Chemin As String)

        Dim x As Integer
        x = Me.ListView1.Items.Count

        Me.ListView1.Items.Add(Chemin)
        ListView1.Items(x).SubItems.Add(nom)
        'creation du nouveau onglet


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Integer
        Dim b As Integer
        Dim z As Integer

        x = Me.ListView1.Items.Count
        Dim MRT As New StringBuilder
        For Each item As ListViewItem In ListView1.Items

            MRT.Append(IO.File.ReadAllText(item.Text & ListView1.Items(b).SubItems(1).Text))
            b += 1
        Next

        Dim txt As String




        Dim compteur As Integer = 0

        'For Each texbox In dynamicTxtlist

        '    nbl += texbox.Lines.Count
        'Next texbox
        'Invoke(New MethodInvoker(Sub() Chargement.ProgressBar1.Maximum = nbl))










        'Search your RichTextBox.Text line by line (Use String.Split instead of Regex to get the lines. This will prevent blank lines occuring in the results.)

        Dim Lines() As String = MRT.ToString.Split(Environment.NewLine)

        For Each Line As String In Lines

            'If this line contains any of the SI values you want to replace

            Dim regex As Regex = New Regex(TextBoxRegex.Text)
            Dim match As Match = regex.Match(Line)
            If match.Success Then
                z = Me.ListView2.Items.Count
                txt = match.Value
                If compteur = 0 Then

                    Me.ListView2.Items.Add(txt)
                    compteur = 1
                Else
                    ListView2.Items(z - 1).SubItems.Add(txt)
                    compteur = 0

                End If
            End If




        Next Line

        'Replace the RichTextBox.Text with the Stringbuilder output









    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.Filter = " files (*.mem)|*.mem"
        SaveFileDialog1.ShowDialog()
    End Sub
    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Dim FileToSaveAs As String = SaveFileDialog1.FileName
        Dim bf As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        Using fs As New System.IO.FileStream(FileToSaveAs, IO.FileMode.Create)
            bf.Serialize(fs, New ArrayList(ListView2.Items))
        End Using

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim fileName As String
        Dim openFileDialog1 As OpenFileDialog = New OpenFileDialog With {
            .Multiselect = False,
            .FileName = String.Empty,
            .Filter = "mem files (*.mem)|*.mem",
            .FilterIndex = 1,
            .RestoreDirectory = True
        }

        If openFileDialog1.ShowDialog() = DialogResult.OK Then

            Try
                fileName = openFileDialog1.FileName
                Dim bf As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
                Using fs As New System.IO.FileStream(fileName, IO.FileMode.Open)
                    ListView2.Items.AddRange(bf.Deserialize(fs).ToArray(GetType(ListViewItem)))
                End Using



            Catch ex As Exception
                MessageBox.Show("Une erreur est survenue lors de l'ouverture du fichier : {0}.", ex.Message)
            End Try

        End If

        openFileDialog1.Dispose()

    End Sub



End Class