Imports HospitalTalca.Paciente
Imports HospitalTalca.DaoDatos
Imports System.Math

Public Class BsnNegocio

    Dim daoDatos As New DaoDatos()

    Function GetPaciente()

        Return daoDatos.GetPaciente()

    End Function

    Function GetDatosDeAlumno(paciente As Paciente, rut As String)

        Return daoDatos.GetDatosDePaciente(paciente, rut)

    End Function

    Function InsertarConsultas(ByVal paciente As Paciente)

        Return daoDatos.InsertarPaciente(paciente)

    End Function

End Class
