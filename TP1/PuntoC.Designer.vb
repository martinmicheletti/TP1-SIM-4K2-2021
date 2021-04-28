<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PUNTOC
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PUNTOC))
        Me.generarBTN = New System.Windows.Forms.Button()
        Me.txt_M = New System.Windows.Forms.TextBox()
        Me.txt_C = New System.Windows.Forms.TextBox()
        Me.txt_A = New System.Windows.Forms.TextBox()
        Me.txt_semilla = New System.Windows.Forms.TextBox()
        Me.txt_muestras = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.C = New System.Windows.Forms.Label()
        Me.K = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_K = New System.Windows.Forms.Label()
        Me.txt_intervalos = New System.Windows.Forms.TextBox()
        Me.lblV = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.dtgvChiCuadrado = New System.Windows.Forms.DataGridView()
        Me.intervalo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.frecuenciaObservada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.frecuenciaEsperada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diferenciaDeFrecuencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diferenciaAlCuadrado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xCuadradoI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEjemplo = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lst_numeros = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvChiCuadrado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'generarBTN
        '
        Me.generarBTN.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.generarBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.generarBTN.Location = New System.Drawing.Point(672, 45)
        Me.generarBTN.Name = "generarBTN"
        Me.generarBTN.Size = New System.Drawing.Size(157, 26)
        Me.generarBTN.TabIndex = 35
        Me.generarBTN.Text = "Generar"
        Me.generarBTN.UseVisualStyleBackColor = False
        '
        'txt_M
        '
        Me.txt_M.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_M.Location = New System.Drawing.Point(378, 79)
        Me.txt_M.Name = "txt_M"
        Me.txt_M.Size = New System.Drawing.Size(50, 20)
        Me.txt_M.TabIndex = 33
        '
        'txt_C
        '
        Me.txt_C.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_C.Location = New System.Drawing.Point(378, 45)
        Me.txt_C.Name = "txt_C"
        Me.txt_C.Size = New System.Drawing.Size(50, 20)
        Me.txt_C.TabIndex = 32
        '
        'txt_A
        '
        Me.txt_A.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_A.Location = New System.Drawing.Point(274, 79)
        Me.txt_A.Name = "txt_A"
        Me.txt_A.Size = New System.Drawing.Size(50, 20)
        Me.txt_A.TabIndex = 31
        '
        'txt_semilla
        '
        Me.txt_semilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_semilla.Location = New System.Drawing.Point(274, 45)
        Me.txt_semilla.Name = "txt_semilla"
        Me.txt_semilla.Size = New System.Drawing.Size(50, 20)
        Me.txt_semilla.TabIndex = 30
        '
        'txt_muestras
        '
        Me.txt_muestras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_muestras.Location = New System.Drawing.Point(142, 45)
        Me.txt_muestras.Name = "txt_muestras"
        Me.txt_muestras.Size = New System.Drawing.Size(76, 20)
        Me.txt_muestras.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(356, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "m"
        '
        'C
        '
        Me.C.AutoSize = True
        Me.C.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C.Location = New System.Drawing.Point(357, 48)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(15, 13)
        Me.C.TabIndex = 41
        Me.C.Text = "C"
        '
        'K
        '
        Me.K.AutoSize = True
        Me.K.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K.Location = New System.Drawing.Point(255, 82)
        Me.K.Name = "K"
        Me.K.Size = New System.Drawing.Size(14, 13)
        Me.K.TabIndex = 40
        Me.K.Text = "a"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(254, 48)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(15, 13)
        Me.label.TabIndex = 39
        Me.label.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "N° de muestras (n)"
        '
        'lbl_K
        '
        Me.lbl_K.AutoSize = True
        Me.lbl_K.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_K.Location = New System.Drawing.Point(69, 82)
        Me.lbl_K.Name = "lbl_K"
        Me.lbl_K.Size = New System.Drawing.Size(67, 13)
        Me.lbl_K.TabIndex = 44
        Me.lbl_K.Text = "Intervalos "
        '
        'txt_intervalos
        '
        Me.txt_intervalos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_intervalos.Location = New System.Drawing.Point(142, 79)
        Me.txt_intervalos.Name = "txt_intervalos"
        Me.txt_intervalos.Size = New System.Drawing.Size(76, 20)
        Me.txt_intervalos.TabIndex = 34
        '
        'lblV
        '
        Me.lblV.AutoSize = True
        Me.lblV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblV.Location = New System.Drawing.Point(465, 63)
        Me.lblV.Name = "lblV"
        Me.lblV.Size = New System.Drawing.Size(119, 13)
        Me.lblV.TabIndex = 46
        Me.lblV.Text = "Grados de libertad: "
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(-1, 1)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Observado"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Esperado"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(825, 404)
        Me.Chart1.TabIndex = 47
        Me.Chart1.Text = "Chart1"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(672, 77)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(157, 23)
        Me.btnLimpiar.TabIndex = 36
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'dtgvChiCuadrado
        '
        Me.dtgvChiCuadrado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgvChiCuadrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvChiCuadrado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.intervalo, Me.frecuenciaObservada, Me.frecuenciaEsperada, Me.diferenciaDeFrecuencia, Me.diferenciaAlCuadrado, Me.xCuadradoI})
        Me.dtgvChiCuadrado.Location = New System.Drawing.Point(0, 0)
        Me.dtgvChiCuadrado.Name = "dtgvChiCuadrado"
        Me.dtgvChiCuadrado.Size = New System.Drawing.Size(830, 408)
        Me.dtgvChiCuadrado.TabIndex = 48
        '
        'intervalo
        '
        Me.intervalo.HeaderText = "K"
        Me.intervalo.Name = "intervalo"
        Me.intervalo.ReadOnly = True
        '
        'frecuenciaObservada
        '
        Me.frecuenciaObservada.HeaderText = "Fo"
        Me.frecuenciaObservada.Name = "frecuenciaObservada"
        Me.frecuenciaObservada.ReadOnly = True
        '
        'frecuenciaEsperada
        '
        Me.frecuenciaEsperada.HeaderText = "Fe"
        Me.frecuenciaEsperada.Name = "frecuenciaEsperada"
        Me.frecuenciaEsperada.ReadOnly = True
        '
        'diferenciaDeFrecuencia
        '
        Me.diferenciaDeFrecuencia.HeaderText = "(Fo-Fe)"
        Me.diferenciaDeFrecuencia.Name = "diferenciaDeFrecuencia"
        Me.diferenciaDeFrecuencia.ReadOnly = True
        '
        'diferenciaAlCuadrado
        '
        Me.diferenciaAlCuadrado.HeaderText = "(Fo-Fe)^2"
        Me.diferenciaAlCuadrado.Name = "diferenciaAlCuadrado"
        Me.diferenciaAlCuadrado.ReadOnly = True
        '
        'xCuadradoI
        '
        Me.xCuadradoI.HeaderText = "((Fo-Fe)^2)/Fe"
        Me.xCuadradoI.Name = "xCuadradoI"
        Me.xCuadradoI.ReadOnly = True
        '
        'btnEjemplo
        '
        Me.btnEjemplo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnEjemplo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEjemplo.Location = New System.Drawing.Point(673, 16)
        Me.btnEjemplo.Name = "btnEjemplo"
        Me.btnEjemplo.Size = New System.Drawing.Size(156, 23)
        Me.btnEjemplo.TabIndex = 49
        Me.btnEjemplo.Text = "Cargar Ejemplo"
        Me.btnEjemplo.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(1, 121)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(843, 434)
        Me.TabControl1.TabIndex = 50
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Chart1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(835, 408)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Gráfico de Frecuencias"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dtgvChiCuadrado)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(835, 408)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tabla de Frecuencias"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lst_numeros)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(835, 408)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Serie de Datos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lst_numeros
        '
        Me.lst_numeros.FormattingEnabled = True
        Me.lst_numeros.Location = New System.Drawing.Point(0, 0)
        Me.lst_numeros.Name = "lst_numeros"
        Me.lst_numeros.Size = New System.Drawing.Size(830, 407)
        Me.lst_numeros.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(413, 20)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Test de Chi Cuadrado - Método congruencial mixto"
        '
        'PUNTOC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(841, 553)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnEjemplo)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.lblV)
        Me.Controls.Add(Me.lbl_K)
        Me.Controls.Add(Me.txt_intervalos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.C)
        Me.Controls.Add(Me.K)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.generarBTN)
        Me.Controls.Add(Me.txt_M)
        Me.Controls.Add(Me.txt_C)
        Me.Controls.Add(Me.txt_A)
        Me.Controls.Add(Me.txt_semilla)
        Me.Controls.Add(Me.txt_muestras)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PUNTOC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Punto C"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgvChiCuadrado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents generarBTN As System.Windows.Forms.Button
    Friend WithEvents txt_M As System.Windows.Forms.TextBox
    Friend WithEvents txt_C As System.Windows.Forms.TextBox
    Friend WithEvents txt_A As System.Windows.Forms.TextBox
    Friend WithEvents txt_semilla As System.Windows.Forms.TextBox
    Friend WithEvents txt_muestras As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents C As System.Windows.Forms.Label
    Friend WithEvents K As System.Windows.Forms.Label
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_K As System.Windows.Forms.Label
    Friend WithEvents txt_intervalos As System.Windows.Forms.TextBox
    Friend WithEvents lblV As System.Windows.Forms.Label
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents dtgvChiCuadrado As System.Windows.Forms.DataGridView
    Friend WithEvents btnEjemplo As System.Windows.Forms.Button
    Friend WithEvents intervalo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents frecuenciaObservada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents frecuenciaEsperada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents diferenciaDeFrecuencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents diferenciaAlCuadrado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents xCuadradoI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents lst_numeros As ListBox
    Friend WithEvents Label3 As Label
End Class
