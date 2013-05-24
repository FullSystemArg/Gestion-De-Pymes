Imports System.Data.SqlClient

Public Class oConsultaProveedores

    Shared Sub CargarDD_Codigo(ByVal DD As ComboBox)
        Dim strSQL As New SqlDataAdapter("Select NUM_PROV From PROVEEDORES", SQLProvider.ConnectionString), ds As New DataSet
        strSQL.Fill(ds)
        DD.DataSource = ds.Tables(0)
        DD.DisplayMember = "NUM_PROV"
        DD.ValueMember = "NUM_PROV"
        DD.Text = ""
    End Sub

End Class
