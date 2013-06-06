Imports System.Data.SqlClient

Public Class Form_Proveedores

#Region "Load_Unload"

    Public Sub Form_Proveedores_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Int_VentanaProveedores_Proveedores = 0
        Im = 0
    End Sub

    Public Sub Form_Proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PonerUltimoNumero()
        If Im = 1 Then
            tb_Numero.Text = strNumero
            tb_RazonSocial.Text = strRazon
            tb_NombreFantasia.Text = strFantasia
            tb_Domicilio.Text = strDomicilio
            tb_Cp.Text = strCP
            tb_CUIT.Text = strCUIT
            DD_Estado.Text = strEstado
        End If
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        Formulario.ConsultaProveedoresToolStripMenuItem1_Click(Nothing, Nothing)
    End Sub

#End Region

#Region "KeyPress"

    Private Sub Form_Proveedores_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub tb_Numero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Numero.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Chr(8) Then e.KeyChar = String.Empty
    End Sub

#End Region

#Region "Funciones"

    Sub PonerUltimoNumero()
        Dim Valor As Integer
        LimpiarDG(DgD)
        DgD.DataSource = SqlHelper.ExecuteDataset(SQLProvider.ConnectionString, CommandType.Text, "SELECT NUM_PROV FROM PROVEEDORES").Tables(0)
        Valor = DgD.Rows.Count + 1
        tb_Numero.Text = Valor
    End Sub

    Private Sub btn_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Limpiar.Click
        PonerUltimoNumero()
        tb_RazonSocial.Text = ""
        tb_Cp.Text = ""
        tb_CUIT.Text = ""
        tb_Domicilio.Text = ""
        tb_NombreFantasia.Text = ""
    End Sub

#End Region

#Region "ABM"

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        Tbnumero = tb_Numero.Text
        oConsultaProveedores.Eliminar_Proveedor(tb_Numero, DgD)
    End Sub

    Private Sub btn_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Grabar.Click
        If tb_Numero.Text <> "" Then
            Tbnumero = tb_Numero.Text
            Dim Cadena As String = ("Select NUM_PROV from PROVEEDORES where NUM_PROV = " & Val(tb_Numero.Text))
            Dim strSQLAlta As String = "INSERT INTO PROVEEDORES " _
                                        & "(NUM_PROV, RAZON, NOM_FANTASIA, DOMICILIO, CUIT, ESTADO) VALUES " _
                                        & "(" & Val(tb_Numero.Text) & ",'" & Trim(tb_RazonSocial.Text) & "','" & Trim(tb_NombreFantasia.Text) & "','" _
                                        & Trim(tb_Domicilio.Text) & "','" & Trim(tb_CUIT.Text) & "','" & Trim(DD_Estado.Text) & "');"
            Dim strSQLMod As String = "UPDATE PROVEEDORES SET NUM_PROV = " & Val(tb_Numero.Text) & ", RAZON = '" & Trim(tb_RazonSocial.Text) _
                                      & "', NOM_FANTASIA = '" & Trim(tb_NombreFantasia.Text) & "', DOMICILIO = '" & Trim(tb_Domicilio.Text) _
                                      & "', CUIT = '" & Trim(tb_CUIT.Text) & "', ESTADO = '" & Trim(DD_Estado.Text) & "' WHERE NUM_PROV = " _
                                      & Val(tb_Numero.Text)
            LimpiarDG(DgD)
            DgD.DataSource = SqlHelper.ExecuteDataset(SQLProvider.ConnectionString, CommandType.Text, Cadena).Tables(0)
            If DgD.Rows.Count > 0 Then
                Mensaje(4)
                If Msg = vbOK Then SqlHelper.ExecuteNonQuery(SQLProvider.ConnectionString, CommandType.Text, strSQLMod)
            Else
                Mensaje(5)
                If Msg = vbOK Then SqlHelper.ExecuteNonQuery(SQLProvider.ConnectionString, CommandType.Text, strSQLAlta)
            End If
        Else
            Mensaje(3)
        End If
    End Sub

#End Region

End Class