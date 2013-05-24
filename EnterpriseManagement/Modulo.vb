﻿Module Modulo

    'Proveedores
    Public ImeC As Integer
    Public Im As Integer
    Public strNumero As String
    Public strRazon As String
    Public strFantasia As String
    Public strCUIT As String
    Public strEstado As String
    Public strDomicilio As String
    Public strCP As String

    Public Msg As String
    Public Tbnumero As String
    Public Int_VentanaFondos_Comprobantes As Integer = 0
    Public Int_VentanaFondos_Conceptos As Integer = 0
    Public Int_VentanaFondos_CuentasBancarias As Integer = 0
    Public Int_VentanaProveedores_Proveedores As Integer = 0
    Public Int_VentanaProveedores_ConceptosFacturables As Integer = 0

    Public Int_VentanaConsultas_ConsultaProveedores As Integer = 0


    Public Sub Mensaje(ByVal Id As Integer)
        Select Case Id
            Case Is = 1
                Msg = MsgBox("El formulario que intenta mostrar ya está en pantalla", vbExclamation, "Enterprise Management")
            Case Is = 2
                Msg = MsgBox("Se va a borrar la cuenta especificada ¿Desea Continuar?", vbOKCancel, "Enterprise Management")
            Case Is = 3
                Msg = MsgBox("Debe ingresar un número de Proveedor para grabar o eliminar un registro", vbExclamation, "Enterprise Management")
            Case Is = 4
                Msg = MsgBox("Esta seguro que desea modificar el Registro: " & Tbnumero & " de la tabla PROVEEDORES", vbOKCancel, "Enterprise Management")
            Case Is = 5
                Msg = MsgBox("Esta seguro que desea grabar el nuevo Registro: " & Tbnumero & " de la tabla PROVEEDORES", vbOKCancel, "Enterprise Management")
            Case Is = 6
                Msg = MsgBox("Esta seguro que desea eliminar el Registro: " & Tbnumero & " de la tabla PROVEEDORES", vbOKCancel, "Enterprise Management")
        End Select
    End Sub

    Public Sub LimpiarDG(ByVal DG As DataGridView)
        DG.DataSource = Nothing
        DG.Refresh()
    End Sub

End Module
