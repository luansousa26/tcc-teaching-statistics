Public Class riacho
    Dim valor As Integer
    Dim total As Integer
    Dim total_numeros As Integer
    Dim porcentagem_total As Double
    Dim porcentagem As Double
    Dim media_porcentagem As Double
    Dim total_final As Double
    Dim porcentagem_final As Double
    Dim total_branco As Double
    ' validação
    Dim valida As Double
    Dim valida2 As Double
    Dim vinteporcento As Double

   
  



    Private Sub voltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        fases.Visible = True
        Me.Close()
    End Sub

    Private Sub riacho_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        valor_media.Text = ""
        media.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub r1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub t1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    

    Private Sub t1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t1.TextChanged

    End Sub

    Private Sub painelriacho_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles painelriacho.MouseLeave

    End Sub

    Private Sub painelriacho_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles painelriacho.Paint

    End Sub

    Private Sub riacho_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave

    End Sub


    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        altera_tamanho()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        fases.Visible = True
    End Sub

   


    Private Sub riacho_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove


    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)



    End Sub

    

    Private Sub iniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        historia.Size = New Size(800, 600)
        historia.botao_fechar.Location = New Point(715, 8)
        fases.controle.Text = "ajuda"
        historia.BackgroundImage = My.Resources.imagens1
        historia.WindowState = FormWindowState.Normal
        historia.Visible = True
    End Sub

    Private Sub botao_fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub encerrararvores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        altera_tamanho()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salvar.Click
        Dim contador As Integer

        Dim t As New Random


        On Error GoTo error1

        For i = 0 To 4 Step 1

            ' variável que deixa as telas aleátorias
            contador = t.Next(0, 9)
        Next


        ' IF que dependendo do valor da váriavel acima chama a imagem correspondente
        If contador.Equals(0) Then

            Me.BackgroundImage = My.Resources.quadrado1

        ElseIf contador.Equals(1) Then
            Me.BackgroundImage = My.Resources.quadrado2

        ElseIf contador.Equals(2) Then
            Me.BackgroundImage = My.Resources.quadrado3

        ElseIf contador.Equals(3) Then
            Me.BackgroundImage = My.Resources.quadrado4

        ElseIf contador.Equals(4) Then
            Me.BackgroundImage = My.Resources.quadrado5

        ElseIf contador.Equals(5) Then
            Me.BackgroundImage = My.Resources.quadrado6

        ElseIf contador.Equals(6) Then
            Me.BackgroundImage = My.Resources.quadrado7

        ElseIf contador.Equals(7) Then
            Me.BackgroundImage = My.Resources.quadrado8

        ElseIf contador.Equals(8) Then
            Me.BackgroundImage = My.Resources.quadrado9

        End If

        ' Fim do IF das imagens


        ' valor digitado pelo usuário sendo passado para inteiro
        valor = Integer.Parse(t1.Text)
        ' soma dos valores inseridos pelo usuário


        total = total + valor

        ' calculo do valor da porcentagem sendo valor*100\12 (12 é o valor de campos da tabela)
        porcentagem = Format((valor * 100) / 12, "0.00")

        ' soma dos valores da porcentagem
        porcentagem_total = porcentagem_total + porcentagem

        ' Valores sendo iseridos na Richtext
        r1.Text = t1.Text & " ---------->" & porcentagem & "%" & vbCrLf & r1.Text
        t1.Text = ""



        ' soma o total de vezes que o usuário inseriu os numeros, ou seja, não pode ser maior que 7 vezes, se for maior o botão é desativado.
        total_numeros = total_numeros + 1


        If total_numeros.Equals(7) Then
            ' Desativa o botão se o total_numeros=7
            valor_media.Text = valor_media.Text & valor
            salvar.Enabled = False
            media.Enabled = True
            salvar.Enabled = False


        Else
            valor_media.Text = valor_media.Text & valor & "+"
        End If


        'pega o valor total de peixes brancos do modulo
        total_branco = Integer.Parse(peixe_brancovalor.Text)

        ' faz o cálculo final para saber a porcentagem de peixes brancos
        total_final = Format((total_branco * 100) / 144, "0.00")





        Exit Sub

        ' Tratativa de erros 
error1:
        MsgBox("Insira apenas numeros inteiros, ou seja, não coloque letras nem numeros quebrados nesse campo!", vbOKOnly, " Aviso de erro")
        t1.Text = ""


    End Sub

    Private Sub PictureBox2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        t1.Text = ""
        r1.Text = ""
        salvar.Enabled = True
        total_numeros = 0
        valor = 0
        porcentagem = 0
        porcentagem_total = 0
        porcentagem_final = 0
        valor_media.Text = ""
        total_final = 0
        total_numeros = 0
        media.Enabled = False

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles media.Click
        ' total dividido pelo número de vezes que foi contado.
        media_porcentagem = Format(porcentagem_total / 7, "0.00")

        valor_media.Text = valor_media.Text & "=" & porcentagem_total & " /7 =" & media_porcentagem


        porcentagem_final = Format((media_porcentagem * 144) / 100, "0")

        vinteporcento = calculo_20porcento(total_branco)

        cento.Text = vinteporcento
        resultado.Text = valida_valores(porcentagem_final, total_branco, vinteporcento)
    End Sub

    Private Sub PictureBox3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Close()
        fases.Visible = True
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        altera_tamanho()
    End Sub

    Private Sub valor_media_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles valor_media.Click

    End Sub
End Class