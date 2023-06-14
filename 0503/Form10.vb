Imports MySql.Data.MySqlClient
Public Class Form10
    Dim constring As New MySqlConnection
    Dim conect As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim query As String

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

    Private Sub pictureBox10_Click(sender As Object, e As EventArgs) Handles pictureBox10.Click
        Dim result As DialogResult = MessageBox.Show("是否要關閉視窗？", "關閉視窗", MessageBoxButtons.YesNo)

        ' 如果用戶選擇 Yes，則關閉視窗
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub


    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click
        Dim connection As New MySqlConnection("datasource=xingdou.sytes.net;port=3306 ;database=ggym; username=janet; password=gymmanagementsystem ;convert zero datetime=True")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM inventoryequipment", connection)
        adapter.Fill(table)
        DataGridView2.DataSource = table



    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        ComboBox2.Text = DataGridView2.CurrentRow.Cells(0).Value
        ComboBox3.Text = DataGridView2.CurrentRow.Cells(1).Value
        DomainUpDown6.Text = DataGridView2.CurrentRow.Cells(2).Value
        DomainUpDown5.Text = DataGridView2.CurrentRow.Cells(3).Value
        DomainUpDown4.Text = DataGridView2.CurrentRow.Cells(4).Value
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs)
        Try
            updates("UPDATE inventoryequipment SET EquipmentName='" & ComboBox2.Text & "', EquipmentID='" & ComboBox3.Text & "',AllQuantity='" & DomainUpDown6.Text & "' ,UsingQuantity='" & DomainUpDown5.Text & "' ,AvailableQuantity='" & DomainUpDown4.Text & "' WHERE EquipmentID='" & ComboBox3.Text & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)
        Try
            create("INSERT INTO `inventoryequipment` VALUES ('" & ComboBox2.Text & "' ,'" & ComboBox3.Text & "','" & DomainUpDown6.Text & "' ,'" & DomainUpDown5.Text & "' ,'" & DomainUpDown4.Text & "')")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Try
            delete("DELETE FROM inventoryequipment WHERE EquipmentID='" & ComboBox3.Text & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click
        Dim connection As New MySqlConnection("datasource=xingdou.sytes.net;port=3306 ;database=ggym; username=janet; password=gymmanagementsystem ;convert zero datetime=True")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM inventoryvenue", connection)
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ComboBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
        ComboBox4.Text = DataGridView1.CurrentRow.Cells(1).Value
        DomainUpDown1.Text = DataGridView1.CurrentRow.Cells(2).Value
        DomainUpDown2.Text = DataGridView1.CurrentRow.Cells(3).Value
        DomainUpDown3.Text = DataGridView1.CurrentRow.Cells(4).Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim query As String = "UPDATE inventoryequipment SET UsingQuantity = (SELECT SUM(Quantity) FROM equipment WHERE equipment.EquipmentID = inventoryequipment.EquipmentID), AvailableQuantity = AllQuantity - (SELECT SUM(Quantity) FROM equipment WHERE equipment.EquipmentID = inventoryequipment.EquipmentID ); SELECT * FROM inventoryequipment"

            reload(query, DataGridView2)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim query As String = "UPDATE inventoryvenue SET UsingQuantity = (SELECT SUM(Quantity) FROM venue WHERE venue.VenueID = inventoryvenue.VenueID), AvailableQuantity = AllQuantity - (SELECT SUM(Quantity) FROM venue WHERE venue.VenueID = inventoryvenue.VenueID ); SELECT * FROM inventoryvenue"

            reload(query, DataGridView1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs)
        Try
            updates("UPDATE inventoryvenue SET VenueName='" & ComboBox1.Text & "',VenueID='" & ComboBox4.Text & "' ,AllQuantity='" & DomainUpDown1.Text & "' ,UsingQuantity='" & DomainUpDown2.Text & "' ,AvailableQuantity='" & DomainUpDown3.Text & "' WHERE VenueID='" & ComboBox4.Text & "' ")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs)
        Try
            create("INSERT INTO `inventoryvenue` VALUES ('" & ComboBox1.Text & "' ,'" & ComboBox4.Text & "','" & DomainUpDown1.Text & "' ,'" & DomainUpDown2.Text & "' ,'" & DomainUpDown3.Text & "')")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            delete("DELETE FROM inventoryvenue WHERE VenueID='" & ComboBox4.Text & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click
        constring.ConnectionString = "server=xingdou.sytes.net;port=3306 ;database=ggym; username=janet; password=gymmanagementsystem ;convert zero datetime=True"

        Try
            constring.Open()
            query = "SELECT * FROM inventoryequipment"
            conect = New MySqlCommand(query, constring)
            reader = conect.ExecuteReader

            While reader.Read
                Chart1.Series("Using Count").Points.AddXY(reader.GetString("EquipmentID"), reader.GetUInt32("UsingQuantity"))
                Chart1.Series("Available Count").Points.AddXY(reader.GetString("EquipmentID"), reader.GetUInt32("AvailableQuantity"))

            End While
            constring.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            constring.Dispose()
        End Try
    End Sub

    Private Sub Chart2_Click(sender As Object, e As EventArgs) Handles Chart2.Click
        constring.ConnectionString = "server=xingdou.sytes.net;port=3306  ;database=ggym; username=janet; password=gymmanagementsystem ;convert zero datetime=True"

        Try
            constring.Open()
            query = "SELECT * FROM inventoryvenue"
            conect = New MySqlCommand(query, constring)
            reader = conect.ExecuteReader
            While reader.Read
                Chart2.Series("Using Count").Points.AddXY(reader.GetString("VenueName"), reader.GetUInt32("UsingQuantity"))
                Chart2.Series("Available Count").Points.AddXY(reader.GetString("VenueName"), reader.GetUInt32("AvailableQuantity"))

            End While
            constring.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Form7.Show()
        Hide()

    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Dim Form8 As New Form8()
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        Dim Form8 As New Form8()
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Dim Form9 As New Form9()
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Dim Form9 As New Form9()
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            create("INSERT INTO `inventoryvenue` VALUES ('" & ComboBox1.Text & "' ,'" & ComboBox4.Text & "','" & DomainUpDown1.Text & "' ,'" & DomainUpDown2.Text & "' ,'" & DomainUpDown3.Text & "')")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            updates("UPDATE inventoryvenue SET VenueName='" & ComboBox1.Text & "',VenueID='" & ComboBox4.Text & "' ,AllQuantity='" & DomainUpDown1.Text & "' ,UsingQuantity='" & DomainUpDown2.Text & "' ,AvailableQuantity='" & DomainUpDown3.Text & "' WHERE VenueID='" & ComboBox4.Text & "' ")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            create("INSERT INTO `inventoryequipment` VALUES ('" & ComboBox2.Text & "' ,'" & ComboBox3.Text & "','" & DomainUpDown6.Text & "' ,'" & DomainUpDown5.Text & "' ,'" & DomainUpDown4.Text & "')")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            updates("UPDATE inventoryequipment SET EquipmentName='" & ComboBox2.Text & "', EquipmentID='" & ComboBox3.Text & "',AllQuantity='" & DomainUpDown6.Text & "' ,UsingQuantity='" & DomainUpDown5.Text & "' ,AvailableQuantity='" & DomainUpDown4.Text & "' WHERE EquipmentID='" & ComboBox3.Text & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class