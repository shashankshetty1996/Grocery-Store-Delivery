Imports System.Data.SqlClient

Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Are you sure you want to close?", vbExclamation + vbYesNo, "Do you Want to close") = vbYes Then
            Me.Close()
            Exit Sub
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim uid As String
        Dim psd As String

        If TextBox1.Text = "" Then
            uid = InputBox("Please Enter Your User Id Here", "User Id Missing")
            TextBox1.Text = uid
        End If
        If TextBox2.Text = "" Then
            If MsgBox("Password is missing", vbExclamation + vbYesNoCancel, "Warning") = vbNo Then
                Me.Close()
                Exit Sub
            End If
        End If

        uid = TextBox1.Text
        psd = TextBox2.Text

        Dim validlogin As String = "select UserPassword from loginGrocery where UserId='" & uid & "'"

        Dim sqlcmd As SqlCommand
        Try
            sqlcmd = New SqlCommand(validlogin, con)
            Dim str As String = sqlcmd.ExecuteScalar()
            If str = psd Then
                Me.Hide()
                Form2.Show()
            Else
                MsgBox("Invalid User Id and Password please try again", vbExclamation, "Invalid Login")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connect()
    End Sub
End Class
