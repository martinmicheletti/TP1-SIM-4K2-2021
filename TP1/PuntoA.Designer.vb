<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PUNTO_A
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PUNTO_A))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_muestras = New System.Windows.Forms.TextBox()
        Me.btn_Generar = New System.Windows.Forms.Button()
        Me.lbx_general = New System.Windows.Forms.ListBox()
        Me.btn_Next = New System.Windows.Forms.Button()
        Me.btn_Limpiar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_M = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_C = New System.Windows.Forms.TextBox()
        Me.lbl_C = New System.Windows.Forms.Label()
        Me.txt_A = New System.Windows.Forms.TextBox()
        Me.K = New System.Windows.Forms.Label()
        Me.txt_semilla = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdb_multiplicativo = New System.Windows.Forms.RadioButton()
        Me.rdb_MIXTO = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N° de muestras"
        '
        'txt_muestras
        '
        Me.txt_muestras.Location = New System.Drawing.Point(111, 33)
        Me.txt_muestras.Name = "txt_muestras"
        Me.txt_muestras.Size = New System.Drawing.Size(77, 20)
        Me.txt_muestras.TabIndex = 1
        '
        'btn_Generar
        '
        Me.btn_Generar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_Generar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Generar.Location = New System.Drawing.Point(579, 17)
        Me.btn_Generar.Name = "btn_Generar"
        Me.btn_Generar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Generar.TabIndex = 12
        Me.btn_Generar.Text = "Generar"
        Me.btn_Generar.UseVisualStyleBackColor = False
        '
        'lbx_general
        '
        Me.lbx_general.FormattingEnabled = True
        Me.lbx_general.Location = New System.Drawing.Point(-1, 104)
        Me.lbx_general.Name = "lbx_general"
        Me.lbx_general.Size = New System.Drawing.Size(683, 277)
        Me.lbx_general.TabIndex = 14
        '
        'btn_Next
        '
        Me.btn_Next.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_Next.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Next.Location = New System.Drawing.Point(579, 46)
        Me.btn_Next.Name = "btn_Next"
        Me.btn_Next.Size = New System.Drawing.Size(75, 23)
        Me.btn_Next.TabIndex = 17
        Me.btn_Next.Text = "Siguiente"
        Me.btn_Next.UseVisualStyleBackColor = False
        '
        'btn_Limpiar
        '
        Me.btn_Limpiar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Limpiar.Location = New System.Drawing.Point(579, 75)
        Me.btn_Limpiar.Name = "btn_Limpiar"
        Me.btn_Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Limpiar.TabIndex = 18
        Me.btn_Limpiar.Text = "Limpiar"
        Me.btn_Limpiar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_M)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_C)
        Me.GroupBox1.Controls.Add(Me.lbl_C)
        Me.GroupBox1.Controls.Add(Me.txt_A)
        Me.GroupBox1.Controls.Add(Me.K)
        Me.GroupBox1.Controls.Add(Me.txt_semilla)
        Me.GroupBox1.Controls.Add(Me.label)
        Me.GroupBox1.Location = New System.Drawing.Point(210, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(197, 84)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Variables"
        '
        'txt_M
        '
        Me.txt_M.Location = New System.Drawing.Point(122, 21)
        Me.txt_M.Name = "txt_M"
        Me.txt_M.Size = New System.Drawing.Size(61, 20)
        Me.txt_M.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(106, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "m"
        '
        'txt_C
        '
        Me.txt_C.Location = New System.Drawing.Point(122, 50)
        Me.txt_C.Name = "txt_C"
        Me.txt_C.Size = New System.Drawing.Size(61, 20)
        Me.txt_C.TabIndex = 15
        '
        'lbl_C
        '
        Me.lbl_C.AutoSize = True
        Me.lbl_C.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_C.Location = New System.Drawing.Point(107, 53)
        Me.lbl_C.Name = "lbl_C"
        Me.lbl_C.Size = New System.Drawing.Size(15, 13)
        Me.lbl_C.TabIndex = 14
        Me.lbl_C.Text = "C"
        '
        'txt_A
        '
        Me.txt_A.Location = New System.Drawing.Point(27, 50)
        Me.txt_A.Name = "txt_A"
        Me.txt_A.Size = New System.Drawing.Size(61, 20)
        Me.txt_A.TabIndex = 13
        '
        'K
        '
        Me.K.AutoSize = True
        Me.K.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K.Location = New System.Drawing.Point(7, 53)
        Me.K.Name = "K"
        Me.K.Size = New System.Drawing.Size(14, 13)
        Me.K.TabIndex = 12
        Me.K.Text = "a"
        '
        'txt_semilla
        '
        Me.txt_semilla.Location = New System.Drawing.Point(27, 20)
        Me.txt_semilla.Name = "txt_semilla"
        Me.txt_semilla.Size = New System.Drawing.Size(61, 20)
        Me.txt_semilla.TabIndex = 11
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(6, 23)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(15, 13)
        Me.label.TabIndex = 10
        Me.label.Text = "X"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdb_multiplicativo)
        Me.GroupBox2.Controls.Add(Me.rdb_MIXTO)
        Me.GroupBox2.Location = New System.Drawing.Point(427, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(113, 79)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccione Metodo"
        '
        'rdb_multiplicativo
        '
        Me.rdb_multiplicativo.AutoSize = True
        Me.rdb_multiplicativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_multiplicativo.Location = New System.Drawing.Point(6, 46)
        Me.rdb_multiplicativo.Name = "rdb_multiplicativo"
        Me.rdb_multiplicativo.Size = New System.Drawing.Size(100, 17)
        Me.rdb_multiplicativo.TabIndex = 13
        Me.rdb_multiplicativo.TabStop = True
        Me.rdb_multiplicativo.Text = "Multiplicativo"
        Me.rdb_multiplicativo.UseVisualStyleBackColor = True
        '
        'rdb_MIXTO
        '
        Me.rdb_MIXTO.AutoSize = True
        Me.rdb_MIXTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_MIXTO.Location = New System.Drawing.Point(6, 17)
        Me.rdb_MIXTO.Name = "rdb_MIXTO"
        Me.rdb_MIXTO.Size = New System.Drawing.Size(55, 17)
        Me.rdb_MIXTO.TabIndex = 12
        Me.rdb_MIXTO.TabStop = True
        Me.rdb_MIXTO.Text = "Mixto"
        Me.rdb_MIXTO.UseVisualStyleBackColor = True
        '
        'PUNTO_A
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(682, 378)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_Limpiar)
        Me.Controls.Add(Me.btn_Next)
        Me.Controls.Add(Me.lbx_general)
        Me.Controls.Add(Me.btn_Generar)
        Me.Controls.Add(Me.txt_muestras)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PUNTO_A"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Punto A"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_muestras As System.Windows.Forms.TextBox
    Friend WithEvents btn_Generar As System.Windows.Forms.Button
    Friend WithEvents lbx_general As System.Windows.Forms.ListBox
    Friend WithEvents btn_Next As System.Windows.Forms.Button
    Friend WithEvents btn_Limpiar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_M As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_C As TextBox
    Friend WithEvents lbl_C As Label
    Friend WithEvents txt_A As TextBox
    Friend WithEvents K As Label
    Friend WithEvents txt_semilla As TextBox
    Friend WithEvents label As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdb_multiplicativo As RadioButton
    Friend WithEvents rdb_MIXTO As RadioButton
End Class
