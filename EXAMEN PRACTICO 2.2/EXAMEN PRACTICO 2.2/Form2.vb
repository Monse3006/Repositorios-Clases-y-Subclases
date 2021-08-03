Public Class FrmCLIENTE
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cliente As Classes_Cliente = New Classes_Cliente
        cliente.ApellidoPaterno = TxtPaterno.Text
        cliente.ApellidoMaterno = TxtMaterno.Text
        cliente.NumeroSeguroSocial = Seguro.Text
        cliente.Cedula = TxtCedula.Text
        cliente.Sexo = CboxSexo.Text
        cliente.Categoría = CboxCategoria.Text

        cliente.generarCodigo()

        DataCliente.Rows.Insert(0, cliente.Codigo, cliente.ApellidoPaterno, cliente.ApellidoMaterno, cliente.Cedula, cliente.Sexo, cliente.Categoría)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TxtPaterno.Clear()
        TxtMaterno.Clear()
        TxtCedula.Clear()
        Seguro.Clear()

    End Sub
End Class