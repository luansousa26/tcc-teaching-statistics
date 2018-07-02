Public Class historia

    Private Sub historia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'SE FOR IGUAL A 1 ABRE A HISTORIA DO RIACHO
        If fases.controle.Text.Equals("1") Then

            Me.BackgroundImage = My.Resources.seuari

            'SE FOR IGUAL A 2 ABRE A HISTORIA DO POMAR
        ElseIf fases.controle.Text.Equals("2") Then

            Me.BackgroundImage = My.Resources.farmer_pomar

            'SE FOR IGUAL A 3 ABRE A HISTORIA DA FLORESTA
        ElseIf fases.controle.Text.Equals("3") Then

            Me.BackgroundImage = My.Resources.farmer_floresta

            'SE FOR IGUAL A 4 ABRE A HISTORIA DA CABANA
        ElseIf fases.controle.Text.Equals("4") Then

            Me.BackgroundImage = My.Resources.farmer_cabana ' tela cabana

            'SE FOR IGUAL A 5 ABRE A HISTORIA DO GALINHEIRO
        ElseIf fases.controle.Text.Equals("5") Then

            Me.BackgroundImage = My.Resources.farmer_galinheiro ' tela galinheiro

            'SE FOR IGUAL A 6 ABRE A HISTORIA DA PLANTAÇÃO
        ElseIf fases.controle.Text.Equals("6") Then

            Me.BackgroundImage = My.Resources.farmer_plantacao ' tela galinheiro

        ElseIf fases.controle.Text.Equals("ajuda") Then

            avancar.Visible = False
            avancar1.Visible = False

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        avancar.Visible = False
        avancar1.Visible = True
        Me.BackgroundImage = My.Resources.imagens1

    End Sub

    Private Sub avancar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        If fases.controle.Text.Equals("1") Then
            riacho.Visible = True
            Me.Close()

        ElseIf fases.controle.Text.Equals("2") Then

            pomar.Visible = True
            Me.Close()

        ElseIf fases.controle.Text.Equals("3") Then

            arvores.Visible = True
            Me.Close()

        ElseIf fases.controle.Text.Equals("4") Then

            cabana.Visible = True
            Me.Close()

        ElseIf fases.controle.Text.Equals("5") Then

            galinheiro.Visible = True
            Me.Close()

        ElseIf fases.controle.Text.Equals("6") Then

            plantacao.Visible = True
            Me.Close()

        End If

    End Sub

    Private Sub botao_fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub botao_encerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        altera_tamanho()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botao_fechar.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles avancar1.Click
        If fases.controle.Text.Equals("1") Then
            riacho.Visible = True
            Me.Close()

        ElseIf fases.controle.Text.Equals("2") Then

            pomar.Visible = True
            Me.Close()

        ElseIf fases.controle.Text.Equals("3") Then

            arvores.Visible = True
            Me.Close()

        ElseIf fases.controle.Text.Equals("4") Then

            cabana.Visible = True
            Me.Close()

        ElseIf fases.controle.Text.Equals("5") Then

            galinheiro.Visible = True
            Me.Close()

        ElseIf fases.controle.Text.Equals("6") Then

            plantacao.Visible = True
            Me.Close()

        End If

    End Sub

    Private Sub PictureBox1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles avancar.Click
        avancar.Visible = False
        avancar1.Visible = True
        Me.BackgroundImage = My.Resources.imagens1
    End Sub
End Class