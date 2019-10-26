Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text
Imports System.Text.RegularExpressions

Public Class Chargement2
    Public dynamicTxtlist As New List(Of TextBox)
    Dim filePath As String = ""
    Dim Selectionneur As String = ""

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If BackgroundWorker1.IsBusy Then
            If BackgroundWorker1.WorkerSupportsCancellation Then
                BackgroundWorker1.CancelAsync()
            End If
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork


        Try
            Select Case Selectionneur

                Case = "OMT"
                    MT.ListView2.Clear()
                    Dim FS As FileStream = File.Open(filePath, FileMode.Open)
                    Dim BinFmtr As New BinaryFormatter
                    Dim alSavedLV As New ArrayList
                    alSavedLV = CType(BinFmtr.Deserialize(FS), ArrayList)
                    Dim lvi As ListViewItem
                    For item As Integer = 0 To alSavedLV.Count - 1
                        If BackgroundWorker1.CancellationPending Then
                            e.Cancel = True
                            Exit For
                        End If
                        lvi = New ListViewItem

                        lvi = CType(alSavedLV(item), ListViewItem)
                        BackgroundWorker1.ReportProgress(CInt((item / alSavedLV.Count) * 100))
                        UpdateLabel(Me.Statut, FormatPercent(item / alSavedLV.Count, 2))
                        Invoke(New MethodInvoker(Sub() MT.ListView2.Items.Add(lvi)))

                    Next
                    FS.Close()
                Case = "CMT"
                    Invoke(New MethodInvoker(Sub() MT.ListView2.Clear()))

                    Dim t As Integer = 0
                    Dim z As Integer = 0
                    Dim txt As String
                    Dim MRT As New StringBuilder
                    Dim compteur As Integer = 0


                    Dim regex As Regex = New Regex(Regexconfig.TextBoxRegexforMT.Text)
                    Dim match As Match


                    For Each texte As TextBox In dynamicTxtlist


                        Dim Lines() As String = dynamicTxtlist(t).Text.Split(Environment.NewLine)
                        t += 1

                        For Each Line As String In Lines

                            match = regex.Match(Line)
                            If match.Success Then

                                txt = match.Value
                                If compteur = 0 Then
                                    Invoke(New MethodInvoker(Sub() MT.ListView2.Items.Add(txt)))

                                    compteur = 1
                                Else
                                    Invoke(New MethodInvoker(Sub() MT.ListView2.Items(z).SubItems.Add(txt)))
                                    z += 1
                                    compteur = 0

                                End If
                            End If

                        Next Line

                    Next

                    'Dim bf As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
                    'Using fs As New System.IO.FileStream(filePath, IO.FileMode.Create)
                    '    bf.Serialize(fs, New ArrayList(MT.ListView2.Items))
                    'End Using




                    'Dim FS As FileStream = File.Create(filePath)

                    'Dim BinFmtr As New BinaryFormatter


                    'Dim alSavedLV As New ArrayList


                    'For item As Integer = 0 To MT.ListView2.Items.Count - 1


                    '    alSavedLV.Add(MT.ListView2.Items(item))

                    'Next



                    'BinFmtr.Serialize(FS, alSavedLV)



                    'FS.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show("Une erreur est survenue lors de l'ouverture du fichier : {0}.", ex.Message)
        End Try

    End Sub
    Delegate Sub SetLabelTextDelegat(ByVal [label] As Label, ByVal [text] As String)
    Private Sub UpdateLabel(ByVal [label] As Label, ByVal [text] As String)
        If [label].InvokeRequired Then
            Dim myDelegate As New SetLabelTextDelegat(AddressOf UpdateLabel)
            Me.Invoke(myDelegate, New Object() {[label], [text]})
        Else
            label.Text = [text]
        End If
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Me.ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If e.Cancelled Then
            Me.Statut.Text = "Cancelled"
            Delay(2)
            MT.Visible = True
            MT.ListView2.Clear()
            MT.Close()
            Principal.Visible = True
            Me.Close()
        Else
            Me.Statut.Text = "Complated"
            Delay(2)
            MT.Visible = True
            Principal.Visible = True
            MT.Activate()
            Me.Close()
        End If
    End Sub

    Public Sub OpenMTTool()




        Dim OpenFileDialogMT As OpenFileDialog = New OpenFileDialog With {
            .Filter = " files (*.mem)|*.mem"}



        If OpenFileDialogMT.ShowDialog() = DialogResult.OK Then
            Principal.Visible = False
            Me.Show()
            MT.Show()
            MT.Visible = False
            Selectionneur = "OMT"
            filePath = Path.GetFullPath(OpenFileDialogMT.FileName)

            BackgroundWorker1.RunWorkerAsync()
        Else
            Me.Visible = True

        End If




        OpenFileDialogMT.Dispose()
    End Sub
    Public Sub CreateMTTool()

        Dim SaveFileDialogMT As SaveFileDialog = New SaveFileDialog With {
            .Filter = " files (*.mem)|*.mem"
        }
        If Principal.ListView1.Items.Count > 0 Then



            If SaveFileDialogMT.ShowDialog = Windows.Forms.DialogResult.OK Then
                Principal.Visible = False
                Me.Show()
                MT.Show()
                'MT.Visible = False
                Selectionneur = "CMT"
                filePath = Path.GetFullPath(SaveFileDialogMT.FileName)

                BackgroundWorker1.RunWorkerAsync()




            End If
        Else
            MsgBox("open Files or folder before")

        End If
        SaveFileDialogMT.Dispose()
    End Sub
    Private Sub SerializeListViewData(LV As ListView, ByVal filename As String)

        '  Create a FileStream and get the file to write to.

        Dim FS As FileStream = File.Create(filename)

        '  Create a Binary Formatter for Serialization process

        Dim BinFmtr As New BinaryFormatter

        '  Create an arraylist as temp storage for listview items data

        Dim alSavedLV As New ArrayList



        '  Iterate through the ListView's listitem collection and add

        '  each to the temporary ArrayList

        For item As Integer = 0 To LV.Items.Count - 1

            '  Add next item/subitem to the arraylist

            alSavedLV.Add(LV.Items(item))

        Next



        '  Serialize the complete arraylist to the file

        '  The arraylist contains all the listview data

        BinFmtr.Serialize(FS, alSavedLV)



        '  Close the FileStream

        FS.Close()



    End Sub
End Class