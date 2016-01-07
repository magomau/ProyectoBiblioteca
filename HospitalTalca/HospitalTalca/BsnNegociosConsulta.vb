Imports HospitalTalca.Consultas
Imports HospitalTalca.DaoDatos
Imports System.Math

Public Class BsnNegociosConsulta

    Dim daoDatos As New DaoDatos()

    Function GetConsultas()

        Return daoDatos.GetConsultas()

    End Function

    Function GetConsultasTipo()

        Return daoDatos.GetConsultasTipo()

    End Function

    Function GetConsultasEspecialidad()

        Return daoDatos.GetConsultasEspecilidad()

    End Function

    Function GetDatosDeConsultas(ByVal consultas As Consultas, ByVal IdPaciente As String)

        Return daoDatos.GetDatosDeConsultas(consultas, IdPaciente)

    End Function

    Function InsertarConsultas(ByVal consultas As Consultas)

        Return daoDatos.InsertarConsultas(consultas)

    End Function

    Function EliminarConsulta(ByVal consultas As Consultas)

        Return daoDatos.EliminarConsulta(consultas)

    End Function

    Function ModificarConsulta(ByVal consultas As Consultas)

        Return daoDatos.ModificarConsultas(consultas)

    End Function


End Class
