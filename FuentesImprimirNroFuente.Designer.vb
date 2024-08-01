<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FuentesImprimirNroFuente
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Listadoxnro = New Listadoxnro()

        Me.gridfuentes = New System.Windows.Forms.DataGridView()
        Me.Listadoxnro = New Listadoxnro()
        CType(Me.gridfuentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.AutoScroll = True
        Me.CrystalReportViewer1.AutoSize = True
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.Listadoxnro
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1242, 635)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'gridfuentes
        '
        Me.gridfuentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridfuentes.Location = New System.Drawing.Point(191, 402)
        Me.gridfuentes.Name = "gridfuentes"
        Me.gridfuentes.Size = New System.Drawing.Size(585, 95)
        Me.gridfuentes.TabIndex = 1
        '
        'FuentesImprimirNroFuente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1242, 635)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.gridfuentes)
        Me.Name = "FuentesImprimirNroFuente"
        Me.Text = "FuentesImprimirNroFuente"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gridfuentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Listadoxnro1 As Listadoxnro
    Friend WithEvents gridfuentes As System.Windows.Forms.DataGridView
    Friend WithEvents Listadoxnro As Listadoxnro

End Class
