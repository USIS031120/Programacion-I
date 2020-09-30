<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.txtEmailCliente = New System.Windows.Forms.TextBox()
        Me.lblEmailCliente = New System.Windows.Forms.Label()
        Me.txtTelefonoCliente = New System.Windows.Forms.TextBox()
        Me.lblTelefonoCliente = New System.Windows.Forms.Label()
        Me.txtDireccionCliente = New System.Windows.Forms.TextBox()
        Me.lblDireccionCliente = New System.Windows.Forms.Label()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        Me.txtCodigoCliente = New System.Windows.Forms.TextBox()
        Me.lblCodigoCliente = New System.Windows.Forms.Label()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.btnSiguienteCliente = New System.Windows.Forms.Button()
        Me.lblRegistrosCliente = New System.Windows.Forms.Label()
        Me.btnAnteriorCliente = New System.Windows.Forms.Button()
        Me.btnPrimeroCliente = New System.Windows.Forms.Button()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.btnEliminarCliente = New System.Windows.Forms.Button()
        Me.btnModificarCliente = New System.Windows.Forms.Button()
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        Me.btnUltimoCliente = New System.Windows.Forms.Button()
        Me.grbDatos.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.grbEdicion.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.txtEmailCliente)
        Me.grbDatos.Controls.Add(Me.lblEmailCliente)
        Me.grbDatos.Controls.Add(Me.txtTelefonoCliente)
        Me.grbDatos.Controls.Add(Me.lblTelefonoCliente)
        Me.grbDatos.Controls.Add(Me.txtDireccionCliente)
        Me.grbDatos.Controls.Add(Me.lblDireccionCliente)
        Me.grbDatos.Controls.Add(Me.txtNombreCliente)
        Me.grbDatos.Controls.Add(Me.lblNombreCliente)
        Me.grbDatos.Controls.Add(Me.txtCodigoCliente)
        Me.grbDatos.Controls.Add(Me.lblCodigoCliente)
        Me.grbDatos.Enabled = False
        Me.grbDatos.Location = New System.Drawing.Point(25, 12)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Size = New System.Drawing.Size(525, 426)
        Me.grbDatos.TabIndex = 0
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos de Clientes"
        '
        'txtEmailCliente
        '
        Me.txtEmailCliente.Location = New System.Drawing.Point(118, 395)
        Me.txtEmailCliente.Name = "txtEmailCliente"
        Me.txtEmailCliente.Size = New System.Drawing.Size(284, 20)
        Me.txtEmailCliente.TabIndex = 9
        '
        'lblEmailCliente
        '
        Me.lblEmailCliente.AutoSize = True
        Me.lblEmailCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailCliente.Location = New System.Drawing.Point(6, 399)
        Me.lblEmailCliente.Name = "lblEmailCliente"
        Me.lblEmailCliente.Size = New System.Drawing.Size(56, 16)
        Me.lblEmailCliente.TabIndex = 8
        Me.lblEmailCliente.Text = "EMAIL:"
        '
        'txtTelefonoCliente
        '
        Me.txtTelefonoCliente.Location = New System.Drawing.Point(118, 326)
        Me.txtTelefonoCliente.Name = "txtTelefonoCliente"
        Me.txtTelefonoCliente.Size = New System.Drawing.Size(120, 20)
        Me.txtTelefonoCliente.TabIndex = 7
        '
        'lblTelefonoCliente
        '
        Me.lblTelefonoCliente.AutoSize = True
        Me.lblTelefonoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoCliente.Location = New System.Drawing.Point(-3, 326)
        Me.lblTelefonoCliente.Name = "lblTelefonoCliente"
        Me.lblTelefonoCliente.Size = New System.Drawing.Size(92, 16)
        Me.lblTelefonoCliente.TabIndex = 6
        Me.lblTelefonoCliente.Text = "TELEFONO:"
        '
        'txtDireccionCliente
        '
        Me.txtDireccionCliente.Location = New System.Drawing.Point(118, 112)
        Me.txtDireccionCliente.Multiline = True
        Me.txtDireccionCliente.Name = "txtDireccionCliente"
        Me.txtDireccionCliente.Size = New System.Drawing.Size(334, 162)
        Me.txtDireccionCliente.TabIndex = 5
        '
        'lblDireccionCliente
        '
        Me.lblDireccionCliente.AutoSize = True
        Me.lblDireccionCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionCliente.Location = New System.Drawing.Point(6, 172)
        Me.lblDireccionCliente.Name = "lblDireccionCliente"
        Me.lblDireccionCliente.Size = New System.Drawing.Size(95, 16)
        Me.lblDireccionCliente.TabIndex = 4
        Me.lblDireccionCliente.Text = "DIRRECION:"
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(118, 60)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(334, 20)
        Me.txtNombreCliente.TabIndex = 3
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCliente.Location = New System.Drawing.Point(6, 64)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(77, 16)
        Me.lblNombreCliente.TabIndex = 2
        Me.lblNombreCliente.Text = "NOMBRE:"
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.Location = New System.Drawing.Point(118, 29)
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoCliente.TabIndex = 1
        '
        'lblCodigoCliente
        '
        Me.lblCodigoCliente.AutoSize = True
        Me.lblCodigoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoCliente.Location = New System.Drawing.Point(6, 29)
        Me.lblCodigoCliente.Name = "lblCodigoCliente"
        Me.lblCodigoCliente.Size = New System.Drawing.Size(70, 16)
        Me.lblCodigoCliente.TabIndex = 0
        Me.lblCodigoCliente.Text = "CODIGO:"
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.btnSiguienteCliente)
        Me.grbNavegacion.Controls.Add(Me.lblRegistrosCliente)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorCliente)
        Me.grbNavegacion.Controls.Add(Me.btnPrimeroCliente)
        Me.grbNavegacion.Location = New System.Drawing.Point(25, 444)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Size = New System.Drawing.Size(268, 74)
        Me.grbNavegacion.TabIndex = 1
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'btnSiguienteCliente
        '
        Me.btnSiguienteCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteCliente.Location = New System.Drawing.Point(171, 34)
        Me.btnSiguienteCliente.Name = "btnSiguienteCliente"
        Me.btnSiguienteCliente.Size = New System.Drawing.Size(47, 35)
        Me.btnSiguienteCliente.TabIndex = 3
        Me.btnSiguienteCliente.Text = ">"
        Me.btnSiguienteCliente.UseVisualStyleBackColor = True
        '
        'lblRegistrosCliente
        '
        Me.lblRegistrosCliente.AutoSize = True
        Me.lblRegistrosCliente.Location = New System.Drawing.Point(118, 44)
        Me.lblRegistrosCliente.Name = "lblRegistrosCliente"
        Me.lblRegistrosCliente.Size = New System.Drawing.Size(36, 13)
        Me.lblRegistrosCliente.TabIndex = 2
        Me.lblRegistrosCliente.Text = "x de n"
        '
        'btnAnteriorCliente
        '
        Me.btnAnteriorCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorCliente.Location = New System.Drawing.Point(65, 33)
        Me.btnAnteriorCliente.Name = "btnAnteriorCliente"
        Me.btnAnteriorCliente.Size = New System.Drawing.Size(47, 35)
        Me.btnAnteriorCliente.TabIndex = 1
        Me.btnAnteriorCliente.Text = "<"
        Me.btnAnteriorCliente.UseVisualStyleBackColor = True
        '
        'btnPrimeroCliente
        '
        Me.btnPrimeroCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroCliente.Location = New System.Drawing.Point(9, 33)
        Me.btnPrimeroCliente.Name = "btnPrimeroCliente"
        Me.btnPrimeroCliente.Size = New System.Drawing.Size(43, 35)
        Me.btnPrimeroCliente.TabIndex = 0
        Me.btnPrimeroCliente.Text = "|<"
        Me.btnPrimeroCliente.UseVisualStyleBackColor = True
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscarCliente)
        Me.grbEdicion.Controls.Add(Me.btnEliminarCliente)
        Me.grbEdicion.Controls.Add(Me.btnModificarCliente)
        Me.grbEdicion.Controls.Add(Me.btnAgregarCliente)
        Me.grbEdicion.Location = New System.Drawing.Point(299, 454)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Size = New System.Drawing.Size(359, 64)
        Me.grbEdicion.TabIndex = 2
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCliente.Location = New System.Drawing.Point(273, 23)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(74, 34)
        Me.btnBuscarCliente.TabIndex = 3
        Me.btnBuscarCliente.Text = "Buscar"
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'btnEliminarCliente
        '
        Me.btnEliminarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarCliente.Location = New System.Drawing.Point(184, 24)
        Me.btnEliminarCliente.Name = "btnEliminarCliente"
        Me.btnEliminarCliente.Size = New System.Drawing.Size(83, 34)
        Me.btnEliminarCliente.TabIndex = 2
        Me.btnEliminarCliente.Text = "Eliminar"
        Me.btnEliminarCliente.UseVisualStyleBackColor = True
        '
        'btnModificarCliente
        '
        Me.btnModificarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarCliente.Location = New System.Drawing.Point(90, 24)
        Me.btnModificarCliente.Name = "btnModificarCliente"
        Me.btnModificarCliente.Size = New System.Drawing.Size(88, 34)
        Me.btnModificarCliente.TabIndex = 1
        Me.btnModificarCliente.Text = "Modificar"
        Me.btnModificarCliente.UseVisualStyleBackColor = True
        '
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCliente.Location = New System.Drawing.Point(7, 24)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(77, 34)
        Me.btnAgregarCliente.TabIndex = 0
        Me.btnAgregarCliente.Text = "Nuevo"
        Me.btnAgregarCliente.UseVisualStyleBackColor = True
        '
        'btnUltimoCliente
        '
        Me.btnUltimoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoCliente.Location = New System.Drawing.Point(249, 478)
        Me.btnUltimoCliente.Name = "btnUltimoCliente"
        Me.btnUltimoCliente.Size = New System.Drawing.Size(47, 35)
        Me.btnUltimoCliente.TabIndex = 4
        Me.btnUltimoCliente.Text = ">|"
        Me.btnUltimoCliente.UseVisualStyleBackColor = True
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 530)
        Me.Controls.Add(Me.btnUltimoCliente)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbDatos)
        Me.Name = "frmClientes"
        Me.Text = "Registro de Clientes"
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbEdicion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbDatos As GroupBox
    Friend WithEvents txtEmailCliente As TextBox
    Friend WithEvents lblEmailCliente As Label
    Friend WithEvents txtTelefonoCliente As TextBox
    Friend WithEvents lblTelefonoCliente As Label
    Friend WithEvents txtDireccionCliente As TextBox
    Friend WithEvents lblDireccionCliente As Label
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents lblNombreCliente As Label
    Friend WithEvents txtCodigoCliente As TextBox
    Friend WithEvents lblCodigoCliente As Label
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistrosCliente As Label
    Friend WithEvents btnAnteriorCliente As Button
    Friend WithEvents btnPrimeroCliente As Button
    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnEliminarCliente As Button
    Friend WithEvents btnModificarCliente As Button
    Friend WithEvents btnAgregarCliente As Button
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents btnSiguienteCliente As Button
    Friend WithEvents btnUltimoCliente As Button
End Class
