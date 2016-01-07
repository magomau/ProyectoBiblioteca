Imports HospitalTalca.BsnNegociosConsulta
Imports HospitalTalca.Consultas

Public Class ConsultarTipoPaciente

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

        DgvTipoPaciente.DataSource = bsnNegocioConsulta.GetConsultasTipo()

        DgvTipoPaciente.Columns(0).Visible = False
        'DvgModificar.Columns(1).Visible = False

    End Sub


    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

End Class