Imports BackEnd

Public Class frm_Pedidos
    Private dt_PedidosEncabeado As Object
    Private dt_PedidosDetalle As Object
    Private PedidosID As Object
    Private ClienteID As Object
    Private Nombre As Object
    Private Contacto As Object



    Private Sub Load_Clientes()
        Dim dt As DataTable = Nothing
        Dim cls_clientes As New cls_Clientes
        Dim Errores As Object = Nothing
        cls_clientes.Clientes_Lista(dt)
        Me.cmb_Clientes.DataSource = dt
        Me.cmb_Clientes.Tag = dt
        Me.cmb_Clientes.DisplayMember = "Nombre"
        Me.cmb_Clientes.ValueMember = "ClienteID"
    End Sub

    Private Sub Load_Productos()
        Dim dt As DataTable = Nothing
        Dim cls As New BackEnd.cls_Productos_Medida
        Dim ClienteID As Object = Nothing
        Dim Errores As Object = Nothing
        cls.Productos_Medida_Lista(dt)
        Me.DataGridView_Productos.DataSource = dt
    End Sub

    Private Sub frm_Pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Clientes()
        Load_Productos()
        PedidosID = Nothing
        ClienteID = Nothing
        Nombre = Nothing
        Contacto = Nothing
    End Sub

    Private Sub cmb_Clientes_LostFocus(sender As Object, e As EventArgs) Handles cmb_Clientes.LostFocus
        Me.cmb_Clientes.Height = 24
    End Sub

    Private Sub cmb_Clientes_GotFocus(sender As Object, e As EventArgs) Handles cmb_Clientes.GotFocus
        Me.cmb_Clientes.Height = 240
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        'Revisa si existe encabezado
        If PedidosID Is Nothing Then
            Dim cls As New cls_PedidosEncabezado
            Dim Errores As Object = Nothing
            Dim Ret As Object = Nothing
            cls.PedidoEncabezado_Altas(0, cmb_Clientes.SelectedText.ToString, cmb_Clientes.SelectedValue.ToString, Errores, Ret)
            PedidosID = Ret
        End If



        If DataGridView_Productos.SelectedRows IsNot Nothing Then
            If DataGridView_Productos.SelectedRows.Count = 1 Then
                Dim r As DataGridViewRow = Nothing

                r = DataGridView_Productos.SelectedRows(0)
                Dim c As DataGridViewCellCollection = r.Cells

                'Me.txt_ClienteID.Text = c.Item("ClienteID").Value
                'Me.txt_Nombre.Text = c.Item("Nombre").Value
                'Me.txt_Domicilio.Text = c.Item("Domicilio").Value
                'Me.txt_Telefono.Text = c.Item("Telefono").Value
                'Me.txt_whatsapp.Text = c.Item("whatsapp").Value
                'Me.txt_Descuento.Text = c.Item("DescuentoCliente").Value
                'Me.txt_Iva.Text = c.Item("Iva").Value

            End If
        End If
    End Sub

    Private Sub btn_CrearPedido_Click(sender As Object, e As EventArgs) Handles btn_CrearPedido.Click

    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        End
    End Sub
End Class