﻿Public Class Form1
    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Dim ntabla, i As SByte
        ntabla = txtTabla.Text
        lstTablas.Items.Clear()
        If ntabla <= 12 Then

            For i = 0 To 10
                lstTablas.Items.Add(ntabla.ToString() + "x" + i.ToString() + "=" + (ntabla * i).ToString())
            Next
        Else
            lstTablas.Items.Add("Por favor ingrese solo tablas menores o iguales a 12.")
        End If

    End Sub
End Class
