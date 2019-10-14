<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Remplacement
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
        Me.Buttonrestoreremp = New System.Windows.Forms.Button()
        Me.Buttonapplyremp = New System.Windows.Forms.Button()
        Me.Buttonremoveitemselct = New System.Windows.Forms.Button()
        Me.Buttonadd = New System.Windows.Forms.Button()
        Me.TextBoxremp2 = New System.Windows.Forms.TextBox()
        Me.TextBoxremp1 = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'Buttonrestoreremp
        '
        Me.Buttonrestoreremp.Location = New System.Drawing.Point(369, 367)
        Me.Buttonrestoreremp.Name = "Buttonrestoreremp"
        Me.Buttonrestoreremp.Size = New System.Drawing.Size(105, 28)
        Me.Buttonrestoreremp.TabIndex = 12
        Me.Buttonrestoreremp.Text = "Restore"
        Me.Buttonrestoreremp.UseVisualStyleBackColor = True
        '
        'Buttonapplyremp
        '
        Me.Buttonapplyremp.Location = New System.Drawing.Point(135, 355)
        Me.Buttonapplyremp.Name = "Buttonapplyremp"
        Me.Buttonapplyremp.Size = New System.Drawing.Size(112, 29)
        Me.Buttonapplyremp.TabIndex = 11
        Me.Buttonapplyremp.Text = "Apply"
        Me.Buttonapplyremp.UseVisualStyleBackColor = True
        '
        'Buttonremoveitemselct
        '
        Me.Buttonremoveitemselct.Location = New System.Drawing.Point(636, 60)
        Me.Buttonremoveitemselct.Name = "Buttonremoveitemselct"
        Me.Buttonremoveitemselct.Size = New System.Drawing.Size(60, 21)
        Me.Buttonremoveitemselct.TabIndex = 10
        Me.Buttonremoveitemselct.Text = "-"
        Me.Buttonremoveitemselct.UseVisualStyleBackColor = True
        '
        'Buttonadd
        '
        Me.Buttonadd.Location = New System.Drawing.Point(548, 56)
        Me.Buttonadd.Name = "Buttonadd"
        Me.Buttonadd.Size = New System.Drawing.Size(47, 26)
        Me.Buttonadd.TabIndex = 9
        Me.Buttonadd.Text = "+"
        Me.Buttonadd.UseVisualStyleBackColor = True
        '
        'TextBoxremp2
        '
        Me.TextBoxremp2.Location = New System.Drawing.Point(337, 60)
        Me.TextBoxremp2.Name = "TextBoxremp2"
        Me.TextBoxremp2.Size = New System.Drawing.Size(169, 20)
        Me.TextBoxremp2.TabIndex = 7
        '
        'TextBoxremp1
        '
        Me.TextBoxremp1.Location = New System.Drawing.Point(104, 60)
        Me.TextBoxremp1.Name = "TextBoxremp1"
        Me.TextBoxremp1.Size = New System.Drawing.Size(169, 20)
        Me.TextBoxremp1.TabIndex = 8
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(110, 106)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(407, 224)
        Me.ListView1.TabIndex = 6
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Remplacement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Buttonrestoreremp)
        Me.Controls.Add(Me.Buttonapplyremp)
        Me.Controls.Add(Me.Buttonremoveitemselct)
        Me.Controls.Add(Me.Buttonadd)
        Me.Controls.Add(Me.TextBoxremp2)
        Me.Controls.Add(Me.TextBoxremp1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "Remplacement"
        Me.Text = "Remplacement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Buttonrestoreremp As Button
    Friend WithEvents Buttonapplyremp As Button
    Friend WithEvents Buttonremoveitemselct As Button
    Friend WithEvents Buttonadd As Button
    Friend WithEvents TextBoxremp2 As TextBox
    Friend WithEvents TextBoxremp1 As TextBox
    Friend WithEvents ListView1 As ListView
End Class
