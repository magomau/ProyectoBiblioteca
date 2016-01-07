Imports HospitalTalca.BsnNegociosConsulta
Imports HospitalTalca.Consultas

Public Class FrmModificarConsulta

    Dim bsnNegocioConsulta As New BsnNegociosConsulta()
    Dim consulta As New Consultas()
    Dim frmMenuPrincipal As New FrnMenuPrincipal()

    Public Sub New(ByVal formMenuPrincipal As FrnMenuPrincipal)
        InitializeComponent()
        Me.frmMenuPrincipal = formMenuPrincipal
    End Sub

    Public Sub New()
        InitializeComponent()

    End Sub

    Public Sub FrmConsultarConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DvgModificar.DataSource = bsnNegocioConsulta.GetConsultas()

        DvgModificar.Columns(0).Visible = False
        'DvgModificar.Columns(1).Visible = False

    End Sub


    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        'Motivo, Diagnostico, FechaConsulta, IDTipoConsulta, IDEspecialidad, IDPaciente
        Dim consultas As New Consultas()

        consultas.Motivo = DvgModificar.SelectedRows.Item(0).Cells(2).Value.ToString()
        consultas.Diagnostico = DvgModificar.SelectedRows.Item(0).Cells(3).Value.ToString()
        consultas.FechaConsulta = Date.Parse(DvgModificar.SelectedRows.Item(0).Cells(4).Value)
        consultas.TipoConsulta = Integer.Parse(DvgModificar.SelectedRows.Item(0).Cells(5).Value)
        consultas.Especialidad = Integer.Parse(DvgModificar.SelectedRows.Item(0).Cells(6).Value)
        consultas.IdPaciente = Integer.Parse(DvgModificar.SelectedRows.Item(0).Cells(7).Value)
        
        ' Dim frmInsertarConsulta As New FrmIngresarConsulta(Me, consultas, Operaciones.modificar)
        'frmInsertarConsulta.ShowDialog()

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Dim consultas As New Consultas()

        consultas.ID = Integer.Parse(DvgModificar.SelectedRows.Item(0).Cells(0).Value)
        If MessageBox.Show("Está seguro de Eliminar el consulta ?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then

            bsnNegocioConsulta.EliminarConsulta(consultas)
            MsgBox("consulta eliminada correctamente", MsgBoxStyle.Information, "Alerta")
            Me.FrmConsultarConsulta_Load(Me, Nothing)
        End If
    End Sub
End Class