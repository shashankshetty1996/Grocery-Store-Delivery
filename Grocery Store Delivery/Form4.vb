﻿Imports System.Data.SqlClient

Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("Do you want to close this form", vbYesNo + vbExclamation, "Message Box") = vbYes Then
            Me.Hide()
            'Form2.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Please Enter all the forms", vbExclamation, "Warning")
            Exit Sub
        End If

        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("Employee should be number only", vbExclamation, "Warning")
            Exit Sub
        End If

        If Not IsNumeric(TextBox3.Text) Then
            MsgBox("Mobile Number should be number only", vbExclamation, "Warning")
            Exit Sub
        End If

        Dim eid As Integer = Val(TextBox1.Text)
        Dim ename As String = TextBox2.Text
        Dim mobNo As Decimal = Val(TextBox3.Text)

        Dim query As String = "insert into employeeGrocery values(" & eid & ",'" & ename & "'," & mobNo & ")"

        Dim sqlcmd As SqlCommand

        Try
            sqlcmd = New SqlCommand(query, con)
            sqlcmd.ExecuteNonQuery()
            MsgBox("Employee Successfully Added",, "Message")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class