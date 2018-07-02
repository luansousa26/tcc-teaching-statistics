
Imports System.Runtime.InteropServices

Public Module resChanger

    Const ENUM_CURRENT_SETTINGS As Integer = -1
    Const CDS_UPDATEREGISTRY As Integer = &H1
    Const CDS_TEST As Long = &H2

    Const CCDEVICENAME As Integer = 32
    Const CCFORMNAME As Integer = 32

    Const DISP_CHANGE_SUCCESSFUL As Integer = 0
    Const DISP_CHANGE_RESTART As Integer = 1
    Const DISP_CHANGE_FAILED As Integer = -1

    Private Declare Function EnumDisplaySettings Lib "user32" Alias "EnumDisplaySettingsA" (ByVal lpszDeviceName As Integer, ByVal iModeNum As Integer, ByRef lpDevMode As DEVMODE) As Integer
    Private Declare Function ChangeDisplaySettings Lib "user32" Alias "ChangeDisplaySettingsA" (ByRef DEVMODE As DEVMODE, ByVal flags As Integer) As Integer

    <StructLayout(LayoutKind.Sequential)> Public Structure DEVMODE
        <MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst:=CCDEVICENAME)> Public dmDeviceName As String
        Public dmSpecVersion As Short
        Public dmDriverVersion As Short
        Public dmSize As Short
        Public dmDriverExtra As Short
        Public dmFields As Integer
        Public dmOrientation As Short
        Public dmPaperSize As Short
        Public dmPaperLength As Short
        Public dmPaperWidth As Short
        Public dmScale As Short
        Public dmCopies As Short
        Public dmDefaultSource As Short
        Public dmPrintQuality As Short
        Public dmColor As Short
        Public dmDuplex As Short
        Public dmYResolution As Short
        Public dmTTOption As Short
        Public dmCollate As Short
        <MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst:=CCFORMNAME)> Public dmFormName As String
        Public dmUnusedPadding As Short
        Public dmBitsPerPel As Short
        Public dmPelsWidth As Integer
        Public dmPelsHeight As Integer
        Public dmDisplayFlags As Integer
        Public dmDisplayFrequency As Integer
    End Structure

    Public Sub changeRes(ByVal theWidth As Integer, ByVal theHeight As Integer)

        Dim DevM As DEVMODE

        DevM.dmDeviceName = New [String](New Char(32) {})
        DevM.dmFormName = New [String](New Char(32) {})
        DevM.dmSize = CShort(Marshal.SizeOf(GetType(DEVMODE)))



        If 0 <> EnumDisplaySettings(Nothing, ENUM_CURRENT_SETTINGS, DevM) Then
            Dim lResult As Integer

            DevM.dmPelsWidth = theWidth
            DevM.dmPelsHeight = theHeight


            lResult = ChangeDisplaySettings(DevM, CDS_TEST)

            If lResult = DISP_CHANGE_FAILED Then
                MsgBox("Display Change Failed.", MsgBoxStyle.OKOnly + MsgBoxStyle.Critical, "Screen Resolution Change Failed")
            Else

                lResult = ChangeDisplaySettings(DevM, CDS_UPDATEREGISTRY)

                Select Case lResult
                    Case DISP_CHANGE_RESTART
                        MsgBox("You must restart your computer to apply these changes.", MsgBoxStyle.OKOnly + MsgBoxStyle.Critical, "Screen Resolution Has Changed")
                    Case DISP_CHANGE_SUCCESSFUL

                    Case Else
                        MsgBox("A mudança falhou.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "A mudança de resolução falhou.")
                End Select
            End If





        End If
    End Sub










End Module


Module Module1

    'funções do programa



    Public Sub altera_tamanho()

        Dim altura As Integer
        Dim largura As Integer

        altura = Integer.Parse(tinicial.altura.Text)
        largura = Integer.Parse(tinicial.largura.Text)
        Application.Exit()
        Call changeRes(largura, altura)

    End Sub

    Public Sub organiza_botoes()

        fases.iniciarriacho.Location = New Point(170, 492)
        fases.iniciarpomar.Location = New Point(331, 320)
        fases.iniciarfloresta.Location = New Point(391, 231)
        fases.iniciarcabana.Location = New Point(770, 357)
        fases.iniciargalinheiro.Location = New Point(717, 516)
        fases.iniciarplantação.Location = New Point(717, 666)
        fases.encerrar.Location = New Point(742, 11)
    End Sub

    Public Sub ajuda()
        historia.Size = New Size(800, 600)
        historia.botao_fechar.Location = New Point(715, 8)

        fases.controle.Text = "ajuda"
        historia.BackgroundImage = My.Resources.imagens1
        historia.WindowState = FormWindowState.Normal
        historia.Visible = True

    End Sub

    Public Function calculo_20porcento(ByVal valor1)
        Dim resultado As Double

        resultado = Format((20 * valor1) / 100, "0.00")
        valor1 = resultado
        MsgBox(valor1, vbOKOnly, "20 por cento")

        Return valor1

    End Function

    Public Function valida_valores(ByVal porcentagem, ByVal total, ByVal desvio)
        Dim resposta As String
        Dim resultadomin As Double
        Dim resultadomax As Double

        resultadomin = total - desvio
        resultadomax = total + desvio

        MsgBox(total, vbOKOnly, "total")
        MsgBox(porcentagem, vbOKOnly, "VALOR DOS CALCULOS")
        MsgBox(resultadomin, vbOKOnly, "valor minimo")
        MsgBox(resultadomax, vbOKOnly, "valor maximo")

        If porcentagem >= resultadomin And porcentagem <= resultadomax Then

            resposta = "Parabéns você acertou"

        Else
            resposta = "Desculpe, o cálculo está errado!"
        End If


        Return resposta
    End Function

    'Fim das funções





    ' tela riacho

    Public Sub insere_riacho()





        ' Variaveis dos peixes
        Dim peixe_azul As Integer
        Dim peixe_laranja As Integer
        Dim peixe_branco As Integer
        Dim peixe_listrado As Integer

        peixe_azul = 0
        peixe_laranja = 0
        peixe_branco = 0
        peixe_listrado = 0



        Dim t As Random = New Random()
        Dim picture As New PictureBox
        Dim picture1 As New PictureBox
        Dim picture2 As New PictureBox
        Dim picture3 As New PictureBox
        Dim picture4 As New PictureBox
        Dim picture5 As New PictureBox
        Dim picture6 As New PictureBox
        Dim picture7 As New PictureBox
        Dim picture8 As New PictureBox
        Dim picture9 As New PictureBox
        Dim picture10 As New PictureBox
        Dim picture11 As New PictureBox

        Dim li1() As PictureBox = {picture, picture1, picture2, picture3, picture4, picture5, picture6, picture7, picture8, picture9, picture10, picture11}

        Dim num As Integer
        num = 49

        For i = 0 To 11 Step 1





            li1(i).Image = riacho.peixe1.Image


            li1(i).Size = New Size(55, 39)

            li1(i).SizeMode = PictureBoxSizeMode.StretchImage


            li1(i).Location = New Point(num, 264)

            li1(i).BackColor = Color.Transparent
            riacho.Controls.Add(li1(i))

            num = num + 55
        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li1(al).Image = riacho.peixe2.Image

        Next



        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li1(al).Image = riacho.peixe4.Image

        Next

        For i = 0 To 10 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li1(al).Image = riacho.peixe3.Image

        Next


        ' for para contagem de peixes
        For i = 0 To 11 Step 1


            If li1(i).Image.Equals(riacho.peixe4.Image) Then

                peixe_azul = peixe_azul + 1

            ElseIf li1(i).Image.Equals(riacho.peixe3.Image) Then

                peixe_branco = peixe_branco + 1

            ElseIf li1(i).Image.Equals(riacho.peixe2.Image) Then

                peixe_listrado = peixe_listrado + 1


            ElseIf li1(i).Image.Equals(riacho.peixe1.Image) Then

                peixe_laranja = peixe_laranja + 1

            End If

        Next


        ' Fim da linha 1



        ' inicio da linha 2
        Dim picture18 As New PictureBox
        Dim picture19 As New PictureBox
        Dim picture20 As New PictureBox
        Dim picture21 As New PictureBox
        Dim picture22 As New PictureBox
        Dim picture23 As New PictureBox
        Dim picture24 As New PictureBox
        Dim picture25 As New PictureBox
        Dim picture26 As New PictureBox
        Dim picture27 As New PictureBox
        Dim picture28 As New PictureBox
        Dim picture29 As New PictureBox

        Dim li2() As PictureBox = {picture18, picture19, picture20, picture21, picture22, picture23, picture24, picture25, picture26, picture27, picture28, picture29}


        Dim num2 As Integer
        num2 = 49

        For i = 0 To 11 Step 1

            li2(i).Image = riacho.peixe1.Image


            li2(i).Size = New Size(55, 39)

            li2(i).SizeMode = PictureBoxSizeMode.StretchImage


            li2(i).Location = New Point(num2, 303)

            li2(i).BackColor = Color.Transparent
            riacho.Controls.Add(li2(i))

            num2 = num2 + 55

        Next

        For i = 0 To 5 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li2(al).Image = riacho.peixe4.Image

        Next



        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li2(al).Image = riacho.peixe2.Image

        Next


        For i = 0 To 10 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li2(al).Image = riacho.peixe3.Image

        Next


        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li2(al).Image = riacho.peixe1.Image

        Next

        ' for para contagem de peixes
        For i = 0 To 11 Step 1


            If li2(i).Image.Equals(riacho.peixe4.Image) Then

                peixe_azul = peixe_azul + 1

            ElseIf li2(i).Image.Equals(riacho.peixe3.Image) Then

                peixe_branco = peixe_branco + 1

            ElseIf li2(i).Image.Equals(riacho.peixe2.Image) Then

                peixe_listrado = peixe_listrado + 1


            ElseIf li2(i).Image.Equals(riacho.peixe1.Image) Then

                peixe_laranja = peixe_laranja + 1

            End If

        Next


        ' inicio da linha 3
        Dim picture36 As New PictureBox
        Dim picture37 As New PictureBox
        Dim picture38 As New PictureBox
        Dim picture39 As New PictureBox
        Dim picture40 As New PictureBox
        Dim picture41 As New PictureBox
        Dim picture42 As New PictureBox
        Dim picture43 As New PictureBox
        Dim picture44 As New PictureBox
        Dim picture45 As New PictureBox
        Dim picture46 As New PictureBox
        Dim picture47 As New PictureBox

        Dim li3() As PictureBox = {picture36, picture37, picture38, picture39, picture40, picture41, picture42, picture43, picture44, picture45, picture46, picture47}


        Dim num3 As Integer
        num3 = 49

        For i = 0 To 11 Step 1

            li3(i).Image = riacho.peixe1.Image


            li3(i).Size = New Size(55, 39)

            li3(i).SizeMode = PictureBoxSizeMode.StretchImage


            li3(i).Location = New Point(num3, 342)

            li3(i).BackColor = Color.Transparent
            riacho.Controls.Add(li3(i))


            num3 = num3 + 55

        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li3(al).Image = riacho.peixe1.Image

        Next


        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li3(al).Image = riacho.peixe4.Image

        Next

        For i = 0 To 10 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li3(al).Image = riacho.peixe3.Image

        Next


        ' for da contagem de peixes
        For i = 0 To 11 Step 1


            If li3(i).Image.Equals(riacho.peixe4.Image) Then

                peixe_azul = peixe_azul + 1

            ElseIf li3(i).Image.Equals(riacho.peixe3.Image) Then

                peixe_branco = peixe_branco + 1

            ElseIf li3(i).Image.Equals(riacho.peixe2.Image) Then

                peixe_listrado = peixe_listrado + 1


            ElseIf li3(i).Image.Equals(riacho.peixe1.Image) Then

                peixe_laranja = peixe_laranja + 1

            End If

        Next

        ' inicio da linha 4
        Dim picture54 As New PictureBox
        Dim picture55 As New PictureBox
        Dim picture56 As New PictureBox
        Dim picture57 As New PictureBox
        Dim picture58 As New PictureBox
        Dim picture59 As New PictureBox
        Dim picture60 As New PictureBox
        Dim picture61 As New PictureBox
        Dim picture62 As New PictureBox
        Dim picture63 As New PictureBox
        Dim picture64 As New PictureBox
        Dim picture65 As New PictureBox

        Dim li4() As PictureBox = {picture54, picture55, picture56, picture57, picture58, picture59, picture60, picture61, picture62, picture63, picture64, picture65}


        Dim num4 As Integer
        num4 = 49

        For i = 0 To 11 Step 1

            li4(i).Image = riacho.peixe3.Image


            li4(i).Size = New Size(55, 39)

            li4(i).SizeMode = PictureBoxSizeMode.StretchImage


            li4(i).Location = New Point(num4, 381)

            li4(i).BackColor = Color.Transparent
            riacho.Controls.Add(li4(i))

            num4 = num4 + 55

        Next

        For i = 0 To 5 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li4(al).Image = riacho.peixe2.Image

        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li4(al).Image = riacho.peixe1.Image

        Next

        For i = 0 To 10 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li4(al).Image = riacho.peixe3.Image

        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li4(al).Image = riacho.peixe4.Image

        Next


        ' for da contagem de peixes
        For i = 0 To 11 Step 1


            If li4(i).Image.Equals(riacho.peixe4.Image) Then

                peixe_azul = peixe_azul + 1

            ElseIf li4(i).Image.Equals(riacho.peixe3.Image) Then

                peixe_branco = peixe_branco + 1

            ElseIf li4(i).Image.Equals(riacho.peixe2.Image) Then

                peixe_listrado = peixe_listrado + 1


            ElseIf li4(i).Image.Equals(riacho.peixe1.Image) Then

                peixe_laranja = peixe_laranja + 1

            End If

        Next

        ' inicio da linha 5
        Dim picture72 As New PictureBox
        Dim picture73 As New PictureBox
        Dim picture74 As New PictureBox
        Dim picture75 As New PictureBox
        Dim picture76 As New PictureBox
        Dim picture77 As New PictureBox
        Dim picture78 As New PictureBox
        Dim picture79 As New PictureBox
        Dim picture80 As New PictureBox
        Dim picture81 As New PictureBox
        Dim picture82 As New PictureBox
        Dim picture83 As New PictureBox

        Dim li5() As PictureBox = {picture72, picture73, picture74, picture75, picture76, picture77, picture78, picture79, picture80, picture81, picture82, picture83}


        Dim num5 As Integer
        num5 = 49

        For i = 0 To 11 Step 1

            li5(i).Image = riacho.peixe1.Image


            li5(i).Size = New Size(55, 39)

            li5(i).SizeMode = PictureBoxSizeMode.StretchImage


            li5(i).Location = New Point(num5, 420)

            li5(i).BackColor = Color.Transparent
            riacho.Controls.Add(li5(i))

            num5 = num5 + 55

        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li5(al).Image = riacho.peixe2.Image

        Next

        For i = 0 To 10 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li5(al).Image = riacho.peixe3.Image

        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li5(al).Image = riacho.peixe4.Image

        Next

        ' for da contagem de peixes
        For i = 0 To 11 Step 1


            If li5(i).Image.Equals(riacho.peixe4.Image) Then

                peixe_azul = peixe_azul + 1

            ElseIf li5(i).Image.Equals(riacho.peixe3.Image) Then

                peixe_branco = peixe_branco + 1

            ElseIf li5(i).Image.Equals(riacho.peixe2.Image) Then

                peixe_listrado = peixe_listrado + 1


            ElseIf li5(i).Image.Equals(riacho.peixe1.Image) Then

                peixe_laranja = peixe_laranja + 1

            End If

        Next






        ' inicio da linha 6


        Dim picture84 As New PictureBox
        Dim picture85 As New PictureBox
        Dim picture86 As New PictureBox
        Dim picture87 As New PictureBox
        Dim picture88 As New PictureBox
        Dim picture89 As New PictureBox
        Dim picture90 As New PictureBox
        Dim picture91 As New PictureBox
        Dim picture92 As New PictureBox
        Dim picture93 As New PictureBox
        Dim picture94 As New PictureBox
        Dim picture95 As New PictureBox

        Dim li6() As PictureBox = {picture84, picture85, picture86, picture87, picture88, picture89, picture90, picture91, picture92, picture93, picture94, picture95}


        Dim num6 As Integer
        num6 = 49

        For i = 0 To 11 Step 1

            li6(i).Image = riacho.peixe1.Image


            li6(i).Size = New Size(55, 39)

            li6(i).SizeMode = PictureBoxSizeMode.StretchImage


            li6(i).Location = New Point(num6, 459)

            li6(i).BackColor = Color.Transparent
            riacho.Controls.Add(li6(i))

            num6 = num6 + 55

        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li6(al).Image = riacho.peixe2.Image

        Next



        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li6(al).Image = riacho.peixe4.Image

        Next

        For i = 0 To 10 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li6(al).Image = riacho.peixe3.Image

        Next

        ' for da contagem de peixes
        For i = 0 To 11 Step 1


            If li6(i).Image.Equals(riacho.peixe4.Image) Then

                peixe_azul = peixe_azul + 1

            ElseIf li6(i).Image.Equals(riacho.peixe3.Image) Then

                peixe_branco = peixe_branco + 1

            ElseIf li6(i).Image.Equals(riacho.peixe2.Image) Then

                peixe_listrado = peixe_listrado + 1


            ElseIf li6(i).Image.Equals(riacho.peixe1.Image) Then

                peixe_laranja = peixe_laranja + 1

            End If

        Next



        ' inicio da linha 7


        Dim picture96 As New PictureBox
        Dim picture97 As New PictureBox
        Dim picture98 As New PictureBox
        Dim picture99 As New PictureBox
        Dim picture100 As New PictureBox
        Dim picture101 As New PictureBox
        Dim picture102 As New PictureBox
        Dim picture103 As New PictureBox
        Dim picture104 As New PictureBox
        Dim picture105 As New PictureBox
        Dim picture106 As New PictureBox
        Dim picture107 As New PictureBox

        Dim li7() As PictureBox = {picture96, picture97, picture98, picture99, picture100, picture101, picture102, picture103, picture104, picture105, picture106, picture107}


        Dim num7 As Integer
        num7 = 49

        For i = 0 To 11 Step 1

            li7(i).Image = riacho.peixe1.Image


            li7(i).Size = New Size(55, 39)

            li7(i).SizeMode = PictureBoxSizeMode.StretchImage


            li7(i).Location = New Point(num7, 498)

            li7(i).BackColor = Color.Transparent
            riacho.Controls.Add(li7(i))

            num7 = num7 + 55

        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li7(al).Image = riacho.peixe2.Image

        Next



        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li7(al).Image = riacho.peixe4.Image

        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li7(al).Image = riacho.peixe1.Image

        Next

        For i = 0 To 10 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li7(al).Image = riacho.peixe3.Image

        Next


        ' for da contagem de peixes
        For i = 0 To 11 Step 1


            If li7(i).Image.Equals(riacho.peixe4.Image) Then

                peixe_azul = peixe_azul + 1

            ElseIf li7(i).Image.Equals(riacho.peixe3.Image) Then

                peixe_branco = peixe_branco + 1

            ElseIf li7(i).Image.Equals(riacho.peixe2.Image) Then

                peixe_listrado = peixe_listrado + 1


            ElseIf li7(i).Image.Equals(riacho.peixe1.Image) Then

                peixe_laranja = peixe_laranja + 1

            End If

        Next



        ' inicio da linha 8


        Dim picture108 As New PictureBox
        Dim picture109 As New PictureBox
        Dim picture110 As New PictureBox
        Dim picture111 As New PictureBox
        Dim picture112 As New PictureBox
        Dim picture113 As New PictureBox
        Dim picture114 As New PictureBox
        Dim picture115 As New PictureBox
        Dim picture116 As New PictureBox
        Dim picture117 As New PictureBox
        Dim picture118 As New PictureBox
        Dim picture119 As New PictureBox

        Dim li8() As PictureBox = {picture108, picture109, picture110, picture111, picture112, picture113, picture114, picture115, picture116, picture117, picture118, picture119}


        Dim num8 As Integer
        num8 = 49

        For i = 0 To 11 Step 1

            li8(i).Image = riacho.peixe4.Image


            li8(i).Size = New Size(55, 39)

            li8(i).SizeMode = PictureBoxSizeMode.StretchImage


            li8(i).Location = New Point(num8, 537)

            li8(i).BackColor = Color.Transparent
            riacho.Controls.Add(li8(i))

            num8 = num8 + 55

        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li8(al).Image = riacho.peixe2.Image

        Next

        For i = 0 To 10 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li8(al).Image = riacho.peixe3.Image

        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li8(al).Image = riacho.peixe1.Image

        Next


        ' for da contagem de peixes
        For i = 0 To 11 Step 1


            If li8(i).Image.Equals(riacho.peixe4.Image) Then

                peixe_azul = peixe_azul + 1

            ElseIf li8(i).Image.Equals(riacho.peixe3.Image) Then

                peixe_branco = peixe_branco + 1

            ElseIf li8(i).Image.Equals(riacho.peixe2.Image) Then

                peixe_listrado = peixe_listrado + 1


            ElseIf li8(i).Image.Equals(riacho.peixe1.Image) Then

                peixe_laranja = peixe_laranja + 1

            End If

        Next




        ' inicio da linha 9


        Dim picture120 As New PictureBox
        Dim picture121 As New PictureBox
        Dim picture122 As New PictureBox
        Dim picture123 As New PictureBox
        Dim picture124 As New PictureBox
        Dim picture125 As New PictureBox
        Dim picture126 As New PictureBox
        Dim picture127 As New PictureBox
        Dim picture128 As New PictureBox
        Dim picture129 As New PictureBox
        Dim picture130 As New PictureBox
        Dim picture131 As New PictureBox

        Dim li9() As PictureBox = {picture120, picture121, picture122, picture123, picture124, picture125, picture126, picture127, picture128, picture129, picture130, picture131}


        Dim num9 As Integer
        num9 = 49

        For i = 0 To 11 Step 1

            li9(i).Image = riacho.peixe2.Image


            li9(i).Size = New Size(55, 39)

            li9(i).SizeMode = PictureBoxSizeMode.StretchImage


            li9(i).Location = New Point(num9, 576)

            li9(i).BackColor = Color.Transparent
            riacho.Controls.Add(li9(i))

            num9 = num9 + 55

        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li9(al).Image = riacho.peixe4.Image

        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li9(al).Image = riacho.peixe1.Image

        Next

        For i = 0 To 10 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li9(al).Image = riacho.peixe3.Image

        Next

        ' for da contagem de peixes
        For i = 0 To 11 Step 1


            If li9(i).Image.Equals(riacho.peixe4.Image) Then

                peixe_azul = peixe_azul + 1

            ElseIf li9(i).Image.Equals(riacho.peixe3.Image) Then

                peixe_branco = peixe_branco + 1

            ElseIf li9(i).Image.Equals(riacho.peixe2.Image) Then

                peixe_listrado = peixe_listrado + 1


            ElseIf li9(i).Image.Equals(riacho.peixe1.Image) Then

                peixe_laranja = peixe_laranja + 1

            End If



        Next





        ' inicio da linha 10


        Dim picture132 As New PictureBox
        Dim picture133 As New PictureBox
        Dim picture134 As New PictureBox
        Dim picture135 As New PictureBox
        Dim picture136 As New PictureBox
        Dim picture137 As New PictureBox
        Dim picture138 As New PictureBox
        Dim picture139 As New PictureBox
        Dim picture140 As New PictureBox
        Dim picture141 As New PictureBox
        Dim picture142 As New PictureBox
        Dim picture143 As New PictureBox


        Dim li10() As PictureBox = {picture132, picture133, picture134, picture135, picture136, picture137, picture138, picture139, picture140, picture141, picture142, picture143}


        Dim num10 As Integer
        num10 = 49

        For i = 0 To 11 Step 1

            li10(i).Image = riacho.peixe2.Image


            li10(i).Size = New Size(55, 39)

            li10(i).SizeMode = PictureBoxSizeMode.StretchImage


            li10(i).Location = New Point(num10, 615)

            li10(i).BackColor = Color.Transparent
            riacho.Controls.Add(li10(i))

            num10 = num10 + 55

        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li10(al).Image = riacho.peixe4.Image

        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li10(al).Image = riacho.peixe1.Image

        Next

        For i = 0 To 10 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li10(al).Image = riacho.peixe3.Image

        Next

        ' for da contagem de peixes
        For i = 0 To 11 Step 1


            If li10(i).Image.Equals(riacho.peixe4.Image) Then

                peixe_azul = peixe_azul + 1

            ElseIf li10(i).Image.Equals(riacho.peixe3.Image) Then

                peixe_branco = peixe_branco + 1

            ElseIf li10(i).Image.Equals(riacho.peixe2.Image) Then

                peixe_listrado = peixe_listrado + 1


            ElseIf li10(i).Image.Equals(riacho.peixe1.Image) Then

                peixe_laranja = peixe_laranja + 1

            End If

        Next



        ' inicio da linha 11


        Dim picture144 As New PictureBox
        Dim picture145 As New PictureBox
        Dim picture146 As New PictureBox
        Dim picture147 As New PictureBox
        Dim picture148 As New PictureBox
        Dim picture149 As New PictureBox
        Dim picture150 As New PictureBox
        Dim picture151 As New PictureBox
        Dim picture152 As New PictureBox
        Dim picture153 As New PictureBox
        Dim picture154 As New PictureBox
        Dim picture155 As New PictureBox

        Dim li11() As PictureBox = {picture144, picture145, picture146, picture147, picture148, picture149, picture150, picture151, picture152, picture153, picture154, picture155}


        Dim num11 As Integer
        num11 = 49

        For i = 0 To 11 Step 1

            li11(i).Image = riacho.peixe2.Image


            li11(i).Size = New Size(55, 39)

            li11(i).SizeMode = PictureBoxSizeMode.StretchImage


            li11(i).Location = New Point(num11, 654)

            li11(i).BackColor = Color.Transparent
            riacho.Controls.Add(li11(i))

            num11 = num11 + 55

        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li11(al).Image = riacho.peixe4.Image

        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li11(al).Image = riacho.peixe1.Image

        Next

        For i = 0 To 10 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li11(al).Image = riacho.peixe3.Image

        Next
        ' for da contagem de peixes
        For i = 0 To 11 Step 1


            If li11(i).Image.Equals(riacho.peixe4.Image) Then

                peixe_azul = peixe_azul + 1

            ElseIf li11(i).Image.Equals(riacho.peixe3.Image) Then

                peixe_branco = peixe_branco + 1

            ElseIf li11(i).Image.Equals(riacho.peixe2.Image) Then

                peixe_listrado = peixe_listrado + 1


            ElseIf li11(i).Image.Equals(riacho.peixe1.Image) Then

                peixe_laranja = peixe_laranja + 1

            End If

        Next





        ' inicio da linha 12


        Dim picture156 As New PictureBox
        Dim picture157 As New PictureBox
        Dim picture158 As New PictureBox
        Dim picture159 As New PictureBox
        Dim picture160 As New PictureBox
        Dim picture161 As New PictureBox
        Dim picture162 As New PictureBox
        Dim picture163 As New PictureBox
        Dim picture164 As New PictureBox
        Dim picture165 As New PictureBox
        Dim picture166 As New PictureBox
        Dim picture167 As New PictureBox

        Dim li12() As PictureBox = {picture156, picture157, picture158, picture159, picture160, picture161, picture162, picture163, picture164, picture165, picture166, picture167}


        Dim num12 As Integer
        num12 = 49

        For i = 0 To 11 Step 1

            li12(i).Image = riacho.peixe2.Image


            li12(i).Size = New Size(55, 39)

            li12(i).SizeMode = PictureBoxSizeMode.StretchImage


            li12(i).Location = New Point(num12, 693)

            li12(i).BackColor = Color.Transparent
            riacho.Controls.Add(li12(i))

            num12 = num12 + 55

        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li12(al).Image = riacho.peixe4.Image

        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li12(al).Image = riacho.peixe1.Image

        Next

        For i = 0 To 10 Step 1


            Dim al As Integer
            al = t.Next(0, 12)


            li12(al).Image = riacho.peixe3.Image

        Next

        ' for da contagem de peixes
        For i = 0 To 11 Step 1


            If li12(i).Image.Equals(riacho.peixe4.Image) Then

                peixe_azul = peixe_azul + 1

            ElseIf li12(i).Image.Equals(riacho.peixe3.Image) Then

                peixe_branco = peixe_branco + 1

            ElseIf li12(i).Image.Equals(riacho.peixe2.Image) Then

                peixe_listrado = peixe_listrado + 1


            ElseIf li12(i).Image.Equals(riacho.peixe1.Image) Then

                peixe_laranja = peixe_laranja + 1

            End If

        Next



        ' Validação dos valores contados pelos for
        riacho.peixe_azulvalor.Text = peixe_azul
        riacho.peixe_laranjavalor.Text = peixe_laranja
        riacho.peixe_listradovalor.Text = peixe_listrado
        riacho.peixe_brancovalor.Text = peixe_branco

    End Sub



    ' INICO DA TELA POMAR'


    Public Sub insere_pomar()

        ' criação de variaveis

        Dim macabix As Integer
        Dim macanor As Integer

        Dim t As Random = New Random()


        Dim picture As New PictureBox

        Dim picture1 As New PictureBox
        Dim picture2 As New PictureBox
        Dim picture3 As New PictureBox
        Dim picture4 As New PictureBox
        Dim picture5 As New PictureBox
        Dim picture6 As New PictureBox
        Dim picture7 As New PictureBox
        Dim picture8 As New PictureBox
        Dim picture9 As New PictureBox
        Dim picture10 As New PictureBox
        Dim picture11 As New PictureBox
        Dim picture12 As New PictureBox
        Dim picture13 As New PictureBox
        Dim picture14 As New PictureBox
        Dim picture15 As New PictureBox
        Dim picture16 As New PictureBox
        Dim picture17 As New PictureBox

        Dim li1() As PictureBox = {picture, picture1, picture2, picture3, picture4, picture5, picture6, picture7, picture8, picture9, picture10, picture11, picture12, picture13, picture14, picture15, picture16, picture17}

        Dim num As Integer
        num = 67

        For i = 0 To 16 Step 1


            li1(i).Image = pomar.macabix.Image


            li1(i).Size = New Size(34, 30)

            li1(i).SizeMode = PictureBoxSizeMode.StretchImage


            li1(i).Location = New Point(num, 282)

            li1(i).BackColor = Color.Transparent
            pomar.Controls.Add(li1(i))

            num = num + 34
        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 17)


            li1(al).Image = pomar.macanor.Image

        Next


        ' Inicio da contagem
        For i = 0 To 16 Step 1

            If li1(i).Image.Equals(pomar.macabix.Image) Then
                macabix = macabix + 1

            ElseIf li1(i).Image.Equals(pomar.macanor.Image) Then
                macanor = macanor + 1
            End If

        Next

        ' Fim da linha 1




        ' inicio da linha 2
        Dim picture18 As New PictureBox
        Dim picture19 As New PictureBox
        Dim picture20 As New PictureBox
        Dim picture21 As New PictureBox
        Dim picture22 As New PictureBox
        Dim picture23 As New PictureBox
        Dim picture24 As New PictureBox
        Dim picture25 As New PictureBox
        Dim picture26 As New PictureBox
        Dim picture27 As New PictureBox
        Dim picture28 As New PictureBox
        Dim picture29 As New PictureBox
        Dim picture30 As New PictureBox
        Dim picture31 As New PictureBox
        Dim picture32 As New PictureBox
        Dim picture33 As New PictureBox
        Dim picture34 As New PictureBox
        Dim picture35 As New PictureBox

        Dim li2() As PictureBox = {picture18, picture19, picture20, picture21, picture22, picture23, picture24, picture25, picture26, picture27, picture28, picture29, picture30, picture31, picture32, picture33, picture34, picture35}


        Dim num2 As Integer
        num2 = 67

        For i = 0 To 16 Step 1

            li2(i).Image = pomar.macanor.Image


            li2(i).Size = New Size(34, 30)

            li2(i).SizeMode = PictureBoxSizeMode.StretchImage


            li2(i).Location = New Point(num2, 312)

            li2(i).BackColor = Color.Transparent
            pomar.Controls.Add(li2(i))

            num2 = num2 + 34

        Next

        For i = 0 To 8 Step 1


            Dim al As Integer
            al = t.Next(0, 17)


            li2(al).Image = pomar.macabix.Image

        Next

        ' Inicio da contagem
        For i = 0 To 16 Step 1

            If li2(i).Image.Equals(pomar.macabix.Image) Then
                macabix = macabix + 1

            ElseIf li2(i).Image.Equals(pomar.macanor.Image) Then
                macanor = macanor + 1
            End If

        Next



        ' inicio da linha 3
        Dim picture36 As New PictureBox
        Dim picture37 As New PictureBox
        Dim picture38 As New PictureBox
        Dim picture39 As New PictureBox
        Dim picture40 As New PictureBox
        Dim picture41 As New PictureBox
        Dim picture42 As New PictureBox
        Dim picture43 As New PictureBox
        Dim picture44 As New PictureBox
        Dim picture45 As New PictureBox
        Dim picture46 As New PictureBox
        Dim picture47 As New PictureBox
        Dim picture48 As New PictureBox
        Dim picture49 As New PictureBox
        Dim picture50 As New PictureBox
        Dim picture51 As New PictureBox
        Dim picture52 As New PictureBox
        Dim picture53 As New PictureBox

        Dim li3() As PictureBox = {picture36, picture37, picture38, picture39, picture40, picture41, picture42, picture43, picture44, picture45, picture46, picture47, picture48, picture49, picture50, picture51, picture52, picture53}


        Dim num3 As Integer
        num3 = 67

        For i = 0 To 16 Step 1

            li3(i).Image = pomar.macanor.Image


            li3(i).Size = New Size(34, 30)

            li3(i).SizeMode = PictureBoxSizeMode.StretchImage


            li3(i).Location = New Point(num3, 342)

            li3(i).BackColor = Color.Transparent
            pomar.Controls.Add(li3(i))

            num3 = num3 + 34

        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 17)


            li3(al).Image = pomar.macabix.Image

        Next

        ' Inicio da contagem
        For i = 0 To 16 Step 1

            If li3(i).Image.Equals(pomar.macabix.Image) Then
                macabix = macabix + 1

            ElseIf li3(i).Image.Equals(pomar.macanor.Image) Then
                macanor = macanor + 1
            End If

        Next

        ' fim da linha 3




        ' inicio da linha 4
        Dim picture54 As New PictureBox
        Dim picture55 As New PictureBox
        Dim picture56 As New PictureBox
        Dim picture57 As New PictureBox
        Dim picture58 As New PictureBox
        Dim picture59 As New PictureBox
        Dim picture60 As New PictureBox
        Dim picture61 As New PictureBox
        Dim picture62 As New PictureBox
        Dim picture63 As New PictureBox
        Dim picture64 As New PictureBox
        Dim picture65 As New PictureBox
        Dim picture66 As New PictureBox
        Dim picture67 As New PictureBox
        Dim picture68 As New PictureBox
        Dim picture69 As New PictureBox
        Dim picture70 As New PictureBox
        Dim picture71 As New PictureBox

        Dim li4() As PictureBox = {picture54, picture55, picture56, picture57, picture58, picture59, picture60, picture61, picture62, picture63, picture64, picture65, picture66, picture67, picture68, picture69, picture70, picture71}


        Dim num4 As Integer
        num4 = 67

        For i = 0 To 16 Step 1

            li4(i).Image = pomar.macabix.Image


            li4(i).Size = New Size(34, 30)

            li4(i).SizeMode = PictureBoxSizeMode.StretchImage


            li4(i).Location = New Point(num4, 372)

            li4(i).BackColor = Color.Transparent
            pomar.Controls.Add(li4(i))

            num4 = num4 + 34

        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 17)


            li4(al).Image = pomar.macanor.Image

        Next

        ' Inicio da contagem
        For i = 0 To 16 Step 1

            If li4(i).Image.Equals(pomar.macabix.Image) Then
                macabix = macabix + 1

            ElseIf li4(i).Image.Equals(pomar.macanor.Image) Then
                macanor = macanor + 1

            End If

        Next




        ' inicio da linha 5
        Dim picture72 As New PictureBox
        Dim picture73 As New PictureBox
        Dim picture74 As New PictureBox
        Dim picture75 As New PictureBox
        Dim picture76 As New PictureBox
        Dim picture77 As New PictureBox
        Dim picture78 As New PictureBox
        Dim picture79 As New PictureBox
        Dim picture80 As New PictureBox
        Dim picture81 As New PictureBox
        Dim picture82 As New PictureBox
        Dim picture83 As New PictureBox
        Dim picture84 As New PictureBox
        Dim picture85 As New PictureBox
        Dim picture86 As New PictureBox
        Dim picture87 As New PictureBox
        Dim picture88 As New PictureBox
        Dim picture89 As New PictureBox

        Dim li5() As PictureBox = {picture72, picture73, picture74, picture75, picture76, picture77, picture78, picture79, picture80, picture81, picture82, picture83, picture84, picture85, picture86, picture87, picture88, picture89}


        Dim num5 As Integer
        num5 = 67

        For i = 0 To 16 Step 1

            li5(i).Image = pomar.macabix.Image


            li5(i).Size = New Size(34, 30)

            li5(i).SizeMode = PictureBoxSizeMode.StretchImage


            li5(i).Location = New Point(num5, 402)

            li5(i).BackColor = Color.Transparent
            pomar.Controls.Add(li5(i))

            num5 = num5 + 34

        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 17)


            li5(al).Image = pomar.macanor.Image

        Next

        ' Inicio da contagem
        For i = 0 To 16 Step 1

            If li5(i).Image.Equals(pomar.macabix.Image) Then
                macabix = macabix + 1

            ElseIf li5(i).Image.Equals(pomar.macanor.Image) Then
                macanor = macanor + 1
            End If

        Next




        ' inicio da linha 6
        Dim picture92 As New PictureBox
        Dim picture93 As New PictureBox
        Dim picture94 As New PictureBox
        Dim picture95 As New PictureBox
        Dim picture96 As New PictureBox
        Dim picture97 As New PictureBox
        Dim picture98 As New PictureBox
        Dim picture99 As New PictureBox
        Dim picture100 As New PictureBox
        Dim picture101 As New PictureBox
        Dim picture102 As New PictureBox
        Dim picture103 As New PictureBox
        Dim picture104 As New PictureBox
        Dim picture105 As New PictureBox
        Dim picture106 As New PictureBox
        Dim picture107 As New PictureBox
        Dim picture108 As New PictureBox
        Dim picture109 As New PictureBox

        Dim li6() As PictureBox = {picture92, picture93, picture94, picture95, picture96, picture97, picture98, picture99, picture100, picture101, picture102, picture103, picture104, picture105, picture106, picture107, picture108, picture109}


        Dim num6 As Integer
        num6 = 67

        For i = 0 To 16 Step 1

            li6(i).Image = pomar.macabix.Image


            li6(i).Size = New Size(34, 30)

            li6(i).SizeMode = PictureBoxSizeMode.StretchImage


            li6(i).Location = New Point(num6, 432)

            li6(i).BackColor = Color.Transparent
            pomar.Controls.Add(li6(i))

            num6 = num6 + 34

        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 17)


            li6(al).Image = pomar.macanor.Image

        Next

        ' Inicio da contagem
        For i = 0 To 16 Step 1

            If li6(i).Image.Equals(pomar.macabix.Image) Then
                macabix = macabix + 1

            ElseIf li6(i).Image.Equals(pomar.macanor.Image) Then
                macanor = macanor + 1
            End If

        Next





        ' inicio da linha 7

        Dim picturea92 As New PictureBox
        Dim picturea93 As New PictureBox
        Dim picturea94 As New PictureBox
        Dim picturea95 As New PictureBox
        Dim picturea96 As New PictureBox
        Dim picturea97 As New PictureBox
        Dim picturea98 As New PictureBox
        Dim picturea99 As New PictureBox
        Dim picturea100 As New PictureBox
        Dim picturea101 As New PictureBox
        Dim picturea102 As New PictureBox
        Dim picturea103 As New PictureBox
        Dim picturea104 As New PictureBox
        Dim picturea105 As New PictureBox
        Dim picturea106 As New PictureBox
        Dim picturea107 As New PictureBox
        Dim picturea108 As New PictureBox
        Dim picturea109 As New PictureBox

        Dim li7() As PictureBox = {picturea92, picturea93, picturea94, picturea95, picturea96, picturea97, picturea98, picturea99, picturea100, picturea101, picturea102, picturea103, picturea104, picturea105, picturea106, picturea107, picturea108, picturea109}


        Dim num7 As Integer
        num7 = 67

        For i = 0 To 16 Step 1

            li7(i).Image = pomar.macabix.Image


            li7(i).Size = New Size(34, 30)

            li7(i).SizeMode = PictureBoxSizeMode.StretchImage


            li7(i).Location = New Point(num7, 462)

            li7(i).BackColor = Color.Transparent
            pomar.Controls.Add(li7(i))

            num7 = num7 + 34

        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 17)


            li7(al).Image = pomar.macanor.Image

        Next


        ' Inicio da contagem
        For i = 0 To 16 Step 1

            If li7(i).Image.Equals(pomar.macabix.Image) Then
                macabix = macabix + 1

            ElseIf li7(i).Image.Equals(pomar.macanor.Image) Then
                macanor = macanor + 1
            End If

        Next

        ' Fim da linha 7






        'inicio da linha 8
        Dim pictureb92 As New PictureBox
        Dim pictureb93 As New PictureBox
        Dim pictureb94 As New PictureBox
        Dim pictureb95 As New PictureBox
        Dim pictureb96 As New PictureBox
        Dim pictureb97 As New PictureBox
        Dim pictureb98 As New PictureBox
        Dim pictureb99 As New PictureBox
        Dim pictureb100 As New PictureBox
        Dim pictureb101 As New PictureBox
        Dim pictureb102 As New PictureBox
        Dim pictureb103 As New PictureBox
        Dim pictureb104 As New PictureBox
        Dim pictureb105 As New PictureBox
        Dim pictureb106 As New PictureBox
        Dim pictureb107 As New PictureBox
        Dim pictureb108 As New PictureBox
        Dim pictureb109 As New PictureBox

        Dim li8() As PictureBox = {pictureb92, pictureb93, pictureb94, pictureb95, pictureb96, pictureb97, pictureb98, pictureb99, pictureb100, pictureb101, pictureb102, pictureb103, pictureb104, pictureb105, pictureb106, pictureb107, pictureb108, pictureb109}


        Dim num8 As Integer
        num8 = 67

        For i = 0 To 16 Step 1

            li8(i).Image = pomar.macabix.Image


            li8(i).Size = New Size(34, 30)

            li8(i).SizeMode = PictureBoxSizeMode.StretchImage


            li8(i).Location = New Point(num8, 492)

            li8(i).BackColor = Color.Transparent
            pomar.Controls.Add(li8(i))

            num8 = num8 + 34

        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 17)


            li8(al).Image = pomar.macanor.Image

        Next


        ' Inicio da contagem
        For i = 0 To 16 Step 1

            If li8(i).Image.Equals(pomar.macabix.Image) Then
                macabix = macabix + 1

            ElseIf li8(i).Image.Equals(pomar.macanor.Image) Then
                macanor = macanor + 1
            End If

        Next

        ' Fim da linha 8




        'inicio da linha 9

        Dim picturec92 As New PictureBox
        Dim picturec93 As New PictureBox
        Dim picturec94 As New PictureBox
        Dim picturec95 As New PictureBox
        Dim picturec96 As New PictureBox
        Dim picturec97 As New PictureBox
        Dim picturec98 As New PictureBox
        Dim picturec99 As New PictureBox
        Dim picturec100 As New PictureBox
        Dim picturec101 As New PictureBox
        Dim picturec102 As New PictureBox
        Dim picturec103 As New PictureBox
        Dim picturec104 As New PictureBox
        Dim picturec105 As New PictureBox
        Dim picturec106 As New PictureBox
        Dim picturec107 As New PictureBox
        Dim picturec108 As New PictureBox
        Dim picturec109 As New PictureBox

        Dim li9() As PictureBox = {picturec92, picturec93, picturec94, picturec95, picturec96, picturec97, picturec98, picturec99, picturec100, picturec101, picturec102, picturec103, picturec104, picturec105, picturec106, picturec107, picturec108, picturec109}


        Dim num9 As Integer
        num9 = 67

        For i = 0 To 16 Step 1

            li9(i).Image = pomar.macabix.Image


            li9(i).Size = New Size(34, 30)

            li9(i).SizeMode = PictureBoxSizeMode.StretchImage


            li9(i).Location = New Point(num9, 522)

            li9(i).BackColor = Color.Transparent
            pomar.Controls.Add(li9(i))

            num9 = num9 + 34

        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 17)


            li9(al).Image = pomar.macanor.Image

        Next
        ' Inicio da contagem
        For i = 0 To 16 Step 1

            If li9(i).Image.Equals(pomar.macabix.Image) Then
                macabix = macabix + 1

            ElseIf li9(i).Image.Equals(pomar.macanor.Image) Then
                macanor = macanor + 1
            End If

        Next
        pomar.macanormal.Text = macanor
        pomar.macabixada.Text = macabix
    End Sub


    ' tela cabana


    Public Sub insere_cabana()

        'variaveis
        Dim tesourao As Integer
        Dim pa As Integer
        Dim luva As Integer
        Dim regador As Integer


        Dim t As Random = New Random()


        Dim picture As New PictureBox

        Dim picture1 As New PictureBox
        Dim picture2 As New PictureBox
        Dim picture3 As New PictureBox
        Dim picture4 As New PictureBox
        Dim picture5 As New PictureBox
        Dim picture6 As New PictureBox
        Dim picture7 As New PictureBox
        Dim picture8 As New PictureBox

        Dim li1() As PictureBox = {picture, picture1, picture2, picture3, picture4, picture5, picture6, picture7, picture8}

        Dim num As Integer
        num = 167

        For i = 0 To 8 Step 1





            li1(i).Image = cabana.luva.Image


            li1(i).Size = New Size(34, 30)

            li1(i).SizeMode = PictureBoxSizeMode.StretchImage


            li1(i).Location = New Point(num, 305)

            li1(i).BackColor = Color.Transparent
            cabana.Controls.Add(li1(i))

            num = num + 45

        Next

        For i = 0 To 3 Step 1


            Dim al As Integer
            al = t.Next(0, 9)


            li1(al).Image = cabana.tesourao.Image

        Next


        For i = 0 To 9 Step 1
            Dim al As Integer

            al = t.Next(0, 9)
            li1(al).Image = cabana.luva.Image

        Next


        For i = 0 To 3 Step 1
            Dim al As Integer

            al = t.Next(0, 9)
            li1(al).Image = cabana.pa.Image

        Next

        For i = 0 To 8 Step 1

            If li1(i).Image.Equals(cabana.tesourao.Image) Then
                tesourao = tesourao + 1

            ElseIf li1(i).Image.Equals(cabana.luva.Image) Then
                luva = luva + 1

            ElseIf li1(i).Image.Equals(cabana.regador.Image) Then
                regador = regador + 1

            ElseIf li1(i).Image.Equals(cabana.pa.Image) Then
                pa = pa + 1
            End If

        Next

        ' Fim da linha 1










        ' inicio da linha 2


        Dim picture18 As New PictureBox
        Dim picture19 As New PictureBox
        Dim picture20 As New PictureBox
        Dim picture21 As New PictureBox
        Dim picture22 As New PictureBox
        Dim picture23 As New PictureBox
        Dim picture24 As New PictureBox
        Dim picture25 As New PictureBox
        Dim picture26 As New PictureBox

        Dim li2() As PictureBox = {picture18, picture19, picture20, picture21, picture22, picture23, picture24, picture25, picture26}


        Dim num2 As Integer
        num2 = 167

        For i = 0 To 8 Step 1

            li2(i).Image = cabana.luva.Image


            li2(i).Size = New Size(34, 30)

            li2(i).SizeMode = PictureBoxSizeMode.StretchImage


            li2(i).Location = New Point(num2, 357)

            li2(i).BackColor = Color.Transparent
            cabana.Controls.Add(li2(i))

            num2 = num2 + 45

        Next

        For i = 0 To 9 Step 1


            Dim al As Integer
            al = t.Next(0, 9)


            li2(al).Image = cabana.luva.Image

        Next


        For i = 0 To 3 Step 1
            Dim al As Integer
            al = t.Next(0, 9)


            li2(al).Image = cabana.pa.Image


        Next


        For i = 0 To 3 Step 1
            Dim al As Integer
            al = t.Next(0, 9)


            li2(al).Image = cabana.regador.Image

        Next


        For i = 0 To 3 Step 1


            Dim al As Integer
            al = t.Next(0, 9)


            li2(al).Image = cabana.tesourao.Image

        Next

        ' Início da Contagem
        For i = 0 To 8 Step 1

            If li2(i).Image.Equals(cabana.tesourao.Image) Then
                tesourao = tesourao + 1

            ElseIf li2(i).Image.Equals(cabana.luva.Image) Then
                luva = luva + 1

            ElseIf li2(i).Image.Equals(cabana.regador.Image) Then
                regador = regador + 1

            ElseIf li2(i).Image.Equals(cabana.pa.Image) Then
                pa = pa + 1
            End If

        Next




        ' inicio da linha 3
        Dim picture36 As New PictureBox
        Dim picture37 As New PictureBox
        Dim picture38 As New PictureBox
        Dim picture39 As New PictureBox
        Dim picture40 As New PictureBox
        Dim picture41 As New PictureBox
        Dim picture42 As New PictureBox
        Dim picture43 As New PictureBox
        Dim picture44 As New PictureBox

        Dim li3() As PictureBox = {picture36, picture37, picture38, picture39, picture40, picture41, picture42, picture43, picture44}


        Dim num3 As Integer
        num3 = 167

        For i = 0 To 8 Step 1

            li3(i).Image = cabana.luva.Image


            li3(i).Size = New Size(34, 30)

            li3(i).SizeMode = PictureBoxSizeMode.StretchImage


            li3(i).Location = New Point(num3, 412)

            li3(i).BackColor = Color.Transparent
            cabana.Controls.Add(li3(i))

            num3 = num3 + 45

        Next

        For i = 0 To 9 Step 1


            Dim al As Integer
            al = t.Next(0, 9)


            li3(al).Image = cabana.luva.Image

        Next


        For i = 0 To 3 Step 1
            Dim al As Integer
            al = t.Next(0, 9)


            li3(al).Image = cabana.pa.Image


        Next


        For i = 0 To 3 Step 1
            Dim al As Integer
            al = t.Next(0, 9)


            li3(al).Image = cabana.regador.Image

        Next


        For i = 0 To 3 Step 1


            Dim al As Integer
            al = t.Next(0, 9)


            li3(al).Image = cabana.tesourao.Image

        Next


        'início da contagem
        For i = 0 To 8 Step 1

            If li3(i).Image.Equals(cabana.tesourao.Image) Then
                tesourao = tesourao + 1

            ElseIf li3(i).Image.Equals(cabana.luva.Image) Then
                luva = luva + 1

            ElseIf li3(i).Image.Equals(cabana.regador.Image) Then
                regador = regador + 1

            ElseIf li3(i).Image.Equals(cabana.pa.Image) Then
                pa = pa + 1
            End If

        Next


        ' inicio da linha 4


        Dim picture54 As New PictureBox
        Dim picture55 As New PictureBox
        Dim picture56 As New PictureBox
        Dim picture57 As New PictureBox
        Dim picture58 As New PictureBox
        Dim picture59 As New PictureBox
        Dim picture60 As New PictureBox
        Dim picture61 As New PictureBox
        Dim picture62 As New PictureBox

        Dim li4() As PictureBox = {picture54, picture55, picture56, picture57, picture58, picture59, picture60, picture61, picture62}


        Dim num4 As Integer
        num4 = 167

        For i = 0 To 8 Step 1

            li4(i).Image = cabana.luva.Image


            li4(i).Size = New Size(34, 30)

            li4(i).SizeMode = PictureBoxSizeMode.StretchImage


            li4(i).Location = New Point(num4, 468)

            li4(i).BackColor = Color.Transparent
            cabana.Controls.Add(li4(i))

            num4 = num4 + 45

        Next

        For i = 0 To 9 Step 1


            Dim al As Integer
            al = t.Next(0, 9)


            li4(al).Image = cabana.luva.Image

        Next


        For i = 0 To 3 Step 1

            Dim al As Integer
            al = t.Next(0, 9)


            li4(al).Image = cabana.pa.Image


        Next


        For i = 0 To 3 Step 1
            Dim al As Integer
            al = t.Next(0, 9)


            li4(al).Image = cabana.regador.Image

        Next


        For i = 0 To 3 Step 1


            Dim al As Integer
            al = t.Next(0, 9)


            li4(al).Image = cabana.tesourao.Image

        Next




        'Início da contagem
        For i = 0 To 8 Step 1

            If li4(i).Image.Equals(cabana.tesourao.Image) Then
                tesourao = tesourao + 1

            ElseIf li4(i).Image.Equals(cabana.luva.Image) Then
                luva = luva + 1

            ElseIf li4(i).Image.Equals(cabana.regador.Image) Then
                regador = regador + 1

            ElseIf li4(i).Image.Equals(cabana.pa.Image) Then
                pa = pa + 1
            End If

        Next



        ' inicio da linha 5


        Dim picture72 As New PictureBox
        Dim picture73 As New PictureBox
        Dim picture74 As New PictureBox
        Dim picture75 As New PictureBox
        Dim picture76 As New PictureBox
        Dim picture77 As New PictureBox
        Dim picture78 As New PictureBox
        Dim picture79 As New PictureBox
        Dim picture80 As New PictureBox

        Dim li5() As PictureBox = {picture72, picture73, picture74, picture75, picture76, picture77, picture78, picture79, picture80}


        Dim num5 As Integer
        num5 = 167

        For i = 0 To 8 Step 1

            li5(i).Image = cabana.luva.Image


            li5(i).Size = New Size(34, 30)

            li5(i).SizeMode = PictureBoxSizeMode.StretchImage


            li5(i).Location = New Point(num5, 521)

            li5(i).BackColor = Color.Transparent
            cabana.Controls.Add(li5(i))

            num5 = num5 + 45

        Next

        For i = 0 To 9 Step 1


            Dim al As Integer
            al = t.Next(0, 9)


            li5(al).Image = cabana.luva.Image

        Next


        For i = 0 To 3 Step 1

            Dim al As Integer
            al = t.Next(0, 9)


            li5(al).Image = cabana.pa.Image


        Next


        For i = 0 To 3 Step 1
            Dim al As Integer
            al = t.Next(0, 9)


            li5(al).Image = cabana.regador.Image

        Next


        For i = 0 To 3 Step 1


            Dim al As Integer
            al = t.Next(0, 9)


            li5(al).Image = cabana.tesourao.Image

        Next
        'Início da contagem
        For i = 0 To 8 Step 1

            If li5(i).Image.Equals(cabana.tesourao.Image) Then
                tesourao = tesourao + 1

            ElseIf li5(i).Image.Equals(cabana.luva.Image) Then
                luva = luva + 1

            ElseIf li5(i).Image.Equals(cabana.regador.Image) Then
                regador = regador + 1

            ElseIf li5(i).Image.Equals(cabana.pa.Image) Then
                pa = pa + 1
            End If

        Next

        ' inicio da linha 6


        Dim picture81 As New PictureBox
        Dim picture82 As New PictureBox
        Dim picture83 As New PictureBox
        Dim picture84 As New PictureBox
        Dim picture85 As New PictureBox
        Dim picture86 As New PictureBox
        Dim picture87 As New PictureBox
        Dim picture88 As New PictureBox
        Dim picture89 As New PictureBox

        Dim li6() As PictureBox = {picture81, picture82, picture83, picture84, picture85, picture86, picture87, picture88, picture89}


        Dim num6 As Integer
        num6 = 167

        For i = 0 To 8 Step 1

            li6(i).Image = cabana.luva.Image


            li6(i).Size = New Size(34, 30)

            li6(i).SizeMode = PictureBoxSizeMode.StretchImage


            li6(i).Location = New Point(num6, 573)

            li6(i).BackColor = Color.Transparent
            cabana.Controls.Add(li6(i))

            num6 = num6 + 45

        Next

        For i = 0 To 9 Step 1


            Dim al As Integer
            al = t.Next(0, 9)


            li6(al).Image = cabana.luva.Image

        Next


        For i = 0 To 3 Step 1

            Dim al As Integer
            al = t.Next(0, 9)


            li6(al).Image = cabana.pa.Image


        Next


        For i = 0 To 3 Step 1
            Dim al As Integer
            al = t.Next(0, 9)


            li6(al).Image = cabana.regador.Image

        Next


        For i = 0 To 3 Step 1


            Dim al As Integer
            al = t.Next(0, 9)


            li6(al).Image = cabana.tesourao.Image

        Next

        'Início da contagem
        For i = 0 To 8 Step 1

            If li6(i).Image.Equals(cabana.tesourao.Image) Then
                tesourao = tesourao + 1

            ElseIf li6(i).Image.Equals(cabana.luva.Image) Then
                luva = luva + 1

            ElseIf li6(i).Image.Equals(cabana.regador.Image) Then
                regador = regador + 1

            ElseIf li6(i).Image.Equals(cabana.pa.Image) Then
                pa = pa + 1
            End If

        Next

        ' inicio da linha 7


        Dim picture90 As New PictureBox
        Dim picture91 As New PictureBox
        Dim picture92 As New PictureBox
        Dim picture93 As New PictureBox
        Dim picture94 As New PictureBox
        Dim picture95 As New PictureBox
        Dim picture96 As New PictureBox
        Dim picture97 As New PictureBox
        Dim picture98 As New PictureBox

        Dim li7() As PictureBox = {picture90, picture91, picture92, picture93, picture94, picture95, picture96, picture97, picture98}


        Dim num7 As Integer
        num7 = 167

        For i = 0 To 8 Step 1

            li7(i).Image = cabana.luva.Image


            li7(i).Size = New Size(34, 30)

            li7(i).SizeMode = PictureBoxSizeMode.StretchImage


            li7(i).Location = New Point(num7, 627)

            li7(i).BackColor = Color.Transparent
            cabana.Controls.Add(li7(i))

            num7 = num7 + 45

        Next

        For i = 0 To 9 Step 1


            Dim al As Integer
            al = t.Next(0, 9)


            li7(al).Image = cabana.luva.Image

        Next


        For i = 0 To 3 Step 1

            Dim al As Integer
            al = t.Next(0, 9)


            li7(al).Image = cabana.pa.Image


        Next


        For i = 0 To 3 Step 1
            Dim al As Integer
            al = t.Next(0, 9)


            li7(al).Image = cabana.regador.Image

        Next


        For i = 0 To 3 Step 1


            Dim al As Integer
            al = t.Next(0, 9)


            li7(al).Image = cabana.tesourao.Image

        Next

        'Início da contagem
        For i = 0 To 8 Step 1

            If li7(i).Image.Equals(cabana.tesourao.Image) Then
                tesourao = tesourao + 1

            ElseIf li7(i).Image.Equals(cabana.luva.Image) Then
                luva = luva + 1

            ElseIf li7(i).Image.Equals(cabana.regador.Image) Then
                regador = regador + 1

            ElseIf li7(i).Image.Equals(cabana.pa.Image) Then
                pa = pa + 1
            End If

        Next

        'Labels
        cabana.luvas.Text = luva
        cabana.pas.Text = pa
        cabana.regadores.Text = regador
        cabana.tesouroes.Text = tesourao

    End Sub




    ' Tela arvores





    ' Tela arvores


    Public Sub insere_arvores()

        ' criação das variaveis
        Dim passaro_azul As Integer
        Dim passaro_vermelho As Integer
        Dim passaro_rosa As Integer
        Dim passaro_verde As Integer

        Dim t As Random = New Random()


        Dim picture As New PictureBox

        Dim picture1 As New PictureBox
        Dim picture2 As New PictureBox
        Dim picture3 As New PictureBox
        Dim picture4 As New PictureBox
        Dim picture5 As New PictureBox
        Dim picture6 As New PictureBox
        Dim picture7 As New PictureBox
        Dim picture8 As New PictureBox
        Dim picture9 As New PictureBox

        Dim li1() As PictureBox = {picture, picture1, picture2, picture3, picture4, picture5, picture6, picture7, picture8, picture9}

        Dim num As Integer
        num = 93

        For i = 0 To 9 Step 1





            li1(i).Image = arvores.p3.Image


            li1(i).Size = New Size(56, 56)

            li1(i).SizeMode = PictureBoxSizeMode.StretchImage


            li1(i).Location = New Point(num, 207)

            li1(i).BackColor = Color.Transparent
            arvores.Controls.Add(li1(i))

            num = num + 54
        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 10)


            li1(al).Image = arvores.p4.Image

        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 10)


            li1(al).Image = arvores.p1.Image

        Next

        For i = 0 To 10 Step 1


            Dim al As Integer
            al = t.Next(0, 10)


            li1(al).Image = arvores.p3.Image

        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 10)


            li1(al).Image = arvores.p2.Image

        Next

        'Contagem dos passaros

        For i = 0 To 9 Step 1

            If li1(i).Image.Equals(arvores.p1.Image) Then
                passaro_azul = passaro_azul + 1

            ElseIf li1(i).Image.Equals(arvores.p2.Image) Then

                passaro_vermelho = passaro_vermelho + 1

            ElseIf li1(i).Image.Equals(arvores.p3.Image) Then

                passaro_rosa = passaro_rosa + 1

            ElseIf li1(i).Image.Equals(arvores.p4.Image) Then

                passaro_verde = passaro_verde + 1
            End If

        Next


        ' linha 2

        Dim picture10 As New PictureBox
        Dim picture11 As New PictureBox
        Dim picture12 As New PictureBox
        Dim picture13 As New PictureBox
        Dim picture14 As New PictureBox
        Dim picture15 As New PictureBox
        Dim picture16 As New PictureBox
        Dim picture17 As New PictureBox
        Dim picture18 As New PictureBox
        Dim picture19 As New PictureBox

        Dim li2() As PictureBox = {picture10, picture11, picture12, picture13, picture14, picture15, picture16, picture17, picture18, picture19}

        Dim num2 As Integer
        num2 = 93

        For i = 0 To 9 Step 1





            li2(i).Image = arvores.p2.Image


            li2(i).Size = New Size(56, 56)

            li2(i).SizeMode = PictureBoxSizeMode.StretchImage


            li2(i).Location = New Point(num2, 262)

            li2(i).BackColor = Color.Transparent
            arvores.Controls.Add(li2(i))

            num2 = num2 + 54
        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 10)


            li2(al).Image = arvores.p2.Image

        Next



        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 10)


            li2(al).Image = arvores.p4.Image

        Next

        For i = 0 To 10 Step 1


            Dim al As Integer
            al = t.Next(0, 10)


            li2(al).Image = arvores.p3.Image

        Next


        For i = 0 To 5 Step 1


            Dim al As Integer
            al = t.Next(0, 10)


            li2(al).Image = arvores.p1.Image

        Next


        'Contagem dos passaros

        For i = 0 To 9 Step 1

            If li2(i).Image.Equals(arvores.p1.Image) Then

                passaro_azul = passaro_azul + 1

            ElseIf li2(i).Image.Equals(arvores.p2.Image) Then

                passaro_vermelho = passaro_vermelho + 1

            ElseIf li2(i).Image.Equals(arvores.p3.Image) Then

                passaro_rosa = passaro_rosa + 1

            ElseIf li2(i).Image.Equals(arvores.p4.Image) Then

                passaro_verde = passaro_verde + 1
            End If

        Next



        ' linha 3

        Dim picture20 As New PictureBox
        Dim picture21 As New PictureBox
        Dim picture22 As New PictureBox
        Dim picture23 As New PictureBox
        Dim picture24 As New PictureBox
        Dim picture25 As New PictureBox
        Dim picture26 As New PictureBox
        Dim picture27 As New PictureBox
        Dim picture28 As New PictureBox
        Dim picture29 As New PictureBox

        Dim li3() As PictureBox = {picture20, picture21, picture22, picture23, picture24, picture25, picture26, picture27, picture28, picture29}

        Dim num3 As Integer
        num3 = 93

        For i = 0 To 9 Step 1





            li3(i).Image = arvores.p3.Image


            li3(i).Size = New Size(56, 56)

            li3(i).SizeMode = PictureBoxSizeMode.StretchImage


            li3(i).Location = New Point(num3, 316)

            li3(i).BackColor = Color.Transparent
            arvores.Controls.Add(li3(i))

            num3 = num3 + 54
        Next

        For i = 0 To 4 Step 1
            Dim al As Integer
            al = t.Next(0, 10)


            li3(al).Image = arvores.p2.Image

        Next



        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 10)


            li3(al).Image = arvores.p4.Image

        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 10)


            li3(al).Image = arvores.p1.Image

        Next

        For i = 0 To 10 Step 1


            Dim al As Integer
            al = t.Next(0, 10)


            li3(al).Image = arvores.p3.Image

        Next

        'Contagem dos passaros

        For i = 0 To 9 Step 1

            If li3(i).Image.Equals(arvores.p1.Image) Then

                passaro_azul = passaro_azul + 1

            ElseIf li3(i).Image.Equals(arvores.p2.Image) Then

                passaro_vermelho = passaro_vermelho + 1

            ElseIf li3(i).Image.Equals(arvores.p3.Image) Then

                passaro_rosa = passaro_rosa + 1

            ElseIf li3(i).Image.Equals(arvores.p4.Image) Then

                passaro_verde = passaro_verde + 1
            End If

        Next




        ' linha 4

        Dim picture30 As New PictureBox
        Dim picture31 As New PictureBox
        Dim picture32 As New PictureBox
        Dim picture33 As New PictureBox
        Dim picture34 As New PictureBox
        Dim picture35 As New PictureBox
        Dim picture36 As New PictureBox
        Dim picture37 As New PictureBox
        Dim picture38 As New PictureBox
        Dim picture39 As New PictureBox

        Dim li4() As PictureBox = {picture30, picture31, picture32, picture33, picture34, picture35, picture36, picture37, picture38, picture39}

        Dim num4 As Integer
        num4 = 93

        For i = 0 To 9 Step 1





            li4(i).Image = arvores.p4.Image


            li4(i).Size = New Size(56, 56)

            li4(i).SizeMode = PictureBoxSizeMode.StretchImage


            li4(i).Location = New Point(num4, 370)

            li4(i).BackColor = Color.Transparent
            arvores.Controls.Add(li4(i))

            num4 = num4 + 54
        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 10)


            li4(al).Image = arvores.p2.Image

        Next



        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 10)


            li4(al).Image = arvores.p4.Image

        Next

        For i = 0 To 10 Step 1


            Dim al As Integer
            al = t.Next(0, 10)


            li4(al).Image = arvores.p3.Image

        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 10)


            li4(al).Image = arvores.p1.Image

        Next

        'Contagem dos passaros

        For i = 0 To 9 Step 1

            If li4(i).Image.Equals(arvores.p1.Image) Then

                passaro_azul = passaro_azul + 1

            ElseIf li4(i).Image.Equals(arvores.p2.Image) Then

                passaro_vermelho = passaro_vermelho + 1

            ElseIf li4(i).Image.Equals(arvores.p3.Image) Then

                passaro_rosa = passaro_rosa + 1

            ElseIf li4(i).Image.Equals(arvores.p4.Image) Then

                passaro_verde = passaro_verde + 1
            End If

        Next


        ' linha 5

        Dim picture40 As New PictureBox
        Dim picture41 As New PictureBox
        Dim picture42 As New PictureBox
        Dim picture43 As New PictureBox
        Dim picture44 As New PictureBox
        Dim picture45 As New PictureBox
        Dim picture46 As New PictureBox
        Dim picture47 As New PictureBox
        Dim picture48 As New PictureBox
        Dim picture49 As New PictureBox

        Dim li5() As PictureBox = {picture40, picture41, picture42, picture43, picture44, picture45, picture46, picture47, picture48, picture49}

        Dim num5 As Integer
        num5 = 93

        For i = 0 To 9 Step 1





            li5(i).Image = arvores.p1.Image


            li5(i).Size = New Size(56, 56)

            li5(i).SizeMode = PictureBoxSizeMode.StretchImage


            li5(i).Location = New Point(num5, 422)

            li5(i).BackColor = Color.Transparent
            arvores.Controls.Add(li5(i))

            num5 = num5 + 54
        Next

        For i = 0 To 5 Step 1


            Dim al As Integer
            al = t.Next(0, 10)


            li5(al).Image = arvores.p2.Image

        Next

        For i = 0 To 10 Step 1


            Dim al As Integer
            al = t.Next(0, 10)


            li5(al).Image = arvores.p3.Image

        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 10)


            li5(al).Image = arvores.p4.Image

        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 10)


            li5(al).Image = arvores.p1.Image

        Next
        'Contagem dos passaros

        For i = 0 To 9 Step 1

            If li5(i).Image.Equals(arvores.p1.Image) Then

                passaro_azul = passaro_azul + 1

            ElseIf li5(i).Image.Equals(arvores.p2.Image) Then

                passaro_vermelho = passaro_vermelho + 1

            ElseIf li5(i).Image.Equals(arvores.p3.Image) Then

                passaro_rosa = passaro_rosa + 1

            ElseIf li5(i).Image.Equals(arvores.p4.Image) Then

                passaro_verde = passaro_verde + 1
            End If

        Next


        ' linha 6

        Dim picture50 As New PictureBox
        Dim picture51 As New PictureBox
        Dim picture52 As New PictureBox
        Dim picture53 As New PictureBox
        Dim picture54 As New PictureBox
        Dim picture55 As New PictureBox
        Dim picture56 As New PictureBox
        Dim picture57 As New PictureBox
        Dim picture58 As New PictureBox
        Dim picture59 As New PictureBox

        Dim li6() As PictureBox = {picture50, picture51, picture52, picture53, picture54, picture55, picture56, picture57, picture58, picture59}

        Dim num6 As Integer
        num6 = 93

        For i = 0 To 9 Step 1





            li6(i).Image = arvores.p3.Image


            li6(i).Size = New Size(56, 56)

            li6(i).SizeMode = PictureBoxSizeMode.StretchImage


            li6(i).Location = New Point(num6, 476)

            li6(i).BackColor = Color.Transparent
            arvores.Controls.Add(li6(i))

            num6 = num6 + 54
        Next



        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 10)


            li6(al).Image = arvores.p1.Image

        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 10)


            li6(al).Image = arvores.p4.Image

        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 10)


            li6(al).Image = arvores.p2.Image

        Next

        'Contagem dos passaros

        For i = 0 To 9 Step 1

            If li6(i).Image.Equals(arvores.p1.Image) Then

                passaro_azul = passaro_azul + 1

            ElseIf li6(i).Image.Equals(arvores.p2.Image) Then

                passaro_vermelho = passaro_vermelho + 1

            ElseIf li6(i).Image.Equals(arvores.p3.Image) Then

                passaro_rosa = passaro_rosa + 1

            ElseIf li6(i).Image.Equals(arvores.p4.Image) Then

                passaro_verde = passaro_verde + 1
            End If

        Next




        ' linha 7

        Dim picture60 As New PictureBox
        Dim picture61 As New PictureBox
        Dim picture62 As New PictureBox
        Dim picture63 As New PictureBox
        Dim picture64 As New PictureBox
        Dim picture65 As New PictureBox
        Dim picture66 As New PictureBox
        Dim picture67 As New PictureBox
        Dim picture68 As New PictureBox
        Dim picture69 As New PictureBox

        Dim li7() As PictureBox = {picture60, picture61, picture62, picture63, picture64, picture65, picture66, picture67, picture68, picture69}

        Dim num7 As Integer
        num7 = 93

        For i = 0 To 9 Step 1





            li7(i).Image = arvores.p2.Image


            li7(i).Size = New Size(56, 56)

            li7(i).SizeMode = PictureBoxSizeMode.StretchImage


            li7(i).Location = New Point(num7, 529)

            li7(i).BackColor = Color.Transparent
            arvores.Controls.Add(li7(i))

            num7 = num7 + 54
        Next

        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 10)


            li7(al).Image = arvores.p1.Image

        Next



        For i = 0 To 4 Step 1


            Dim al As Integer
            al = t.Next(0, 10)


            li7(al).Image = arvores.p4.Image

        Next
        For i = 0 To 10 Step 1


            Dim al As Integer
            al = t.Next(0, 10)


            li7(al).Image = arvores.p3.Image

        Next




        'Contagem dos passaros

        For i = 0 To 9 Step 1

            If li7(i).Image.Equals(arvores.p1.Image) Then

                passaro_azul = passaro_azul + 1

            ElseIf li7(i).Image.Equals(arvores.p2.Image) Then

                passaro_vermelho = passaro_vermelho + 1

            ElseIf li7(i).Image.Equals(arvores.p3.Image) Then

                passaro_rosa = passaro_rosa + 1

            ElseIf li7(i).Image.Equals(arvores.p4.Image) Then

                passaro_verde = passaro_verde + 1
            End If

        Next

        arvores.passaro_azul.Text = passaro_azul
        arvores.passaro_rosa.Text = passaro_rosa
        arvores.passaro_vermelho.Text = passaro_vermelho
        arvores.passaro_verde.Text = passaro_verde

    End Sub




    Public Sub insere_galinheiro()

        'Variáveis
        Dim galinha As Integer
        Dim galinhaovos As Integer


        Dim t As Random = New Random()

        'Primeira Linha

        Dim picture As New PictureBox

        Dim picture1 As New PictureBox
        Dim picture2 As New PictureBox
        Dim picture3 As New PictureBox
        Dim picture4 As New PictureBox
        Dim picture5 As New PictureBox
        Dim picture6 As New PictureBox
        Dim picture7 As New PictureBox
        Dim picture8 As New PictureBox

        Dim li1() As PictureBox = {picture, picture1, picture2, picture3, picture4, picture5, picture6, picture7, picture8}

        Dim num As Integer
        num = 167

        For i = 0 To 8 Step 1





            li1(i).Image = galinheiro.galinha.Image


            li1(i).Size = New Size(34, 30)

            li1(i).SizeMode = PictureBoxSizeMode.StretchImage


            li1(i).Location = New Point(num, 305)

            li1(i).BackColor = Color.Transparent

            galinheiro.Controls.Add(li1(i))

            num = num + 45

        Next

        For i = 0 To 9 Step 1


            Dim al As Integer
            al = t.Next(0, 9)


            li1(al).Image = galinheiro.galinhaovos.Image

        Next


        For i = 0 To 3 Step 1
            Dim al As Integer

            al = t.Next(0, 9)
            li1(al).Image = galinheiro.galinha.Image

        Next

        'Início da contagem
        For i = 0 To 6 Step 1

            If li1(i).Image.Equals(galinheiro.galinha.Image) Then
                galinha = galinha + 1

            ElseIf li1(i).Image.Equals(galinheiro.galinhaovos.Image) Then
                galinhaovos = galinhaovos + 1
            End If

        Next

        ' Fim da linha 1








        'Segunda linha



        ' inicio da linha 2


        Dim picture18 As New PictureBox
        Dim picture19 As New PictureBox
        Dim picture20 As New PictureBox
        Dim picture21 As New PictureBox
        Dim picture22 As New PictureBox
        Dim picture23 As New PictureBox
        Dim picture24 As New PictureBox
        Dim picture25 As New PictureBox
        Dim picture26 As New PictureBox

        Dim li2() As PictureBox = {picture18, picture19, picture20, picture21, picture22, picture23, picture24, picture25, picture26}


        Dim num2 As Integer
        num2 = 167

        For i = 0 To 8 Step 1





            li2(i).Image = galinheiro.galinhaovos.Image


            li2(i).Size = New Size(34, 30)

            li2(i).SizeMode = PictureBoxSizeMode.StretchImage


            li2(i).Location = New Point(num2, 357)

            li2(i).BackColor = Color.Transparent

            galinheiro.Controls.Add(li2(i))

            num2 = num2 + 45

        Next

        For i = 0 To 9 Step 1


            Dim al As Integer
            al = t.Next(0, 9)


            li2(al).Image = galinheiro.galinhaovos.Image

        Next


        For i = 0 To 5 Step 1
            Dim al As Integer

            al = t.Next(0, 9)
            li2(al).Image = galinheiro.galinha.Image

        Next

        'Início da Contagem
        For i = 0 To 6 Step 1

            If li2(i).Image.Equals(galinheiro.galinha.Image) Then
                galinha = galinha + 1

            ElseIf li2(i).Image.Equals(galinheiro.galinhaovos.Image) Then
                galinhaovos = galinhaovos + 1
            End If

        Next

        ' Fim da segunda linha






        ' terceira linha

        Dim picture36 As New PictureBox
        Dim picture37 As New PictureBox
        Dim picture38 As New PictureBox
        Dim picture39 As New PictureBox
        Dim picture40 As New PictureBox
        Dim picture41 As New PictureBox
        Dim picture42 As New PictureBox
        Dim picture43 As New PictureBox
        Dim picture44 As New PictureBox

        Dim li3() As PictureBox = {picture36, picture37, picture38, picture39, picture40, picture41, picture42, picture43, picture44}


        Dim num3 As Integer
        num3 = 167

        For i = 0 To 8 Step 1





            li3(i).Image = galinheiro.galinha.Image


            li3(i).Size = New Size(34, 30)

            li3(i).SizeMode = PictureBoxSizeMode.StretchImage


            li3(i).Location = New Point(num3, 412)

            li3(i).BackColor = Color.Transparent

            galinheiro.Controls.Add(li3(i))

            num3 = num3 + 45

        Next

        For i = 0 To 9 Step 1


            Dim al As Integer
            al = t.Next(0, 9)


            li3(al).Image = galinheiro.galinhaovos.Image

        Next


        For i = 0 To 3 Step 1
            Dim al As Integer

            al = t.Next(0, 9)
            li3(al).Image = galinheiro.galinha.Image

        Next

        'Início da Contagem
        For i = 0 To 6 Step 1

            If li3(i).Image.Equals(galinheiro.galinha.Image) Then
                galinha = galinha + 1

            ElseIf li3(i).Image.Equals(galinheiro.galinhaovos.Image) Then
                galinhaovos = galinhaovos + 1
            End If

        Next

        ' fim da terceira linha




        'Inicio da quarta linha

        Dim picture54 As New PictureBox
        Dim picture55 As New PictureBox
        Dim picture56 As New PictureBox
        Dim picture57 As New PictureBox
        Dim picture58 As New PictureBox
        Dim picture59 As New PictureBox
        Dim picture60 As New PictureBox
        Dim picture61 As New PictureBox
        Dim picture62 As New PictureBox

        Dim li4() As PictureBox = {picture54, picture55, picture56, picture57, picture58, picture59, picture60, picture61, picture62}


        Dim num4 As Integer
        num4 = 167


        For i = 0 To 8 Step 1





            li4(i).Image = galinheiro.galinha.Image


            li4(i).Size = New Size(34, 30)

            li4(i).SizeMode = PictureBoxSizeMode.StretchImage


            li4(i).Location = New Point(num4, 468)

            li4(i).BackColor = Color.Transparent

            galinheiro.Controls.Add(li4(i))

            num4 = num4 + 45

        Next

        For i = 0 To 9 Step 1


            Dim al As Integer
            al = t.Next(0, 9)


            li4(al).Image = galinheiro.galinhaovos.Image

        Next


        For i = 0 To 3 Step 1
            Dim al As Integer

            al = t.Next(0, 9)
            li4(al).Image = galinheiro.galinha.Image

        Next

        'Início da contagem
        For i = 0 To 6 Step 1

            If li4(i).Image.Equals(galinheiro.galinha.Image) Then
                galinha = galinha + 1

            ElseIf li4(i).Image.Equals(galinheiro.galinhaovos.Image) Then
                galinhaovos = galinhaovos + 1
            End If

        Next



        ' Fim da quarta linha


        'Inicio da quinta linha

        Dim picture72 As New PictureBox
        Dim picture73 As New PictureBox
        Dim picture74 As New PictureBox
        Dim picture75 As New PictureBox
        Dim picture76 As New PictureBox
        Dim picture77 As New PictureBox
        Dim picture78 As New PictureBox
        Dim picture79 As New PictureBox
        Dim picture80 As New PictureBox

        Dim li5() As PictureBox = {picture72, picture73, picture74, picture75, picture76, picture77, picture78, picture79, picture80}


        Dim num5 As Integer
        num5 = 167

        For i = 0 To 8 Step 1





            li5(i).Image = galinheiro.galinha.Image


            li5(i).Size = New Size(34, 30)

            li5(i).SizeMode = PictureBoxSizeMode.StretchImage


            li5(i).Location = New Point(num5, 521)

            li5(i).BackColor = Color.Transparent

            galinheiro.Controls.Add(li5(i))

            num5 = num5 + 45

        Next

        For i = 0 To 9 Step 1


            Dim al As Integer
            al = t.Next(0, 9)


            li5(al).Image = galinheiro.galinhaovos.Image

        Next


        For i = 0 To 3 Step 1
            Dim al As Integer

            al = t.Next(0, 9)
            li5(al).Image = galinheiro.galinha.Image

        Next

        'Início da contagem
        For i = 0 To 6 Step 1

            If li5(i).Image.Equals(galinheiro.galinha.Image) Then
                galinha = galinha + 1

            ElseIf li5(i).Image.Equals(galinheiro.galinhaovos.Image) Then
                galinhaovos = galinhaovos + 1
            End If

        Next


        ' Fim da quinta linha


        'Inicio da sexta linha


        Dim picture81 As New PictureBox
        Dim picture82 As New PictureBox
        Dim picture83 As New PictureBox
        Dim picture84 As New PictureBox
        Dim picture85 As New PictureBox
        Dim picture86 As New PictureBox
        Dim picture87 As New PictureBox
        Dim picture88 As New PictureBox
        Dim picture89 As New PictureBox

        Dim li6() As PictureBox = {picture81, picture82, picture83, picture84, picture85, picture86, picture87, picture88, picture89}


        Dim num6 As Integer
        num6 = 167

        For i = 0 To 8 Step 1





            li6(i).Image = galinheiro.galinha.Image


            li6(i).Size = New Size(34, 30)

            li6(i).SizeMode = PictureBoxSizeMode.StretchImage


            li6(i).Location = New Point(num6, 574)

            li6(i).BackColor = Color.Transparent

            galinheiro.Controls.Add(li6(i))

            num6 = num6 + 45

        Next

        For i = 0 To 3 Step 1


            Dim al As Integer
            al = t.Next(0, 9)


            li6(al).Image = galinheiro.galinhaovos.Image

        Next


        For i = 0 To 9 Step 1
            Dim al As Integer

            al = t.Next(0, 9)
            li5(al).Image = galinheiro.galinha.Image

        Next

        'Início da contagem
        For i = 0 To 6 Step 1

            If li6(i).Image.Equals(galinheiro.galinha.Image) Then
                galinha = galinha + 1

            ElseIf li6(i).Image.Equals(galinheiro.galinhaovos.Image) Then
                galinhaovos = galinhaovos + 1
            End If

        Next

        'Fim da sexta linha


        'Inicio da setima linha

        Dim picture90 As New PictureBox
        Dim picture91 As New PictureBox
        Dim picture92 As New PictureBox
        Dim picture93 As New PictureBox
        Dim picture94 As New PictureBox
        Dim picture95 As New PictureBox
        Dim picture96 As New PictureBox
        Dim picture97 As New PictureBox
        Dim picture98 As New PictureBox

        Dim li7() As PictureBox = {picture90, picture91, picture92, picture93, picture94, picture95, picture96, picture97, picture98}


        Dim num7 As Integer
        num7 = 167


        For i = 0 To 8 Step 1





            li7(i).Image = galinheiro.galinha.Image


            li7(i).Size = New Size(34, 30)

            li7(i).SizeMode = PictureBoxSizeMode.StretchImage


            li7(i).Location = New Point(num7, 627)

            li7(i).BackColor = Color.Transparent

            galinheiro.Controls.Add(li7(i))

            num7 = num7 + 45

        Next

        For i = 0 To 9 Step 1


            Dim al As Integer
            al = t.Next(0, 9)


            li7(al).Image = galinheiro.galinhaovos.Image

        Next


        For i = 0 To 3 Step 1
            Dim al As Integer

            al = t.Next(0, 9)
            li7(al).Image = galinheiro.galinha.Image

        Next

        'Início da contagem
        For i = 0 To 8 Step 1

            If li7(i).Image.Equals(galinheiro.galinha.Image) Then
                galinha = galinha + 1

            ElseIf li7(i).Image.Equals(galinheiro.galinhaovos.Image) Then
                galinhaovos = galinhaovos + 1
            End If

        Next

        'Fim da setima linha



        galinheiro.ninhocom.Text = galinhaovos
        galinheiro.ninhosem.Text = galinha

    End Sub

    Public Sub insere_plantacao()

        'Variáveis
        Dim cenoura As Integer
        Dim beterraba As Integer


        Dim t As Random = New Random()

        'Primeira Linha

        Dim picture As New PictureBox
        Dim picture1 As New PictureBox
        Dim picture2 As New PictureBox
        Dim picture3 As New PictureBox
        Dim picture4 As New PictureBox
        Dim picture5 As New PictureBox
        Dim picture6 As New PictureBox
        Dim picture7 As New PictureBox
        Dim picture8 As New PictureBox
        Dim picture9 As New PictureBox
        Dim picture10 As New PictureBox
        Dim picture11 As New PictureBox
        Dim picture12 As New PictureBox
        Dim picture13 As New PictureBox
        Dim picture14 As New PictureBox
        Dim picture15 As New PictureBox
        Dim picture16 As New PictureBox
        Dim picture17 As New PictureBox
        Dim picture18 As New PictureBox
        Dim picture19 As New PictureBox
        Dim picture20 As New PictureBox

        Dim li1() As PictureBox = {picture, picture1, picture2, picture3, picture4, picture5, picture6, picture7, picture8, picture9, picture10, picture11, picture12, picture13, picture14, picture15, picture16, picture17, picture18, picture19, picture20}

        Dim num As Integer
        num = 42

        For i = 0 To 20 Step 1





            li1(i).Image = plantacao.cenoura.Image


            li1(i).Size = New Size(30, 28)

            li1(i).SizeMode = PictureBoxSizeMode.StretchImage


            li1(i).Location = New Point(num, 490)

            li1(i).BackColor = Color.Transparent

            plantacao.Controls.Add(li1(i))

            num = num + 28

        Next

        For i = 0 To 18 Step 1


            Dim al As Integer
            al = t.Next(0, 21)


            li1(al).Image = plantacao.beterraba.Image

        Next


        For i = 0 To 5 Step 1
            Dim al As Integer

            al = t.Next(0, 21)
            li1(al).Image = plantacao.cenoura.Image

        Next

        'Início da contagem
        For i = 0 To 20 Step 1

            If li1(i).Image.Equals(plantacao.cenoura.Image) Then
                cenoura = cenoura + 1

            ElseIf li1(i).Image.Equals(plantacao.beterraba.Image) Then
                beterraba = beterraba + 1
            End If

        Next

        ' Fim da linha 1

        'Segunda Linha

        Dim picture21 As New PictureBox
        Dim picture22 As New PictureBox
        Dim picture23 As New PictureBox
        Dim picture24 As New PictureBox
        Dim picture25 As New PictureBox
        Dim picture26 As New PictureBox
        Dim picture27 As New PictureBox
        Dim picture28 As New PictureBox
        Dim picture29 As New PictureBox
        Dim picture30 As New PictureBox
        Dim picture31 As New PictureBox
        Dim picture32 As New PictureBox
        Dim picture33 As New PictureBox
        Dim picture34 As New PictureBox
        Dim picture35 As New PictureBox
        Dim picture36 As New PictureBox
        Dim picture37 As New PictureBox
        Dim picture38 As New PictureBox
        Dim picture39 As New PictureBox
        Dim picture40 As New PictureBox
        Dim picture41 As New PictureBox

        Dim li2() As PictureBox = {picture21, picture22, picture23, picture24, picture25, picture26, picture27, picture28, picture29, picture30, picture31, picture32, picture33, picture34, picture35, picture36, picture37, picture38, picture39, picture40, picture41}

        num = 42

        For i = 0 To 20 Step 1





            li2(i).Image = plantacao.cenoura.Image


            li2(i).Size = New Size(30, 28)

            li2(i).SizeMode = PictureBoxSizeMode.StretchImage


            li2(i).Location = New Point(num, 518)

            li2(i).BackColor = Color.Transparent

            plantacao.Controls.Add(li2(i))

            num = num + 28

        Next

        For i = 0 To 15 Step 1


            Dim al As Integer
            al = t.Next(0, 21)


            li2(al).Image = plantacao.beterraba.Image

        Next


        For i = 0 To 5 Step 1
            Dim al As Integer

            al = t.Next(0, 21)
            li2(al).Image = plantacao.cenoura.Image

        Next

        'Início da contagem
        For i = 0 To 20 Step 1

            If li2(i).Image.Equals(plantacao.cenoura.Image) Then
                cenoura = cenoura + 1

            ElseIf li2(i).Image.Equals(plantacao.beterraba.Image) Then
                beterraba = beterraba + 1
            End If

        Next

        ' Fim da linha 2


        'Terceira Linha


        Dim picture42 As New PictureBox
        Dim picture43 As New PictureBox
        Dim picture44 As New PictureBox
        Dim picture45 As New PictureBox
        Dim picture46 As New PictureBox
        Dim picture47 As New PictureBox
        Dim picture48 As New PictureBox
        Dim picture49 As New PictureBox
        Dim picture50 As New PictureBox
        Dim picture51 As New PictureBox
        Dim picture52 As New PictureBox
        Dim picture53 As New PictureBox
        Dim picture54 As New PictureBox
        Dim picture55 As New PictureBox
        Dim picture56 As New PictureBox
        Dim picture57 As New PictureBox
        Dim picture58 As New PictureBox
        Dim picture59 As New PictureBox
        Dim picture60 As New PictureBox
        Dim picture61 As New PictureBox
        Dim picture62 As New PictureBox

        Dim li3() As PictureBox = {picture42, picture43, picture44, picture45, picture46, picture47, picture48, picture49, picture50, picture51, picture52, picture53, picture54, picture55, picture56, picture57, picture58, picture59, picture60, picture61, picture62}

        num = 42

        For i = 0 To 20 Step 1





            li3(i).Image = plantacao.cenoura.Image


            li3(i).Size = New Size(30, 28)

            li3(i).SizeMode = PictureBoxSizeMode.StretchImage


            li3(i).Location = New Point(num, 546)

            li3(i).BackColor = Color.Transparent

            plantacao.Controls.Add(li3(i))

            num = num + 28

        Next

        For i = 0 To 18 Step 1


            Dim al As Integer
            al = t.Next(0, 21)


            li3(al).Image = plantacao.beterraba.Image

        Next


        For i = 0 To 5 Step 1
            Dim al As Integer

            al = t.Next(0, 21)
            li3(al).Image = plantacao.cenoura.Image

        Next

        'Início da contagem
        For i = 0 To 20 Step 1

            If li3(i).Image.Equals(plantacao.cenoura.Image) Then
                cenoura = cenoura + 1

            ElseIf li3(i).Image.Equals(plantacao.beterraba.Image) Then
                beterraba = beterraba + 1
            End If

        Next

        ' Fim da linha 3

        'Quarta Linha

        Dim picture63 As New PictureBox
        Dim picture64 As New PictureBox
        Dim picture65 As New PictureBox
        Dim picture66 As New PictureBox
        Dim picture67 As New PictureBox
        Dim picture68 As New PictureBox
        Dim picture69 As New PictureBox
        Dim picture70 As New PictureBox
        Dim picture71 As New PictureBox
        Dim picture72 As New PictureBox
        Dim picture73 As New PictureBox
        Dim picture74 As New PictureBox
        Dim picture75 As New PictureBox
        Dim picture76 As New PictureBox
        Dim picture77 As New PictureBox
        Dim picture78 As New PictureBox
        Dim picture79 As New PictureBox
        Dim picture80 As New PictureBox
        Dim picture81 As New PictureBox
        Dim picture82 As New PictureBox
        Dim picture83 As New PictureBox

        Dim li4() As PictureBox = {picture63, picture64, picture65, picture66, picture67, picture68, picture69, picture70, picture71, picture72, picture73, picture74, picture75, picture76, picture77, picture78, picture79, picture80, picture81, picture82, picture83}

        num = 42

        For i = 0 To 20 Step 1





            li4(i).Image = plantacao.cenoura.Image


            li4(i).Size = New Size(30, 28)

            li4(i).SizeMode = PictureBoxSizeMode.StretchImage


            li4(i).Location = New Point(num, 574)

            li4(i).BackColor = Color.Transparent

            plantacao.Controls.Add(li4(i))

            num = num + 28

        Next

        For i = 0 To 18 Step 1


            Dim al As Integer
            al = t.Next(0, 21)


            li4(al).Image = plantacao.beterraba.Image

        Next


        For i = 0 To 5 Step 1
            Dim al As Integer

            al = t.Next(0, 21)
            li4(al).Image = plantacao.cenoura.Image

        Next

        'Início da contagem
        For i = 0 To 20 Step 1

            If li4(i).Image.Equals(plantacao.cenoura.Image) Then
                cenoura = cenoura + 1

            ElseIf li4(i).Image.Equals(plantacao.beterraba.Image) Then
                beterraba = beterraba + 1
            End If

        Next

        ' Fim da linha 4

        'Quinta Linha

        Dim picture84 As New PictureBox
        Dim picture85 As New PictureBox
        Dim picture86 As New PictureBox
        Dim picture87 As New PictureBox
        Dim picture88 As New PictureBox
        Dim picture89 As New PictureBox
        Dim picture90 As New PictureBox
        Dim picture91 As New PictureBox
        Dim picture92 As New PictureBox
        Dim picture93 As New PictureBox
        Dim picture94 As New PictureBox
        Dim picture95 As New PictureBox
        Dim picture96 As New PictureBox
        Dim picture97 As New PictureBox
        Dim picture98 As New PictureBox
        Dim picture99 As New PictureBox
        Dim picture100 As New PictureBox
        Dim picture101 As New PictureBox
        Dim picture102 As New PictureBox
        Dim picture103 As New PictureBox
        Dim picture104 As New PictureBox

        Dim li5() As PictureBox = {picture84, picture85, picture86, picture87, picture88, picture89, picture90, picture91, picture92, picture93, picture94, picture95, picture96, picture97, picture98, picture99, picture100, picture101, picture102, picture103, picture104}


        num = 42

        For i = 0 To 20 Step 1



            li5(i).Image = plantacao.cenoura.Image


            li5(i).Size = New Size(30, 28)

            li5(i).SizeMode = PictureBoxSizeMode.StretchImage


            li5(i).Location = New Point(num, 602)

            li5(i).BackColor = Color.Transparent

            plantacao.Controls.Add(li5(i))

            num = num + 28

        Next

        For i = 0 To 18 Step 1


            Dim al As Integer
            al = t.Next(0, 21)


            li5(al).Image = plantacao.beterraba.Image

        Next


        For i = 0 To 5 Step 1
            Dim al As Integer

            al = t.Next(0, 21)
            li5(al).Image = plantacao.cenoura.Image

        Next

        'Início da contagem
        For i = 0 To 20 Step 1

            If li5(i).Image.Equals(plantacao.cenoura.Image) Then
                cenoura = cenoura + 1

            ElseIf li5(i).Image.Equals(plantacao.beterraba.Image) Then
                beterraba = beterraba + 1
            End If

        Next

        ' Fim da linha 

        'Sexta Linha

        Dim picture105 As New PictureBox
        Dim picture106 As New PictureBox
        Dim picture107 As New PictureBox
        Dim picture108 As New PictureBox
        Dim picture109 As New PictureBox
        Dim picture110 As New PictureBox
        Dim picture111 As New PictureBox
        Dim picture112 As New PictureBox
        Dim picture113 As New PictureBox
        Dim picture114 As New PictureBox
        Dim picture115 As New PictureBox
        Dim picture116 As New PictureBox
        Dim picture117 As New PictureBox
        Dim picture118 As New PictureBox
        Dim picture119 As New PictureBox
        Dim picture120 As New PictureBox
        Dim picture121 As New PictureBox
        Dim picture122 As New PictureBox
        Dim picture123 As New PictureBox
        Dim picture124 As New PictureBox
        Dim picture125 As New PictureBox

        Dim li6() As PictureBox = {picture105, picture106, picture107, picture108, picture109, picture110, picture111, picture112, picture113, picture114, picture115, picture116, picture117, picture118, picture119, picture120, picture121, picture122, picture123, picture124, picture125}


        num = 42

        For i = 0 To 20 Step 1



            li6(i).Image = plantacao.cenoura.Image


            li6(i).Size = New Size(30, 28)

            li6(i).SizeMode = PictureBoxSizeMode.StretchImage


            li6(i).Location = New Point(num, 629)

            li6(i).BackColor = Color.Transparent

            plantacao.Controls.Add(li6(i))

            num = num + 28

        Next

        For i = 0 To 18 Step 1


            Dim al As Integer
            al = t.Next(0, 21)


            li6(al).Image = plantacao.beterraba.Image

        Next


        For i = 0 To 5 Step 1
            Dim al As Integer

            al = t.Next(0, 21)
            li6(al).Image = plantacao.cenoura.Image

        Next

        'Início da contagem
        For i = 0 To 20 Step 1

            If li6(i).Image.Equals(plantacao.cenoura.Image) Then
                cenoura = cenoura + 1

            ElseIf li6(i).Image.Equals(plantacao.beterraba.Image) Then
                beterraba = beterraba + 1
            End If

        Next

        ' Fim da linha 6

        'Setima Linha

        Dim picture126 As New PictureBox
        Dim picture127 As New PictureBox
        Dim picture128 As New PictureBox
        Dim picture129 As New PictureBox
        Dim picture130 As New PictureBox
        Dim picture131 As New PictureBox
        Dim picture132 As New PictureBox
        Dim picture133 As New PictureBox
        Dim picture134 As New PictureBox
        Dim picture135 As New PictureBox
        Dim picture136 As New PictureBox
        Dim picture137 As New PictureBox
        Dim picture138 As New PictureBox
        Dim picture139 As New PictureBox
        Dim picture140 As New PictureBox
        Dim picture141 As New PictureBox
        Dim picture142 As New PictureBox
        Dim picture143 As New PictureBox
        Dim picture144 As New PictureBox
        Dim picture145 As New PictureBox
        Dim picture146 As New PictureBox

        Dim li7() As PictureBox = {picture126, picture127, picture128, picture129, picture130, picture131, picture132, picture133, picture134, picture135, picture136, picture137, picture138, picture139, picture140, picture141, picture142, picture143, picture144, picture145, picture146}


        num = 42

        For i = 0 To 20 Step 1



            li7(i).Image = plantacao.cenoura.Image


            li7(i).Size = New Size(30, 28)

            li7(i).SizeMode = PictureBoxSizeMode.StretchImage


            li7(i).Location = New Point(num, 657)

            li7(i).BackColor = Color.Transparent

            plantacao.Controls.Add(li7(i))

            num = num + 28

        Next

        For i = 0 To 18 Step 1


            Dim al As Integer
            al = t.Next(0, 21)


            li7(al).Image = plantacao.beterraba.Image

        Next


        For i = 0 To 5 Step 1
            Dim al As Integer

            al = t.Next(0, 21)
            li7(al).Image = plantacao.cenoura.Image

        Next

        'Início da contagem
        For i = 0 To 20 Step 1

            If li7(i).Image.Equals(plantacao.cenoura.Image) Then
                cenoura = cenoura + 1

            ElseIf li7(i).Image.Equals(plantacao.beterraba.Image) Then
                beterraba = beterraba + 1
            End If

        Next

        ' Fim da linha 7

        'Oitava Linha

        Dim picture147 As New PictureBox
        Dim picture148 As New PictureBox
        Dim picture149 As New PictureBox
        Dim picture150 As New PictureBox
        Dim picture151 As New PictureBox
        Dim picture152 As New PictureBox
        Dim picture153 As New PictureBox
        Dim picture154 As New PictureBox
        Dim picture155 As New PictureBox
        Dim picture156 As New PictureBox
        Dim picture157 As New PictureBox
        Dim picture158 As New PictureBox
        Dim picture159 As New PictureBox
        Dim picture160 As New PictureBox
        Dim picture161 As New PictureBox
        Dim picture162 As New PictureBox
        Dim picture163 As New PictureBox
        Dim picture164 As New PictureBox
        Dim picture165 As New PictureBox
        Dim picture166 As New PictureBox
        Dim picture167 As New PictureBox

        Dim li8() As PictureBox = {picture147, picture148, picture149, picture150, picture151, picture152, picture153, picture154, picture155, picture156, picture157, picture158, picture159, picture160, picture161, picture162, picture163, picture164, picture165, picture166, picture167}


        num = 42

        For i = 0 To 20 Step 1



            li8(i).Image = plantacao.cenoura.Image


            li8(i).Size = New Size(30, 28)

            li8(i).SizeMode = PictureBoxSizeMode.StretchImage


            li8(i).Location = New Point(num, 685)

            li8(i).BackColor = Color.Transparent

            plantacao.Controls.Add(li8(i))

            num = num + 28

        Next

        For i = 0 To 18 Step 1


            Dim al As Integer
            al = t.Next(0, 21)


            li8(al).Image = plantacao.beterraba.Image

        Next


        For i = 0 To 5 Step 1
            Dim al As Integer

            al = t.Next(0, 21)
            li8(al).Image = plantacao.cenoura.Image

        Next

        'Início da contagem
        For i = 0 To 20 Step 1

            If li8(i).Image.Equals(plantacao.cenoura.Image) Then
                cenoura = cenoura + 1

            ElseIf li8(i).Image.Equals(plantacao.beterraba.Image) Then
                beterraba = beterraba + 1
            End If

        Next

        ' Fim da linha 8
        plantacao.cenouras.Text = cenoura
        plantacao.beterrabas.Text = beterraba

    End Sub
End Module