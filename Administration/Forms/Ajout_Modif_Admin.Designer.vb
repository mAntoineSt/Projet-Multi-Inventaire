<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajout_Modif_Admin
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
        Me.tbMatricule = New System.Windows.Forms.TextBox()
        Me.tbMdp = New System.Windows.Forms.TextBox()
        Me.bConfirmer = New System.Windows.Forms.Button()
        Me.tbConfirmationMdp = New System.Windows.Forms.TextBox()
        Me.tbNom = New System.Windows.Forms.TextBox()
        Me.tbPrenom = New System.Windows.Forms.TextBox()
        Me.tbDepartementService = New System.Windows.Forms.TextBox()
        Me.tbNumeroBureau = New System.Windows.Forms.TextBox()
        Me.tbPosteTelephonique = New System.Windows.Forms.TextBox()
        Me.tbCellulaire = New System.Windows.Forms.TextBox()
        Me.tbCourriel = New System.Windows.Forms.TextBox()
        Me.tbTelephoneBureau = New System.Windows.Forms.TextBox()
        Me.pHaut = New System.Windows.Forms.Panel()
        Me.lQuitter = New System.Windows.Forms.Label()
        Me.lTitre = New System.Windows.Forms.Label()
        Me.pBas = New System.Windows.Forms.Panel()
        Me.pHaut.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbMatricule
        '
        Me.tbMatricule.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMatricule.ForeColor = System.Drawing.Color.LightGray
        Me.tbMatricule.Location = New System.Drawing.Point(22, 55)
        Me.tbMatricule.Name = "tbMatricule"
        Me.tbMatricule.Size = New System.Drawing.Size(291, 26)
        Me.tbMatricule.TabIndex = 1
        Me.tbMatricule.TabStop = False
        Me.tbMatricule.Text = "Matricule"
        '
        'tbMdp
        '
        Me.tbMdp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMdp.ForeColor = System.Drawing.Color.LightGray
        Me.tbMdp.Location = New System.Drawing.Point(22, 87)
        Me.tbMdp.MaxLength = 25
        Me.tbMdp.Name = "tbMdp"
        Me.tbMdp.Size = New System.Drawing.Size(291, 26)
        Me.tbMdp.TabIndex = 3
        Me.tbMdp.TabStop = False
        Me.tbMdp.Text = "Mot de passe"
        '
        'bConfirmer
        '
        Me.bConfirmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bConfirmer.Location = New System.Drawing.Point(22, 415)
        Me.bConfirmer.Name = "bConfirmer"
        Me.bConfirmer.Size = New System.Drawing.Size(291, 37)
        Me.bConfirmer.TabIndex = 4
        Me.bConfirmer.TabStop = False
        Me.bConfirmer.Text = "CONFIRMER"
        Me.bConfirmer.UseVisualStyleBackColor = True
        '
        'tbConfirmationMdp
        '
        Me.tbConfirmationMdp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbConfirmationMdp.ForeColor = System.Drawing.Color.LightGray
        Me.tbConfirmationMdp.Location = New System.Drawing.Point(22, 120)
        Me.tbConfirmationMdp.MaxLength = 25
        Me.tbConfirmationMdp.Name = "tbConfirmationMdp"
        Me.tbConfirmationMdp.Size = New System.Drawing.Size(291, 26)
        Me.tbConfirmationMdp.TabIndex = 6
        Me.tbConfirmationMdp.TabStop = False
        Me.tbConfirmationMdp.Text = "Confirmation du mot de passe"
        '
        'tbNom
        '
        Me.tbNom.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNom.ForeColor = System.Drawing.Color.LightGray
        Me.tbNom.Location = New System.Drawing.Point(22, 152)
        Me.tbNom.Name = "tbNom"
        Me.tbNom.Size = New System.Drawing.Size(291, 26)
        Me.tbNom.TabIndex = 8
        Me.tbNom.TabStop = False
        Me.tbNom.Text = "Nom"
        '
        'tbPrenom
        '
        Me.tbPrenom.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPrenom.ForeColor = System.Drawing.Color.LightGray
        Me.tbPrenom.Location = New System.Drawing.Point(22, 184)
        Me.tbPrenom.Name = "tbPrenom"
        Me.tbPrenom.Size = New System.Drawing.Size(291, 26)
        Me.tbPrenom.TabIndex = 10
        Me.tbPrenom.TabStop = False
        Me.tbPrenom.Text = "Prénom"
        '
        'tbDepartementService
        '
        Me.tbDepartementService.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDepartementService.ForeColor = System.Drawing.Color.LightGray
        Me.tbDepartementService.Location = New System.Drawing.Point(22, 216)
        Me.tbDepartementService.Name = "tbDepartementService"
        Me.tbDepartementService.Size = New System.Drawing.Size(291, 26)
        Me.tbDepartementService.TabIndex = 12
        Me.tbDepartementService.TabStop = False
        Me.tbDepartementService.Text = "Département/Service/Programme"
        '
        'tbNumeroBureau
        '
        Me.tbNumeroBureau.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNumeroBureau.ForeColor = System.Drawing.Color.LightGray
        Me.tbNumeroBureau.Location = New System.Drawing.Point(22, 248)
        Me.tbNumeroBureau.Name = "tbNumeroBureau"
        Me.tbNumeroBureau.Size = New System.Drawing.Size(291, 26)
        Me.tbNumeroBureau.TabIndex = 14
        Me.tbNumeroBureau.TabStop = False
        Me.tbNumeroBureau.Text = "Numéro de bureau (optionnel)"
        '
        'tbPosteTelephonique
        '
        Me.tbPosteTelephonique.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPosteTelephonique.ForeColor = System.Drawing.Color.LightGray
        Me.tbPosteTelephonique.Location = New System.Drawing.Point(22, 312)
        Me.tbPosteTelephonique.Name = "tbPosteTelephonique"
        Me.tbPosteTelephonique.Size = New System.Drawing.Size(292, 26)
        Me.tbPosteTelephonique.TabIndex = 16
        Me.tbPosteTelephonique.TabStop = False
        Me.tbPosteTelephonique.Text = "Poste téléphonique (Optionnel)"
        '
        'tbCellulaire
        '
        Me.tbCellulaire.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCellulaire.ForeColor = System.Drawing.Color.LightGray
        Me.tbCellulaire.Location = New System.Drawing.Point(22, 344)
        Me.tbCellulaire.Name = "tbCellulaire"
        Me.tbCellulaire.Size = New System.Drawing.Size(292, 26)
        Me.tbCellulaire.TabIndex = 18
        Me.tbCellulaire.TabStop = False
        Me.tbCellulaire.Text = "Cellulaire (Optionnel)"
        '
        'tbCourriel
        '
        Me.tbCourriel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCourriel.ForeColor = System.Drawing.Color.LightGray
        Me.tbCourriel.Location = New System.Drawing.Point(22, 376)
        Me.tbCourriel.Name = "tbCourriel"
        Me.tbCourriel.Size = New System.Drawing.Size(292, 26)
        Me.tbCourriel.TabIndex = 20
        Me.tbCourriel.TabStop = False
        Me.tbCourriel.Text = "Courriel (Optionnel)"
        '
        'tbTelephoneBureau
        '
        Me.tbTelephoneBureau.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTelephoneBureau.ForeColor = System.Drawing.Color.LightGray
        Me.tbTelephoneBureau.Location = New System.Drawing.Point(22, 280)
        Me.tbTelephoneBureau.Name = "tbTelephoneBureau"
        Me.tbTelephoneBureau.Size = New System.Drawing.Size(291, 26)
        Me.tbTelephoneBureau.TabIndex = 22
        Me.tbTelephoneBureau.TabStop = False
        Me.tbTelephoneBureau.Text = "Téléphone de bureau (optionnel)"
        '
        'pHaut
        '
        Me.pHaut.Controls.Add(Me.lQuitter)
        Me.pHaut.Controls.Add(Me.lTitre)
        Me.pHaut.Location = New System.Drawing.Point(0, 0)
        Me.pHaut.Name = "pHaut"
        Me.pHaut.Size = New System.Drawing.Size(338, 39)
        Me.pHaut.TabIndex = 23
        '
        'lQuitter
        '
        Me.lQuitter.AutoSize = True
        Me.lQuitter.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.lQuitter.ForeColor = System.Drawing.Color.White
        Me.lQuitter.Location = New System.Drawing.Point(305, 5)
        Me.lQuitter.Name = "lQuitter"
        Me.lQuitter.Size = New System.Drawing.Size(26, 28)
        Me.lQuitter.TabIndex = 1
        Me.lQuitter.Text = "X"
        '
        'lTitre
        '
        Me.lTitre.AutoSize = True
        Me.lTitre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTitre.ForeColor = System.Drawing.Color.White
        Me.lTitre.Location = New System.Drawing.Point(13, 10)
        Me.lTitre.Name = "lTitre"
        Me.lTitre.Size = New System.Drawing.Size(45, 18)
        Me.lTitre.TabIndex = 0
        Me.lTitre.Text = "Titre"
        '
        'pBas
        '
        Me.pBas.Location = New System.Drawing.Point(0, 467)
        Me.pBas.Name = "pBas"
        Me.pBas.Size = New System.Drawing.Size(338, 26)
        Me.pBas.TabIndex = 24
        '
        'Ajout_Modif_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 493)
        Me.Controls.Add(Me.pBas)
        Me.Controls.Add(Me.pHaut)
        Me.Controls.Add(Me.tbTelephoneBureau)
        Me.Controls.Add(Me.tbCourriel)
        Me.Controls.Add(Me.tbCellulaire)
        Me.Controls.Add(Me.tbPosteTelephonique)
        Me.Controls.Add(Me.tbNumeroBureau)
        Me.Controls.Add(Me.tbDepartementService)
        Me.Controls.Add(Me.tbPrenom)
        Me.Controls.Add(Me.tbNom)
        Me.Controls.Add(Me.tbConfirmationMdp)
        Me.Controls.Add(Me.bConfirmer)
        Me.Controls.Add(Me.tbMdp)
        Me.Controls.Add(Me.tbMatricule)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ajout_Modif_Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajout_Modif_Admin (NOM CHANGEMENTS)"
        Me.pHaut.ResumeLayout(False)
        Me.pHaut.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbMatricule As TextBox
    Friend WithEvents tbMdp As TextBox
    Friend WithEvents bConfirmer As Button
    Friend WithEvents tbConfirmationMdp As TextBox
    Friend WithEvents tbNom As TextBox
    Friend WithEvents tbPrenom As TextBox
    Friend WithEvents tbDepartementService As TextBox
    Friend WithEvents tbNumeroBureau As TextBox
    Friend WithEvents tbPosteTelephonique As TextBox
    Friend WithEvents tbCellulaire As TextBox
    Friend WithEvents tbCourriel As TextBox
    Friend WithEvents tbTelephoneBureau As TextBox
    Friend WithEvents pHaut As Panel
    Friend WithEvents pBas As Panel
    Friend WithEvents lQuitter As Label
    Friend WithEvents lTitre As Label
End Class
