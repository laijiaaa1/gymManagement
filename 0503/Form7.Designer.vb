<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.dataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.pictureBox10 = New System.Windows.Forms.PictureBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.label6 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        CType(Me.pictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dataGridViewImageColumn1
        '
        Me.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dataGridViewImageColumn1.HeaderText = ""
        Me.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.dataGridViewImageColumn1.MinimumWidth = 6
        Me.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1"
        '
        'pictureBox10
        '
        Me.pictureBox10.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pictureBox10.Image = Global._0503.My.Resources.Resources.close
        Me.pictureBox10.Location = New System.Drawing.Point(1450, 11)
        Me.pictureBox10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pictureBox10.Name = "pictureBox10"
        Me.pictureBox10.Size = New System.Drawing.Size(29, 32)
        Me.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox10.TabIndex = 108
        Me.pictureBox10.TabStop = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 106)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1491, 694)
        Me.ReportViewer1.TabIndex = 111
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Location = New System.Drawing.Point(762, 106)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
        Me.ReportViewer2.ServerReport.BearerToken = Nothing
        Me.ReportViewer2.Size = New System.Drawing.Size(8, 26)
        Me.ReportViewer2.TabIndex = 112
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panel1.Controls.Add(Me.label6)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1491, 106)
        Me.panel1.TabIndex = 89
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Arial monospaced for SAP", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.SystemColors.Control
        Me.label6.Location = New System.Drawing.Point(36, 37)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(117, 38)
        Me.label6.TabIndex = 128
        Me.label6.Text = "PRINT"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1491, 800)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.pictureBox10)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form7"
        Me.Text = "Form7"
        CType(Me.pictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents pictureBox10 As PictureBox
    Private WithEvents dataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Private WithEvents panel1 As Panel
    Private WithEvents label6 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
