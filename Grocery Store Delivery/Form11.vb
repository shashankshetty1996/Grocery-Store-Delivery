Imports System.Data.SqlClient

Public Class Form11
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Please Enter all the Fields", vbExclamation, "Warning")
            Exit Sub
        End If
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("Payment Key Should be number only", vbExclamation, "Warning")
            Exit Sub
        End If
        If Not IsNumeric(TextBox2.Text) Then
            MsgBox("Customer Name should be number only", vbExclamation, "Warning")
            Exit Sub
        End If
        If Not IsNumeric(TextBox4.Text) Then
            MsgBox("Mobile Number should be Number only", vbExclamation, "Warning")
            Exit Sub
        End If

        Dim pid As Integer = Val(TextBox1.Text)
        Dim cid As Integer = Val(TextBox2.Text)
        Dim cname As String = TextBox3.Text
        Dim mobile As Decimal = Val(TextBox4.Text)
        Dim addr As String = TextBox5.Text

        Dim query As String = "insert into customersGrocery values(" & pid & "," & cid & ",'" & cname & "'," & mobile & ",'" & addr & "')"
        Dim sqlcmd As SqlCommand

        Try
            sqlcmd = New SqlCommand(query, con)
            sqlcmd.ExecuteNonQuery()
            MsgBox("Customer Successfully Added",, "Please Refresh in Customers details form")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
End Class