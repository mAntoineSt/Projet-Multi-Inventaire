<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnregistrementMateriel
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbcEnrMat = New System.Windows.Forms.TabControl()
        Me.tem_Information = New System.Windows.Forms.TabPage()
        Me.tem_conditions = New System.Windows.Forms.TabPage()
        Me.tem_histo_dommages = New System.Windows.Forms.TabPage()
        Me.tem_histo_reparation = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.tbcEnrMat.SuspendLayout()
        Me.tem_Information.SuspendLayout()
        Me.tem_histo_dommages.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tbcEnrMat)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1122, 805)
        Me.Panel1.TabIndex = 0
        '
        'tbcEnrMat
        '
        Me.tbcEnrMat.Controls.Add(Me.tem_Information)
        Me.tbcEnrMat.Controls.Add(Me.tem_conditions)
        Me.tbcEnrMat.Controls.Add(Me.tem_histo_dommages)
        Me.tbcEnrMat.Controls.Add(Me.tem_histo_reparation)
        Me.tbcEnrMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcEnrMat.Location = New System.Drawing.Point(61, 56)
        Me.tbcEnrMat.Name = "tbcEnrMat"
        Me.tbcEnrMat.SelectedIndex = 0
        Me.tbcEnrMat.Size = New System.Drawing.Size(955, 692)
        Me.tbcEnrMat.TabIndex = 0
        '
        'tem_Information
        '
        Me.tem_Information.Controls.Add(Me.Panel2)
        Me.tem_Information.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tem_Information.Location = New System.Drawing.Point(4, 29)
        Me.tem_Information.Name = "tem_Information"
        Me.tem_Information.Padding = New System.Windows.Forms.Padding(3)
        Me.tem_Information.Size = New System.Drawing.Size(947, 659)
        Me.tem_Information.TabIndex = 0
        Me.tem_Information.Text = "Informations"
        Me.tem_Information.UseVisualStyleBackColor = True
        '
        'tem_conditions
        '
        Me.tem_conditions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tem_conditions.Location = New System.Drawing.Point(4, 29)
        Me.tem_conditions.Name = "tem_conditions"
        Me.tem_conditions.Padding = New System.Windows.Forms.Padding(3)
        Me.tem_conditions.Size = New System.Drawing.Size(947, 659)
        Me.tem_conditions.TabIndex = 1
        Me.tem_conditions.Text = "Conditions d'emprunt"
        Me.tem_conditions.UseVisualStyleBackColor = True
        '
        'tem_histo_dommages
        '
        Me.tem_histo_dommages.Controls.Add(Me.Panel4)
        Me.tem_histo_dommages.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tem_histo_dommages.Location = New System.Drawing.Point(4, 29)
        Me.tem_histo_dommages.Name = "tem_histo_dommages"
        Me.tem_histo_dommages.Size = New System.Drawing.Size(947, 659)
        Me.tem_histo_dommages.TabIndex = 2
        Me.tem_histo_dommages.Text = "État du Matériel"
        Me.tem_histo_dommages.UseVisualStyleBackColor = True
        '
        'tem_histo_reparation
        '
        Me.tem_histo_reparation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tem_histo_reparation.Location = New System.Drawing.Point(4, 29)
        Me.tem_histo_reparation.Name = "tem_histo_reparation"
        Me.tem_histo_reparation.Size = New System.Drawing.Size(947, 659)
        Me.tem_histo_reparation.TabIndex = 3
        Me.tem_histo_reparation.Text = "Historique des réparations"
        Me.tem_histo_reparation.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(6, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(938, 647)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(938, 61)
        Me.Panel3.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(153, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Informations sur le matériel"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.44444!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.55556!))
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox5, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox4, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox3, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DateTimePicker2, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.RichTextBox1, 1, 6)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 91)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(450, 500)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.44444!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.55556!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label16, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox9, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox8, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox7, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox6, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label13, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label14, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.ComboBox1, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.DateTimePicker1, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Button1, 1, 6)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(479, 91)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 7
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(450, 500)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(82, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 20, 3, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 31)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Identifiant"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(84, 304)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 20, 3, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 31)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Fabricant"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(95, 91)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 20, 3, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 31)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Marque"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 375)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 20, 3, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 31)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Année de Fabrication"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(97, 162)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3, 20, 3, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 31)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Modèle"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(72, 446)
        Me.Label7.Margin = New System.Windows.Forms.Padding(3, 20, 3, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 34)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Description"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(88, 233)
        Me.Label8.Margin = New System.Windows.Forms.Padding(3, 20, 3, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 31)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "No Série"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(68, 20)
        Me.Label9.Margin = New System.Windows.Forms.Padding(3, 20, 3, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 31)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Fournisseur"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(82, 304)
        Me.Label10.Margin = New System.Windows.Forms.Padding(3, 20, 3, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 31)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Catégorie"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(31, 91)
        Me.Label11.Margin = New System.Windows.Forms.Padding(3, 20, 3, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 31)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Année acquisition"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(79, 375)
        Me.Label12.Margin = New System.Windows.Forms.Padding(3, 20, 3, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 31)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "No Antivol"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(63, 162)
        Me.Label13.Margin = New System.Windows.Forms.Padding(3, 20, 3, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 31)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Coût d'Achat"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(37, 233)
        Me.Label14.Margin = New System.Windows.Forms.Padding(3, 20, 3, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(114, 31)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Valeur résiduelle"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TextBox1.Location = New System.Drawing.Point(157, 20)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 20, 3, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(290, 20)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.TextBox2.Location = New System.Drawing.Point(157, 91)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 20, 3, 20)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(290, 20)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.TextBox3.Location = New System.Drawing.Point(157, 162)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 20, 3, 20)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(290, 20)
        Me.TextBox3.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.Dock = System.Windows.Forms.DockStyle.Left
        Me.TextBox4.Location = New System.Drawing.Point(157, 233)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 20, 3, 20)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(290, 20)
        Me.TextBox4.TabIndex = 10
        '
        'TextBox5
        '
        Me.TextBox5.Dock = System.Windows.Forms.DockStyle.Left
        Me.TextBox5.Location = New System.Drawing.Point(157, 304)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(3, 20, 3, 20)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(290, 20)
        Me.TextBox5.TabIndex = 11
        '
        'TextBox6
        '
        Me.TextBox6.Dock = System.Windows.Forms.DockStyle.Left
        Me.TextBox6.Location = New System.Drawing.Point(157, 20)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(3, 20, 3, 20)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(290, 20)
        Me.TextBox6.TabIndex = 13
        '
        'TextBox7
        '
        Me.TextBox7.Dock = System.Windows.Forms.DockStyle.Left
        Me.TextBox7.Location = New System.Drawing.Point(157, 162)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(3, 20, 3, 20)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(290, 20)
        Me.TextBox7.TabIndex = 8
        '
        'TextBox8
        '
        Me.TextBox8.Dock = System.Windows.Forms.DockStyle.Left
        Me.TextBox8.Location = New System.Drawing.Point(157, 233)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(3, 20, 3, 20)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(290, 20)
        Me.TextBox8.TabIndex = 8
        '
        'TextBox9
        '
        Me.TextBox9.Dock = System.Windows.Forms.DockStyle.Left
        Me.TextBox9.Location = New System.Drawing.Point(157, 375)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(3, 20, 3, 20)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(290, 20)
        Me.TextBox9.TabIndex = 8
        '
        'ComboBox1
        '
        Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(157, 304)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 20, 3, 20)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(290, 21)
        Me.ComboBox1.TabIndex = 14
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DateTimePicker1.Location = New System.Drawing.Point(157, 91)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 20, 3, 20)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(290, 20)
        Me.DateTimePicker1.TabIndex = 15
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Dock = System.Windows.Forms.DockStyle.Left
        Me.DateTimePicker2.Location = New System.Drawing.Point(157, 375)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(3, 20, 3, 20)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(290, 20)
        Me.DateTimePicker2.TabIndex = 12
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(157, 429)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(290, 68)
        Me.RichTextBox1.TabIndex = 13
        Me.RichTextBox1.Text = ""
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(947, 656)
        Me.Panel4.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(947, 61)
        Me.Panel5.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(153, 19)
        Me.Label15.Margin = New System.Windows.Forms.Padding(3)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(223, 24)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Rapport d'état du matériel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(106, 446)
        Me.Label16.Margin = New System.Windows.Forms.Padding(3, 20, 3, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 34)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Photo"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.Location = New System.Drawing.Point(174, 441)
        Me.Button1.Margin = New System.Windows.Forms.Padding(20, 15, 3, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 44)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Parcourir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EnregistrementMateriel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "EnregistrementMateriel"
        Me.Size = New System.Drawing.Size(1122, 805)
        Me.Panel1.ResumeLayout(False)
        Me.tbcEnrMat.ResumeLayout(False)
        Me.tem_Information.ResumeLayout(False)
        Me.tem_histo_dommages.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbcEnrMat As TabControl
    Friend WithEvents tem_Information As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents tem_conditions As TabPage
    Friend WithEvents tem_histo_dommages As TabPage
    Friend WithEvents tem_histo_reparation As TabPage
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label15 As Label
End Class
