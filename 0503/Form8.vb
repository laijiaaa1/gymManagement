Imports MySql.Data.MySqlClient
Public Class Form8
    Dim constring As New MySqlConnection
    Dim conect As New MySqlCommand
    Private Sub button5_Click(sender As Object, e As EventArgs)
        Try
            create("INSERT INTO `manager` VALUES ('" & textBox5.Text & "' ,'" & textBox6.Text & "' ,'" & textBox7.Text & "' ,'" & textBox8.Text & "')")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub pictureBox10_Click(sender As Object, e As EventArgs) Handles pictureBox10.Click
        Dim result As DialogResult = MessageBox.Show("是否要關閉視窗？", "關閉視窗", MessageBoxButtons.YesNo)

        ' 如果用戶選擇 Yes，則關閉視窗
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub pictureBox2_Click(sender As Object, e As EventArgs)
        Dim Form3 As New Form3()
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New MySqlConnection("datasource=xingdou.sytes.net;port=3306 ;database=ggym; username=janet; password=gymmanagementsystem ;convert zero datetime=True")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM manager", connection)
        '   adapter.Fill(table)
        dataGridView1.DataSource = table
    End Sub

    Private Sub dataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellContentClick
        textBox5.Text = dataGridView1.CurrentRow.Cells(0).Value
        textBox6.Text = dataGridView1.CurrentRow.Cells(1).Value
        textBox7.Text = dataGridView1.CurrentRow.Cells(2).Value
        textBox8.Text = dataGridView1.CurrentRow.Cells(3).Value

    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs)
        Try
            updates("UPDATE manager SET ManagerID='" & textBox5.Text & "',ManagerName='" & textBox6.Text & "' ,PhoneNumber='" & textBox7.Text & "' ,Password='" & textBox8.Text & "' WHERE ManagerID= '" & textBox5.Text & "' ")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs)
        Try
            delete("DELETE FROM manager WHERE ManagerID='" & textBox5.Text & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            reload("SELECT*FROM manager", dataGridView1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub pictureBox9_Click(sender As Object, e As EventArgs) Handles pictureBox9.Click
        Try
            search("SELECT * FROM manager WHERE ManagerID='" & TextBox1.Text & "'")
            For Each row As DataRow In dt.Rows

                If Not row("ManagerID").ToString().Equals(TextBox1.Text) Then
                    row.Delete()
                End If
            Next
            dt.AcceptChanges()
            dataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        Dim Form3 As New Form3()
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click
        Dim Form3 As New Form3()
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Dim Form2 As New Form2()
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
        Dim Form2 As New Form2()
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub pictureBox4_Click(sender As Object, e As EventArgs) Handles pictureBox4.Click
        Dim Form6 As New Form6()
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click
        Dim Form6 As New Form6()
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub pictureBox5_Click(sender As Object, e As EventArgs) Handles pictureBox5.Click
        Dim Form10 As New Form10()
        Form10.Show()
        Me.Hide()
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
        Dim Form10 As New Form10()
        Form10.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Dim Form9 As New Form9()
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim Form9 As New Form9()
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub pictureBox6_Click(sender As Object, e As EventArgs)
        Try
            updates("UPDATE manager SET ManagerID='" & textBox5.Text & "',ManagerName='" & textBox6.Text & "' ,PhoneNumber='" & textBox7.Text & "' ,Password='" & textBox8.Text & "' WHERE ManagerID= '" & textBox5.Text & "' ")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub pictureBox7_Click(sender As Object, e As EventArgs)
        Try
            create("INSERT INTO `manager` VALUES ('" & textBox5.Text & "' ,'" & textBox6.Text & "' ,'" & textBox7.Text & "' ,'" & textBox8.Text & "')")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub pictureBox8_Click(sender As Object, e As EventArgs) Handles pictureBox8.Click
        Try
            delete("DELETE FROM manager WHERE ManagerID='" & textBox5.Text & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            create("INSERT INTO `manager` VALUES ('" & textBox5.Text & "' ,'" & textBox6.Text & "' ,'" & textBox7.Text & "' ,'" & textBox8.Text & "')")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            updates("UPDATE manager SET ManagerID='" & textBox5.Text & "',ManagerName='" & textBox6.Text & "' ,PhoneNumber='" & textBox7.Text & "' ,Password='" & textBox8.Text & "' WHERE ManagerID= '" & textBox5.Text & "' ")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class