Imports MySql.Data.MySqlClient
Public Class Form6
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

    Private Sub pictureBox3_Click(sender As Object, e As EventArgs) Handles pictureBox3.Click
        Dim Form2 As New Form2()
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub label2_Click(sender As Object, e As EventArgs) Handles label2.Click
        Dim Form2 As New Form2()
        Form2.Show()
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



    Private Sub PictureBox11_Click_1(sender As Object, e As EventArgs)
        Try
            create("INSERT INTO `equipmentrepair` VALUES ('" & comboBox4.Text & "' ,'" & comboBox1.Text & "' ,'" & ComboBox3.Text & "' ,'" & TextBox1.Text & "'  , '" & dateTimePicker1.Text & "' , '" & DateTimePicker2.Text & "','" & TextBox4.Text & "')")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellContentClick
        Dim column As New DataGridViewCheckBoxColumn()
        dataGridView1.Columns.Add(column)
        For Each row As DataGridViewRow In dataGridView1.Rows
            If CBool(row.Cells("Check").Value) Then

                row.Visible = False
            End If
        Next
        comboBox4.Text = dataGridView1.CurrentRow.Cells(1).Value
        comboBox1.Text = dataGridView1.CurrentRow.Cells(2).Value
        ComboBox3.Text = dataGridView1.CurrentRow.Cells(3).Value
        TextBox1.Text = dataGridView1.CurrentRow.Cells(4).Value
        dateTimePicker1.Text = dataGridView1.CurrentRow.Cells(5).Value
        DateTimePicker2.Text = dataGridView1.CurrentRow.Cells(6).Value
        TextBox4.Text = dataGridView1.CurrentRow.Cells(7).Value
    End Sub


    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click
        Dim connection As New MySqlConnection("datasource=xingdou.sytes.net;port=3306 ;database=ggym; username=janet; password=gymmanagementsystem ;convert zero datetime=True")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM equipmentrepair", connection)
        adapter.Fill(table)
        dataGridView1.DataSource = table
    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            reload("SELECT*FROM equipmentrepair", dataGridView1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            delete("DELETE FROM equipmentrepair WHERE equipmentID='" & ComboBox3.Text & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox12_Click_1(sender As Object, e As EventArgs)
        Try
            updates("UPDATE equipmentrepair SET Campus='" & comboBox4.Text & "',EquipmentName='" & comboBox1.Text & "' ,EquipmentID='" & ComboBox3.Text & "' ,Problem='" & TextBox1.Text & "'  , ApplyTime= '" & dateTimePicker1.Text & "' ,RepairTime= '" & DateTimePicker2.Text & "' ,RenterID= '" & TextBox4.Text & "'WHERE EquipmentID= '" & ComboBox3.Text & "' ")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click
        Dim connection As New MySqlConnection("datasource=xingdou.sytes.net;port=3306 ;database=ggym; username=janet; password=gymmanagementsystem ;convert zero datetime=True")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM venuerepair", connection)
        adapter.Fill(table)
        dataGridView2.DataSource = table
    End Sub

    Private Sub dataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView2.CellContentClick
        Dim column As New DataGridViewCheckBoxColumn()
        dataGridView2.Columns.Add(column)
        For Each row As DataGridViewRow In dataGridView2.Rows
            If CBool(row.Cells("Check1").Value) Then

                row.Visible = False
            End If
        Next
        ComboBox5.Text = dataGridView2.CurrentRow.Cells(1).Value
        ComboBox7.Text = dataGridView2.CurrentRow.Cells(2).Value
        ComboBox6.Text = dataGridView2.CurrentRow.Cells(3).Value
        TextBox2.Text = dataGridView2.CurrentRow.Cells(4).Value
        DateTimePicker4.Text = dataGridView2.CurrentRow.Cells(5).Value
        DateTimePicker3.Text = dataGridView2.CurrentRow.Cells(6).Value
        TextBox3.Text = dataGridView2.CurrentRow.Cells(7).Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            reload("SELECT*FROM venuerepair", dataGridView2)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub pictureBox8_Click(sender As Object, e As EventArgs) Handles pictureBox8.Click
        Try
            delete("DELETE FROM venuerepair WHERE VenueID='" & ComboBox6.Text & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub pictureBox7_Click(sender As Object, e As EventArgs)
        Try
            create("INSERT INTO `venuerepair` VALUES ('" & ComboBox5.Text & "' ,'" & ComboBox7.Text & "' ,'" & ComboBox6.Text & "' ,'" & TextBox2.Text & "'  , '" & DateTimePicker4.Text & "' , '" & DateTimePicker3.Text & "','" & TextBox3.Text & "')")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub pictureBox6_Click(sender As Object, e As EventArgs)
        Try
            updates("UPDATE venuerepair SET Campus='" & ComboBox5.Text & "',VenueName='" & ComboBox7.Text & "' ,VenueID='" & ComboBox6.Text & "' ,Problem='" & TextBox2.Text & "'  , ApplyTime= '" & DateTimePicker4.Text & "' ,RepairTime= '" & DateTimePicker3.Text & "',RenterID='" & TextBox3.Text & "' WHERE VenueID= '" & ComboBox6.Text & "' ")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub pictureBox9_Click(sender As Object, e As EventArgs) Handles pictureBox9.Click
        Try
            search("SELECT * FROM equipmentrepair WHERE EquipmentID='" & ComboBox2.Text & "'")
            For Each row As DataRow In dt.Rows

                If Not row("EquipmentID").ToString().Equals(ComboBox2.Text) Then
                    row.Delete()
                End If
            Next
            dt.AcceptChanges()
            dataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Try
            search("SELECT * FROM venuerepair WHERE VenueID='" & ComboBox8.Text & "'")
            For Each row As DataRow In dt.Rows

                If Not row("VenueID").ToString().Equals(ComboBox8.Text) Then
                    row.Delete()
                End If
            Next
            dt.AcceptChanges()
            dataGridView2.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        Dim Form8 As New Form8()
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Dim Form9 As New Form9()
        Form9.Show()
        Me.Hide()
    End Sub



    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Dim Form8 As New Form8()
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Dim Form9 As New Form9()
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            create("INSERT INTO `venuerepair` VALUES ('" & ComboBox5.Text & "' ,'" & ComboBox7.Text & "' ,'" & ComboBox6.Text & "' ,'" & TextBox2.Text & "'  , '" & DateTimePicker4.Text & "' , '" & DateTimePicker3.Text & "','" & TextBox3.Text & "')")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            updates("UPDATE venuerepair SET Campus='" & ComboBox5.Text & "',VenueName='" & ComboBox7.Text & "' ,VenueID='" & ComboBox6.Text & "' ,Problem='" & TextBox2.Text & "'  , ApplyTime= '" & DateTimePicker4.Text & "' ,RepairTime= '" & DateTimePicker3.Text & "',RenterID='" & TextBox3.Text & "' WHERE VenueID= '" & ComboBox6.Text & "' ")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            create("INSERT INTO `equipmentrepair` VALUES ('" & comboBox4.Text & "' ,'" & comboBox1.Text & "' ,'" & ComboBox3.Text & "' ,'" & TextBox1.Text & "'  , '" & dateTimePicker1.Text & "' , '" & DateTimePicker2.Text & "','" & TextBox4.Text & "')")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            updates("UPDATE equipmentrepair SET Campus='" & comboBox4.Text & "',EquipmentName='" & comboBox1.Text & "' ,EquipmentID='" & ComboBox3.Text & "' ,Problem='" & TextBox1.Text & "'  , ApplyTime= '" & dateTimePicker1.Text & "' ,RepairTime= '" & DateTimePicker2.Text & "' ,RenterID= '" & TextBox4.Text & "'WHERE EquipmentID= '" & ComboBox3.Text & "' ")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class