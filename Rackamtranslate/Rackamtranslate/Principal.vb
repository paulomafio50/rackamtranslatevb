Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Text
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.ComponentModel

Public Class Principal
    Public dynamicTxtlist As New List(Of TextBox)
    Public dynamicTxt2list As New List(Of RichTextBox)
    Public dynamicTxt3list As New List(Of TextBox)
    Public dynamicTxt4list As New List(Of TextBox)
    Public dynamicTablist As New List(Of TabPage)
    Public dynamicTab2list As New List(Of TabPage)
    Public dynamicTab3list As New List(Of TabPage)
    Public dynamicTab4list As New List(Of TabPage)
    Public Property CheckedListBoxfichierEXTENTIES As Object
    Dim filePath As String = ""
    Dim Selectionneur As String = ""

#Region "Ouverture de fichier"

    Private Sub FilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilesToolStripMenuItem.Click

        OpenFileDialog1.Filter = "fichier rpy ou txt|*.rpy;*.txt"
        Dim nomfichier As String
        Dim chemin As String
        If OpenFileDialog1.ShowDialog() = 1 Then
            Me.DecompilerToolStripMenuItem1.Visible = True
            For x = 0 To OpenFileDialog1.FileNames.Count - 1
                nomfichier = Path.GetFileName(OpenFileDialog1.FileName)
                chemin = Path.GetDirectoryName(OpenFileDialog1.FileName) + "\"

                Creationtab(nomfichier, chemin)

            Next

        End If


    End Sub
#End Region
#Region "Ouverture de Dossier"
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
            Me.DecompilerToolStripMenuItem1.Visible = True

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
#End Region
#Region "Decompilation"

    Private Sub DecompilerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DecompilerToolStripMenuItem1.Click

        If Regexconfig.TextBoxRegex.Text = "" Then
            MsgBox("regex empty")
            Regexconfig.Show()
            Exit Sub
        End If

        If ListView1.Items.Count > 0 Then

            Me.ListView1.Visible = False
                Me.TabControl1.Visible = False
                Me.TabControlMTCharg.Visible = True
                Me.TabControlMTCharg.SelectedIndex = 0
                Me.MenuStrip1.Visible = False
                Selectionneur = "DECOMP"

                BackgroundWorkerMT.RunWorkerAsync()


            End If
    End Sub


#End Region
#Region "Recompilation"

    Private Sub RecompilerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RecompilerToolStripMenuItem1.Click
        If Regexconfig.TextBoxRegex.Text = "" Then

            MsgBox("regex empty")
            Regexconfig.Show()
            Exit Sub
        End If
        If TabControl2.Visible = True Then

            Me.TabControl2.Visible = False
            Me.TabControlMTCharg.Visible = True
            Me.TabControlMTCharg.SelectedIndex = 0
            Me.MenuStrip1.Visible = False
            Selectionneur = "RECOMP"
            BackgroundWorkerMT.RunWorkerAsync()
        End If
    End Sub

