Public Class Classe_Persona
    'Atributos
    Public ApellidoPaterno As String
    Public ApellidoMaterno As String
    Public NumeroSeguroSocial As String
    Public Sexo As String
    Public Cedula As String
    'Propiedades
    Public Property ApellidoP As String
        Get
            Return ApellidoPaterno
        End Get
        Set(value As String)
            ApellidoPaterno = value
        End Set
    End Property
    Public Property ApellidoM As String
        Get
            Return ApellidoMaterno
        End Get
        Set(value As String)
            ApellidoMaterno = value
        End Set
    End Property
    Public Property NumeSeguro As String
        Get
            Return NumeroSeguroSocial
        End Get
        Set(value As String)
            NumeroSeguroSocial = value
        End Set
    End Property
    Public Property SEX As String
        Get
            Return Sexo
        End Get
        Set(value As String)
            Sexo = value
        End Set
    End Property
    Public Property CedID As String
        Get
            Return Cedula
        End Get
        Set(value As String)
            Cedula = value
        End Set
    End Property
End Class

