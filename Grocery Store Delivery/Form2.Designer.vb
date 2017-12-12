<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchAnOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentDetialsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateCustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchCustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchCustoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeToolStripMenuItem, Me.OrdersToolStripMenuItem, Me.PaymentToolStripMenuItem, Me.PaymentToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(437, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeDetailsToolStripMenuItem, Me.AddEmployeeToolStripMenuItem, Me.UpdateEmployeeToolStripMenuItem, Me.SearchEmployeeToolStripMenuItem})
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.EmployeeToolStripMenuItem.Text = "Employee"
        '
        'EmployeeDetailsToolStripMenuItem
        '
        Me.EmployeeDetailsToolStripMenuItem.Name = "EmployeeDetailsToolStripMenuItem"
        Me.EmployeeDetailsToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.EmployeeDetailsToolStripMenuItem.Text = "Employee Details"
        '
        'AddEmployeeToolStripMenuItem
        '
        Me.AddEmployeeToolStripMenuItem.Name = "AddEmployeeToolStripMenuItem"
        Me.AddEmployeeToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.AddEmployeeToolStripMenuItem.Text = "Add Employee"
        '
        'UpdateEmployeeToolStripMenuItem
        '
        Me.UpdateEmployeeToolStripMenuItem.Name = "UpdateEmployeeToolStripMenuItem"
        Me.UpdateEmployeeToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.UpdateEmployeeToolStripMenuItem.Text = "Update Employee"
        '
        'OrdersToolStripMenuItem
        '
        Me.OrdersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrderFormToolStripMenuItem, Me.SearchAnOrderToolStripMenuItem})
        Me.OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem"
        Me.OrdersToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.OrdersToolStripMenuItem.Text = "Orders"
        '
        'OrderFormToolStripMenuItem
        '
        Me.OrderFormToolStripMenuItem.Name = "OrderFormToolStripMenuItem"
        Me.OrderFormToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.OrderFormToolStripMenuItem.Text = "Order Form"
        '
        'SearchAnOrderToolStripMenuItem
        '
        Me.SearchAnOrderToolStripMenuItem.Name = "SearchAnOrderToolStripMenuItem"
        Me.SearchAnOrderToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.SearchAnOrderToolStripMenuItem.Text = "Search an order"
        '
        'PaymentToolStripMenuItem
        '
        Me.PaymentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaymentDetialsToolStripMenuItem, Me.UpdateCustomersToolStripMenuItem, Me.SearchCustomersToolStripMenuItem, Me.SearchCustoToolStripMenuItem})
        Me.PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem"
        Me.PaymentToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.PaymentToolStripMenuItem.Text = "Customers"
        '
        'PaymentDetialsToolStripMenuItem
        '
        Me.PaymentDetialsToolStripMenuItem.Name = "PaymentDetialsToolStripMenuItem"
        Me.PaymentDetialsToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.PaymentDetialsToolStripMenuItem.Text = "Customers Details"
        '
        'UpdateCustomersToolStripMenuItem
        '
        Me.UpdateCustomersToolStripMenuItem.Name = "UpdateCustomersToolStripMenuItem"
        Me.UpdateCustomersToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.UpdateCustomersToolStripMenuItem.Text = "Add Customers"
        '
        'SearchCustomersToolStripMenuItem
        '
        Me.SearchCustomersToolStripMenuItem.Name = "SearchCustomersToolStripMenuItem"
        Me.SearchCustomersToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.SearchCustomersToolStripMenuItem.Text = "Update Customers"
        '
        'PaymentToolStripMenuItem1
        '
        Me.PaymentToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaymentDetailsToolStripMenuItem})
        Me.PaymentToolStripMenuItem1.Name = "PaymentToolStripMenuItem1"
        Me.PaymentToolStripMenuItem1.Size = New System.Drawing.Size(66, 20)
        Me.PaymentToolStripMenuItem1.Text = "Payment"
        '
        'PaymentDetailsToolStripMenuItem
        '
        Me.PaymentDetailsToolStripMenuItem.Name = "PaymentDetailsToolStripMenuItem"
        Me.PaymentDetailsToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.PaymentDetailsToolStripMenuItem.Text = "Payment Details"
        '
        'SearchEmployeeToolStripMenuItem
        '
        Me.SearchEmployeeToolStripMenuItem.Name = "SearchEmployeeToolStripMenuItem"
        Me.SearchEmployeeToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.SearchEmployeeToolStripMenuItem.Text = "Search Employee"
        '
        'SearchCustoToolStripMenuItem
        '
        Me.SearchCustoToolStripMenuItem.Name = "SearchCustoToolStripMenuItem"
        Me.SearchCustoToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.SearchCustoToolStripMenuItem.Text = "Search Customers"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(437, 254)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "+"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrderFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchAnOrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentDetialsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateCustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchCustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PaymentDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchCustoToolStripMenuItem As ToolStripMenuItem
End Class