#End Region
#Region "Dynamic creation Tab Textbox"

    Public Sub Creationtab(ByVal nom As String, ByVal Chemin As String)


        Dim x As Integer
        Dim dynamicTab As New TabPage
        Dim dynamicTxt As New TextBox
        Dim dynamicTab2 As New TabPage
        Dim dynamicTxt2 As New RichTextBox

        Dim dynamicTab3 As New TabPage
        Dim dynamicTxt3 As New TextBox
        Dim dynamicTab4 As New TabPage
        Dim dynamicTxt4 As New TextBox








        x = Me.ListView1.Items.Count

        Me.ListView1.Items.Add(Chemin)
        ListView1.Items(x).SubItems.Add(nom)
        'creation du nouveau onglet
        TabControl1.TabPages.Add(dynamicTab)
        TabControl2.TabPages.Add(dynamicTab2)
        TabControl3.TabPages.Add(dynamicTab3)
        TabControl3.TabPages.Add(dynamicTab4)
        'configuration du nouvel onglet
        dynamicTab.Name = "taborigine" & nom

        dynamicTab.Text = nom
        dynamicTab2.Name = "tabtrad" & nom
        dynamicTab2.Tag = nom

        dynamicTab2.Text = nom
        dynamicTab3.Name = "tabtraddebut" & nom
        dynamicTab3.Text = nom
        dynamicTab4.Name = "tabtradfin" & nom
        dynamicTab4.Text = nom
        'creation du nouveau textbox
        dynamicTab.Controls.Add(dynamicTxt)
        dynamicTab2.Controls.Add(dynamicTxt2)
        dynamicTab3.Controls.Add(dynamicTxt3)
        dynamicTab4.Controls.Add(dynamicTxt4)
        'Configuration du nouveau textbox
        dynamicTxt.Name = "textborigine" & nom
        dynamicTxt.Dock = DockStyle.Fill
        dynamicTxt.Multiline = True


        dynamicTxt.ScrollBars = ScrollBars.Both
        dynamicTxt.Text = IO.File.ReadAllText(Chemin + nom)

        dynamicTxt2.Name = "textbtrad" & nom
        dynamicTxt2.Dock = DockStyle.Fill
        dynamicTxt2.Tag = nom
        dynamicTxt2.Multiline = True


        dynamicTxt2.ScrollBars = ScrollBars.Both
        dynamicTxt3.Name = "textbtraddebut" & nom
        dynamicTxt3.Multiline = True
        dynamicTxt4.Name = "textbtradfin"
        dynamicTxt4.Multiline = True

        dynamicTxtlist.Add(dynamicTxt)
        dynamicTxt2list.Add(dynamicTxt2)
        dynamicTxt3list.Add(dynamicTxt3)
        dynamicTxt4list.Add(dynamicTxt4)
        dynamicTablist.Add(dynamicTab)
        dynamicTab2list.Add(dynamicTab2)
        dynamicTab3list.Add(dynamicTab3)
        dynamicTab4list.Add(dynamicTab4)
        Traducteur.ComboBox1.Items.Add(nom)
    End Sub
#End Region
#Region "Sauvegarde"

    Private Sub EnregistrerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrerToolStripMenuItem.Click
        If ListView1.Items.Count > 0 Then
            Dim a As Integer = 0
            For Each texbox In dynamicTxtlist

                IO.File.WriteAllText((ListView1.Items(a).Text & ListView1.Items(a).SubItems(1).Text), texbox.Text)
                a += 1

            Next
            MsgBox(My.Resources.Globalstrings.MessageSave)



        End If




    End Sub

    Private Sub EnregistrersousToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrersousToolStripMenuItem.Click
        MsgBox(My.Resources.Globalstrings.Messagelater)
        'Dim chemin As String
        'Dim position As Integer = ListView1.Items(1).Text.LastIndexOf("\")
        'MsgBox(position)

        'Dim chemifin As String

        'If ListView1.Items.Count > 0 Then
        '    Dim a As Integer = 0
        '    For Each texbox In dynamicTxtlist
        '        chemin = ListView1.Items(a).Text & ListView1.Items(a).SubItems(1).Text
        '        IO.File.WriteAllText((ListView1.Items(a).Text & ListView1.Items(a).SubItems(1).Text), texbox.Text)
        '        a += 1

        '    Next
        '    MsgBox(My.Resources.Globalstrings.MessageSave)



        'End If
    End Sub
