Public Class Form1

    Private Sub ToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem2.Click

    End Sub
    Private Sub mnuBaja_Click(sender As System.Object, e As System.EventArgs) Handles mnuBaja.Click
        opc = 112
        If paso = 1 Then Form3.Show()
    End Sub

    Private Sub mnuResOpe_Click(sender As System.Object, e As System.EventArgs) Handles mnuResOpe.Click
        opc = 11
        If paso <> 1 Then Inicio.Show()
    End Sub

    Private Sub mnuAlta_Click(sender As System.Object, e As System.EventArgs) Handles mnuAlta.Click
        opc = 111
        '  MsgBox(matri.ToString())
        If paso = 1 Then Form3.Show()
    End Sub

    Private Sub mnuConCond_Click(sender As System.Object, e As System.EventArgs) Handles mnuConCond.Click
        opc = 213
        Form2.Show()
    End Sub

    Private Sub mnuConBaja_Click(sender As System.Object, e As System.EventArgs) Handles mnuConBaja.Click
        opc = 214
        Form2.Show()
    End Sub

    Private Sub mnuSalida_Click(sender As System.Object, e As System.EventArgs) Handles mnuSalida.Click
        Application.Exit()
    End Sub

    Private Sub CambioDeClaveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CambioDeClaveToolStripMenuItem.Click
        Form4.Show()

    End Sub

    Private Sub mnuNroTodas_Click(sender As System.Object, e As System.EventArgs) Handles mnuNroTodas.Click
        opc = 211
        Form2.Show()

    End Sub

    Private Sub mnutipoTodas_Click(sender As System.Object, e As System.EventArgs) Handles mnutipoTodas.Click
        opc = 221
        Form2.Show()

    End Sub

    Private Sub mnuNroUna_Click(sender As System.Object, e As System.EventArgs) Handles mnuNroUna.Click
        opc = 212
        Form3.Show()
    End Sub

    Private Sub FuentesDadasDeBajaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FuentesDadasDeBajaToolStripMenuItem.Click
        FuentesBajas.Show()
    End Sub

  
    Private Sub mnuTipoRad_Click(sender As System.Object, e As System.EventArgs) Handles mnuTipoRad.Click
        opc = 222
        Form2.Show()
    End Sub

    Private Sub XNroFuente_Click(sender As System.Object, e As System.EventArgs) Handles XNroFuente.Click
        FuentesImprimirNroFuente.Show()

    End Sub

   
    Private Sub mnuModi_Click(sender As System.Object, e As System.EventArgs) Handles mnuModi.Click
        opc = 113
        Form3.Show()

    End Sub

    Private Sub FuentesDeUsoCondicionalToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FuentesDeUsoCondicionalToolStripMenuItem.Click
        ImprimirFuentesCondicionales.Show()

    End Sub
End Class