Imports MySql.Data.MySqlClient
Public Class Form4
    Dim constring As New MySqlConnection
    Dim conect As New MySqlCommand
    Private Sub pictureBox10_Click(sender As Object, e As EventArgs) Handles pictureBox10.Click
        Dim result As DialogResult = MessageBox.Show("是否要關閉視窗？", "關閉視窗", MessageBoxButtons.YesNo)

        ' 如果用戶選擇 Yes，則關閉視窗
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click
        Dim Form3 As New Form3()
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub label1_Click(sender As Object, e As EventArgs) Handles label1.Click
        Dim Form3 As New Form3()
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub pictureBox2_Click(sender As Object, e As EventArgs) Handles pictureBox2.Click
        Dim Form2 As New Form2()
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub label5_Click(sender As Object, e As EventArgs) Handles label5.Click
        Dim Form2 As New Form2()
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub pictureBox4_Click(sender As Object, e As EventArgs) Handles pictureBox4.Click
        Dim Form6 As New Form6()
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub label3_Click(sender As Object, e As EventArgs) Handles label3.Click
        Dim Form6 As New Form6()
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub pictureBox5_Click(sender As Object, e As EventArgs) Handles pictureBox5.Click
        Dim Form7 As New Form7()
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub label4_Click(sender As Object, e As EventArgs) Handles label4.Click
        Dim Form7 As New Form7()
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub dataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub pictureBox7_Click(sender As Object, e As EventArgs) Handles pictureBox7.Click
        Try
            create("INSERT INTO `equipment` VALUES ('" & comboBox1.Text & "' ,'" & numericUpDown1.Value & "'  , '" & dateTimePicker1.Text & "' , '" & dateTimePicker2.Text & "' , '" & textBox1.Text & "' , '" & textBox2.Text & "' , '" & textBox3.Text & "', '" & comboBox3.Text & "')")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New MySqlConnection("datasource=192.168.63.166;database=ggym; username=janet; password=gymmanagementsystem ;convert zero datetime=True")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM equipment", connection)
        adapter.Fill(table)
        DataGridView2.DataSource = table
    End Sub

    Private Sub comboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox1.SelectedIndexChanged

    End Sub

    Private Sub pictureBox6_Click(sender As Object, e As EventArgs) Handles pictureBox6.Click
        Try
            update1("UPDATE equipment SET comboBox1='" & comboBox1.Text & "' ,numericUpDown1='" & numericUpDown1.Value & "'  ,dateTimePicker1= '" & dateTimePicker1.Text & "' ,dateTimePicker2= '" & dateTimePicker2.Text & "' ,textBox1= '" & textBox1.Text & "' , textBox2= '" & textBox2.Text & "' ,textBox3= '" & textBox3.Text & "',comboBox3='" & comboBox3.Text & "'")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            reload("SELECT*FROM equipment", DataGridView2)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub pictureBox8_Click(sender As Object, e As EventArgs) Handles pictureBox8.Click
        Try
            delete("DELETE FROM equipment WHERE textBox2='" & textBox2.Text & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        comboBox1.Text = DataGridView2.CurrentRow.Cells(0).Value
        numericUpDown1.Value = DataGridView2.CurrentRow.Cells(1).Value
        dateTimePicker1.Text = DataGridView2.CurrentRow.Cells(2).Value
        dateTimePicker2.Text = DataGridView2.CurrentRow.Cells(3).Value
        textBox1.Text = DataGridView2.CurrentRow.Cells(4).Value
        textBox2.Text = DataGridView2.CurrentRow.Cells(5).Value
        textBox3.Text = DataGridView2.CurrentRow.Cells(6).Value
        comboBox3.Text= DataGridView2.CurrentRow.Cells(7).Value


    End Sub

    Private Sub DataGridView2_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView2.SelectionChanged

    End Sub
End Class