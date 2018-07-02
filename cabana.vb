Public Class cabana
    Dim valor As Integer
    Dim total As Integer
    Dim total_numeros As Integer
    Dim porcentagem_total As Double
    Dim porcentagem As Double
    Dim total_luvas As Integer
    Dim total_final As Double

    Dim vinteporcento As Double
    Dim porcentagem_final As Double
    Dim media_porcentagem As Double
    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        fases.Visible = True
        Me.Close()
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        valor_media.Text = ""
        media.Enabled = False
    End Sub

    


    

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        altera_tamanho()
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        ajuda()
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Close()
        fases.Visible = True
    End Sub

    Private Sub botao_fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub encerrararvores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        altera_tamanho()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salvar.Click
        Dim contador As Integer


        Dim t As New Random
        For i = 0 To 4 Step 1

            contador = t.Next(0, 6)
        Next


        If contador.Equals(0) Then

            Me.BackgroundImage = My.Resources.cabana_quadrado1

        ElseIf contador.Equals(1) Then
            Me.BackgroundImage = My.Resources.cabana_quadrado2

        ElseIf contador.Equals(2) Then
            Me.BackgroundImage = My.Resources.cabana_quadrado3

        ElseIf contador.Equals(3) Then
            Me.BackgroundImage = My.Resources.cabana_quadrado4

        ElseIf contador.Equals(4) Then
            Me.BackgroundImage = My.Resources.cabana_quadrado5

        ElseIf contador.Equals(5) Then
            Me.BackgroundImage = My.Resources.cabana_quadrado6

        End If

        On Error GoTo error1



        ' valor digitado pelo usuário sendo passado para inteiro
        valor = Integer.Parse(t1.Text)
        ' soma dos valores inseridos pelo usuário
        total = total + valor

        ' calculo do valor da porcentagem sendo (valor*100)\6 (6 é o valor de campos da tabela)
        porcentagem = Format((valor * 100) / 6, "0.00")

        ' soma dos valores da porcentagem
        porcentagem_total = porcentagem_total + porcentagem

        ' Valores sendo iseridos na Richtext
        r1.Text = t1.Text & " ---------->" & porcentagem & "%" & vbCrLf & r1.Text
        t1.Text = ""



        ' soma o total de vezes que o usuário inseriu os numeros, ou seja, não pode ser maior que 6 vezes, se for maior o botão é desativado.
        total_numeros = total_numeros + 1


        If total_numeros.Equals(6) Then
            ' Desativa o botão se o total_numeros=6
            salvar.Enabled = False
            media.Enabled = True
            valor_media.Text = valor_media.Text & valor

        Else
            valor_media.Text = valor_media.Text & valor & "+"
        End If

        total_luvas = Integer.Parse(luvas.Text)
        total_final = Format((total_luvas * 100) / 63, "0.00")

        Exit Sub


        ' Tratativa de erros 
error1:
        MsgBox("Insira apenas numeros inteiros, ou seja, não coloque letras nem numeros quebrados nesse campo!", vbOKOnly, " Aviso de erro")
        t1.Text = ""
    End Sub

    Private Sub apagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles apagar.Click
        valor_media.Text = ""
        t1.Text = ""
        r1.Text = ""
        salvar.Enabled = True
        media.Enabled = False
        total_numeros = 0
        valor = 0
        porcentagem = 0
        porcentagem_total = 0
        total_final = 0

        vinteporcento = 0
        porcentagem_final = 0
        media_porcentagem = 0
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles media.Click
        media_porcentagem = Format(porcentagem_total / 6, "0.00")
        porcentagem_final = Format((media_porcentagem * 63) / 100, "0")
        vinteporcento = calculo_20porcento(total_luvas)

        valor_media.Text = valor_media.Text & "=" & porcentagem_total & " /6 =" & media_porcentagem

        'função que valida se os valores estão corretos
        resultado.Text = valida_valores(porcentagem_final, total_luvas, vinteporcento)
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Me.Close()
        fases.Visible = True
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        altera_tamanho()
    End Sub

    Private Sub resultado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resultado.Click

    End Sub
End Class