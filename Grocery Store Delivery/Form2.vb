Public Class Form2
    Private Sub EmployeeDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeDetailsToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub AddEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEmployeeToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub UpdateEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateEmployeeToolStripMenuItem.Click
        Form5.Show()
    End Sub

    Private Sub SearchEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchEmployeeToolStripMenuItem.Click
        Form6.Show()
    End Sub

    Private Sub PaymentDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentDetailsToolStripMenuItem.Click
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub PaymentDetialsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentDetialsToolStripMenuItem.Click
        Me.Hide()
        Form10.Show()
    End Sub

    Private Sub UpdateCustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateCustomersToolStripMenuItem.Click
        Form11.Show()
    End Sub

    Private Sub SearchCustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchCustomersToolStripMenuItem.Click
        Form12.Show()
    End Sub

    Private Sub SearchCustoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchCustoToolStripMenuItem.Click
        Form13.Show()
    End Sub

    Private Sub OrderFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderFormToolStripMenuItem.Click
        Me.Hide()
        Form14.Show()
    End Sub

    Private Sub SearchAnOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchAnOrderToolStripMenuItem.Click
        Form17.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class