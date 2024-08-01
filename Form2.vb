Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class Form2
    Dim ordena As String
    Dim conn As New SqlConnection(Conexion.CadenaConexion)
    Dim cuenta As Integer
    Dim ds As DataSet




    Private Sub List2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles List2.SelectedIndexChanged

    End Sub

    Private Sub ArmaLista2()
        List2.Items.Add("--")
        List2.Items.Add("AM/BE")
        List2.Items.Add("Am241")
        List2.Items.Add("Am243")
        List2.Items.Add("Ba133")
        List2.Items.Add("Background")
        List2.Items.Add("Bi207")
        List2.Items.Add("BLANCO")
        List2.Items.Add("C14")
        List2.Items.Add("Cd109")
        List2.Items.Add("Cd209")
        List2.Items.Add("Ce139")
        List2.Items.Add("Ce144")
        List2.Items.Add("Cl36")
        List2.Items.Add("Cm244")
        List2.Items.Add("Co57")
        List2.Items.Add("Co60")
        List2.Items.Add("Cr51")
        List2.Items.Add("Cs134")
        List2.Items.Add("Cs137")
        List2.Items.Add("Eu152")
        List2.Items.Add("Eu154")
        List2.Items.Add("Eu155")
        List2.Items.Add("Fe59")
        List2.Items.Add("H3")
        List2.Items.Add("Hg203")
        List2.Items.Add("Ho166")
        List2.Items.Add("I131")
        List2.Items.Add("Ir192")
        List2.Items.Add("Kr85")
        List2.Items.Add("Mn54")
        List2.Items.Add("Na22")
        List2.Items.Add("Po210")
        List2.Items.Add("Pu239")
        List2.Items.Add("Pu242")
        List2.Items.Add("Rh106")
        List2.Items.Add("Ru103")
        List2.Items.Add("Ru106")
        List2.Items.Add("Sb124")
        List2.Items.Add("Sb125")
        List2.Items.Add("Sn113")
        List2.Items.Add("Sr85")
        List2.Items.Add("Sr89")
        List2.Items.Add("Sr90")
        List2.Items.Add("Sr90/Y90")
        List2.Items.Add("Tc99")
        List2.Items.Add("Ti204")
        List2.Items.Add("U233")
        List2.Items.Add("Uranio enriqu.")
        List2.Items.Add("Y88")
    End Sub

    Private Sub List1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles List1.SelectedIndexChanged

    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        conn.Close()
        '  Dim i As Short
        Dim strSQL As String
        Select Case opc
            Case 214
                Try
                    Label1.Text = "Consulta de Fuentes Radiactivas 'dadas de Baja'"
                    strSQL = "SELECT ID_FUENTE_RADIACTIVA, ID_FABRICACION, TIPO_DE_FUENTE, FECHA_BAJA_ESTIMADA, BAJA_REAL, LUGAR_DEPOSITO, RADIONUCLEIDO_1, TIPO_DE_EMISION_1 " +
                     " FROM inventa WHERE ESTADO_DE_LA_FUENTE LIKE 'BAJA' ORDER BY ID_FUENTE_RADIACTIVA"
                    Dim commando1 As New SqlCommand(strSQL, conn)
                    conn.Open()
                    commando1.ExecuteNonQuery()
                    Dim da As New SqlDataAdapter(commando1)
                    ds = New DataSet()
                    da.Fill(ds, "inventa")
                    DataGrid1.DataSource = ds
                    DataGrid1.DataMember = "inventa"
                    cuenta = DataGrid1.RowCount
                    TxtTotal.Text = cuenta
                    'Label3.Visible = True
                    Label2.Visible = True
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try
                Exit Sub
                conn.Close()
            Case 213
                Label1.Text = "Consulta de Fuentes Radiactivas 'Condicionales'"
                strSQL = "Select DISTINCT ID_FUENTE_RADIACTIVA, CLASIFICACION, TIPO_DE_FUENTE, GEOMETRIA_SOPORTE, DIMENSIONES, RADIONUCLEIDO_1, SEMIPERIODO_1_DIAS," +
              " RADIONUCLEIDO_2, RADIONUCLEIDO_3, RADIONUCLEIDO_4, RADIONUCLEIDO_5, RADIONUCLEIDO_6, RADIONUCLEIDO_7, RADIONUCLEIDO_8, " +
              " RADIONUCLEIDO_9, RADIONUCLEIDO_10, RADIONUCLEIDO_11, FECHA_REFERENCIA_1 " +
              " FROM inventa WHERE(SEMIPERIODO_1_DIAS / DateDiff(dd, FECHA_REFERENCIA_1, GETDATE()) > 2) " +
              " ORDER BY ID_FUENTE_RADIACTIVA"
                Dim commando1 As New SqlCommand(strSQL, conn)
                conn.Open()
                commando1.ExecuteNonQuery()
                Dim da As New SqlDataAdapter(commando1)
                ds = New DataSet()
                da.Fill(ds, "inventa")
                DataGrid1.DataSource = ds
                DataGrid1.DataMember = "inventa"
                cuenta = DataGrid1.RowCount
                TxtTotal.Text = cuenta
                ' Label3.Visible = True
                Label2.Visible = True
                '  CreaGrid3()
            
                '    & "WHERE (left(INVENTA.[ESTADO DE LA FUENTE], 4) <> " & "'" & "BAJA" & "' and "
                Exit Sub
            Case 211, 111, 112, 113
                Label1.Text = "Consulta de Fuentes Radiactivas 'Por Nro de Fuente'"
                strSQL = "Select ID_FUENTE_RADIACTIVA as Fuente, CLASIFICACION as Clasif, TIPO_DE_FUENTE as Tipo, GEOMETRIA_SOPORTE as Geometria, DIMENSIONES as Dimensiones, RADIONUCLEIDO_1 as RAD1, RADIONUCLEIDO_2 as RAD2, RADIONUCLEIDO_3 as RAD3, RADIONUCLEIDO_4 as RAD4, RADIONUCLEIDO_5 as RAD5, RADIONUCLEIDO_6 as RAD6, RADIONUCLEIDO_7 as RAD7, RADIONUCLEIDO_8 as RAD8, " +
              " RADIONUCLEIDO_9 as RAD9, RADIONUCLEIDO_10 as RAD10, RADIONUCLEIDO_11 as RAD11, RADIONUCLEIDO_12 as RAD12 " +
              " FROM inventa ORDER BY ID_FUENTE_RADIACTIVA"
                Dim commando1 As New SqlCommand(strSQL, conn)
                conn.Open()
                commando1.ExecuteNonQuery()
                Dim da As New SqlDataAdapter(commando1)
                ds = New DataSet()
                da.Fill(ds, "inventa")
                DataGrid1.DataSource = ds
                DataGrid1.DataMember = "inventa"
                cuenta = DataGrid1.RowCount
                TxtTotal.Text = cuenta
                '   Label3.Visible = True
                Label2.Visible = True
            Case 212
                Label1.Text = "Consulta de Fuentes Radiactivas 'Condicionales'"
                strSQL = "Select DISTINCT ID_FUENTE_RADIACTIVA, CLASIFICACION, TIPO_DE_FUENTE, GEOMETRIA_SOPORTE, DIMENSIONES, RADIONUCLEIDO_1, SEMIPERIODO_1_DIAS," +
              " RADIONUCLEIDO_2, RADIONUCLEIDO_3, RADIONUCLEIDO_4, RADIONUCLEIDO_5, RADIONUCLEIDO_6, RADIONUCLEIDO_7, RADIONUCLEIDO_8, " +
              " RADIONUCLEIDO_9, RADIONUCLEIDO_10, RADIONUCLEIDO_11, FECHA_REFERENCIA_1 " +
              " FROM inventa WHERE(SEMIPERIODO_1_DIAS / DateDiff(dd, FECHA_REFERENCIA_1, GETDATE()) > 2) " +
              " ORDER BY TIPO_DE_FUENTE"
                Dim commando1 As New SqlCommand(strSQL, conn)
                conn.Open()
                commando1.ExecuteNonQuery()
                Dim da As New SqlDataAdapter(commando1)
                ds = New DataSet()
                da.Fill(ds, "inventa")
                DataGrid1.DataSource = ds
                DataGrid1.DataMember = "inventa"
                cuenta = DataGrid1.RowCount
                TxtTotal.Text = cuenta
                '  Label3.Visible = True
                Label2.Visible = True
            Case 221
                Label1.Text = "Consulta de Fuentes Radiactivas 'Todas por tipo'"
                strSQL = "Select ID_FUENTE_RADIACTIVA as Fuente, CLASIFICACION as Clasif, TIPO_DE_FUENTE as Tipo, GEOMETRIA_SOPORTE as Geometria, DIMENSIONES as Dimensiones, RADIONUCLEIDO_1 as RAD1, RADIONUCLEIDO_2 as RAD2, RADIONUCLEIDO_3 as RAD3, RADIONUCLEIDO_4 as RAD4, RADIONUCLEIDO_5 as RAD5, RADIONUCLEIDO_6 as RAD6, RADIONUCLEIDO_7 as RAD7, RADIONUCLEIDO_8 as RAD8, " +
              " RADIONUCLEIDO_9 as RAD9, RADIONUCLEIDO_10 as RAD10, RADIONUCLEIDO_11 as RAD11, RADIONUCLEIDO_12 as RAD12 " +
              " FROM inventa ORDER BY TIPO_DE_FUENTE"
                Dim commando1 As New SqlCommand(strSQL, conn)
                conn.Open()
                commando1.ExecuteNonQuery()
                Dim da As New SqlDataAdapter(commando1)
                ds = New DataSet()
                da.Fill(ds, "inventa")
                DataGrid1.DataSource = ds
                DataGrid1.DataMember = "inventa"
                cuenta = DataGrid1.RowCount
                TxtTotal.Text = cuenta
                '  Label3.Visible = True
                Label2.Visible = True
            Case 213
                Label1.Text = "Consulta de Fuentes Radiactivas 'Condicionales'"
                strSQL = "Select DISTINCT ID_FUENTE_RADIACTIVA, CLASIFICACION, TIPO_DE_FUENTE, GEOMETRIA_SOPORTE, DIMENSIONES, RADIONUCLEIDO_1, SEMIPERIODO_1_DIAS," +
              " RADIONUCLEIDO_2, RADIONUCLEIDO_3, RADIONUCLEIDO_4, RADIONUCLEIDO_5, RADIONUCLEIDO_6, RADIONUCLEIDO_7, RADIONUCLEIDO_8, " +
              " RADIONUCLEIDO_9, RADIONUCLEIDO_10, RADIONUCLEIDO_11, FECHA_REFERENCIA_1 " +
              " FROM inventa WHERE(SEMIPERIODO_1_DIAS / DateDiff(dd, FECHA_REFERENCIA_1, GETDATE()) > 2) " +
              " ORDER BY ID_FUENTE_RADIACTIVA"
                Dim commando1 As New SqlCommand(strSQL, conn)
                conn.Open()
                commando1.ExecuteNonQuery()
                Dim da As New SqlDataAdapter(commando1)
                ds = New DataSet()
                da.Fill(ds, "inventa")
                DataGrid1.DataSource = ds
                DataGrid1.DataMember = "inventa"
                cuenta = DataGrid1.RowCount
                TxtTotal.Text = cuenta
                ' Label3.Visible = True
                Label2.Visible = True
            Case 222
                Label1.Text = "Consulta de Fuentes Radiactivas 'por tipo de fuente'"
                strSQL = "Select DISTINCT ID_FUENTE_RADIACTIVA, CLASIFICACION, TIPO_DE_FUENTE, GEOMETRIA_SOPORTE, DIMENSIONES, RADIONUCLEIDO_1, SEMIPERIODO_1_DIAS," +
              " RADIONUCLEIDO_2, RADIONUCLEIDO_3, RADIONUCLEIDO_4, RADIONUCLEIDO_5, RADIONUCLEIDO_6, RADIONUCLEIDO_7, RADIONUCLEIDO_8, " +
              " RADIONUCLEIDO_9, RADIONUCLEIDO_10, RADIONUCLEIDO_11, FECHA_REFERENCIA_1 " +
              " FROM inventa WHERE(SEMIPERIODO_1_DIAS / DateDiff(dd, FECHA_REFERENCIA_1, GETDATE()) > 2) " +
              " ORDER BY TIPO_DE_FUENTE"
                Dim commando1 As New SqlCommand(strSQL, conn)
                conn.Open()
                commando1.ExecuteNonQuery()
                Dim da As New SqlDataAdapter(commando1)
                ds = New DataSet()
                da.Fill(ds, "inventa")
                DataGrid1.DataSource = ds
                DataGrid1.DataMember = "inventa"
                cuenta = DataGrid1.RowCount
                TxtTotal.Text = cuenta
                '  Label3.Visible = True
                Label2.Visible = True
                Exit Sub

            Case 2113

                strSQL = "SELECT ID_FUENTE_RADIACTIVA, TIPO_DE_FUENTE, FECHA_BAJA_ESTIMADA, BAJA_REAL, LUGAR_DEPOSITO, RADIONUCLEIDO_1, CLASIFICACION, " +
                "GEOMETRIA_SOPORTE, DIMENSIONES, RADIONUCLEIDO_2, RADIONUCLEIDO_3, RADIONUCLEIDO_4, RADIONUCLEIDO_5, RADIONUCLEIDO_6," +
                "RADIONUCLEIDO_7, RADIONUCLEIDO_8, RADIONUCLEIDO_9, RADIONUCLEIDO_10, RADIONUCLEIDO_11, RADIONUCLEIDO_12" +
                " FROM(inventa) WHERE (SUBSTRING(ID_FUENTE_RADIACTIVA, 2, 4) BETWEEN 1 AND 999)" +
                " ORDER BY ID_FUENTE_RADIACTIVA"

                Dim commando1 As New SqlCommand(strSQL, conn)
                conn.Open()
                commando1.ExecuteNonQuery()
                Dim da As New SqlDataAdapter(commando1)
                ds = New DataSet()
                da.Fill(ds, "inventa")
                DataGrid1.DataSource = ds
                DataGrid1.DataMember = "inventa"
                cuenta = DataGrid1.RowCount
                TxtTotal.Text = cuenta
               
                Label1.Text = Label1.Text & " (CNA I)"
                ' CreaGrid1()
                Exit Sub
            Case 2114
                strSQL = "SELECT ID_FUENTE_RADIACTIVA, TIPO_DE_FUENTE, FECHA_BAJA_ESTIMADA, BAJA_REAL, LUGAR_DEPOSITO, RADIONUCLEIDO_1, CLASIFICACION, " +
                "GEOMETRIA_SOPORTE, DIMENSIONES, RADIONUCLEIDO_2, RADIONUCLEIDO_3, RADIONUCLEIDO_4, RADIONUCLEIDO_5, RADIONUCLEIDO_6," +
                "RADIONUCLEIDO_7, RADIONUCLEIDO_8, RADIONUCLEIDO_9, RADIONUCLEIDO_10, RADIONUCLEIDO_11, RADIONUCLEIDO_12" +
                " FROM(inventa) WHERE (SUBSTRING(ID_FUENTE_RADIACTIVA, 2, 4) > 999)" +
                " ORDER BY ID_FUENTE_RADIACTIVA"
                Dim commando1 As New SqlCommand(strSQL, conn)
                conn.Open()
                commando1.ExecuteNonQuery()
                Dim da As New SqlDataAdapter(commando1)
                ds = New DataSet()
                da.Fill(ds, "inventa")
                DataGrid1.DataSource = ds
                DataGrid1.DataMember = "inventa"
                cuenta = DataGrid1.RowCount
                TxtTotal.Text = cuenta
             
                Label1.Text = Label1.Text & " (CNA II)"
                '  CreaGrid1()
                Exit Sub
        End Select
        'strSQL = "select [Id Fuente radiactiva], Clasificacion, [Tipo de fuente], " & " [Geometria /soporte], dimensiones, [radionucleido 1], " & " [radionucleido 2], [radionucleido 3], [radionucleido 4], " & " [radionucleido 5], [radionucleido 6], [radionucleido 7], " & " [radionucleido 8], [radionucleido 9], [radionucleido 10], " & " [radionucleido 11], [radionucleido 12]from inventa ORDER BY " & ordena
        'cuenta = DataGrid1.RowCount
        'CreaGrid1()


    End Sub

    Private Sub List1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles List1.DoubleClick
        Txttipo.Text = List1.Text
    End Sub

    Private Sub List2_DoubleClick(sender As System.Object, e As System.EventArgs) Handles List2.DoubleClick
        '      TxtRad(0).Text = List2.Text
        _TxtRad_0.Text = List2.Text


    End Sub

    Private Sub TxtId_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtId.KeyPress
        '   Dim KeyAscii As Short = Asc(EventArgs.KeyChar)
        Dim idbusca As String
        'If KeyAscii = 13 Then
        idbusca = UCase(RTrim(LTrim(TxtId.Text)))
        'tbInventa.Seek("=", idbusca)
        ' If Not tbInventa.NoMatch Then
        'MsgBox("La fuente ya existe")
        'GoTo EventExitSub
        'Else
        'End If
        'End If
