﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Gestion_Admins
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
        Me.dgvListeAdministrateurs = New System.Windows.Forms.DataGridView()
        Me.pTitre = New System.Windows.Forms.Panel()
        Me.bAjoutAdmin = New System.Windows.Forms.Button()
        Me.bModifAdmin = New System.Windows.Forms.Button()
        Me.bSuppressionAdmin = New System.Windows.Forms.Button()
        Me.bDroitsAdmins = New System.Windows.Forms.Button()
        CType(Me.dgvListeAdministrateurs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pTitre.SuspendLayout()
        Me.SuspendLayout()
        '
        'lTitre
        '
        Me.lTitre.AutoSize = True
        Me.lTitre.BackColor = System.Drawing.Color.Transparent
        Me.lTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lTitre.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lTitre.Location = New System.Drawing.Point(42, 22)
        Me.lTitre.Name = "lTitre"
        Me.lTitre.Size = New System.Drawing.Size(352, 31)
        Me.lTitre.TabIndex = 0
        Me.lTitre.Text = "Gestion des administrateurs"
        '
        'dgvListeAdministrateurs
        '
        Me.dgvListeAdministrateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListeAdministrateurs.Location = New System.Drawing.Point(56, 114)
        Me.dgvListeAdministrateurs.Name = "dgvListeAdministrateurs"
        Me.dgvListeAdministrateurs.Size = New System.Drawing.Size(601, 323)
        Me.dgvListeAdministrateurs.TabIndex = 1
        '
        'pTitre
        '
        Me.pTitre.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pTitre.Controls.Add(Me.lTitre)
        Me.pTitre.Location = New System.Drawing.Point(144, 16)
        Me.pTitre.Name = "pTitre"
        Me.pTitre.Size = New System.Drawing.Size(436, 80)
        Me.pTitre.TabIndex = 2
        '
        'bAjoutAdmin
        '
        Me.bAjoutAdmin.Location = New System.Drawing.Point(776, 138)
        Me.bAjoutAdmin.Name = "bAjoutAdmin"
        Me.bAjoutAdmin.Size = New System.Drawing.Size(142, 56)
        Me.bAjoutAdmin.TabIndex = 3
        Me.bAjoutAdmin.Text = "Ajouter un nouvel administrateur"
        Me.bAjoutAdmin.UseVisualStyleBackColor = True
        '
        'bModifAdmin
        '
        Me.bModifAdmin.Location = New System.Drawing.Point(776, 211)
        Me.bModifAdmin.Name = "bModifAdmin"
        Me.bModifAdmin.Size = New System.Drawing.Size(142, 56)
        Me.bModifAdmin.TabIndex = 4
        Me.bModifAdmin.Text = "Modifier un administrateur"
        Me.bModifAdmin.UseVisualStyleBackColor = True
        '
        'bSuppressionAdmin
        '
        Me.bSuppressionAdmin.Location = New System.Drawing.Point(776, 283)
        Me.bSuppressionAdmin.Name = "bSuppressionAdmin"
        Me.bSuppressionAdmin.Size = New System.Drawing.Size(142, 56)
        Me.bSuppressionAdmin.TabIndex = 5
        Me.bSuppressionAdmin.Text = "Supprimer un administrateur"
        Me.bSuppressionAdmin.UseVisualStyleBackColor = True
        '
        'bDroitsAdmins
        '
        Me.bDroitsAdmins.Location = New System.Drawing.Point(776, 357)
        Me.bDroitsAdmins.Name = "bDroitsAdmins"
        Me.bDroitsAdmins.Size = New System.Drawing.Size(142, 56)
        Me.bDroitsAdmins.TabIndex = 6
        Me.bDroitsAdmins.Text = "Enlever/Remettre les droits d'un administrateur"
        Me.bDroitsAdmins.UseVisualStyleBackColor = True
        '
        'Gestion_Admins
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.bDroitsAdmins)
        Me.Controls.Add(Me.bSuppressionAdmin)
        Me.Controls.Add(Me.bModifAdmin)
        Me.Controls.Add(Me.bAjoutAdmin)
        Me.Controls.Add(Me.pTitre)
        Me.Controls.Add(Me.dgvListeAdministrateurs)
        Me.Name = "Gestion_Admins"
        Me.Size = New System.Drawing.Size(1013, 473)
        CType(Me.dgvListeAdministrateurs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pTitre.ResumeLayout(False)
        Me.pTitre.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lTitre As Label
    Friend WithEvents dgvListeAdministrateurs As DataGridView
    Friend WithEvents pTitre As Panel
    Friend WithEvents bAjoutAdmin As Button
    Friend WithEvents bModifAdmin As Button
    Friend WithEvents bSuppressionAdmin As Button
    Friend WithEvents bDroitsAdmins As Button
End Class
