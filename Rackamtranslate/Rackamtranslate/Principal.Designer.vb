<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.RegexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RitchboxOptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TutorielToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiscordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenulistview = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveAllItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabControl4 = New System.Windows.Forms.TabControl()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.EnregistrerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnregistrersousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecompilerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecompilerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReplaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TraducteurToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenMTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateMTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplyMTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.SaveFileDialogMT = New System.Windows.Forms.SaveFileDialog()
        Me.BackgroundWorkerMT = New System.ComponentModel.BackgroundWorker()
        Me.TabControlMTCharg = New System.Windows.Forms.TabControl()
        Me.TabPageProgressBar = New System.Windows.Forms.TabPage()
        Me.MyPictureBox = New System.Windows.Forms.PictureBox()
        Me.ProgressBarrr = New System.Windows.Forms.ProgressBar()
        Me.Status = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPageMT = New System.Windows.Forms.TabPage()
        Me.ListViewMT = New System.Windows.Forms.ListView()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MTToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecompileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenulistview.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControlMTCharg.SuspendLayout()
        Me.TabPageProgressBar.SuspendLayout()
        CType(Me.MyPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageMT.SuspendLayout()
        Me.SuspendLayout()
        '
        'RegexToolStripMenuItem
        '
        Me.RegexToolStripMenuItem.Name = "RegexToolStripMenuItem"
        resources.ApplyResources(Me.RegexToolStripMenuItem, "RegexToolStripMenuItem")
        '
        'RitchboxOptionToolStripMenuItem
        '
        Me.RitchboxOptionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorToolStripMenuItem, Me.FontToolStripMenuItem})
        Me.RitchboxOptionToolStripMenuItem.Name = "RitchboxOptionToolStripMenuItem"
        resources.ApplyResources(Me.RitchboxOptionToolStripMenuItem, "RitchboxOptionToolStripMenuItem")
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        resources.ApplyResources(Me.ColorToolStripMenuItem, "ColorToolStripMenuItem")
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        resources.ApplyResources(Me.FontToolStripMenuItem, "FontToolStripMenuItem")
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TutorielToolStripMenuItem, Me.DiscordToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        resources.ApplyResources(Me.HelpToolStripMenuItem, "HelpToolStripMenuItem")
        '
        'TutorielToolStripMenuItem
        '
        Me.TutorielToolStripMenuItem.Name = "TutorielToolStripMenuItem"
        resources.ApplyResources(Me.TutorielToolStripMenuItem, "TutorielToolStripMenuItem")
        '
        'DiscordToolStripMenuItem
        '
        Me.DiscordToolStripMenuItem.Name = "DiscordToolStripMenuItem"
        resources.ApplyResources(Me.DiscordToolStripMenuItem, "DiscordToolStripMenuItem")
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.ContextMenuStrip = Me.ContextMenulistview
        resources.ApplyResources(Me.ListView1, "ListView1")
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        resources.ApplyResources(Me.ColumnHeader1, "ColumnHeader1")
        '
        'ColumnHeader2
        '
        resources.ApplyResources(Me.ColumnHeader2, "ColumnHeader2")
        '
        'ContextMenulistview
        '
        Me.ContextMenulistview.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveItemToolStripMenuItem, Me.RemoveAllItemToolStripMenuItem})
        Me.ContextMenulistview.Name = "ContextMenulistview"
        resources.ApplyResources(Me.ContextMenulistview, "ContextMenulistview")
        '
        'RemoveItemToolStripMenuItem
        '
        Me.RemoveItemToolStripMenuItem.Name = "RemoveItemToolStripMenuItem"
        resources.ApplyResources(Me.RemoveItemToolStripMenuItem, "RemoveItemToolStripMenuItem")
        '
        'RemoveAllItemToolStripMenuItem
        '
        Me.RemoveAllItemToolStripMenuItem.Name = "RemoveAllItemToolStripMenuItem"
        resources.ApplyResources(Me.RemoveAllItemToolStripMenuItem, "RemoveAllItemToolStripMenuItem")
        '
        'TabControl1
        '
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        '
        'TabControl2
        '
        resources.ApplyResources(Me.TabControl2, "TabControl2")
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        '
        'TabControl4
        '
        resources.ApplyResources(Me.TabControl4, "TabControl4")
        Me.TabControl4.Name = "TabControl4"
        Me.TabControl4.SelectedIndex = 0
        '
        'TabControl3
        '
        resources.ApplyResources(Me.TabControl3, "TabControl3")
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegexToolStripMenuItem, Me.ToolStripSeparator4, Me.RitchboxOptionToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        resources.ApplyResources(Me.OptionsToolStripMenuItem, "OptionsToolStripMenuItem")
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        resources.ApplyResources(Me.ToolStripSeparator4, "ToolStripSeparator4")
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.ShowNewFolderButton = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.ViewToolStripMenuItem, Me.DecompilerToolStripMenuItem1, Me.RecompilerToolStripMenuItem1, Me.ReplaceToolStripMenuItem, Me.TraducteurToolStripMenuItem1, Me.OptionsToolStripMenuItem, Me.MTToolStripMenuItem, Me.HelpToolStripMenuItem})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OuvrirToolStripMenuItem, Me.toolStripSeparator, Me.EnregistrerToolStripMenuItem, Me.EnregistrersousToolStripMenuItem, Me.toolStripSeparator1, Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        resources.ApplyResources(Me.FichierToolStripMenuItem, "FichierToolStripMenuItem")
        '
        'OuvrirToolStripMenuItem
        '
        Me.OuvrirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilesToolStripMenuItem, Me.FolderToolStripMenuItem})
        resources.ApplyResources(Me.OuvrirToolStripMenuItem, "OuvrirToolStripMenuItem")
        Me.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        '
        'FilesToolStripMenuItem
        '
        Me.FilesToolStripMenuItem.Name = "FilesToolStripMenuItem"
        resources.ApplyResources(Me.FilesToolStripMenuItem, "FilesToolStripMenuItem")
        '
        'FolderToolStripMenuItem
        '
        Me.FolderToolStripMenuItem.Name = "FolderToolStripMenuItem"
        resources.ApplyResources(Me.FolderToolStripMenuItem, "FolderToolStripMenuItem")
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        resources.ApplyResources(Me.toolStripSeparator, "toolStripSeparator")
        '
        'EnregistrerToolStripMenuItem
        '
        resources.ApplyResources(Me.EnregistrerToolStripMenuItem, "EnregistrerToolStripMenuItem")
        Me.EnregistrerToolStripMenuItem.Name = "EnregistrerToolStripMenuItem"
        '
        'EnregistrersousToolStripMenuItem
        '
        Me.EnregistrersousToolStripMenuItem.Name = "EnregistrersousToolStripMenuItem"
        resources.ApplyResources(Me.EnregistrersousToolStripMenuItem, "EnregistrersousToolStripMenuItem")
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        resources.ApplyResources(Me.toolStripSeparator1, "toolStripSeparator1")
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        resources.ApplyResources(Me.QuitterToolStripMenuItem, "QuitterToolStripMenuItem")
        '
        'DecompilerToolStripMenuItem1
        '
        Me.DecompilerToolStripMenuItem1.Name = "DecompilerToolStripMenuItem1"
        resources.ApplyResources(Me.DecompilerToolStripMenuItem1, "DecompilerToolStripMenuItem1")
        '
        'RecompilerToolStripMenuItem1
        '
        Me.RecompilerToolStripMenuItem1.Name = "RecompilerToolStripMenuItem1"
        resources.ApplyResources(Me.RecompilerToolStripMenuItem1, "RecompilerToolStripMenuItem1")
        '
        'ReplaceToolStripMenuItem
        '
        Me.ReplaceToolStripMenuItem.Name = "ReplaceToolStripMenuItem"
        resources.ApplyResources(Me.ReplaceToolStripMenuItem, "ReplaceToolStripMenuItem")
        '
        'TraducteurToolStripMenuItem1
        '
        Me.TraducteurToolStripMenuItem1.Name = "TraducteurToolStripMenuItem1"
        resources.ApplyResources(Me.TraducteurToolStripMenuItem1, "TraducteurToolStripMenuItem1")
        '
        'MTToolStripMenuItem
        '
        Me.MTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenMTToolStripMenuItem, Me.CreateMTToolStripMenuItem, Me.ApplyMTToolStripMenuItem})
        Me.MTToolStripMenuItem.Name = "MTToolStripMenuItem"
        resources.ApplyResources(Me.MTToolStripMenuItem, "MTToolStripMenuItem")
        '
        'OpenMTToolStripMenuItem
        '
        Me.OpenMTToolStripMenuItem.Name = "OpenMTToolStripMenuItem"
        resources.ApplyResources(Me.OpenMTToolStripMenuItem, "OpenMTToolStripMenuItem")
        '
        'CreateMTToolStripMenuItem
        '
        Me.CreateMTToolStripMenuItem.Name = "CreateMTToolStripMenuItem"
        resources.ApplyResources(Me.CreateMTToolStripMenuItem, "CreateMTToolStripMenuItem")
        '
        'ApplyMTToolStripMenuItem
        '
        Me.ApplyMTToolStripMenuItem.Name = "ApplyMTToolStripMenuItem"
        resources.ApplyResources(Me.ApplyMTToolStripMenuItem, "ApplyMTToolStripMenuItem")
        '
        'BackgroundWorkerMT
        '
        Me.BackgroundWorkerMT.WorkerReportsProgress = True
        Me.BackgroundWorkerMT.WorkerSupportsCancellation = True
        '
        'TabControlMTCharg
        '
        resources.ApplyResources(Me.TabControlMTCharg, "TabControlMTCharg")
        Me.TabControlMTCharg.Controls.Add(Me.TabPageProgressBar)
        Me.TabControlMTCharg.Controls.Add(Me.TabPageMT)
        Me.TabControlMTCharg.Name = "TabControlMTCharg"
        Me.TabControlMTCharg.SelectedIndex = 0
        Me.TabControlMTCharg.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        '
        'TabPageProgressBar
        '
        Me.TabPageProgressBar.Controls.Add(Me.MyPictureBox)
        Me.TabPageProgressBar.Controls.Add(Me.ProgressBarrr)
        Me.TabPageProgressBar.Controls.Add(Me.Status)
        Me.TabPageProgressBar.Controls.Add(Me.Button1)
        resources.ApplyResources(Me.TabPageProgressBar, "TabPageProgressBar")
        Me.TabPageProgressBar.Name = "TabPageProgressBar"
        Me.TabPageProgressBar.UseVisualStyleBackColor = True
        '
        'MyPictureBox
        '
        resources.ApplyResources(Me.MyPictureBox, "MyPictureBox")
        Me.MyPictureBox.Name = "MyPictureBox"
        Me.MyPictureBox.TabStop = False
        '
        'ProgressBarrr
        '
        resources.ApplyResources(Me.ProgressBarrr, "ProgressBarrr")
        Me.ProgressBarrr.Name = "ProgressBarrr"
        '
        'Status
        '
        resources.ApplyResources(Me.Status, "Status")
        Me.Status.Name = "Status"
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPageMT
        '
        Me.TabPageMT.Controls.Add(Me.ListViewMT)
        resources.ApplyResources(Me.TabPageMT, "TabPageMT")
        Me.TabPageMT.Name = "TabPageMT"
        Me.TabPageMT.UseVisualStyleBackColor = True
        '
        'ListViewMT
        '
        Me.ListViewMT.ContextMenuStrip = Me.ContextMenulistview
        resources.ApplyResources(Me.ListViewMT, "ListViewMT")
        Me.ListViewMT.FullRowSelect = True
        Me.ListViewMT.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListViewMT.HideSelection = False
        Me.ListViewMT.MultiSelect = False
        Me.ListViewMT.Name = "ListViewMT"
        Me.ListViewMT.UseCompatibleStateImageBehavior = False
        Me.ListViewMT.View = System.Windows.Forms.View.Details
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MTToolStripMenuItem1, Me.DecompileToolStripMenuItem, Me.MainToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        resources.ApplyResources(Me.ViewToolStripMenuItem, "ViewToolStripMenuItem")
        '
        'MTToolStripMenuItem1
        '
        Me.MTToolStripMenuItem1.Name = "MTToolStripMenuItem1"
        resources.ApplyResources(Me.MTToolStripMenuItem1, "MTToolStripMenuItem1")
        '
        'DecompileToolStripMenuItem
        '
        Me.DecompileToolStripMenuItem.Name = "DecompileToolStripMenuItem"
        resources.ApplyResources(Me.DecompileToolStripMenuItem, "DecompileToolStripMenuItem")
        '
        'MainToolStripMenuItem
        '
        Me.MainToolStripMenuItem.Name = "MainToolStripMenuItem"
        resources.ApplyResources(Me.MainToolStripMenuItem, "MainToolStripMenuItem")
        '
        'Principal
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControlMTCharg)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.TabControl4)
        Me.Controls.Add(Me.TabControl3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Principal"
        Me.ContextMenulistview.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControlMTCharg.ResumeLayout(False)
        Me.TabPageProgressBar.ResumeLayout(False)
        Me.TabPageProgressBar.PerformLayout()
        CType(Me.MyPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageMT.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RegexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RitchboxOptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ContextMenulistview As ContextMenuStrip
    Friend WithEvents RemoveItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveAllItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabControl4 As TabControl
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OuvrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents EnregistrerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnregistrersousToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents DecompilerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RecompilerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TraducteurToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ReplaceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateMTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApplyMTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialogMT As SaveFileDialog
    Friend WithEvents OpenMTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TutorielToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DiscordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundWorkerMT As System.ComponentModel.BackgroundWorker
    Friend WithEvents TabControlMTCharg As TabControl
    Friend WithEvents TabPageProgressBar As TabPage
    Friend WithEvents TabPageMT As TabPage
    Friend WithEvents ProgressBarrr As ProgressBar
    Friend WithEvents Status As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ListViewMT As ListView
    Friend WithEvents MyPictureBox As PictureBox
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MTToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DecompileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainToolStripMenuItem As ToolStripMenuItem
End Class
