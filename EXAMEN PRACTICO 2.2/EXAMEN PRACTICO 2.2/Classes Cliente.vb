Public Class Classes_Cliente
    Inherits Classe_Persona
    ' Atributos
    Public Categoría As String
    Public CódigoPedido As String

    Public Property categoria As String
        Get
            Return Categoría
        End Get
        Set(value As String)
            Categoría = value
        End Set
    End Property
    Public Property Codigo As String
        Get
            Return CódigoPedido
        End Get
        Set(value As String)
            CódigoPedido = value
        End Set
    End Property

    'Método
    Public Sub generarCodigo()
        If Categoría = "Adulto" Then
            Me.Codigo = "A" & ApellidoPaterno & "0012"
        ElseIf Categoría = "Tercera Edad" Then
            Me.Codigo = "TE" & ApellidoPaterno & "0103"
        End If

    End Sub
End Class
