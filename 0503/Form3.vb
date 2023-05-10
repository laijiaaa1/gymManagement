Public Class Form3
    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Dim Form8 As New Form8()
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Dim Form2 As New Form2()
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub pictureBox10_Click(sender As Object, e As EventArgs) Handles pictureBox10.Click
        Dim result As DialogResult = MessageBox.Show("是否要關閉視窗？", "關閉視窗", MessageBoxButtons.YesNo)

        ' 如果用戶選擇 Yes，則關閉視窗
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim Form6 As New Form6()
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Dim Form7 As New Form7()
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim Form1 As New Form1()
        Form1.Show()
        Me.Hide()
    End Sub
End Class