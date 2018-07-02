Public Class arvores

    Dim valor As Integer
    Dim total As Integer
    Dim porcentagem_total As Double
    Dim porcentagem As Double
    Dim media_porcentagem As Double
    Dim vinteporcento As Double
    Dim porcentagem_final As Double
    Dim total_roxo As Integer
    Dim total_final As Integer
    Dim valida As Double
    Dim valida2 As Double
    Dim total_numeros As Integer




    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        valor_media.Text = ""
        media.Enabled = False

       
    End Sub

    Private Sub voltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        fases.Visible = True
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        altera_tamanho()
    End Sub

  

    

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        fases.Visible = True

    End Sub



    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        ajuda()
    End Sub

    Private Sub botao_fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub painelarvores_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles painelarvores.Paint

    End Sub

    Private Sub resultado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resultado.Click

    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salvar.Click
        Dim contador As Integer

        Dim t As New Random

        For i = 0 To 4 Step 1
            contador = t.Next(0, 5)
        Next

        If contador.Equals(0) Then

            Me.BackgroundImage = My.Resources.floresta_quadrado1

        ElseIf contador.Equals(1) Then
            Me.BackgroundImage = My.Resources.floresta_quadrado2

        ElseIf contador.Equals(2) Then
            Me.BackgroundImage = My.Resources.floresta_quadrado3

        ElseIf contador.Equals(3) Then
            Me.BackgroundImage = My.Resources.floresta_quadrado4

        ElseIf contador.Equals(4) Then
            Me.BackgroundImage = My.Resources.floresta_quadrado5

        End If

        On Error GoTo error1


        valor = Integer.Parse(t1.Text)

        ' valor inserido pelo usuário dividido por 100 * 9 (número de quadrados)

        porcentagem = Format((valor * 100) / 9, "0.00")

        porcentagem_total = porcentagem_total + porcentagem
        total = total + valor
        p1.Text = porcentagem_total

        r1.Text = t1.Text & " ---------->" & porcentagem & "%" & vbCrLf & r1.Text

        t1.Text = ""
        total_numeros = total_numeros + 1

        If total_numeros.Equals(6) Then
            valor_media.Text = valor_media.Text & valor
            salvar.Enabled = False
            media.Enabled = True

        Else
            valor_media.Text = valor_media.Text & valor & "+"
        End If

        total_roxo = Integer.Parse(passaro_rosa.Text)

        total_final = Format((total_roxo * 100) / 70, "0.00")
        Exit Sub

error1:
        MsgBox("Insira apenas numeros inteiros, ou seja, não coloque letras nem numeros quebrados nesse campo!")
        t1.Text = ""
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles apagar.Click
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
        valor_media.Text = ""
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles media.Click
        'media da porcentagem (valor da porcentagem total divido por 6(número de vezes que foi contado) 

        media_porcentagem = Format(porcentagem_total / 6, "0.00")

        valor_media.Text = valor_media.Text & "=" & porcentagem_total & " /6 =" & media_porcentagem

        porcentagem_final = Format((media_porcentagem * 70) / 100, "0,00")
        vinteporcento = calculo_20porcento(total_roxo)

        resultado.Text = valida_valores(porcentagem_final, total_roxo, vinteporcento)
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Close()
        fases.Visible = True
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        altera_tamanho()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub passaro_azul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles passaro_azul.Click

    End Sub
End Class