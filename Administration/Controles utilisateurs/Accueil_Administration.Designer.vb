<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Accueil_Administration
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.lTitre = New System.Windows.Forms.Label()
        Me.lTitreRole = New System.Windows.Forms.Label()
        Me.lRole = New System.Windows.Forms.Label()
        Me.lTitreAcces = New System.Windows.Forms.Label()
        Me.lTitrePasAcces = New System.Windows.Forms.Label()
        Me.pAcces = New System.Windows.Forms.Panel()
        Me.lAccesStatistiques = New System.Windows.Forms.Label()
        Me.lAccesGestionAdmins = New System.Windows.Forms.Label()
        Me.lAccesGestionPreteurs = New System.Windows.Forms.Label()
        Me.lAccesGestionEmprunteurs = New System.Windows.Forms.Label()
        Me.pPasAcces = New System.Windows.Forms.Panel()
        Me.lPasAccesGestionStats = New System.Windows.Forms.Label()
        Me.lPasAccesGestionAdmins = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pAcces.SuspendLayout()
        Me.pPasAcces.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lTitre
        '
        Me.lTitre.AutoSize = True
        Me.lTitre.Font = New System.Drawing.Font("Perpetua Titling MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTitre.Location = New System.Drawing.Point(83, 17)
        Me.lTitre.Name = "lTitre"
        Me.lTitre.Size = New System.Drawing.Size(381, 32)
        Me.lTitre.TabIndex = 0
        Me.lTitre.Text = "Partie administrative"
        '
        'lTitreRole
        '
        Me.lTitreRole.AutoSize = True
        Me.lTitreRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lTitreRole.Location = New System.Drawing.Point(187, 91)
        Me.lTitreRole.Name = "lTitreRole"
        Me.lTitreRole.Size = New System.Drawing.Size(112, 25)
        Me.lTitreRole.TabIndex = 1
        Me.lTitreRole.Text = "Votre rôle : "
        '
        'lRole
        '
        Me.lRole.AutoSize = True
        Me.lRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lRole.Location = New System.Drawing.Point(303, 95)
        Me.lRole.Name = "lRole"
        Me.lRole.Size = New System.Drawing.Size(57, 20)
        Me.lRole.TabIndex = 2
        Me.lRole.Text = "ROLE"
        '
        'lTitreAcces
        '
        Me.lTitreAcces.AutoSize = True
        Me.lTitreAcces.BackColor = System.Drawing.Color.Lime
        Me.lTitreAcces.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lTitreAcces.Location = New System.Drawing.Point(107, 192)
        Me.lTitreAcces.Name = "lTitreAcces"
        Me.lTitreAcces.Size = New System.Drawing.Size(238, 24)
        Me.lTitreAcces.TabIndex = 3
        Me.lTitreAcces.Text = "Ce que vous avez accès"
        '
        'lTitrePasAcces
        '
        Me.lTitrePasAcces.AutoSize = True
        Me.lTitrePasAcces.BackColor = System.Drawing.Color.Red
        Me.lTitrePasAcces.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lTitrePasAcces.Location = New System.Drawing.Point(622, 192)
        Me.lTitrePasAcces.Name = "lTitrePasAcces"
        Me.lTitrePasAcces.Size = New System.Drawing.Size(294, 24)
        Me.lTitrePasAcces.TabIndex = 4
        Me.lTitrePasAcces.Text = "Ce que vous n'avez pas accès"
        '
        'pAcces
        '
        Me.pAcces.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pAcces.Controls.Add(Me.lAccesStatistiques)
        Me.pAcces.Controls.Add(Me.lAccesGestionAdmins)
        Me.pAcces.Controls.Add(Me.lAccesGestionPreteurs)
        Me.pAcces.Controls.Add(Me.lAccesGestionEmprunteurs)
        Me.pAcces.Location = New System.Drawing.Point(97, 219)
        Me.pAcces.Name = "pAcces"
        Me.pAcces.Size = New System.Drawing.Size(258, 242)
        Me.pAcces.TabIndex = 5
        '
        'lAccesStatistiques
        '
        Me.lAccesStatistiques.AutoSize = True
        Me.lAccesStatistiques.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lAccesStatistiques.Location = New System.Drawing.Point(14, 120)
        Me.lAccesStatistiques.Name = "lAccesStatistiques"
        Me.lAccesStatistiques.Size = New System.Drawing.Size(120, 18)
        Me.lAccesStatistiques.TabIndex = 3
        Me.lAccesStatistiques.Text = "• Aux statistiques"
        '
        'lAccesGestionAdmins
        '
        Me.lAccesGestionAdmins.AutoSize = True
        Me.lAccesGestionAdmins.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lAccesGestionAdmins.Location = New System.Drawing.Point(14, 84)
        Me.lAccesGestionAdmins.Name = "lAccesGestionAdmins"
        Me.lAccesGestionAdmins.Size = New System.Drawing.Size(227, 18)
        Me.lAccesGestionAdmins.TabIndex = 2
        Me.lAccesGestionAdmins.Text = "• À la gestion des administrateurs"
        '
        'lAccesGestionPreteurs
        '
        Me.lAccesGestionPreteurs.AutoSize = True
        Me.lAccesGestionPreteurs.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lAccesGestionPreteurs.Location = New System.Drawing.Point(14, 54)
        Me.lAccesGestionPreteurs.Name = "lAccesGestionPreteurs"
        Me.lAccesGestionPreteurs.Size = New System.Drawing.Size(180, 18)
        Me.lAccesGestionPreteurs.TabIndex = 1
        Me.lAccesGestionPreteurs.Text = "• À la gestion des prêteurs"
        '
        'lAccesGestionEmprunteurs
        '
        Me.lAccesGestionEmprunteurs.AutoSize = True
        Me.lAccesGestionEmprunteurs.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lAccesGestionEmprunteurs.Location = New System.Drawing.Point(14, 24)
        Me.lAccesGestionEmprunteurs.Name = "lAccesGestionEmprunteurs"
        Me.lAccesGestionEmprunteurs.Size = New System.Drawing.Size(209, 18)
        Me.lAccesGestionEmprunteurs.TabIndex = 0
        Me.lAccesGestionEmprunteurs.Text = "• À la gestion des emprunteurs"
        '
        'pPasAcces
        '
        Me.pPasAcces.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pPasAcces.Controls.Add(Me.lPasAccesGestionStats)
        Me.pPasAcces.Controls.Add(Me.lPasAccesGestionAdmins)
        Me.pPasAcces.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.pPasAcces.Location = New System.Drawing.Point(643, 219)
        Me.pPasAcces.Name = "pPasAcces"
        Me.pPasAcces.Size = New System.Drawing.Size(258, 242)
        Me.pPasAcces.TabIndex = 6
        '
        'lPasAccesGestionStats
        '
        Me.lPasAccesGestionStats.AutoSize = True
        Me.lPasAccesGestionStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lPasAccesGestionStats.Location = New System.Drawing.Point(14, 60)
        Me.lPasAccesGestionStats.Name = "lPasAccesGestionStats"
        Me.lPasAccesGestionStats.Size = New System.Drawing.Size(120, 18)
        Me.lPasAccesGestionStats.TabIndex = 5
        Me.lPasAccesGestionStats.Text = "• Aux statistiques"
        '
        'lPasAccesGestionAdmins
        '
        Me.lPasAccesGestionAdmins.AutoSize = True
        Me.lPasAccesGestionAdmins.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lPasAccesGestionAdmins.Location = New System.Drawing.Point(14, 24)
        Me.lPasAccesGestionAdmins.Name = "lPasAccesGestionAdmins"
        Me.lPasAccesGestionAdmins.Size = New System.Drawing.Size(227, 18)
        Me.lPasAccesGestionAdmins.TabIndex = 4
        Me.lPasAccesGestionAdmins.Text = "• À la gestion des administrateurs"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.lTitre)
        Me.Panel1.Controls.Add(Me.lTitreRole)
        Me.Panel1.Controls.Add(Me.lRole)
        Me.Panel1.Location = New System.Drawing.Point(233, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(547, 150)
        Me.Panel1.TabIndex = 7
        '
        'Accueil_Administration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pPasAcces)
        Me.Controls.Add(Me.pAcces)
        Me.Controls.Add(Me.lTitrePasAcces)
        Me.Controls.Add(Me.lTitreAcces)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Name = "Accueil_Administration"
        Me.Size = New System.Drawing.Size(1013, 473)
        Me.pAcces.ResumeLayout(False)
        Me.pAcces.PerformLayout()
        Me.pPasAcces.ResumeLayout(False)
        Me.pPasAcces.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lTitre As Label
    Friend WithEvents lTitreRole As Label
    Friend WithEvents lRole As Label
    Friend WithEvents lTitreAcces As Label
    Friend WithEvents lTitrePasAcces As Label
    Friend WithEvents pAcces As Panel
    Friend WithEvents lAccesGestionAdmins As Label
    Friend WithEvents lAccesGestionPreteurs As Label
    Friend WithEvents lAccesGestionEmprunteurs As Label
    Friend WithEvents pPasAcces As Panel
    Friend WithEvents lAccesStatistiques As Label
    Friend WithEvents lPasAccesGestionStats As Label
    Friend WithEvents lPasAccesGestionAdmins As Label
    Friend WithEvents Panel1 As Panel
End Class
