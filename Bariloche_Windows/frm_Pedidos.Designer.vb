<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Pedidos
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
        Me.cmb_Clientes = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_CrearPedido = New System.Windows.Forms.Button()
        Me.DataGridView_Productos = New System.Windows.Forms.DataGridView()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.DataGridView_PedidoDetalle = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txt_Descuentos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_DescuentoCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        CType(Me.DataGridView_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_PedidoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_Clientes
        '
        Me.cmb_Clientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_Clientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_Clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmb_Clientes.FormattingEnabled = True
        Me.cmb_Clientes.Location = New System.Drawing.Point(97, 21)
        Me.cmb_Clientes.Name = "cmb_Clientes"
        Me.cmb_Clientes.Size = New System.Drawing.Size(362, 26)
        Me.cmb_Clientes.Sorted = True
        Me.cmb_Clientes.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cliente"
        '
        'btn_CrearPedido
        '
        Me.btn_CrearPedido.Location = New System.Drawing.Point(12, 504)
        Me.btn_CrearPedido.Name = "btn_CrearPedido"
        Me.btn_CrearPedido.Size = New System.Drawing.Size(111, 26)
        Me.btn_CrearPedido.TabIndex = 7
        Me.btn_CrearPedido.Text = "Crear Pedido"
        Me.btn_CrearPedido.UseVisualStyleBackColor = True
        '
        'DataGridView_Productos
        '
        Me.DataGridView_Productos.AllowUserToAddRows = False
        Me.DataGridView_Productos.AllowUserToDeleteRows = False
        Me.DataGridView_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Productos.Location = New System.Drawing.Point(12, 53)
        Me.DataGridView_Productos.MultiSelect = False
        Me.DataGridView_Productos.Name = "DataGridView_Productos"
        Me.DataGridView_Productos.ReadOnly = True
        Me.DataGridView_Productos.RowHeadersWidth = 51
        Me.DataGridView_Productos.RowTemplate.Height = 24
        Me.DataGridView_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Productos.Size = New System.Drawing.Size(1066, 140)
        Me.DataGridView_Productos.TabIndex = 8
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(17, 199)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar.TabIndex = 9
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'DataGridView_PedidoDetalle
        '
        Me.DataGridView_PedidoDetalle.AllowUserToAddRows = False
        Me.DataGridView_PedidoDetalle.AllowUserToDeleteRows = False
        Me.DataGridView_PedidoDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_PedidoDetalle.Location = New System.Drawing.Point(12, 228)
        Me.DataGridView_PedidoDetalle.MultiSelect = False
        Me.DataGridView_PedidoDetalle.Name = "DataGridView_PedidoDetalle"
        Me.DataGridView_PedidoDetalle.ReadOnly = True
        Me.DataGridView_PedidoDetalle.RowHeadersWidth = 51
        Me.DataGridView_PedidoDetalle.RowTemplate.Height = 24
        Me.DataGridView_PedidoDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_PedidoDetalle.Size = New System.Drawing.Size(1066, 140)
        Me.DataGridView_PedidoDetalle.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 381)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "SubTotal"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(113, 378)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 12
        '
        'txt_Descuentos
        '
        Me.txt_Descuentos.Location = New System.Drawing.Point(113, 406)
        Me.txt_Descuentos.Name = "txt_Descuentos"
        Me.txt_Descuentos.ReadOnly = True
        Me.txt_Descuentos.Size = New System.Drawing.Size(100, 22)
        Me.txt_Descuentos.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 409)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Descuentos"
        '
        'txt_DescuentoCliente
        '
        Me.txt_DescuentoCliente.Location = New System.Drawing.Point(750, 25)
        Me.txt_DescuentoCliente.Name = "txt_DescuentoCliente"
        Me.txt_DescuentoCliente.ReadOnly = True
        Me.txt_DescuentoCliente.Size = New System.Drawing.Size(100, 22)
        Me.txt_DescuentoCliente.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(627, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Descuento Cliente"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(113, 434)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 437)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "IVA"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(113, 462)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 465)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 20)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Total"
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(248, 505)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(111, 26)
        Me.btn_Cancelar.TabIndex = 21
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'frm_Pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1090, 543)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_DescuentoCliente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_Descuentos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView_PedidoDetalle)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.DataGridView_Productos)
        Me.Controls.Add(Me.btn_CrearPedido)
        Me.Controls.Add(Me.cmb_Clientes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_Pedidos"
        Me.Text = "Pedidos"
        CType(Me.DataGridView_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_PedidoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_Clientes As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_CrearPedido As Button
    Friend WithEvents DataGridView_Productos As DataGridView
    Friend WithEvents btn_agregar As Button
    Friend WithEvents DataGridView_PedidoDetalle As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txt_Descuentos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_DescuentoCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_Cancelar As Button
End Class
