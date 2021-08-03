Public Class FrmEmpleado
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim empleado As Classe_Empleado = New Classe_Empleado
        empleado.TipoEmpleado = CBOEMPLEADO.Text
        empleado.ApellidoPaterno = TxtPaterno.Text
        empleado.ApellidoMaterno = TxtMaterno.Text
        empleado.NumeroSeguroSocial = Seguro.Text
        empleado.TipoContrato = CboxContra.Text

        empleado.CalcularElSueldo(400)
        empleado.GenerarCedula()
        DataEmpleado.Rows.Insert(0, empleado.TipoEmpleado, empleado.Cedula, empleado.ApellidoPaterno, empleado.ApellidoMaterno, empleado.NumeroSeguroSocial, empleado.TipoContrato, empleado.Sueldo)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TxtPaterno.Clear()
        TxtMaterno.Clear()
        Seguro.Clear()


    End Sub
End Class