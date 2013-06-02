Imports System.Data.SqlClient

Public Class oConsultaProveedores

#Region "Consultas"

    Shared Sub CargarDD_Codigo(ByVal DD As ComboBox)
        Dim strSQL As New SqlDataAdapter("Select NUM_PROV From PROVEEDORES", SQLProvider.ConnectionString), ds As New DataSet
        strSQL.Fill(ds)
        DD.DataSource = ds.Tables(0)
        DD.DisplayMember = "NUM_PROV"
        DD.ValueMember = "NUM_PROV"
        DD.Text = ""
    End Sub

    Shared Sub CargarDG_ConsultaProveedores(ByVal DG As DataGridView, ByVal Cadena As String)
        LimpiarDG(DG)
        DG.DataSource = SqlHelper.ExecuteDataset(SQLProvider.ConnectionString, CommandType.Text, Cadena).Tables(0)
        ImeC = 1
    End Sub

    Shared Sub MostrarProveedor(ByVal DG As DataGridView)
        If ImeC = 1 Then
            strNumero = DG.CurrentRow.Cells(0).EditedFormattedValue.ToString
            strRazon = DG.CurrentRow.Cells(1).EditedFormattedValue.ToString
            strFantasia = DG.CurrentRow.Cells(2).EditedFormattedValue.ToString
            strDomicilio = DG.CurrentRow.Cells(3).EditedFormattedValue.ToString
            strCUIT = DG.CurrentRow.Cells(4).EditedFormattedValue.ToString
            strEstado = DG.CurrentRow.Cells(6).EditedFormattedValue.ToString
            Im = 1
            Formulario.ProveedoresToolStripMenuItem3_Click(Nothing, Nothing)
        End If
    End Sub

#End Region

#Region "Proveedores"

    Shared Sub Eliminar_Proveedor(ByVal Tnumero As Integer, ByVal DgD As DataGridView)
        If Tnumero <> "" Then
            LimpiarDG(DgD)
            DgD.DataSource = SqlHelper.ExecuteDataset(SQLProvider.ConnectionString, CommandType.Text, ("Select NUM_PROV from PROVEEDORES where NUM_PROV = " & Trim(Tnumero))).Tables(0)
            If DgD.Rows.Count > 0 Then
                Mensaje(6)
                If Msg = vbOK Then SqlHelper.ExecuteNonQuery(SQLProvider.ConnectionString, CommandType.Text, "Delete From PROVEEDORES Where NUM_PROV = '" & Trim(Tnumero) & "'")
            End If
        Else
            Mensaje(3)
        End If
    End Sub

#End Region

End Class
