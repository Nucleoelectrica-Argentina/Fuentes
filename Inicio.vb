Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Collections


Public Class Inicio
    Public conn As New SqlConnection(Conexion.CadenaConexion)
    Public Nombre As String

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ValidarClave()
    End Sub

    Private Sub Inicio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        conn.Close()
        Try
            Dim strConsulta As String
            strConsulta = "SELECT nombre FROM usuarios WHERE usuario LIKE 'Responsable Operativo' order by matricula"
            Dim cmd As New SqlCommand(strConsulta, conn)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            da.Fill(ds, "usuarios")
            ComboBox1.Items.Clear()
            Dim tabla As DataTable
            Dim fila As DataRow
            tabla = ds.Tables("usuarios")
            For Each fila In tabla.Rows
                ComboBox1.Items.Add(fila.Item("nombre"))
            Next
            ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        Catch ex As Exception
            ex.Message.ToString()
        End Try
    End Sub
    Private Sub ValidarClave()
        Dim ConsultaSQL As String = "select clave, matricula from usuarios where nombre = '" + Nombre + "'"
        Dim comando As New SqlCommand(ConsultaSQL, conn)
        conn.Open()
        comando.ExecuteNonQuery()
        conn.Close()
        Dim ds As New DataSet()
        Dim da As New SqlDataAdapter(comando)
        da.Fill(ds, "usuarios")
        Dim DR As DataRow
        DR = ds.Tables("usuarios").Rows(0)
        Dim Xclave As String = DR("clave").ToString()
        If txtpassword.Text <> Space(5) Then
            Dim m, xposic As Short
            Dim eclave, t As String
            Dim largo As Short
            Dim Xa As String
            Dim Xb As String
            Dim clav As String
            largo = Len(Xclave)
            Xa = ""
            Xb = ""
            For m = 1 To 90
                Xa = Xa & Chr(m + 31)
                Xb = Xb & Chr(m + 161)
            Next m
            eclave = ""
            For m = 1 To largo

                t = Mid(Xclave, m, 1)
                xposic = InStr(Xb, t)
                eclave = eclave & Mid(Xa, xposic, 1)
            Next
            clav = eclave
            If txtpassword.Text <> clav Then
                '   imgLogo.Image = System.Drawing.Bitmap.FromResource("FACE04") 'FromResource("FACE04.jpg")
                MsgBox(" incorrecta")
                txtpassword.Text = ""
                '  imgLogo.Image = System.Drawing.Bitmap.FromResource("Face02")
                ComboBox1.Focus()
                cancel_button.Enabled = False
            Else
                ' matri = tbUsuarios.Fields("matrícula").Value
                ' imgLogo.Image = System.Drawing.Bitmap.FromResource("Face03")
                matri = DR("matricula").ToString()
                MsgBox("     OK " & Chr(10) & Nombre & Chr(10) & "MATRICULA:" & matri & "puede acceder")
                Select Case opc
                    Case 11
                        paso = 1
                        Form1.mnuAlta.Enabled = True
                        Form1.mnuBaja.Enabled = True
                        Form1.mnuModi.Enabled = True
                    Case 12
                        paso = 2
                    Case 13
                        paso = 3
                        '  Form1.mnuSoluso.Enabled = True
                        ' Form1.mnuSolbaja.Enabled = True
                        'Form1.mnuSolnueva.Enabled = True
                        ' Form1.mnuSolgrado.Enabled = True
                    Case 14
                        paso = 4
                End Select
                Me.Close()
                Form1.Refresh()
            End If

        End If
    End Sub
    Private Sub ComboBox1_TextChanged(sender As Object, e As System.EventArgs) Handles ComboBox1.TextChanged
        Nombre = ComboBox1.SelectedItem
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles cancel_button.Click
        Application.Exit()

    End Sub
End Class
