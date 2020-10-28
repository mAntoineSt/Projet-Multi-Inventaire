<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionMateriel
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAccueil_Materiel = New System.Windows.Forms.Button()
        Me.btnFiche_Materiel = New System.Windows.Forms.Button()
        Me.btnListe_Materiel = New System.Windows.Forms.Button()
        Me.btnLEnrModif_Materiel = New System.Windows.Forms.Button()
        Me.btnLogin_Materiel = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1207, 739)
        Me.Panel1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.47727!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.52273!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 302.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnLogin_Materiel, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1207, 56)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1184, 56)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(23, 683)
        Me.Panel2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 711)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1184, 28)
        Me.Panel4.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnListe_Materiel, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.btnAccueil_Materiel, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnFiche_Materiel, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.btnLEnrModif_Materiel, 0, 4)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 56)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(233, 655)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'btnAccueil_Materiel
        '
        Me.btnAccueil_Materiel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAccueil_Materiel.Location = New System.Drawing.Point(20, 129)
        Me.btnAccueil_Materiel.Margin = New System.Windows.Forms.Padding(20)
        Me.btnAccueil_Materiel.Name = "btnAccueil_Materiel"
        Me.btnAccueil_Materiel.Size = New System.Drawing.Size(193, 69)
        Me.btnAccueil_Materiel.TabIndex = 0
        Me.btnAccueil_Materiel.Text = "ACCUEIL"
        Me.btnAccueil_Materiel.UseVisualStyleBackColor = True
        '
        'btnFiche_Materiel
        '
        Me.btnFiche_Materiel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnFiche_Materiel.Location = New System.Drawing.Point(20, 347)
        Me.btnFiche_Materiel.Margin = New System.Windows.Forms.Padding(20)
        Me.btnFiche_Materiel.Name = "btnFiche_Materiel"
        Me.btnFiche_Materiel.Size = New System.Drawing.Size(193, 69)
        Me.btnFiche_Materiel.TabIndex = 1
        Me.btnFiche_Materiel.Text = "FICHE DU MATÉRIEL"
        Me.btnFiche_Materiel.UseVisualStyleBackColor = True
        '
        'btnListe_Materiel
        '
        Me.btnListe_Materiel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnListe_Materiel.Location = New System.Drawing.Point(20, 238)
        Me.btnListe_Materiel.Margin = New System.Windows.Forms.Padding(20)
        Me.btnListe_Materiel.Name = "btnListe_Materiel"
        Me.btnListe_Materiel.Size = New System.Drawing.Size(193, 69)
        Me.btnListe_Materiel.TabIndex = 2
        Me.btnListe_Materiel.Text = "LISTE DU MATÉRIEL"
        Me.btnListe_Materiel.UseVisualStyleBackColor = True
        '
        'btnLEnrModif_Materiel
        '
        Me.btnLEnrModif_Materiel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLEnrModif_Materiel.Location = New System.Drawing.Point(20, 456)
        Me.btnLEnrModif_Materiel.Margin = New System.Windows.Forms.Padding(20)
        Me.btnLEnrModif_Materiel.Name = "btnLEnrModif_Materiel"
        Me.btnLEnrModif_Materiel.Size = New System.Drawing.Size(193, 69)
        Me.btnLEnrModif_Materiel.TabIndex = 3
        Me.btnLEnrModif_Materiel.Text = "ENREGISTREMENT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ET " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MODIFICATION"
        Me.btnLEnrModif_Materiel.UseVisualStyleBackColor = True
        '
        'btnLogin_Materiel
        '
        Me.btnLogin_Materiel.Location = New System.Drawing.Point(883, 3)
        Me.btnLogin_Materiel.Name = "btnLogin_Materiel"
        Me.btnLogin_Materiel.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin_Materiel.TabIndex = 0
        Me.btnLogin_Materiel.Text = "Button4"
        Me.btnLogin_Materiel.UseVisualStyleBackColor = True
        '
        'GestionMateriel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1207, 739)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "GestionMateriel"
        Me.Text = "GestionMateriel"
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnListe_Materiel As Button
    Friend WithEvents btnAccueil_Materiel As Button
    Friend WithEvents btnFiche_Materiel As Button
    Friend WithEvents btnLEnrModif_Materiel As Button
    Friend WithEvents btnLogin_Materiel As Button
End Class
