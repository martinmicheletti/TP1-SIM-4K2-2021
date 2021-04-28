Imports System.Windows.Forms.DataVisualization.Charting

Public Class PuntoB
    Dim tieneDatos As Boolean

    Private Sub PUNTOB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Chart1.Series(0).Points.Clear()
    End Sub

    Private Sub graficarBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles graficarBTN.Click
        '' Valido que haya datos en el form
        logicaValidacion()

        '' Si no ingreso los datos, que solo muestre un mensaje

        If tieneDatos = False Then
            MsgBox("Por favor ingrese todos los valores solicitados")
        Else
            graficarBTN.Enabled = False
            XiTab.Enabled = True
            BTNActualizarXi.Enabled = True

            '' Inicializo las variables

            Dim numAleatorio As Double
            Dim random As New Random()
            Dim intervalos As Double
            Dim n As Integer = Ntxt.Text
            Dim lista(0 To (n - 1)) As Double
            Dim count As Integer = 0
            Dim sum As Integer
            Dim k As Integer = Ktxt.Text ''numero de intervalos equiprobables entre 0 y 1
            Dim med As Double
            Dim xCuadradoTabulado As Double = 0 ''variable que asumira el rol de xi cuadrado tabulado
            Dim xCuadradoCalculado As Double = 0 ''variable que asumira el rol de xi cuadrado para ser comparado con la tabla

            '' Generamos la lista de numeros aleatorios

            For num As Decimal = 0 To (Ntxt.Text - 1) ''iteramos la cantidad de n-1 elegidas por el usuario
                numAleatorio = Rnd() ''asignamos numero random al eje y
                lst_numeros.Items.Add(Math.Round(numAleatorio, 4)) ''lo agregamos a la lista q se muestra en pantalla
                'Round(yvalue, 3)

                lista(num) = numAleatorio ''lo agregamos a la lista para el lbl

            Next

            intervalos = 1 / k ''probabilidad de cada intevalo
            med = n / k ''MEDIDA DE LOS INTERVALOS'' = frecuencia esperada

            Dim fila As Double = 0
            intervalos = Math.Round(intervalos, 3)
            ''ESTABLECE EL VALOR REDONDEADO DE LOS INTERVALOS EN 3 DIGITOS''

            For i As Double = 0 To (0.99) Step intervalos ''recorremos los intervalos saltando de forma entera, pero el intervalo es decimal.
                ''de esta forma buscamos los numeros en la lista que pertenecen a cada intervalo para sumarlos a la muestra
                sum = 0 ''contador de frecuencia , que sera al final el ciclo la frecuencia observada de dicho valor
                For count = 0 To (n - 1) ''iteramos desde 0 hasta la cantidad de muestras solicitadas
                    If i <= lista(count) Then ''si el numero pseudo-aleaotrio es mayor que el limite inferior del intervalo 
                        If lista(count) < (i + intervalos) Then ''y menor que el limite superior del intervalo
                            sum = sum + 1 ''incremento de la frecuencia de aparicion en dicho intervalo
                        End If
                    End If
                Next count

                i = Math.Round(i, 3)
                med = Math.Round(med, 3)
                Chart1.Series("Observado").Points.AddXY((i + intervalos), sum) ''graficamos el valor observado en el intervalo i
                Chart1.Series("Esperado").Points.AddXY((i + intervalos), med) '' y graficamos el valor del esperado en el intervalo i

                '' Calculo de Chi Cuadrado

                dtgvChiCuadrado.Rows.Add() ''agregamos una fila por cada ciclo
                dtgvChiCuadrado.Rows((fila)).Cells(0).Value = i.ToString() + " - " + (i + intervalos).ToString ''agregamos el rango del intervalo a la grilla
                dtgvChiCuadrado.Rows((fila)).Cells(1).Value = sum.ToString ''agregamos la frecuencia observada
                dtgvChiCuadrado.Rows((fila)).Cells(2).Value = med.ToString ''agregamos frecuencia esperada

                Dim fdif As Double = sum - med
                fdif = Math.Round(fdif, 3)
                dtgvChiCuadrado.Rows((fila)).Cells(3).Value = fdif.ToString ''agregamos diferencia de frecuencias
                Dim difCuadrado As Double = fdif * fdif
                difCuadrado = Math.Round(difCuadrado, 3)
                dtgvChiCuadrado.Rows((fila)).Cells(4).Value = difCuadrado.ToString ''agregamos diferencia al cuadrado
                Dim xCuadradoI As Double = difCuadrado / med ''calculo ((fo - fe)^2 )/ fe
                xCuadradoI = Math.Round(xCuadradoI, 3)
                dtgvChiCuadrado.Rows((fila)).Cells(5).Value = xCuadradoI.ToString ''agreagamos xicuadrado

                xCuadradoCalculado += xCuadradoI ''voy realizando sumatoria de ((fo - fe)^2 )/ fe
                fila += 1
            Next
            dtgvChiCuadrado.Rows.Add()
            dtgvChiCuadrado.Rows((fila)).Cells(4).Value = "Xi Cuadrado Calculado"
            dtgvChiCuadrado.Rows((fila)).Cells(5).Value = xCuadradoCalculado.ToString ''agregamos el xi cuadrado a la grilla

            '' Grafico de frecuencias

            Chart1.Series("Observado").ChartType = SeriesChartType.Column
            Chart1.Series("Observado").XValueType = ChartValueType.Double
            Chart1.Series("Observado").YValueType = ChartValueType.Int32
            Chart1.ChartAreas(0).AxisX.Interval = intervalos
            Chart1.Series("Observado").IsVisibleInLegend = True

            lblV.Text = "Grados de libertad: " + (k - 1).ToString
            dtgvChiCuadrado.Rows.Add()
            dtgvChiCuadrado.Rows((fila + 1)).Cells(4).Value = "Xi Cudrado Tabulado"
        End If

    End Sub
    Private Function logicaValidacion() As Boolean
        If (Ntxt.Text = "" Or Ktxt.Text = "") Then
            tieneDatos = False
        Else
            tieneDatos = True
        End If
        Return tieneDatos
    End Function

    Private Sub Ntxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Ntxt.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            MsgBox("Por favor ingrese un numero")
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub Ktxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Ktxt.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            MsgBox("Por favor ingrese un numero")
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpiar.Click
        Chart1.Series(0).Points.Clear()
        Chart1.Series(1).Points.Clear()
        Ntxt.Text = ""
        Ktxt.Text = ""
        lst_numeros.Items.Clear()
        lst_numeros.Show()
        dtgvChiCuadrado.Rows.Clear()
        lblV.Text = ""
        graficarBTN.Enabled = True
        XiTab.Enabled = False
        XiTab.Text = 0
    End Sub

    Private Sub ActualizarXi_Click(sender As Object, e As EventArgs) Handles BTNActualizarXi.Click

        dtgvChiCuadrado.Rows(dtgvChiCuadrado.Rows.Count - 2).Cells(5).Value = XiTab.Text

        If (dtgvChiCuadrado.Rows(dtgvChiCuadrado.Rows.Count - 2).Cells(5).Value >= dtgvChiCuadrado.Rows(dtgvChiCuadrado.Rows.Count - 3).Cells(5).Value) Then
            dtgvChiCuadrado.Rows(dtgvChiCuadrado.Rows.Count - 2).Cells(3).Value = "No Rechazado"
            dtgvChiCuadrado.Rows(dtgvChiCuadrado.Rows.Count - 2).Cells(3).Style.BackColor = Color.Green
        Else
            dtgvChiCuadrado.Rows(dtgvChiCuadrado.Rows.Count - 2).Cells(3).Value = "Rechazado"
            dtgvChiCuadrado.Rows(dtgvChiCuadrado.Rows.Count - 2).Cells(3).Style.BackColor = Color.Red
        End If
    End Sub
End Class