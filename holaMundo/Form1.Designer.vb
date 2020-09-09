<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.lblde = New System.Windows.Forms.Label()
        Me.cbotipo = New System.Windows.Forms.ComboBox()
        Me.cbode = New System.Windows.Forms.ComboBox()
        Me.cboa = New System.Windows.Forms.ComboBox()
        Me.lbla = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnconvertir = New System.Windows.Forms.Button()
        Me.lblresultado = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Location = New System.Drawing.Point(234, 48)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(31, 13)
        Me.lbltipo.TabIndex = 0
        Me.lbltipo.Text = "Tipo:"
        '
        'lblde
        '
        Me.lblde.AutoSize = True
        Me.lblde.Location = New System.Drawing.Point(39, 102)
        Me.lblde.Name = "lblde"
        Me.lblde.Size = New System.Drawing.Size(25, 13)
        Me.lblde.TabIndex = 3
        Me.lblde.Text = "DE:"
        '
        'cbotipo
        '
        Me.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotipo.FormattingEnabled = True
        Me.cbotipo.Items.AddRange(New Object() {"Moneda", "Longitud", "Masa", "Almacenamiento", "Tiempo"})
        Me.cbotipo.Location = New System.Drawing.Point(271, 45)
        Me.cbotipo.Name = "cbotipo"
        Me.cbotipo.Size = New System.Drawing.Size(121, 21)
        Me.cbotipo.TabIndex = 4
        '
        'cbode
        '
        Me.cbode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbode.FormattingEnabled = True
        Me.cbode.Location = New System.Drawing.Point(76, 99)
        Me.cbode.Name = "cbode"
        Me.cbode.Size = New System.Drawing.Size(121, 21)
        Me.cbode.TabIndex = 5
        '
        'cboa
        '
        Me.cboa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboa.FormattingEnabled = True
        Me.cboa.Location = New System.Drawing.Point(237, 102)
        Me.cboa.Name = "cboa"
        Me.cboa.Size = New System.Drawing.Size(121, 21)
        Me.cboa.TabIndex = 7
        '
        'lbla
        '
        Me.lbla.AutoSize = True
        Me.lbla.Location = New System.Drawing.Point(214, 105)
        Me.lbla.Name = "lbla"
        Me.lbla.Size = New System.Drawing.Size(17, 13)
        Me.lbla.TabIndex = 6
        Me.lbla.Text = "A:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(378, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Cantidad:"
        '
        'btnconvertir
        '
        Me.btnconvertir.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnconvertir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconvertir.Location = New System.Drawing.Point(76, 148)
        Me.btnconvertir.Name = "btnconvertir"
        Me.btnconvertir.Size = New System.Drawing.Size(143, 44)
        Me.btnconvertir.TabIndex = 10
        Me.btnconvertir.Text = "Convertir"
        Me.btnconvertir.UseVisualStyleBackColor = False
        '
        'lblresultado
        '
        Me.lblresultado.AutoSize = True
        Me.lblresultado.Location = New System.Drawing.Point(378, 167)
        Me.lblresultado.Name = "lblresultado"
        Me.lblresultado.Size = New System.Drawing.Size(67, 13)
        Me.lblresultado.TabIndex = 11
        Me.lblresultado.Text = "Resultado: ?"
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(437, 102)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(125, 20)
        Me.txtcantidad.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 230)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.lblresultado)
        Me.Controls.Add(Me.btnconvertir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboa)
        Me.Controls.Add(Me.lbla)
        Me.Controls.Add(Me.cbode)
        Me.Controls.Add(Me.cbotipo)
        Me.Controls.Add(Me.lblde)
        Me.Controls.Add(Me.lbltipo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Conversor de numeros decimales a Romanos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltipo As Label
    Friend WithEvents lblde As Label
    Friend WithEvents cbotipo As ComboBox
    Friend WithEvents cbode As ComboBox
    Friend WithEvents cboa As ComboBox
    Friend WithEvents lbla As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnconvertir As Button
    Friend WithEvents lblresultado As Label
    Friend WithEvents txtcantidad As TextBox
End Class
