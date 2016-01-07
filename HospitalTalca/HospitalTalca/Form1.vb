Imports System.Data
Imports System.Data.OleDb
Imports HospitalTalca.BsnUsuario
Imports HospitalTalca.FrnMenuPrincipal

Public Class FrnLogin
    Dim bsnUsuario As New BsnUsuario()

    Private Sub Form1_load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TxtUser.Text = ""
        TxtPass.Text = ""
    End Sub

    Private Sub BotonSalir_Click(sender As System.Object, e As System.EventArgs) Handles BtnSalir.Click
        Application.Exit()
    End Sub

    Private Sub BotonAceptar_Click(sender As System.Object, e As System.EventArgs) Handles BtnAceptar.Click
        Dim usuario As New Usuario(TxtUser.Text, TxtPass.Text)
        Dim formPrincipal As New FrnMenuPrincipal(Me, usuario)


        If bsnUsuario.ValidarUsuario(usuario) Then
            Me.Hide()
            formPrincipal.Show()
        Else
            MsgBox("El usuario no existe ", MsgBoxStyle.Information, "Alerta")
        End If
    End Sub


End Class
