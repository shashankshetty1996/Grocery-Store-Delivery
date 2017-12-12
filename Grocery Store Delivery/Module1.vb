Imports System.Data.SqlClient

Module Module1
    Public con As SqlConnection

    Public Function connect()
        con = New SqlConnection("server=DESKTOP-LFV0TRS;database=grocery;user ID=student;password=student;")

        Try
            con.Open()
            MsgBox("Welcome to grocery store Database system!",, "by Rafeh ONLY")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function
End Module
