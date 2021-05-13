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
            Dim cantidadIntervalosReales As Double = 0
            Dim numAleatorio As Double
            Dim random As New Random()
            Dim intervalos As Double
            Dim medidaIntervalos As Double
            Dim tamañoIntervaloAcumulado As Double
            Dim filasAcumuladas As Double = 0
            Dim desdeInt As Double = 0
            Dim n As Integer = Ntxt.Text
            Dim lista(0 To (n - 1)) As Double
            Dim k As Integer = Ktxt.Text ''numero de intervalos equiprobables entre 0 y 1
            Dim tamañoIntervalo As Double
            Dim grados_libertad As Double
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

            medidaIntervalos = n / k ''MEDIDA DE LOS INTERVALOS'' = frecuencia esperada

            tamañoIntervalo = 1 / k

            Dim fila As Double = 0
            intervalos = Math.Round(intervalos, 3)
            ''ESTABLECE EL VALOR REDONDEADO DE LOS INTERVALOS EN 3 DIGITOS''


            Dim potencia As Double = 0
            Dim resta As Double = 0
            Dim division As Double = 0
            Dim mediaUniforme = 0.5

            Dim varianzaUniforme = Math.Pow(1, 2) / 12

            '' lleno el vector de fo 
            '' For principal, recorre cada fila por cada intervalo
            Dim i As Double
            For i = 1 To k Step 1
                Dim hastaInt = desdeInt + tamañoIntervalo + tamañoIntervaloAcumulado
                Dim fo = 0
                Dim fe = 0

                Dim marcaClase = (hastaInt + desdeInt) / 2

                For j As Double = 0 To n - 1 Step 1
                    '' Si el valor se encuentra entre los limites
                    '' no incluye el limite superior
                    If lista(j) < hastaInt And lista(j) >= desdeInt Then
                        fo += 1
                    End If
                Next

                '' Si la frecuencia observada es menor a 5,
                '' se suma con otro intervalo
                If fo < 5 Then
                    filasAcumuladas += 1
                    tamañoIntervaloAcumulado += tamañoIntervalo
                Else

                    ''Dim funcionDensidad = 1 / (1 - 0)

                    fe = (Math.Round((Convert.ToDouble(tamañoIntervalo + tamañoIntervaloAcumulado)), 4)) * n

                    resta = fo - fe

                    potencia = Math.Round(Convert.ToDouble(Math.Pow(Convert.ToDouble(resta), 2)), 4)

                    division = Math.Round((potencia / fe), 4)

                    ''dt.Rows.Add(cantidadIntervalosReales + 1, desdeInt, hastaInt, marcaClase, fo, fe, resta, potencia, division)

                    ''agregamos una fila por cada ciclo
                    dtgvChiCuadrado.Rows.Add()

                    ''agregamos el rango del intervalo a la grilla
                    dtgvChiCuadrado.Rows(cantidadIntervalosReales).Cells(0).Value = desdeInt.ToString() + " - " + hastaInt.ToString()

                    ''agregamos la frecuencia observada
                    dtgvChiCuadrado.Rows(cantidadIntervalosReales).Cells(1).Value = fo.ToString()

                    ''agregamos frecuencia esperada
                    dtgvChiCuadrado.Rows(cantidadIntervalosReales).Cells(2).Value = fe.ToString()

                    ''graficamos el valor observado en el intervalo i
                    Chart1.Series("Observado").Points.AddXY(marcaClase, fo)

                    '' y graficamos el valor del esperado en el intervalo i
                    Chart1.Series("Esperado").Points.AddXY(marcaClase, fe)

                    Dim diferencia As Double = fo - fe
                    diferencia = Math.Round(diferencia, 4)

                    ''agregamos diferencia de frecuencias
                    dtgvChiCuadrado.Rows(cantidadIntervalosReales).Cells(3).Value = diferencia.ToString

                    Dim difCuadrado As Double = diferencia * diferencia
                    difCuadrado = Math.Round(difCuadrado, 4)

                    ''agregamos diferencia al cuadrado
                    dtgvChiCuadrado.Rows(cantidadIntervalosReales).Cells(4).Value = difCuadrado.ToString

                    ''calculo ((fo - fe)^2 )/ fe
                    Dim xCuadradoI As Double = difCuadrado / fe

                    xCuadradoI = Math.Round(xCuadradoI, 4)
                    ''agreagamos xicuadrado
                    dtgvChiCuadrado.Rows(cantidadIntervalosReales).Cells(5).Value = xCuadradoI.ToString

                    ''voy realizando sumatoria de ((fo - fe)^2 )/ fe
                    xCuadradoCalculado += xCuadradoI

                    desdeInt += (tamañoIntervalo + tamañoIntervaloAcumulado)

                    filasAcumuladas = 0
                    tamañoIntervaloAcumulado = 0
                    cantidadIntervalosReales += 1

                    grados_libertad = (Convert.ToDouble(cantidadIntervalosReales) - 1)

                End If

            Next

            dtgvChiCuadrado.Rows.Add()
            dtgvChiCuadrado.Rows(cantidadIntervalosReales).Cells(4).Value = "Xi Cuadrado Calculado"

            ''agregamos el xi cuadrado a la grilla
            dtgvChiCuadrado.Rows(cantidadIntervalosReales).Cells(5).Value = xCuadradoCalculado.ToString

            '' Grafico de frecuencias
            Chart1.Series("Observado").ChartType = SeriesChartType.Column
            Chart1.Series("Observado").XValueType = ChartValueType.Double
            Chart1.Series("Observado").YValueType = ChartValueType.Int32

            Chart1.ChartAreas(0).AxisX.Interval = intervalos

            Chart1.Series("Observado").IsVisibleInLegend = True

            lblV.Text = "Grados de libertad: " + grados_libertad.ToString

            dtgvChiCuadrado.Rows.Add()

            dtgvChiCuadrado.Rows((cantidadIntervalosReales + 1)).Cells(4).Value = "Xi Cudrado Tabulado"
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
        BTNActualizarXi.Enabled=False
    End Sub

    Private Sub ActualizarXi_Click(sender As Object, e As EventArgs) Handles BTNActualizarXi.Click

        dtgvChiCuadrado.Rows(dtgvChiCuadrado.Rows.Count - 2).Cells(5).Value = XiTab.Text

        Dim chiTabulado As Double

        Dim chiCalculado As Double

        chiTabulado = Double.Parse(dtgvChiCuadrado.Rows(dtgvChiCuadrado.Rows.Count - 2).Cells(5).Value)

        chiCalculado = Double.Parse(dtgvChiCuadrado.Rows(dtgvChiCuadrado.Rows.Count - 3).Cells(5).Value)

        If (chiTabulado > chiCalculado) Then
            dtgvChiCuadrado.Rows(dtgvChiCuadrado.Rows.Count - 2).Cells(3).Value = "No Rechazado"
            dtgvChiCuadrado.Rows(dtgvChiCuadrado.Rows.Count - 2).Cells(3).Style.BackColor = Color.Green
        Else
            dtgvChiCuadrado.Rows(dtgvChiCuadrado.Rows.Count - 2).Cells(3).Value = "Rechazado"
            dtgvChiCuadrado.Rows(dtgvChiCuadrado.Rows.Count - 2).Cells(3).Style.BackColor = Color.Red
        End If


    End Sub

    Private Sub XiTab_TextChanged(sender As Object, e As EventArgs) Handles XiTab.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class