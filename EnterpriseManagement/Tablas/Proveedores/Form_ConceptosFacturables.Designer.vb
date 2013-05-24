<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ConceptosFacturables
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_ConceptosFacturables))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_Codigo = New System.Windows.Forms.TextBox()
        Me.tb_Descripcion = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RB_Exento = New System.Windows.Forms.RadioButton()
        Me.RB_Gravado = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RB_NoGasto = New System.Windows.Forms.RadioButton()
        Me.RB_SiGasto = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.btn_Limpiar = New System.Windows.Forms.Button()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Grabar = New System.Windows.Forms.Button()
        Me.DG_ConceptosFacturables = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DG_ConceptosFacturables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción"
        '
        'tb_Codigo
        '
        Me.tb_Codigo.Location = New System.Drawing.Point(81, 17)
        Me.tb_Codigo.Name = "tb_Codigo"
        Me.tb_Codigo.Size = New System.Drawing.Size(95, 20)
        Me.tb_Codigo.TabIndex = 2
        '
        'tb_Descripcion
        '
        Me.tb_Descripcion.Location = New System.Drawing.Point(81, 45)
        Me.tb_Descripcion.Name = "tb_Descripcion"
        Me.tb_Descripcion.Size = New System.Drawing.Size(300, 20)
        Me.tb_Descripcion.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RB_Exento)
        Me.Panel1.Controls.Add(Me.RB_Gravado)
        Me.Panel1.Location = New System.Drawing.Point(387, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(72, 48)
        Me.Panel1.TabIndex = 4
        '
        'RB_Exento
        '
        Me.RB_Exento.AutoSize = True
        Me.RB_Exento.Location = New System.Drawing.Point(3, 26)
        Me.RB_Exento.Name = "RB_Exento"
        Me.RB_Exento.Size = New System.Drawing.Size(58, 17)
        Me.RB_Exento.TabIndex = 1
        Me.RB_Exento.Text = "Exento"
        Me.RB_Exento.UseVisualStyleBackColor = True
        '
        'RB_Gravado
        '
        Me.RB_Gravado.AutoSize = True
        Me.RB_Gravado.Checked = True
        Me.RB_Gravado.Location = New System.Drawing.Point(3, 3)
        Me.RB_Gravado.Name = "RB_Gravado"
        Me.RB_Gravado.Size = New System.Drawing.Size(66, 17)
        Me.RB_Gravado.TabIndex = 0
        Me.RB_Gravado.TabStop = True
        Me.RB_Gravado.Text = "Gravado"
        Me.RB_Gravado.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RB_NoGasto)
        Me.Panel2.Controls.Add(Me.RB_SiGasto)
        Me.Panel2.Location = New System.Drawing.Point(465, 17)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(86, 48)
        Me.Panel2.TabIndex = 5
        '
        'RB_NoGasto
        '
        Me.RB_NoGasto.AutoSize = True
        Me.RB_NoGasto.Location = New System.Drawing.Point(20, 26)
        Me.RB_NoGasto.Name = "RB_NoGasto"
        Me.RB_NoGasto.Size = New System.Drawing.Size(39, 17)
        Me.RB_NoGasto.TabIndex = 1
        Me.RB_NoGasto.Text = "No"
        Me.RB_NoGasto.UseVisualStyleBackColor = True
        '
        'RB_SiGasto
        '
        Me.RB_SiGasto.AutoSize = True
        Me.RB_SiGasto.Checked = True
        Me.RB_SiGasto.Location = New System.Drawing.Point(20, 3)
        Me.RB_SiGasto.Name = "RB_SiGasto"
        Me.RB_SiGasto.Size = New System.Drawing.Size(34, 17)
        Me.RB_SiGasto.TabIndex = 0
        Me.RB_SiGasto.TabStop = True
        Me.RB_SiGasto.Text = "Si"
        Me.RB_SiGasto.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(479, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tipo Gasto"
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Enabled = False
        Me.btn_Modificar.Location = New System.Drawing.Point(320, 413)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(72, 24)
        Me.btn_Modificar.TabIndex = 11
        Me.btn_Modificar.Text = "Modificar"
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'btn_Limpiar
        '
        Me.btn_Limpiar.Image = CType(resources.GetObject("btn_Limpiar.Image"), System.Drawing.Image)
        Me.btn_Limpiar.Location = New System.Drawing.Point(15, 407)
        Me.btn_Limpiar.Name = "btn_Limpiar"
        Me.btn_Limpiar.Size = New System.Drawing.Size(36, 37)
        Me.btn_Limpiar.TabIndex = 10
        Me.btn_Limpiar.UseVisualStyleBackColor = True
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Enabled = False
        Me.btn_Eliminar.Location = New System.Drawing.Point(398, 413)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(72, 24)
        Me.btn_Eliminar.TabIndex = 9
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'btn_Grabar
        '
        Me.btn_Grabar.Location = New System.Drawing.Point(476, 413)
        Me.btn_Grabar.Name = "btn_Grabar"
        Me.btn_Grabar.Size = New System.Drawing.Size(72, 24)
        Me.btn_Grabar.TabIndex = 8
        Me.btn_Grabar.Text = "Grabar"
        Me.btn_Grabar.UseVisualStyleBackColor = True
        '
        'DG_ConceptosFacturables
        '
        Me.DG_ConceptosFacturables.AllowUserToAddRows = False
        Me.DG_ConceptosFacturables.AllowUserToDeleteRows = False
        Me.DG_ConceptosFacturables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_ConceptosFacturables.Location = New System.Drawing.Point(15, 95)
        Me.DG_ConceptosFacturables.Name = "DG_ConceptosFacturables"
        Me.DG_ConceptosFacturables.ReadOnly = True
        Me.DG_ConceptosFacturables.Size = New System.Drawing.Size(536, 306)
        Me.DG_ConceptosFacturables.TabIndex = 7
        '
        'Form_ConceptosFacturables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 446)
        Me.Controls.Add(Me.btn_Modificar)
        Me.Controls.Add(Me.btn_Limpiar)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Grabar)
        Me.Controls.Add(Me.DG_ConceptosFacturables)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tb_Descripcion)
        Me.Controls.Add(Me.tb_Codigo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_ConceptosFacturables"
        Me.Text = "Conceptos Facturables"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DG_ConceptosFacturables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_Codigo As System.Windows.Forms.TextBox
    Friend WithEvents tb_Descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RB_Exento As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Gravado As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RB_NoGasto As System.Windows.Forms.RadioButton
    Friend WithEvents RB_SiGasto As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents btn_Limpiar As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Grabar As System.Windows.Forms.Button
    Friend WithEvents DG_ConceptosFacturables As System.Windows.Forms.DataGridView
End Class
