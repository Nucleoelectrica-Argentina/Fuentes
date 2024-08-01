<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtmatricula = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtclaveorig = New System.Windows.Forms.TextBox()
        Me.txtclavenueva1 = New System.Windows.Forms.TextBox()
        Me.txtclavenueva2 = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese su matricula y presione [ENTER]"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(13, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ingrese su clave y presione [ENTER]"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(13, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 37)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ingrese su Nueva Clave y presione [ENTER]"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(13, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 44)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Reingrese su Nueva Clave y presione [ENTER]"
        Me.Label5.Visible = False
        '
        'txtmatricula
        '
        Me.txtmatricula.Location = New System.Drawing.Point(125, 15)
        Me.txtmatricula.Name = "txtmatricula"
        Me.txtmatricula.Size = New System.Drawing.Size(78, 20)
        Me.txtmatricula.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txtNombre.Location = New System.Drawing.Point(125, 41)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(317, 20)
        Me.txtNombre.TabIndex = 6
        Me.txtNombre.Visible = False
        '
        'txtclaveorig
        '
        Me.txtclaveorig.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclaveorig.Location = New System.Drawing.Point(125, 78)
        Me.txtclaveorig.Name = "txtclaveorig"
        Me.txtclaveorig.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9834)
        Me.txtclaveorig.Size = New System.Drawing.Size(100, 24)
        Me.txtclaveorig.TabIndex = 7
        Me.txtclaveorig.Visible = False
        '
        'txtclavenueva1
        '
        Me.txtclavenueva1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclavenueva1.Location = New System.Drawing.Point(125, 122)
        Me.txtclavenueva1.Name = "txtclavenueva1"
        Me.txtclavenueva1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9786)
        Me.txtclavenueva1.Size = New System.Drawing.Size(100, 24)
        Me.txtclavenueva1.TabIndex = 8
        Me.txtclavenueva1.Visible = False
        '
        'txtclavenueva2
        '
        Me.txtclavenueva2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclavenueva2.Location = New System.Drawing.Point(125, 169)
        Me.txtclavenueva2.Name = "txtclavenueva2"
        Me.txtclavenueva2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9786)
        Me.txtclavenueva2.Size = New System.Drawing.Size(100, 24)
        Me.txtclavenueva2.TabIndex = 9
        Me.txtclavenueva2.Visible = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(268, 251)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 10
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(367, 251)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(253, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(205, 54)
        Me.Label6.TabIndex = 12
        Me.Label6.Visible = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(540, 328)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtclavenueva2)
        Me.Controls.Add(Me.txtclavenueva1)
        Me.Controls.Add(Me.txtclaveorig)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtmatricula)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de Claves"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtmatricula As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtclaveorig As System.Windows.Forms.TextBox
    Friend WithEvents txtclavenueva1 As System.Windows.Forms.TextBox
    Friend WithEvents txtclavenueva2 As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
