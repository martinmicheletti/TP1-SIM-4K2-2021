Public Class PUNTO_A

    Dim cant_muestras As Integer
    Dim count As Integer
    Dim x As Double
    Dim c1 As Double
    Dim a As Double
    Dim m As Double
    Dim x1 As Double

    Dim semilla As Double
    Dim n_aleatorio As Double

    Private Sub PUNTO_A_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '' Inicializo los campos

        lbx_general.Visible = False
        btn_Next.Enabled = False
        txt_muestras.Text = 20
        txt_muestras.Enabled = False
        rdb_MIXTO.Checked = True
    End Sub
    Private Function validar_Campos() As Boolean
        Dim validacion As Boolean
        If (txt_M.Text = "" Or txt_A.Text = "" Or txt_semilla.Text = "") Then
            validacion = False
        Else
            validacion = True
        End If
        Return validacion
    End Function

    Private Sub btn_Generar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Generar.Click
        btn_Next.Enabled = True
        btn_Generar.Enabled = False
        lbx_general.Visible = True
        txt_A.Enabled = False
        txt_C.Enabled = False
        txt_semilla.Enabled = False
        txt_M.Enabled = True


        '' Valido que esten cargadas las variables 

        If validar_Campos() = False Then
            MsgBox("Por favor ingrese las variables")
        Else : lbx_general.Items.Clear()
            cant_muestras = txt_muestras.Text

            count = 0
            semilla = txt_semilla.Text
            a = txt_A.Text
            m = txt_M.Text


            If rdb_MIXTO.Checked Then
                For count = 0 To (cant_muestras - 1)
                    c1 = txt_C.Text

                    If count = 0 Then
                        x = semilla
                    Else
                        x = ((a * x) + c1) Mod m
                    End If

                    n_aleatorio = Math.Round(x / m, 4)

                    lbx_general.Items.Add(n_aleatorio)

                Next count

            Else
                If rdb_multiplicativo.Checked Then
                    For count = 0 To (cant_muestras - 1)

                        If count = 0 Then
                            x = semilla
                        Else
                            x = (a * x) Mod m
                        End If

                        n_aleatorio = Math.Round(x / m, 4)

                        '' agrego a la lista
                        lbx_general.Items.Add(n_aleatorio)

                    Next count

                End If
            End If

            x1 = x

        End If



    End Sub

    Private Sub btn_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Next.Click

        If validar_Campos() = False Then
            MsgBox("Por favor ingrese todos los valores requeridos")
        Else
            Dim ri As Double
            If rdb_MIXTO.Checked Then
                x = ((a * x) + c1) Mod m

            Else
                x = (a * x) Mod m
            End If
            n_aleatorio = Math.Round(x / m, 4)
            lbx_general.Items.Add(n_aleatorio)
        End If
    End Sub

    Private Sub rdb_MIXTO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txt_C.Enabled = True
        txt_C.Visible = True
        lbl_C.Visible = True

    End Sub

    Private Sub rdb_multiplicativo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txt_C.Enabled = False
        txt_C.Visible = False
        lbl_C.Visible = False
    End Sub



    Private Sub Btn_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Limpiar.Click
        '' limpio los campos y la lista
        lbx_general.Visible = False


        lbx_general.Items.Clear()
        txt_C.Clear()
        txt_A.Clear()
        txt_M.Clear()
        txt_semilla.Clear()
        btn_Generar.Enabled = True
        txt_A.Enabled = True
        txt_C.Enabled = True
        txt_semilla.Enabled = True
        txt_M.Enabled = True

    End Sub

    Private Sub rdb_MIXTO_CheckedChanged_1(sender As Object, e As EventArgs) Handles rdb_MIXTO.CheckedChanged
        txt_C.Enabled = True
        txt_C.Visible = True
        lbl_C.Visible = True
    End Sub

    Private Sub rdb_multiplicativo_CheckedChanged_1(sender As Object, e As EventArgs) Handles rdb_multiplicativo.CheckedChanged
        txt_C.Enabled = False
        txt_C.Visible = False
        lbl_C.Visible = False
    End Sub


    Private Sub txt_semilla_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_semilla.KeyPress
        '' El evento keypress es cuando se ingresa por teclado
        '' Valido que se ingrese numeros

        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MsgBox("Por favor ingrese un numero")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txt_A_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_A.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MsgBox("Por favor ingrese un numero")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub


    Private Sub txt_M_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_M.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MsgBox("Por favor ingrese un numero")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub


    Private Sub txt_C_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_C.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MsgBox("Por favor ingrese un numero")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txt_M_TextChanged(sender As Object, e As EventArgs) Handles txt_M.TextChanged

    End Sub
End Class