﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cboOperaciones = New System.Windows.Forms.ComboBox()
        Me.optResiduo = New System.Windows.Forms.RadioButton()
        Me.optExponenciacion = New System.Windows.Forms.RadioButton()
        Me.optPorcentaje = New System.Windows.Forms.RadioButton()
        Me.optDividir = New System.Windows.Forms.RadioButton()
        Me.optMultiplicar = New System.Windows.Forms.RadioButton()
        Me.optResta = New System.Windows.Forms.RadioButton()
        Me.optSuma = New System.Windows.Forms.RadioButton()
        Me.lblrespuesta = New System.Windows.Forms.Label()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.lblnum2 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.lblnum1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboOperaciones
        '
        Me.cboOperaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOperaciones.FormattingEnabled = True
        Me.cboOperaciones.Items.AddRange(New Object() {"Seleccione una opcion", "Sumar", "Restar", "Multiplciar", "Dividir"})
        Me.cboOperaciones.Location = New System.Drawing.Point(271, 161)
        Me.cboOperaciones.Name = "cboOperaciones"
        Me.cboOperaciones.Size = New System.Drawing.Size(121, 21)
        Me.cboOperaciones.TabIndex = 27
        '
        'optResiduo
        '
        Me.optResiduo.AutoSize = True
        Me.optResiduo.Location = New System.Drawing.Point(140, 161)
        Me.optResiduo.Name = "optResiduo"
        Me.optResiduo.Size = New System.Drawing.Size(64, 17)
        Me.optResiduo.TabIndex = 26
        Me.optResiduo.Text = "Residuo"
        Me.optResiduo.UseVisualStyleBackColor = True
        '
        'optExponenciacion
        '
        Me.optExponenciacion.AutoSize = True
        Me.optExponenciacion.Location = New System.Drawing.Point(140, 138)
        Me.optExponenciacion.Name = "optExponenciacion"
        Me.optExponenciacion.Size = New System.Drawing.Size(31, 17)
        Me.optExponenciacion.TabIndex = 25
        Me.optExponenciacion.Text = "^"
        Me.optExponenciacion.UseVisualStyleBackColor = True
        '
        'optPorcentaje
        '
        Me.optPorcentaje.AutoSize = True
        Me.optPorcentaje.Location = New System.Drawing.Point(140, 115)
        Me.optPorcentaje.Name = "optPorcentaje"
        Me.optPorcentaje.Size = New System.Drawing.Size(76, 17)
        Me.optPorcentaje.TabIndex = 24
        Me.optPorcentaje.Text = "Porcentaje"
        Me.optPorcentaje.UseVisualStyleBackColor = True
        '
        'optDividir
        '
        Me.optDividir.AutoSize = True
        Me.optDividir.Location = New System.Drawing.Point(139, 92)
        Me.optDividir.Name = "optDividir"
        Me.optDividir.Size = New System.Drawing.Size(30, 17)
        Me.optDividir.TabIndex = 23
        Me.optDividir.TabStop = True
        Me.optDividir.Text = "/"
        Me.optDividir.UseVisualStyleBackColor = True
        '
        'optMultiplicar
        '
        Me.optMultiplicar.AutoSize = True
        Me.optMultiplicar.Location = New System.Drawing.Point(139, 69)
        Me.optMultiplicar.Name = "optMultiplicar"
        Me.optMultiplicar.Size = New System.Drawing.Size(29, 17)
        Me.optMultiplicar.TabIndex = 22
        Me.optMultiplicar.TabStop = True
        Me.optMultiplicar.Text = "*"
        Me.optMultiplicar.UseVisualStyleBackColor = True
        '
        'optResta
        '
        Me.optResta.AutoSize = True
        Me.optResta.Location = New System.Drawing.Point(139, 46)
        Me.optResta.Name = "optResta"
        Me.optResta.Size = New System.Drawing.Size(28, 17)
        Me.optResta.TabIndex = 21
        Me.optResta.TabStop = True
        Me.optResta.Text = "-"
        Me.optResta.UseVisualStyleBackColor = True
        '
        'optSuma
        '
        Me.optSuma.AutoSize = True
        Me.optSuma.Checked = True
        Me.optSuma.Location = New System.Drawing.Point(139, 23)
        Me.optSuma.Name = "optSuma"
        Me.optSuma.Size = New System.Drawing.Size(31, 17)
        Me.optSuma.TabIndex = 20
        Me.optSuma.TabStop = True
        Me.optSuma.Text = "+"
        Me.optSuma.UseVisualStyleBackColor = True
        '
        'lblrespuesta
        '
        Me.lblrespuesta.AutoSize = True
        Me.lblrespuesta.Location = New System.Drawing.Point(280, 50)
        Me.lblrespuesta.Name = "lblrespuesta"
        Me.lblrespuesta.Size = New System.Drawing.Size(70, 13)
        Me.lblrespuesta.TabIndex = 19
        Me.lblrespuesta.Text = "Respuesta: ?"
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(218, 47)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(56, 20)
        Me.txtnum2.TabIndex = 18
        '
        'lblnum2
        '
        Me.lblnum2.AutoSize = True
        Me.lblnum2.Location = New System.Drawing.Point(173, 50)
        Me.lblnum2.Name = "lblnum2"
        Me.lblnum2.Size = New System.Drawing.Size(41, 13)
        Me.lblnum2.TabIndex = 17
        Me.lblnum2.Text = "Num 2:"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(112, 194)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(92, 33)
        Me.btnCalcular.TabIndex = 16
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(63, 47)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(56, 20)
        Me.txtnum1.TabIndex = 15
        '
        'lblnum1
        '
        Me.lblnum1.AutoSize = True
        Me.lblnum1.Location = New System.Drawing.Point(16, 50)
        Me.lblnum1.Name = "lblnum1"
        Me.lblnum1.Size = New System.Drawing.Size(41, 13)
        Me.lblnum1.TabIndex = 14
        Me.lblnum1.Text = "Num 1:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 255)
        Me.Controls.Add(Me.cboOperaciones)
        Me.Controls.Add(Me.optResiduo)
        Me.Controls.Add(Me.optExponenciacion)
        Me.Controls.Add(Me.optPorcentaje)
        Me.Controls.Add(Me.optDividir)
        Me.Controls.Add(Me.optMultiplicar)
        Me.Controls.Add(Me.optResta)
        Me.Controls.Add(Me.optSuma)
        Me.Controls.Add(Me.lblrespuesta)
        Me.Controls.Add(Me.txtnum2)
        Me.Controls.Add(Me.lblnum2)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtnum1)
        Me.Controls.Add(Me.lblnum1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Calculadora Basica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboOperaciones As ComboBox
    Friend WithEvents optResiduo As RadioButton
    Friend WithEvents optExponenciacion As RadioButton
    Friend WithEvents optPorcentaje As RadioButton
    Friend WithEvents optDividir As RadioButton
    Friend WithEvents optMultiplicar As RadioButton
    Friend WithEvents optResta As RadioButton
    Friend WithEvents optSuma As RadioButton
    Friend WithEvents lblrespuesta As Label
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents lblnum2 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents lblnum1 As Label
End Class
