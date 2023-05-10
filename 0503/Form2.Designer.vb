<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.panel1.SuspendLayout()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Arial monospaced for SAP", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.Control
        Me.label1.Location = New System.Drawing.Point(440, 64)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(497, 38)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Rental Management System"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Arial monospaced for SAP", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.SystemColors.Control
        Me.label2.Location = New System.Drawing.Point(675, 61)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(58, 23)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Home"
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panel1.Controls.Add(Me.pictureBox3)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel1.Location = New System.Drawing.Point(0, 667)
        Me.panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1325, 101)
        Me.panel1.TabIndex = 21
        '
        'pictureBox3
        '
        Me.pictureBox3.Image = Global._0503.My.Resources.Resources._23
        Me.pictureBox3.Location = New System.Drawing.Point(651, 8)
        Me.pictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(100, 50)
        Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox3.TabIndex = 3
        Me.pictureBox3.TabStop = False
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label4.Font = New System.Drawing.Font("Arial monospaced for SAP", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.SystemColors.Control
        Me.label4.Location = New System.Drawing.Point(898, 381)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(238, 30)
        Me.label4.TabIndex = 19
        Me.label4.Text = "Equipment Rental"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label3.Font = New System.Drawing.Font("Arial monospaced for SAP", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.SystemColors.Control
        Me.label3.Location = New System.Drawing.Point(226, 369)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(182, 30)
        Me.label3.TabIndex = 18
        Me.label3.Text = "Venue Rental"
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panel2.Controls.Add(Me.PictureBox5)
        Me.panel2.Controls.Add(Me.label1)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(1325, 160)
        Me.panel2.TabIndex = 22
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global._0503.My.Resources.Resources.close
        Me.PictureBox5.Location = New System.Drawing.Point(1284, 11)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(29, 32)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 24
        Me.PictureBox5.TabStop = False
        '
        'pictureBox4
        '
        Me.pictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pictureBox4.Location = New System.Drawing.Point(1258, 12)
        Me.pictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pictureBox4.Name = "pictureBox4"
        Me.pictureBox4.Size = New System.Drawing.Size(29, 32)
        Me.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox4.TabIndex = 20
        Me.pictureBox4.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pictureBox1.Image = Global._0503.My.Resources.Resources.Picture２
        Me.pictureBox1.Location = New System.Drawing.Point(-41, 104)
        Me.pictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(743, 567)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 16
        Me.pictureBox1.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pictureBox2.Image = Global._0503.My.Resources.Resources.Picture3
        Me.pictureBox2.Location = New System.Drawing.Point(651, 151)
        Me.pictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(766, 517)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox2.TabIndex = 17
        Me.pictureBox2.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1325, 768)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.pictureBox4)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.pictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label1 As Label
    Private WithEvents label2 As Label
    Private WithEvents panel1 As Panel
    Private WithEvents pictureBox3 As PictureBox
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents panel2 As Panel
    Private WithEvents pictureBox4 As PictureBox
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents PictureBox5 As PictureBox
End Class
