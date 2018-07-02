Public Class plantacao

    Dim valor As Integer
    Dim total As Integer
    Dim total_numeros As Integer
    Dim porcentagem_total As Double
    Dim porcentagem As Double
    Dim total_cenouras As Integer
    Dim total_final As Double

    Dim vinteporcento As Double
    Dim porcentagem_final As Double
    Dim media_porcentagem As Double
    Dim valida As Double
    Dim valida2 As Double

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        fases.Visible = True
        Me.Close()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        valor_media.Text = ""
        media.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cenoura.Click

    End Sub

    Private Sub beterraba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beterraba.Click

    End Sub

   
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        t1.Text = ""
        r1.Text = ""
        salvar.Enabled = True
        media.Enabled = False
        total_numeros = 0
        valor = 0
        porcentagem = 0
        porcentagem_total = 0
        total_numeros = 0
        valor_media.Text = ""

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        media_porcentagem = Format(porcentagem_total / 5, "0.00")



        porcentagem_final = Format((media_porcentagem * 168) / 100, "0")
        vinteporcento = calculo_20porcento(total_cenouras)
        resultado.Text = valida_valores(porcentagem_final, total_cenouras, vinteporcento)





    End Sub

    Private Sub encerrarcabana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        altera_tamanho()
    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        ajuda()
    End Sub

    Private Sub encerrararvores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        altera_tamanho()
    End Sub

    Private Sub botao_fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        fases.Visible = True
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salvar.Click
        Dim contador As Integer

        Dim t As New Random


        For i = 0 To 4 Step 1
            contador = t.Next(0, 10)
        Next




        If contador.Equals(0) Then

            Me.BackgroundImage = My.Resources.plantacao_quadrado1

        ElseIf contador.Equals(1) Then
            Me.BackgroundImage = My.Resources.plantacao_quadrado2

        ElseIf contador.Equals(2) Then
            Me.BackgroundImage = My.Resources.plantacao_quadrado3

        ElseIf contador.Equals(3) Then
            Me.BackgroundImage = My.Resources.plantacao_quadrado4

        ElseIf contador.Equals(4) Then
            Me.BackgroundImage = My.Resources.plantacao_quadrado5

        ElseIf contador.Equals(5) Then
            Me.BackgroundImage = My.Resources.plantacao_quadrado6

        ElseIf contador.Equals(6) Then
            Me.BackgroundImage = My.Resources.plantacao_quadrado7

        ElseIf contador.Equals(7) Then
            Me.BackgroundImage = My.Resources.plantacao_quadrado8

        ElseIf contador.Equals(8) Then
            Me.BackgroundImage = My.Resources.plantacao_quadrado9


        End If




        On Error GoTo error1

        ' valor digitado pelo usuário sendo passado para inteiro
        valor = Integer.Parse(t1.Text)
        ' soma dos valores inseridos pelo usuário
        total = total + valor

        ' calculo do valor da porcentagem sendo valor*100\16 (16 é o valor de campos da tabela)
        porcentagem = Format((valor * 100) / 16, "0.00")

        ' soma dos valores da porcentagem
        porcentagem_total = porcentagem_total + porcentagem

        ' Valores sendo iseridos na Richtext
        r1.Text = t1.Text & " ---------->" & porcentagem & "%" & vbCrLf & r1.Text
        t1.Text = ""



        ' soma o total de vezes que o usuário inseriu os numeros, ou seja, não pode ser maior que 8 vezes, se for maior o botão é desativado.
        total_numeros = total_numeros + 1


        If total_numeros.Equals(8) Then
            ' Desativa o botão se o total_numeros=8
            salvar.Enabled = False
            Media.Enabled = True
            valor_media.Text = valor_media.Text & valor
        Else

            valor_media.Text = valor_media.Text & valor & "+"
        End If

        total_cenouras = Integer.Parse(cenouras.Text)
        total_final = Format((total_cenouras * 100) / 168, "0.00")

        Exit Sub

        ' Tratativa de erros 
error1:
        MsgBox("Insira apenas numeros inteiros, ou seja, não coloque letras nem numeros quebrados nesse campo!", vbOKOnly, " Aviso de erro")
        t1.Text = ""




    End Sub

    Private Sub apagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        t1.Text = ""
        r1.Text = ""
        salvar.Enabled = True
        Media.Enabled = False
        total_numeros = 0
        valor = 0
        porcentagem = 0
        porcentagem_total = 0
        total_numeros = 0
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles media.Click
        ' total da porcentagem divido pelo número de vezes que foi contado.
        media_porcentagem = Format(porcentagem_total / 8, "0.00")




        porcentagem_final = Format((media_porcentagem * 168) / 100, "0")
        vinteporcento = calculo_20porcento(total_cenouras)
        resultado.Text = valida_valores(porcentagem_final, total_cenouras, vinteporcento)
        resposta.Text = "Calculando a média... " & vbCrLf & valor_media.Text & "=" & total & " /8 =" & total / 8 & vbCrLf & " Isso que quer dizer que: " & total / 8 & " Equivale a " & media_porcentagem & "% das cenouras da plantação" & vbCrLf & "De acordo com os seus cálculos há no total " & porcentagem_final & " cenouras na plantação." & vbCrLf & resultado.Text & vbCrLf & " Agora Você pode clicar no botão apagar e refazer a fase ou voltar e escolher " & vbCrLf & "outra fase."
        painel_resposta.Visible = True
    End Sub

    Private Sub PictureBox2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
        fases.Visible = True
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        altera_tamanho()
    End Sub

    Private Sub painel_resposta_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles painel_resposta.Paint

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        painel_resposta.Visible = False
    End Sub
End Class