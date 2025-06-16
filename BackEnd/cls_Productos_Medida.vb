Public Class cls_Productos_Medida

    Public Sub Productos_Medida_Lista(ByRef DataTable As Object)
        Dim ta As New BarilocheTableAdapters.Productos_MedidaTableAdapter
        Dim dt As Bariloche.Productos_MedidaDataTable = Nothing
        dt = ta.GetData
        DataTable = dt

    End Sub

End Class
