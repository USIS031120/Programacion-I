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
        Me.txtserie = New System.Windows.Forms.TextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.btnMediaAritmetica = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRespuestaMedia = New System.Windows.Forms.Label()
        Me.lblRespuestaVarianza = New System.Windows.Forms.Label()
        Me.lblRespuestaDesvTipica = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grdEstadistica = New System.Windows.Forms.DataGridView()
        Me.lbltotalf1 = New System.Windows.Forms.Label()
        Me.lblTotalx1xf1 = New System.Windows.Forms.Label()
        Me.lblTotalx2xf1 = New System.Windows.Forms.Label()
        Me.x1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.f1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.n1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.x1xf1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.x2xf1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grdEstadistica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtserie
        '
        Me.txtserie.Location = New System.Drawing.Point(75, 43)
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(187, 20)
        Me.txtserie.TabIndex = 2
        Me.txtserie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(28, 49)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(34, 13)
        Me.lblNumero.TabIndex = 5
        Me.lblNumero.Text = "Serie:"
        '
        'btnMediaAritmetica
        '
        Me.btnMediaAritmetica.Location = New System.Drawing.Point(75, 176)
        Me.btnMediaAritmetica.Name = "btnMediaAritmetica"
        Me.btnMediaAritmetica.Size = New System.Drawing.Size(187, 48)
        Me.btnMediaAritmetica.TabIndex = 6
        Me.btnMediaAritmetica.Text = "Calculos estadisticos"
        Me.btnMediaAritmetica.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Media artimetica:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Varianza:"
        '
        'lblRespuestaMedia
        '
        Me.lblRespuestaMedia.AutoSize = True
        Me.lblRespuestaMedia.Location = New System.Drawing.Point(165, 80)
        Me.lblRespuestaMedia.Name = "lblRespuestaMedia"
        Me.lblRespuestaMedia.Size = New System.Drawing.Size(13, 13)
        Me.lblRespuestaMedia.TabIndex = 10
        Me.lblRespuestaMedia.Text = "?"
        '
        'lblRespuestaVarianza
        '
        Me.lblRespuestaVarianza.AutoSize = True
        Me.lblRespuestaVarianza.Location = New System.Drawing.Point(165, 111)
        Me.lblRespuestaVarianza.Name = "lblRespuestaVarianza"
        Me.lblRespuestaVarianza.Size = New System.Drawing.Size(13, 13)
        Me.lblRespuestaVarianza.TabIndex = 11
        Me.lblRespuestaVarianza.Text = "?"
        '
        'lblRespuestaDesvTipica
        '
        Me.lblRespuestaDesvTipica.AutoSize = True
        Me.lblRespuestaDesvTipica.Location = New System.Drawing.Point(165, 141)
        Me.lblRespuestaDesvTipica.Name = "lblRespuestaDesvTipica"
        Me.lblRespuestaDesvTipica.Size = New System.Drawing.Size(13, 13)
        Me.lblRespuestaDesvTipica.TabIndex = 13
        Me.lblRespuestaDesvTipica.Text = "?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Desv. Tipica:"
        '
        'grdEstadistica
        '
        Me.grdEstadistica.AllowUserToDeleteRows = False
        Me.grdEstadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdEstadistica.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.x1, Me.f1, Me.n1, Me.x1xf1, Me.x2xf1})
        Me.grdEstadistica.Location = New System.Drawing.Point(305, 28)
        Me.grdEstadistica.Name = "grdEstadistica"
        Me.grdEstadistica.Size = New System.Drawing.Size(423, 345)
        Me.grdEstadistica.TabIndex = 14
        '
        'lbltotalf1
        '
        Me.lbltotalf1.AutoSize = True
        Me.lbltotalf1.Location = New System.Drawing.Point(401, 376)
        Me.lbltotalf1.Name = "lbltotalf1"
        Me.lbltotalf1.Size = New System.Drawing.Size(22, 13)
        Me.lbltotalf1.TabIndex = 15
        Me.lbltotalf1.Text = "0.0"
        '
        'lblTotalx1xf1
        '
        Me.lblTotalx1xf1.AutoSize = True
        Me.lblTotalx1xf1.Location = New System.Drawing.Point(537, 376)
        Me.lblTotalx1xf1.Name = "lblTotalx1xf1"
        Me.lblTotalx1xf1.Size = New System.Drawing.Size(22, 13)
        Me.lblTotalx1xf1.TabIndex = 16
        Me.lblTotalx1xf1.Text = "0.0"
        '
        'lblTotalx2xf1
        '
        Me.lblTotalx2xf1.AutoSize = True
        Me.lblTotalx2xf1.Location = New System.Drawing.Point(658, 376)
        Me.lblTotalx2xf1.Name = "lblTotalx2xf1"
        Me.lblTotalx2xf1.Size = New System.Drawing.Size(22, 13)
        Me.lblTotalx2xf1.TabIndex = 17
        Me.lblTotalx2xf1.Text = "0.0"
        '
        'x1
        '
        Me.x1.HeaderText = "X1"
        Me.x1.Name = "x1"
        '
        'f1
        '
        Me.f1.HeaderText = "F1"
        Me.f1.Name = "f1"
        '
        'n1
        '
        Me.n1.HeaderText = "N1"
        Me.n1.Name = "n1"
        '
        'x1xf1
        '
        Me.x1xf1.HeaderText = "X1 x F1"
        Me.x1xf1.Name = "x1xf1"
        '
        'x2xf1
        '
        Me.x2xf1.HeaderText = "X2 x F1"
        Me.x2xf1.Name = "x2xf1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 400)
        Me.Controls.Add(Me.lblTotalx2xf1)
        Me.Controls.Add(Me.lblTotalx1xf1)
        Me.Controls.Add(Me.lbltotalf1)
        Me.Controls.Add(Me.grdEstadistica)
        Me.Controls.Add(Me.lblRespuestaDesvTipica)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblRespuestaVarianza)
        Me.Controls.Add(Me.lblRespuestaMedia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMediaAritmetica)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.txtserie)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Calculadora Basica"
        CType(Me.grdEstadistica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtserie As TextBox
    Friend WithEvents lblNumero As Label
    Friend WithEvents btnMediaAritmetica As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblRespuestaMedia As Label
    Friend WithEvents lblRespuestaVarianza As Label
    Friend WithEvents lblRespuestaDesvTipica As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents grdEstadistica As DataGridView
    Friend WithEvents lbltotalf1 As Label
    Friend WithEvents lblTotalx1xf1 As Label
    Friend WithEvents lblTotalx2xf1 As Label
    Friend WithEvents x1 As DataGridViewTextBoxColumn
    Friend WithEvents f1 As DataGridViewTextBoxColumn
    Friend WithEvents n1 As DataGridViewTextBoxColumn
    Friend WithEvents x1xf1 As DataGridViewTextBoxColumn
    Friend WithEvents x2xf1 As DataGridViewTextBoxColumn
End Class
