Imports System.Windows.Forms

Public Class Radiosup

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Radiosup_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LstRadio.Items.Add("Am/Be")
        LstRadio.Items.Add("Am241")
        LstRadio.Items.Add("Am243")
        LstRadio.Items.Add("Ba133")
        LstRadio.Items.Add("Bi207")
        LstRadio.Items.Add("BLANCO")
        LstRadio.Items.Add("C14")
        LstRadio.Items.Add("Ce144")
        LstRadio.Items.Add("Cl36")
        LstRadio.Items.Add("Cm244")
        LstRadio.Items.Add("Co57")
        LstRadio.Items.Add("Co60")
        LstRadio.Items.Add("Cr51")
        LstRadio.Items.Add("Cs134")
        LstRadio.Items.Add("Cs137")
        LstRadio.Items.Add("Eu152")
        LstRadio.Items.Add("Fe59")
        LstRadio.Items.Add("H3")
        LstRadio.Items.Add("Ho166")
        LstRadio.Items.Add("I131")
        LstRadio.Items.Add("Ir192")
        LstRadio.Items.Add("Kr85")
        LstRadio.Items.Add("Mn54")
        LstRadio.Items.Add("Na22")
        LstRadio.Items.Add("Po210")
        LstRadio.Items.Add("Pu239")
        LstRadio.Items.Add("Pu242")
        LstRadio.Items.Add("Ru103")
        LstRadio.Items.Add("Ru106")
        LstRadio.Items.Add("Sb125")
        LstRadio.Items.Add("Sr89")
        LstRadio.Items.Add("Sr90")
        LstRadio.Items.Add("Sr90/Y90")
        LstRadio.Items.Add("Tl204")
        LstRadio.Items.Add("U233")
        LstRadio.Items.Add("Uranio enriqu.")
    End Sub
End Class
