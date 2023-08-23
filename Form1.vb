Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Static contador As Integer
        contador = (contador + 1) Mod imglst1.Images.Count
        picImagem.Image = imglst1.Images(contador)

    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        If btnIniciar.Text = "Iniciar" Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
            btnIniciar.Text = "Iniciar"
        End If
    End Sub

    Private Sub picImagem_Click(sender As Object, e As EventArgs) Handles picImagem.Click

    End Sub
End Class
