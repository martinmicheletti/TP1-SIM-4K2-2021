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
        Dim medidaIntervalos As Double
        Dim tamañoIntervalo As Double
        Dim intervalos As Double
        Dim desdeInt As Double
        Dim tamañoIntervaloAcumulado As Double
        Dim filasAcumuladas As Double
        Dim cantidadIntervalosReales As Double
        Dim grados_libertad As Double

        lst_numeros.Visible = True

        If var = False Then
            MsgBox("Por favor ingrese todos los valores solicitados")
        Else
            generarBTN.Enabled = False
            btnEjemplo.Enabled = False
            Dim n As Double = Double.Parse(txt_muestras.Text)
            Dim lista(0 To (n - 1)) As Double
            Dim K As Double = Double.Parse(txt_intervalos.Text)
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

            intervalos = 1 / K ''probabilidad de cada intevalo

            medidaIntervalos = n / K ''MEDIDA DE LOS INTERVALOS'' = frecuencia esperada

            tamañoIntervalo = 1 / K

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
            For i = 1 To K Step 1
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

    Private Sub BTNActualizarXi_Click(sender As Object, e As EventArgs) Handles BTNActualizarXi.Click

        If (IsNumeric(XiTab.Text)) Then
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
        Else
            MsgBox("Por favor, ingrese un número")
        End If

    End Sub
End Class