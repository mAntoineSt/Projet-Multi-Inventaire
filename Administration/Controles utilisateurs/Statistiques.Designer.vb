<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Statistiques
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.bPartieGlobale = New System.Windows.Forms.Button()
        Me.bEmprunteurs = New System.Windows.Forms.Button()
        Me.bPreteurs = New System.Windows.Forms.Button()
        Me.bAdministrateurs = New System.Windows.Forms.Button()
        Me.gbGlobale = New System.Windows.Forms.GroupBox()
        Me.lTitreNbrConditions = New System.Windows.Forms.Label()
        Me.lTitreNbrEquipements = New System.Windows.Forms.Label()
        Me.lTitreNbrAdministratifs = New System.Windows.Forms.Label()
        Me.lTitreNbrEmprunteurs = New System.Windows.Forms.Label()
        Me.lTitreNbrPreteurs = New System.Windows.Forms.Label()
        Me.lTitreNbrPersonneBD = New System.Windows.Forms.Label()
        Me.lTitreNbrRetours = New System.Windows.Forms.Label()
        Me.lTitreNbrPrets = New System.Windows.Forms.Label()
        Me.lTitreNbrOuverturesApplis = New System.Windows.Forms.Label()
        Me.lTitreGlobale = New System.Windows.Forms.Label()
        Me.cbGlobaleChoixAnnee = New System.Windows.Forms.ComboBox()
        Me.cbGlobaleChoixMois = New System.Windows.Forms.ComboBox()
        Me.lGlobaleChoixAnnee = New System.Windows.Forms.Label()
        Me.lGlobaleChoixMois = New System.Windows.Forms.Label()
        Me.gbPartieEmprunteurs = New System.Windows.Forms.GroupBox()
        Me.gbPartiePreteurs = New System.Windows.Forms.GroupBox()
        Me.gbPartieAdministrateur = New System.Windows.Forms.GroupBox()
        Me.bGlobalePDF = New System.Windows.Forms.Button()
        Me.bGlobaleDOCS = New System.Windows.Forms.Button()
        Me.bGlobaleXLSX = New System.Windows.Forms.Button()
        Me.lTitreNbrResponsabilites = New System.Windows.Forms.Label()
        Me.lNbrOuverturesApplis = New System.Windows.Forms.Label()
        Me.lNbrPrets = New System.Windows.Forms.Label()
        Me.lNbrRetours = New System.Windows.Forms.Label()
        Me.lNbrPersonneBD = New System.Windows.Forms.Label()
        Me.lNbrEmprunteurs = New System.Windows.Forms.Label()
        Me.lNbrPreteurs = New System.Windows.Forms.Label()
        Me.lNbrAdministratifs = New System.Windows.Forms.Label()
        Me.lNbrEquipements = New System.Windows.Forms.Label()
        Me.lNbrConditions = New System.Windows.Forms.Label()
        Me.lNbrResponsabilites = New System.Windows.Forms.Label()
        Me.bEmprunteursPDF = New System.Windows.Forms.Button()
        Me.bEmprunteursDOCS = New System.Windows.Forms.Button()
        Me.bEmprunteursXLSX = New System.Windows.Forms.Button()
        Me.cbEmprunteurChoixAnnee = New System.Windows.Forms.ComboBox()
        Me.cbEmprunteurChoixMois = New System.Windows.Forms.ComboBox()
        Me.lEmprunteurTitreChoixAnnee = New System.Windows.Forms.Label()
        Me.lEmprunteurTitreChoixMois = New System.Windows.Forms.Label()
        Me.lTitrePartieEmprunteurs = New System.Windows.Forms.Label()
        Me.lEmprunteursTitreNbrEmprunteurs = New System.Windows.Forms.Label()
        Me.lEmprunteurTitreNbrPretsEffectuees = New System.Windows.Forms.Label()
        Me.lEmprunteursTitreNbrPretsActifs = New System.Windows.Forms.Label()
        Me.lEmprunteursTitreNbrRetoursEffectuees = New System.Windows.Forms.Label()
        Me.lEmprunteursTitreNbrEmpruntsActifs = New System.Windows.Forms.Label()
        Me.lEmprunteurTitreEmprunteursSuspendues = New System.Windows.Forms.Label()
        Me.lEmprunteursTitreNbrRetoursAttentes = New System.Windows.Forms.Label()
        Me.lTitreNbrFraisRetards = New System.Windows.Forms.Label()
        Me.lNbrFraisRetards = New System.Windows.Forms.Label()
        Me.lEmprunteursNbrEmprunteurs = New System.Windows.Forms.Label()
        Me.lEmprunteursNbrEmpruntsActifs = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lEmprunteurNbrPretsEffectuees = New System.Windows.Forms.Label()
        Me.lEmprunteursNbrPretsActifs = New System.Windows.Forms.Label()
        Me.lEmprunteursNbrRetoursEffectuees = New System.Windows.Forms.Label()
        Me.lEmprunteursNbrRetoursAttentes = New System.Windows.Forms.Label()
        Me.lPreteursTitre = New System.Windows.Forms.Label()
        Me.cbPreteursChoixAnnee = New System.Windows.Forms.ComboBox()
        Me.cbPreteursChoixMois = New System.Windows.Forms.ComboBox()
        Me.lPreteursTitreChoixAnnee = New System.Windows.Forms.Label()
        Me.lPreteursTitreChoixMois = New System.Windows.Forms.Label()
        Me.bPreteursPDF = New System.Windows.Forms.Button()
        Me.bPreteursDOCS = New System.Windows.Forms.Button()
        Me.bPreteursXLSX = New System.Windows.Forms.Button()
        Me.gbGlobale.SuspendLayout()
        Me.gbPartieEmprunteurs.SuspendLayout()
        Me.gbPartiePreteurs.SuspendLayout()
        Me.SuspendLayout()
        '
        'bPartieGlobale
        '
        Me.bPartieGlobale.Location = New System.Drawing.Point(51, 39)
        Me.bPartieGlobale.Name = "bPartieGlobale"
        Me.bPartieGlobale.Size = New System.Drawing.Size(167, 66)
        Me.bPartieGlobale.TabIndex = 0
        Me.bPartieGlobale.Text = "Partie globale"
        Me.bPartieGlobale.UseVisualStyleBackColor = True
        '
        'bEmprunteurs
        '
        Me.bEmprunteurs.Location = New System.Drawing.Point(51, 134)
        Me.bEmprunteurs.Name = "bEmprunteurs"
        Me.bEmprunteurs.Size = New System.Drawing.Size(167, 66)
        Me.bEmprunteurs.TabIndex = 1
        Me.bEmprunteurs.Text = "Partie emprunteurs"
        Me.bEmprunteurs.UseVisualStyleBackColor = True
        '
        'bPreteurs
        '
        Me.bPreteurs.Location = New System.Drawing.Point(51, 239)
        Me.bPreteurs.Name = "bPreteurs"
        Me.bPreteurs.Size = New System.Drawing.Size(167, 66)
        Me.bPreteurs.TabIndex = 2
        Me.bPreteurs.Text = "Partie prêteurs"
        Me.bPreteurs.UseVisualStyleBackColor = True
        '
        'bAdministrateurs
        '
        Me.bAdministrateurs.Location = New System.Drawing.Point(51, 343)
        Me.bAdministrateurs.Name = "bAdministrateurs"
        Me.bAdministrateurs.Size = New System.Drawing.Size(167, 66)
        Me.bAdministrateurs.TabIndex = 3
        Me.bAdministrateurs.Text = "Partie administrateurs"
        Me.bAdministrateurs.UseVisualStyleBackColor = True
        '
        'gbGlobale
        '
        Me.gbGlobale.Controls.Add(Me.lNbrFraisRetards)
        Me.gbGlobale.Controls.Add(Me.lTitreNbrFraisRetards)
        Me.gbGlobale.Controls.Add(Me.bGlobalePDF)
        Me.gbGlobale.Controls.Add(Me.bGlobaleDOCS)
        Me.gbGlobale.Controls.Add(Me.bGlobaleXLSX)
        Me.gbGlobale.Controls.Add(Me.lNbrResponsabilites)
        Me.gbGlobale.Controls.Add(Me.lNbrConditions)
        Me.gbGlobale.Controls.Add(Me.lNbrEquipements)
        Me.gbGlobale.Controls.Add(Me.lNbrAdministratifs)
        Me.gbGlobale.Controls.Add(Me.lNbrPreteurs)
        Me.gbGlobale.Controls.Add(Me.lNbrEmprunteurs)
        Me.gbGlobale.Controls.Add(Me.lNbrPersonneBD)
        Me.gbGlobale.Controls.Add(Me.lNbrRetours)
        Me.gbGlobale.Controls.Add(Me.lNbrPrets)
        Me.gbGlobale.Controls.Add(Me.lNbrOuverturesApplis)
        Me.gbGlobale.Controls.Add(Me.lTitreNbrResponsabilites)
        Me.gbGlobale.Controls.Add(Me.lTitreNbrConditions)
        Me.gbGlobale.Controls.Add(Me.lTitreNbrEquipements)
        Me.gbGlobale.Controls.Add(Me.lTitreNbrAdministratifs)
        Me.gbGlobale.Controls.Add(Me.lTitreNbrEmprunteurs)
        Me.gbGlobale.Controls.Add(Me.lTitreNbrPreteurs)
        Me.gbGlobale.Controls.Add(Me.lTitreNbrPersonneBD)
        Me.gbGlobale.Controls.Add(Me.lTitreNbrRetours)
        Me.gbGlobale.Controls.Add(Me.lTitreNbrPrets)
        Me.gbGlobale.Controls.Add(Me.lTitreNbrOuverturesApplis)
        Me.gbGlobale.Controls.Add(Me.lTitreGlobale)
        Me.gbGlobale.Controls.Add(Me.cbGlobaleChoixAnnee)
        Me.gbGlobale.Controls.Add(Me.cbGlobaleChoixMois)
        Me.gbGlobale.Controls.Add(Me.lGlobaleChoixAnnee)
        Me.gbGlobale.Controls.Add(Me.lGlobaleChoixMois)
        Me.gbGlobale.Location = New System.Drawing.Point(302, 39)
        Me.gbGlobale.Name = "gbGlobale"
        Me.gbGlobale.Size = New System.Drawing.Size(697, 396)
        Me.gbGlobale.TabIndex = 4
        Me.gbGlobale.TabStop = False
        Me.gbGlobale.Text = "Partie globale"
        '
        'lTitreNbrConditions
        '
        Me.lTitreNbrConditions.AutoSize = True
        Me.lTitreNbrConditions.Location = New System.Drawing.Point(25, 304)
        Me.lTitreNbrConditions.Name = "lTitreNbrConditions"
        Me.lTitreNbrConditions.Size = New System.Drawing.Size(157, 13)
        Me.lTitreNbrConditions.TabIndex = 15
        Me.lTitreNbrConditions.Text = "Nombre de conditions inscrites :"
        '
        'lTitreNbrEquipements
        '
        Me.lTitreNbrEquipements.AutoSize = True
        Me.lTitreNbrEquipements.Location = New System.Drawing.Point(24, 277)
        Me.lTitreNbrEquipements.Name = "lTitreNbrEquipements"
        Me.lTitreNbrEquipements.Size = New System.Drawing.Size(151, 13)
        Me.lTitreNbrEquipements.TabIndex = 14
        Me.lTitreNbrEquipements.Text = "Nombre d'équipements inscrit :"
        '
        'lTitreNbrAdministratifs
        '
        Me.lTitreNbrAdministratifs.AutoSize = True
        Me.lTitreNbrAdministratifs.Location = New System.Drawing.Point(24, 253)
        Me.lTitreNbrAdministratifs.Name = "lTitreNbrAdministratifs"
        Me.lTitreNbrAdministratifs.Size = New System.Drawing.Size(161, 13)
        Me.lTitreNbrAdministratifs.TabIndex = 12
        Me.lTitreNbrAdministratifs.Text = "Nombre d'administrateurs inscrit :"
        '
        'lTitreNbrEmprunteurs
        '
        Me.lTitreNbrEmprunteurs.AutoSize = True
        Me.lTitreNbrEmprunteurs.Location = New System.Drawing.Point(20, 200)
        Me.lTitreNbrEmprunteurs.Name = "lTitreNbrEmprunteurs"
        Me.lTitreNbrEmprunteurs.Size = New System.Drawing.Size(149, 13)
        Me.lTitreNbrEmprunteurs.TabIndex = 11
        Me.lTitreNbrEmprunteurs.Text = "Nombre d'emprunteurs inscrit :"
        '
        'lTitreNbrPreteurs
        '
        Me.lTitreNbrPreteurs.AutoSize = True
        Me.lTitreNbrPreteurs.Location = New System.Drawing.Point(21, 227)
        Me.lTitreNbrPreteurs.Name = "lTitreNbrPreteurs"
        Me.lTitreNbrPreteurs.Size = New System.Drawing.Size(136, 13)
        Me.lTitreNbrPreteurs.TabIndex = 10
        Me.lTitreNbrPreteurs.Text = "Nombre de prêteurs inscrit :"
        '
        'lTitreNbrPersonneBD
        '
        Me.lTitreNbrPersonneBD.AutoSize = True
        Me.lTitreNbrPersonneBD.Location = New System.Drawing.Point(21, 172)
        Me.lTitreNbrPersonneBD.Name = "lTitreNbrPersonneBD"
        Me.lTitreNbrPersonneBD.Size = New System.Drawing.Size(280, 13)
        Me.lTitreNbrPersonneBD.TabIndex = 9
        Me.lTitreNbrPersonneBD.Text = "Nombre de personnes inscrites dans la base de données :"
        '
        'lTitreNbrRetours
        '
        Me.lTitreNbrRetours.AutoSize = True
        Me.lTitreNbrRetours.Location = New System.Drawing.Point(20, 135)
        Me.lTitreNbrRetours.Name = "lTitreNbrRetours"
        Me.lTitreNbrRetours.Size = New System.Drawing.Size(153, 13)
        Me.lTitreNbrRetours.TabIndex = 8
        Me.lTitreNbrRetours.Text = "Nombre de retours effectuées :"
        '
        'lTitreNbrPrets
        '
        Me.lTitreNbrPrets.AutoSize = True
        Me.lTitreNbrPrets.Location = New System.Drawing.Point(20, 99)
        Me.lTitreNbrPrets.Name = "lTitreNbrPrets"
        Me.lTitreNbrPrets.Size = New System.Drawing.Size(140, 13)
        Me.lTitreNbrPrets.TabIndex = 7
        Me.lTitreNbrPrets.Text = "Nombre de prêts enregistré :"
        '
        'lTitreNbrOuverturesApplis
        '
        Me.lTitreNbrOuverturesApplis.AutoSize = True
        Me.lTitreNbrOuverturesApplis.Location = New System.Drawing.Point(20, 67)
        Me.lTitreNbrOuverturesApplis.Name = "lTitreNbrOuverturesApplis"
        Me.lTitreNbrOuverturesApplis.Size = New System.Drawing.Size(184, 13)
        Me.lTitreNbrOuverturesApplis.TabIndex = 6
        Me.lTitreNbrOuverturesApplis.Text = "Nombre d'ouvertures de l'application :"
        '
        'lTitreGlobale
        '
        Me.lTitreGlobale.AutoSize = True
        Me.lTitreGlobale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lTitreGlobale.Location = New System.Drawing.Point(19, 23)
        Me.lTitreGlobale.Name = "lTitreGlobale"
        Me.lTitreGlobale.Size = New System.Drawing.Size(313, 20)
        Me.lTitreGlobale.TabIndex = 5
        Me.lTitreGlobale.Text = "Toutes les infos en globalité de l'application"
        '
        'cbGlobaleChoixAnnee
        '
        Me.cbGlobaleChoixAnnee.FormattingEnabled = True
        Me.cbGlobaleChoixAnnee.Items.AddRange(New Object() {"Aucunes"})
        Me.cbGlobaleChoixAnnee.Location = New System.Drawing.Point(406, 19)
        Me.cbGlobaleChoixAnnee.Name = "cbGlobaleChoixAnnee"
        Me.cbGlobaleChoixAnnee.Size = New System.Drawing.Size(110, 21)
        Me.cbGlobaleChoixAnnee.TabIndex = 4
        '
        'cbGlobaleChoixMois
        '
        Me.cbGlobaleChoixMois.FormattingEnabled = True
        Me.cbGlobaleChoixMois.Items.AddRange(New Object() {"Aucunes"})
        Me.cbGlobaleChoixMois.Location = New System.Drawing.Point(581, 19)
        Me.cbGlobaleChoixMois.Name = "cbGlobaleChoixMois"
        Me.cbGlobaleChoixMois.Size = New System.Drawing.Size(110, 21)
        Me.cbGlobaleChoixMois.TabIndex = 3
        '
        'lGlobaleChoixAnnee
        '
        Me.lGlobaleChoixAnnee.AutoSize = True
        Me.lGlobaleChoixAnnee.Location = New System.Drawing.Point(362, 23)
        Me.lGlobaleChoixAnnee.Name = "lGlobaleChoixAnnee"
        Me.lGlobaleChoixAnnee.Size = New System.Drawing.Size(38, 13)
        Me.lGlobaleChoixAnnee.TabIndex = 2
        Me.lGlobaleChoixAnnee.Text = "Année"
        '
        'lGlobaleChoixMois
        '
        Me.lGlobaleChoixMois.AutoSize = True
        Me.lGlobaleChoixMois.Location = New System.Drawing.Point(546, 23)
        Me.lGlobaleChoixMois.Name = "lGlobaleChoixMois"
        Me.lGlobaleChoixMois.Size = New System.Drawing.Size(29, 13)
        Me.lGlobaleChoixMois.TabIndex = 1
        Me.lGlobaleChoixMois.Text = "Mois"
        '
        'gbPartieEmprunteurs
        '
        Me.gbPartieEmprunteurs.Controls.Add(Me.gbPartiePreteurs)
        Me.gbPartieEmprunteurs.Controls.Add(Me.lEmprunteursNbrRetoursAttentes)
        Me.gbPartieEmprunteurs.Controls.Add(Me.lEmprunteursNbrRetoursEffectuees)
        Me.gbPartieEmprunteurs.Controls.Add(Me.lEmprunteursNbrPretsActifs)
        Me.gbPartieEmprunteurs.Controls.Add(Me.lEmprunteurNbrPretsEffectuees)
        Me.gbPartieEmprunteurs.Controls.Add(Me.Label12)
        Me.gbPartieEmprunteurs.Controls.Add(Me.lEmprunteursNbrEmpruntsActifs)
        Me.gbPartieEmprunteurs.Controls.Add(Me.lEmprunteursNbrEmprunteurs)
        Me.gbPartieEmprunteurs.Controls.Add(Me.lEmprunteursTitreNbrRetoursAttentes)
        Me.gbPartieEmprunteurs.Controls.Add(Me.lEmprunteurTitreEmprunteursSuspendues)
        Me.gbPartieEmprunteurs.Controls.Add(Me.lEmprunteursTitreNbrEmpruntsActifs)
        Me.gbPartieEmprunteurs.Controls.Add(Me.lEmprunteursTitreNbrRetoursEffectuees)
        Me.gbPartieEmprunteurs.Controls.Add(Me.lEmprunteursTitreNbrPretsActifs)
        Me.gbPartieEmprunteurs.Controls.Add(Me.lEmprunteurTitreNbrPretsEffectuees)
        Me.gbPartieEmprunteurs.Controls.Add(Me.lEmprunteursTitreNbrEmprunteurs)
        Me.gbPartieEmprunteurs.Controls.Add(Me.lTitrePartieEmprunteurs)
        Me.gbPartieEmprunteurs.Controls.Add(Me.cbEmprunteurChoixAnnee)
        Me.gbPartieEmprunteurs.Controls.Add(Me.cbEmprunteurChoixMois)
        Me.gbPartieEmprunteurs.Controls.Add(Me.lEmprunteurTitreChoixAnnee)
        Me.gbPartieEmprunteurs.Controls.Add(Me.lEmprunteurTitreChoixMois)
        Me.gbPartieEmprunteurs.Controls.Add(Me.bEmprunteursPDF)
        Me.gbPartieEmprunteurs.Controls.Add(Me.bEmprunteursDOCS)
        Me.gbPartieEmprunteurs.Controls.Add(Me.bEmprunteursXLSX)
        Me.gbPartieEmprunteurs.Location = New System.Drawing.Point(302, 39)
        Me.gbPartieEmprunteurs.Name = "gbPartieEmprunteurs"
        Me.gbPartieEmprunteurs.Size = New System.Drawing.Size(697, 394)
        Me.gbPartieEmprunteurs.TabIndex = 5
        Me.gbPartieEmprunteurs.TabStop = False
        Me.gbPartieEmprunteurs.Text = "Partie emprunteurs"
        Me.gbPartieEmprunteurs.Visible = False
        '
        'gbPartiePreteurs
        '
        Me.gbPartiePreteurs.Controls.Add(Me.bPreteursPDF)
        Me.gbPartiePreteurs.Controls.Add(Me.bPreteursDOCS)
        Me.gbPartiePreteurs.Controls.Add(Me.bPreteursXLSX)
        Me.gbPartiePreteurs.Controls.Add(Me.lPreteursTitre)
        Me.gbPartiePreteurs.Controls.Add(Me.cbPreteursChoixAnnee)
        Me.gbPartiePreteurs.Controls.Add(Me.cbPreteursChoixMois)
        Me.gbPartiePreteurs.Controls.Add(Me.lPreteursTitreChoixAnnee)
        Me.gbPartiePreteurs.Controls.Add(Me.lPreteursTitreChoixMois)
        Me.gbPartiePreteurs.Location = New System.Drawing.Point(0, 0)
        Me.gbPartiePreteurs.Name = "gbPartiePreteurs"
        Me.gbPartiePreteurs.Size = New System.Drawing.Size(697, 396)
        Me.gbPartiePreteurs.TabIndex = 5
        Me.gbPartiePreteurs.TabStop = False
        Me.gbPartiePreteurs.Text = "Partie prêteurs"
        Me.gbPartiePreteurs.Visible = False
        '
        'gbPartieAdministrateur
        '
        Me.gbPartieAdministrateur.Location = New System.Drawing.Point(3, 3)
        Me.gbPartieAdministrateur.Name = "gbPartieAdministrateur"
        Me.gbPartieAdministrateur.Size = New System.Drawing.Size(293, 158)
        Me.gbPartieAdministrateur.TabIndex = 5
        Me.gbPartieAdministrateur.TabStop = False
        Me.gbPartieAdministrateur.Text = "Partie administrateur"
        Me.gbPartieAdministrateur.Visible = False
        '
        'bGlobalePDF
        '
        Me.bGlobalePDF.Location = New System.Drawing.Point(496, 296)
        Me.bGlobalePDF.Name = "bGlobalePDF"
        Me.bGlobalePDF.Size = New System.Drawing.Size(164, 71)
        Me.bGlobalePDF.TabIndex = 6
        Me.bGlobalePDF.Text = "Exporter en .PDF"
        Me.bGlobalePDF.UseVisualStyleBackColor = True
        '
        'bGlobaleDOCS
        '
        Me.bGlobaleDOCS.Location = New System.Drawing.Point(496, 181)
        Me.bGlobaleDOCS.Name = "bGlobaleDOCS"
        Me.bGlobaleDOCS.Size = New System.Drawing.Size(164, 71)
        Me.bGlobaleDOCS.TabIndex = 7
        Me.bGlobaleDOCS.Text = "Exporter en .DOCS"
        Me.bGlobaleDOCS.UseVisualStyleBackColor = True
        '
        'bGlobaleXLSX
        '
        Me.bGlobaleXLSX.Location = New System.Drawing.Point(496, 70)
        Me.bGlobaleXLSX.Name = "bGlobaleXLSX"
        Me.bGlobaleXLSX.Size = New System.Drawing.Size(164, 71)
        Me.bGlobaleXLSX.TabIndex = 8
        Me.bGlobaleXLSX.Text = "Exporter en .XLSX"
        Me.bGlobaleXLSX.UseVisualStyleBackColor = True
        '
        'lTitreNbrResponsabilites
        '
        Me.lTitreNbrResponsabilites.AutoSize = True
        Me.lTitreNbrResponsabilites.Location = New System.Drawing.Point(26, 331)
        Me.lTitreNbrResponsabilites.Name = "lTitreNbrResponsabilites"
        Me.lTitreNbrResponsabilites.Size = New System.Drawing.Size(178, 13)
        Me.lTitreNbrResponsabilites.TabIndex = 16
        Me.lTitreNbrResponsabilites.Text = "Nombre de responsabilités inscrites :"
        '
        'lNbrOuverturesApplis
        '
        Me.lNbrOuverturesApplis.AutoSize = True
        Me.lNbrOuverturesApplis.Location = New System.Drawing.Point(210, 67)
        Me.lNbrOuverturesApplis.Name = "lNbrOuverturesApplis"
        Me.lNbrOuverturesApplis.Size = New System.Drawing.Size(54, 13)
        Me.lNbrOuverturesApplis.TabIndex = 17
        Me.lNbrOuverturesApplis.Text = "NOMBRE"
        '
        'lNbrPrets
        '
        Me.lNbrPrets.AutoSize = True
        Me.lNbrPrets.Location = New System.Drawing.Point(166, 99)
        Me.lNbrPrets.Name = "lNbrPrets"
        Me.lNbrPrets.Size = New System.Drawing.Size(54, 13)
        Me.lNbrPrets.TabIndex = 18
        Me.lNbrPrets.Text = "NOMBRE"
        '
        'lNbrRetours
        '
        Me.lNbrRetours.AutoSize = True
        Me.lNbrRetours.Location = New System.Drawing.Point(179, 135)
        Me.lNbrRetours.Name = "lNbrRetours"
        Me.lNbrRetours.Size = New System.Drawing.Size(54, 13)
        Me.lNbrRetours.TabIndex = 19
        Me.lNbrRetours.Text = "NOMBRE"
        '
        'lNbrPersonneBD
        '
        Me.lNbrPersonneBD.AutoSize = True
        Me.lNbrPersonneBD.Location = New System.Drawing.Point(307, 172)
        Me.lNbrPersonneBD.Name = "lNbrPersonneBD"
        Me.lNbrPersonneBD.Size = New System.Drawing.Size(54, 13)
        Me.lNbrPersonneBD.TabIndex = 20
        Me.lNbrPersonneBD.Text = "NOMBRE"
        '
        'lNbrEmprunteurs
        '
        Me.lNbrEmprunteurs.AutoSize = True
        Me.lNbrEmprunteurs.Location = New System.Drawing.Point(175, 200)
        Me.lNbrEmprunteurs.Name = "lNbrEmprunteurs"
        Me.lNbrEmprunteurs.Size = New System.Drawing.Size(54, 13)
        Me.lNbrEmprunteurs.TabIndex = 21
        Me.lNbrEmprunteurs.Text = "NOMBRE"
        '
        'lNbrPreteurs
        '
        Me.lNbrPreteurs.AutoSize = True
        Me.lNbrPreteurs.Location = New System.Drawing.Point(161, 227)
        Me.lNbrPreteurs.Name = "lNbrPreteurs"
        Me.lNbrPreteurs.Size = New System.Drawing.Size(54, 13)
        Me.lNbrPreteurs.TabIndex = 22
        Me.lNbrPreteurs.Text = "NOMBRE"
        '
        'lNbrAdministratifs
        '
        Me.lNbrAdministratifs.AutoSize = True
        Me.lNbrAdministratifs.Location = New System.Drawing.Point(191, 253)
        Me.lNbrAdministratifs.Name = "lNbrAdministratifs"
        Me.lNbrAdministratifs.Size = New System.Drawing.Size(54, 13)
        Me.lNbrAdministratifs.TabIndex = 23
        Me.lNbrAdministratifs.Text = "NOMBRE"
        '
        'lNbrEquipements
        '
        Me.lNbrEquipements.AutoSize = True
        Me.lNbrEquipements.Location = New System.Drawing.Point(181, 277)
        Me.lNbrEquipements.Name = "lNbrEquipements"
        Me.lNbrEquipements.Size = New System.Drawing.Size(54, 13)
        Me.lNbrEquipements.TabIndex = 25
        Me.lNbrEquipements.Text = "NOMBRE"
        '
        'lNbrConditions
        '
        Me.lNbrConditions.AutoSize = True
        Me.lNbrConditions.Location = New System.Drawing.Point(188, 304)
        Me.lNbrConditions.Name = "lNbrConditions"
        Me.lNbrConditions.Size = New System.Drawing.Size(54, 13)
        Me.lNbrConditions.TabIndex = 26
        Me.lNbrConditions.Text = "NOMBRE"
        '
        'lNbrResponsabilites
        '
        Me.lNbrResponsabilites.AutoSize = True
        Me.lNbrResponsabilites.Location = New System.Drawing.Point(210, 331)
        Me.lNbrResponsabilites.Name = "lNbrResponsabilites"
        Me.lNbrResponsabilites.Size = New System.Drawing.Size(54, 13)
        Me.lNbrResponsabilites.TabIndex = 27
        Me.lNbrResponsabilites.Text = "NOMBRE"
        '
        'bEmprunteursPDF
        '
        Me.bEmprunteursPDF.Location = New System.Drawing.Point(508, 291)
        Me.bEmprunteursPDF.Name = "bEmprunteursPDF"
        Me.bEmprunteursPDF.Size = New System.Drawing.Size(164, 71)
        Me.bEmprunteursPDF.TabIndex = 9
        Me.bEmprunteursPDF.Text = "Exporter en .PDF"
        Me.bEmprunteursPDF.UseVisualStyleBackColor = True
        '
        'bEmprunteursDOCS
        '
        Me.bEmprunteursDOCS.Location = New System.Drawing.Point(508, 176)
        Me.bEmprunteursDOCS.Name = "bEmprunteursDOCS"
        Me.bEmprunteursDOCS.Size = New System.Drawing.Size(164, 71)
        Me.bEmprunteursDOCS.TabIndex = 10
        Me.bEmprunteursDOCS.Text = "Exporter en .DOCS"
        Me.bEmprunteursDOCS.UseVisualStyleBackColor = True
        '
        'bEmprunteursXLSX
        '
        Me.bEmprunteursXLSX.Location = New System.Drawing.Point(508, 65)
        Me.bEmprunteursXLSX.Name = "bEmprunteursXLSX"
        Me.bEmprunteursXLSX.Size = New System.Drawing.Size(164, 71)
        Me.bEmprunteursXLSX.TabIndex = 11
        Me.bEmprunteursXLSX.Text = "Exporter en .XLSX"
        Me.bEmprunteursXLSX.UseVisualStyleBackColor = True
        '
        'cbEmprunteurChoixAnnee
        '
        Me.cbEmprunteurChoixAnnee.FormattingEnabled = True
        Me.cbEmprunteurChoixAnnee.Items.AddRange(New Object() {"Aucunes"})
        Me.cbEmprunteurChoixAnnee.Location = New System.Drawing.Point(406, 19)
        Me.cbEmprunteurChoixAnnee.Name = "cbEmprunteurChoixAnnee"
        Me.cbEmprunteurChoixAnnee.Size = New System.Drawing.Size(110, 21)
        Me.cbEmprunteurChoixAnnee.TabIndex = 15
        '
        'cbEmprunteurChoixMois
        '
        Me.cbEmprunteurChoixMois.FormattingEnabled = True
        Me.cbEmprunteurChoixMois.Items.AddRange(New Object() {"Aucunes"})
        Me.cbEmprunteurChoixMois.Location = New System.Drawing.Point(581, 19)
        Me.cbEmprunteurChoixMois.Name = "cbEmprunteurChoixMois"
        Me.cbEmprunteurChoixMois.Size = New System.Drawing.Size(110, 21)
        Me.cbEmprunteurChoixMois.TabIndex = 14
        '
        'lEmprunteurTitreChoixAnnee
        '
        Me.lEmprunteurTitreChoixAnnee.AutoSize = True
        Me.lEmprunteurTitreChoixAnnee.Location = New System.Drawing.Point(362, 23)
        Me.lEmprunteurTitreChoixAnnee.Name = "lEmprunteurTitreChoixAnnee"
        Me.lEmprunteurTitreChoixAnnee.Size = New System.Drawing.Size(38, 13)
        Me.lEmprunteurTitreChoixAnnee.TabIndex = 13
        Me.lEmprunteurTitreChoixAnnee.Text = "Année"
        '
        'lEmprunteurTitreChoixMois
        '
        Me.lEmprunteurTitreChoixMois.AutoSize = True
        Me.lEmprunteurTitreChoixMois.Location = New System.Drawing.Point(546, 23)
        Me.lEmprunteurTitreChoixMois.Name = "lEmprunteurTitreChoixMois"
        Me.lEmprunteurTitreChoixMois.Size = New System.Drawing.Size(29, 13)
        Me.lEmprunteurTitreChoixMois.TabIndex = 12
        Me.lEmprunteurTitreChoixMois.Text = "Mois"
        '
        'lTitrePartieEmprunteurs
        '
        Me.lTitrePartieEmprunteurs.AutoSize = True
        Me.lTitrePartieEmprunteurs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lTitrePartieEmprunteurs.Location = New System.Drawing.Point(4, 20)
        Me.lTitrePartieEmprunteurs.Name = "lTitrePartieEmprunteurs"
        Me.lTitrePartieEmprunteurs.Size = New System.Drawing.Size(352, 20)
        Me.lTitrePartieEmprunteurs.TabIndex = 16
        Me.lTitrePartieEmprunteurs.Text = "Toutes les infos des emprunteurs de l'application"
        '
        'lEmprunteursTitreNbrEmprunteurs
        '
        Me.lEmprunteursTitreNbrEmprunteurs.AutoSize = True
        Me.lEmprunteursTitreNbrEmprunteurs.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lEmprunteursTitreNbrEmprunteurs.Location = New System.Drawing.Point(28, 99)
        Me.lEmprunteursTitreNbrEmprunteurs.Name = "lEmprunteursTitreNbrEmprunteurs"
        Me.lEmprunteursTitreNbrEmprunteurs.Size = New System.Drawing.Size(207, 22)
        Me.lEmprunteursTitreNbrEmprunteurs.TabIndex = 17
        Me.lEmprunteursTitreNbrEmprunteurs.Text = "Nombre d'emprunteurs : "
        '
        'lEmprunteurTitreNbrPretsEffectuees
        '
        Me.lEmprunteurTitreNbrPretsEffectuees.AutoSize = True
        Me.lEmprunteurTitreNbrPretsEffectuees.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lEmprunteurTitreNbrPretsEffectuees.Location = New System.Drawing.Point(28, 205)
        Me.lEmprunteurTitreNbrPretsEffectuees.Name = "lEmprunteurTitreNbrPretsEffectuees"
        Me.lEmprunteurTitreNbrPretsEffectuees.Size = New System.Drawing.Size(246, 22)
        Me.lEmprunteurTitreNbrPretsEffectuees.TabIndex = 18
        Me.lEmprunteurTitreNbrPretsEffectuees.Text = "Nombre de prêts effectuées : "
        '
        'lEmprunteursTitreNbrPretsActifs
        '
        Me.lEmprunteursTitreNbrPretsActifs.AutoSize = True
        Me.lEmprunteursTitreNbrPretsActifs.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lEmprunteursTitreNbrPretsActifs.Location = New System.Drawing.Point(31, 242)
        Me.lEmprunteursTitreNbrPretsActifs.Name = "lEmprunteursTitreNbrPretsActifs"
        Me.lEmprunteursTitreNbrPretsActifs.Size = New System.Drawing.Size(205, 22)
        Me.lEmprunteursTitreNbrPretsActifs.TabIndex = 19
        Me.lEmprunteursTitreNbrPretsActifs.Text = "Nombre de prêts actifs : "
        '
        'lEmprunteursTitreNbrRetoursEffectuees
        '
        Me.lEmprunteursTitreNbrRetoursEffectuees.AutoSize = True
        Me.lEmprunteursTitreNbrRetoursEffectuees.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lEmprunteursTitreNbrRetoursEffectuees.Location = New System.Drawing.Point(31, 284)
        Me.lEmprunteursTitreNbrRetoursEffectuees.Name = "lEmprunteursTitreNbrRetoursEffectuees"
        Me.lEmprunteursTitreNbrRetoursEffectuees.Size = New System.Drawing.Size(262, 22)
        Me.lEmprunteursTitreNbrRetoursEffectuees.TabIndex = 20
        Me.lEmprunteursTitreNbrRetoursEffectuees.Text = "Nombre de retours effectuées : "
        '
        'lEmprunteursTitreNbrEmpruntsActifs
        '
        Me.lEmprunteursTitreNbrEmpruntsActifs.AutoSize = True
        Me.lEmprunteursTitreNbrEmpruntsActifs.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lEmprunteursTitreNbrEmpruntsActifs.Location = New System.Drawing.Point(28, 129)
        Me.lEmprunteursTitreNbrEmpruntsActifs.Name = "lEmprunteursTitreNbrEmpruntsActifs"
        Me.lEmprunteursTitreNbrEmpruntsActifs.Size = New System.Drawing.Size(254, 22)
        Me.lEmprunteursTitreNbrEmpruntsActifs.TabIndex = 21
        Me.lEmprunteursTitreNbrEmpruntsActifs.Text = "Nombre d'emprunteurs actifs : "
        '
        'lEmprunteurTitreEmprunteursSuspendues
        '
        Me.lEmprunteurTitreEmprunteursSuspendues.AutoSize = True
        Me.lEmprunteurTitreEmprunteursSuspendues.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lEmprunteurTitreEmprunteursSuspendues.Location = New System.Drawing.Point(28, 168)
        Me.lEmprunteurTitreEmprunteursSuspendues.Name = "lEmprunteurTitreEmprunteursSuspendues"
        Me.lEmprunteurTitreEmprunteursSuspendues.Size = New System.Drawing.Size(309, 22)
        Me.lEmprunteurTitreEmprunteursSuspendues.TabIndex = 22
        Me.lEmprunteurTitreEmprunteursSuspendues.Text = "Nombre d'emprunteurs suspendues : "
        '
        'lEmprunteursTitreNbrRetoursAttentes
        '
        Me.lEmprunteursTitreNbrRetoursAttentes.AutoSize = True
        Me.lEmprunteursTitreNbrRetoursAttentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lEmprunteursTitreNbrRetoursAttentes.Location = New System.Drawing.Point(31, 328)
        Me.lEmprunteursTitreNbrRetoursAttentes.Name = "lEmprunteursTitreNbrRetoursAttentes"
        Me.lEmprunteursTitreNbrRetoursAttentes.Size = New System.Drawing.Size(259, 22)
        Me.lEmprunteursTitreNbrRetoursAttentes.TabIndex = 23
        Me.lEmprunteursTitreNbrRetoursAttentes.Text = "Nombre de retours en attente : "
        '
        'lTitreNbrFraisRetards
        '
        Me.lTitreNbrFraisRetards.AutoSize = True
        Me.lTitreNbrFraisRetards.Location = New System.Drawing.Point(26, 357)
        Me.lTitreNbrFraisRetards.Name = "lTitreNbrFraisRetards"
        Me.lTitreNbrFraisRetards.Size = New System.Drawing.Size(197, 13)
        Me.lTitreNbrFraisRetards.TabIndex = 28
        Me.lTitreNbrFraisRetards.Text = "Nombre de frais de retards accumulées :"
        '
        'lNbrFraisRetards
        '
        Me.lNbrFraisRetards.AutoSize = True
        Me.lNbrFraisRetards.Location = New System.Drawing.Point(229, 358)
        Me.lNbrFraisRetards.Name = "lNbrFraisRetards"
        Me.lNbrFraisRetards.Size = New System.Drawing.Size(54, 13)
        Me.lNbrFraisRetards.TabIndex = 29
        Me.lNbrFraisRetards.Text = "NOMBRE"
        '
        'lEmprunteursNbrEmprunteurs
        '
        Me.lEmprunteursNbrEmprunteurs.AutoSize = True
        Me.lEmprunteursNbrEmprunteurs.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lEmprunteursNbrEmprunteurs.Location = New System.Drawing.Point(238, 99)
        Me.lEmprunteursNbrEmprunteurs.Name = "lEmprunteursNbrEmprunteurs"
        Me.lEmprunteursNbrEmprunteurs.Size = New System.Drawing.Size(88, 22)
        Me.lEmprunteursNbrEmprunteurs.TabIndex = 24
        Me.lEmprunteursNbrEmprunteurs.Text = "NOMBRE"
        '
        'lEmprunteursNbrEmpruntsActifs
        '
        Me.lEmprunteursNbrEmpruntsActifs.AutoSize = True
        Me.lEmprunteursNbrEmpruntsActifs.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lEmprunteursNbrEmpruntsActifs.Location = New System.Drawing.Point(288, 129)
        Me.lEmprunteursNbrEmpruntsActifs.Name = "lEmprunteursNbrEmpruntsActifs"
        Me.lEmprunteursNbrEmpruntsActifs.Size = New System.Drawing.Size(88, 22)
        Me.lEmprunteursNbrEmpruntsActifs.TabIndex = 25
        Me.lEmprunteursNbrEmpruntsActifs.Text = "NOMBRE"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label12.Location = New System.Drawing.Point(343, 168)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 22)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "NOMBRE"
        '
        'lEmprunteurNbrPretsEffectuees
        '
        Me.lEmprunteurNbrPretsEffectuees.AutoSize = True
        Me.lEmprunteurNbrPretsEffectuees.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lEmprunteurNbrPretsEffectuees.Location = New System.Drawing.Point(276, 205)
        Me.lEmprunteurNbrPretsEffectuees.Name = "lEmprunteurNbrPretsEffectuees"
        Me.lEmprunteurNbrPretsEffectuees.Size = New System.Drawing.Size(88, 22)
        Me.lEmprunteurNbrPretsEffectuees.TabIndex = 27
        Me.lEmprunteurNbrPretsEffectuees.Text = "NOMBRE"
        '
        'lEmprunteursNbrPretsActifs
        '
        Me.lEmprunteursNbrPretsActifs.AutoSize = True
        Me.lEmprunteursNbrPretsActifs.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lEmprunteursNbrPretsActifs.Location = New System.Drawing.Point(238, 242)
        Me.lEmprunteursNbrPretsActifs.Name = "lEmprunteursNbrPretsActifs"
        Me.lEmprunteursNbrPretsActifs.Size = New System.Drawing.Size(88, 22)
        Me.lEmprunteursNbrPretsActifs.TabIndex = 28
        Me.lEmprunteursNbrPretsActifs.Text = "NOMBRE"
        '
        'lEmprunteursNbrRetoursEffectuees
        '
        Me.lEmprunteursNbrRetoursEffectuees.AutoSize = True
        Me.lEmprunteursNbrRetoursEffectuees.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lEmprunteursNbrRetoursEffectuees.Location = New System.Drawing.Point(288, 284)
        Me.lEmprunteursNbrRetoursEffectuees.Name = "lEmprunteursNbrRetoursEffectuees"
        Me.lEmprunteursNbrRetoursEffectuees.Size = New System.Drawing.Size(88, 22)
        Me.lEmprunteursNbrRetoursEffectuees.TabIndex = 29
        Me.lEmprunteursNbrRetoursEffectuees.Text = "NOMBRE"
        '
        'lEmprunteursNbrRetoursAttentes
        '
        Me.lEmprunteursNbrRetoursAttentes.AutoSize = True
        Me.lEmprunteursNbrRetoursAttentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lEmprunteursNbrRetoursAttentes.Location = New System.Drawing.Point(288, 328)
        Me.lEmprunteursNbrRetoursAttentes.Name = "lEmprunteursNbrRetoursAttentes"
        Me.lEmprunteursNbrRetoursAttentes.Size = New System.Drawing.Size(88, 22)
        Me.lEmprunteursNbrRetoursAttentes.TabIndex = 30
        Me.lEmprunteursNbrRetoursAttentes.Text = "NOMBRE"
        '
        'lPreteursTitre
        '
        Me.lPreteursTitre.AutoSize = True
        Me.lPreteursTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lPreteursTitre.Location = New System.Drawing.Point(9, 24)
        Me.lPreteursTitre.Name = "lPreteursTitre"
        Me.lPreteursTitre.Size = New System.Drawing.Size(321, 20)
        Me.lPreteursTitre.TabIndex = 21
        Me.lPreteursTitre.Text = "Toutes les infos des prêteurs de l'application"
        '
        'cbPreteursChoixAnnee
        '
        Me.cbPreteursChoixAnnee.FormattingEnabled = True
        Me.cbPreteursChoixAnnee.Items.AddRange(New Object() {"Aucunes"})
        Me.cbPreteursChoixAnnee.Location = New System.Drawing.Point(581, 20)
        Me.cbPreteursChoixAnnee.Name = "cbPreteursChoixAnnee"
        Me.cbPreteursChoixAnnee.Size = New System.Drawing.Size(110, 21)
        Me.cbPreteursChoixAnnee.TabIndex = 20
        '
        'cbPreteursChoixMois
        '
        Me.cbPreteursChoixMois.FormattingEnabled = True
        Me.cbPreteursChoixMois.Items.AddRange(New Object() {"Aucunes"})
        Me.cbPreteursChoixMois.Location = New System.Drawing.Point(406, 20)
        Me.cbPreteursChoixMois.Name = "cbPreteursChoixMois"
        Me.cbPreteursChoixMois.Size = New System.Drawing.Size(110, 21)
        Me.cbPreteursChoixMois.TabIndex = 19
        '
        'lPreteursTitreChoixAnnee
        '
        Me.lPreteursTitreChoixAnnee.AutoSize = True
        Me.lPreteursTitreChoixAnnee.Location = New System.Drawing.Point(537, 24)
        Me.lPreteursTitreChoixAnnee.Name = "lPreteursTitreChoixAnnee"
        Me.lPreteursTitreChoixAnnee.Size = New System.Drawing.Size(38, 13)
        Me.lPreteursTitreChoixAnnee.TabIndex = 18
        Me.lPreteursTitreChoixAnnee.Text = "Année"
        '
        'lPreteursTitreChoixMois
        '
        Me.lPreteursTitreChoixMois.AutoSize = True
        Me.lPreteursTitreChoixMois.Location = New System.Drawing.Point(371, 24)
        Me.lPreteursTitreChoixMois.Name = "lPreteursTitreChoixMois"
        Me.lPreteursTitreChoixMois.Size = New System.Drawing.Size(29, 13)
        Me.lPreteursTitreChoixMois.TabIndex = 17
        Me.lPreteursTitreChoixMois.Text = "Mois"
        '
        'bPreteursPDF
        '
        Me.bPreteursPDF.Location = New System.Drawing.Point(508, 276)
        Me.bPreteursPDF.Name = "bPreteursPDF"
        Me.bPreteursPDF.Size = New System.Drawing.Size(164, 71)
        Me.bPreteursPDF.TabIndex = 22
        Me.bPreteursPDF.Text = "Exporter en .PDF"
        Me.bPreteursPDF.UseVisualStyleBackColor = True
        '
        'bPreteursDOCS
        '
        Me.bPreteursDOCS.Location = New System.Drawing.Point(508, 184)
        Me.bPreteursDOCS.Name = "bPreteursDOCS"
        Me.bPreteursDOCS.Size = New System.Drawing.Size(164, 71)
        Me.bPreteursDOCS.TabIndex = 23
        Me.bPreteursDOCS.Text = "Exporter en .DOCS"
        Me.bPreteursDOCS.UseVisualStyleBackColor = True
        '
        'bPreteursXLSX
        '
        Me.bPreteursXLSX.Location = New System.Drawing.Point(508, 93)
        Me.bPreteursXLSX.Name = "bPreteursXLSX"
        Me.bPreteursXLSX.Size = New System.Drawing.Size(164, 71)
        Me.bPreteursXLSX.TabIndex = 24
        Me.bPreteursXLSX.Text = "Exporter en .XLSX"
        Me.bPreteursXLSX.UseVisualStyleBackColor = True
        '
        'Statistiques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gbPartieEmprunteurs)
        Me.Controls.Add(Me.gbPartieAdministrateur)
        Me.Controls.Add(Me.gbGlobale)
        Me.Controls.Add(Me.bAdministrateurs)
        Me.Controls.Add(Me.bPreteurs)
        Me.Controls.Add(Me.bEmprunteurs)
        Me.Controls.Add(Me.bPartieGlobale)
        Me.Name = "Statistiques"
        Me.Size = New System.Drawing.Size(1013, 473)
        Me.gbGlobale.ResumeLayout(False)
        Me.gbGlobale.PerformLayout()
        Me.gbPartieEmprunteurs.ResumeLayout(False)
        Me.gbPartieEmprunteurs.PerformLayout()
        Me.gbPartiePreteurs.ResumeLayout(False)
        Me.gbPartiePreteurs.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bPartieGlobale As Button
    Friend WithEvents bEmprunteurs As Button
    Friend WithEvents bPreteurs As Button
    Friend WithEvents bAdministrateurs As Button
    Friend WithEvents gbGlobale As GroupBox
    Friend WithEvents gbPartieEmprunteurs As GroupBox
    Friend WithEvents gbPartiePreteurs As GroupBox
    Friend WithEvents gbPartieAdministrateur As GroupBox
    Friend WithEvents lTitreGlobale As Label
    Friend WithEvents cbGlobaleChoixAnnee As ComboBox
    Friend WithEvents cbGlobaleChoixMois As ComboBox
    Friend WithEvents lGlobaleChoixAnnee As Label
    Friend WithEvents lGlobaleChoixMois As Label
    Friend WithEvents bGlobalePDF As Button
    Friend WithEvents bGlobaleDOCS As Button
    Friend WithEvents bGlobaleXLSX As Button
    Friend WithEvents lTitreNbrRetours As Label
    Friend WithEvents lTitreNbrPrets As Label
    Friend WithEvents lTitreNbrOuverturesApplis As Label
    Friend WithEvents lTitreNbrAdministratifs As Label
    Friend WithEvents lTitreNbrEmprunteurs As Label
    Friend WithEvents lTitreNbrPreteurs As Label
    Friend WithEvents lTitreNbrPersonneBD As Label
    Friend WithEvents lTitreNbrConditions As Label
    Friend WithEvents lTitreNbrEquipements As Label
    Friend WithEvents lNbrResponsabilites As Label
    Friend WithEvents lNbrConditions As Label
    Friend WithEvents lNbrEquipements As Label
    Friend WithEvents lNbrAdministratifs As Label
    Friend WithEvents lNbrPreteurs As Label
    Friend WithEvents lNbrEmprunteurs As Label
    Friend WithEvents lNbrPersonneBD As Label
    Friend WithEvents lNbrRetours As Label
    Friend WithEvents lNbrPrets As Label
    Friend WithEvents lNbrOuverturesApplis As Label
    Friend WithEvents lTitreNbrResponsabilites As Label
    Friend WithEvents bEmprunteursPDF As Button
    Friend WithEvents bEmprunteursDOCS As Button
    Friend WithEvents bEmprunteursXLSX As Button
    Friend WithEvents cbEmprunteurChoixAnnee As ComboBox
    Friend WithEvents cbEmprunteurChoixMois As ComboBox
    Friend WithEvents lEmprunteurTitreChoixAnnee As Label
    Friend WithEvents lEmprunteurTitreChoixMois As Label
    Friend WithEvents lTitrePartieEmprunteurs As Label
    Friend WithEvents lEmprunteursTitreNbrEmprunteurs As Label
    Friend WithEvents lNbrFraisRetards As Label
    Friend WithEvents lTitreNbrFraisRetards As Label
    Friend WithEvents lEmprunteursTitreNbrRetoursAttentes As Label
    Friend WithEvents lEmprunteurTitreEmprunteursSuspendues As Label
    Friend WithEvents lEmprunteursTitreNbrEmpruntsActifs As Label
    Friend WithEvents lEmprunteursTitreNbrRetoursEffectuees As Label
    Friend WithEvents lEmprunteursTitreNbrPretsActifs As Label
    Friend WithEvents lEmprunteurTitreNbrPretsEffectuees As Label
    Friend WithEvents lEmprunteursNbrRetoursAttentes As Label
    Friend WithEvents lEmprunteursNbrRetoursEffectuees As Label
    Friend WithEvents lEmprunteursNbrPretsActifs As Label
    Friend WithEvents lEmprunteurNbrPretsEffectuees As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lEmprunteursNbrEmpruntsActifs As Label
    Friend WithEvents lEmprunteursNbrEmprunteurs As Label
    Friend WithEvents bPreteursPDF As Button
    Friend WithEvents bPreteursDOCS As Button
    Friend WithEvents bPreteursXLSX As Button
    Friend WithEvents lPreteursTitre As Label
    Friend WithEvents cbPreteursChoixAnnee As ComboBox
    Friend WithEvents cbPreteursChoixMois As ComboBox
    Friend WithEvents lPreteursTitreChoixAnnee As Label
    Friend WithEvents lPreteursTitreChoixMois As Label
End Class