EventExitSub:
        ' EventArgs.KeyChar = Chr(KeyAscii)
        ' If KeyAscii = 0 Then
        'EventArgs.Handled = True
        'End If
    End Sub

    Private Sub CreaGrid1()
        '  DataGrid1.DataSource = rsInventa
        TxtTotal.Text = cuenta

        Me.LblTipo.Visible = False
        Me.LblRadio.Visible = False
        Txttipo.Visible = False
        _TxtRad_0.Visible = False
        _TxtRad_1.Visible = False
        _TxtRad_2.Visible = False
        _TxtRad_3.Visible = False
        DataGrid1.Visible = True
        btn_buscar.Visible = False
        DataGrid1.Columns(0).Width = 800
        DataGrid1.Columns(1).Width = 900
        DataGrid1.Columns(2).Width = 1200
        DataGrid1.Columns(3).Width = 1200
        DataGrid1.Columns(4).Width = 1800
        DataGrid1.Columns(5).Width = 600
        DataGrid1.Columns(6).Width = 600
        DataGrid1.Columns(7).Width = 600
        DataGrid1.Columns(8).Width = 600
        DataGrid1.Columns(9).Width = 600
        DataGrid1.Columns(10).Width = 650
        DataGrid1.Columns(11).Width = 650
        DataGrid1.Columns(12).Width = 650
        DataGrid1.Columns(13).Width = 650
        DataGrid1.Columns(14).Width = 690
        DataGrid1.Columns(15).Width = 670
        DataGrid1.Columns(16).Width = 670
        DataGrid1.Columns(0).HeaderText = "FUENTE"
        DataGrid1.Columns(1).HeaderText = "CLASIFIC."
        DataGrid1.Columns(2).HeaderText = "TIPO"
        DataGrid1.Columns(3).HeaderText = "GEOMETRIA"
        DataGrid1.Columns(4).HeaderText = "DIMENSIONES"
        DataGrid1.Columns(5).HeaderText = "RAD.1"
        DataGrid1.Columns(6).HeaderText = "RAD.2"
        DataGrid1.Columns(7).HeaderText = "RAD.3"
        DataGrid1.Columns(8).HeaderText = "RAD.4"
        DataGrid1.Columns(9).HeaderText = "RAD.5"
        DataGrid1.Columns(10).HeaderText = "RAD.6"
        DataGrid1.Columns(11).HeaderText = "RAD.7"
        DataGrid1.Columns(12).HeaderText = "RAD.8"
        DataGrid1.Columns(13).HeaderText = "RAD.9"
        DataGrid1.Columns(14).HeaderText = "RAD.10"
        DataGrid1.Columns(15).HeaderText = "RAD.11"
        DataGrid1.Columns(16).HeaderText = "RAD.12"
    End Sub

    Private Sub CreaGrid2()
        '    DataGrid1.DataSource = rsInventa

        TxtTotal.Text = cuenta
        LblTipo.Visible = False
        LblRadio.Visible = False
        Txttipo.Visible = False
        _TxtRad_0.Visible = False
        _TxtRad_1.Visible = False
        _TxtRad_2.Visible = False
        _TxtRad_3.Visible = False
        DataGrid1.Visible = True
        btn_buscar.Visible = False
        DataGrid1.Columns(0).Width = 1000
        DataGrid1.Columns(1).Width = 1500
        DataGrid1.Columns(2).Width = 1800
        DataGrid1.Columns(3).Width = 1200
        DataGrid1.Columns(4).Width = 1200
        DataGrid1.Columns(5).Width = 1400
        DataGrid1.Columns(6).Width = 1400
        DataGrid1.Columns(7).Width = 2000
        DataGrid1.Columns(0).HeaderText = "FUENTE"
        DataGrid1.Columns(1).HeaderText = "FABRICACION"
        DataGrid1.Columns(2).HeaderText = "TIPO"
        DataGrid1.Columns(3).HeaderText = "BAJA ESTIMADA"
        DataGrid1.Columns(4).HeaderText = "FECHA BAJA"
        DataGrid1.Columns(5).HeaderText = "DEPOSITO"
        DataGrid1.Columns(6).HeaderText = "RADIONUC. 1"
        DataGrid1.Columns(7).HeaderText = "TIPO EMISION"
    End Sub

    Private Sub CreaGrid3()
        '     DataGrid1.DataSource = rsInventa
        TxtTotal.Text = cuenta
        LblTipo.Visible = False
        LblRadio.Visible = False
        Txttipo.Visible = False
        _TxtRad_0.Visible = False
        _TxtRad_1.Visible = False
        _TxtRad_2.Visible = False
        _TxtRad_3.Visible = False
        DataGrid1.Visible = True
        btn_buscar.Visible = False
        DataGrid1.Columns(0).Width = 800
        DataGrid1.Columns(1).Width = 900
        DataGrid1.Columns(2).Width = 1200
        DataGrid1.Columns(3).Width = 1200
        DataGrid1.Columns(4).Width = 1800
        DataGrid1.Columns(5).Width = 600
        DataGrid1.Columns(6).Width = 600
        DataGrid1.Columns(7).Width = 600
        DataGrid1.Columns(8).Width = 600
        DataGrid1.Columns(9).Width = 600
        DataGrid1.Columns(10).Width = 650
        DataGrid1.Columns(11).Width = 650
        DataGrid1.Columns(12).Width = 650
        DataGrid1.Columns(13).Width = 650
        DataGrid1.Columns(14).Width = 690
        DataGrid1.Columns(15).Width = 670
        DataGrid1.Columns(16).Width = 670
        DataGrid1.Columns(17).Width = 1100
        DataGrid1.Columns(0).HeaderText = "FUENTE"
        DataGrid1.Columns(1).HeaderText = "CLASIFIC."
        DataGrid1.Columns(2).HeaderText = "TIPO"
        DataGrid1.Columns(3).HeaderText = "GEOMETRIA"
        DataGrid1.Columns(4).HeaderText = "DIMENSIONES"
        DataGrid1.Columns(5).HeaderText = "RAD.1"
        DataGrid1.Columns(6).HeaderText = "SemiPer"
        DataGrid1.Columns(7).HeaderText = "RAD.2"
        DataGrid1.Columns(8).HeaderText = "RAD.3"
        DataGrid1.Columns(9).HeaderText = "RAD.4"
        DataGrid1.Columns(10).HeaderText = "RAD.5"
        DataGrid1.Columns(11).HeaderText = "RAD.6"
        DataGrid1.Columns(12).HeaderText = "RAD.7"
        DataGrid1.Columns(13).HeaderText = "RAD.8"
        DataGrid1.Columns(14).HeaderText = "RAD.9"
        DataGrid1.Columns(15).HeaderText = "RAD.10"
        DataGrid1.Columns(16).HeaderText = "RAD.11"
        DataGrid1.Columns(17).HeaderText = "Fec.Ref"
    End Sub



    Private Sub btn_aceptar_Click(sender As System.Object, e As System.EventArgs) Handles btn_aceptar.Click
        conn.Close()
        If Txttipo.Text = "" Then
            MsgBox("Debe seleccionar un tipo de fuente")
        End If
        If _TxtRad_0.Text = "" Then
            MsgBox("Debe seleccionar un radionucleido")
        End If

        Dim consultaSQL = "SELECT ID_FUENTE_RADIACTIVA, TIPO_DE_FUENTE, FECHA_BAJA_ESTIMADA, BAJA_REAL, LUGAR_DEPOSITO, RADIONUCLEIDO_1, CLASIFICACION, " +
               "GEOMETRIA_SOPORTE, DIMENSIONES, RADIONUCLEIDO_2, RADIONUCLEIDO_3, RADIONUCLEIDO_4, RADIONUCLEIDO_5, RADIONUCLEIDO_6," +
               "RADIONUCLEIDO_7, RADIONUCLEIDO_8, RADIONUCLEIDO_9, RADIONUCLEIDO_10, RADIONUCLEIDO_11, RADIONUCLEIDO_12" +
               " FROM inventa WHERE TIPO_DE_FUENTE = '" + Trim(Txttipo.Text) + "' AND RADIONUCLEIDO_1 = '" + Trim(_TxtRad_0.Text) + "' OR RADIONUCLEIDO_2 = '" + Trim(_TxtRad_0.Text) + "' " +
               " OR RADIONUCLEIDO_3 = '" + Trim(_TxtRad_0.Text) + "' OR RADIONUCLEIDO_4 = '" + Trim(_TxtRad_0.Text) + "' " '+
        '" ORDER BY '" + ordena + "'"
        Dim commando1 As New SqlCommand(consultaSQL, conn)
        conn.Open()
        commando1.ExecuteNonQuery()
        Dim da As New SqlDataAdapter(commando1)
        ds = New DataSet()
        da.Fill(ds, "inventa")
        DataGrid1.DataSource = ds
        DataGrid1.DataMember = "inventa"
        cuenta = DataGrid1.RowCount
        TxtTotal.Text = cuenta
        If cuenta = 0 Then
            MsgBox("No hay datos")
            Exit Sub

        End If

        btn_aceptar.Visible = False
        List1.Visible = False
        List2.Visible = False
        Label2.Visible = True
        ' Label3.Top = 6120
        '   Label3.Text = "Haga Doble Click en una fila para ver mas datos de la fuente"
        '  Label3.Visible = True
        'CreaGrid1()


    End Sub

    Private Sub Txttipo_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txttipo.TextChanged

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btn_buscar_Click(sender As System.Object, e As System.EventArgs) Handles btn_buscar.Click
        Dim xlongi, respbus, xlongi1 As Short
        Dim criterio As String
        Dim radio, Tipo As String
        Dim xlongi2 As Short
        respbus = 0
        criterio = ""
        encontrado = 0
        Do While respbus <> 1 And Txttipo.Text = "" And _TxtRad_0.Text = "" And _TxtRad_1.Text = "" And _TxtRad_2.Text = "" And _TxtRad_3.Text = ""
            respbus = MsgBox("Debe ingresar alguno de los datos solicitados", MsgBoxStyle.OkOnly)
            Txttipo.Focus()
            Exit Sub
        Loop
        'Call Crea_DataGrid1()
        Tipo = UCase(RTrim(LTrim(UCase(Txttipo.Text))))
        xlongi = Len(RTrim(LTrim(UCase(Txttipo.Text))))
        xlongi1 = Len(RTrim(LTrim(UCase(_TxtRad_0.Text))))
        If xlongi1 > 0 Then
            xlongi2 = xlongi1 - 1
            radio = UCase(Mid(Me._TxtRad_0.Text, 1, 1)) & LCase(Mid(Me._TxtRad_0.Text, 2, xlongi2))
        Else
            radio = " "
            xlongi2 = 0
        End If
        If xlongi > 0 Then
            Tipo = Mid(Tipo, 1, xlongi)
        Else
            Tipo = " "
        End If
        Dim ConsultaSQL = " Select DISTINCT ID_FUENTE_RADIACTIVA, ID_FABRICACION, FUENTE_PRIMARIA_DE_ORIGEN, TIPO_DE_FUENTE, GEOMETRIA_SOPORTE, ESTADO_DE_LA_FUENTE, " +
       " UNIDAD_ACTIVIDAD, RADIONUCLEIDO_1, RADIONUCLEIDO_2, RADIONUCLEIDO_3, RADIONUCLEIDO_4, RADIONUCLEIDO_5, RADIONUCLEIDO_6, " +
       " RADIONUCLEIDO_7, RADIONUCLEIDO_8, RADIONUCLEIDO_9, RADIONUCLEIDO_10, RADIONUCLEIDO_11, RADIONUCLEIDO_12, PROVEEDOR_DE_ORIGEN, " +
       " USO_DE_ORIGEN, USUARIO_PRINCIPAL, FECHA_REFERENCIA_1, ACTIVIDAD_CORREGIDA, FECHA_BAJA_ESTIMADA, LUGAR_DEPOSITO " +
       " FROM inventa WHERE (LEFT(ESTADO_DE_LA_FUENTE, 4) <> 'BAJA')" +
       " ORDER BY TIPO_DE_FUENTE, ID_FUENTE_RADIACTIVA"
        Dim commando1 As New SqlCommand(ConsultaSQL, conn)
        conn.Open()
        commando1.ExecuteNonQuery()
        Dim da As New SqlDataAdapter(commando1)
        ds = New DataSet()
        da.Fill(ds, "inventa")
        DataGrid1.DataSource = ds
        DataGrid1.DataMember = "inventa"
        cuenta = DataGrid1.RowCount
        If encontrado = 0 Then
            MsgBox("No se encontró el radionucleído buscado")
        End If





    End Sub

    Private Sub DataGrid1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles DataGrid1.DoubleClick

        'Dim xlongi, respbus, xlongi1 As Short
        'Dim criterio As String
        'Dim radio, Tipo As String
        'Dim xlongi2 As Short

        Dim Xfuente As String
        Xfuente = DataGrid1.SelectedCells(0).Value.ToString
        opc = 999
        Form3.IdFuente.Text = Xfuente

        Form3.ShowDialog()


    End Sub
End Class
