Public Class galinheiro
    Dim valor As Integer
    Dim total As Integer
    Dim total_numeros As Integer
    Dim porcentagem_total As Double
    Dim porcentagem As Double
    Dim total_galinhaovos As Integer
    Dim media_porcentagem As Double
    Dim porcentagem_final As Double
    Dim total_final As Integer
    Dim vinteporcento As Double


    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        valor_media.Text = ""
        media.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        fases.Visible = True
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        altera_tamanho()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        fases.Visible = True
        Me.Close()
    End Sub

  

   

    

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        ajuda()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        fases.Visible = True
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salvar.Click
        Dim contador As Integer

        Dim t As New Random

        For i = 0 To 4 Step 1

            contador = t.Next(0, 7)
        Next



        If contador.Equals(0) Then

            Me.BackgroundImage = My.Resources.galinheiro_quadrado1

        ElseIf contador.Equals(1) Then
            Me.BackgroundImage = My.Resources.galinheiro_quadrado2

        ElseIf contador.Equals(2) Then
            Me.BackgroundImage = My.Resources.galinheiro_quadrado3

        ElseIf contador.Equals(3) Then
            Me.BackgroundImage = My.Resources.galinheiro_quadrado4

        ElseIf contador.Equals(4) Then
            Me.BackgroundImage = My.Resources.galinheiro_quadrado5

        ElseIf contador.Equals(5) Then
            Me.BackgroundImage = My.Resources.galinheiro_quadrado6

        End If


        On Error GoTo error1


        ' valor digitado pelo usuário sendo passado para inteiro
        valor = Integer.Parse(t1.Text)
        ' soma dos valores inseridos pelo usuário
        total = total + valor

        ' calculo do valor da porcentagem sendo valor*100\6 (6 é o valor de campos da tabela)
        porcentagem = Format((valor * 100) / 6, "0.00")

        ' soma dos valores da porcentagem
        porcentagem_total = porcentagem_total + porcentagem

        ' Valores sendo iseridos na Richtext
        r1.Text = t1.Text & " ---------->" & porcentagem & "%" & vbCrLf & r1.Text
        t1.Text = ""



        ' soma o total de vezes que o usuário inseriu os numeros, ou seja, não pode ser maior que 5 vezes, se for maior o botão é desativado.
        total_numeros = total_numeros + 1


        If total_numeros.Equals(5) Then
            ' Desativa o botão se o total_numeros=5
            salvar.Enabled = False
            media.Enabled = True
            valor_media.Text = valor_media.Text & valor
        Else
            valor_media.Text = valor_media.Text & valor & "+"
        End If

        total_galinhaovos = Integer.Parse(ninhocom.Text)
        total_final = Format((total_galinhaovos * 100) / 63, "0.00")

        Exit Sub

        ' Tratativa de erros 
error1:
        MsgBox("Insira apenas numeros inteiros, ou seja, não coloque letras nem numeros quebrados nesse campo!", vbOKOnly, " Aviso de erro")
        t1.Text = ""
    End Sub

    Private Sub apagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles apagar.Click
        valor_media.Text = ""
        r1.Text = ""
        t1.Text = ""
        valor = 0
        total = 0
        porcentagem_total = 0
        porcentagem = 0
        media_porcentagem = 0
        porcentagem_final = 0
        total_final = 0
        total_numeros = 0
        salvar.Enabled = True
        media.Enabled = False
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles media.Click
        media_porcentagem = Format(porcentagem_total / 5, "0.00")
        porcentagem_final = Format((media_porcentagem * 63) / 100, "0")

        valor_media.Text = valor_media.Text & "=" & porcentagem_total & " /5 =" & media_porcentagem
        vinteporcento = calculo_20porcento(total_galinhaovos)
        resposta.Text = valida_valores(porcentagem_final, total_galinhaovos, vinteporcento)
    End Sub

    Private Sub PictureBox2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
        fases.Visible = True
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        altera_tamanho()
    End Sub
End Class