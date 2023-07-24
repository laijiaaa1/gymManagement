Imports MySql.Data.MySqlClient
Public Class Form9
    Dim constring As New MySqlConnection
    Dim conect As New MySqlCommand
    Dim reader As MySqlDataReader

    Dim connection As New MySqlConnection("datasource=xingdou.sytes.net;port=3306 ;database=ggym; username=janet; password=gymmanagementsystem ;convert zero datetime=True")

    Private Sub pictureBox10_Click(sender As Object, e As EventArgs) Handles pictureBox10.Click
        Dim result As DialogResult = MessageBox.Show("回到主畫面？", "關閉此頁面", MessageBoxButtons.YesNo)

        ' 如果用戶選擇 Yes，則關閉視窗
        If result = DialogResult.Yes Then
            Form3.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim Form3 As New Form3()
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT Campus,EquipmentName,EquipmentID,Quantity,RentalDateTime,ReturnDateTime,name,RenterID,phone,major FROM (equipment LEFT OUTER JOIN user ON equipment.RenterID=user.id)", connection)
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub
    Private Sub pictureBox9_Click_1(sender As Object, e As EventArgs) Handles pictureBox9.Click
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT Campus,EquipmentName,EquipmentID,Quantity,RentalDateTime,ReturnDateTime,name,RenterID,phone,major FROM (equipment LEFT OUTER JOIN user ON equipment.RenterID=user.id) WHERE RentalDateTime >= @D1 AND RentalDateTime < DATE_ADD(@D2, INTERVAL 1 DAY)", connection)

        command.Parameters.Add("@D1", MySqlDbType.Date).Value = DateTimePicker1.Value
        command.Parameters.Add("@D2", MySqlDbType.Date).Value = DateTimePicker2.Value

        Dim adapter As New MySqlDataAdapter(command)
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub



    Private Sub DateTimePicker6_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker6.ValueChanged

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT Campus,VenueName,VenueID,Quantity,RentalDateTime,ReturnDateTime,name,RenterID,phone,major FROM (venue LEFT OUTER JOIN user ON venue.RenterID=user.id)", connection)
        adapter.Fill(table)
        DataGridView2.DataSource = table
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT Campus,VenueName,VenueID,Quantity,RentalDateTime,ReturnDateTime,name,RenterID,phone,major FROM (venue LEFT OUTER JOIN user ON venue.RenterID=user.id)  WHERE RentalDateTime >= @D3 AND RentalDateTime < DATE_ADD(@D4, INTERVAL 1 DAY)", connection)

        command.Parameters.Add("@D3", MySqlDbType.Date).Value = DateTimePicker6.Value
        command.Parameters.Add("@D4", MySqlDbType.Date).Value = DateTimePicker5.Value

        Dim adapter As New MySqlDataAdapter(command)
        adapter.Fill(table)
        DataGridView2.DataSource = table
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM equipmentrepair", connection)
        adapter.Fill(table)
        DataGridView3.DataSource = table
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT * FROM equipmentrepair WHERE ApplyTime >= @D5 AND ApplyTime < DATE_ADD(@D6, INTERVAL 1 DAY)", connection)

        command.Parameters.Add("@D5", MySqlDbType.Date).Value = DateTimePicker4.Value
        command.Parameters.Add("@D6", MySqlDbType.Date).Value = DateTimePicker3.Value

        Dim adapter As New MySqlDataAdapter(command)
        adapter.Fill(table)
        DataGridView3.DataSource = table
    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM venuerepair", connection)
        adapter.Fill(table)
        DataGridView4.DataSource = table
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT * FROM venuerepair WHERE ApplyTime >= @D7 AND ApplyTime < DATE_ADD(@D8, INTERVAL 1 DAY)", connection)

        command.Parameters.Add("@D7", MySqlDbType.Date).Value = DateTimePicker8.Value
        command.Parameters.Add("@D8", MySqlDbType.Date).Value = DateTimePicker7.Value

        Dim adapter As New MySqlDataAdapter(command)
        adapter.Fill(table)
        DataGridView4.DataSource = table
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DateTimePicker8_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker8.ValueChanged

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
        Dim Form7 As New Form7()
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class