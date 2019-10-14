<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonRestav = New System.Windows.Forms.Button()
        Me.ButtonRempav = New System.Windows.Forms.Button()
        Me.TextBoxRegexparav = New System.Windows.Forms.TextBox()
        Me.TextBoxRegexrempav = New System.Windows.Forms.TextBox()
        Me.TextBoxRegexav2 = New System.Windows.Forms.TextBox()
        Me.TextBoxRegexav1 = New System.Windows.Forms.TextBox()
        Me.TextBoxRegex = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(23, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "In this regex replace"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(349, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "For"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(242, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "This"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(23, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Regex"
        '
        'ButtonRestav
        '
        Me.ButtonRestav.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonRestav.Location = New System.Drawing.Point(242, 225)
        Me.ButtonRestav.Name = "ButtonRestav"
        Me.ButtonRestav.Size = New System.Drawing.Size(94, 24)
        Me.ButtonRestav.TabIndex = 15
        Me.ButtonRestav.Text = "Restore"
        Me.ButtonRestav.UseVisualStyleBackColor = True
        '
        'ButtonRempav
        '
        Me.ButtonRempav.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonRempav.Location = New System.Drawing.Point(65, 225)
        Me.ButtonRempav.Name = "ButtonRempav"
        Me.ButtonRempav.Size = New System.Drawing.Size(87, 24)
        Me.ButtonRempav.TabIndex = 14
        Me.ButtonRempav.Text = "Apply"
        Me.ButtonRempav.UseVisualStyleBackColor = True
        '
        'TextBoxRegexparav
        '
        Me.TextBoxRegexparav.Location = New System.Drawing.Point(349, 164)
        Me.TextBoxRegexparav.Name = "TextBoxRegexparav"
        Me.TextBoxRegexparav.Size = New System.Drawing.Size(35, 20)
        Me.TextBoxRegexparav.TabIndex = 12
        Me.TextBoxRegexparav.Text = "¤"
        Me.TextBoxRegexparav.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxRegexrempav
        '
        Me.TextBoxRegexrempav.Location = New System.Drawing.Point(242, 164)
        Me.TextBoxRegexrempav.Name = "TextBoxRegexrempav"
        Me.TextBoxRegexrempav.Size = New System.Drawing.Size(35, 20)
        Me.TextBoxRegexrempav.TabIndex = 13
        Me.TextBoxRegexrempav.Text = """"
        Me.TextBoxRegexrempav.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxRegexav2
        '
        Me.TextBoxRegexav2.Location = New System.Drawing.Point(23, 187)
        Me.TextBoxRegexav2.Name = "TextBoxRegexav2"
        Me.TextBoxRegexav2.Size = New System.Drawing.Size(129, 20)
        Me.TextBoxRegexav2.TabIndex = 10
        Me.TextBoxRegexav2.Text = "old "".+"""
        '
        'TextBoxRegexav1
        '
        Me.TextBoxRegexav1.Location = New System.Drawing.Point(23, 143)
        Me.TextBoxRegexav1.Name = "TextBoxRegexav1"
        Me.TextBoxRegexav1.Size = New System.Drawing.Size(129, 20)
        Me.TextBoxRegexav1.TabIndex = 11
        Me.TextBoxRegexav1.Text = "#.+"".+"""
        '
        'TextBoxRegex
        '
        Me.TextBoxRegex.Location = New System.Drawing.Point(23, 34)
        Me.TextBoxRegex.Name = "TextBoxRegex"
        Me.TextBoxRegex.Size = New System.Drawing.Size(192, 20)
        Me.TextBoxRegex.TabIndex = 9
        Me.TextBoxRegex.Text = "(\s\s\s\s""|\s\s\s\s\w+\s"")(.+)("")"
        '
        'Regexconfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 290)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonRestav)
        Me.Controls.Add(Me.ButtonRempav)
        Me.Controls.Add(Me.TextBoxRegexparav)
        Me.Controls.Add(Me.TextBoxRegexrempav)
        Me.Controls.Add(Me.TextBoxRegexav2)
        Me.Controls.Add(Me.TextBoxRegexav1)
        Me.Controls.Add(Me.TextBoxRegex)
        Me.Name = "Regexconfig"
        Me.Text = "Regexconfig"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonRestav As Button
    Friend WithEvents ButtonRempav As Button
    Friend WithEvents TextBoxRegexparav As TextBox
    Friend WithEvents TextBoxRegexrempav As TextBox
    Friend WithEvents TextBoxRegexav2 As TextBox
    Friend WithEvents TextBoxRegexav1 As TextBox
    Friend WithEvents TextBoxRegex As TextBox
End Class
