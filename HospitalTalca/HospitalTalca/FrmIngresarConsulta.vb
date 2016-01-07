Imports HospitalTalca.BsnNegocio
Imports HospitalTalca.Consultas
Imports HospitalTalca.BsnNegociosConsulta


Public Class FrmIngresarConsulta
    Dim modificarconsulta As New FrmModificarConsulta()
    Dim bsnNegocioConsulta As New BsnNegociosConsulta()
    Dim consulta As New Consultas()
    Dim operador As Integer = -1

    'Public Sub New(ByVal modificarconsulta As FrmModificarConsulta, ByVal consulta As Consultas, ByVal operacion As Integer)
    '    InitializeComponent()

    '    Me.modificarconsulta = modificarconsulta
    '    Me.consulta = consulta
    '    Me.operador = operacion

    'End Sub

    'Public Sub New(ByVal modificarconsulta As FrmModificarConsulta, ByVal operacion As Integer)
    '    InitializeComponent()

    '    Me.modificarconsulta = FrmModificarConsulta
    '    Me.operador = operacion

    'End Sub

    Private Sub FrmInsertarConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cbTipoConsulta.DisplayMember = "Text"
        cbTipoConsulta.ValueMember = "Value"
        Dim tba As New DataTable
        tba.Columns.Add("Text", GetType(String))
        tba.Columns.Add("Value", GetType(Integer))
        tba.Rows.Add("Consulta Medica", 1)
        tba.Rows.Add("Urgencia", 2)
        tba.Rows.Add("Interconsulta", 3)
        cbTipoConsulta.DataSource = tba

        CbEspeci.DisplayMember = "Text"
        CbEspeci.ValueMember = "Value"
        Dim tb As New DataTable
        tb.Columns.Add("Text", GetType(String))
        tb.Columns.Add("Value", GetType(Integer))
        tb.Rows.Add("Medicina General", 1)
        tb.Rows.Add("Traumatologia", 2)
        tb.Rows.Add("Odontologia", 3)
        tb.Rows.Add("Pediatria", 4)
        tb.Rows.Add("Oncologia", 5)
        CbEspeci.DataSource = tb

        CbidPaciente.DisplayMember = "Text"
        CbidPaciente.ValueMember = "Value"
        Dim tbb As New DataTable
        tbb.Columns.Add("Text", GetType(String))
        tbb.Columns.Add("Value", GetType(Integer))
        tbb.Rows.Add("ignacio vargas", 1)
        tbb.Rows.Add("pepe tapia", 2)
        tbb.Rows.Add("luis perez", 3)
        tbb.Rows.Add("juan poblete", 4)
        tbb.Rows.Add("Mauricio Carpentier", 5)
        tbb.Rows.Add("Alan Brito", 6)
        CbidPaciente.DataSource = tbb

        If operador = Operaciones.modificar Then
            txtMotivo.Text = consulta.Motivo
            txtDiagnostico.Text = consulta.Diagnostico
            CbEspeci.SelectedValue = consulta.Especialidad
            cbTipoConsulta.SelectedValue = consulta.TipoConsulta
            dtpFechaConsulta.Value = consulta.FechaConsulta
            CbidPaciente.SelectedValue = consulta.IdPaciente

            Me.Text = "Modificar Consulta"

        End If

    End Sub


    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        consulta.Motivo = txtMotivo.Text
        consulta.Diagnostico = txtDiagnostico.Text
        consulta.Especialidad = CbEspeci.SelectedValue
        consulta.TipoConsulta = cbTipoConsulta.SelectedValue
        consulta.FechaConsulta = dtpFechaConsulta.Value
        consulta.IdPaciente = CbidPaciente.SelectedValue

        'If operador = Operaciones.modificar Then

        '    If MessageBox.Show("¿ Está seguro de modificar el Alumno ?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then

        '        bsnNegocia.ModificarAlumno(alumnos)
        '        MsgBox("Alumno modificado correctamente", MsgBoxStyle.Information, "Alerta")
        '    Else
        If MessageBox.Show("¿ Está seguro de agregar una consulta ?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            bsnNegocioConsulta.InsertarConsultas(consulta)
        End If

    End Sub
End Class