#End Region
#Region "Supression objet tableau"




    Private Sub RemoveItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveItemToolStripMenuItem.Click
        Dim i As Integer

        If ListView1.SelectedItems.Count = 0 Then
            MsgBox(My.Resources.Globalstrings.Messagelistview1, vbYes, "Erreur")
            'Sinon, on récupère le numéro de ligne
        Else
            If ListView1.SelectedItems.Count > 0 Then
                i = ListView1.SelectedIndices(0)

                dynamicTxtlist(i).Dispose()
                dynamicTxtlist.RemoveAt(i)
                dynamicTxt2list(i).Dispose()
                dynamicTxt2list.RemoveAt(i)
                dynamicTxt3list(i).Dispose()
                dynamicTxt3list.RemoveAt(i)
                dynamicTxt4list(i).Dispose()
                dynamicTxt4list.RemoveAt(i)


                dynamicTablist(i).Dispose()
                dynamicTablist.RemoveAt(i)
                dynamicTab2list(i).Dispose()
                dynamicTab2list.RemoveAt(i)
                dynamicTab3list(i).Dispose()
                dynamicTab3list.RemoveAt(i)
                dynamicTab4list(i).Dispose()
                dynamicTab4list.RemoveAt(i)
                Traducteur.ComboBox1.Items.RemoveAt(i)

                ListView1.Items.RemoveAt(i)


            End If
        End If

        Exit Sub








    End Sub

    Private Sub RemoveAllItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveAllItemToolStripMenuItem.Click
        For i = 1 To ListView1.Items.Count

            ListView1.Items.RemoveAt(0)

        Next
        dynamicTxtlist.Clear()
        dynamicTxt2list.Clear()
        dynamicTxt3list.Clear()
        dynamicTxt4list.Clear()
        ListView1.Items.Clear()
        TabControl1.TabPages.Clear()
        TabControl2.TabPages.Clear()
        Traducteur.ComboBox1.Items.Clear()
    End Sub
#End Region
#Region "Options"

    Private Sub RegexToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles RegexToolStripMenuItem.Click
        Regexconfig.Show()
    End Sub



    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        Dim colors As DialogResult
        colors = ColorDialog1.ShowDialog()

        If colors = Windows.Forms.DialogResult.OK Then

            For Each textbox In dynamicTxt2list

                textbox.BackColor = ColorDialog1.Color
            Next
        End If
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Dim font As DialogResult
        font = FontDialog1.ShowDialog()

        If font = Windows.Forms.DialogResult.OK Then

            For Each textbox In dynamicTxt2list

                textbox.Font = FontDialog1.Font
            Next
        End If
        Dim fcolors As DialogResult
        fcolors = ColorDialog1.ShowDialog()

        If fcolors = Windows.Forms.DialogResult.OK Then

            For Each textbox In dynamicTxt2list

                textbox.ForeColor = ColorDialog1.Color
            Next
        End If
    End Sub
#End Region
#Region "Divers"

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub TraducteurToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TraducteurToolStripMenuItem1.Click

        Traducteur.Show()
        Traducteur.Visible = True
    End Sub

    Private Sub ReplaceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReplaceToolStripMenuItem.Click
        Remplacement.Show()
    End Sub
#End Region



    Private Sub CreateMTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateMTToolStripMenuItem.Click
        If TabControl1.Visible = False Then
            MsgBox("after recompile")
            Exit Sub
        End If


        Dim SaveFileDialogMT As SaveFileDialog = New SaveFileDialog With {
            .Filter = " files (*.mem)|*.mem"
        }
        If Me.ListView1.Items.Count > 0 Then



            If SaveFileDialogMT.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.ListView1.Visible = False
                Me.TabControl1.Visible = False
                Me.TabControlMTCharg.Visible = True
                Me.TabControlMTCharg.SelectedIndex = 0
                Me.MenuStrip1.Visible = False
                Selectionneur = "CMT"
                filePath = Path.GetFullPath(SaveFileDialogMT.FileName)

                BackgroundWorkerMT.RunWorkerAsync()




            End If
        Else
            MsgBox("open Files or folder before")

        End If
        SaveFileDialogMT.Dispose()
    End Sub

    Private Sub OpenMTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenMTToolStripMenuItem.Click
        If TabControl1.Visible = False Then
            MsgBox("after recompile")
            Exit Sub
        End If
        Dim OpenFileDialogMT As OpenFileDialog = New OpenFileDialog With {
            .Filter = " files (*.mem)|*.mem"}

        If OpenFileDialogMT.ShowDialog() = DialogResult.OK Then
            Me.ListView1.Visible = False
            Me.TabControl1.Visible = False
            Me.TabControlMTCharg.Visible = True
            Me.TabControlMTCharg.SelectedIndex = 0
            Me.MenuStrip1.Visible = False
            Selectionneur = "OMT"
            filePath = Path.GetFullPath(OpenFileDialogMT.FileName)

            BackgroundWorkerMT.RunWorkerAsync()
        Else


        End If




        OpenFileDialogMT.Dispose()
    End Sub




    Private Sub ApplyMTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplyMTToolStripMenuItem.Click
        If ListView1.Items.Count > 0 Then

            If Me.ListViewMT.Items.Count > 0 Then
                Dim b As Integer = 0

                For Each item As ListViewItem In Me.ListViewMT.Items

                    For Each texbox In dynamicTxtlist

                        texbox.Text = texbox.Text.Replace(item.Text, Me.ListViewMT.Items(b).SubItems(1).Text)

                    Next

                    b += 1

                Next

            Else
                MsgBox("Load MT before")
            End If
            MsgBox("fini")
        Else

            MsgBox("open Files or folder before")

        End If


    End Sub

    Private Sub TutorielToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TutorielToolStripMenuItem.Click
        Dim Path As String = Application.StartupPath
        Process.Start(Path & "\pdf\help_En.pdf")
    End Sub

    Private Sub DiscordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiscordToolStripMenuItem.Click
        Process.Start("https://discord.gg/PsuHkDn")
    End Sub






