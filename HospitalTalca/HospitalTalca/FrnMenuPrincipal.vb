Imports HospitalTalca.Usuario
Imports HospitalTalca.FrnLogin

Public Class FrnMenuPrincipal

    Dim usuario As Usuario
    Dim formLogin As FrnLogin


    Public Sub New(formLogin As FrnLogin, usuario As Usuario)
        InitializeComponent()
        Me.usuario = usuario
        Me.formLogin = formLogin
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FrnMenuPrincipal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Me.Dispose()
        formLogin.Show()
    End Sub

    Private Sub ConsultarPacienteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarPacienteToolStripMenuItem.Click
        Dim consultar As New ConsultarPaciente(Me)
        consultar.ShowDialog()
    End Sub

    Private Sub IngresarConsultaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresarConsultaToolStripMenuItem.Click
        Dim insertarConsulta As New FrmIngresarConsulta()
        insertarConsulta.ShowDialog()
    End Sub

    Private Sub ModificarConsultaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarConsultaToolStripMenuItem.Click
        Dim modificarConsulta As New FrmModificarConsulta(Me)
        modificarConsulta.btnEliminar.Visible = False
        modificarConsulta.ShowDialog()
    End Sub

    Private Sub EliminarConsultaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarConsultaToolStripMenuItem.Click
        Dim eliminarConsulta As New FrmModificarConsulta(Me)
        eliminarConsulta.btnModificar.Visible = False
        eliminarConsulta.ShowDialog()
    End Sub

    Private Sub TipoDeConsultaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoDeConsultaToolStripMenuItem.Click
        Dim consultarTipoConsulta As New ConsultarTipoPaciente()
        consultarTipoConsulta.ShowDialog(Me)
    End Sub

    Private Sub EspecialidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EspecialidadToolStripMenuItem.Click
        Dim espcialidad As New ConsultarEspecialidad()
        espcialidad.ShowDialog()
    End Sub

End Class