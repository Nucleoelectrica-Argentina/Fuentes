Imports System.Windows.Forms

Public Class Emiup

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Emiup_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LstEmi.Items.Add("--")
        LstEmi.Items.Add("ALFA")
        LstEmi.Items.Add("ALFA, BETA")
        LstEmi.Items.Add("ALFA, GAMMA")
        LstEmi.Items.Add("ALFA/GAMMA")
        LstEmi.Items.Add("BETA")
        LstEmi.Items.Add("BETA ( B/SEG 2 PI)")
        LstEmi.Items.Add("BETA (UCI/ML)")
        LstEmi.Items.Add("BETA/GAMMA")
        LstEmi.Items.Add("BETA+/GAMMA")
        LstEmi.Items.Add("BETA-GAMMA")
        LstEmi.Items.Add("BETA/GAMMA (UCI/ML)")
        LstEmi.Items.Add("BETA/GAMMA( 4PI)")
        LstEmi.Items.Add("BETA/GAMMA(2PI)")
        LstEmi.Items.Add("BETAS/seg (EMISION SUP.5,23B/seg.cm2)")
        LstEmi.Items.Add("CPM BETA 4PI")
        LstEmi.Items.Add("CPM BETA EN 4 PI")
        LstEmi.Items.Add("DPM (ALFA)2 PI")
        LstEmi.Items.Add("IPS BETA 4 PI")
        LstEmi.Items.Add("NEUTRONES(N/SEG)")
        LstEmi.Items.Add("S/D")
        LstEmi.Items.Add("CPM BETA EN 4 PI")
    End Sub
End Class
