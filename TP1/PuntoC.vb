Imports System.Windows.Forms.DataVisualization.Charting

Public Class PUNTOC
    Dim n As Integer
    Dim count As Integer
    Dim x As Double

    Dim c1 As Double

    Dim a As Double = 0
    Dim m As Double
    Dim x1 As Double
    Dim var As Boolean
    Private Sub PUNTOC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    End Sub

    Private Function logicaBoton() As Boolean
        If (txt_semilla.Text = "" Or txt_C.Text = "" Or txt_M.Text = "" Or txt_intervalos.Text = "" Or txt_A.Text = "" Or txt_muestras.Text = "") Then
            var = False
        Else
            var = True
        End If
        Return var
    End Function

    Private Sub generarBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles generarBTN.Click
        logicaBoton()
        Dim xCuadradoCalculado As Double = 0
        lst_numeros.Visible = True

        If var = False Then
            MsgBox("Por favor ingrese todos los valores solicitados")
        Else
            generarBTN.Enabled = False
            btnEjemplo.Enabled = False
            n = txt_muestras.Text
            Dim lista(0 To (n - 1)) As Double
            count = 0
            x = txt_semilla.Text
            a = txt_A.Text

            m = txt_M.Text




            For count = 0 To (n - 1)
                c1 = txt_C.Text

                x = (a * x)
                x = x + c1
                x = x Mod m

                lista(count) = x / (m)
                lst_numeros.Items.Add(lista(count))
            Next count
            x1 = x

            Chart1.Series(0).Points.Clear()

            Dim intervalos As Double
            Dim sum As Integer
            Dim k As Integer = txt_intervalos.Text
            Dim med As Double

            intervalos = 1 / k
            med = n / k
            intervalos = Math.Round(intervalos, 3)
            Dim fila As Integer = 0 ''filas de la grilla

            For i As Double = 0 To 0.99 Step intervalos
                sum = 0

                For count = 0 To (n - 1)
                    If i <= lista(count) Then
                        If lista(count) < (i + intervalos) Then
                            sum = sum + 1
                        End If
                    End If
                Next count
                i = Math.Round(i, 3)
                intervalos = Math.Round(intervalos, 3)
                sum = Math.Round(sum, 3)
                med = Math.Round(med, 3)

                Chart1.Series("Observado").Points.AddXY((i + intervalos), sum)
                Chart1.Series("Esperado").Points.AddXY((i + intervalos), med)
                '' calculo de chi - cuadrado
                dtgvChiCuadrado.Rows.Add() ''agregamos una fila por cada ciclo
                dtgvChiCuadrado.Rows((fila)).Cells(0).Value = i.ToString() + " - " + (i + intervalos).ToString ''agregamos el rango del intervalo a la grilla
                dtgvChiCuadrado.Rows((fila)).Cells(1).Value = sum.ToString ''agregamos la frecuencia observada
                dtgvChiCuadrado.Rows((fila)).Cells(2).Value = med.ToString ''agregamos frecuencia esperada

                Dim fdif As Double = Math.Round(sum - med, 3)
                dtgvChiCuadrado.Rows((fila)).Cells(3).Value = fdif.ToString ''agregamos diferencia de frecuencias
                Dim difCuadrado As Double = Math.Round(fdif * fdif, 3)
                dtgvChiCuadrado.Rows((fila)).Cells(4).Value = difCuadrado.ToString ''agregamos diferencia al cuadrado
                Dim xCuadradoI As Double = Math.Round(difCuadrado / med, 3) ''calculo ((fo - fe)^2 )/ fe
                dtgvChiCuadrado.Rows((fila)).Cells(5).Value = xCuadradoI.ToString ''agreagamos xicuadrado

                xCuadradoCalculado += xCuadradoI ''voy realizando sumatoria de ((fo - fe)^2 )/ fe
                fila += 1
            Next
            dtgvChiCuadrado.Rows.Add()
            dtgvChiCuadrado.Rows((fila)).Cells(4).Value = "Xi Cuadrado calculado"
            dtgvChiCuadrado.Rows((fila)).Cells(5).Value = xCuadradoCalculado.ToString ''agregamos el xi cuadrado a la grilla

            Chart1.Series("Observado").ChartType = SeriesChartType.Column
            Chart1.Series("Observado").XValueType = ChartValueType.Double
            Chart1.Series("Observado").YValueType = ChartValueType.Int32
            Chart1.ChartAreas(0).AxisX.Interval = intervalos
            Chart1.Series("Observado").IsVisibleInLegend = True

            lblV.Text = "Los grados de libertad son: " + (k - 1).ToString
            dtgvChiCuadrado.Rows.Add()
            dtgvChiCuadrado.Rows((fila + 1)).Cells(4).Value = "Xi cudrado Tabulado"
            Dim xiTabulado As String = frm_menu.listaChipcuadrada(k - 2).ToString()
            If xiTabulado Is "" Then ''si la posicion del vector no tiene valores, cambia el string xiTabulado
                xiTabulado = "No hay valores para esos grados de libertad"
                dtgvChiCuadrado.Rows((fila + 1)).Cells(5).Value = xiTabulado.ToString
            Else
                dtgvChiCuadrado.Rows((fila + 1)).Cells(5).Value = xiTabulado.ToString
                If Convert.ToDouble(xiTabulado.ToString) > xCuadradoCalculado Then
                    dtgvChiCuadrado.Rows((fila + 1)).Cells(3).Value = "Aceptado"
                    dtgvChiCuadrado.Rows((fila + 1)).Cells(3).Style.BackColor = Color.Green
                Else
                    dtgvChiCuadrado.Rows((fila + 1)).Cells(3).Value = "Rechazado"
                    dtgvChiCuadrado.Rows((fila + 1)).Cells(3).Style.BackColor = Color.Red
                End If
            End If

        End If

    End Sub

    Private Sub txt_muestras_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_muestras.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txt_semilla_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_semilla.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txt_A_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_A.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txt_C_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_C.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txt_M_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_M.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txt_intervalos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_intervalos.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpiar.Click
        Chart1.Series(0).Points.Clear()
        Chart1.Series(1).Points.Clear()
        txt_C.Clear()
        txt_M.Clear()
        txt_intervalos.Clear()
        txt_A.Clear()
        txt_semilla.Clear()
        txt_muestras.Clear()
        dtgvChiCuadrado.Rows.Clear()
        lst_numeros.Items.Clear()
        btnEjemplo.Enabled = True
        generarBTN.Enabled = True
        lblV.Text = "Grados de Libertad"

    End Sub

    Private Sub btnEjemplo_Click(sender As System.Object, e As System.EventArgs) Handles btnEjemplo.Click
        ''seteamos los parametros del problema segun problema echo en clases
        txt_muestras.Text = 100
        txt_semilla.Text = 100
        txt_M.Text = 5000
        txt_C.Text = 43
        txt_A.Text = 17
        txt_intervalos.Text = 10
        lblV.Text = "Los Grados de Libertad son: "


    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub
End Class