Imports HospitalTalca.Paciente
Imports HospitalTalca.Consultas
Imports System.IO
Imports System.Data.OleDb
Imports System.Data
Imports HospitalTalca.ConexionBD

Public Class DaoDatos

    Dim conexion As New ConexionBD()

    Function GetPaciente()
        Dim command As New OleDbCommand

        Dim dataset As New DataSet

        command.Connection = conexion.GetConexion()

        conexion.AbrirConexion()
        'Rut, Nombre, Apellido, FechaNacimiento, Telefono
        command.CommandText = "select * from Paciente"
        Dim reader As New OleDbDataAdapter
        reader.SelectCommand = command
        reader.Fill(dataset)

        conexion.CerrarConexion()

        Return dataset.Tables(0)

    End Function

    Function GetDatosDePaciente(paciente As Paciente, rut As String)

        Return paciente
    End Function

    Function PacienteExiste(rut As String)

        Return True
    End Function

    Function InsertarPaciente(paciente As Paciente)


        Dim command As New OleDbCommand
        command.Connection = conexion.GetConexion()

        conexion.AbrirConexion()

        command.CommandText = "Insert into Paciente (Nombre, Apellido, Rut, FechaNacimiento, Telefono) values ('" & paciente.Nombre & "','" & paciente.Apellido & "','" & paciente.Rut & "','" & paciente.FechaNacimiento.ToString() & "'," & paciente.Telefono & ") "
        command.ExecuteNonQuery()

        conexion.CerrarConexion()

        Return paciente

        Return True

    End Function

    Function GetConsultas()
        Dim command As New OleDbCommand

        Dim dataset As New DataSet

        command.Connection = conexion.GetConexion()

        conexion.AbrirConexion()
        'Motivo, Diagnostico, FechaConsulta, IDTipoConsulta, IDEspecialidad, IDPaciente
        command.CommandText = "select * from Consultas"
        Dim reader As New OleDbDataAdapter
        reader.SelectCommand = command
        reader.Fill(dataset)

        conexion.CerrarConexion()

        Return dataset.Tables(0)

    End Function

    Function GetConsultasTipo()
        Dim command As New OleDbCommand

        Dim dataset As New DataSet

        command.Connection = conexion.GetConexion()

        conexion.AbrirConexion()
        'Motivo, Diagnostico, FechaConsulta, IDTipoConsulta, IDEspecialidad, IDPaciente
        command.CommandText = "select * from TipoConsulta"
        Dim reader As New OleDbDataAdapter
        reader.SelectCommand = command
        reader.Fill(dataset)

        conexion.CerrarConexion()

        Return dataset.Tables(0)

    End Function


    Function GetConsultasEspecilidad()
        Dim command As New OleDbCommand

        Dim dataset As New DataSet

        command.Connection = conexion.GetConexion()

        conexion.AbrirConexion()
        'Motivo, Diagnostico, FechaConsulta, IDTipoConsulta, IDEspecialidad, IDPaciente
        command.CommandText = "select * from Especialidad"
        Dim reader As New OleDbDataAdapter
        reader.SelectCommand = command
        reader.Fill(dataset)

        conexion.CerrarConexion()

        Return dataset.Tables(0)

    End Function



    Function GetDatosDeConsultas(ByVal consulta As Consultas, ByVal IdPaciente As String)

        Return consulta
    End Function

    Function consultaExiste(ByVal Id As Integer)

        Return True
    End Function

    Function InsertarConsultas(ByVal consultas As Consultas)

        Dim command As New OleDbCommand
        command.Connection = conexion.GetConexion()

        conexion.AbrirConexion()

        command.CommandText = "Insert into Consultas (Motivo, Diagnostico, FechaConsulta, IDTipoConsulta, IDEspecialidad, IDPaciente) values ('" & consultas.Motivo & "','" & consultas.Diagnostico & "','" & consultas.FechaConsulta.ToString() & "'," & consultas.TipoConsulta & "," & consultas.Especialidad & "," & consultas.IdPaciente & ") "
        command.ExecuteNonQuery()

        conexion.CerrarConexion()
        MessageBox.Show("Consulta Ingresada Exitosamente!!")
        Return consultas

        Return True

    End Function


    Function EliminarConsulta(ByVal consultas As Consultas)


        Dim command As New OleDbCommand
        command.Connection = conexion.GetConexion()

        conexion.AbrirConexion()

        command.CommandText = "Delete from Consultas where ID = " & consultas.ID & ""
        command.ExecuteNonQuery()

        conexion.CerrarConexion()
        'MessageBox.Show("Consulta Eliminar Exitosamente!!")
        Return consultas

        Return True

    End Function

    Function ModificarConsultas(ByVal consultas As Consultas)


        Dim command As New OleDbCommand
        command.Connection = conexion.GetConexion()

        conexion.AbrirConexion()

        'command.CommandText = "Update Consultas set Nombre = '" & consultas.Nombre & "' , Apellido = '" & alumno.Apellido & "', Rut = '" & alumno.Rut & "', FechaNacimiento = '" & alumno.FechaNacimiento.ToString() & "', Genero = " & alumno.Genero & " where ID = " & alumno.ID & ""
        command.ExecuteNonQuery()

        conexion.CerrarConexion()
        ' MessageBox.Show("Consulta Modificar Exitosamente!!")
        Return consultas

        Return True

    End Function


End Class

