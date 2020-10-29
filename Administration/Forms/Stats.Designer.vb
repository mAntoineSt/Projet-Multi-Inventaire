<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stats
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
        Me.cbAnnees = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbMois = New System.Windows.Forms.ComboBox()
        Me.lbMoisChoisie = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btPdf = New System.Windows.Forms.Button()
        Me.btWord = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbAnnees
        '
        Me.cbAnnees.FormattingEnabled = True
        Me.cbAnnees.Location = New System.Drawing.Point(239, 12)
        Me.cbAnnees.Name = "cbAnnees"
        Me.cbAnnees.Size = New System.Drawing.Size(244, 21)
        Me.cbAnnees.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(146, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Année choisie"
        '
        'cbMois
        '
        Me.cbMois.FormattingEnabled = True
        Me.cbMois.Location = New System.Drawing.Point(238, 55)
        Me.cbMois.Name = "cbMois"
        Me.cbMois.Size = New System.Drawing.Size(244, 21)
        Me.cbMois.TabIndex = 2
        '
        'lbMoisChoisie
        '
        Me.lbMoisChoisie.AutoSize = True
        Me.lbMoisChoisie.Location = New System.Drawing.Point(147, 59)
        Me.lbMoisChoisie.Name = "lbMoisChoisie"
        Me.lbMoisChoisie.Size = New System.Drawing.Size(65, 13)
        Me.lbMoisChoisie.TabIndex = 3
        Me.lbMoisChoisie.Text = "Mois choisie"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre de prêts effectuées :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nombre de retours effectuées :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nombre de retards :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Frais cumulées : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Nombre de prêteurs unique : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Nombre d'ajouts d'équipements"
        '
        'btPdf
        '
        Me.btPdf.Location = New System.Drawing.Point(401, 153)
        Me.btPdf.Name = "btPdf"
        Me.btPdf.Size = New System.Drawing.Size(198, 79)
        Me.btPdf.TabIndex = 10
        Me.btPdf.Text = "Avoir une version pdf"
        Me.btPdf.UseVisualStyleBackColor = True
        '
        'btWord
        '
        Me.btWord.Location = New System.Drawing.Point(401, 238)
        Me.btWord.Name = "btWord"
        Me.btWord.Size = New System.Drawing.Size(198, 79)
        Me.btWord.TabIndex = 11
        Me.btWord.Text = "Avoir une version word"
        Me.btWord.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 219)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(200, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Nombre de suppressions d'équipements :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 238)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(149, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Nombre d'équipements actifs :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 282)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(154, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Nombre d'emprunteurs unique :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 310)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(129, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Nombre d'admins unique :"
        '
        'Stats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 395)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btWord)
        Me.Controls.Add(Me.btPdf)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbMoisChoisie)
        Me.Controls.Add(Me.cbMois)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbAnnees)
        Me.Name = "Stats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stats"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbAnnees As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbMois As ComboBox
    Friend WithEvents lbMoisChoisie As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btPdf As Button
    Friend WithEvents btWord As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
