<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class historia
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.botao_fechar = New System.Windows.Forms.PictureBox()
        Me.avancar1 = New System.Windows.Forms.PictureBox()
        Me.avancar = New System.Windows.Forms.PictureBox()
        CType(Me.botao_fechar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.avancar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.avancar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'botao_fechar
        '
        Me.botao_fechar.BackColor = System.Drawing.Color.Transparent
        Me.botao_fechar.Image = Global.WindowsApplication1.My.Resources.Resources.botao_fechar
        Me.botao_fechar.Location = New System.Drawing.Point(975, 11)
        Me.botao_fechar.Margin = New System.Windows.Forms.Padding(2)
        Me.botao_fechar.Name = "botao_fechar"
        Me.botao_fechar.Size = New System.Drawing.Size(28, 24)
        Me.botao_fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.botao_fechar.TabIndex = 3
        Me.botao_fechar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.botao_fechar, "Fecha a tela.")
        '
        'avancar1
        '
        Me.avancar1.BackColor = System.Drawing.Color.Transparent
        Me.avancar1.Image = Global.WindowsApplication1.My.Resources.Resources.avancar
        Me.avancar1.Location = New System.Drawing.Point(34, 712)
        Me.avancar1.Margin = New System.Windows.Forms.Padding(2)
        Me.avancar1.Name = "avancar1"
        Me.avancar1.Size = New System.Drawing.Size(99, 45)
        Me.avancar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.avancar1.TabIndex = 4
        Me.avancar1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.avancar1, "Avançar.")
        '
        'avancar
        '
        Me.avancar.BackColor = System.Drawing.Color.Transparent
        Me.avancar.Image = Global.WindowsApplication1.My.Resources.Resources.avancar
        Me.avancar.Location = New System.Drawing.Point(34, 712)
        Me.avancar.Margin = New System.Windows.Forms.Padding(2)
        Me.avancar.Name = "avancar"
        Me.avancar.Size = New System.Drawing.Size(99, 45)
        Me.avancar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.avancar.TabIndex = 5
        Me.avancar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.avancar, "Avançar.")
        '
        'historia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.avancar)
        Me.Controls.Add(Me.avancar1)
        Me.Controls.Add(Me.botao_fechar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "historia"
        Me.Text = "historia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.botao_fechar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.avancar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.avancar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents botao_fechar As System.Windows.Forms.PictureBox
    Friend WithEvents avancar1 As System.Windows.Forms.PictureBox
    Friend WithEvents avancar As System.Windows.Forms.PictureBox
End Class
