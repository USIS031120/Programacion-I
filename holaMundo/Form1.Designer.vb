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
        Me.lblcapital = New System.Windows.Forms.Label()
        Me.txtcapital = New System.Windows.Forms.TextBox()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.txtinteres = New System.Windows.Forms.TextBox()
        Me.lnlinteres = New System.Windows.Forms.Label()
        Me.txttiempo = New System.Windows.Forms.TextBox()
        Me.lnltiempo = New System.Windows.Forms.Label()
        Me.lblinteresSimple = New System.Windows.Forms.Label()
        Me.lblinteresCompuesto = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblcapital
        '
        Me.lblcapital.AutoSize = True
        Me.lblcapital.Location = New System.Drawing.Point(20, 40)
        Me.lblcapital.Name = "lblcapital"
        Me.lblcapital.Size = New System.Drawing.Size(42, 13)
        Me.lblcapital.TabIndex = 0
        Me.lblcapital.Text = "Capital:"
        '
        'txtcapital
        '
        Me.txtcapital.Location = New System.Drawing.Point(68, 40)
        Me.txtcapital.Name = "txtcapital"
        Me.txtcapital.Size = New System.Drawing.Size(66, 20)
        Me.txtcapital.TabIndex = 1
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(142, 141)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(129, 48)
        Me.btncalcular.TabIndex = 2
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'txtinteres
        '
        Me.txtinteres.Location = New System.Drawing.Point(211, 40)
        Me.txtinteres.Name = "txtinteres"
        Me.txtinteres.Size = New System.Drawing.Size(60, 20)
        Me.txtinteres.TabIndex = 4
        '
        'lnlinteres
        '
        Me.lnlinteres.AutoSize = True
        Me.lnlinteres.Location = New System.Drawing.Point(152, 43)
        Me.lnlinteres.Name = "lnlinteres"
        Me.lnlinteres.Size = New System.Drawing.Size(53, 13)
        Me.lnlinteres.TabIndex = 3
        Me.lnlinteres.Text = "Intereses:"
        '
        'txttiempo
        '
        Me.txttiempo.Location = New System.Drawing.Point(378, 37)
        Me.txttiempo.Name = "txttiempo"
        Me.txttiempo.Size = New System.Drawing.Size(53, 20)
        Me.txttiempo.TabIndex = 6
        '
        'lnltiempo
        '
        Me.lnltiempo.AutoSize = True
        Me.lnltiempo.Location = New System.Drawing.Point(288, 43)
        Me.lnltiempo.Name = "lnltiempo"
        Me.lnltiempo.Size = New System.Drawing.Size(77, 13)
        Me.lnltiempo.TabIndex = 5
        Me.lnltiempo.Text = "Tiempo (años):"
        '
        'lblinteresSimple
        '
        Me.lblinteresSimple.AutoSize = True
        Me.lblinteresSimple.Location = New System.Drawing.Point(60, 101)
        Me.lblinteresSimple.Name = "lblinteresSimple"
        Me.lblinteresSimple.Size = New System.Drawing.Size(74, 13)
        Me.lblinteresSimple.TabIndex = 7
        Me.lblinteresSimple.Text = "Interes simple:"
        '
        'lblinteresCompuesto
        '
        Me.lblinteresCompuesto.AutoSize = True
        Me.lblinteresCompuesto.Location = New System.Drawing.Point(288, 101)
        Me.lblinteresCompuesto.Name = "lblinteresCompuesto"
        Me.lblinteresCompuesto.Size = New System.Drawing.Size(97, 13)
        Me.lblinteresCompuesto.TabIndex = 8
        Me.lblinteresCompuesto.Text = "Interes compuesto:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 201)
        Me.Controls.Add(Me.lblinteresCompuesto)
        Me.Controls.Add(Me.lblinteresSimple)
        Me.Controls.Add(Me.txttiempo)
        Me.Controls.Add(Me.lnltiempo)
        Me.Controls.Add(Me.txtinteres)
        Me.Controls.Add(Me.lnlinteres)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.txtcapital)
        Me.Controls.Add(Me.lblcapital)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Calculadora Basica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblcapital As Label
    Friend WithEvents txtcapital As TextBox
    Friend WithEvents btncalcular As Button
    Friend WithEvents txtinteres As TextBox
    Friend WithEvents lnlinteres As Label
    Friend WithEvents txttiempo As TextBox
    Friend WithEvents lnltiempo As Label
    Friend WithEvents lblinteresSimple As Label
    Friend WithEvents lblinteresCompuesto As Label
End Class
