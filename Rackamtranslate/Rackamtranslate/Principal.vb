Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Text

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

    Private Sub ToolStripMenuItem1_Click_1(sender As Object, e As EventArgs)

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





    '                                     _  _     _  _     _  _   _____                                 _ _        _  _     _  _     _  _   
    '                                   _| || |_ _| || |_ _| || |_|  __ \                               (_) |     _| || |_ _| || |_ _| || |_ 
    '                                  |_  __  _|_  __  _|_  __  _| |  | | ___  ___ ___  _ __ ___  _ __  _| | ___|_  __  _|_  __  _|_  __  _|
    '                                   _| || |_ _| || |_ _| || |_| |  | |/ _ \/ __/ _ \| '_ ` _ \| '_ \| | |/ _ \_| || |_ _| || |_ _| || |_ 
    '                                  |_  __  _|_  __  _|_  __  _| |__| |  __/ (_| (_) | | | | | | |_) | | |  __/_  __  _|_  __  _|_  __  _|
    '                                    |_||_|   |_||_|   |_||_| |_____/ \___|\___\___/|_| |_| |_| .__/|_|_|\___| |_||_|   |_||_|   |_||_|  
    '                                                                                             | |                                        
    '                                                                                             |_|                                        

    Private Sub DecompilerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DecompilerToolStripMenuItem1.Click



        If ListView1.Items.Count > 0 Then

            Me.TabControl1.Visible = False
            Me.ListView1.Visible = False
            Me.TabControl2.Visible = True
            Me.RecompilerToolStripMenuItem1.Visible = True
            Me.TraducteurToolStripMenuItem1.Visible = True
            Me.DecompilerToolStripMenuItem1.Visible = False
            Me.ReplaceToolStripMenuItem.Visible = True
            Me.Visible = False
            Chargement.Show()


            Dim thread1 As New Thread(Sub() Decompile()) With {
                .IsBackground = True
            }
            thread1.Start()

        End If
    End Sub

    Sub Decompile()






        Dim txt As String
        Dim txt2 As String
        Dim txt3 As String
        Dim t As Integer = 0
        Dim li As Long = 0

        Dim nbl As Integer
        Dim compteur As Integer = 0

        For Each texbox In dynamicTxtlist

            nbl += texbox.Lines.Count
        Next texbox
        Invoke(New MethodInvoker(Sub() Chargement.ProgressBar1.Maximum = nbl))

        For Each texbox In dynamicTxtlist
            Dim txttrans As String
            Dim Output As New StringBuilder
            Dim Output2 As New StringBuilder
            Dim Output3 As New StringBuilder







            'Search your RichTextBox.Text line by line (Use String.Split instead of Regex to get the lines. This will prevent blank lines occuring in the results.)

            Dim Lines() As String = dynamicTxtlist(t).Text.Split(Environment.NewLine)

            For Each Line As String In Lines
                compteur += 1
                'If this line contains any of the SI values you want to replace
                If Regex.IsMatch(Line, Regexconfig.TextBoxRegex.Text) Then
                    'retire le retour le chariot
                    txttrans = Line.Replace(vbCr, "").Replace(vbLf, "")


                    'Create a link to the MatchConversion function that will allow you to apply logic when replacing search results
                    txt = Regex.Replace(txttrans, Regexconfig.TextBoxRegex.Text, "$2")
                    txt2 = Regex.Replace(txttrans, Regexconfig.TextBoxRegex.Text, "$1")
                    txt3 = Regex.Replace(txttrans, Regexconfig.TextBoxRegex.Text, "$3")
                    '
                    Output.AppendLine(txt)
                    Output2.AppendLine(txt2)
                    Output3.AppendLine(txt3)
                    'If there are no SI Values in this row, then just add the row as is to the stringbuilder
                    li += 1

                End If

            Next Line

            'Replace the RichTextBox.Text with the Stringbuilder output

            Invoke(New MethodInvoker(Sub() dynamicTxt2list(t).Text = Output.ToString))
            Invoke(New MethodInvoker(Sub() dynamicTxt3list(t).Text = Output2.ToString))
            Invoke(New MethodInvoker(Sub() dynamicTxt4list(t).Text = Output3.ToString))
            t += 1
            li = 0
            Invoke(New MethodInvoker(Sub() Chargement.ProgressBar1.Value = compteur))
        Next

        Threading.Thread.Sleep(1000)
        Invoke(New MethodInvoker(Sub() Chargement.Close()))

        Invoke(New MethodInvoker(Sub() Me.Visible = True))

    End Sub

    Private Sub RecompilerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RecompilerToolStripMenuItem1.Click


        '                                           _  _     _  _     _  _   _____                                _ _        _  _     _  _     _  _   
        '                                         _| || |_ _| || |_ _| || |_|  __ \                              (_) |     _| || |_ _| || |_ _| || |_ 
        '                                        |_  __  _|_  __  _|_  __  _| |__) |___  ___ ___  _ __ ___  _ __  _| | ___|_  __  _|_  __  _|_  __  _|
        '                                         _| || |_ _| || |_ _| || |_|  _  // _ \/ __/ _ \| '_ ` _ \| '_ \| | |/ _ \_| || |_ _| || |_ _| || |_ 
        '                                        |_  __  _|_  __  _|_  __  _| | \ \  __/ (_| (_) | | | | | | |_) | | |  __/_  __  _|_  __  _|_  __  _|
        '                                          |_||_|   |_||_|   |_||_| |_|  \_\___|\___\___/|_| |_| |_| .__/|_|_|\___| |_||_|   |_||_|   |_||_|  
        '                                                                                                  | |                                        
        ''                                                                                                 |_|                                        
        If TabControl2.Visible = True Then
            Me.ListView1.Visible = True
            Me.TabControl1.Visible = True
            Me.TabControl2.Visible = False
            Me.RecompilerToolStripMenuItem1.Visible = False
            Me.TraducteurToolStripMenuItem1.Visible = False
            Me.DecompilerToolStripMenuItem1.Visible = True
            Me.ReplaceToolStripMenuItem.Visible = False
            Me.Visible = False


            Chargement.Show()

            Dim thread1 As New Thread(Sub() Recompile()) With {
                .IsBackground = True
            }
            thread1.Start()
        End If
    End Sub
    Sub Recompile()
        Dim txt As String
        Dim t As Integer = 0
        Dim li As Long = 0
        Dim ln As Integer = 1
        Dim nombredetext As Long = dynamicTxtlist.Count
        Dim nbl As Integer
        Dim compteur As Integer = 0

        For Each texbox In dynamicTxtlist

            nbl += texbox.Lines.Count
        Next texbox
        Invoke(New MethodInvoker(Sub() Chargement.ProgressBar1.Maximum = nbl))


        For Each texbox In dynamicTxtlist

            Dim Output As New StringBuilder

            'Search your RichTextBox.Text line by line (Use String.Split instead of Regex to get the lines. This will prevent blank lines occuring in the results.)

            Dim Lines() As String = dynamicTxtlist(t).Text.Split(Environment.NewLine)

            For Each Line As String In Lines

                compteur += 1

                'If this line contains any of the SI values you want to replace
                If Regex.IsMatch(Line, Regexconfig.TextBoxRegex.Text) Then

                    txt = Line
                    'Regex.Replace effectively splits the text using your searchpattern as the marker for each split
                    Invoke(New MethodInvoker(Sub() txt = dynamicTxt3list(t).Lines(li) & dynamicTxt2list(t).Lines(li) & dynamicTxt4list(t).Lines(li)))
                    Output.AppendLine(txt)
                    'If there are no SI Values in this row, then just add the row as is to the stringbuilder



                    li += 1
                Else : Output.AppendLine(Line)
                End If

                Invoke(New MethodInvoker(Sub() Chargement.ProgressBar1.Value = compteur))

            Next Line

            'Replace the RichTextBox.Text with the Stringbuilder output
            Invoke(New MethodInvoker(Sub() dynamicTxtlist(t).Text = Output.ToString))

            t += 1
            li = 0
            ln += 1
        Next

        Invoke(New MethodInvoker(Sub() Chargement.Close()))
        Invoke(New MethodInvoker(Sub() Me.Visible = True))
    End Sub
    '              _       _                                            _ _                                   
    '             | |     (_)                                          | (_)                                  
    ' _ __ ___  __| |_   _ _ _ __ ___    __ _  __ _ _ __ __ _ _ __   __| |_ _ __   _ __ ___   ___ _ __  _   _ 
    '| '__/ _ \/ _` | | | | | '__/ _ \  / _` |/ _` | '__/ _` | '_ \ / _` | | '__| | '_ ` _ \ / _ \ '_ \| | | |
    '| | |  __/ (_| | |_| | | | |  __/ | (_| | (_| | | | (_| | | | | (_| | | |    | | | | | |  __/ | | | |_| |
    '|_|  \___|\__,_|\__,_|_|_|  \___|  \__,_|\__, |_|  \__,_|_| |_|\__,_|_|_|    |_| |_| |_|\___|_| |_|\__,_|
    '                                          __/ |                                                          
    '                                         |___/                                                          
    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    'If GroupBox1.Width = 169 Then
    '    GroupBox1.Width = 0
    '    Button2.Left = 1
    '    Button2.Text = ">>"

    '    Me.ListView1.Left = Me.ListView1.Left - 169
    '    Me.ListView1.Width = Me.ListView1.Width + 169
    '    Me.TabControl1.Left = Me.TabControl1.Left - 169
    '    Me.TabControl1.Width = Me.TabControl1.Width + 169
    '    Me.TabControl2.Left = Me.TabControl2.Left - 169
    '    Me.TabControl2.Width = Me.TabControl2.Width + 169

    'Else
    '    GroupBox1.Width = 169
    '    Button2.Left = 166
    '    Button2.Text = "<<"
    '    Me.ListView1.Left = Me.ListView1.Left + 169
    '    Me.ListView1.Width = Me.ListView1.Width - 169
    '    Me.TabControl1.Left = Me.TabControl1.Left + 169
    '    Me.TabControl1.Width = Me.TabControl1.Width - 169
    '    Me.TabControl2.Left = Me.TabControl2.Left + 169
    '    Me.TabControl2.Width = Me.TabControl2.Width - 169



    'End If

    'End Sub



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
    ' _____                              _                            _   _               _______       ____    _______        _   _               
    '|  __ \                            (_)                          | | (_)             |__   __|/\   |  _ \  |__   __|      | | | |              
    '| |  | |_   _ _ __   __ _ _ __ ___  _  ___    ___ _ __ ___  __ _| |_ _  ___  _ __      | |  /  \  | |_) |    | | _____  _| |_| |__   _____  __
    '| |  | | | | | '_ \ / _` | '_ ` _ \| |/ __|  / __| '__/ _ \/ _` | __| |/ _ \| '_ \     | | / /\ \ |  _ <     | |/ _ \ \/ / __| '_ \ / _ \ \/ /
    '| |__| | |_| | | | | (_| | | | | | | | (__  | (__| | |  __/ (_| | |_| | (_) | | | |    | |/ ____ \| |_) |    | |  __/>  <| |_| |_) | (_) >  < 
    '|_____/ \__, |_| |_|\__,_|_| |_| |_|_|\___|  \___|_|  \___|\__,_|\__|_|\___/|_| |_|    |_/_/    \_\____/     |_|\___/_/\_\\__|_.__/ \___/_/\_\
    '         __/ |                                                                                                                                
    '        |___/          
    'test
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
        dynamicTab.Size = TabControl1.Size
        dynamicTab.Text = nom
        dynamicTab2.Name = "tabtrad" & nom
        dynamicTab2.Tag = nom
        dynamicTab2.Size = TabControl2.Size
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
        dynamicTxt.Multiline = True
        dynamicTxt.Size = dynamicTab.Size
        dynamicTxt.Anchor = TabControl1.Anchor
        dynamicTxt.ScrollBars = ScrollBars.Both
        dynamicTxt.Text = IO.File.ReadAllText(Chemin + nom)

        dynamicTxt2.Name = "textbtrad" & nom
        dynamicTxt2.Tag = nom
        dynamicTxt2.Multiline = True
        dynamicTxt2.Size = dynamicTab2.Size
        dynamicTxt2.Anchor = TabControl2.Anchor
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
        Traducteur.ComboBox1.Items.Add(dynamicTxt2.Tag)
    End Sub

    Private Sub RegexToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Regexconfig.Show()
    End Sub



    '                         _  _     _  _     _  _    _____                                           _        _  _     _  _     _  _   
    '                       _| || |_ _| || |_ _| || |_ / ____|                                         | |     _| || |_ _| || |_ _| || |_ 
    '                      |_  __  _|_  __  _|_  __  _| (___   __ _ _   ___   _____  __ _  __ _ _ __ __| | ___|_  __  _|_  __  _|_  __  _|
    '                       _| || |_ _| || |_ _| || |_ \___ \ / _` | | | \ \ / / _ \/ _` |/ _` | '__/ _` |/ _ \_| || |_ _| || |_ _| || |_ 
    '                      |_  __  _|_  __  _|_  __  _|____) | (_| | |_| |\ V /  __/ (_| | (_| | | | (_| |  __/_  __  _|_  __  _|_  __  _|
    '                        |_||_|   |_||_|   |_||_| |_____/ \__,_|\__,_| \_/ \___|\__, |\__,_|_|  \__,_|\___| |_||_|   |_||_|   |_||_|  
    '                                                                                __/ |                                                
    '                                                                               |___/                                                 
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






    '                  _  _     _  _     _  _   ______  __  __                       _____      _           _   _               _  _     _  _     _  _   
    '                _| || |_ _| || |_ _| || |_|  ____|/ _|/ _|                     / ____|    | |         | | (_)            _| || |_ _| || |_ _| || |_ 
    '               |_  __  _|_  __  _|_  __  _| |__  | |_| |_ __ _  ___ ___ _ __  | (___   ___| | ___  ___| |_ _  ___  _ __ |_  __  _|_  __  _|_  __  _|
    '                _| || |_ _| || |_ _| || |_|  __| |  _|  _/ _` |/ __/ _ \ '__|  \___ \ / _ \ |/ _ \/ __| __| |/ _ \| '_ \ _| || |_ _| || |_ _| || |_ 
    '               |_  __  _|_  __  _|_  __  _| |____| | | || (_| | (_|  __/ |     ____) |  __/ |  __/ (__| |_| | (_) | | | |_  __  _|_  __  _|_  __  _|
    '                 |_||_|   |_||_|   |_||_| |______|_| |_| \__,_|\___\___|_|    |_____/ \___|_|\___|\___|\__|_|\___/|_| |_| |_||_|   |_||_|   |_||_|  
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
    '                                              _  _     _  _     _  _   ______  __  __                      _______          _    _  _     _  _     _  _   
    '                                            _| || |_ _| || |_ _| || |_|  ____|/ _|/ _|                    |__   __|        | | _| || |_ _| || |_ _| || |_ 
    '                                           |_  __  _|_  __  _|_  __  _| |__  | |_| |_ __ _  ___ ___ _ __     | | ___  _   _| ||_  __  _|_  __  _|_  __  _|
    '                                            _| || |_ _| || |_ _| || |_|  __| |  _|  _/ _` |/ __/ _ \ '__|    | |/ _ \| | | | __|| || |_ _| || |_ _| || |_ 
    '                                           |_  __  _|_  __  _|_  __  _| |____| | | || (_| | (_|  __/ |       | | (_) | |_| | ||_  __  _|_  __  _|_  __  _|
    '                                             |_||_|   |_||_|   |_||_| |______|_| |_| \__,_|\___\___|_|       |_|\___/ \__,_|\__||_||_|   |_||_|   |_||_|  
    Private Sub RemoveAllItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveAllItemToolStripMenuItem.Click
        ListView1.Clear()
        dynamicTxtlist.Clear()
        dynamicTxt2list.Clear()
        dynamicTxt3list.Clear()
        dynamicTxt4list.Clear()
        ListView1.Items.Clear()
        TabControl1.TabPages.Clear()
        TabControl2.TabPages.Clear()
        Traducteur.ComboBox1.Items.Clear()
    End Sub

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
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub EnregistrersousToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrersousToolStripMenuItem.Click
        MsgBox(My.Resources.Globalstrings.Messagelater)
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Help.Show()
    End Sub


    Private Sub TraducteurToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TraducteurToolStripMenuItem1.Click

        Traducteur.Show()
        Traducteur.Visible = True
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub ReplaceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReplaceToolStripMenuItem.Click
        Remplacement.Show()
    End Sub

    '                      _  _     _  _     _  _     _  _     _  _   __  __ _______  _  _     _  _     _  _     _  _     _  _   
    '                    _| || |_ _| || |_ _| || |_ _| || |_ _| || |_|  \/  |__   __|| || |_ _| || |_ _| || |_ _| || |_ _| || |_ 
    '                   |_  __  _|_  __  _|_  __  _|_  __  _|_  __  _| \  / |  | | |_  __  _|_  __  _|_  __  _|_  __  _|_  __  _|
    '                    _| || |_ _| || |_ _| || |_ _| || |_ _| || |_| |\/| |  | |  _| || |_ _| || |_ _| || |_ _| || |_ _| || |_ 
    '                   |_  __  _|_  __  _|_  __  _|_  __  _|_  __  _| |  | |  | | |_  __  _|_  __  _|_  __  _|_  __  _|_  __  _|
    '                     |_||_|   |_||_|   |_||_|   |_||_|   |_||_| |_|  |_|  |_|   |_||_|   |_||_|   |_||_|   |_||_|   |_||_|  



    Private Sub CreateMTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateMTToolStripMenuItem.Click

        If ListView1.Items.Count > 0 Then

            Dim SaveFileDialogMT As SaveFileDialog = New SaveFileDialog With {
            .Filter = " files (*.mem)|*.mem"
        }


            If SaveFileDialogMT.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim x As Integer
                Dim b As Integer
                Dim z As Integer
                Dim txt As String
                Dim MRT As New StringBuilder
                Dim compteur As Integer = 0

                x = Me.ListView1.Items.Count
                Dim regex As Regex = New Regex(Regexconfig.TextBoxRegexforMT.Text)
                Dim match As Match






                For Each texte As TextBox In dynamicTxtlist

                    Dim Lines() As String = texte.Text.Split(Environment.NewLine)

                    For Each Line As String In Lines
                        match = regex.Match(Line)
                        If match.Success Then
                            z = MT.ListView2.Items.Count
                            txt = match.Value
                            If compteur = 0 Then

                                MT.ListView2.Items.Add(txt)
                                compteur = 1
                            Else
                                MT.ListView2.Items(z - 1).SubItems.Add(txt)
                                compteur = 0

                            End If
                        End If

                    Next Line

                Next
                Dim FileToSaveAs As String = SaveFileDialogMT.FileName
                Dim bf As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
                Using fs As New System.IO.FileStream(FileToSaveAs, IO.FileMode.Create)
                    bf.Serialize(fs, New ArrayList(MT.ListView2.Items))
                End Using


                SaveFileDialogMT.Dispose()
            End If
        Else
            MsgBox("open Files or folder before")
        End If
    End Sub

    Private Sub OpenMTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenMTToolStripMenuItem.Click
        Me.Visible = False
        Chargement2.Show()
        MT.Show()
        MT.Visible = False
        Dim fileName As String
        Dim openFileDialogMT As OpenFileDialog = New OpenFileDialog With {
            .Multiselect = False,
            .FileName = String.Empty,
            .Filter = "mem files (*.mem)|*.mem",
            .FilterIndex = 1,
            .RestoreDirectory = True
        }


        If openFileDialogMT.ShowDialog() = DialogResult.OK Then

            Try
                fileName = openFileDialogMT.FileName
                Dim bf As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
                Using fs As New System.IO.FileStream(fileName, IO.FileMode.Open)
                    MT.ListView2.Items.AddRange(bf.Deserialize(fs).ToArray(GetType(ListViewItem)))
                End Using



            Catch ex As Exception
                MessageBox.Show("Une erreur est survenue lors de l'ouverture du fichier : {0}.", ex.Message)
            End Try

        End If
        Me.Visible = True
        MT.Visible = True
        Chargement2.Close()
        openFileDialogMT.Dispose()
    End Sub
    Private Sub ShowMTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowMTToolStripMenuItem.Click
        MT.Show()
        MT.Visible = True
    End Sub

    Private Sub ApplyMTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplyMTToolStripMenuItem.Click
        If ListView1.Items.Count > 0 Then

            If MT.ListView2.Items.Count > 0 Then
                Dim b As Integer = 0




                For Each item As ListViewItem In ListView1.Items




                    For Each texbox In dynamicTxtlist


                        texbox.Text = texbox.Text.Replace(item.Text, ListView1.Items(b).SubItems(1).Text)


                    Next

                    b += 1




                Next

            Else
                MsgBox("Load MT before")
            End If

        Else

            MsgBox("open Files or folder before")


        End If


    End Sub
End Class
