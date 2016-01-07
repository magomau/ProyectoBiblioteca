Public Class Consultas

    Protected _id As Integer
    Protected _motivo As String
    Protected _diagnostico As String
    Protected _fechaConsulta As Date
    Protected _tipoConsulta As Integer
    Protected _especialidad As Integer
    Protected _idPaciente As Integer

    Public Property ID As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property Motivo As String
        Get
            Return _motivo
        End Get
        Set(ByVal value As String)
            _motivo = value
        End Set
    End Property

    Public Property Diagnostico As String
        Get
            Return _diagnostico
        End Get
        Set(ByVal value As String)
            _diagnostico = value
        End Set
    End Property

    Public Property FechaConsulta As Date
        Get
            Return _fechaConsulta
        End Get
        Set(ByVal value As Date)
            _fechaConsulta = value
        End Set
    End Property

    Public Property TipoConsulta As Integer
        Get
            Return _tipoConsulta
        End Get
        Set(ByVal value As Integer)
            _tipoConsulta = value
        End Set
    End Property

    Public Property Especialidad As Integer
        Get
            Return _especialidad
        End Get
        Set(ByVal value As Integer)
            _especialidad = value
        End Set
    End Property

    Public Property IdPaciente As Integer
        Get
            Return _idPaciente
        End Get
        Set(ByVal value As Integer)
            _idPaciente = value
        End Set
    End Property


End Class
