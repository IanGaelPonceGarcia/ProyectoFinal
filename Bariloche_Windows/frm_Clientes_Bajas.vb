Imports BackEnd

Public Class frm_Clientes_Bajas

    Private Sub LoadTable()
        Dim dt As DataTable = Nothing
        Dim cls As New BackEnd.cls_Clientes
        Dim ClienteID As Object = Nothing
        Dim Errores As Object = Nothing
        cls.Clientes_Lista(dt)
        Me.DataGridView1.DataSource = dt
    End Sub
    Private Sub frm_Clientes_Bajas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows IsNot Nothing Then
            If DataGridView1.SelectedRows.Count = 1 Then
                Dim r As DataGridViewRow = Nothing
                r = DataGridView1.SelectedRows(0)
                Dim c As DataGridViewCellCollection = r.Cells
                Me.txt_ClienteID.Text = c.Item("ClienteID").Value
                Me.txt_Nombre.Text = c.Item("Nombre").Value
                Me.txt_Domicilio.Text = c.Item("Domicilio").Value
                Me.txt_Telefono.Text = c.Item("Telefono").Value
                Me.txt_whatsapp.Text = c.Item("whatsapp").Value
                Me.txt_Descuento.Text = c.Item("DescuentoCliente").Value
                Me.txt_Iva.Text = c.Item("Iva").Value

            End If
        End If


    End Sub

    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        Dim cls As New BackEnd.cls_Clientes
        Dim ClienteID As Object = Me.txt_ClienteID.Text
        Dim Errores As Object = Nothing
        cls.Clientes_Eliminar(ClienteID)
        LoadTable()
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        End
    End Sub


End Class