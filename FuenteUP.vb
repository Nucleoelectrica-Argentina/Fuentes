Imports System.Windows.Forms
Public Class FuenteUP

    Private Sub FuenteUP_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("---------")
        ListBox1.Items.Add("Fuentes A")
        ListBox1.Items.Add("Fuentes B")
        ListBox1.Items.Add("Fuentes C")
        ListBox1.Items.Add("Todas")
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'aceptar
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        'cancelar
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class