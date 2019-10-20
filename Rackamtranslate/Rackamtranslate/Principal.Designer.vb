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
        Me.MemoryTranslationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ContextMenulistview.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
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
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        resources.ApplyResources(Me.HelpToolStripMenuItem, "HelpToolStripMenuItem")
        '
        'ListView1
        '
        resources.ApplyResources(Me.ListView1, "ListView1")
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.ContextMenuStrip = Me.ContextMenulistview
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.DecompilerToolStripMenuItem1, Me.RecompilerToolStripMenuItem1, Me.ReplaceToolStripMenuItem, Me.TraducteurToolStripMenuItem1, Me.OptionsToolStripMenuItem, Me.HelpToolStripMenuItem, Me.MemoryTranslationToolStripMenuItem})
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
        'MemoryTranslationToolStripMenuItem
        '
        Me.MemoryTranslationToolStripMenuItem.Name = "MemoryTranslationToolStripMenuItem"
        resources.ApplyResources(Me.MemoryTranslationToolStripMenuItem, "MemoryTranslationToolStripMenuItem")
        '
        'Principal
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.TabControl4)
        Me.Controls.Add(Me.TabControl3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Principal"
        Me.ContextMenulistview.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents MemoryTranslationToolStripMenuItem As ToolStripMenuItem
End Class
