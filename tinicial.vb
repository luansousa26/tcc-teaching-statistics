Imports System.Runtime.InteropServices

Public Class tinicial



Private Sub tinicial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

End Sub

    Private Sub Tela_inicial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        organiza_botoes()


        Dim altura_tela As Double
        Dim largura_tela As Double

        largura_tela = Screen.PrimaryScreen.Bounds.Width
        altura_tela = Screen.PrimaryScreen.Bounds.Height

        altura.Text = altura_tela
        largura.Text = largura_tela



        fases.Visible = True
        changeRes(1024, 768)



    End Sub

    Private Sub botao_fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botao_fechar.Click
        Application.Exit()
    End Sub
End Class
