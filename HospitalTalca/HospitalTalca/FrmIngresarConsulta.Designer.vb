<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIngresarConsulta
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Especialidad = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMotivo = New System.Windows.Forms.TextBox()
        Me.txtDiagnostico = New System.Windows.Forms.TextBox()
        Me.dtpFechaConsulta = New System.Windows.Forms.DateTimePicker()
        Me.cbTipoConsulta = New System.Windows.Forms.ComboBox()
        Me.CbEspeci = New System.Windows.Forms.ComboBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.CbidPaciente = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Motivo: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Diagnostico: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha de Consulta: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipo de Consulta: "
        '
        'Especialidad
        '
        Me.Especialidad.AutoSize = True
        Me.Especialidad.Location = New System.Drawing.Point(54, 189)
        Me.Especialidad.Name = "Especialidad"
        Me.Especialidad.Size = New System.Drawing.Size(73, 13)
        Me.Especialidad.TabIndex = 4
        Me.Especialidad.Text = "Especialidad: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Id del Paciante: "
        '
        'txtMotivo
        '
        Me.txtMotivo.Location = New System.Drawing.Point(150, 45)
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(210, 20)
        Me.txtMotivo.TabIndex = 6
        '
        'txtDiagnostico
        '
        Me.txtDiagnostico.Location = New System.Drawing.Point(150, 80)
        Me.txtDiagnostico.Name = "txtDiagnostico"
        Me.txtDiagnostico.Size = New System.Drawing.Size(210, 20)
        Me.txtDiagnostico.TabIndex = 7
        '
        'dtpFechaConsulta
        '
        Me.dtpFechaConsulta.Location = New System.Drawing.Point(150, 111)
        Me.dtpFechaConsulta.Name = "dtpFechaConsulta"
        Me.dtpFechaConsulta.Size = New System.Drawing.Size(210, 20)
        Me.dtpFechaConsulta.TabIndex = 8
        '
        'cbTipoConsulta
        '
        Me.cbTipoConsulta.FormattingEnabled = True
        Me.cbTipoConsulta.Location = New System.Drawing.Point(150, 145)
        Me.cbTipoConsulta.Name = "cbTipoConsulta"
        Me.cbTipoConsulta.Size = New System.Drawing.Size(210, 21)
        Me.cbTipoConsulta.TabIndex = 9
        '
        'CbEspeci
        '
        Me.CbEspeci.FormattingEnabled = True
        Me.CbEspeci.Location = New System.Drawing.Point(150, 189)
        Me.CbEspeci.Name = "CbEspeci"
        Me.CbEspeci.Size = New System.Drawing.Size(210, 21)
        Me.CbEspeci.TabIndex = 10
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(88, 321)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(96, 37)
        Me.btnCerrar.TabIndex = 12
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(354, 321)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(92, 36)
        Me.btnAceptar.TabIndex = 13
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'CbidPaciente
        '
        Me.CbidPaciente.FormattingEnabled = True
        Me.CbidPaciente.Location = New System.Drawing.Point(150, 224)
        Me.CbidPaciente.Name = "CbidPaciente"
        Me.CbidPaciente.Size = New System.Drawing.Size(121, 21)
        Me.CbidPaciente.TabIndex = 14
        '
        'FrmIngresarConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 407)
        Me.Controls.Add(Me.CbidPaciente)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.CbEspeci)
        Me.Controls.Add(Me.cbTipoConsulta)
        Me.Controls.Add(Me.dtpFechaConsulta)
        Me.Controls.Add(Me.txtDiagnostico)
        Me.Controls.Add(Me.txtMotivo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Especialidad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmIngresarConsulta"
        Me.Text = "IngresarConsulta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Especialidad As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMotivo As System.Windows.Forms.TextBox
    Friend WithEvents txtDiagnostico As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaConsulta As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbTipoConsulta As System.Windows.Forms.ComboBox
    Friend WithEvents CbEspeci As System.Windows.Forms.ComboBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents CbidPaciente As System.Windows.Forms.ComboBox
End Class
