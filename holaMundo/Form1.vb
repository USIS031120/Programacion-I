Public Class Form1
    Dim objromano = New conversor_romanos

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        lblRespuestaRomano.Text = objromano.convertir(txtnumero.Text)
    End Sub
End Class

Class conversor_romanos
    Dim romanos()() As String = {
        New String() {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"},
        New String() {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"},
        New String() {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"}
        }

    Dim u, d, c, numero As Integer

    Public Function convertir(ByVal num As Integer)
        u = num Mod 10
        c = num \ 100
        numero = num Mod 100
        d = num \ 10
        Return romanos(2)(c) + romanos(1)(d) + romanos(0)(u)
    End Function
End Class