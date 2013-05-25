Imports System.Data.SqlClient

Public Class Form_Proveedores

    Public Sub Form_Proveedores_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Int_VentanaProveedores_Proveedores = 0
        Im = 0
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        Formulario.ConsultaProveedoresToolStripMenuItem1_Click(Nothing, Nothing)
    End Sub

    Private Sub btn_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Limpiar.Click
        PonerUltimoNumero()
        tb_RazonSocial.Text = ""
        tb_Cp.Text = ""
        tb_CUIT.Text = ""
        tb_Domicilio.Text = ""
        tb_Fecha.Text = ""
        tb_NombreFantasia.Text = ""
        cb_Obligatoria.Checked = False
    End Sub

    Private Sub tb_Fecha_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_Fecha.GotFocus
        MonthCalendar1.Visible = True
    End Sub

    Private Sub tb_Fecha_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_Fecha.LostFocus
        MonthCalendar1.Visible = False
    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        MonthCalendar1.Visible = True
    End Sub

    Private Sub MonthCalendar1_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        tb_Fecha.Text = MonthCalendar1.SelectionRange.Start.ToString
        MonthCalendar1.Visible = True
    End Sub

    Private Sub btn_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Grabar.Click
        If tb_Numero.Text <> "" Then
            Tbnumero = tb_Numero.Text
            Dim strSQL As String = "INSERT INTO PROVEEDORES " _
                                    & "(NUM_PROV, RAZON, NOM_FANTASIA, DOMICILIO, CUIT, ESTADO) VALUES " _
                                    & "(" & Val(tb_Numero.Text) & ",'" & Trim(tb_RazonSocial.Text) & "','" & Trim(tb_NombreFantasia.Text) & "','" & Trim(tb_Domicilio.Text) & "','" & Trim(tb_CUIT.Text) & "','" & Trim(DD_Estado.Text) & "');"
            Dim datSQL As New SqlDataAdapter("Select NUM_PROV from PROVEEDORES where NUM_PROV = " & Val(tb_Numero.Text), SQLProvider.ConnectionString), ds As New DataSet
            datSQL.Fill(ds)
            LimpiarDG(DgD)
            DgD.DataSource = ds.Tables(0)
            If DgD.Rows.Count > 0 Then
                Mensaje(4)
                If Msg = vbOK Then SqlHelper.ExecuteNonQuery(SQLProvider.ConnectionString, CommandType.Text, "UPDATE PROVEEDORES SET NUM_PROV = " & Val(tb_Numero.Text) & ", RAZON = '" & Trim(tb_RazonSocial.Text) & "', NOM_FANTASIA = '" & Trim(tb_NombreFantasia.Text) & "', DOMICILIO = '" & Trim(tb_Domicilio.Text) & "', CUIT = '" & Trim(tb_CUIT.Text) & "', ESTADO = '" & Trim(DD_Estado.Text) & "' WHERE NUM_PROV = " & Val(tb_Numero.Text))
            Else
                Mensaje(5)
                If Msg = vbOK Then SqlHelper.ExecuteNonQuery(SQLProvider.ConnectionString, CommandType.Text, strSQL)
            End If
        Else
            Mensaje(3)
        End If
    End Sub

    Private Sub Form_Proveedores_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Public Sub Form_Proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PonerUltimoNumero()
        If Im = 1 Then
            tb_Numero.Text = strNumero
            tb_RazonSocial.Text = strRazon
            tb_NombreFantasia.Text = strFantasia
            tb_Domicilio.Text = strDomicilio
            tb_CUIT.Text = strCUIT
            DD_Estado.Text = strEstado
        End If
    End Sub

    Sub PonerUltimoNumero()
        Dim Valor As Integer
        Dim strSQL As New SqlDataAdapter("SELECT NUM_PROV FROM PROVEEDORES", SQLProvider.ConnectionString), ds As New DataSet
        strSQL.Fill(ds)
        LimpiarDG(DgD)
        DgD.DataSource = ds.Tables(0)
        Valor = DgD.Rows.Count + 1
        tb_Numero.Text = Valor
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        If tb_Numero.Text <> "" Then
            Tbnumero = tb_Numero.Text
            Dim datSQL As New SqlDataAdapter("Select NUM_PROV from PROVEEDORES where NUM_PROV = " & Val(tb_Numero.Text), SQLProvider.ConnectionString), ds As New DataSet
            datSQL.Fill(ds)
            LimpiarDG(DgD)
            DgD.DataSource = ds.Tables(0)
            If DgD.Rows.Count > 0 Then
                Mensaje(6)
                If Msg = vbOK Then SqlHelper.ExecuteNonQuery(SQLProvider.ConnectionString, CommandType.Text, "Delete From PROVEEDORES Where NUM_PROV = '" & Trim(tb_Numero.Text) & "'")
            End If
        Else
            Mensaje(3)
        End If

    End Sub
End Class