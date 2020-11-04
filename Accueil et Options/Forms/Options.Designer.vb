<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        Me.lbTitre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RbClair = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbSombre = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RetourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbTitre
        '
        Me.lbTitre.AutoSize = True
        Me.lbTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitre.Location = New System.Drawing.Point(160, 9)
        Me.lbTitre.Name = "lbTitre"
        Me.lbTitre.Size = New System.Drawing.Size(144, 39)
        Me.lbTitre.TabIndex = 0
        Me.lbTitre.Text = "Options"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Autre paramètres en dessous..."
        '
        'RbClair
        '
        Me.RbClair.AutoSize = True
        Me.RbClair.Checked = True
        Me.RbClair.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbClair.Location = New System.Drawing.Point(16, 28)
        Me.RbClair.Name = "RbClair"
        Me.RbClair.Size = New System.Drawing.Size(134, 29)
        Me.RbClair.TabIndex = 1
        Me.RbClair.TabStop = True
        Me.RbClair.Text = "Mode Clair"
        Me.RbClair.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbSombre)
        Me.GroupBox1.Controls.Add(Me.RbClair)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(202, 114)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mode visuel"
        '
        'rbSombre
        '
        Me.rbSombre.AutoSize = True
        Me.rbSombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSombre.Location = New System.Drawing.Point(16, 70)
        Me.rbSombre.Name = "rbSombre"
        Me.rbSombre.Size = New System.Drawing.Size(164, 29)
        Me.rbSombre.TabIndex = 2
        Me.rbSombre.Text = "Mode Sombre"
        Me.rbSombre.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RetourToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(464, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RetourToolStripMenuItem
        '
        Me.RetourToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RetourToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop
        Me.RetourToolStripMenuItem.Name = "RetourToolStripMenuItem"
        Me.RetourToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.RetourToolStripMenuItem.Text = "Retour"
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 342)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbTitre)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Options"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbTitre As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RbClair As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbSombre As RadioButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RetourToolStripMenuItem As ToolStripMenuItem
End Class
