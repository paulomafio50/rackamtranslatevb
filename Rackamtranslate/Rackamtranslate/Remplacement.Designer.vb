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
        Me.components = New System.ComponentModel.Container()
        Me.Buttonrestoreremp = New System.Windows.Forms.Button()
        Me.Buttonapplyremp = New System.Windows.Forms.Button()
        Me.Buttonadd = New System.Windows.Forms.Button()
        Me.TextBoxremp2 = New System.Windows.Forms.TextBox()
        Me.TextBoxremp1 = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Source = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Target = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Buttonrestoreremp
        '
        Me.Buttonrestoreremp.Location = New System.Drawing.Point(422, 356)
        Me.Buttonrestoreremp.Name = "Buttonrestoreremp"
        Me.Buttonrestoreremp.Size = New System.Drawing.Size(105, 28)
        Me.Buttonrestoreremp.TabIndex = 12
        Me.Buttonrestoreremp.Text = "Restore"
        Me.Buttonrestoreremp.UseVisualStyleBackColor = True
        '
        'Buttonapplyremp
        '
        Me.Buttonapplyremp.Location = New System.Drawing.Point(120, 355)
        Me.Buttonapplyremp.Name = "Buttonapplyremp"
        Me.Buttonapplyremp.Size = New System.Drawing.Size(112, 29)
        Me.Buttonapplyremp.TabIndex = 11
        Me.Buttonapplyremp.Text = "Apply"
        Me.Buttonapplyremp.UseVisualStyleBackColor = True
        '
        'Buttonadd
        '
        Me.Buttonadd.Location = New System.Drawing.Point(548, 60)
        Me.Buttonadd.Name = "Buttonadd"
        Me.Buttonadd.Size = New System.Drawing.Size(37, 22)
        Me.Buttonadd.TabIndex = 9
        Me.Buttonadd.Text = "add"
        Me.Buttonadd.UseVisualStyleBackColor = True
        '
        'TextBoxremp2
        '
        Me.TextBoxremp2.Location = New System.Drawing.Point(358, 60)
        Me.TextBoxremp2.Name = "TextBoxremp2"
        Me.TextBoxremp2.Size = New System.Drawing.Size(169, 20)
        Me.TextBoxremp2.TabIndex = 7
        '
        'TextBoxremp1
        '
        Me.TextBoxremp1.Location = New System.Drawing.Point(120, 60)
        Me.TextBoxremp1.Name = "TextBoxremp1"
        Me.TextBoxremp1.Size = New System.Drawing.Size(169, 20)
        Me.TextBoxremp1.TabIndex = 8
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Source, Me.Target})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(120, 101)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(407, 224)
        Me.ListView1.TabIndex = 6
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Source
        '
        Me.Source.Text = "Source"
        Me.Source.Width = 199
        '
        'Target
        '
        Me.Target.Text = "Target"
        Me.Target.Width = 172
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(160, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(159, 22)
        Me.ToolStripMenuItem1.Text = "Remove item"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(159, 22)
        Me.ToolStripMenuItem2.Text = "Remove all item"
        '
        'Remplacement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Buttonrestoreremp)
        Me.Controls.Add(Me.Buttonapplyremp)
        Me.Controls.Add(Me.Buttonadd)
        Me.Controls.Add(Me.TextBoxremp2)
        Me.Controls.Add(Me.TextBoxremp1)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Remplacement"
        Me.ShowIcon = False
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Buttonrestoreremp As Button
    Friend WithEvents Buttonapplyremp As Button
    Friend WithEvents Buttonadd As Button
    Friend WithEvents TextBoxremp2 As TextBox
    Friend WithEvents TextBoxremp1 As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Source As ColumnHeader
    Friend WithEvents Target As ColumnHeader
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
End Class
