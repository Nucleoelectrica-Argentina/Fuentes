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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuResOpe = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAlta = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModi = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFuenSec = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaInventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorNroDeFuenteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNroTodas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNroUna = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorTipoDeFuenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnutipoTodas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTipoRad = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConCond = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConBaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeInventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XNroFuente = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuentesDadasDeBajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuentesDeUsoCondicionalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoDelSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambioDeClaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSalida = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ListadosToolStripMenuItem, Me.MantenimientoDelSistemaToolStripMenuItem, Me.mnuSalida})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(702, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuResOpe})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(71, 20)
        Me.ToolStripMenuItem1.Text = "Actualizar"
        '
        'mnuResOpe
        '
        Me.mnuResOpe.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAlta, Me.mnuBaja, Me.mnuModi, Me.mnuFuenSec})
        Me.mnuResOpe.Name = "mnuResOpe"
        Me.mnuResOpe.Size = New System.Drawing.Size(195, 22)
        Me.mnuResOpe.Text = "Responsable Operativo"
        '
        'mnuAlta
        '
        Me.mnuAlta.Enabled = False
        Me.mnuAlta.Name = "mnuAlta"
        Me.mnuAlta.Size = New System.Drawing.Size(236, 22)
        Me.mnuAlta.Text = "Ingresar Nueva Fuente"
        '
        'mnuBaja
        '
        Me.mnuBaja.Enabled = False
        Me.mnuBaja.Name = "mnuBaja"
        Me.mnuBaja.Size = New System.Drawing.Size(236, 22)
        Me.mnuBaja.Text = "Borrar Fuentes"
        '
        'mnuModi
        '
        Me.mnuModi.Enabled = False
        Me.mnuModi.Name = "mnuModi"
        Me.mnuModi.Size = New System.Drawing.Size(236, 22)
        Me.mnuModi.Text = "Modificar Datos de una Fuente"
        '
        'mnuFuenSec
        '
        Me.mnuFuenSec.Enabled = False
        Me.mnuFuenSec.Name = "mnuFuenSec"
        Me.mnuFuenSec.Size = New System.Drawing.Size(236, 22)
        Me.mnuFuenSec.Text = "Generar Fuente Secundaria"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaInventarioToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(66, 20)
        Me.ToolStripMenuItem2.Text = "Consulta"
        '
        'ConsultaInventarioToolStripMenuItem
        '
        Me.ConsultaInventarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PorNroDeFuenteToolStripMenuItem1, Me.PorTipoDeFuenteToolStripMenuItem, Me.mnuConCond, Me.mnuConBaja})
        Me.ConsultaInventarioToolStripMenuItem.Name = "ConsultaInventarioToolStripMenuItem"
        Me.ConsultaInventarioToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ConsultaInventarioToolStripMenuItem.Text = "Consulta Inventario"
        '
        'PorNroDeFuenteToolStripMenuItem1
        '
        Me.PorNroDeFuenteToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNroTodas, Me.mnuNroUna})
        Me.PorNroDeFuenteToolStripMenuItem1.Name = "PorNroDeFuenteToolStripMenuItem1"
        Me.PorNroDeFuenteToolStripMenuItem1.Size = New System.Drawing.Size(174, 22)
        Me.PorNroDeFuenteToolStripMenuItem1.Text = "Por Nro de Fuente"
        '
        'mnuNroTodas
        '
        Me.mnuNroTodas.Name = "mnuNroTodas"
        Me.mnuNroTodas.Size = New System.Drawing.Size(164, 22)
        Me.mnuNroTodas.Text = "Todas"
        '
        'mnuNroUna
        '
        Me.mnuNroUna.Name = "mnuNroUna"
        Me.mnuNroUna.Size = New System.Drawing.Size(164, 22)
        Me.mnuNroUna.Text = "Una en Particular"
        '
        'PorTipoDeFuenteToolStripMenuItem
        '
        Me.PorTipoDeFuenteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnutipoTodas, Me.mnuTipoRad})
        Me.PorTipoDeFuenteToolStripMenuItem.Name = "PorTipoDeFuenteToolStripMenuItem"
        Me.PorTipoDeFuenteToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.PorTipoDeFuenteToolStripMenuItem.Text = "Por Tipo de Fuente"
        '
        'mnutipoTodas
        '
        Me.mnutipoTodas.Name = "mnutipoTodas"
        Me.mnutipoTodas.Size = New System.Drawing.Size(193, 22)
        Me.mnutipoTodas.Text = "Todas"
        '
        'mnuTipoRad
        '
        Me.mnuTipoRad.Name = "mnuTipoRad"
        Me.mnuTipoRad.Size = New System.Drawing.Size(193, 22)
        Me.mnuTipoRad.Text = "Tipo y RadioNucleidos"
        '
        'mnuConCond
        '
        Me.mnuConCond.Name = "mnuConCond"
        Me.mnuConCond.Size = New System.Drawing.Size(174, 22)
        Me.mnuConCond.Text = "Uso Condicional"
        '
        'mnuConBaja
        '
        Me.mnuConBaja.Name = "mnuConBaja"
        Me.mnuConBaja.Size = New System.Drawing.Size(174, 22)
        Me.mnuConBaja.Text = "Dadas de Baja"
        '
        'ListadosToolStripMenuItem
        '
        Me.ListadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoDeInventarioToolStripMenuItem})
        Me.ListadosToolStripMenuItem.Name = "ListadosToolStripMenuItem"
        Me.ListadosToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ListadosToolStripMenuItem.Text = "Listados"
        '
        'ListadoDeInventarioToolStripMenuItem
        '
        Me.ListadoDeInventarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XNroFuente, Me.FuentesDadasDeBajaToolStripMenuItem, Me.FuentesDeUsoCondicionalToolStripMenuItem})
        Me.ListadoDeInventarioToolStripMenuItem.Name = "ListadoDeInventarioToolStripMenuItem"
        Me.ListadoDeInventarioToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ListadoDeInventarioToolStripMenuItem.Text = "Listado de Inventario"
        '
        'XNroFuente
        '
        Me.XNroFuente.Name = "XNroFuente"
        Me.XNroFuente.Size = New System.Drawing.Size(220, 22)
        Me.XNroFuente.Text = "Por Nro de Fuente"
        '
        'FuentesDadasDeBajaToolStripMenuItem
        '
        Me.FuentesDadasDeBajaToolStripMenuItem.Name = "FuentesDadasDeBajaToolStripMenuItem"
        Me.FuentesDadasDeBajaToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.FuentesDadasDeBajaToolStripMenuItem.Text = "Fuentes dadas de Baja"
        '
        'FuentesDeUsoCondicionalToolStripMenuItem
        '
        Me.FuentesDeUsoCondicionalToolStripMenuItem.Name = "FuentesDeUsoCondicionalToolStripMenuItem"
        Me.FuentesDeUsoCondicionalToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.FuentesDeUsoCondicionalToolStripMenuItem.Text = "Fuentes de uso Condicional"
        '
        'MantenimientoDelSistemaToolStripMenuItem
        '
        Me.MantenimientoDelSistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambioDeClaveToolStripMenuItem})
        Me.MantenimientoDelSistemaToolStripMenuItem.Name = "MantenimientoDelSistemaToolStripMenuItem"
        Me.MantenimientoDelSistemaToolStripMenuItem.Size = New System.Drawing.Size(164, 20)
        Me.MantenimientoDelSistemaToolStripMenuItem.Text = "Mantenimiento del Sistema"
        '
        'CambioDeClaveToolStripMenuItem
        '
        Me.CambioDeClaveToolStripMenuItem.Enabled = False
        Me.CambioDeClaveToolStripMenuItem.Name = "CambioDeClaveToolStripMenuItem"
        Me.CambioDeClaveToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CambioDeClaveToolStripMenuItem.Text = "Cambio de Clave"
        '
        'mnuSalida
        '
        Me.mnuSalida.Name = "mnuSalida"
        Me.mnuSalida.Size = New System.Drawing.Size(50, 20)
        Me.mnuSalida.Text = "Salida"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(702, 446)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuResOpe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAlta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBaja As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoDelSistemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSalida As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuModi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFuenSec As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaInventarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorNroDeFuenteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNroTodas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNroUna As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorTipoDeFuenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnutipoTodas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTipoRad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConCond As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConBaja As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoDeInventarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XNroFuente As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FuentesDadasDeBajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FuentesDeUsoCondicionalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambioDeClaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
