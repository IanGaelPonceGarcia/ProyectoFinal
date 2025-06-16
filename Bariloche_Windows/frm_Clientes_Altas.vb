Public Class frm_Clientes_Altas


    Private Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click
        Dim cls As New BackEnd.cls_Clientes
        Dim ClienteID As Object = Nothing
        Dim Errores As Object = Nothing
        cls.Clientes_Altas(ClienteID, txt_Nombre.Text, txt_Domicilio.Text, txt_Telefono.Text, Me.txt_whatsapp.Text, txt_Descuento.Text, txt_Iva.Text, Errores)


    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        End
    End Sub
End Class
