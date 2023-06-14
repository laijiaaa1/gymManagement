Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Public Class Form4
    Dim constring As New MySqlConnection
    Dim conect As New MySqlCommand
    Dim ds As New DataSet()

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
        Dim Form10 As New Form10()
        Form10.Show()
        Me.Hide()
    End Sub

    Private Sub label4_Click(sender As Object, e As EventArgs) Handles label4.Click
        Dim Form10 As New Form10()
        Form10.Show()
        Me.Hide()
    End Sub

    Private Sub pictureBox7_Click(sender As Object, e As EventArgs)
        Try
            create("INSERT INTO equipment(Campus,EquipmentName,EquipmentID,Quantity,RentalDateTime,ReturnDateTime,RenterID) VALUES ('" & ComboBox2.Text & "' ,'" & comboBox1.Text & "' ,'" & ComboBox4.Text & "' ,'" & numericUpDown1.Value & "'  , '" & dateTimePicker1.Text & "' , '" & dateTimePicker2.Text & "' , '" & textBox2.Text & "' ) ; INSERT INTO user(name,phone,major) VALUES ( '" & textBox1.Text & "' ,'" & textBox3.Text & "', '" & comboBox3.Text & "')")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New MySqlConnection("server=xingdou.sytes.net;port=3306  ;database=ggym; username=janet; password=gymmanagementsystem ;convert zero datetime=True")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT Campus,EquipmentName,EquipmentID,Quantity,RentalDateTime,ReturnDateTime,name,RenterID,phone,major FROM (equipment LEFT OUTER JOIN user ON equipment.RenterID=user.id) ", connection)
        '  adapter.Fill(table)
        DataGridView2.DataSource = table
    End Sub


    Private Sub pictureBox6_Click(sender As Object, e As EventArgs)
        Try
            updates("UPDATE equipment SET Campus='" & ComboBox2.Text & "',EquipmentName='" & comboBox1.Text & "' ,EquipmentID='" & ComboBox4.Text & "' ,Quantity='" & numericUpDown1.Value & "'  ,RentalDateTime= '" & dateTimePicker1.Text & "' ,ReturnDateTime= '" & dateTimePicker2.Text & "' , RenterID= '" & textBox2.Text & "'  WHERE EquipmentID= '" & ComboBox4.Text & "'  ")


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            reload("SELECT Campus,EquipmentName,EquipmentID,Quantity,RentalDateTime,ReturnDateTime,name,RenterID,phone,major FROM (equipment LEFT OUTER JOIN user ON equipment.RenterID=user.id) ", DataGridView2)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub pictureBox8_Click(sender As Object, e As EventArgs) Handles pictureBox8.Click
        Try
            delete("DELETE FROM equipment WHERE EquipmentID='" & ComboBox4.Text & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

        Dim column As New DataGridViewCheckBoxColumn()
        DataGridView2.Columns.Add(column)
        For Each row As DataGridViewRow In DataGridView2.Rows
            If CBool(row.Cells("Check").Value) Then

                row.Visible = False
            End If
        Next
        ComboBox2.Text = DataGridView2.CurrentRow.Cells(1).Value
        comboBox1.Text = DataGridView2.CurrentRow.Cells(2).Value
        ComboBox4.Text = DataGridView2.CurrentRow.Cells(3).Value
        numericUpDown1.Value = DataGridView2.CurrentRow.Cells(4).Value
        dateTimePicker1.Text = DataGridView2.CurrentRow.Cells(5).Value
        dateTimePicker2.Text = DataGridView2.CurrentRow.Cells(6).Value
        textBox1.Text = DataGridView2.CurrentRow.Cells(7).Value
        textBox2.Text = DataGridView2.CurrentRow.Cells(8).Value
        textBox3.Text = DataGridView2.CurrentRow.Cells(9).Value
        comboBox3.Text = DataGridView2.CurrentRow.Cells(10).Value


    End Sub

    Private Sub pictureBox9_Click(sender As Object, e As EventArgs) Handles pictureBox9.Click
        Try
            search("SELECT * FROM equipment WHERE EquipmentID='" & ComboBox5.Text & "'")
            For Each row As DataRow In dt.Rows

                If Not row("EquipmentID").ToString().Equals(ComboBox5.Text) Then
                    row.Delete()
                End If
            Next
            dt.AcceptChanges()
            DataGridView2.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim Form8 As New Form8()
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        Dim Form8 As New Form8()
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Dim Form9 As New Form9()
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Dim Form9 As New Form9()
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            updates("UPDATE equipment SET Campus='" & ComboBox2.Text & "',EquipmentName='" & comboBox1.Text & "' ,EquipmentID='" & ComboBox4.Text & "' ,Quantity='" & numericUpDown1.Value & "'  ,RentalDateTime= '" & dateTimePicker1.Text & "' ,ReturnDateTime= '" & dateTimePicker2.Text & "' , RenterID= '" & textBox2.Text & "'  WHERE EquipmentID= '" & ComboBox4.Text & "'  ")


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            create("INSERT INTO equipment(Campus,EquipmentName,EquipmentID,Quantity,RentalDateTime,ReturnDateTime,RenterID) VALUES ('" & ComboBox2.Text & "' ,'" & comboBox1.Text & "' ,'" & ComboBox4.Text & "' ,'" & numericUpDown1.Value & "'  , '" & dateTimePicker1.Text & "' , '" & dateTimePicker2.Text & "' , '" & textBox2.Text & "' ) ; INSERT INTO user(name,phone,major) VALUES ( '" & textBox1.Text & "' ,'" & textBox3.Text & "', '" & comboBox3.Text & "')")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class