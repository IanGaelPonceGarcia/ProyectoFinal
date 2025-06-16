Imports System.Data.Common

Public Class cls_PedidosEncabezado

    Public Sub PedidoEncabezado_Altas(ClienteID As Object, Nombre As Object, Contacto As Object, ByRef Errores As Object, ByRef Ret As Object)
        Dim ta As New BarilocheTableAdapters.PedidosEncabezadoTableAdapter
        Dim dt As New Bariloche.PedidosEncabezadoDataTable
        ta.Fill(dt)

        Dim newRow As Bariloche.PedidosEncabezadoRow
        newRow = dt.NewPedidosEncabezadoRow
        newRow("ClienteID") = ClienteID.ToString
        newRow("Nombre") = Nombre.ToString
        newRow("Contacto") = Contacto.ToString
        'Es necesario para obtener el siguiente consecutivo de lo contratio sera -1
        dt.Rows.Add(newRow)
        Dim rowsInserted As Integer = ta.Update(newRow)
        Ret = newRow("PedidosID")
    End Sub

End Class
