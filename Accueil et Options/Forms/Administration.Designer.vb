<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administration
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
        Me.lbMessageRole = New System.Windows.Forms.Label()
        Me.lbRole = New System.Windows.Forms.Label()
        Me.btStats = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbTitre
        '
        Me.lbTitre.AutoSize = True
        Me.lbTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitre.Location = New System.Drawing.Point(104, 19)
        Me.lbTitre.Name = "lbTitre"
        Me.lbTitre.Size = New System.Drawing.Size(372, 42)
        Me.lbTitre.TabIndex = 0
        Me.lbTitre.Text = "Menu administration"
        '
        'lbMessageRole
        '
        Me.lbMessageRole.AutoSize = True
        Me.lbMessageRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMessageRole.Location = New System.Drawing.Point(194, 70)
        Me.lbMessageRole.Name = "lbMessageRole"
        Me.lbMessageRole.Size = New System.Drawing.Size(101, 20)
        Me.lbMessageRole.TabIndex = 1
        Me.lbMessageRole.Text = "Rôle actuel : "
        '
        'lbRole
        '
        Me.lbRole.AutoSize = True
        Me.lbRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRole.Location = New System.Drawing.Point(301, 70)
        Me.lbRole.Name = "lbRole"
        Me.lbRole.Size = New System.Drawing.Size(53, 20)
        Me.lbRole.TabIndex = 2
        Me.lbRole.Text = "ROLE"
        '
        'btStats
        '
        Me.btStats.Location = New System.Drawing.Point(73, 137)
        Me.btStats.Name = "btStats"
        Me.btStats.Size = New System.Drawing.Size(120, 32)
        Me.btStats.TabIndex = 3
        Me.btStats.Text = "Voir les statistiques"
        Me.btStats.UseVisualStyleBackColor = True
        '
        'Administration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 292)
        Me.Controls.Add(Me.btStats)
        Me.Controls.Add(Me.lbRole)
        Me.Controls.Add(Me.lbMessageRole)
        Me.Controls.Add(Me.lbTitre)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Administration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbTitre As Label
    Friend WithEvents lbMessageRole As Label
    Friend WithEvents lbRole As Label
    Friend WithEvents btStats As Button
End Class
