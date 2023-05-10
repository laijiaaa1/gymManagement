<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label5 = New System.Windows.Forms.Label()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.button1.Font = New System.Drawing.Font("Arial monospaced for SAP", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.SystemColors.Control
        Me.button1.Location = New System.Drawing.Point(777, 560)
        Me.button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(301, 51)
        Me.button1.TabIndex = 22
        Me.button1.Text = "Login"
        Me.button1.UseVisualStyleBackColor = False
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Arial monospaced for SAP", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.label5.Location = New System.Drawing.Point(1008, 462)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(70, 23)
        Me.label5.TabIndex = 21
        Me.label5.Text = "Clear"
        '
        'checkBox1
        '
        Me.checkBox1.AutoSize = True
        Me.checkBox1.Font = New System.Drawing.Font("Arial monospaced for SAP", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.checkBox1.Location = New System.Drawing.Point(777, 462)
        Me.checkBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(188, 27)
        Me.checkBox1.TabIndex = 20
        Me.checkBox1.Text = "Show Password" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.checkBox1.UseVisualStyleBackColor = True
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(777, 402)
        Me.textBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(301, 25)
        Me.textBox2.TabIndex = 19
        Me.textBox2.UseSystemPasswordChar = True
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(777, 320)
        Me.textBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(301, 25)
        Me.textBox1.TabIndex = 18
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Arial monospaced for SAP", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.SystemColors.Control
        Me.label4.Location = New System.Drawing.Point(772, 370)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(118, 23)
        Me.label4.TabIndex = 17
        Me.label4.Text = "Password:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Arial monospaced for SAP", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.SystemColors.Control
        Me.label3.Location = New System.Drawing.Point(772, 289)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(106, 23)
        Me.label3.TabIndex = 16
        Me.label3.Text = "Account:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Arial monospaced for SAP", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.label2.Location = New System.Drawing.Point(796, 206)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(262, 23)
        Me.label2.TabIndex = 15
        Me.label2.Text = "Gym Management System" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Arial monospaced for SAP", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.Control
        Me.label1.Location = New System.Drawing.Point(821, 109)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(210, 69)
        Me.label1.TabIndex = 14
        Me.label1.Text = "Login"
        '
        'pictureBox2
        '
        Me.pictureBox2.Image = Global._0503.My.Resources.Resources.close
        Me.pictureBox2.Location = New System.Drawing.Point(1284, 11)
        Me.pictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(29, 32)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox2.TabIndex = 23
        Me.pictureBox2.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global._0503.My.Resources.Resources.Picture4
        Me.pictureBox1.Location = New System.Drawing.Point(-5, -75)
        Me.pictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(494, 895)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 13
        Me.pictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1325, 768)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.checkBox1)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.pictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents button1 As Button
    Private WithEvents label5 As Label
    Private WithEvents checkBox1 As CheckBox
    Private WithEvents textBox2 As TextBox
    Private WithEvents textBox1 As TextBox
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents pictureBox1 As PictureBox
End Class
