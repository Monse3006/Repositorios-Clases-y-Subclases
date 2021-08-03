Public Class Classe_Empleado
    Inherits Classe_Persona
    ' Atributos
    Public TipoEmpleado As String
    Public TipoContrato As String
    Public Sueldo As Double
    'propiedades
    Public Property TC As String
        Get
            Return TipoContrato
        End Get
        Set(value As String)
            TipoContrato = value
        End Set
    End Property
    Public Property S As Double
        Get
            Return Sueldo
        End Get
        Set(value As Double)
            Sueldo = value
        End Set
    End Property
    Public Property Empleado As String
        Get
            Return TipoEmpleado
        End Get
        Set(value As String)
            TipoEmpleado = value
        End Set
    End Property
    ' Operaciones
    Public Sub CalcularElSueldo(sueldobase As Double)
        If (Me.TipoContrato = "A contrato") Then
            Me.Sueldo = sueldobase + 400
        ElseIf (Me.TipoContrato = "Nombramiento") Then
            Me.Sueldo = sueldobase + 750
        Else
            Me.Sueldo = 0
        End If
    End Sub
    Public Sub GenerarCedula()
        If (Me.TipoEmpleado = "Vendedor") Then
            Me.Cedula = "1803402054"
        ElseIf (Me.TipoEmpleado = "Cajero") Then
            Me.Cedula = "1803622693"
        ElseIf (Me.TipoEmpleado = "Contador") Then
            Me.Cedula = "1804944344"
        End If
    End Sub
End Class