#Region "BackgroundWorker"
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerMT.DoWork


        Try
            Select Case Selectionneur

                Case = "OMT"
                    Me.ListViewMT.Clear()
                    Me.ListViewMT.Columns.Add("Source")
                    Me.ListViewMT.Columns.Add("Target")

                    Dim FS As FileStream = File.Open(filePath, FileMode.Open)
                    Dim BinFmtr As New BinaryFormatter
                    Dim alSavedLV As New ArrayList
                    alSavedLV = CType(BinFmtr.Deserialize(FS), ArrayList)
                    Dim lvi As ListViewItem
                    For item As Integer = 0 To alSavedLV.Count - 1
                        If BackgroundWorkerMT.CancellationPending Then
                            e.Cancel = True
                            Exit For
                        End If
                        lvi = New ListViewItem
                        lvi = CType(alSavedLV(item), ListViewItem)
                        BackgroundWorkerMT.ReportProgress(CInt((item / alSavedLV.Count) * 100))
                        UpdateLabel(Me.Status, FormatPercent(item / alSavedLV.Count, 2))
                        Me.ListViewMT.Items.Add(lvi)
                    Next
                    FS.Close()
                Case = "CMT"
                    Me.ListViewMT.Clear()
                    Me.ListViewMT.Columns.Add("Source")
                    Me.ListViewMT.Columns.Add("Target")
                    Dim t As Integer = 0
                    Dim z As Integer = 0
                    Dim txt As String
                    Dim MRT As New StringBuilder
                    Dim compteur As Integer = 0
                    Dim regex As Regex = New Regex(Regexconfig.TextBoxRegexforMT.Text)
                    Dim match As Match
                    For Each texte As TextBox In dynamicTxtlist
                        If BackgroundWorkerMT.CancellationPending Then
                            e.Cancel = True
                            Exit For
                        End If
                        Dim Lines() As String = dynamicTxtlist(t).Text.Split(Environment.NewLine)
                        t += 1
                        For Each Line As String In Lines
                            match = regex.Match(Line)
                            If match.Success Then
                                txt = match.Value
                                If compteur = 0 Then
                                    Me.ListViewMT.Items.Add(txt)
                                    compteur = 1
                                Else
                                    Me.ListViewMT.Items(z).SubItems.Add(txt)
                                    z += 1
                                    compteur = 0
                                End If
                            End If
                        Next Line
                    Next
                    Dim FS As FileStream = File.Create(filePath)
                    Dim BinFmtr As New BinaryFormatter
                    Dim alSavedLV As New ArrayList
                    For item As Integer = 0 To Me.ListViewMT.Items.Count - 1
                        alSavedLV.Add(Me.ListViewMT.Items(item))
                    Next
                    BinFmtr.Serialize(FS, alSavedLV)
                    FS.Close()
                Case = "DECOMP"
                    Dim txt As String
                    Dim txt2 As String
                    Dim txt3 As String
                    Dim t As Integer = 0
                    Dim li As Long = 0

                    Dim nbl As Integer
                    Dim compteur As Integer = 0
                    If Regexconfig.CheckBoxrempauto.Checked = True Then
                        Dim k As Integer = 0
                        For Each texbox In Me.dynamicTxtlist
                            Invoke(New MethodInvoker(Sub() Me.dynamicTxtlist(k).Text = Regex.Replace(texbox.Text, Regexconfig.TextBoxRegexrempav.Text, Regexconfig.TextBoxRegexparav.Text, RegexOptions.IgnoreCase)))
                            k += 1
                        Next
                    End If
                    For Each texbox In dynamicTxtlist

                        nbl += texbox.Lines.Count
                    Next texbox


                    For Each texbox In dynamicTxtlist
                        Dim txttrans As String
                        Dim Output As New StringBuilder
                        Dim Output2 As New StringBuilder
                        Dim Output3 As New StringBuilder


                        Dim Lines() As String = dynamicTxtlist(t).Text.Split(Environment.NewLine)

                        For Each Line As String In Lines
                            compteur += 1
                            BackgroundWorkerMT.ReportProgress(CInt((compteur / nbl) * 100))
                            UpdateLabel(Me.Status, FormatPercent(compteur / nbl, 2))
                            If Regex.IsMatch(Line, Regexconfig.TextBoxRegex.Text) Then

                                txttrans = Line.Replace(vbCr, "").Replace(vbLf, "")


                                txt = Regex.Replace(txttrans, Regexconfig.TextBoxRegex.Text, "$2")
                                txt2 = Regex.Replace(txttrans, Regexconfig.TextBoxRegex.Text, "$1")
                                txt3 = Regex.Replace(txttrans, Regexconfig.TextBoxRegex.Text, "$3")
                                Output.AppendLine(txt)
                                Output2.AppendLine(txt2)
                                Output3.AppendLine(txt3)

                                li += 1

                            End If

                        Next Line

                        Invoke(New MethodInvoker(Sub() dynamicTxt2list(t).Text = Output.ToString))
                        Invoke(New MethodInvoker(Sub() dynamicTxt3list(t).Text = Output2.ToString))
                        Invoke(New MethodInvoker(Sub() dynamicTxt4list(t).Text = Output3.ToString))
                        t += 1
                        li = 0

                    Next
                Case = "RECOMP"

                    Dim t As Integer = 0
                    Dim li As Long = 0
                    Dim ln As Integer = 1
                    Dim nombredetext As Long = dynamicTxtlist.Count
                    Dim nbl As Integer
                    Dim compteur As Integer = 0

                    For Each texbox In dynamicTxtlist

                        nbl += texbox.Lines.Count
                    Next texbox

                    For Each texbox In dynamicTxtlist

                        Dim texte As String = texbox.Text
                        Dim stringdebut As String() = {}
                        Invoke(New MethodInvoker(Sub() stringdebut = dynamicTxt3list(t).Text.Split(({vbCrLf, vbCr, vbLf}), StringSplitOptions.None)))
                        Dim stringmilieu As String() = {}
                        Invoke(New MethodInvoker(Sub() stringmilieu = dynamicTxt2list(t).Text.Split(({vbCrLf, vbCr, vbLf}), StringSplitOptions.None)))

                        Dim stringfin As String() = {}
                        Invoke(New MethodInvoker(Sub() stringfin = dynamicTxt4list(t).Text.Split(({vbCrLf, vbCr, vbLf}), StringSplitOptions.None)))
                        Dim Lines() As String = dynamicTxtlist(t).Text.Split(({vbCrLf, vbCr, vbLf}), StringSplitOptions.None)

                        For Each Line As String In Lines

                            compteur += 1
                            BackgroundWorkerMT.ReportProgress(CInt((compteur / nbl) * 100))
                            UpdateLabel(Me.Status, FormatPercent(compteur / nbl, 2))

                            If Regex.IsMatch(Line, Regexconfig.TextBoxRegex.Text) Then

                                texte = texte.Replace(Line, stringdebut(li).Replace(vbCr, "").Replace(vbLf, "") & stringmilieu(li).Replace(vbCr, "").Replace(vbLf, "") & stringfin(li).Replace(vbCr, "").Replace(vbLf, ""))

                                li += 1


                            End If



                        Next Line


                        Invoke(New MethodInvoker(Sub() dynamicTxtlist(t).Text = texte))
                        t += 1
                        li = 0
                        ln += 1
                    Next

                    If Regexconfig.CheckBoxrempauto.Checked = True Then
                        Dim k As Integer = 0
                        For Each texbox In Me.dynamicTxtlist
                            Invoke(New MethodInvoker(Sub() Me.dynamicTxtlist(k).Text = Regex.Replace(texbox.Text, Regexconfig.TextBoxRegexparav.Text, Regexconfig.TextBoxRegexrempav.Text, RegexOptions.IgnoreCase)))
                            k += 1
                        Next
                    End If
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
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

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorkerMT.ProgressChanged
        Me.ProgressBarrr.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerMT.RunWorkerCompleted
        If e.Cancelled Then
            Me.Status.Text = "Cancelled"
            Delay(2)
            Me.MenuStrip1.Visible = True
            Me.TabControlMTCharg.Visible = False
            Me.ListView1.Visible = True
            Me.TabControl1.Visible = True

        Else
            Me.Status.Text = "Complated"
            Delay(1)
            Select Case Selectionneur
                Case = "OMT"
                    Me.TabControlMTCharg.SelectedIndex = 1
                    Me.MenuStrip1.Visible = True
                    AutoSizeListViewColumns(Me.ListViewMT)
                Case = "CMT"
                    Me.TabControlMTCharg.SelectedIndex = 1
                    Me.MenuStrip1.Visible = True
                    AutoSizeListViewColumns(Me.ListViewMT)
                Case = "DECOMP"
                    Me.MenuStrip1.Visible = True
                    Me.TabControlMTCharg.Visible = False
                    Me.TabControl2.Visible = True
                    Me.DecompilerToolStripMenuItem1.Visible = False
                    Me.RecompilerToolStripMenuItem1.Visible = True
                    Me.TraducteurToolStripMenuItem1.Visible = True
                    Me.ReplaceToolStripMenuItem.Visible = True
                Case = "RECOMP"
                    Me.MenuStrip1.Visible = True
                    Me.TabControlMTCharg.Visible = False
                    Me.ListView1.Visible = True
                    Me.TabControl1.Visible = True
                    Me.DecompilerToolStripMenuItem1.Visible = True
                    Me.RecompilerToolStripMenuItem1.Visible = False
                    Me.TraducteurToolStripMenuItem1.Visible = False
                    Me.ReplaceToolStripMenuItem.Visible = False
            End Select
        End If
    End Sub
