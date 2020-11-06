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
        Me.lMatricule = New System.Windows.Forms.Label()
        Me.tbMatricule = New System.Windows.Forms.TextBox()
        Me.tbMdp = New System.Windows.Forms.TextBox()
        Me.lMdp = New System.Windows.Forms.Label()
        Me.bConfirmer = New System.Windows.Forms.Button()
        Me.tbConfirmationMdp = New System.Windows.Forms.TextBox()
        Me.lConfirmationMdp = New System.Windows.Forms.Label()
        Me.tbNom = New System.Windows.Forms.TextBox()
        Me.lNom = New System.Windows.Forms.Label()
        Me.tbPrenom = New System.Windows.Forms.TextBox()
        Me.lPrenom = New System.Windows.Forms.Label()
        Me.tbDepartementService = New System.Windows.Forms.TextBox()
        Me.lDepartementService = New System.Windows.Forms.Label()
        Me.tbNumeroBureau = New System.Windows.Forms.TextBox()
        Me.lNumeroBureau = New System.Windows.Forms.Label()
        Me.tbPosteTelephonique = New System.Windows.Forms.TextBox()
        Me.lPosteTelephonique = New System.Windows.Forms.Label()
        Me.tbCellulaire = New System.Windows.Forms.TextBox()
        Me.lCellulaire = New System.Windows.Forms.Label()
        Me.tbCourriel = New System.Windows.Forms.TextBox()
        Me.lCourriel = New System.Windows.Forms.Label()
        Me.tbTelephoneBureau = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lMatricule
        '
        Me.lMatricule.AutoSize = True
        Me.lMatricule.Location = New System.Drawing.Point(52, 19)
        Me.lMatricule.Name = "lMatricule"
        Me.lMatricule.Size = New System.Drawing.Size(56, 13)
        Me.lMatricule.TabIndex = 0
        Me.lMatricule.Text = "Matricule :"
        '
        'tbMatricule
        '
        Me.tbMatricule.Location = New System.Drawing.Point(108, 16)
        Me.tbMatricule.Name = "tbMatricule"
        Me.tbMatricule.Size = New System.Drawing.Size(206, 20)
        Me.tbMatricule.TabIndex = 1
        '
        'tbMdp
        '
        Me.tbMdp.Location = New System.Drawing.Point(108, 44)
        Me.tbMdp.Name = "tbMdp"
        Me.tbMdp.Size = New System.Drawing.Size(206, 20)
        Me.tbMdp.TabIndex = 3
        Me.tbMdp.UseSystemPasswordChar = True
        '
        'lMdp
        '
        Me.lMdp.AutoSize = True
        Me.lMdp.Location = New System.Drawing.Point(30, 47)
        Me.lMdp.Name = "lMdp"
        Me.lMdp.Size = New System.Drawing.Size(77, 13)
        Me.lMdp.TabIndex = 2
        Me.lMdp.Text = "Mot de passe :"
        '
        'bConfirmer
        '
        Me.bConfirmer.Location = New System.Drawing.Point(93, 370)
        Me.bConfirmer.Name = "bConfirmer"
        Me.bConfirmer.Size = New System.Drawing.Size(151, 37)
        Me.bConfirmer.TabIndex = 4
        Me.bConfirmer.Text = "Confirmer"
        Me.bConfirmer.UseVisualStyleBackColor = True
        '
        'tbConfirmationMdp
        '
        Me.tbConfirmationMdp.Location = New System.Drawing.Point(108, 81)
        Me.tbConfirmationMdp.Name = "tbConfirmationMdp"
        Me.tbConfirmationMdp.Size = New System.Drawing.Size(206, 20)
        Me.tbConfirmationMdp.TabIndex = 6
        Me.tbConfirmationMdp.UseSystemPasswordChar = True
        '
        'lConfirmationMdp
        '
        Me.lConfirmationMdp.AutoSize = True
        Me.lConfirmationMdp.Location = New System.Drawing.Point(22, 71)
        Me.lConfirmationMdp.Name = "lConfirmationMdp"
        Me.lConfirmationMdp.Size = New System.Drawing.Size(85, 26)
        Me.lConfirmationMdp.TabIndex = 5
        Me.lConfirmationMdp.Text = "Confirmation du" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   mot de passe :"
        '
        'tbNom
        '
        Me.tbNom.Location = New System.Drawing.Point(108, 107)
        Me.tbNom.Name = "tbNom"
        Me.tbNom.Size = New System.Drawing.Size(206, 20)
        Me.tbNom.TabIndex = 8
        '
        'lNom
        '
        Me.lNom.AutoSize = True
        Me.lNom.Location = New System.Drawing.Point(67, 110)
        Me.lNom.Name = "lNom"
        Me.lNom.Size = New System.Drawing.Size(35, 13)
        Me.lNom.TabIndex = 7
        Me.lNom.Text = "Nom :"
        '
        'tbPrenom
        '
        Me.tbPrenom.Location = New System.Drawing.Point(108, 133)
        Me.tbPrenom.Name = "tbPrenom"
        Me.tbPrenom.Size = New System.Drawing.Size(206, 20)
        Me.tbPrenom.TabIndex = 10
        '
        'lPrenom
        '
        Me.lPrenom.AutoSize = True
        Me.lPrenom.Location = New System.Drawing.Point(53, 136)
        Me.lPrenom.Name = "lPrenom"
        Me.lPrenom.Size = New System.Drawing.Size(49, 13)
        Me.lPrenom.TabIndex = 9
        Me.lPrenom.Text = "Prénom :"
        '
        'tbDepartementService
        '
        Me.tbDepartementService.Location = New System.Drawing.Point(109, 171)
        Me.tbDepartementService.Name = "tbDepartementService"
        Me.tbDepartementService.Size = New System.Drawing.Size(206, 20)
        Me.tbDepartementService.TabIndex = 12
        '
        'lDepartementService
        '
        Me.lDepartementService.AutoSize = True
        Me.lDepartementService.Location = New System.Drawing.Point(30, 162)
        Me.lDepartementService.Name = "lDepartementService"
        Me.lDepartementService.Size = New System.Drawing.Size(73, 26)
        Me.lDepartementService.TabIndex = 11
        Me.lDepartementService.Text = "Département/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        Service :"
        '
        'tbNumeroBureau
        '
        Me.tbNumeroBureau.Location = New System.Drawing.Point(108, 211)
        Me.tbNumeroBureau.Name = "tbNumeroBureau"
        Me.tbNumeroBureau.Size = New System.Drawing.Size(206, 20)
        Me.tbNumeroBureau.TabIndex = 14
        '
        'lNumeroBureau
        '
        Me.lNumeroBureau.AutoSize = True
        Me.lNumeroBureau.Location = New System.Drawing.Point(38, 201)
        Me.lNumeroBureau.Name = "lNumeroBureau"
        Me.lNumeroBureau.Size = New System.Drawing.Size(64, 26)
        Me.lNumeroBureau.TabIndex = 13
        Me.lNumeroBureau.Text = "Numéro de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      bureau :"
        '
        'tbPosteTelephonique
        '
        Me.tbPosteTelephonique.Location = New System.Drawing.Point(108, 273)
        Me.tbPosteTelephonique.Name = "tbPosteTelephonique"
        Me.tbPosteTelephonique.Size = New System.Drawing.Size(206, 20)
        Me.tbPosteTelephonique.TabIndex = 16
        '
        'lPosteTelephonique
        '
        Me.lPosteTelephonique.AutoSize = True
        Me.lPosteTelephonique.Location = New System.Drawing.Point(27, 264)
        Me.lPosteTelephonique.Name = "lPosteTelephonique"
        Me.lPosteTelephonique.Size = New System.Drawing.Size(78, 26)
        Me.lPosteTelephonique.TabIndex = 15
        Me.lPosteTelephonique.Text = "Poste" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Téléphonique :"
        '
        'tbCellulaire
        '
        Me.tbCellulaire.Location = New System.Drawing.Point(109, 307)
        Me.tbCellulaire.Name = "tbCellulaire"
        Me.tbCellulaire.Size = New System.Drawing.Size(206, 20)
        Me.tbCellulaire.TabIndex = 18
        '
        'lCellulaire
        '
        Me.lCellulaire.AutoSize = True
        Me.lCellulaire.Location = New System.Drawing.Point(47, 311)
        Me.lCellulaire.Name = "lCellulaire"
        Me.lCellulaire.Size = New System.Drawing.Size(55, 13)
        Me.lCellulaire.TabIndex = 17
        Me.lCellulaire.Text = "Cellulaire :"
        '
        'tbCourriel
        '
        Me.tbCourriel.Location = New System.Drawing.Point(108, 333)
        Me.tbCourriel.Name = "tbCourriel"
        Me.tbCourriel.Size = New System.Drawing.Size(206, 20)
        Me.tbCourriel.TabIndex = 20
        '
        'lCourriel
        '
        Me.lCourriel.AutoSize = True
        Me.lCourriel.Location = New System.Drawing.Point(54, 337)
        Me.lCourriel.Name = "lCourriel"
        Me.lCourriel.Size = New System.Drawing.Size(48, 13)
        Me.lCourriel.TabIndex = 19
        Me.lCourriel.Text = "Courriel :"
        '
        'tbTelephoneBureau
        '
        Me.tbTelephoneBureau.Location = New System.Drawing.Point(108, 241)
        Me.tbTelephoneBureau.Name = "tbTelephoneBureau"
        Me.tbTelephoneBureau.Size = New System.Drawing.Size(206, 20)
        Me.tbTelephoneBureau.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 26)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Téléphone de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         bureau :"
        '
        'Ajout_Modif_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 419)
        Me.Controls.Add(Me.tbTelephoneBureau)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbCourriel)
        Me.Controls.Add(Me.lCourriel)
        Me.Controls.Add(Me.tbCellulaire)
        Me.Controls.Add(Me.lCellulaire)
        Me.Controls.Add(Me.tbPosteTelephonique)
        Me.Controls.Add(Me.lPosteTelephonique)
        Me.Controls.Add(Me.tbNumeroBureau)
        Me.Controls.Add(Me.lNumeroBureau)
        Me.Controls.Add(Me.tbDepartementService)
        Me.Controls.Add(Me.lDepartementService)
        Me.Controls.Add(Me.tbPrenom)
        Me.Controls.Add(Me.lPrenom)
        Me.Controls.Add(Me.tbNom)
        Me.Controls.Add(Me.lNom)
        Me.Controls.Add(Me.tbConfirmationMdp)
        Me.Controls.Add(Me.lConfirmationMdp)
        Me.Controls.Add(Me.bConfirmer)
        Me.Controls.Add(Me.tbMdp)
        Me.Controls.Add(Me.lMdp)
        Me.Controls.Add(Me.tbMatricule)
        Me.Controls.Add(Me.lMatricule)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Ajout_Modif_Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajout_Modif_Admin (NOM CHANGEMENTS)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lMatricule As Label
    Friend WithEvents tbMatricule As TextBox
    Friend WithEvents tbMdp As TextBox
    Friend WithEvents lMdp As Label
    Friend WithEvents bConfirmer As Button
    Friend WithEvents tbConfirmationMdp As TextBox
    Friend WithEvents lConfirmationMdp As Label
    Friend WithEvents tbNom As TextBox
    Friend WithEvents lNom As Label
    Friend WithEvents tbPrenom As TextBox
    Friend WithEvents lPrenom As Label
    Friend WithEvents tbDepartementService As TextBox
    Friend WithEvents lDepartementService As Label
    Friend WithEvents tbNumeroBureau As TextBox
    Friend WithEvents lNumeroBureau As Label
    Friend WithEvents tbPosteTelephonique As TextBox
    Friend WithEvents lPosteTelephonique As Label
    Friend WithEvents tbCellulaire As TextBox
    Friend WithEvents lCellulaire As Label
    Friend WithEvents tbCourriel As TextBox
    Friend WithEvents lCourriel As Label
    Friend WithEvents tbTelephoneBureau As TextBox
    Friend WithEvents Label1 As Label
End Class
