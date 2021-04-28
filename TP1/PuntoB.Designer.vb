<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PuntoB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PuntoB))
        Me.graficarBTN = New System.Windows.Forms.Button()
        Me.Ktxt = New System.Windows.Forms.TextBox()
        Me.Ntxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblV = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.dtgvChiCuadrado = New System.Windows.Forms.DataGridView()
        Me.intervalo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.frecuenciaObservada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.frecuenciaEsperada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diferenciaDeFrecuencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diferenciaAlCuadrado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xCuadradoI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lst_numeros = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.XiTab = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTNActualizarXi = New System.Windows.Forms.Button()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvChiCuadrado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'graficarBTN
        '
        Me.graficarBTN.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.graficarBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graficarBTN.Location = New System.Drawing.Point(609, 41)
        Me.graficarBTN.Name = "graficarBTN"
        Me.graficarBTN.Size = New System.Drawing.Size(105, 27)
        Me.graficarBTN.TabIndex = 19
        Me.graficarBTN.Text = "Graficar"
        Me.graficarBTN.UseVisualStyleBackColor = False
        '
        'Ktxt
        '
        Me.Ktxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ktxt.Location = New System.Drawing.Point(438, 45)
        Me.Ktxt.Name = "Ktxt"
        Me.Ktxt.Size = New System.Drawing.Size(122, 20)
        Me.Ktxt.TabIndex = 18
        '
        'Ntxt
        '
        Me.Ntxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ntxt.Location = New System.Drawing.Point(164, 45)
        Me.Ntxt.Name = "Ntxt"
        Me.Ntxt.Size = New System.Drawing.Size(122, 20)
        Me.Ntxt.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(315, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "N° de intervalos (k)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "N° de muestras (n)"
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(6, 9)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Observado"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Esperado"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(856, 367)
        Me.Chart1.TabIndex = 20
        Me.Chart1.Text = "Chart1"
        '
        'lblV
        '
        Me.lblV.AutoSize = True
        Me.lblV.Location = New System.Drawing.Point(3, 7)
        Me.lblV.Name = "lblV"
        Me.lblV.Size = New System.Drawing.Size(93, 13)
        Me.lblV.TabIndex = 23
        Me.lblV.Text = "Grados de libertad"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(754, 41)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(105, 27)
        Me.btnLimpiar.TabIndex = 24
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'dtgvChiCuadrado
        '
        Me.dtgvChiCuadrado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgvChiCuadrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvChiCuadrado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.intervalo, Me.frecuenciaObservada, Me.frecuenciaEsperada, Me.diferenciaDeFrecuencia, Me.diferenciaAlCuadrado, Me.xCuadradoI})
        Me.dtgvChiCuadrado.Location = New System.Drawing.Point(0, 23)
        Me.dtgvChiCuadrado.Name = "dtgvChiCuadrado"
        Me.dtgvChiCuadrado.ReadOnly = True
        Me.dtgvChiCuadrado.Size = New System.Drawing.Size(868, 360)
        Me.dtgvChiCuadrado.TabIndex = 49
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(5, 90)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(876, 415)
        Me.TabControl1.TabIndex = 50
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Chart1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(868, 389)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Gráfico de frecuencias"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dtgvChiCuadrado)
        Me.TabPage2.Controls.Add(Me.lblV)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(868, 389)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tabla de frecuencias"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lst_numeros)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(868, 389)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Series de datos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lst_numeros
        '
        Me.lst_numeros.FormattingEnabled = True
        Me.lst_numeros.Location = New System.Drawing.Point(-4, 0)
        Me.lst_numeros.Name = "lst_numeros"
        Me.lst_numeros.Size = New System.Drawing.Size(877, 368)
        Me.lst_numeros.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 20)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Test de Chi Cuadrado"
        '
        'XiTab
        '
        Me.XiTab.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.XiTab.Enabled = False
        Me.XiTab.Location = New System.Drawing.Point(609, 80)
        Me.XiTab.Name = "XiTab"
        Me.XiTab.Size = New System.Drawing.Size(105, 20)
        Me.XiTab.TabIndex = 52
        Me.XiTab.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(521, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Xi Tabulado"
        '
        'BTNActualizarXi
        '
        Me.BTNActualizarXi.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BTNActualizarXi.Enabled = False
        Me.BTNActualizarXi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNActualizarXi.Location = New System.Drawing.Point(720, 76)
        Me.BTNActualizarXi.Name = "BTNActualizarXi"
        Me.BTNActualizarXi.Size = New System.Drawing.Size(139, 27)
        Me.BTNActualizarXi.TabIndex = 54
        Me.BTNActualizarXi.Text = "Actualizar Xi Tab"
        Me.BTNActualizarXi.UseVisualStyleBackColor = False
        '
        'PuntoB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(881, 525)
        Me.Controls.Add(Me.BTNActualizarXi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.XiTab)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.graficarBTN)
        Me.Controls.Add(Me.Ktxt)
        Me.Controls.Add(Me.Ntxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PuntoB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Punto B"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgvChiCuadrado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents graficarBTN As System.Windows.Forms.Button
    Friend WithEvents Ktxt As System.Windows.Forms.TextBox
    Friend WithEvents Ntxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents lblV As System.Windows.Forms.Label
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents dtgvChiCuadrado As System.Windows.Forms.DataGridView
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
    Friend WithEvents XiTab As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BTNActualizarXi As Button
End Class
