

Public Class fases


    Private Sub fases_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tinicial.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Iniciarriacho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        riacho.painelriacho.Location = New Point(775, 238)
        insere_riacho()
        controle.Text = "1"
        historia.Visible = True





    End Sub

    Private Sub Iniciarpomar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        insere_pomar()
        controle.Text = "2"
        historia.Visible = True




    End Sub

    Private Sub IniciarFloresta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        insere_arvores()
        controle.Text = "3"
        historia.Visible = True


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        insere_plantacao()
        controle.Text = "6"
        historia.Visible = True

    End Sub

    Private Sub QuartoInicial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        insere_cabana()
        controle.Text = "4"
        historia.Visible = True



    End Sub

    Private Sub InicialGalinheiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        insere_galinheiro()
        controle.Text = "5"
        historia.Visible = True

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        altera_tamanho()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles encerrar.Click
        altera_tamanho()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iniciargalinheiro.Click
        insere_galinheiro()
        controle.Text = "5"
        historia.Visible = True
    End Sub

    Private Sub iniciarriacho_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iniciarriacho.Click
        insere_riacho()
        controle.Text = "1"
        historia.Visible = True
    End Sub

    Private Sub iniciarpomar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iniciarpomar.Click
        insere_pomar()
        controle.Text = "2"
        historia.Visible = True
    End Sub

    Private Sub iniciarfloresta_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iniciarfloresta.Click
        insere_arvores()
        controle.Text = "3"
        historia.Visible = True
    End Sub

    Private Sub iniciarcabana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iniciarcabana.Click
        insere_cabana()
        controle.Text = "4"
        historia.Visible = True
    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iniciarplantação.Click, iniciarplantação.Click
        insere_plantacao()
        controle.Text = "6"
        historia.Visible = True
    End Sub
End Class