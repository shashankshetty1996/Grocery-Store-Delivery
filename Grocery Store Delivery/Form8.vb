Imports System.Data.SqlClient

Public Class Form8
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

        Dim query As String = "insert into payement_methodGrocery values(" & pid & "," & total & ",'" & method & "')"
        Dim sqlcmd As SqlCommand

        Try
            sqlcmd = New SqlCommand(query, con)
            sqlcmd.ExecuteNonQuery()
            MsgBox("Payment details added successfully",, "Please Refresh in Payment details")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class