Public Class Formulario

    Private Sub CuentasBancariasFondosFIjosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuentasBancariasFondosFIjosToolStripMenuItem.Click
        If Int_VentanaFondos_CuentasBancarias = 0 Then
            Dim Frm_CuentasBancarias As New Form_CuentasBancarias
            Frm_CuentasBancarias.MdiParent = Me
            Frm_CuentasBancarias.Show()
            Int_VentanaFondos_CuentasBancarias = 1
        Else
            Mensaje(1)
        End If
    End Sub

    Public Sub ProveedoresToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem3.Click
        Dim Frm_Proveedores As New Form_Proveedores
        If Int_VentanaProveedores_Proveedores = 0 Then
            If Im = 0 Then
                Frm_Proveedores.MdiParent = Me
                Frm_Proveedores.Show()
                Int_VentanaProveedores_Proveedores = 1
            Else
                Frm_Proveedores.ShowDialog()
            End If
        Else
            If Im = 0 Then
                Mensaje(1)
            End If
        End If
    End Sub

    Public Sub ConsultaProveedoresToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaProveedoresToolStripMenuItem1.Click
        If Int_VentanaConsultas_ConsultaProveedores = 0 Then
            Dim Frm_ConsultaProveedores As New Form_ConsultaProveedores
            Frm_ConsultaProveedores.MdiParent = Me
            Frm_ConsultaProveedores.Show()
            Int_VentanaConsultas_ConsultaProveedores = 1
        Else
            Mensaje(1)
        End If
    End Sub

End Class
