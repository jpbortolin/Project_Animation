<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picImagem = New System.Windows.Forms.PictureBox()
        Me.imglst1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnIniciar = New System.Windows.Forms.Button()
        CType(Me.picImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picImagem
        '
        Me.picImagem.BackColor = System.Drawing.SystemColors.Window
        Me.picImagem.Location = New System.Drawing.Point(130, 41)
        Me.picImagem.Name = "picImagem"
        Me.picImagem.Size = New System.Drawing.Size(145, 184)
        Me.picImagem.TabIndex = 0
        Me.picImagem.TabStop = False
        '
        'imglst1
        '
        Me.imglst1.ImageStream = CType(resources.GetObject("imglst1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglst1.TransparentColor = System.Drawing.Color.Transparent
        Me.imglst1.Images.SetKeyName(0, "img1.jpeg")
        Me.imglst1.Images.SetKeyName(1, "img2.jpeg")
        Me.imglst1.Images.SetKeyName(2, "img3.jpeg")
        Me.imglst1.Images.SetKeyName(3, "img4.jpeg")
        Me.imglst1.Images.SetKeyName(4, "img5.jpeg")
        '
        'Timer1
        '
        '
        'btnIniciar
        '
        Me.btnIniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciar.Location = New System.Drawing.Point(130, 241)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(145, 46)
        Me.btnIniciar.TabIndex = 1
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(404, 320)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.picImagem)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.picImagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picImagem As PictureBox
    Friend WithEvents imglst1 As ImageList
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnIniciar As Button
End Class
