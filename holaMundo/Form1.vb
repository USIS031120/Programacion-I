Public Class Form1
    Dim objEstadistica As New estadisticas
    Private Sub btnMediaAritmetica_Click(sender As Object, e As EventArgs) Handles btnMediaAritmetica.Click
        lblRespuestaMedia.Text = objEstadistica.calcularMedia(txtserie.Text.Split(","))
        lblRespuestaVarianza.Text = objEstadistica.calcularVarianza(txtserie.Text.Split(","))
        lblRespuestaDesvTipica.Text = objEstadistica.calcularDesvTipica(txtserie.Text.Split(","))
    End Sub

    Private Sub grdEstadistica_KeyUp(sender As Object, e As KeyEventArgs) Handles grdEstadistica.KeyUp
        Try
            Dim nFilas = grdEstadistica.Rows.Count - 1,
                totalf1 = 0,
                totalx1xf1 = 0.0,
                totalx2xf1 = 0.0
            Dim fila As New DataGridViewRow
            For i = 0 To nFilas
                fila = grdEstadistica.Rows(i)
                Dim x1 = 0, f1 = 0
                If fila.Cells("x1").Value <> "" Then
                    x1 = Integer.Parse(fila.Cells("x1").Value.ToString())
                End If
                If fila.Cells("f1").Value <> "" Then
                    f1 = Integer.Parse(fila.Cells("f1").Value.ToString())
                End If
                totalf1 += f1
                totalx1xf1 += x1 * f1
                totalx2xf1 += x1 ^ 2 * f1

                fila.Cells("n1").Value = totalf1.ToString()
                fila.Cells("x1xf1").Value = (x1 * f1).ToString()
                fila.Cells("x2xf1").Value = (x1 ^ 2 * f1).ToString()
            Next
            lbltotalf1.Text = totalf1.ToString()
            lblTotalx1xf1.Text = totalx1xf1.ToString()
            lblTotalx2xf1.Text = totalx2xf1.ToString()


            Dim media = Math.Round(totalx1xf1 / totalf1, 2),
                varianza = Math.Round(totalx2xf1 / totalf1 - media ^ 2, 2)
            lblRespuestaMedia.Text = media.ToString()
            lblRespuestaVarianza.Text = varianza.ToString()
        Catch ex As Exception
            'Manejador...
            MessageBox.Show("ERorr")
        End Try

    End Sub
End Class
