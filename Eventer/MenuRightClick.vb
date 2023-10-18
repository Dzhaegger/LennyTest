Public Class MenuRightClick
    Private Sub MenuRightClick_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MenuItem1_Click(sender As Object, e As EventArgs) Handles btnItem1.Click
        ' Lógica para la funcionalidad del primer elemento del menú
        MessageBox.Show("Has seleccionado la opción 1 del menú.")
    End Sub

    Private Sub MenuItem2_Click(sender As Object, e As EventArgs) Handles btnItem2.Click
        ' Lógica para la funcionalidad del segundo elemento del menú
        MessageBox.Show("Has seleccionado la opción 2 del menú.")
    End Sub

    Private Sub MenuItem3_Click(sender As Object, e As EventArgs) Handles btnItem3.Click
        ' Lógica para la funcionalidad del tercer elemento del menú
        MessageBox.Show("Has seleccionado la opción 3 del menú.")
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub
End Class
