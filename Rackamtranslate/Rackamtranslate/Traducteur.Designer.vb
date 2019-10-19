<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Traducteur
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Traducteur))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonTraduire = New System.Windows.Forms.Button()
        Me.GeckoWebBrowser1 = New Gecko.GeckoWebBrowser()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Textsource = New System.Windows.Forms.Label()
        Me.Buttonok = New System.Windows.Forms.Button()
        Me.ComboBoxtraducteur = New System.Windows.Forms.ComboBox()
        Me.Labeltraducteur = New System.Windows.Forms.Label()
        Me.Labellangtarget = New System.Windows.Forms.Label()
        Me.Labellangsouce = New System.Windows.Forms.Label()
        Me.ComboBoxLangtarget = New System.Windows.Forms.ComboBox()
        Me.ComboBoxLangsource = New System.Windows.Forms.ComboBox()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'ButtonTraduire
        '
        resources.ApplyResources(Me.ButtonTraduire, "ButtonTraduire")
        Me.ButtonTraduire.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonTraduire.Name = "ButtonTraduire"
        Me.ButtonTraduire.UseVisualStyleBackColor = False
        '
        'GeckoWebBrowser1
        '
        resources.ApplyResources(Me.GeckoWebBrowser1, "GeckoWebBrowser1")
        Me.GeckoWebBrowser1.FrameEventsPropagateToMainWindow = False
        Me.GeckoWebBrowser1.Name = "GeckoWebBrowser1"
        Me.GeckoWebBrowser1.UseHttpActivityObserver = False
        '
        'ComboBox1
        '
        resources.ApplyResources(Me.ComboBox1, "ComboBox1")
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Name = "ComboBox1"
        '
        'NumericUpDown1
        '
        resources.ApplyResources(Me.NumericUpDown1, "NumericUpDown1")
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Textsource
        '
        resources.ApplyResources(Me.Textsource, "Textsource")
        Me.Textsource.Name = "Textsource"
        '
        'Buttonok
        '
        resources.ApplyResources(Me.Buttonok, "Buttonok")
        Me.Buttonok.Name = "Buttonok"
        Me.Buttonok.UseVisualStyleBackColor = True
        '
        'ComboBoxtraducteur
        '
        Me.ComboBoxtraducteur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxtraducteur.FormattingEnabled = True
        resources.ApplyResources(Me.ComboBoxtraducteur, "ComboBoxtraducteur")
        Me.ComboBoxtraducteur.Name = "ComboBoxtraducteur"
        '
        'Labeltraducteur
        '
        resources.ApplyResources(Me.Labeltraducteur, "Labeltraducteur")
        Me.Labeltraducteur.Name = "Labeltraducteur"
        '
        'Labellangtarget
        '
        resources.ApplyResources(Me.Labellangtarget, "Labellangtarget")
        Me.Labellangtarget.Name = "Labellangtarget"
        '
        'Labellangsouce
        '
        resources.ApplyResources(Me.Labellangsouce, "Labellangsouce")
        Me.Labellangsouce.Name = "Labellangsouce"
        '
        'ComboBoxLangtarget
        '
        Me.ComboBoxLangtarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxLangtarget.FormattingEnabled = True
        resources.ApplyResources(Me.ComboBoxLangtarget, "ComboBoxLangtarget")
        Me.ComboBoxLangtarget.Name = "ComboBoxLangtarget"
        '
        'ComboBoxLangsource
        '
        Me.ComboBoxLangsource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxLangsource.FormattingEnabled = True
        resources.ApplyResources(Me.ComboBoxLangsource, "ComboBoxLangsource")
        Me.ComboBoxLangsource.Name = "ComboBoxLangsource"
        '
        'Traducteur
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ComboBoxtraducteur)
        Me.Controls.Add(Me.Labeltraducteur)
        Me.Controls.Add(Me.Labellangtarget)
        Me.Controls.Add(Me.Labellangsouce)
        Me.Controls.Add(Me.ComboBoxLangtarget)
        Me.Controls.Add(Me.ComboBoxLangsource)
        Me.Controls.Add(Me.Buttonok)
        Me.Controls.Add(Me.Textsource)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.GeckoWebBrowser1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonTraduire)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Traducteur"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonTraduire As Button
    Friend WithEvents GeckoWebBrowser1 As Gecko.GeckoWebBrowser
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Textsource As Label
    Friend WithEvents Buttonok As Button
    Friend WithEvents ComboBoxtraducteur As ComboBox
    Friend WithEvents Labeltraducteur As Label
    Friend WithEvents Labellangtarget As Label
    Friend WithEvents Labellangsouce As Label
    Friend WithEvents ComboBoxLangtarget As ComboBox
    Friend WithEvents ComboBoxLangsource As ComboBox
End Class
