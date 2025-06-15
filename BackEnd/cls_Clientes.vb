Public Class cls_Clientes
    Public Sub Clientes_Altas(ByRef ClienteID As Object, Nombre As Object, Domicilio As Object, Telefono As Object, Whatsapp As Object, Descuento As Object, Iva As Object, RegistroFechaCreado As Object, RegistroFechaModificado As Object, RegistroUsuarioCreado As Object, RegistroUsuarioModificado As Object, ByRef Errores As Object)
        Dim ta As BarilocheTableAdapters.ClientesTableAdapter = Nothing
        ta = New BarilocheTableAdapters.ClientesTableAdapter
        ta.Insert(Nombre.ToString, Domicilio.ToString, Telefono.ToString, Whatsapp.ToString, Descuento.ToString, Iva.ToString, RegistroFechaCreado.ToString, RegistroFechaModificado.ToString, RegistroUsuarioCreado.ToString, RegistroUsuarioModificado.ToString)
        ClienteID = 0
    End Sub

    Public Sub Clientes_Eliminar(ByRef ClienteID As Object)
        Dim ta As BarilocheTableAdapters.ClientesTableAdapter = Nothing
        ta = New BarilocheTableAdapters.ClientesTableAdapter
        ta.Delete_By_ClientesID(ClienteID.ToString)
    End Sub

    Public Sub Clientes_Modificaciones(ClienteID As Object, Nombre As Object, Domicilio As Object, Telefono As Object, Whatsapp As Object, Descuento As Object, Iva As Object, RegistroFechaCreado As Object, RegistroFechaModificado As Object, RegistroUsuarioCreado As Object, RegistroUsuarioModificado As Object, ByRef Errores As Object)
        Dim ta As BarilocheTableAdapters.ClientesTableAdapter = Nothing
        ta = New BarilocheTableAdapters.ClientesTableAdapter
        ta.Update_By_ClientesID(Nombre.ToString, Domicilio.ToString, Telefono.ToString, Whatsapp.ToString, Descuento.ToString, Iva.ToString, RegistroFechaCreado.ToString, RegistroFechaModificado.ToString, RegistroUsuarioCreado.ToString, RegistroUsuarioModificado.ToString, ClienteID.ToString)
    End Sub

    Public Sub Clientes_Buscar(ClienteID As Object, Nombre As Object, Domicilio As Object, Telefono As Object, Whatsapp As Object)
        Dim ta As BarilocheTableAdapters.ClientesTableAdapter = Nothing
        ta = New BarilocheTableAdapters.ClientesTableAdapter
        Dim dt As Bariloche.ClientesDataTable = Nothing
        ta.Fill_By_Buscar(dt, Nombre.ToString, Domicilio.ToString, Telefono.ToString, Whatsapp.ToString, ClienteID.ToString)
    End Sub

End Class
