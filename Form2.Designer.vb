<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.DataGrid1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.lblid = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.LblTipo = New System.Windows.Forms.Label()
        Me.Txttipo = New System.Windows.Forms.TextBox()
        Me.LblRadio = New System.Windows.Forms.Label()
        Me._TxtRad_0 = New System.Windows.Forms.TextBox()
        Me._TxtRad_1 = New System.Windows.Forms.TextBox()
        Me._TxtRad_2 = New System.Windows.Forms.TextBox()
        Me._TxtRad_3 = New System.Windows.Forms.TextBox()
        Me.List1 = New System.Windows.Forms.ListBox()
        Me.List2 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.AllowUserToDeleteRows = False
        Me.DataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.DataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid1.Location = New System.Drawing.Point(15, 91)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.ShowEditingIcon = False
        Me.DataGrid1.Size = New System.Drawing.Size(722, 336)
        Me.DataGrid1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(153, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Inventario de Fuentes Radiactivas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 430)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(291, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Haga doble click en una fila para ver más datos de la fuente"
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(266, 494)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 4
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(348, 494)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 5
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        Me.btn_buscar.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(429, 494)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(133, 460)
        Me.TxtId.Multiline = True
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(121, 60)
        Me.TxtId.TabIndex = 7
        Me.TxtId.Visible = False
        '
        'lblid
        '
        Me.lblid.BackColor = System.Drawing.Color.White
        Me.lblid.Location = New System.Drawing.Point(12, 460)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(103, 60)
        Me.lblid.TabIndex = 8
        Me.lblid.Text = "Ingrese Fuente Nueva y Apriete Enter"
        Me.lblid.Visible = False
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(563, 57)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(91, 13)
        Me.LblTotal.TabIndex = 11
        Me.LblTotal.Text = "Cant. de Fuentes:"
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(669, 54)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(68, 20)
        Me.TxtTotal.TabIndex = 12
        '
        'LblTipo
        '
        Me.LblTipo.AutoSize = True
        Me.LblTipo.Location = New System.Drawing.Point(33, 35)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.Size = New System.Drawing.Size(82, 13)
        Me.LblTipo.TabIndex = 13
        Me.LblTipo.Text = "Tipo de Fuente:"
        '
        'Txttipo
        '
        Me.Txttipo.Location = New System.Drawing.Point(117, 35)
        Me.Txttipo.Name = "Txttipo"
        Me.Txttipo.Size = New System.Drawing.Size(100, 20)
        Me.Txttipo.TabIndex = 14
        Me.Txttipo.Visible = False
        '
        'LblRadio
        '
        Me.LblRadio.AutoSize = True
        Me.LblRadio.Location = New System.Drawing.Point(31, 61)
        Me.LblRadio.Name = "LblRadio"
        Me.LblRadio.Size = New System.Drawing.Size(85, 13)
        Me.LblRadio.TabIndex = 15
        Me.LblRadio.Text = "Radionucleídos:"
        '
        '_TxtRad_0
        '
        Me._TxtRad_0.Location = New System.Drawing.Point(133, 61)
        Me._TxtRad_0.Name = "_TxtRad_0"
        Me._TxtRad_0.Size = New System.Drawing.Size(40, 20)
        Me._TxtRad_0.TabIndex = 16
        Me._TxtRad_0.Visible = False
        '
        '_TxtRad_1
        '
        Me._TxtRad_1.Location = New System.Drawing.Point(179, 61)
        Me._TxtRad_1.Name = "_TxtRad_1"
        Me._TxtRad_1.Size = New System.Drawing.Size(40, 20)
        Me._TxtRad_1.TabIndex = 17
        Me._TxtRad_1.Visible = False
        '
        '_TxtRad_2
        '
        Me._TxtRad_2.Location = New System.Drawing.Point(225, 61)
        Me._TxtRad_2.Name = "_TxtRad_2"
        Me._TxtRad_2.Size = New System.Drawing.Size(40, 20)
        Me._TxtRad_2.TabIndex = 18
        Me._TxtRad_2.Visible = False
        '
        '_TxtRad_3
        '
        Me._TxtRad_3.Location = New System.Drawing.Point(271, 61)
        Me._TxtRad_3.Name = "_TxtRad_3"
        Me._TxtRad_3.Size = New System.Drawing.Size(40, 20)
        Me._TxtRad_3.TabIndex = 19
        Me._TxtRad_3.Visible = False
        '
        'List1
        '
        Me.List1.FormattingEnabled = True
        Me.List1.Location = New System.Drawing.Point(473, 181)
        Me.List1.Name = "List1"
        Me.List1.Size = New System.Drawing.Size(120, 95)
        Me.List1.TabIndex = 9
        Me.List1.Visible = False
        '
        'List2
        '
        Me.List2.FormattingEnabled = True
        Me.List2.Location = New System.Drawing.Point(285, 181)
        Me.List2.Name = "List2"
        Me.List2.Size = New System.Drawing.Size(120, 95)
        Me.List2.TabIndex = 10
        Me.List2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(470, 444)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(280, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Haga click en el título de la columna para ordenar por ella"
        Me.Label3.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(779, 529)
        Me.Controls.Add(Me._TxtRad_3)
        Me.Controls.Add(Me._TxtRad_2)
        Me.Controls.Add(Me._TxtRad_1)
        Me.Controls.Add(Me._TxtRad_0)
        Me.Controls.Add(Me.LblRadio)
        Me.Controls.Add(Me.Txttipo)
        Me.Controls.Add(Me.LblTipo)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.List2)
        Me.Controls.Add(Me.List1)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Inventario de Fuentes Radiactivas"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TxtId As System.Windows.Forms.TextBox
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents LblTipo As System.Windows.Forms.Label
    Friend WithEvents LblRadio As System.Windows.Forms.Label
    Public WithEvents Txttipo As System.Windows.Forms.TextBox
    Public WithEvents _TxtRad_0 As System.Windows.Forms.TextBox
    Public WithEvents _TxtRad_1 As System.Windows.Forms.TextBox
    Public WithEvents _TxtRad_2 As System.Windows.Forms.TextBox
    Public WithEvents _TxtRad_3 As System.Windows.Forms.TextBox
    Friend WithEvents List1 As System.Windows.Forms.ListBox
    Friend WithEvents List2 As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
