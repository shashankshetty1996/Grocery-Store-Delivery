Imports System.Data.SqlClient

Public Class Form9
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Please enter the values", vbExclamation, "Message")
            Exit Sub
        End If
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("Payment ID should be number only", vbExclamation, "Warning")
            Exit Sub
        End If
        If Not IsNumeric(TextBox2.Text) Then
            MsgBox("Total Cost should be number only", vbExclamation, "Warning")
            Exit Sub
        End If

        Dim pid As Integer = Val(TextBox1.Text)
        Dim total As Integer = Val(TextBox2.Text)
        Dim method As String = TextBox3.Text

        Dim query As String = "update payement_methodGrocery set p_total=" & total & ",method='" & method & "' where p_id=" & pid & ""
        Dim sqlcmd As SqlCommand

        Try
            sqlcmd = New SqlCommand(query, con)
            sqlcmd.ExecuteNonQuery()
            MsgBox("Payment details Updated successfully",, "Please Refresh in Payment details")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class