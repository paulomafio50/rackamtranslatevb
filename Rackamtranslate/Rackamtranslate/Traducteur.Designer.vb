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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Traducteur))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonTraduire = New System.Windows.Forms.Button()
        Me.GeckoWebBrowser1 = New Gecko.GeckoWebBrowser()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Textsource = New System.Windows.Forms.Label()
        Me.Buttonok = New System.Windows.Forms.Button()
        Me.Labeltraducteur = New System.Windows.Forms.Label()
        Me.Labellangtarget = New System.Windows.Forms.Label()
        Me.Labellangsouce = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ComboBoxLangtargetYand = New System.Windows.Forms.ComboBox()
        Me.ComboBoxtraducteur = New System.Windows.Forms.ComboBox()
        Me.ComboBoxLangsourceYand = New System.Windows.Forms.ComboBox()
        Me.ComboBoxLangtargetGog = New System.Windows.Forms.ComboBox()
        Me.ComboBoxLangsourceGog = New System.Windows.Forms.ComboBox()
        Me.ComboBoxLangtargetDeepl = New System.Windows.Forms.ComboBox()
        Me.ComboBoxLangsourceDeepl = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.ButtonTraduire.BackColor = System.Drawing.SystemColors.Control
        resources.ApplyResources(Me.ButtonTraduire, "ButtonTraduire")
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
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'ComboBoxLangtargetYand
        '
        Me.ComboBoxLangtargetYand.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Rackamtranslate.My.MySettings.Default, "ComboBoxLangtargetYandL", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ComboBoxLangtargetYand.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Global.Rackamtranslate.My.MySettings.Default, "ComboBoxLangtargetYandV", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ComboBoxLangtargetYand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxLangtargetYand.FormattingEnabled = True
        Me.ComboBoxLangtargetYand.Items.AddRange(New Object() {resources.GetString("ComboBoxLangtargetYand.Items"), resources.GetString("ComboBoxLangtargetYand.Items1"), resources.GetString("ComboBoxLangtargetYand.Items2"), resources.GetString("ComboBoxLangtargetYand.Items3"), resources.GetString("ComboBoxLangtargetYand.Items4"), resources.GetString("ComboBoxLangtargetYand.Items5"), resources.GetString("ComboBoxLangtargetYand.Items6"), resources.GetString("ComboBoxLangtargetYand.Items7"), resources.GetString("ComboBoxLangtargetYand.Items8"), resources.GetString("ComboBoxLangtargetYand.Items9"), resources.GetString("ComboBoxLangtargetYand.Items10"), resources.GetString("ComboBoxLangtargetYand.Items11"), resources.GetString("ComboBoxLangtargetYand.Items12"), resources.GetString("ComboBoxLangtargetYand.Items13"), resources.GetString("ComboBoxLangtargetYand.Items14"), resources.GetString("ComboBoxLangtargetYand.Items15"), resources.GetString("ComboBoxLangtargetYand.Items16"), resources.GetString("ComboBoxLangtargetYand.Items17"), resources.GetString("ComboBoxLangtargetYand.Items18"), resources.GetString("ComboBoxLangtargetYand.Items19"), resources.GetString("ComboBoxLangtargetYand.Items20"), resources.GetString("ComboBoxLangtargetYand.Items21"), resources.GetString("ComboBoxLangtargetYand.Items22"), resources.GetString("ComboBoxLangtargetYand.Items23"), resources.GetString("ComboBoxLangtargetYand.Items24"), resources.GetString("ComboBoxLangtargetYand.Items25"), resources.GetString("ComboBoxLangtargetYand.Items26"), resources.GetString("ComboBoxLangtargetYand.Items27"), resources.GetString("ComboBoxLangtargetYand.Items28"), resources.GetString("ComboBoxLangtargetYand.Items29"), resources.GetString("ComboBoxLangtargetYand.Items30"), resources.GetString("ComboBoxLangtargetYand.Items31"), resources.GetString("ComboBoxLangtargetYand.Items32"), resources.GetString("ComboBoxLangtargetYand.Items33"), resources.GetString("ComboBoxLangtargetYand.Items34"), resources.GetString("ComboBoxLangtargetYand.Items35"), resources.GetString("ComboBoxLangtargetYand.Items36"), resources.GetString("ComboBoxLangtargetYand.Items37"), resources.GetString("ComboBoxLangtargetYand.Items38"), resources.GetString("ComboBoxLangtargetYand.Items39"), resources.GetString("ComboBoxLangtargetYand.Items40"), resources.GetString("ComboBoxLangtargetYand.Items41"), resources.GetString("ComboBoxLangtargetYand.Items42"), resources.GetString("ComboBoxLangtargetYand.Items43"), resources.GetString("ComboBoxLangtargetYand.Items44"), resources.GetString("ComboBoxLangtargetYand.Items45"), resources.GetString("ComboBoxLangtargetYand.Items46"), resources.GetString("ComboBoxLangtargetYand.Items47"), resources.GetString("ComboBoxLangtargetYand.Items48"), resources.GetString("ComboBoxLangtargetYand.Items49"), resources.GetString("ComboBoxLangtargetYand.Items50"), resources.GetString("ComboBoxLangtargetYand.Items51"), resources.GetString("ComboBoxLangtargetYand.Items52"), resources.GetString("ComboBoxLangtargetYand.Items53"), resources.GetString("ComboBoxLangtargetYand.Items54"), resources.GetString("ComboBoxLangtargetYand.Items55"), resources.GetString("ComboBoxLangtargetYand.Items56"), resources.GetString("ComboBoxLangtargetYand.Items57"), resources.GetString("ComboBoxLangtargetYand.Items58"), resources.GetString("ComboBoxLangtargetYand.Items59"), resources.GetString("ComboBoxLangtargetYand.Items60"), resources.GetString("ComboBoxLangtargetYand.Items61"), resources.GetString("ComboBoxLangtargetYand.Items62"), resources.GetString("ComboBoxLangtargetYand.Items63"), resources.GetString("ComboBoxLangtargetYand.Items64"), resources.GetString("ComboBoxLangtargetYand.Items65"), resources.GetString("ComboBoxLangtargetYand.Items66"), resources.GetString("ComboBoxLangtargetYand.Items67"), resources.GetString("ComboBoxLangtargetYand.Items68"), resources.GetString("ComboBoxLangtargetYand.Items69"), resources.GetString("ComboBoxLangtargetYand.Items70"), resources.GetString("ComboBoxLangtargetYand.Items71"), resources.GetString("ComboBoxLangtargetYand.Items72"), resources.GetString("ComboBoxLangtargetYand.Items73"), resources.GetString("ComboBoxLangtargetYand.Items74"), resources.GetString("ComboBoxLangtargetYand.Items75"), resources.GetString("ComboBoxLangtargetYand.Items76"), resources.GetString("ComboBoxLangtargetYand.Items77"), resources.GetString("ComboBoxLangtargetYand.Items78"), resources.GetString("ComboBoxLangtargetYand.Items79"), resources.GetString("ComboBoxLangtargetYand.Items80"), resources.GetString("ComboBoxLangtargetYand.Items81"), resources.GetString("ComboBoxLangtargetYand.Items82"), resources.GetString("ComboBoxLangtargetYand.Items83"), resources.GetString("ComboBoxLangtargetYand.Items84"), resources.GetString("ComboBoxLangtargetYand.Items85"), resources.GetString("ComboBoxLangtargetYand.Items86"), resources.GetString("ComboBoxLangtargetYand.Items87"), resources.GetString("ComboBoxLangtargetYand.Items88"), resources.GetString("ComboBoxLangtargetYand.Items89"), resources.GetString("ComboBoxLangtargetYand.Items90"), resources.GetString("ComboBoxLangtargetYand.Items91"), resources.GetString("ComboBoxLangtargetYand.Items92"), resources.GetString("ComboBoxLangtargetYand.Items93"), resources.GetString("ComboBoxLangtargetYand.Items94"), resources.GetString("ComboBoxLangtargetYand.Items95"), resources.GetString("ComboBoxLangtargetYand.Items96"), resources.GetString("ComboBoxLangtargetYand.Items97"), resources.GetString("ComboBoxLangtargetYand.Items98"), resources.GetString("ComboBoxLangtargetYand.Items99"), resources.GetString("ComboBoxLangtargetYand.Items100"), resources.GetString("ComboBoxLangtargetYand.Items101"), resources.GetString("ComboBoxLangtargetYand.Items102")})
        resources.ApplyResources(Me.ComboBoxLangtargetYand, "ComboBoxLangtargetYand")
        Me.ComboBoxLangtargetYand.Name = "ComboBoxLangtargetYand"
        Me.ComboBoxLangtargetYand.Text = Global.Rackamtranslate.My.MySettings.Default.ComboBoxLangtargetYandL
        Me.ComboBoxLangtargetYand.Visible = Global.Rackamtranslate.My.MySettings.Default.ComboBoxLangtargetYandV
        '
        'ComboBoxtraducteur
        '
        Me.ComboBoxtraducteur.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Rackamtranslate.My.MySettings.Default, "ComboBoxtraducteur", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ComboBoxtraducteur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxtraducteur.FormattingEnabled = True
        Me.ComboBoxtraducteur.Items.AddRange(New Object() {resources.GetString("ComboBoxtraducteur.Items"), resources.GetString("ComboBoxtraducteur.Items1"), resources.GetString("ComboBoxtraducteur.Items2")})
        resources.ApplyResources(Me.ComboBoxtraducteur, "ComboBoxtraducteur")
        Me.ComboBoxtraducteur.Name = "ComboBoxtraducteur"
        Me.ComboBoxtraducteur.Text = Global.Rackamtranslate.My.MySettings.Default.ComboBoxtraducteur
        '
        'ComboBoxLangsourceYand
        '
        Me.ComboBoxLangsourceYand.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Rackamtranslate.My.MySettings.Default, "ComboBoxLangsourceYandL", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ComboBoxLangsourceYand.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Global.Rackamtranslate.My.MySettings.Default, "ComboBoxLangsourceYandV", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ComboBoxLangsourceYand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxLangsourceYand.FormattingEnabled = True
        Me.ComboBoxLangsourceYand.Items.AddRange(New Object() {resources.GetString("ComboBoxLangsourceYand.Items"), resources.GetString("ComboBoxLangsourceYand.Items1"), resources.GetString("ComboBoxLangsourceYand.Items2"), resources.GetString("ComboBoxLangsourceYand.Items3"), resources.GetString("ComboBoxLangsourceYand.Items4"), resources.GetString("ComboBoxLangsourceYand.Items5"), resources.GetString("ComboBoxLangsourceYand.Items6"), resources.GetString("ComboBoxLangsourceYand.Items7"), resources.GetString("ComboBoxLangsourceYand.Items8"), resources.GetString("ComboBoxLangsourceYand.Items9"), resources.GetString("ComboBoxLangsourceYand.Items10"), resources.GetString("ComboBoxLangsourceYand.Items11"), resources.GetString("ComboBoxLangsourceYand.Items12"), resources.GetString("ComboBoxLangsourceYand.Items13"), resources.GetString("ComboBoxLangsourceYand.Items14"), resources.GetString("ComboBoxLangsourceYand.Items15"), resources.GetString("ComboBoxLangsourceYand.Items16"), resources.GetString("ComboBoxLangsourceYand.Items17"), resources.GetString("ComboBoxLangsourceYand.Items18"), resources.GetString("ComboBoxLangsourceYand.Items19"), resources.GetString("ComboBoxLangsourceYand.Items20"), resources.GetString("ComboBoxLangsourceYand.Items21"), resources.GetString("ComboBoxLangsourceYand.Items22"), resources.GetString("ComboBoxLangsourceYand.Items23"), resources.GetString("ComboBoxLangsourceYand.Items24"), resources.GetString("ComboBoxLangsourceYand.Items25"), resources.GetString("ComboBoxLangsourceYand.Items26"), resources.GetString("ComboBoxLangsourceYand.Items27"), resources.GetString("ComboBoxLangsourceYand.Items28"), resources.GetString("ComboBoxLangsourceYand.Items29"), resources.GetString("ComboBoxLangsourceYand.Items30"), resources.GetString("ComboBoxLangsourceYand.Items31"), resources.GetString("ComboBoxLangsourceYand.Items32"), resources.GetString("ComboBoxLangsourceYand.Items33"), resources.GetString("ComboBoxLangsourceYand.Items34"), resources.GetString("ComboBoxLangsourceYand.Items35"), resources.GetString("ComboBoxLangsourceYand.Items36"), resources.GetString("ComboBoxLangsourceYand.Items37"), resources.GetString("ComboBoxLangsourceYand.Items38"), resources.GetString("ComboBoxLangsourceYand.Items39"), resources.GetString("ComboBoxLangsourceYand.Items40"), resources.GetString("ComboBoxLangsourceYand.Items41"), resources.GetString("ComboBoxLangsourceYand.Items42"), resources.GetString("ComboBoxLangsourceYand.Items43"), resources.GetString("ComboBoxLangsourceYand.Items44"), resources.GetString("ComboBoxLangsourceYand.Items45"), resources.GetString("ComboBoxLangsourceYand.Items46"), resources.GetString("ComboBoxLangsourceYand.Items47"), resources.GetString("ComboBoxLangsourceYand.Items48"), resources.GetString("ComboBoxLangsourceYand.Items49"), resources.GetString("ComboBoxLangsourceYand.Items50"), resources.GetString("ComboBoxLangsourceYand.Items51"), resources.GetString("ComboBoxLangsourceYand.Items52"), resources.GetString("ComboBoxLangsourceYand.Items53"), resources.GetString("ComboBoxLangsourceYand.Items54"), resources.GetString("ComboBoxLangsourceYand.Items55"), resources.GetString("ComboBoxLangsourceYand.Items56"), resources.GetString("ComboBoxLangsourceYand.Items57"), resources.GetString("ComboBoxLangsourceYand.Items58"), resources.GetString("ComboBoxLangsourceYand.Items59"), resources.GetString("ComboBoxLangsourceYand.Items60"), resources.GetString("ComboBoxLangsourceYand.Items61"), resources.GetString("ComboBoxLangsourceYand.Items62"), resources.GetString("ComboBoxLangsourceYand.Items63"), resources.GetString("ComboBoxLangsourceYand.Items64"), resources.GetString("ComboBoxLangsourceYand.Items65"), resources.GetString("ComboBoxLangsourceYand.Items66"), resources.GetString("ComboBoxLangsourceYand.Items67"), resources.GetString("ComboBoxLangsourceYand.Items68"), resources.GetString("ComboBoxLangsourceYand.Items69"), resources.GetString("ComboBoxLangsourceYand.Items70"), resources.GetString("ComboBoxLangsourceYand.Items71"), resources.GetString("ComboBoxLangsourceYand.Items72"), resources.GetString("ComboBoxLangsourceYand.Items73"), resources.GetString("ComboBoxLangsourceYand.Items74"), resources.GetString("ComboBoxLangsourceYand.Items75"), resources.GetString("ComboBoxLangsourceYand.Items76"), resources.GetString("ComboBoxLangsourceYand.Items77"), resources.GetString("ComboBoxLangsourceYand.Items78"), resources.GetString("ComboBoxLangsourceYand.Items79"), resources.GetString("ComboBoxLangsourceYand.Items80"), resources.GetString("ComboBoxLangsourceYand.Items81"), resources.GetString("ComboBoxLangsourceYand.Items82"), resources.GetString("ComboBoxLangsourceYand.Items83"), resources.GetString("ComboBoxLangsourceYand.Items84"), resources.GetString("ComboBoxLangsourceYand.Items85"), resources.GetString("ComboBoxLangsourceYand.Items86"), resources.GetString("ComboBoxLangsourceYand.Items87"), resources.GetString("ComboBoxLangsourceYand.Items88"), resources.GetString("ComboBoxLangsourceYand.Items89"), resources.GetString("ComboBoxLangsourceYand.Items90"), resources.GetString("ComboBoxLangsourceYand.Items91"), resources.GetString("ComboBoxLangsourceYand.Items92"), resources.GetString("ComboBoxLangsourceYand.Items93"), resources.GetString("ComboBoxLangsourceYand.Items94"), resources.GetString("ComboBoxLangsourceYand.Items95"), resources.GetString("ComboBoxLangsourceYand.Items96"), resources.GetString("ComboBoxLangsourceYand.Items97"), resources.GetString("ComboBoxLangsourceYand.Items98"), resources.GetString("ComboBoxLangsourceYand.Items99"), resources.GetString("ComboBoxLangsourceYand.Items100"), resources.GetString("ComboBoxLangsourceYand.Items101")})
        resources.ApplyResources(Me.ComboBoxLangsourceYand, "ComboBoxLangsourceYand")
        Me.ComboBoxLangsourceYand.Name = "ComboBoxLangsourceYand"
        Me.ComboBoxLangsourceYand.Text = Global.Rackamtranslate.My.MySettings.Default.ComboBoxLangsourceYandL
        Me.ComboBoxLangsourceYand.Visible = Global.Rackamtranslate.My.MySettings.Default.ComboBoxLangsourceYandV
        '
        'ComboBoxLangtargetGog
        '
        Me.ComboBoxLangtargetGog.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Rackamtranslate.My.MySettings.Default, "ComboBoxLangtargetGogL", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ComboBoxLangtargetGog.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Global.Rackamtranslate.My.MySettings.Default, "ComboBoxLangtargetGogV", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ComboBoxLangtargetGog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxLangtargetGog.FormattingEnabled = True
        Me.ComboBoxLangtargetGog.Items.AddRange(New Object() {resources.GetString("ComboBoxLangtargetGog.Items"), resources.GetString("ComboBoxLangtargetGog.Items1"), resources.GetString("ComboBoxLangtargetGog.Items2"), resources.GetString("ComboBoxLangtargetGog.Items3"), resources.GetString("ComboBoxLangtargetGog.Items4"), resources.GetString("ComboBoxLangtargetGog.Items5"), resources.GetString("ComboBoxLangtargetGog.Items6"), resources.GetString("ComboBoxLangtargetGog.Items7"), resources.GetString("ComboBoxLangtargetGog.Items8"), resources.GetString("ComboBoxLangtargetGog.Items9"), resources.GetString("ComboBoxLangtargetGog.Items10"), resources.GetString("ComboBoxLangtargetGog.Items11"), resources.GetString("ComboBoxLangtargetGog.Items12"), resources.GetString("ComboBoxLangtargetGog.Items13"), resources.GetString("ComboBoxLangtargetGog.Items14"), resources.GetString("ComboBoxLangtargetGog.Items15"), resources.GetString("ComboBoxLangtargetGog.Items16"), resources.GetString("ComboBoxLangtargetGog.Items17"), resources.GetString("ComboBoxLangtargetGog.Items18"), resources.GetString("ComboBoxLangtargetGog.Items19"), resources.GetString("ComboBoxLangtargetGog.Items20"), resources.GetString("ComboBoxLangtargetGog.Items21"), resources.GetString("ComboBoxLangtargetGog.Items22"), resources.GetString("ComboBoxLangtargetGog.Items23"), resources.GetString("ComboBoxLangtargetGog.Items24"), resources.GetString("ComboBoxLangtargetGog.Items25"), resources.GetString("ComboBoxLangtargetGog.Items26"), resources.GetString("ComboBoxLangtargetGog.Items27"), resources.GetString("ComboBoxLangtargetGog.Items28"), resources.GetString("ComboBoxLangtargetGog.Items29"), resources.GetString("ComboBoxLangtargetGog.Items30"), resources.GetString("ComboBoxLangtargetGog.Items31"), resources.GetString("ComboBoxLangtargetGog.Items32"), resources.GetString("ComboBoxLangtargetGog.Items33"), resources.GetString("ComboBoxLangtargetGog.Items34"), resources.GetString("ComboBoxLangtargetGog.Items35"), resources.GetString("ComboBoxLangtargetGog.Items36"), resources.GetString("ComboBoxLangtargetGog.Items37"), resources.GetString("ComboBoxLangtargetGog.Items38"), resources.GetString("ComboBoxLangtargetGog.Items39"), resources.GetString("ComboBoxLangtargetGog.Items40"), resources.GetString("ComboBoxLangtargetGog.Items41"), resources.GetString("ComboBoxLangtargetGog.Items42"), resources.GetString("ComboBoxLangtargetGog.Items43"), resources.GetString("ComboBoxLangtargetGog.Items44"), resources.GetString("ComboBoxLangtargetGog.Items45"), resources.GetString("ComboBoxLangtargetGog.Items46"), resources.GetString("ComboBoxLangtargetGog.Items47"), resources.GetString("ComboBoxLangtargetGog.Items48"), resources.GetString("ComboBoxLangtargetGog.Items49"), resources.GetString("ComboBoxLangtargetGog.Items50"), resources.GetString("ComboBoxLangtargetGog.Items51"), resources.GetString("ComboBoxLangtargetGog.Items52"), resources.GetString("ComboBoxLangtargetGog.Items53"), resources.GetString("ComboBoxLangtargetGog.Items54"), resources.GetString("ComboBoxLangtargetGog.Items55"), resources.GetString("ComboBoxLangtargetGog.Items56"), resources.GetString("ComboBoxLangtargetGog.Items57"), resources.GetString("ComboBoxLangtargetGog.Items58"), resources.GetString("ComboBoxLangtargetGog.Items59"), resources.GetString("ComboBoxLangtargetGog.Items60"), resources.GetString("ComboBoxLangtargetGog.Items61"), resources.GetString("ComboBoxLangtargetGog.Items62"), resources.GetString("ComboBoxLangtargetGog.Items63"), resources.GetString("ComboBoxLangtargetGog.Items64"), resources.GetString("ComboBoxLangtargetGog.Items65"), resources.GetString("ComboBoxLangtargetGog.Items66"), resources.GetString("ComboBoxLangtargetGog.Items67"), resources.GetString("ComboBoxLangtargetGog.Items68"), resources.GetString("ComboBoxLangtargetGog.Items69"), resources.GetString("ComboBoxLangtargetGog.Items70"), resources.GetString("ComboBoxLangtargetGog.Items71"), resources.GetString("ComboBoxLangtargetGog.Items72"), resources.GetString("ComboBoxLangtargetGog.Items73"), resources.GetString("ComboBoxLangtargetGog.Items74"), resources.GetString("ComboBoxLangtargetGog.Items75"), resources.GetString("ComboBoxLangtargetGog.Items76"), resources.GetString("ComboBoxLangtargetGog.Items77"), resources.GetString("ComboBoxLangtargetGog.Items78"), resources.GetString("ComboBoxLangtargetGog.Items79"), resources.GetString("ComboBoxLangtargetGog.Items80"), resources.GetString("ComboBoxLangtargetGog.Items81"), resources.GetString("ComboBoxLangtargetGog.Items82"), resources.GetString("ComboBoxLangtargetGog.Items83"), resources.GetString("ComboBoxLangtargetGog.Items84"), resources.GetString("ComboBoxLangtargetGog.Items85"), resources.GetString("ComboBoxLangtargetGog.Items86"), resources.GetString("ComboBoxLangtargetGog.Items87"), resources.GetString("ComboBoxLangtargetGog.Items88"), resources.GetString("ComboBoxLangtargetGog.Items89"), resources.GetString("ComboBoxLangtargetGog.Items90"), resources.GetString("ComboBoxLangtargetGog.Items91"), resources.GetString("ComboBoxLangtargetGog.Items92"), resources.GetString("ComboBoxLangtargetGog.Items93"), resources.GetString("ComboBoxLangtargetGog.Items94"), resources.GetString("ComboBoxLangtargetGog.Items95"), resources.GetString("ComboBoxLangtargetGog.Items96"), resources.GetString("ComboBoxLangtargetGog.Items97"), resources.GetString("ComboBoxLangtargetGog.Items98"), resources.GetString("ComboBoxLangtargetGog.Items99"), resources.GetString("ComboBoxLangtargetGog.Items100"), resources.GetString("ComboBoxLangtargetGog.Items101"), resources.GetString("ComboBoxLangtargetGog.Items102")})
        resources.ApplyResources(Me.ComboBoxLangtargetGog, "ComboBoxLangtargetGog")
        Me.ComboBoxLangtargetGog.Name = "ComboBoxLangtargetGog"
        Me.ComboBoxLangtargetGog.Text = Global.Rackamtranslate.My.MySettings.Default.ComboBoxLangtargetGogL
        Me.ComboBoxLangtargetGog.Visible = Global.Rackamtranslate.My.MySettings.Default.ComboBoxLangtargetGogV
        '
        'ComboBoxLangsourceGog
        '
        Me.ComboBoxLangsourceGog.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Rackamtranslate.My.MySettings.Default, "ComboBoxLangsourceGogL", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ComboBoxLangsourceGog.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Global.Rackamtranslate.My.MySettings.Default, "ComboBoxLangsourceGogV", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ComboBoxLangsourceGog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxLangsourceGog.FormattingEnabled = True
        Me.ComboBoxLangsourceGog.Items.AddRange(New Object() {resources.GetString("ComboBoxLangsourceGog.Items"), resources.GetString("ComboBoxLangsourceGog.Items1"), resources.GetString("ComboBoxLangsourceGog.Items2"), resources.GetString("ComboBoxLangsourceGog.Items3"), resources.GetString("ComboBoxLangsourceGog.Items4"), resources.GetString("ComboBoxLangsourceGog.Items5"), resources.GetString("ComboBoxLangsourceGog.Items6"), resources.GetString("ComboBoxLangsourceGog.Items7"), resources.GetString("ComboBoxLangsourceGog.Items8"), resources.GetString("ComboBoxLangsourceGog.Items9"), resources.GetString("ComboBoxLangsourceGog.Items10"), resources.GetString("ComboBoxLangsourceGog.Items11"), resources.GetString("ComboBoxLangsourceGog.Items12"), resources.GetString("ComboBoxLangsourceGog.Items13"), resources.GetString("ComboBoxLangsourceGog.Items14"), resources.GetString("ComboBoxLangsourceGog.Items15"), resources.GetString("ComboBoxLangsourceGog.Items16"), resources.GetString("ComboBoxLangsourceGog.Items17"), resources.GetString("ComboBoxLangsourceGog.Items18"), resources.GetString("ComboBoxLangsourceGog.Items19"), resources.GetString("ComboBoxLangsourceGog.Items20"), resources.GetString("ComboBoxLangsourceGog.Items21"), resources.GetString("ComboBoxLangsourceGog.Items22"), resources.GetString("ComboBoxLangsourceGog.Items23"), resources.GetString("ComboBoxLangsourceGog.Items24"), resources.GetString("ComboBoxLangsourceGog.Items25"), resources.GetString("ComboBoxLangsourceGog.Items26"), resources.GetString("ComboBoxLangsourceGog.Items27"), resources.GetString("ComboBoxLangsourceGog.Items28"), resources.GetString("ComboBoxLangsourceGog.Items29"), resources.GetString("ComboBoxLangsourceGog.Items30"), resources.GetString("ComboBoxLangsourceGog.Items31"), resources.GetString("ComboBoxLangsourceGog.Items32"), resources.GetString("ComboBoxLangsourceGog.Items33"), resources.GetString("ComboBoxLangsourceGog.Items34"), resources.GetString("ComboBoxLangsourceGog.Items35"), resources.GetString("ComboBoxLangsourceGog.Items36"), resources.GetString("ComboBoxLangsourceGog.Items37"), resources.GetString("ComboBoxLangsourceGog.Items38"), resources.GetString("ComboBoxLangsourceGog.Items39"), resources.GetString("ComboBoxLangsourceGog.Items40"), resources.GetString("ComboBoxLangsourceGog.Items41"), resources.GetString("ComboBoxLangsourceGog.Items42"), resources.GetString("ComboBoxLangsourceGog.Items43"), resources.GetString("ComboBoxLangsourceGog.Items44"), resources.GetString("ComboBoxLangsourceGog.Items45"), resources.GetString("ComboBoxLangsourceGog.Items46"), resources.GetString("ComboBoxLangsourceGog.Items47"), resources.GetString("ComboBoxLangsourceGog.Items48"), resources.GetString("ComboBoxLangsourceGog.Items49"), resources.GetString("ComboBoxLangsourceGog.Items50"), resources.GetString("ComboBoxLangsourceGog.Items51"), resources.GetString("ComboBoxLangsourceGog.Items52"), resources.GetString("ComboBoxLangsourceGog.Items53"), resources.GetString("ComboBoxLangsourceGog.Items54"), resources.GetString("ComboBoxLangsourceGog.Items55"), resources.GetString("ComboBoxLangsourceGog.Items56"), resources.GetString("ComboBoxLangsourceGog.Items57"), resources.GetString("ComboBoxLangsourceGog.Items58"), resources.GetString("ComboBoxLangsourceGog.Items59"), resources.GetString("ComboBoxLangsourceGog.Items60"), resources.GetString("ComboBoxLangsourceGog.Items61"), resources.GetString("ComboBoxLangsourceGog.Items62"), resources.GetString("ComboBoxLangsourceGog.Items63"), resources.GetString("ComboBoxLangsourceGog.Items64"), resources.GetString("ComboBoxLangsourceGog.Items65"), resources.GetString("ComboBoxLangsourceGog.Items66"), resources.GetString("ComboBoxLangsourceGog.Items67"), resources.GetString("ComboBoxLangsourceGog.Items68"), resources.GetString("ComboBoxLangsourceGog.Items69"), resources.GetString("ComboBoxLangsourceGog.Items70"), resources.GetString("ComboBoxLangsourceGog.Items71"), resources.GetString("ComboBoxLangsourceGog.Items72"), resources.GetString("ComboBoxLangsourceGog.Items73"), resources.GetString("ComboBoxLangsourceGog.Items74"), resources.GetString("ComboBoxLangsourceGog.Items75"), resources.GetString("ComboBoxLangsourceGog.Items76"), resources.GetString("ComboBoxLangsourceGog.Items77"), resources.GetString("ComboBoxLangsourceGog.Items78"), resources.GetString("ComboBoxLangsourceGog.Items79"), resources.GetString("ComboBoxLangsourceGog.Items80"), resources.GetString("ComboBoxLangsourceGog.Items81"), resources.GetString("ComboBoxLangsourceGog.Items82"), resources.GetString("ComboBoxLangsourceGog.Items83"), resources.GetString("ComboBoxLangsourceGog.Items84"), resources.GetString("ComboBoxLangsourceGog.Items85"), resources.GetString("ComboBoxLangsourceGog.Items86"), resources.GetString("ComboBoxLangsourceGog.Items87"), resources.GetString("ComboBoxLangsourceGog.Items88"), resources.GetString("ComboBoxLangsourceGog.Items89"), resources.GetString("ComboBoxLangsourceGog.Items90"), resources.GetString("ComboBoxLangsourceGog.Items91"), resources.GetString("ComboBoxLangsourceGog.Items92"), resources.GetString("ComboBoxLangsourceGog.Items93"), resources.GetString("ComboBoxLangsourceGog.Items94"), resources.GetString("ComboBoxLangsourceGog.Items95"), resources.GetString("ComboBoxLangsourceGog.Items96"), resources.GetString("ComboBoxLangsourceGog.Items97"), resources.GetString("ComboBoxLangsourceGog.Items98"), resources.GetString("ComboBoxLangsourceGog.Items99"), resources.GetString("ComboBoxLangsourceGog.Items100"), resources.GetString("ComboBoxLangsourceGog.Items101")})
        resources.ApplyResources(Me.ComboBoxLangsourceGog, "ComboBoxLangsourceGog")
        Me.ComboBoxLangsourceGog.Name = "ComboBoxLangsourceGog"
        Me.ComboBoxLangsourceGog.Text = Global.Rackamtranslate.My.MySettings.Default.ComboBoxLangsourceGogL
        Me.ComboBoxLangsourceGog.Visible = Global.Rackamtranslate.My.MySettings.Default.ComboBoxLangsourceGogV
        '
        'ComboBoxLangtargetDeepl
        '
        Me.ComboBoxLangtargetDeepl.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Rackamtranslate.My.MySettings.Default, "ComboBoxLangTargetDeeplL", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ComboBoxLangtargetDeepl.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Global.Rackamtranslate.My.MySettings.Default, "ComboBoxLangtargetDeeplV", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ComboBoxLangtargetDeepl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxLangtargetDeepl.FormattingEnabled = True
        Me.ComboBoxLangtargetDeepl.Items.AddRange(New Object() {resources.GetString("ComboBoxLangtargetDeepl.Items"), resources.GetString("ComboBoxLangtargetDeepl.Items1"), resources.GetString("ComboBoxLangtargetDeepl.Items2"), resources.GetString("ComboBoxLangtargetDeepl.Items3"), resources.GetString("ComboBoxLangtargetDeepl.Items4"), resources.GetString("ComboBoxLangtargetDeepl.Items5"), resources.GetString("ComboBoxLangtargetDeepl.Items6"), resources.GetString("ComboBoxLangtargetDeepl.Items7"), resources.GetString("ComboBoxLangtargetDeepl.Items8")})
        resources.ApplyResources(Me.ComboBoxLangtargetDeepl, "ComboBoxLangtargetDeepl")
        Me.ComboBoxLangtargetDeepl.Name = "ComboBoxLangtargetDeepl"
        Me.ComboBoxLangtargetDeepl.Text = Global.Rackamtranslate.My.MySettings.Default.ComboBoxLangTargetDeeplL
        Me.ComboBoxLangtargetDeepl.Visible = Global.Rackamtranslate.My.MySettings.Default.ComboBoxLangtargetDeeplV
        '
        'ComboBoxLangsourceDeepl
        '
        Me.ComboBoxLangsourceDeepl.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Global.Rackamtranslate.My.MySettings.Default, "ComboBoxLangsourceDeeplV", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ComboBoxLangsourceDeepl.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Rackamtranslate.My.MySettings.Default, "ComboBoxLangsourceDeeplL", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ComboBoxLangsourceDeepl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxLangsourceDeepl.FormattingEnabled = True
        Me.ComboBoxLangsourceDeepl.Items.AddRange(New Object() {resources.GetString("ComboBoxLangsourceDeepl.Items"), resources.GetString("ComboBoxLangsourceDeepl.Items1"), resources.GetString("ComboBoxLangsourceDeepl.Items2"), resources.GetString("ComboBoxLangsourceDeepl.Items3"), resources.GetString("ComboBoxLangsourceDeepl.Items4"), resources.GetString("ComboBoxLangsourceDeepl.Items5"), resources.GetString("ComboBoxLangsourceDeepl.Items6"), resources.GetString("ComboBoxLangsourceDeepl.Items7"), resources.GetString("ComboBoxLangsourceDeepl.Items8")})
        resources.ApplyResources(Me.ComboBoxLangsourceDeepl, "ComboBoxLangsourceDeepl")
        Me.ComboBoxLangsourceDeepl.Name = "ComboBoxLangsourceDeepl"
        Me.ComboBoxLangsourceDeepl.Text = Global.Rackamtranslate.My.MySettings.Default.ComboBoxLangsourceDeeplL
        Me.ComboBoxLangsourceDeepl.Visible = Global.Rackamtranslate.My.MySettings.Default.ComboBoxLangsourceDeeplV
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel1.Controls.Add(Me.ComboBoxtraducteur)
        Me.Panel1.Controls.Add(Me.ComboBoxLangtargetYand)
        Me.Panel1.Controls.Add(Me.ComboBoxLangsourceGog)
        Me.Panel1.Controls.Add(Me.ComboBoxLangsourceYand)
        Me.Panel1.Controls.Add(Me.ComboBoxLangtargetGog)
        Me.Panel1.Controls.Add(Me.ComboBoxLangtargetDeepl)
        Me.Panel1.Controls.Add(Me.Labellangsouce)
        Me.Panel1.Controls.Add(Me.ComboBoxLangsourceDeepl)
        Me.Panel1.Controls.Add(Me.Labellangtarget)
        Me.Panel1.Controls.Add(Me.Labeltraducteur)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel2.Controls.Add(Me.NumericUpDown1)
        Me.Panel2.Controls.Add(Me.ButtonTraduire)
        Me.Panel2.Controls.Add(Me.Buttonok)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Textsource)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'Traducteur
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GeckoWebBrowser1)
        Me.Name = "Traducteur"
        Me.ShowIcon = False
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents ComboBoxLangtargetGog As ComboBox
    Friend WithEvents ComboBoxLangsourceGog As ComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ComboBoxLangsourceDeepl As ComboBox
    Friend WithEvents ComboBoxLangtargetDeepl As ComboBox
    Friend WithEvents ComboBoxLangsourceYand As ComboBox
    Friend WithEvents ComboBoxLangtargetYand As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
