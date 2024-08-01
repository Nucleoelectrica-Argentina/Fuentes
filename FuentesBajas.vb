Imports CrystalDecisions
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class FuentesBajas

    Friend SchemaSerializationMode As SchemaSerializationMode
    Friend DataSetName As String

    Property Fuentes_xnro As DataSet1.Fuentes_xnroDataTable

    Private Sub FuentesBajas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Dim cnn As SqlConnection
            cnn = New SqlConnection(Conexion.CadenaConexion)
            Dim SQLConsulta As String
            SQLConsulta = "SELECT ID_FUENTE_RADIACTIVA AS FUENTE, CLASIFICACION, TIPO_DE_FUENTE AS TIPO, GEOMETRIA_SOPORTE AS GEOMETRIA, " +
                          " RADIONUCLEIDO_1 + '--' + RADIONUCLEIDO_2 + '--' + RADIONUCLEIDO_3 AS RADIONUCLEIDOS, BAJA_REAL AS FECHABAJA " +
                          " FROM dbo.inventa WHERE BAJA_REAL Is Not NULL"
            Dim cmd As New SqlCommand(SQLConsulta, cnn)
            cmd.CommandType = CommandType.Text
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            da.Fill(ds, "inventa")
            Dim rp As New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            Dim ur As String = (Application.StartupPath & "\ListadoFuentesBaja.rpt").ToString()
            ' Dim ur As String = ("D:\VBFuentes\Fuentes\Fuentes\ListadoFuentesBaja.rpt").ToString()
            rp.Load(ur, [Shared].OpenReportMethod.OpenReportByDefault)
            rp.SetDatabaseLogon("desa", "_123@456", "SQLSERVERPRO", "inventa")
            rp.SetDataSource(ds.Tables(0))
            CrystalReportViewer1.ReportSource = rp
            CrystalReportViewer1.RefreshReport()
        Catch ex As Exception
            ex.Message.ToString()
        End Try
    End Sub
End Class