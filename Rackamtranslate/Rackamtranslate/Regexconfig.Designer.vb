﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Regexconfig
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonRestav = New System.Windows.Forms.Button()
        Me.ButtonRempav = New System.Windows.Forms.Button()
        Me.TextBoxRegexparav = New System.Windows.Forms.TextBox()
        Me.TextBoxRegexrempav = New System.Windows.Forms.TextBox()
        Me.TextBoxRegex = New System.Windows.Forms.TextBox()
        Me.TextBoxRegexforMT = New System.Windows.Forms.TextBox()
        Me.LabelRegexforMT = New System.Windows.Forms.Label()
        Me.CheckBoxrempauto = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(113, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "For"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(24, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Replace"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(23, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Regex for decompiler and recompiler"
        '
        'ButtonRestav
        '
        Me.ButtonRestav.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonRestav.Location = New System.Drawing.Point(163, 165)
        Me.ButtonRestav.Name = "ButtonRestav"
        Me.ButtonRestav.Size = New System.Drawing.Size(94, 24)
        Me.ButtonRestav.TabIndex = 15
        Me.ButtonRestav.Text = "Restore"
        Me.ButtonRestav.UseVisualStyleBackColor = True
        '
        'ButtonRempav
        '
        Me.ButtonRempav.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonRempav.Location = New System.Drawing.Point(23, 165)
        Me.ButtonRempav.Name = "ButtonRempav"
        Me.ButtonRempav.Size = New System.Drawing.Size(87, 24)
        Me.ButtonRempav.TabIndex = 14
        Me.ButtonRempav.Text = "Apply"
        Me.ButtonRempav.UseVisualStyleBackColor = True
        '
        'TextBoxRegexparav
        '
        Me.TextBoxRegexparav.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Rackamtranslate.My.MySettings.Default, "regexfor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxRegexparav.Location = New System.Drawing.Point(116, 110)
        Me.TextBoxRegexparav.Name = "TextBoxRegexparav"
        Me.TextBoxRegexparav.Size = New System.Drawing.Size(69, 20)
        Me.TextBoxRegexparav.TabIndex = 12
        Me.TextBoxRegexparav.Text = Global.Rackamtranslate.My.MySettings.Default.regexfor
        Me.TextBoxRegexparav.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxRegexrempav
        '
        Me.TextBoxRegexrempav.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Rackamtranslate.My.MySettings.Default, "regexthis", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxRegexrempav.Location = New System.Drawing.Point(27, 110)
        Me.TextBoxRegexrempav.Name = "TextBoxRegexrempav"
        Me.TextBoxRegexrempav.Size = New System.Drawing.Size(69, 20)
        Me.TextBoxRegexrempav.TabIndex = 13
        Me.TextBoxRegexrempav.Text = Global.Rackamtranslate.My.MySettings.Default.regexthis
        Me.TextBoxRegexrempav.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxRegex
        '
        Me.TextBoxRegex.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Rackamtranslate.My.MySettings.Default, "saveregex", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxRegex.Location = New System.Drawing.Point(26, 34)
        Me.TextBoxRegex.Name = "TextBoxRegex"
        Me.TextBoxRegex.Size = New System.Drawing.Size(192, 20)
        Me.TextBoxRegex.TabIndex = 9
        Me.TextBoxRegex.Text = Global.Rackamtranslate.My.MySettings.Default.saveregex
        '
        'TextBoxRegexforMT
        '
        Me.TextBoxRegexforMT.Location = New System.Drawing.Point(26, 240)
        Me.TextBoxRegexforMT.Name = "TextBoxRegexforMT"
        Me.TextBoxRegexforMT.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxRegexforMT.TabIndex = 20
        Me.TextBoxRegexforMT.Text = """.+"""
        '
        'LabelRegexforMT
        '
        Me.LabelRegexforMT.AutoSize = True
        Me.LabelRegexforMT.Location = New System.Drawing.Point(24, 224)
        Me.LabelRegexforMT.Name = "LabelRegexforMT"
        Me.LabelRegexforMT.Size = New System.Drawing.Size(72, 13)
        Me.LabelRegexforMT.TabIndex = 21
        Me.LabelRegexforMT.Text = "Regex for MT"
        '
        'CheckBoxrempauto
        '
        Me.CheckBoxrempauto.AutoSize = True
        Me.CheckBoxrempauto.Checked = True
        Me.CheckBoxrempauto.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxrempauto.Location = New System.Drawing.Point(217, 110)
        Me.CheckBoxrempauto.Name = "CheckBoxrempauto"
        Me.CheckBoxrempauto.Size = New System.Drawing.Size(90, 17)
        Me.CheckBoxrempauto.TabIndex = 22
        Me.CheckBoxrempauto.Text = "Replace auto"
        Me.CheckBoxrempauto.UseVisualStyleBackColor = True
        '
        'Regexconfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 290)
        Me.Controls.Add(Me.CheckBoxrempauto)
        Me.Controls.Add(Me.LabelRegexforMT)
        Me.Controls.Add(Me.TextBoxRegexforMT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonRestav)
        Me.Controls.Add(Me.ButtonRempav)
        Me.Controls.Add(Me.TextBoxRegexparav)
        Me.Controls.Add(Me.TextBoxRegexrempav)
        Me.Controls.Add(Me.TextBoxRegex)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Regexconfig"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonRestav As Button
    Friend WithEvents ButtonRempav As Button
    Friend WithEvents TextBoxRegexparav As TextBox
    Friend WithEvents TextBoxRegexrempav As TextBox
    Friend WithEvents TextBoxRegex As TextBox
    Friend WithEvents TextBoxRegexforMT As TextBox
    Friend WithEvents LabelRegexforMT As Label
    Friend WithEvents CheckBoxrempauto As CheckBox
End Class
