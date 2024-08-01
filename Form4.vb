Imports Microsoft.VisualBasic.Compatibility
Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class Form4
    Public conn As New SqlConnection(Conexion.CadenaConexion)

    Private Sub txtmatricula_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtmatricula.TextChanged

    End Sub

    Private Sub txtmatricula_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtmatricula.KeyPress
        conn.Close()
        If e.KeyChar = ChrW(Keys.Enter) Then
            ' ingresa  la matricula
            ' y muestra el nombre
            Try
                Dim consultaMatricula As String
                consultaMatricula = "select nombre from usuarios where matricula = '" + txtmatricula.Text + "'"
                Dim comando As New SqlCommand(consultaMatricula, conn)
                conn.Open()
                comando.ExecuteNonQuery()
                Dim da As New SqlDataAdapter(comando)

                Dim datas As New DataSet()
                da.Fill(datas, "usuarios")

                Dim Dr As DataRow
                Dr = datas.Tables("usuarios").Rows(0)
                txtNombre.Text = Dr("nombre").ToString()
                conn.Close()
                txtNombre.Visible = True
                Label2.Visible = True
                Label3.Visible = True
                txtclaveorig.Visible = True
            Catch ex As Exception
                MsgBox("Usuario no encontrado")
            End Try
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Hide()
        Me.Close()
    End Sub

    Private Sub txtclaveorig_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtclaveorig.TextChanged

    End Sub

    Private Sub txtclaveorig_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtclaveorig.KeyPress
        conn.Close()
        If e.KeyChar = ChrW(Keys.Enter) Then
            Dim ConsultaSQL As String = "select clave, matricula from usuarios where nombre = '" + Trim(txtNombre.Text) + "'"
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
            If txtclaveorig.Text <> clav Then
                MsgBox("clave incorrecta")
                txtclaveorig.Text = ""
            Else
                Label4.Visible = True
                txtclavenueva1.Visible = True
                Label5.Visible = True
                txtclavenueva2.Visible = True
                Label6.Visible = True

            End If
        End If
    End Sub
    Private Sub GenerarClave()
        Dim Xclave As String = txtclavenueva1.Text
        If txtclavenueva1.Text = txtclavenueva2.Text Then
            Dim m As Integer, eclave As String, t As String, xposic As Integer
            Dim largo As Integer
            Dim clav As String
            largo = Len(Xclave)
            Xa = ""
            Xb = ""
            For m = 1 To 90
                Xa = Xa + Chr(m + 31)
                Xb = Xb + Chr(m + 161)
            Next m

            eclave = ""
            For m = 1 To largo
                t = Mid$(Xclave, m, 1)
                xposic = InStr(Xa, t)
                eclave = eclave + Mid$(Xb, xposic, 1)
            Next
            clav = eclave
            Try
                Dim UpdateSQL As String = "update usuarios set clave = '" + clav + "' where nombre = '" + Trim(txtNombre.Text) + "'"
                Dim comando As New SqlCommand(UpdateSQL, conn)
                conn.Open()
                comando.ExecuteNonQuery()
                conn.Close()
                Label4.Visible = True
                txtclavenueva1.Visible = True
                MsgBox("Clave Cambiada con Exito")
                txtclavenueva1.Visible = False
                txtclavenueva2.Visible = False
                txtclaveorig.Visible = False
                txtmatricula.Visible = False
                txtNombre.Visible = False
                Label1.Visible = False
                Label2.Visible = False
                Label3.Visible = False
                Label4.Visible = False
                Label5.Visible = False
                btnAceptar.Visible = False
            Catch ex As Exception
                ex.Message.ToString()
            End Try
        End If
    End Sub
    Private Sub txtclavenueva1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtclavenueva1.TextChanged

    End Sub

    Private Sub txtclavenueva1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtclavenueva1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtclavenueva2.Focus()

        End If

    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        GenerarClave()

    End Sub

    Private Sub txtclavenueva2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtclavenueva2.TextChanged

    End Sub

    Private Sub txtclavenueva2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtclavenueva2.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnAceptar.Focus()
        End If
    End Sub

    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtmatricula.Visible = True
        Label1.Visible = True
        txtclavenueva1.Text = ""
    End Sub
End Class