#End Region
    Private Sub AutoSizeListViewColumns(oListView As ListView)
        Dim nCol As Integer
        SuspendLayout()
        For nCol = 0 To (oListView.Columns.Count - 1)
            oListView.Columns(nCol).Width = -1
        Next
        oListView.Refresh()
        ResumeLayout()
    End Sub

    Private Sub MTToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MTToolStripMenuItem1.Click
        Me.TabControlMTCharg.Visible = True
        Me.TabControlMTCharg.SelectedIndex = 1
        Me.TabControl1.Visible = False
        Me.ListView1.Visible = False
        Me.TabControl2.Visible = False
        Me.MTToolStripMenuItem1.Checked = True
        Me.DecompileToolStripMenuItem.Checked = False
        Me.MainToolStripMenuItem.Checked = False
    End Sub

    Private Sub DecompileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecompileToolStripMenuItem.Click
        Me.TabControlMTCharg.Visible = False

        Me.TabControl1.Visible = False
        Me.ListView1.Visible = False
        Me.TabControl2.Visible = True
        Me.MTToolStripMenuItem1.Checked = False
        Me.DecompileToolStripMenuItem.Checked = True
        Me.MainToolStripMenuItem.Checked = False
    End Sub

    Private Sub MainToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainToolStripMenuItem.Click
        Me.TabControlMTCharg.Visible = False
        Me.TabControl1.Visible = True
        Me.ListView1.Visible = True
        Me.TabControl2.Visible = False
        Me.MTToolStripMenuItem1.Checked = False
        Me.DecompileToolStripMenuItem.Checked = False
        Me.MainToolStripMenuItem.Checked = True
    End Sub






End Class
