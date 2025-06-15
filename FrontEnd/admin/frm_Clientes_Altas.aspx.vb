
Partial Class Default2
    Inherits System.Web.UI.Page


    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim cls As New BackEnd.cls_Clientes
        Dim ClienteID As Object = Nothing
        Dim Errores As Object = Nothing
        '        cls.Clientes_Altas(ClienteID, txt_Nombre.Text, txt_Domicilio.Text, txt_Telefono.Text, Me.txt_whatsapp.Text, txt_Descuento.Text, txt_Iva.Text, Errores)
        cls.Clientes_Altas(ClienteID, "1", "2", "3", "4", 0, 0, Errores)

    End Sub
End Class
