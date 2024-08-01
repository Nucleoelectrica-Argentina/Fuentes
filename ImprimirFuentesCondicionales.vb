Imports CrystalDecisions.CrystalReports
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class ImprimirFuentesCondicionales
    Public fref As String
    Public idfuente As String
    Public clasif As String
    Public tipo As String
    Public Geome As String
    Public Dimen As String
    Public Radio1, Radio2, Radio3, Radio4, Radio5, Radio6, Radio7, Radio8, Radio9, Radio10, Radio11, Radio12 As String
    Public semi1, semi2, semi3, semi4, semi5, semi6, semi7, semi8, semi9, semi10, semi11, semi12 As Long
    Public semi1fin, semi2fin, semi3fin, semi4fin, semi5fin, semi6fin, semi7fin, semi8fin, semi9fin, semi10fin, semi11fin, semi12fin As Double
    Public semi1fin1, semi2fin1, semi3fin1, semi4fin1, semi5fin1, semi6fin1, semi7fin1, semi8fin1, semi9fin1, semi10fin1, semi11fin1, semi12fin1 As String
    Public SQLConsulta1, SQLConsulta As String
    Public fref1 As Date
    Public miDataTable As New DataTable
    Public hoy2 As String
    Public tiem As Integer
    Private Sub ImprimirFuentesCondicionales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        BorrarTablaTemporal()
        filtro1()
        ArmaReporte()
    End Sub
    Sub BorrarTablaTemporal()
        Dim cone1 As SqlConnection
        cone1 = New SqlConnection(Conexion.CadenaConexion)
        Dim SQLBorrar As String
        SQLBorrar = "Delete from tmpcondic"
        Dim comd2 As New SqlCommand(SQLBorrar, cone1)
        cone1.Open()
        comd2.CommandType = CommandType.Text
        comd2.ExecuteNonQuery()
        cone1.Close()
    End Sub

    Sub filtro1()
        MsgBox("Procesando datos por favor espere", MsgBoxStyle.Information)

        hoy2 = Date.Today()
        Try
            'actini As Double, semi1 As Long, fref1 As Date, acti1 As Double
            Dim cnn1 As SqlConnection
            cnn1 = New SqlConnection(Conexion.CadenaConexion)
            Dim SQLConsulta1 As String
            SQLConsulta1 = " SELECT ID_FUENTE_RADIACTIVA, CLASIFICACION, TIPO_DE_FUENTE, GEOMETRIA_SOPORTE, DIMENSIONES, RADIONUCLEIDO_1, " +
            "SEMIPERIODO_1_DIAS, RADIONUCLEIDO_2, RADIONUCLEIDO_3, RADIONUCLEIDO_4, RADIONUCLEIDO_5, RADIONUCLEIDO_6, RADIONUCLEIDO_7," +
            "RADIONUCLEIDO_8, RADIONUCLEIDO_9, RADIONUCLEIDO_10, FECHA_REFERENCIA_1, SEMIPERIODO_2_DIAS, SEMIPERIODO_3_DIAS, SEMIPERIODO_4_DIAS," +
            "SEMIPERIODO_5_DIAS, SEMIPERIODO_6_DIAS, SEMIPERIODO_7_DIAS, SEMIPERIODO_8_DIAS, SEMIPERIODO_9_DIAS, RADIONUCLEIDO_11," +
            "SEMIPERIODO_10_DIAS, SEMIPERIODO_11_DIAS, RADIONUCLEIDO_12, SEMIPERIODO_12_DIAS " +
            " FROM inventa " +
            " WHERE   (FECHA_REFERENCIA_1 IS NOT NULL)  " +
            " ORDER BY ID_FUENTE_RADIACTIVA "
            Dim cmd1 As New SqlCommand(SQLConsulta1, cnn1)
            cmd1.CommandType = CommandType.Text
            Dim da As New SqlDataAdapter(cmd1)
            Dim ds As New DataSet()
            da.Fill(ds, "inventa")
            gridFuentes.DataSource = ds
            gridFuentes.DataMember = "inventa"
            For Each Dtr In gridFuentes.Rows
                Label1.Text = gridFuentes.Rows.Count.ToString()

                idfuente = Dtr.Cells("ID_FUENTE_RADIACTIVA").Value.ToString
                clasif = Dtr.Cells("CLASIFICACION").Value.ToString
                Geome = Dtr.Cells("GEOMETRIA_SOPORTE").Value.ToString
                tipo = Dtr.Cells("TIPO_DE_FUENTE").Value.ToString
                Dimen = Dtr.Cells("DIMENSIONES").Value.ToString
                fref1 = Dtr.Cells("FECHA_REFERENCIA_1").Value.ToString
                Radio1 = Dtr.Cells("RADIONUCLEIDO_1").Value.ToString
                Radio2 = Dtr.Cells("RADIONUCLEIDO_2").Value.ToString
                Radio3 = Dtr.Cells("RADIONUCLEIDO_3").Value.ToString
                Radio4 = Dtr.Cells("RADIONUCLEIDO_4").Value.ToString
                Radio5 = Dtr.Cells("RADIONUCLEIDO_5").Value.ToString
                Radio6 = Dtr.Cells("RADIONUCLEIDO_6").Value.ToString
                Radio7 = Dtr.Cells("RADIONUCLEIDO_7").Value.ToString
                Radio8 = Dtr.Cells("RADIONUCLEIDO_8").Value.ToString
                Radio9 = Dtr.Cells("RADIONUCLEIDO_9").Value.ToString
                Radio10 = Dtr.Cells("RADIONUCLEIDO_10").Value.ToString
                Radio11 = Dtr.Cells("RADIONUCLEIDO_11").Value.ToString
                Radio12 = Dtr.Cells("RADIONUCLEIDO_12").Value.ToString
                '----------------1----------------------------------------------
                If Dtr.Cells("SEMIPERIODO_1_DIAS").Value.ToString = "" Then
                    semi1 = 0
                Else
                    semi1 = Dtr.Cells("SEMIPERIODO_1_DIAS").Value.ToString
                End If
                If semi1 > 0 Then
                    tiem = DateDiff("d", fref1, hoy2)
                    'semi1 = Dtr("SEMIPERIODO_1_DIAS").ToString
                    semi1fin = semi1 / tiem
                    semi1fin1 = semi1fin.ToString
                End If
                '---------------------------------2----------------------------
                If Dtr.Cells("SEMIPERIODO_2_DIAS").Value.ToString = "" Then
                    semi2 = 0
                Else
                    semi2 = Dtr.Cells("SEMIPERIODO_2_DIAS").Value.ToString
                End If
                If semi2 > 0 Then
                    tiem = DateDiff("d", fref1, hoy2)
                    'semi2 = Dtr("SEMIPERIODO_2_DIAS").ToString
                    semi2fin = semi2 / tiem
                    semi2fin1 = semi2fin.ToString
                End If
                '-----------------------3--------------------------------------
                If Dtr.Cells("SEMIPERIODO_3_DIAS").Value.ToString = "" Then
                    semi3 = 0
                Else
                    semi3 = Dtr.Cells("SEMIPERIODO_3_DIAS").Value.ToString
                End If

                If semi3 > 0 Then
                    tiem = DateDiff("d", fref1, hoy2)
                    'semi3 = Dtr("SEMIPERIODO_3_DIAS").ToString
                    semi3fin = semi3 / tiem
                    semi3fin1 = semi3fin.ToString
                End If
                '-----------------------4 ------------------------------
                If Dtr.Cells("SEMIPERIODO_4_DIAS").Value.ToString = "" Then
                    semi4 = 0
                Else
                    semi4 = Dtr.Cells("SEMIPERIODO_4_DIAS").Value.ToString
                End If
                If semi4 > 0 Then
                    tiem = DateDiff("d", fref1, hoy2)
                    ' semi4 = Dtr("SEMIPERIODO_4_DIAS").ToString
                    semi4fin = semi4 / tiem
                    semi4fin1 = semi4fin.ToString
                End If
                '-------------------------5---------------------------------
                If Dtr.Cells("SEMIPERIODO_5_DIAS").Value.ToString = "" Then
                    semi5 = 0
                Else
                    semi5 = Dtr.Cells("SEMIPERIODO_5_DIAS").Value.ToString
                End If
                If semi5 > 0 Then
                    tiem = DateDiff("d", fref1, hoy2)
                    'semi5 = Dtr("SEMIPERIODO_5_DIAS").ToString
                    semi5fin = semi5 / tiem
                    semi5fin1 = semi5fin.ToString
                End If
                '--------------------------------6-----------------------------
                If Dtr.Cells("SEMIPERIODO_6_DIAS").Value.ToString = "" Then
                    semi6 = 0
                Else

                    semi6 = Dtr.Cells("SEMIPERIODO_6_DIAS").Value.ToString
                End If

                If semi6 > 0 Then
                    tiem = DateDiff("d", fref1, hoy2)
                    'semi6 = Dtr("SEMIPERIODO_6_DIAS").ToString
                    semi6fin = semi6 / tiem
                    semi6fin1 = semi6fin.ToString
                End If
                '-----------------------------------7---------------------------
                If Dtr.Cells("SEMIPERIODO_7_DIAS").Value.ToString = "" Then
                    semi7 = 0
                Else
                    semi7 = Dtr.Cells("SEMIPERIODO_7_DIAS").Value.ToString
                End If
                If semi7 > 0 Then
                    tiem = DateDiff("d", fref1, hoy2)
                    'semi7 = Dtr("SEMIPERIODO_7_DIAS").ToString
                    semi7fin = semi4 / tiem
                    semi7fin1 = semi7fin.ToString
                End If
                '-------------------------------8----------------------------------
                If Dtr.Cells("SEMIPERIODO_8_DIAS").Value.ToString = "" Then
                    semi8 = 0
                Else

                    semi8 = Dtr.Cells("SEMIPERIODO_8_DIAS").Value.ToString
                End If
                If semi8 > 0 Then
                    tiem = DateDiff("d", fref1, hoy2)
                    'semi4 = Dtr("SEMIPERIODO_1_DIAS").ToString
                    semi8fin = semi8 / tiem
                    semi8fin1 = semi8fin.ToString
                End If
                '---------------------------------9-----------------------------------
                If Dtr.Cells("SEMIPERIODO_9_DIAS").Value.ToString = "" Then
                    semi9 = 0
                Else
                    semi9 = Dtr.Cells("SEMIPERIODO_9_DIAS").Value.ToString
                End If
                If semi9 > 0 Then
                    tiem = DateDiff("d", fref1, hoy2)
                    'semi4 = Dtr("SEMIPERIODO_1_DIAS").ToString
                    semi9fin = semi9 / tiem
                    semi9fin1 = semi9fin.ToString
                End If
                '-------------------------10------------------------------------
                If Dtr.Cells("SEMIPERIODO_10_DIAS").Value.ToString = "" Then
                    semi10 = 0
                Else
                    semi10 = Dtr.Cells("SEMIPERIODO_10_DIAS").Value.ToString
                End If
                If semi10 > 0 Then
                    tiem = DateDiff("d", fref1, hoy2)
                    'semi10 = Dtr("SEMIPERIODO_1_DIAS").ToString
                    semi10fin = semi10 / tiem
                    semi10fin1 = semi10fin.ToString
                End If
                '--------------------------11-------------------------------
                If Dtr.Cells("SEMIPERIODO_11_DIAS").Value.ToString = "" Then
                    semi11 = 0
                Else
                    semi11 = Dtr.Cells("SEMIPERIODO_11_DIAS").Value.ToString
                End If
                If semi11 > 0 Then
                    tiem = DateDiff("d", fref1, hoy2)
                    '  semi11 = Dtr("SEMIPERIODO_1_DIAS").ToString
                    semi11fin = semi11 / tiem
                    semi11fin1 = semi11fin.ToString
                End If
                '--------------------12--------------------------------------
                If Dtr.Cells("SEMIPERIODO_12_DIAS").Value.ToString = "" Then
                    semi12 = 0
                Else
                    semi12 = Dtr.Cells("SEMIPERIODO_12_DIAS").Value.ToString
                End If
                If semi12 > 0 Then
                    tiem = DateDiff("d", fref1, hoy2)
                    'semi4 = Dtr("SEMIPERIODO_1_DIAS").ToString
                    semi12fin = semi12 / tiem
                    semi12fin1 = semi12fin.ToString
                End If

                If semi1fin1 > 2 Or semi2fin1 > 2 Or semi3fin1 > 2 Or semi4fin1 > 2 Or semi5fin1 > 2 Or semi6fin1 > 2 Or semi7fin1 > 2 Or semi8fin1 > 2 Or semi9fin1 > 2 Or semi10fin1 > 2 Or semi11fin1 > 2 Or semi12fin1 > 2 Then
                    Try
                        Dim conn2 As New SqlConnection(Conexion.CadenaConexion)
                        Dim SQLtmpCondi As String = "INSERT INTO tmpcondic (ID_FUENTE_RADIACTIVA, CLASIFICACION, GEOMETRIA_SOPORTE, DIMENSIONES, RADIONUCLEIDO_1, SEMIPERIODO_1_DIAS, RADIONUCLEIDO_2, " +
                        " SEMIPERIODO_2_DIAS, RADIONUCLEIDO_3, SEMIPERIODO_3_DIAS, RADIONUCLEIDO_4, SEMIPERIODO_4_DIAS, RADIONUCLEIDO_5, SEMIPERIODO_5_DIAS, " +
                        "     RADIONUCLEIDO_6, SEMIPERIODO_6_DIAS, RADIONUCLEIDO_7, SEMIPERIODO_7_DIAS, RADIONUCLEIDO_8, SEMIPERIODO_8_DIAS, RADIONUCLEIDO_9, " +
                        "     SEMIPERIODO_9_DIAS, RADIONUCLEIDO_10, SEMIPERIODO_10_DIAS, RADIONUCLEIDO_11, SEMIPERIODO_11_DIAS, RADIONUCLEIDO_12, " +
                        "     SEMIPERIODO_12_DIAS, FECHA_REFERENCIA_1, TIPO_DE_FUENTE) VALUES('" + idfuente + "' , '" + clasif + "', '" + Geome + "', '" + Dimen + "' , '" + Radio1 + "', '" + semi1fin1 + "', '" + Radio2 + "', '" + semi2fin1 + "' , '" + Radio3 + "', '" + semi3fin1 + "', '" + Radio4 + "', '" + semi4fin1 + "', '" + Radio5 + "' , '" + semi5fin1 + "' , '" + Radio6 + "' , '" + semi6fin1 + "' ,  '" + Radio7 + "' , '" + semi7fin1 + "', '" + Radio8 + "' , '" + semi8fin1 + "', '" + Radio9 + "', '" + semi9fin1 + "', '" + Radio10 + "', '" + semi10fin1 + "', '" + Radio11 + "', '" + semi11fin1 + "', '" + Radio12 + "', '" + semi12fin1 + "', '" + fref1.ToString + "', '" + tipo + "' ) "
                        Dim comando2 As New SqlCommand(SQLtmpCondi, conn2)
                        conn2.Open()
                        comando2.CommandType = CommandType.Text
                        comando2.ExecuteNonQuery()
                        conn2.Close()
                    Catch ex As Exception
                        ex.Message.ToString()
                    End Try
                End If

            Next
            cnn1.Close()

        Catch ex As Exception
            ex.Message.ToString()
        End Try
    End Sub
    Sub ArmaReporte()
        MsgBox("Armando Reporte...", MsgBoxStyle.Information)
        Try
            Dim cnn3 As SqlConnection
            cnn3 = New SqlConnection(Conexion.CadenaConexion)
            Dim SQLReporte As String
            SQLReporte = "SELECT ID_FUENTE_RADIACTIVA, CLASIFICACION, GEOMETRIA_SOPORTE, DIMENSIONES, RADIONUCLEIDO_1, SEMIPERIODO_1_DIAS, RADIONUCLEIDO_2, " +
          " SEMIPERIODO_2_DIAS, RADIONUCLEIDO_3, SEMIPERIODO_3_DIAS, RADIONUCLEIDO_4, SEMIPERIODO_4_DIAS, RADIONUCLEIDO_5, SEMIPERIODO_5_DIAS, " +
          " RADIONUCLEIDO_6, SEMIPERIODO_6_DIAS, RADIONUCLEIDO_7, SEMIPERIODO_7_DIAS, RADIONUCLEIDO_8, SEMIPERIODO_8_DIAS, RADIONUCLEIDO_9, " +
          " SEMIPERIODO_9_DIAS, RADIONUCLEIDO_10, SEMIPERIODO_10_DIAS, RADIONUCLEIDO_11, SEMIPERIODO_11_DIAS, RADIONUCLEIDO_12, " +
          " SEMIPERIODO_12_DIAS, FECHA_REFERENCIA_1, TIPO_DE_FUENTE " +
          " FROM tmpcondic " +
            " ORDER BY ID_FUENTE_RADIACTIVA "
            ' " WHERE(SEMIPERIODO_1_DIAS / DateDiff(d, FECHA_REFERENCIA_1, GETDATE()) > 2) " +

            Dim cmd3 As New SqlCommand(SQLReporte, cnn3)
            cmd3.CommandType = CommandType.Text
            Dim da3 As New SqlDataAdapter(cmd3)
            Dim ds3 As New DataSet()
            da3.Fill(ds3, "tmpcondic")
            Dim rp As New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            Dim ur As String = (Application.StartupPath & "\RUsoCondicional.rpt").ToString()
            'Dim ur As String = ("D:\VBFuentes\Fuentes\Fuentes\FuentesCondicional.rpt").ToString()
            rp.Load(ur, CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            rp.SetDatabaseLogon("desa", "_123@456", "SQLSERVERPRO", "inventa")
            rp.SetDataSource(ds3.Tables(0))
            CrystalReportViewer1.ReportSource = rp
            CrystalReportViewer1.RefreshReport()
        Catch ex As Exception
            ex.Message.ToString()
        End Try
    End Sub


   
End Class