Public Class pomar
     Dim valor As Integer
    Dim total As Integer
    Dim total_numeros As Integer
    Dim porcentagem_total As Double
    Dim porcentagem As Double
    Dim total_macabix As Integer
    Dim total_final As Double
    Dim vinteporcento As Double
    Dim media_porcentagem As Double
    Dim porcentagem_final As Double
    Dim valida As Double
    Dim valida2 As Double

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        fases.Visible = True
        Me.Close()

    End Sub

    Private Sub pomar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub pomar_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        media.Enabled = False
        valor_media.Text = ""
    End Sub
   
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Button2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        altera_tamanho()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        fases.Visible = True

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

   




    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        ajuda()
    End Sub

    Private Sub botao_fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub encerrararvores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        altera_tamanho()

    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Me.Close()
        fases.Visible = True
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salvar.Click
        Dim contador As Integer

        Dim t As New Random

        For i = 0 To 4 Step 1

            contador = t.Next(0, 13)
        Next


        On Error GoTo error1

        If contador.Equals(0) Then

            Me.BackgroundImage = My.Resources.pomar_quadrado1

        ElseIf contador.Equals(1) Then
            Me.BackgroundImage = My.Resources.pomar_quadrado2

        ElseIf contador.Equals(2) Then
            Me.BackgroundImage = My.Resources.pomar_quadrado3

        ElseIf contador.Equals(3) Then
            Me.BackgroundImage = My.Resources.pomar_quadrado4

        ElseIf contador.Equals(4) Then
            Me.BackgroundImage = My.Resources.pomar_quadrado5

        ElseIf contador.Equals(5) Then
            Me.BackgroundImage = My.Resources.pomar_quadrado6

        ElseIf contador.Equals(6) Then
            Me.BackgroundImage = My.Resources.pomar_quadrado7

        ElseIf contador.Equals(7) Then
            Me.BackgroundImage = My.Resources.pomar_quadrado8

        ElseIf contador.Equals(8) Then
            Me.BackgroundImage = My.Resources.pomar_quadrado9

        ElseIf contador.Equals(9) Then
            Me.BackgroundImage = My.Resources.pomar_quadrado10

        ElseIf contador.Equals(10) Then
            Me.BackgroundImage = My.Resources.pomar_quadrado11

        ElseIf contador.Equals(11) Then
            Me.BackgroundImage = My.Resources.pomar_quadrado12

        End If


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



        ' soma o total de vezes que o usuário inseriu os numeros, ou seja, não pode ser maior que 7 vezes, se for maior o botão é desativado.
        total_numeros = total_numeros + 1


        If total_numeros.Equals(7) Then
            ' Desativa o botão se o total_numeros=7
            valor_media.Text = valor_media.Text & valor
            salvar.Enabled = False
            media.Enabled = True

        Else
            valor_media.Text = valor_media.Text & valor & "+"
        End If

        total_macabix = Integer.Parse(macabixada.Text)
        total_final = Format((total_macabix * 100) / 153, "0.00")

        Exit Sub

        ' Tratativa de erros 
error1:
        MsgBox("Insira apenas numeros inteiros, ou seja, não coloque letras nem numeros quebrados nesse campo!", vbOKOnly, " Aviso de erro")
        t1.Text = ""



    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles apagar.Click
        t1.Text = ""
        r1.Text = ""
        total = 0
        valor = 0
        porcentagem = 0
        porcentagem_total = 0
        salvar.Enabled = True
        media.Enabled = False
        valor_media.Text = ""


        total_numeros = 0
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles media.Click
        media_porcentagem = Format(porcentagem_total / 7, "0.00")


        valor_media.Text = valor_media.Text & "=" & porcentagem_total & " /7 =" & media_porcentagem

        porcentagem_final = Format((media_porcentagem * 153) / 100, "0")



        vinteporcento = calculo_20porcento(total_macabix)
        resposta.Text = valida_valores(porcentagem_final, total_macabix, vinteporcento)
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        altera_tamanho()
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click

    End Sub
End Class