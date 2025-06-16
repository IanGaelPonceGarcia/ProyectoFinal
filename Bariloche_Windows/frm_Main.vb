Public Class frm_Main
    Private Sub AltasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltasToolStripMenuItem.Click
        Dim frm As New frm_Clientes_Altas
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BajasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajasToolStripMenuItem.Click
        Dim frm As New frm_Clientes_Bajas
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ModificacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificacionesToolStripMenuItem.Click
        Dim frm As New frm_Clientes_Cambios
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidosToolStripMenuItem.Click
        Dim frm As New frm_Pedidos
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class