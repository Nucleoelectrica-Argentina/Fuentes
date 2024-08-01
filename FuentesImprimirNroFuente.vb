Imports System.Data.Sql
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports

Public Class FuentesImprimirNroFuente
    Public SQLConsulta1, SQLConsulta As String
    Public cuenta As Integer
    Public actini As Double
    Public acti11 As String
    Public semi1 As Long
    Public fref1 As Date
    Public acti1 As Double
    Public Fuente As String
    Public Identificacion As String
    Public RadioPpal As String
    Public TipoRadio As String
    Public LugarDeposito As String
    Public Actividad As String
    Public miDataTable As New DataTable
    Public valor As String
    Public tipo_fuen, Unidad As String
    Public Fuentes_fijas As String
    Public Unidad_activ As String



    Private Sub FuentesImprimirNroFuente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tipo_fuen = UCase(InputBox("Ingrese la primera letra de la fuente ó * para todas"))
        If tipo_fuen <> "*" Then
            Unidad = UCase(InputBox("Ingrese 1 para CNA1, 2 para CNA2 * para todas"))
            Fuentes_fijas = UCase(InputBox("Desea imprimir las fuentes fijas S / N?"))
        End If
        calc_acti()
        ArmarReporte()
    End Sub
    Private Sub calc_acti()
        Try
            Dim cnn1 As SqlConnection
            cnn1 = New SqlConnection(Conexion.CadenaConexion)
            If tipo_fuen = "A" And Unidad = "1" And Fuentes_fijas <> "S" Then ' todas las A de CNAI sin las fijas
                SQLConsulta1 = "SELECT ID_FUENTE_RADIACTIVA, ID_FABRICACION, RADIONUCLEIDO_1, TIPO_DE_EMISION_1, LUGAR_DEPOSITO, ACTIVIDAD_INICIAL_1, SEMIPERIODO_1_DIAS, " +
                " FECHA_REFERENCIA_1, ESTADO_DE_LA_FUENTE, actividadcalc, UNIDAD_ACTIVIDAD " +
                " FROM inventa " +
                " WHERE (ESTADO_DE_LA_FUENTE NOT LIKE 'B%') AND (ID_FUENTE_RADIACTIVA >= 'A0001') AND (ID_FUENTE_RADIACTIVA <= 'A0999') ORDER BY ID_FUENTE_RADIACTIVA"
                'mid([Id Fuente radiactiva],2,4) between 1 and 999
            Else
                If tipo_fuen = "A" And Unidad = "2" And Fuentes_fijas <> "S" Then
                    SQLConsulta1 = "SELECT ID_FUENTE_RADIACTIVA, ID_FABRICACION, RADIONUCLEIDO_1, TIPO_DE_EMISION_1, LUGAR_DEPOSITO, ACTIVIDAD_INICIAL_1, SEMIPERIODO_1_DIAS, " +
                                   " FECHA_REFERENCIA_1, ESTADO_DE_LA_FUENTE, actividadcalc, UNIDAD_ACTIVIDAD " +
                                   " FROM inventa " +
                                   " WHERE (ESTADO_DE_LA_FUENTE NOT LIKE 'B%') AND (ID_FUENTE_RADIACTIVA >= 'A1000') AND (ID_FUENTE_RADIACTIVA <= 'A1999') ORDER BY ID_FUENTE_RADIACTIVA"
                Else


                    If tipo_fuen = "A" And Unidad = "1" And Fuentes_fijas = "S" Then

                        SQLConsulta1 = "SELECT ID_FUENTE_RADIACTIVA, ID_FABRICACION, RADIONUCLEIDO_1, TIPO_DE_EMISION_1, LUGAR_DEPOSITO, ACTIVIDAD_INICIAL_1, SEMIPERIODO_1_DIAS, " +
                                                           " FECHA_REFERENCIA_1, ESTADO_DE_LA_FUENTE, actividadcalc, UNIDAD_ACTIVIDAD " +
                                                           " FROM inventa " +
                                                           " WHERE (ESTADO_DE_LA_FUENTE NOT LIKE 'B%') AND (ID_FUENTE_RADIACTIVA >= 'A2000') AND (ID_FUENTE_RADIACTIVA <= 'A2999') ORDER BY ID_FUENTE_RADIACTIVA"

                    Else
                        If tipo_fuen = "A" And Unidad = "2" And Fuentes_fijas = "S" Then
                            SQLConsulta1 = "SELECT ID_FUENTE_RADIACTIVA, ID_FABRICACION, RADIONUCLEIDO_1, TIPO_DE_EMISION_1, LUGAR_DEPOSITO, ACTIVIDAD_INICIAL_1, SEMIPERIODO_1_DIAS, " +
                                                                                     " FECHA_REFERENCIA_1, ESTADO_DE_LA_FUENTE, actividadcalc, UNIDAD_ACTIVIDAD " +
                                                                                     " FROM inventa " +
                                                                                     " WHERE (ESTADO_DE_LA_FUENTE NOT LIKE 'B%') AND (ID_FUENTE_RADIACTIVA >= 'A3000') AND (ID_FUENTE_RADIACTIVA <= 'A3999') ORDER BY ID_FUENTE_RADIACTIVA"
                        Else
                            If tipo_fuen = "A" And Unidad = "*" Then
                                SQLConsulta1 = "SELECT ID_FUENTE_RADIACTIVA, ID_FABRICACION, RADIONUCLEIDO_1, TIPO_DE_EMISION_1, LUGAR_DEPOSITO, ACTIVIDAD_INICIAL_1, SEMIPERIODO_1_DIAS, " +
                                                                                                                 " FECHA_REFERENCIA_1, ESTADO_DE_LA_FUENTE, actividadcalc, UNIDAD_ACTIVIDAD " +
                                                                                                                 " FROM inventa " +
                                                                                                                 " WHERE (ESTADO_DE_LA_FUENTE NOT LIKE 'B%') AND (ID_FUENTE_RADIACTIVA LIKE 'A%') ORDER BY ID_FUENTE_RADIACTIVA"

                            Else

                                If tipo_fuen = "B" Then
                                    SQLConsulta1 = "SELECT ID_FUENTE_RADIACTIVA, ID_FABRICACION, RADIONUCLEIDO_1, TIPO_DE_EMISION_1, LUGAR_DEPOSITO, ACTIVIDAD_INICIAL_1, SEMIPERIODO_1_DIAS, " +
                                                                   " FECHA_REFERENCIA_1, ESTADO_DE_LA_FUENTE, actividadcalc, UNIDAD_ACTIVIDAD " +
                                                                   " FROM inventa " +
                                                                   " WHERE (ESTADO_DE_LA_FUENTE NOT LIKE 'B%') AND (ID_FUENTE_RADIACTIVA LIKE 'B%') ORDER BY ID_FUENTE_RADIACTIVA"
                                Else

                                    If tipo_fuen = "C" And Unidad = "1" And Fuentes_fijas <> "S" Then ' Todas las C de ATUCHA I SIN LAS FIJAS
                                        SQLConsulta1 = "SELECT ID_FUENTE_RADIACTIVA, ID_FABRICACION, RADIONUCLEIDO_1, TIPO_DE_EMISION_1, LUGAR_DEPOSITO, ACTIVIDAD_INICIAL_1, SEMIPERIODO_1_DIAS, " +
                                           " FECHA_REFERENCIA_1, ESTADO_DE_LA_FUENTE, actividadcalc, UNIDAD_ACTIVIDAD " +
                                           " FROM inventa " +
                                           " WHERE (ESTADO_DE_LA_FUENTE NOT LIKE 'B%') AND (ID_FUENTE_RADIACTIVA >= 'C0001') AND (ID_FUENTE_RADIACTIVA <= 'C0999') ORDER BY ID_FUENTE_RADIACTIVA"
                                    Else
                                        If tipo_fuen = "C" And Unidad = "2" And Fuentes_fijas <> "S" Then ' Todas las C de ATUCHA II SIN LAS FIJAS
                                            SQLConsulta1 = "SELECT ID_FUENTE_RADIACTIVA, ID_FABRICACION, RADIONUCLEIDO_1, TIPO_DE_EMISION_1, LUGAR_DEPOSITO, ACTIVIDAD_INICIAL_1, SEMIPERIODO_1_DIAS, " +
                                           " FECHA_REFERENCIA_1, ESTADO_DE_LA_FUENTE, actividadcalc, UNIDAD_ACTIVIDAD " +
                                           " FROM inventa " +
                                           " WHERE (ESTADO_DE_LA_FUENTE NOT LIKE 'B%') AND (ID_FUENTE_RADIACTIVA >= 'C1000') AND (ID_FUENTE_RADIACTIVA <= 'C1999') ORDER BY ID_FUENTE_RADIACTIVA"
                                        Else
                                            If tipo_fuen = "C" And Unidad = "1" And Fuentes_fijas = "S" Then 'solo las fijas C de Atucha I
                                                SQLConsulta1 = "SELECT ID_FUENTE_RADIACTIVA, ID_FABRICACION, RADIONUCLEIDO_1, TIPO_DE_EMISION_1, LUGAR_DEPOSITO, ACTIVIDAD_INICIAL_1, SEMIPERIODO_1_DIAS, " +
                                          " FECHA_REFERENCIA_1, ESTADO_DE_LA_FUENTE, actividadcalc, UNIDAD_ACTIVIDAD " +
                                          " FROM inventa " +
                                          " WHERE (ESTADO_DE_LA_FUENTE NOT LIKE 'B%') AND (ID_FUENTE_RADIACTIVA >= 'C2000') AND (ID_FUENTE_RADIACTIVA <= 'C2999') ORDER BY ID_FUENTE_RADIACTIVA"
                                            Else
                                                If tipo_fuen = "C" And Unidad = "2" And Fuentes_fijas = "S" Then ' solo las fijas de Atucha II
                                                    SQLConsulta1 = "SELECT ID_FUENTE_RADIACTIVA, ID_FABRICACION, RADIONUCLEIDO_1, TIPO_DE_EMISION_1, LUGAR_DEPOSITO, ACTIVIDAD_INICIAL_1, SEMIPERIODO_1_DIAS, " +
                                                                                      " FECHA_REFERENCIA_1, ESTADO_DE_LA_FUENTE, actividadcalc, UNIDAD_ACTIVIDAD " +
                                                                                      " FROM inventa " +
                                                                                      " WHERE (ESTADO_DE_LA_FUENTE NOT LIKE 'B%') AND (ID_FUENTE_RADIACTIVA >= 'C3000') AND (ID_FUENTE_RADIACTIVA <= 'C3999') ORDER BY ID_FUENTE_RADIACTIVA"
                                                Else

                                                    If tipo_fuen = "C" And Unidad = "*" Then ' Todas las C
                                                        SQLConsulta1 = "SELECT ID_FUENTE_RADIACTIVA, ID_FABRICACION, RADIONUCLEIDO_1, TIPO_DE_EMISION_1, LUGAR_DEPOSITO, ACTIVIDAD_INICIAL_1, SEMIPERIODO_1_DIAS, " +
                                                                                     " FECHA_REFERENCIA_1, ESTADO_DE_LA_FUENTE, actividadcalc, UNIDAD_ACTIVIDAD " +
                                                                                     " FROM inventa " +
                                                                                     " WHERE (ESTADO_DE_LA_FUENTE NOT LIKE 'B%') AND (ID_FUENTE_RADIACTIVA LIKE 'C%') ORDER BY ID_FUENTE_RADIACTIVA"

                                                    Else
                                                        If tipo_fuen = "*" Then
                                                            SQLConsulta1 = "SELECT ID_FUENTE_RADIACTIVA, ID_FABRICACION, RADIONUCLEIDO_1, TIPO_DE_EMISION_1, LUGAR_DEPOSITO, ACTIVIDAD_INICIAL_1, SEMIPERIODO_1_DIAS, " +
                                                                                     " FECHA_REFERENCIA_1, ESTADO_DE_LA_FUENTE, actividadcalc, UNIDAD_ACTIVIDAD " +
                                                                                     " FROM inventa " +
                                                                                     " WHERE (ESTADO_DE_LA_FUENTE NOT LIKE 'B%') ORDER BY ID_FUENTE_RADIACTIVA"
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            Dim cmd1 As New SqlCommand(SQLConsulta1, cnn1)
            cmd1.CommandType = CommandType.Text
            Dim da As New SqlDataAdapter(cmd1)
            Dim ds As New DataSet()
            da.Fill(ds, "inventa")
            gridfuentes.DataSource = ds
            gridfuentes.DataMember = "inventa"
            For Each Dtr In gridfuentes.Rows
                ' Label2.Text = gridfuentes.Rows.Count.ToString()
                actini = Dtr.Cells("ACTIVIDAD_INICIAL_1").Value.ToString()
                semi1 = Dtr.Cells("SEMIPERIODO_1_DIAS").Value.ToString()
                If Dtr.Cells("FECHA_REFERENCIA_1").Value.ToString = "" Then
                    fref1 = System.DateTime.Today
                Else
                    fref1 = Dtr.Cells("FECHA_REFERENCIA_1").Value

                End If
                '  calc_acti(actini, semi1, fref1, acti1)
                Dim tiem As Integer, semi As Double
                If semi1 > 0 Then
                    tiem = DateDiff("d", fref1, Now)
                    semi = tiem / semi1
                    acti1 = actini * Math.Exp(-0.693 * semi)
                    acti11 = acti1.ToString("0.##E+00", System.Globalization.CultureInfo.InvariantCulture)
                End If
                ' acti = actini * (System.Math.Exp(-0.693 * (tiem / semi)))
                Fuente = Dtr.Cells("ID_FUENTE_RADIACTIVA").Value.ToString()
                Unidad_activ = Dtr.Cells("UNIDAD_ACTIVIDAD").Value.ToString()


                Try
                    Dim conn2 As New SqlConnection(Conexion.CadenaConexion)
                    Dim UpdateSQL As String = "UPDATE [inventa] SET [actividadcalc] = '" + acti11 + "' WHERE ID_FUENTE_RADIACTIVA = '" + Fuente + "' ;"
                    Dim comando As New SqlCommand(UpdateSQL, conn2)
                    conn2.Open()
                    comando.ExecuteNonQuery()
                    conn2.Close()
                Catch ex As Exception
                    ex.Message.ToString()
                End Try

            Next

            cnn1.Close()

            MsgBox("finalizo proceso de calculo" + vbExclamation)

        Catch ex As Exception
            ex.Message.ToString()

        End Try

    End Sub
    Sub ArmarReporte()

        Try
            Dim cnn As SqlConnection
            cnn = New SqlConnection(Conexion.CadenaConexion)
            If tipo_fuen = "A" And Unidad = "1" And Fuentes_fijas <> "S" Then ' todas las A de CNAI sin las fijas
                SQLConsulta1 = "SELECT ID_FUENTE_RADIACTIVA, ID_FABRICACION, RADIONUCLEIDO_1, TIPO_DE_EMISION_1, LUGAR_DEPOSITO, ACTIVIDAD_INICIAL_1, SEMIPERIODO_1_DIAS, " +
                " FECHA_REFERENCIA_1, ESTADO_DE_LA_FUENTE, actividadcalc, UNIDAD_ACTIVIDAD " +
                " FROM inventa " +
                " WHERE (ESTADO_DE_LA_FUENTE NOT LIKE 'B%') AND (ID_FUENTE_RADIACTIVA >= 'A0001') AND (ID_FUENTE_RADIACTIVA <= 'A0999') ORDER BY ID_FUENTE_RADIACTIVA"
                'mid([Id Fuente radiactiva],2,4) between 1 and 999
            Else
                If tipo_fuen = "A" And Unidad = "2" And Fuentes_fijas <> "S" Then
                    SQLConsulta1 = "SELECT ID_FUENTE_RADIACTIVA, ID_FABRICACION, RADIONUCLEIDO_1, TIPO_DE_EMISION_1, LUGAR_DEPOSITO, ACTIVIDAD_INICIAL_1, SEMIPERIODO_1_DIAS, " +
                                   " FECHA_REFERENCIA_1, ESTADO_DE_LA_FUENTE, actividadcalc , UNIDAD_ACTIVIDAD " +
                                   " FROM inventa " +
                                   " WHERE (ESTADO_DE_LA_FUENTE NOT LIKE 'B%') AND (ID_FUENTE_RADIACTIVA >= 'A1000') AND (ID_FUENTE_RADIACTIVA <= 'A1999') ORDER BY ID_FUENTE_RADIACTIVA"
                Else


                    If tipo_fuen = "A" And Unidad = "1" And Fuentes_fijas = "S" Then

                        SQLConsulta1 = "SELECT ID_FUENTE_RADIACTIVA, ID_FABRICACION, RADIONUCLEIDO_1, TIPO_DE_EMISION_1, LUGAR_DEPOSITO, ACTIVIDAD_INICIAL_1, SEMIPERIODO_1_DIAS, " +
                                                           " FECHA_REFERENCIA_1, ESTADO_DE_LA_FUENTE, actividadcalc , UNIDAD_ACTIVIDAD " +
                                                           " FROM inventa " +
                                                           " WHERE (ESTADO_DE_LA_FUENTE NOT LIKE 'B%') AND (ID_FUENTE_RADIACTIVA >= 'A2000') AND (ID_FUENTE_RADIACTIVA <= 'A2999') ORDER BY ID_FUENTE_RADIACTIVA"

                    Else
                        If tipo_fuen = "A" And Unidad = "2" And Fuentes_fijas = "S" Then
                            SQLConsulta1 = "SELECT ID_FUENTE_RADIACTIVA, ID_FABRICACION, RADIONUCLEIDO_1, TIPO_DE_EMISION_1, LUGAR_DEPOSITO, ACTIVIDAD_INICIAL_1, SEMIPERIODO_1_DIAS, " +
                                                                                     " FECHA_REFERENCIA_1, ESTADO_DE_LA_FUENTE, actividadcalc , UNIDAD_ACTIVIDAD " +
                                                                                     " FROM inventa " +
                                                                                     " WHERE (ESTADO_DE_LA_FUENTE NOT LIKE 'B%') AND (ID_FUENTE_RADIACTIVA >= 'A3000') AND (ID_FUENTE_RADIACTIVA <= 'A3999') ORDER BY ID_FUENTE_RADIACTIVA"
                        Else
                            If tipo_fuen = "A" And Unidad = "*" Then
                                SQLConsulta1 = "SELECT ID_FUENTE_RADIACTIVA, ID_FABRICACION, RADIONUCLEIDO_1, TIPO_DE_EMISION_1, LUGAR_DEPOSITO, ACTIVIDAD_INICIAL_1, SEMIPERIODO_1_DIAS, " +
                                                                                                                 " FECHA_REFERENCIA_1, ESTADO_DE_LA_FUENTE, actividadcalc , UNIDAD_ACTIVIDAD " +
                                                                                                                 " FROM inventa " +
                                                                                                                 " WHERE (ESTADO_DE_LA_FUENTE NOT LIKE 'B%') AND (ID_FUENTE_RADIACTIVA LIKE 'A%') ORDER BY ID_FUENTE_RADIACTIVA"

                            Else

                                If tipo_fuen = "B" Then
                                    SQLConsulta1 = "SELECT ID_FUENTE_RADIACTIVA, ID_FABRICACION, RADIONUCLEIDO_1, TIPO_DE_EMISION_1, LUGAR_DEPOSITO, ACTIVIDAD_INICIAL_1, SEMIPERIODO_1_DIAS, " +
                                                                   " FECHA_REFERENCIA_1, ESTADO_DE_LA_FUENTE, actividadcalc , UNIDAD_ACTIVIDAD " +
                                                                   " FROM inventa " +
                                                                   " WHERE (ESTADO_DE_LA_FUENTE NOT LIKE 'B%') AND (ID_FUENTE_RADIACTIVA LIKE 'B%') ORDER BY ID_FUENTE_RADIACTIVA"
                                Else

                                    If tipo_fuen = "C" And Unidad = "1" And Fuentes_fijas <> "S" Then ' Todas las C de ATUCHA I SIN LAS FIJAS
                                        SQLConsulta1 = "SELECT ID_FUENTE_RADIACTIVA, ID_FABRICACION, RADIONUCLEIDO_1, TIPO_DE_EMISION_1, LUGAR_DEPOSITO, ACTIVIDAD_INICIAL_1, SEMIPERIODO_1_DIAS, " +
                                           " FECHA_REFERENCIA_1, ESTADO_DE_LA_FUENTE, actividadcalc , UNIDAD_ACTIVIDAD " +
                                           " FROM inventa " +
                                           " WHERE (ESTADO_DE_LA_FUENTE NOT LIKE 'B%') AND (ID_FUENTE_RADIACTIVA >= 'C0001') AND (ID_FUENTE_RADIACTIVA <= 'C0999') ORDER BY ID_FUENTE_RADIACTIVA"
                                    Else
                                        If tipo_fuen = "C" And Unidad = "2" And Fuentes_fijas <> "S" Then ' Todas las C de ATUCHA II SIN LAS FIJAS
                                            SQLConsulta1 = "SELECT ID_FUENTE_RADIACTIVA, ID_FABRICACION, RADIONUCLEIDO_1, TIPO_DE_EMISION_1, LUGAR_DEPOSITO, ACTIVIDAD_INICIAL_1, SEMIPERIODO_1_DIAS, " +
                                           " FECHA_REFERENCIA_1, ESTADO_DE_LA_FUENTE, actividadcalc , UNIDAD_ACTIVIDAD " +
                                           " FROM inventa " +
                                           " WHERE (ESTADO_DE_LA_FUENTE NOT LIKE 'B%') AND (ID_FUENTE_RADIACTIVA >= 'C1000') AND (ID_FUENTE_RADIACTIVA <= 'C1999') ORDER BY ID_FUENTE_RADIACTIVA"
                                        Else
                                            If tipo_fuen = "C" And Unidad = "1" And Fuentes_fijas = "S" Then 'solo las fijas C de Atucha I
                                                SQLConsulta1 = "SELECT ID_FUENTE_RADIACTIVA, ID_FABRICACION, RADIONUCLEIDO_1, TIPO_DE_EMISION_1, LUGAR_DEPOSITO, ACTIVIDAD_INICIAL_1, SEMIPERIODO_1_DIAS, " +
                                          " FECHA_REFERENCIA_1, ESTADO_DE_LA_FUENTE, actividadcalc , UNIDAD_ACTIVIDAD " +
                                          " FROM inventa " +
                                          " WHERE (ESTADO_DE_LA_FUENTE NOT LIKE 'B%') AND (ID_FUENTE_RADIACTIVA >= 'C2000') AND (ID_FUENTE_RADIACTIVA <= 'C2999') ORDER BY ID_FUENTE_RADIACTIVA"
                                            Else
                                                If tipo_fuen = "C" And Unidad = "2" And Fuentes_fijas = "S" Then ' solo las fijas de Atucha II
                                                    SQLConsulta1 = "SELECT ID_FUENTE_RADIACTIVA, ID_FABRICACION, RADIONUCLEIDO_1, TIPO_DE_EMISION_1, LUGAR_DEPOSITO, ACTIVIDAD_INICIAL_1, SEMIPERIODO_1_DIAS, " +
                                                                                      " FECHA_REFERENCIA_1, ESTADO_DE_LA_FUENTE, actividadcalc , UNIDAD_ACTIVIDAD " +
                                                                                      " FROM inventa " +
                                                                                      " WHERE (ESTADO_DE_LA_FUENTE NOT LIKE 'B%') AND (ID_FUENTE_RADIACTIVA >= 'C3000') AND (ID_FUENTE_RADIACTIVA <= 'C3999') ORDER BY ID_FUENTE_RADIACTIVA"
                                                Else

                                                    If tipo_fuen = "C" And Unidad = "*" Then ' Todas las C
                                                        SQLConsulta1 = "SELECT ID_FUENTE_RADIACTIVA, ID_FABRICACION, RADIONUCLEIDO_1, TIPO_DE_EMISION_1, LUGAR_DEPOSITO, ACTIVIDAD_INICIAL_1, SEMIPERIODO_1_DIAS, " +
                                                                                     " FECHA_REFERENCIA_1, ESTADO_DE_LA_FUENTE, actividadcalc , UNIDAD_ACTIVIDAD " +
                                                                                     " FROM inventa " +
                                                                                     " WHERE (ESTADO_DE_LA_FUENTE NOT LIKE 'B%') AND (ID_FUENTE_RADIACTIVA LIKE 'C%') ORDER BY ID_FUENTE_RADIACTIVA"

                                                    Else
                                                        If tipo_fuen = "*" Then
                                                            SQLConsulta1 = "SELECT ID_FUENTE_RADIACTIVA, ID_FABRICACION, RADIONUCLEIDO_1, TIPO_DE_EMISION_1, LUGAR_DEPOSITO, ACTIVIDAD_INICIAL_1, SEMIPERIODO_1_DIAS, " +
                                                                                     " FECHA_REFERENCIA_1, ESTADO_DE_LA_FUENTE, actividadcalc , UNIDAD_ACTIVIDAD " +
                                                                                     " FROM inventa " +
                                                                                     " WHERE (ESTADO_DE_LA_FUENTE NOT LIKE 'B%') ORDER BY ID_FUENTE_RADIACTIVA"
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            Dim cmd As New SqlCommand(SQLConsulta1, cnn)
            cmd.CommandType = CommandType.Text
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            da.Fill(ds, "inventa")
            Dim rp As New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            Dim ur As String = (Application.StartupPath & "\Listadoxnro.rpt").ToString()

            '      Dim ur As String = ("D:\VBFuentes\Fuentes\Fuentes\Listadoxnro.rpt").ToString()
            rp.Load(ur, CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            rp.SetDatabaseLogon("desa", "_123@456", "SQLSERVERPRO", "inventa")
            ' rp.SetDatabaseLogon("desa", "_123@456", "SQLSERVERTEST", "inventa")
            rp.SetDataSource(ds.Tables(0))
            CrystalReportViewer1.ReportSource = rp
            CrystalReportViewer1.RefreshReport()
        Catch ex As Exception
            'ex.Message.ToString()
        End Try

    End Sub

    Private Sub CrystalReportViewer1_Click(sender As Object, e As System.EventArgs) Handles CrystalReportViewer1.Click
     

    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As System.EventArgs) Handles CrystalReportViewer1.Load
   
    End Sub
End Class