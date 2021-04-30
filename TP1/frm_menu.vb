Public Class frm_menu
    Public listaChipcuadrada() As String = {"3,84", "5,99", "7,81", "9,49", "11,14", "12,6", "14,1", "15,5", "16,9", "18,3", "19,7", "21,0", "22,4", "23,7", "25,0", "26.3", "26,3",
                             "27,6", "28,9", "30,1", "31,4", "32,7", "33.9", "35,2", "36,4", "37,7", "38,9", "40,1", "41,3", "42,6", "43,8", "44,98", "46,19", "47,39", "48,60", "49,80", "51", "52,19", "53,38", "54,57", "55,8",
                             "", "", "", "", "", "", "", "", "", "67,5", "", "", "", "", "", "", "", "", "", "79,1", "", "", "", "", "", "", "", "", "", "90,5", "", "", "", "", "", "",
                             "", "", "", "101,9", "", "", "", "", "", "", "", "", "", "113,1", "", "", "", "", "", "", "", "", "", "124,3"}
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PUNTO_A.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PuntoB.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PUNTOC.Show()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ''Label3.Text = "Integrantes: Aresu Barella, Barella, Bruna, Loza, Micheletti, Soruco"

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
