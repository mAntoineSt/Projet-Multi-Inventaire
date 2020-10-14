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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Administration))
        Me.pUserControls = New System.Windows.Forms.Panel()
        Me.msMenu = New System.Windows.Forms.MenuStrip()
        Me.msRetourAccueil = New System.Windows.Forms.ToolStripMenuItem()
        Me.msAccueilAdmin = New System.Windows.Forms.ToolStripMenuItem()
        Me.msGestionAdmins = New System.Windows.Forms.ToolStripMenuItem()
        Me.msGestionEmprunteurs = New System.Windows.Forms.ToolStripMenuItem()
        Me.msGestionPreteurs = New System.Windows.Forms.ToolStripMenuItem()
        Me.msStatistiques = New System.Windows.Forms.ToolStripMenuItem()
        Me.msMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pUserControls
        '
        Me.pUserControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pUserControls.Location = New System.Drawing.Point(0, 28)
        Me.pUserControls.Name = "pUserControls"
        Me.pUserControls.Size = New System.Drawing.Size(1013, 473)
        Me.pUserControls.TabIndex = 1
        '
        'msMenu
        '
        Me.msMenu.BackColor = System.Drawing.Color.Transparent
        Me.msMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msRetourAccueil, Me.msAccueilAdmin, Me.msGestionAdmins, Me.msGestionEmprunteurs, Me.msGestionPreteurs, Me.msStatistiques})
        Me.msMenu.Location = New System.Drawing.Point(0, 0)
        Me.msMenu.Name = "msMenu"
        Me.msMenu.Size = New System.Drawing.Size(1013, 28)
        Me.msMenu.TabIndex = 2
        Me.msMenu.Text = "msMenu"
        '
        'msRetourAccueil
        '
        Me.msRetourAccueil.BackColor = System.Drawing.Color.Black
        Me.msRetourAccueil.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.msRetourAccueil.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.msRetourAccueil.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.msRetourAccueil.Name = "msRetourAccueil"
        Me.msRetourAccueil.Size = New System.Drawing.Size(134, 24)
        Me.msRetourAccueil.Text = "Retour à l'accueil"
        '
        'msAccueilAdmin
        '
        Me.msAccueilAdmin.BackColor = System.Drawing.Color.Black
        Me.msAccueilAdmin.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.msAccueilAdmin.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.msAccueilAdmin.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.msAccueilAdmin.Name = "msAccueilAdmin"
        Me.msAccueilAdmin.Size = New System.Drawing.Size(157, 24)
        Me.msAccueilAdmin.Text = "Accueil administratif"
        '
        'msGestionAdmins
        '
        Me.msGestionAdmins.BackColor = System.Drawing.Color.Black
        Me.msGestionAdmins.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.msGestionAdmins.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.msGestionAdmins.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.msGestionAdmins.Name = "msGestionAdmins"
        Me.msGestionAdmins.Size = New System.Drawing.Size(204, 24)
        Me.msGestionAdmins.Text = "Gestion des administrateurs"
        '
        'msGestionEmprunteurs
        '
        Me.msGestionEmprunteurs.BackColor = System.Drawing.Color.Black
        Me.msGestionEmprunteurs.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.msGestionEmprunteurs.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.msGestionEmprunteurs.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.msGestionEmprunteurs.Name = "msGestionEmprunteurs"
        Me.msGestionEmprunteurs.Size = New System.Drawing.Size(185, 24)
        Me.msGestionEmprunteurs.Text = "Gestion des emprunteurs"
        '
        'msGestionPreteurs
        '
        Me.msGestionPreteurs.BackColor = System.Drawing.Color.Black
        Me.msGestionPreteurs.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.msGestionPreteurs.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.msGestionPreteurs.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.msGestionPreteurs.Name = "msGestionPreteurs"
        Me.msGestionPreteurs.Size = New System.Drawing.Size(156, 24)
        Me.msGestionPreteurs.Text = "Gestion des prêteurs"
        '
        'msStatistiques
        '
        Me.msStatistiques.BackColor = System.Drawing.Color.Black
        Me.msStatistiques.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.msStatistiques.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.msStatistiques.Name = "msStatistiques"
        Me.msStatistiques.Size = New System.Drawing.Size(97, 24)
        Me.msStatistiques.Text = "Statistiques"
        '
        'Administration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 501)
        Me.Controls.Add(Me.pUserControls)
        Me.Controls.Add(Me.msMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Administration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administration"
        Me.msMenu.ResumeLayout(False)
        Me.msMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pUserControls As Panel
    Friend WithEvents msMenu As MenuStrip
    Friend WithEvents msRetourAccueil As ToolStripMenuItem
    Friend WithEvents msAccueilAdmin As ToolStripMenuItem
    Friend WithEvents msGestionAdmins As ToolStripMenuItem
    Friend WithEvents msGestionEmprunteurs As ToolStripMenuItem
    Friend WithEvents msGestionPreteurs As ToolStripMenuItem
    Friend WithEvents msStatistiques As ToolStripMenuItem
End Class
