Imports HospitalTalca.BsnNegocio
Imports HospitalTalca.Paciente
Public Class ConsultarPaciente

    Dim bsnNegocio As New BsnNegocio()
    Dim frmMenuPrincipal As New FrnMenuPrincipal()

    Public Sub New(frmMenuPrincipal As FrnMenuPrincipal)
        InitializeComponent()

        Me.frmMenuPrincipal = frmMenuPrincipal
    End Sub

    Public Sub New()
        InitializeComponent()

    End Sub

    Public Sub FrmConsultarAlumno_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        DgvPaciente.DataSource = bsnNegocio.GetPaciente()

        DgvPaciente.Columns(0).Visible = False
        DgvPaciente.Columns(5).Visible = False

    End Sub


    Private Sub BtnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
    End Sub

End Class