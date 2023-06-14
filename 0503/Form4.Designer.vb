<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.comboBox3 = New System.Windows.Forms.ComboBox()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.dataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.label5 = New System.Windows.Forms.Label()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pictureBox5 = New System.Windows.Forms.PictureBox()
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.label14 = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Campus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EquipmentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EquipmentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentalDateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturnDateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RenterName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RenterID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Department = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.label15 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.pictureBox10 = New System.Windows.Forms.PictureBox()
        Me.pictureBox9 = New System.Windows.Forms.PictureBox()
        Me.pictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'comboBox3
        '
        Me.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox3.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBox3.FormattingEnabled = True
        Me.comboBox3.Items.AddRange(New Object() {"教育系", "輔資系", "體育系", "特教系", "幼教系", "數位系", "中文系", "視藝系", "應歷系", "外文系", "音樂系", "企管系", "應經系", "科管系", "資管系", "財金系", "行銷系", "農藝系", "園藝系", "森林系", "木設系", "動科系", "生農系", "景觀系", "植醫系", "電物系", "應化系", "應數系", "資工系", "生機系", "土木系", "電機系", "機械系", "食科系", "水生系", "生資系", "生化系", "微藥系", "獸醫系"})
        Me.comboBox3.Location = New System.Drawing.Point(560, 652)
        Me.comboBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.comboBox3.Name = "comboBox3"
        Me.comboBox3.Size = New System.Drawing.Size(266, 33)
        Me.comboBox3.TabIndex = 106
        '
        'textBox3
        '
        Me.textBox3.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox3.Location = New System.Drawing.Point(560, 594)
        Me.textBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(266, 34)
        Me.textBox3.TabIndex = 105
        '
        'textBox2
        '
        Me.textBox2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox2.Location = New System.Drawing.Point(560, 536)
        Me.textBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(266, 34)
        Me.textBox2.TabIndex = 104
        '
        'numericUpDown1
        '
        Me.numericUpDown1.Font = New System.Drawing.Font("Arial monospaced for SAP", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numericUpDown1.Location = New System.Drawing.Point(559, 304)
        Me.numericUpDown1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(267, 30)
        Me.numericUpDown1.TabIndex = 114
        '
        'dataGridViewImageColumn1
        '
        Me.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dataGridViewImageColumn1.HeaderText = ""
        Me.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.dataGridViewImageColumn1.MinimumWidth = 6
        Me.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1"
        '
        'textBox1
        '
        Me.textBox1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox1.Location = New System.Drawing.Point(560, 478)
        Me.textBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(266, 34)
        Me.textBox1.TabIndex = 103
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panel1.Controls.Add(Me.Label17)
        Me.panel1.Controls.Add(Me.Label16)
        Me.panel1.Controls.Add(Me.PictureBox11)
        Me.panel1.Controls.Add(Me.PictureBox3)
        Me.panel1.Controls.Add(Me.label4)
        Me.panel1.Controls.Add(Me.label3)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.panel2)
        Me.panel1.Controls.Add(Me.pictureBox5)
        Me.panel1.Controls.Add(Me.pictureBox4)
        Me.panel1.Controls.Add(Me.pictureBox1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(244, 800)
        Me.panel1.TabIndex = 90
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial monospaced for SAP", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.Control
        Me.Label17.Location = New System.Drawing.Point(77, 738)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(94, 23)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "History"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial monospaced for SAP", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.Control
        Me.Label16.Location = New System.Drawing.Point(40, 615)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(166, 23)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Administrator"
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = Global._0503.My.Resources.Resources.圖片11
        Me.PictureBox11.Location = New System.Drawing.Point(67, 682)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(114, 50)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox11.TabIndex = 8
        Me.PictureBox11.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global._0503.My.Resources.Resources.圖片2
        Me.PictureBox3.Location = New System.Drawing.Point(69, 561)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(112, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Arial monospaced for SAP", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.SystemColors.Control
        Me.label4.Location = New System.Drawing.Point(65, 496)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(118, 23)
        Me.label4.TabIndex = 6
        Me.label4.Text = "Inventory"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Arial monospaced for SAP", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.SystemColors.Control
        Me.label3.Location = New System.Drawing.Point(53, 370)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(142, 23)
        Me.label3.TabIndex = 6
        Me.label3.Text = "Maintenance"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Arial monospaced for SAP", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.Control
        Me.label1.Location = New System.Drawing.Point(93, 109)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(58, 23)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Home"
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.SystemColors.Control
        Me.panel2.Controls.Add(Me.label5)
        Me.panel2.Controls.Add(Me.pictureBox2)
        Me.panel2.Location = New System.Drawing.Point(12, 149)
        Me.panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(249, 128)
        Me.panel2.TabIndex = 1
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Arial monospaced for SAP", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label5.Location = New System.Drawing.Point(73, 94)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(82, 23)
        Me.label5.TabIndex = 6
        Me.label5.Text = "Rental"
        '
        'pictureBox2
        '
        Me.pictureBox2.Image = Global._0503.My.Resources.Resources.icons8_purchase_order_48
        Me.pictureBox2.Location = New System.Drawing.Point(61, 35)
        Me.pictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(112, 57)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox2.TabIndex = 1
        Me.pictureBox2.TabStop = False
        '
        'pictureBox5
        '
        Me.pictureBox5.Image = Global._0503.My.Resources.Resources._24
        Me.pictureBox5.Location = New System.Drawing.Point(69, 433)
        Me.pictureBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pictureBox5.Name = "pictureBox5"
        Me.pictureBox5.Size = New System.Drawing.Size(112, 57)
        Me.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox5.TabIndex = 4
        Me.pictureBox5.TabStop = False
        '
        'pictureBox4
        '
        Me.pictureBox4.Image = Global._0503.My.Resources.Resources._25
        Me.pictureBox4.Location = New System.Drawing.Point(69, 305)
        Me.pictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pictureBox4.Name = "pictureBox4"
        Me.pictureBox4.Size = New System.Drawing.Size(112, 57)
        Me.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox4.TabIndex = 3
        Me.pictureBox4.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global._0503.My.Resources.Resources._23
        Me.pictureBox1.Location = New System.Drawing.Point(67, 49)
        Me.pictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(112, 57)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = False
        '
        'dateTimePicker1
        '
        Me.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:MM:ss"
        Me.dateTimePicker1.Font = New System.Drawing.Font("Arial monospaced for SAP", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateTimePicker1.Location = New System.Drawing.Point(559, 362)
        Me.dateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dateTimePicker1.Name = "dateTimePicker1"
        Me.dateTimePicker1.Size = New System.Drawing.Size(266, 30)
        Me.dateTimePicker1.TabIndex = 101
        '
        'comboBox1
        '
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Items.AddRange(New Object() {"羽球拍", "羽球", "網球拍", "網球", "籃球", "排球", "足球", "桌球拍", "乒乓球", "棒球", "棒球棒", "棒球手套"})
        Me.comboBox1.Location = New System.Drawing.Point(559, 188)
        Me.comboBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(266, 33)
        Me.comboBox1.TabIndex = 100
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Font = New System.Drawing.Font("Arial monospaced for SAP", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label14.Location = New System.Drawing.Point(308, 652)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(166, 28)
        Me.label14.TabIndex = 99
        Me.label14.Text = "Department:"
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Font = New System.Drawing.Font("Arial monospaced for SAP", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label13.Location = New System.Drawing.Point(308, 594)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(194, 28)
        Me.label13.TabIndex = 98
        Me.label13.Text = "Phone Number:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Arial monospaced for SAP", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label12.Location = New System.Drawing.Point(308, 536)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(180, 28)
        Me.label12.TabIndex = 97
        Me.label12.Text = "Renter's ID:"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Arial monospaced for SAP", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label11.Location = New System.Drawing.Point(308, 478)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(208, 28)
        Me.label11.TabIndex = 96
        Me.label11.Text = "Renter's Name:"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Arial monospaced for SAP", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label10.Location = New System.Drawing.Point(307, 420)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(236, 28)
        Me.label10.TabIndex = 95
        Me.label10.Text = "Return DateTime:" & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Arial monospaced for SAP", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label9.Location = New System.Drawing.Point(307, 362)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(236, 28)
        Me.label9.TabIndex = 94
        Me.label9.Text = "Rental DateTime:"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Arial monospaced for SAP", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label8.Location = New System.Drawing.Point(307, 304)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(138, 28)
        Me.label8.TabIndex = 93
        Me.label8.Text = "Quantity:"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Arial monospaced for SAP", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label7.Location = New System.Drawing.Point(307, 188)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(222, 28)
        Me.label7.TabIndex = 92
        Me.label7.Text = "Equipment Name:"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Arial monospaced for SAP", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label6.Location = New System.Drawing.Point(289, 36)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(477, 38)
        Me.label6.TabIndex = 91
        Me.label6.Text = "Rental Equipment Record"
        '
        'DataGridView2
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial monospaced for SAP", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Check, Me.Campus, Me.EquipmentName, Me.EquipmentID, Me.Quantity, Me.RentalDateTime, Me.ReturnDateTime, Me.RenterName, Me.RenterID, Me.PhoneNumber, Me.Department})
        Me.DataGridView2.Location = New System.Drawing.Point(900, 148)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        DataGridViewCellStyle4.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.RowTemplate.Height = 27
        Me.DataGridView2.Size = New System.Drawing.Size(550, 560)
        Me.DataGridView2.TabIndex = 115
        '
        'Check
        '
        Me.Check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Check.HeaderText = "Check"
        Me.Check.MinimumWidth = 80
        Me.Check.Name = "Check"
        Me.Check.Width = 80
        '
        'Campus
        '
        Me.Campus.DataPropertyName = "Campus"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial monospaced for SAP", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Campus.DefaultCellStyle = DataGridViewCellStyle3
        Me.Campus.HeaderText = "Campus"
        Me.Campus.MinimumWidth = 6
        Me.Campus.Name = "Campus"
        Me.Campus.Width = 125
        '
        'EquipmentName
        '
        Me.EquipmentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EquipmentName.DataPropertyName = "EquipmentName"
        Me.EquipmentName.HeaderText = "Equipment Name"
        Me.EquipmentName.MinimumWidth = 6
        Me.EquipmentName.Name = "EquipmentName"
        Me.EquipmentName.Width = 189
        '
        'EquipmentID
        '
        Me.EquipmentID.DataPropertyName = "EquipmentID"
        Me.EquipmentID.HeaderText = "EquipmentID"
        Me.EquipmentID.MinimumWidth = 6
        Me.EquipmentID.Name = "EquipmentID"
        Me.EquipmentID.Width = 125
        '
        'Quantity
        '
        Me.Quantity.DataPropertyName = "Quantity"
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.MinimumWidth = 6
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Width = 125
        '
        'RentalDateTime
        '
        Me.RentalDateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RentalDateTime.DataPropertyName = "RentalDateTime"
        Me.RentalDateTime.HeaderText = "Rental DateTime"
        Me.RentalDateTime.MinimumWidth = 6
        Me.RentalDateTime.Name = "RentalDateTime"
        Me.RentalDateTime.Width = 199
        '
        'ReturnDateTime
        '
        Me.ReturnDateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ReturnDateTime.DataPropertyName = "ReturnDateTime"
        Me.ReturnDateTime.HeaderText = "Return DateTime"
        Me.ReturnDateTime.MinimumWidth = 6
        Me.ReturnDateTime.Name = "ReturnDateTime"
        Me.ReturnDateTime.Width = 199
        '
        'RenterName
        '
        Me.RenterName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RenterName.DataPropertyName = "name"
        Me.RenterName.HeaderText = "RenterName"
        Me.RenterName.MinimumWidth = 6
        Me.RenterName.Name = "RenterName"
        Me.RenterName.Width = 159
        '
        'RenterID
        '
        Me.RenterID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RenterID.DataPropertyName = "RenterID"
        Me.RenterID.HeaderText = "RenterID"
        Me.RenterID.MinimumWidth = 6
        Me.RenterID.Name = "RenterID"
        Me.RenterID.Width = 135
        '
        'PhoneNumber
        '
        Me.PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PhoneNumber.DataPropertyName = "phone"
        Me.PhoneNumber.HeaderText = "Phone Number"
        Me.PhoneNumber.MinimumWidth = 6
        Me.PhoneNumber.Name = "PhoneNumber"
        Me.PhoneNumber.Width = 167
        '
        'Department
        '
        Me.Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Department.DataPropertyName = "major"
        Me.Department.HeaderText = "Department"
        Me.Department.MinimumWidth = 6
        Me.Department.Name = "Department"
        Me.Department.Width = 159
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Arial monospaced for SAP", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(1069, 724)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(245, 51)
        Me.Button1.TabIndex = 116
        Me.Button1.Text = "Reload"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dateTimePicker2
        '
        Me.dateTimePicker2.CustomFormat = "yyyy-MM-dd HH:MM:ss"
        Me.dateTimePicker2.Font = New System.Drawing.Font("Arial monospaced for SAP", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateTimePicker2.Location = New System.Drawing.Point(559, 420)
        Me.dateTimePicker2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dateTimePicker2.Name = "dateTimePicker2"
        Me.dateTimePicker2.Size = New System.Drawing.Size(266, 30)
        Me.dateTimePicker2.TabIndex = 117
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Font = New System.Drawing.Font("Arial monospaced for SAP", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label15.Location = New System.Drawing.Point(308, 130)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(110, 28)
        Me.label15.TabIndex = 119
        Me.label15.Text = "Campus:"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"蘭潭", "新民", "民雄", "林森"})
        Me.ComboBox2.Location = New System.Drawing.Point(559, 130)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(266, 33)
        Me.ComboBox2.TabIndex = 118
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial monospaced for SAP", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(307, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 28)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "Equipment ID:"
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"羽球拍:112", "羽球:113", "網球:114", "網球拍:115", "籃球:116", "排球:117", "足球:118", "桌球拍:119", "乒乓球:120", "棒球:121", "棒球棒:122", "棒球手套:123"})
        Me.ComboBox4.Location = New System.Drawing.Point(559, 246)
        Me.ComboBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(266, 33)
        Me.ComboBox4.TabIndex = 121
        '
        'ComboBox5
        '
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"羽球拍:112", "羽球:113", "網球:114", "網球拍:115", "籃球:116", "排球:117", "足球:118", "桌球拍:119", "乒乓球:120", "棒球:121", "棒球棒:122", "棒球手套:123"})
        Me.ComboBox5.Location = New System.Drawing.Point(1069, 91)
        Me.ComboBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(266, 33)
        Me.ComboBox5.TabIndex = 122
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'pictureBox10
        '
        Me.pictureBox10.Image = Global._0503.My.Resources.Resources.close
        Me.pictureBox10.Location = New System.Drawing.Point(1444, 12)
        Me.pictureBox10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pictureBox10.Name = "pictureBox10"
        Me.pictureBox10.Size = New System.Drawing.Size(33, 36)
        Me.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox10.TabIndex = 113
        Me.pictureBox10.TabStop = False
        '
        'pictureBox9
        '
        Me.pictureBox9.Image = Global._0503.My.Resources.Resources.icons8_zoom_in_30
        Me.pictureBox9.Location = New System.Drawing.Point(1359, 66)
        Me.pictureBox9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pictureBox9.Name = "pictureBox9"
        Me.pictureBox9.Size = New System.Drawing.Size(51, 51)
        Me.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox9.TabIndex = 112
        Me.pictureBox9.TabStop = False
        '
        'pictureBox8
        '
        Me.pictureBox8.Image = Global._0503.My.Resources.Resources.icons8_trash_32
        Me.pictureBox8.Location = New System.Drawing.Point(900, 724)
        Me.pictureBox8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pictureBox8.Name = "pictureBox8"
        Me.pictureBox8.Size = New System.Drawing.Size(51, 51)
        Me.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox8.TabIndex = 111
        Me.pictureBox8.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Arial monospaced for SAP", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(707, 724)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 51)
        Me.Button2.TabIndex = 123
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Arial monospaced for SAP", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.Location = New System.Drawing.Point(560, 724)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(122, 51)
        Me.Button3.TabIndex = 124
        Me.Button3.Text = "Add"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1491, 800)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label15)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.dateTimePicker2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.comboBox3)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.numericUpDown1)
        Me.Controls.Add(Me.pictureBox10)
        Me.Controls.Add(Me.pictureBox9)
        Me.Controls.Add(Me.pictureBox8)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.dateTimePicker1)
        Me.Controls.Add(Me.comboBox1)
        Me.Controls.Add(Me.label14)
        Me.Controls.Add(Me.label13)
        Me.Controls.Add(Me.label12)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial monospaced for SAP", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents comboBox3 As ComboBox
    Private WithEvents textBox3 As TextBox
    Private WithEvents textBox2 As TextBox
    Private WithEvents numericUpDown1 As NumericUpDown
    Private WithEvents dataGridViewImageColumn1 As DataGridViewImageColumn
    Private WithEvents pictureBox10 As PictureBox
    Private WithEvents pictureBox9 As PictureBox
    Private WithEvents pictureBox8 As PictureBox
    Private WithEvents textBox1 As TextBox
    Private WithEvents panel1 As Panel
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label1 As Label
    Private WithEvents panel2 As Panel
    Private WithEvents label5 As Label
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents pictureBox5 As PictureBox
    Private WithEvents pictureBox4 As PictureBox
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents dateTimePicker1 As DateTimePicker
    Private WithEvents comboBox1 As ComboBox
    Private WithEvents label14 As Label
    Private WithEvents label13 As Label
    Private WithEvents label12 As Label
    Private WithEvents label11 As Label
    Private WithEvents label10 As Label
    Private WithEvents label9 As Label
    Private WithEvents label8 As Label
    Private WithEvents label7 As Label
    Private WithEvents label6 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Button1 As Button
    Private WithEvents dateTimePicker2 As DateTimePicker
    Private WithEvents label15 As Label
    Private WithEvents ComboBox2 As ComboBox
    Private WithEvents Label2 As Label
    Private WithEvents ComboBox4 As ComboBox
    Private WithEvents ComboBox5 As ComboBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Private WithEvents Label16 As Label
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Private WithEvents Label17 As Label
    Friend WithEvents Check As DataGridViewCheckBoxColumn
    Friend WithEvents Campus As DataGridViewTextBoxColumn
    Friend WithEvents EquipmentName As DataGridViewTextBoxColumn
    Friend WithEvents EquipmentID As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents RentalDateTime As DataGridViewTextBoxColumn
    Friend WithEvents ReturnDateTime As DataGridViewTextBoxColumn
    Friend WithEvents RenterName As DataGridViewTextBoxColumn
    Friend WithEvents RenterID As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumber As DataGridViewTextBoxColumn
    Friend WithEvents Department As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
