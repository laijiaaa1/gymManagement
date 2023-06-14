Imports MySql.Data.MySqlClient
Public Class Module1
    Dim conect As New MySqlConnection("server=xingdou.sytes.net;port=3306 ; database=ggym; username=janet; password=gymmanagementsystem")
    Public Sub New()

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Public Function open() As MySqlConnection
        Try
            conect.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return conect

    End Function
    Public Function close() As MySqlConnection
        Try
            conect.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return conect

    End Function
End Class

