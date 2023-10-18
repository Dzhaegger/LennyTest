Public Class Form1
    Dim x As Integer
    Dim y As Integer
    Dim newx As Integer
    Dim newy As Integer
    Dim mouseDown As Boolean = False
    Dim emojis As List(Of String) = New List(Of String) From {"( ͡° ͜ʖ ͡°)", "( ͠° ͟ʖ ͡°)", "( ͡~ ͜ʖ ͡°)", "( ͡ʘ ͜ʖ ͡ʘ)", "( ͡o ͜ʖ ͡o)", "( ͡☉ ͜ʖ ͡☉)", "(ง ͠° ͟ل͜ ͡°)ง", "(͡ ͡° ͜ つ ͡͡°)", "( ͡°╭͜ʖ╮͡° )", "( ͡◉ ͜ʖ ͡◉)"}
    Dim clickCounter As Integer = 0

    Private Sub PanelSuperior_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelSuperior.MouseDown
        If e.Button = MouseButtons.Left Then
            x = Control.MousePosition.X - Me.Location.X
            y = Control.MousePosition.Y - Me.Location.Y
            mouseDown = True
        End If
    End Sub

    Private Sub PanelSuperior_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelSuperior.MouseMove
        If mouseDown Then
            newx = Control.MousePosition.X - x
            newy = Control.MousePosition.Y - y
            Me.Location = New Point(newx, newy)
        End If
    End Sub

    Private Sub PanelSuperior_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelSuperior.MouseUp
        mouseDown = False
    End Sub

    Private Sub btnTestClick_MouseDown(sender As Object, e As MouseEventArgs) Handles btnTestClick.MouseDown
        If e.Button = MouseButtons.Left Then
            If clickCounter < emojis.Count Then
                Lenny.Text = emojis(clickCounter)
                clickCounter += 1
            Else
                Lenny.Text = "No more lenny faces!"
            End If
        ElseIf e.Button = MouseButtons.Right Then
            Dim menuForm As New MenuRightClick()
            menuForm.Show()
        ElseIf e.Button = MouseButtons.Middle Then
            Dim result As DialogResult = MessageBox.Show("¿Deseas resetear?", "Resetear Caras de Lenny", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                ' Restablecer las caras de Lenny
                clickCounter = 0
                Lenny.Text = ""
            End If
        End If
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub btnminimizar_Click(sender As Object, e As EventArgs) Handles btnminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
