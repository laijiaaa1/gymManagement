Public Class Form5
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
End Class