Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
Imports Microsoft.VisualBasic.Compatibility.VB6
Imports Microsoft.VisualBasic.VBMath


Public Class Form3
    Inherits System.Windows.Forms.Form

    Dim total As Short
    Dim fechabaja As Date
    'Dim cadena, moti As String
    Public encontrado As Boolean
    Public largo As Integer
    Public i As Short ' j
    Public indi, tipomov, resp As Short
    Public acticor As Integer
    Public fref2, bajareal, fref1, bajaest As Date
    Public fref2_1, bajareal_1, fref1_1, bajaest_1 As Date
    Public fref2_2, bajareal_2, fref1_2, bajaest_2 As Date
    Public fref2_3, bajareal_3, fref1_3, bajaest_3 As Date
    Public fref2_4, bajareal_4, fref1_4, bajaest_4 As Date
    Public fref2_5, bajareal_5, fref1_5, bajaest_5 As Date
    Public fref2_6, bajareal_6, fref1_6, bajaest_6 As Date
    Public fref2_7, bajareal_7, fref1_7, bajaest_7 As Date
    Public fref2_8, bajareal_8, fref1_8, bajaest_8 As Date
    Public fref2_9, bajareal_9, fref1_9, bajaest_9 As Date
    Public fref2_10, bajareal_10, fref1_10, bajaest_10 As Date
    Public fref2_11, bajareal_11, fref1_11, bajaest_11 As Date
    Public i1 As Integer, acti As Double, actini As Double, tiem As Long, vacti As Double
    Public semi, semi1 As Single, j As Integer, hoy As Date, vsemi, vsemi1 As Single
    Public acti_1 As Double, actini_1 As Double, tiem_1 As Long, vacti_1 As Double, vactini_1 As Double
    Public semi_1, semi1_1 As Single, j_1 As Integer, hoy_1 As Date, vsemi_1, vsemi1_1 As Single
    Public acti_2 As Double, actini_2 As Double, tiem_2 As Long, vacti_2 As Double, vactini_2 As Double
    Public semi_2, semi1_2 As Single, j_2 As Integer, hoy_2 As Date, vsemi_2, vsemi1_2 As Single
    Public acti_3 As Double, actini_3 As Double, tiem_3 As Long, vacti_3 As Double, vactini_3 As Double
    Public semi_3, semi1_3 As Single, j_3 As Integer, hoy_3 As Date, vsemi_3, vsemi1_3 As Single
    Public acti_4 As Double, actini_4 As Double, tiem_4 As Long, vacti_4 As Double, vactini_4 As Double
    Public semi_4, semi1_4 As Single, j_4 As Integer, hoy_4 As Date, vsemi_4, vsemi1_4 As Single
    Public acti_5 As Double, actini_5 As Double, tiem_5 As Long, vacti_5 As Double, vactini_5 As Double
    Public semi_5, semi1_5 As Single, j_5 As Integer, hoy_5 As Date, vsemi_5, vsemi1_5 As Single
    Public acti_6 As Double, actini_6 As Double, tiem_6 As Long, vacti_6 As Double, vactini_6 As Double
    Public semi_6, semi1_6 As Single, j_6 As Integer, hoy_6 As Date, vsemi_6, vsemi1_6 As Single
    Public acti_7 As Double, actini_7 As Double, tiem_7 As Long, vacti_7 As Double, vactini_7 As Double
    Public semi_7, semi1_7 As Single, j_7 As Integer, hoy_7 As Date, vsemi_7, vsemi1_7 As Single
    Public acti_8 As Double, actini_8 As Double, tiem_8 As Long, vacti_8 As Double, vactini_8 As Double
    Public semi_8, semi1_8 As Single, j_8 As Integer, hoy_8 As Date, vsemi_8, vsemi1_8 As Single
    Public acti_9 As Double, actini_9 As Double, tiem_9 As Long, vacti_9 As Double, vactini_9 As Double
    Public semi_9, semi1_9 As Single, j_9 As Integer, hoy_9 As Date, vsemi_9, vsemi1_9 As Single
    Public acti_10 As Double, actini_10 As Double, tiem_10 As Long, vacti_10 As Double, vactini_10 As Double
    Public semi_10, semi1_10 As Single, j_10 As Integer, hoy_10 As Date, vsemi_10, vsemi1_10 As Single
    Public acti_11 As Double, actini_11 As Double, tiem_11 As Long, vacti_11 As Double, vactini_11 As Double
    Public semi_11, semi1_11 As Single, j_11 As Integer, hoy_11 As Date, vsemi_11, vsemi1_11 As Single
    Public Xfuente As String
    Dim conn As New SqlConnection(Conexion.CadenaConexion)

    Private Sub LstTipo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles LstTipo.SelectedIndexChanged
        Tipo.Text = LstTipo.Text
        If Tipo.Text <> "" Then
            LstTipo.Visible = False
        Else
            LstTipo.Visible = True
        End If
    End Sub
    Sub Carga_LstTipo()

        Dim strLlenarList As String
        strLlenarList = "Select distinct(TIPO_DE_FUENTE) from inventa order by TIPO_DE_FUENTE"
        Dim comd1 As New SqlCommand(strLlenarList, conn)
        '  conn.Open()
        Dim Dr As SqlDataReader
        Dr = comd1.ExecuteReader()
        While Dr.Read()
            LstTipo.Items.Add(Dr(0))
        End While
        Dr.Close()
        LstTipo.Items.Add("--")
        '****************************************************
        ' modificado a pedido de Frediani 04/02/2015
        '****************************************************
        'LstTipo.Items.Add("ABIERTA")
        'LstTipo.Items.Add("CERRADA")
        'LstTipo.Items.Add("CERRADA/GASEOSA")
        'LstTipo.Items.Add("LIQUIDA")
        'LstTipo.Items.Add("LIQUIDA EQUIVALENTE")
        'LstTipo.Items.Add("LIQUIDA MULTIGAMMA")
        'LstTipo.Items.Add("LIQUIDO SIMULADO")
        'LstTipo.Items.Add("ARENA SIMULADA")
        'LstTipo.Items.Add("CARBON ACTIVADO")
        'LstTipo.Items.Add("DIETA SIMULADA")
        'LstTipo.Items.Add("ELEMENTO FILTRANTE")
        'LstTipo.Items.Add("FILTRO SIMULADO")
        'LstTipo.Items.Add("FUENTE ESPECIAL MULTIGAMMA")
        'LstTipo.Items.Add("GAS EQUIVALENTE")
        'LstTipo.Items.Add("GAS SIMULADO")
        'LstTipo.Items.Add("MATRIZ CARBON ACTIVADO")
        'LstTipo.Items.Add("MATRIZ SOLIDA")
        'LstTipo.Items.Add("PESAFILTRO")
        'LstTipo.Items.Add("PLANA")
        'LstTipo.Items.Add("PLANA EXTENDIDA")
        'LstTipo.Items.Add("PLANA P / FILTRO")
        'LstTipo.Items.Add("PLANA -VIDRIO")
        'LstTipo.Items.Add("PUNTUAL")
        'LstTipo.Items.Add("PUNTUAL SELLADA")
        'LstTipo.Items.Add("Resinas")
        'LstTipo.Items.Add("S/D")
        'LstTipo.Items.Add("SELLADA")
        'LstTipo.Items.Add("SELLADA EXTENDIDA")
        'LstTipo.Items.Add("SELLADA/BLINDADA")
        'LstTipo.Items.Add("SELLADA/LIQUIDA")
        'LstTipo.Items.Add("SIMIL GAS")
        'LstTipo.Items.Add("SOLIDA /BLINDADA")
        'LstTipo.Items.Add("TIERRA")
        LstTipo.Visible = True
        LstTipo.Enabled = True



    End Sub
    Private Sub LstUni_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles LstUni.SelectedIndexChanged
        Unidad.Text = LstUni.Text
        If Unidad.Text <> "" Then
            LstUni.Visible = False
        Else
            LstUni.Visible = True
        End If
    End Sub
    Sub Carga_LstUni()
        LstUni.Items.Add("UNIDAD ACTIVIDAD")
        LstUni.Items.Add("--")
        LstUni.Items.Add("µCI")
        LstUni.Items.Add("µCi/gr")
        LstUni.Items.Add("µCi/Ml")
        LstUni.Items.Add("ALFA/Min 2 PI")
        LstUni.Items.Add("ALFA/Seg")
        LstUni.Items.Add("BETA/Seg")
        LstUni.Items.Add("Bq")
        LstUni.Items.Add("Bq/Gr")
        LstUni.Items.Add("CI")
        LstUni.Items.Add("CPM")
        LstUni.Items.Add("CPM 4 PI")
        LstUni.Items.Add("CPS 4 PI")
        LstUni.Items.Add("dpm")
        LstUni.Items.Add("dpm/gr")
        LstUni.Items.Add("dpm/ml")
        LstUni.Items.Add("dps")
        LstUni.Items.Add("KBq")
        LstUni.Items.Add("MCI")
        LstUni.Items.Add("N/Seg")
        LstUni.Items.Add("nCi")
        LstUni.Items.Add("nCi/gr")
        LstUni.Visible = True
        LstUni.Enabled = True

    End Sub
    Private Sub LstEmi_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub LstUso_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles LstUso.SelectedIndexChanged
        TxtUso.Text = LstUso.Text
        If TxtUso.Text <> "" Then
            LstUso.Visible = False
        Else
            LstUso.Visible = True
        End If
    End Sub

    Sub Carga_LstUso()
        LstUso.Items.Add("--")
        LstUso.Items.Add("CAL")
        LstUso.Items.Add("CAL ENERGIA ESPECTROMETRO")
        LstUso.Items.Add("CAL.CENTELLEO LIQUIDO")
        LstUso.Items.Add("CAL.Equipos Contaminac.superficial")
        LstUso.Items.Add("CAL.Monitor Herramientas MGH1")
        LstUso.Items.Add("CALIB RADIOPROTECCION")
        LstUso.Items.Add("CALIB.ALFA total")
        LstUso.Items.Add("CALIB.BETA total")
        LstUso.Items.Add("CALIB.GAMA total")
        LstUso.Items.Add("CALIB.CONT.SUP.")
        LstUso.Items.Add("CALIB.EN EFICIENCIA")
        LstUso.Items.Add("CALIB.NEUTRONES")
        LstUso.Items.Add("CALIB.CHIMENEA")
        LstUso.Items.Add("CALIB.CTC")
        LstUso.Items.Add("CALIB.EFICIENCIA FILTROS SARTORIUS")
        LstUso.Items.Add("CALIB.ENERGIA SISTEMAS ESPECTR.")
        LstUso.Items.Add("CALIB.SECUNDARIA")
        LstUso.Items.Add("CALIB.SISTEMAS ESPECT")
        LstUso.Items.Add("CALIBRACION EN ENERGIAS")
        LstUso.Items.Add("CTC fantoma")
        LstUso.Visible = True
        LstUso.Enabled = True

    End Sub

 

    Private Sub LstGeom_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles LstGeom.SelectedIndexChanged
        Geom.Text = LstGeom.Text
        If Geom.Text <> "" Then
            LstGeom.Visible = False
        Else
            LstGeom.Visible = True

        End If
    End Sub
    Sub Carga_LstGeom()
        LstGeom.Items.Add("GEOMETRIA /SOPORTE")
        LstGeom.Items.Add("--")
        LstGeom.Items.Add("2 VIAL SELLADO")
        LstGeom.Items.Add("ACRILICO")
        LstGeom.Items.Add("ACRILICO CON MYLAR")
        LstGeom.Items.Add("ACRILICO RECTANGULAR")
        LstGeom.Items.Add("AMPOLLA")
        LstGeom.Items.Add("AMPOLLA CERRADA")
        LstGeom.Items.Add("AMPOLLA DE VIDRIO")
        LstGeom.Items.Add("AMPOLLA PLASTICA")
        LstGeom.Items.Add("AMPOLLA SELLADA")
        LstGeom.Items.Add("ARO ALUMINIO")
        LstGeom.Items.Add("BLINDAJE PLOMO/GAMAGRAFIA")
        LstGeom.Items.Add("BOTELLA PLASTICA")
        LstGeom.Items.Add("BOTELLA DE VIDRIO")
        LstGeom.Items.Add("BOTELLA DE VIDRIO SELLADA")
        LstGeom.Items.Add("BOTELLON 100 BAR")
        LstGeom.Items.Add("CAPSULA")
        LstGeom.Items.Add("CAPSULA ALUMINIO")
        LstGeom.Items.Add("CAPSULA METALICA")
        LstGeom.Items.Add("CAZOLETA PLASTICA")
        LstGeom.Items.Add("CILINDRO")
        LstGeom.Items.Add("CILINDRO METALICO")
        LstGeom.Items.Add("CILINDRO PRESURIZADO")
        LstGeom.Items.Add("CIRCULAR")
        LstGeom.Items.Add("CIRCULAR EN RESINA POLIESTER")
        LstGeom.Items.Add("CONICA PUNTUAL")
        LstGeom.Items.Add("CONTENEDOR BOTELLA PLASTICA")
        LstGeom.Items.Add("DISCO")
        LstGeom.Items.Add("DISCO ACRILICO")
        LstGeom.Items.Add("EXTENDIDA")
        LstGeom.Items.Add("FIBRA DE VIDRIO")
        LstGeom.Items.Add("FILTRO EN FIBRA CIRCULAR EN CAZOLETA METALICA")
        LstGeom.Items.Add("FRASCO")
        LstGeom.Items.Add("FRASCO BURBUJEADOR")
        LstGeom.Items.Add("FRASCO BURBUJEADOR CERRADO")
        LstGeom.Items.Add("FRASCO DE VIDRIO")
        LstGeom.Items.Add("FRASCO PLASTICO")
        LstGeom.Items.Add("FRASCO PLASTICO 120grCARBON ACTIVADO")
        LstGeom.Items.Add("FRASCO PLASTICO 160grCARBON ACTIVADO")
        LstGeom.Items.Add("FRASCO PLASTICO 208grCARBON ACTIVADO")
        LstGeom.Items.Add("FRASCO PLASTICO CERRADO")
        LstGeom.Items.Add("FRASCO PLASTICO SELLADO")
        LstGeom.Items.Add("FRASCO SELLADO")
        LstGeom.Items.Add("GAMAGRAFIA")
        LstGeom.Items.Add("FRASCO DE VIDRIO")
        LstGeom.Items.Add("GA-MA BEAKER")
        LstGeom.Items.Add("GA-MA GAS BEAKER")
        LstGeom.Items.Add("GAMAGRAFIA")
        LstGeom.Items.Add("LIQUIDA")
        LstGeom.Items.Add("MARINELLI")
        LstGeom.Items.Add("MARINELLI BEAKER")
        LstGeom.Items.Add("MARINELLI BEAKER 130G")
        LstGeom.Items.Add("MARINELLI BEAKER 438G")
        LstGeom.Items.Add("MARINELLI PLASTICO")
        LstGeom.Items.Add("MARINELLI RG100")
        LstGeom.Items.Add("MATRIZ RESINA")
        LstGeom.Items.Add("MOPLAST BOTTLE")
        LstGeom.Items.Add("MULTIGAMMA + AZUL METILENO")
        LstGeom.Items.Add("PAPEL")
        LstGeom.Items.Add("PAPEL DE FILTRO")
        LstGeom.Items.Add("PAPEL FILTRO")
        LstGeom.Items.Add("PLANA")
        LstGeom.Items.Add("PLANA 50 MM X 3 MM")
        LstGeom.Items.Add("PLANA CON MYLER")
        LstGeom.Items.Add("PLANA EXTENDIDA")
        LstGeom.Items.Add("PLANCHA")
        LstGeom.Items.Add("PLANCHA ACRILICA")
        LstGeom.Items.Add("PUNTUAL")
        LstGeom.Items.Add("PUNTUAL SOPORTE ACRILICO")
        LstGeom.Items.Add("SELLADA")
        LstGeom.Items.Add("SOPORTE ACRILICO")
        LstGeom.Items.Add("VIAL")
        LstGeom.Items.Add("VIAL DE PLASTICO")
        LstGeom.Items.Add("VIAL SELLADO")
        LstGeom.Items.Add("VIAL VIDRIO")

        LstGeom.Visible = True
        LstGeom.Enabled = True

    End Sub



    Private Sub LstDeposito_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles LstDeposito.SelectedIndexChanged
        Deposito.Text = LstDeposito.Text
        If Deposito.Text <> "" Then
            LstDeposito.Visible = False
        Else
            LstDeposito.Visible = True
        End If

    End Sub

    Sub Carga_LstDeposito()
        '  LstDeposito.Items.Add("2/419")
        '  LstDeposito.Items.Add("2/419 CAJA FUERTE")
        '  LstDeposito.Items.Add("2/432 CAJA FUERTE")
        '  LstDeposito.Items.Add("2/432 CAJA FUERTE")
        '  LstDeposito.Items.Add("2/419 Cofre N°1")
        '  LstDeposito.Items.Add("2/419 Cont. 280300 Parafina")
        '  LstDeposito.Items.Add("2/419 Cont. Plomo")
        '  LstDeposito.Items.Add("2/419 Cont. Plomo Naranja")
        '  LstDeposito.Items.Add("BAJA")
        '  LstDeposito.Items.Add("Cofre -  2/418")
        ' LstDeposito.Items.Add("Dosimetria")
        '  LstDeposito.Items.Add("Laboratorio 2/310")
        '   LstDeposito.Items.Add("Laboratorio 2/312")
        '  LstDeposito.Items.Add("Laboratorio 2/324")
        '  LstDeposito.Items.Add("SPC")
        

        Dim strLlenarList As String
        strLlenarList = "Select distinct(LUGAR_DEPOSITO) from inventa order by LUGAR_DEPOSITO"
        Dim comd1 As New SqlCommand(strLlenarList, conn)
        '  conn.Open()
        Dim Dr As SqlDataReader
        Dr = comd1.ExecuteReader()
        While Dr.Read()
            LstDeposito.Items.Add(Dr(0))
        End While
        Dr.Close()
        LstDeposito.Items.Add("--")
        LstDeposito.Visible = True
        LstDeposito.Enabled = True

    End Sub
    Private Sub LstEstado_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles LstEstado.SelectedIndexChanged
        Estado.Text = LstEstado.Text
        If Estado.Text <> "" Then
            LstEstado.Visible = False
        Else
            LstEstado.Visible = True

        End If
    End Sub
    Sub Carga_LstEstado()
        LstEstado.Items.Add("ACT")
        LstEstado.Items.Add("BAJA")
        LstEstado.Items.Add("NO CALIBRADA")
        LstEstado.Items.Add("USO")

        LstEstado.Visible = True
        LstEstado.Enabled = True

    End Sub


    Sub carga_LstClasif()
        LstClasif.Items.Add("PRIMARIA")
        LstClasif.Items.Add("SECUNDARIA")
        LstClasif.Items.Add("TERCIARIA")
        LstClasif.Items.Add("STDINTERNO")
        LstClasif.Items.Add("--")
        LstClasif.Visible = True
        LstClasif.Enabled = True

    End Sub



    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles cmdBuscar.Click

    End Sub

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load 
        '   MsgBox(opc.ToString())

        Select Case opc

            Case 112
                ' MsgBox(matri.ToString())
                Label1.Text = "BAJAS AL INVENTARIO DE FUENTES"
                cmdBaja.Visible = True
                Frame2.Visible = True
                Frame2.Enabled = True
                List1.Visible = True
                List1.Items.Add("Consumo")
                List1.Items.Add("Decaimiento")
                List1.Items.Add("Deterioro")
                List1.Items.Add("Fraccionamiento")
                Dim respon As String
                respon = CStr(matri)
                OcultaForm3()
                Exit Sub
            Case 111
                ' MsgBox(matri.ToString())
                Label1.Text = "ALTAS AL INVENTARIO DE FUENTES"
                cmdBuscar.Visible = False
                Command2.Visible = False
                Command3.Visible = False
                Command4.Visible = False
                Command5.Visible = False
                '  carga_LstClasif()
                cmdBaja.Visible = False
                cmdModi.Visible = False

                OcultaForm3()
                Exit Sub
            Case 113
                Label1.Text = "MODIFICACION DATOS DE FUENTES"
                cmdBuscar.Visible = False
                cmdBaja.Visible = False
                cmdGrabar.Visible = False
                cmdModi.Visible = True
                Command2.Visible = False
                Command3.Visible = False
                Command4.Visible = False
                Command5.Visible = False
                ' carga_LstClasif()
                OcultaForm3()
                Exit Sub
            Case 212
                OcultaForm3()
                Exit Sub

            Case 999
                CargarFormDesde()
                Exit Sub

        End Select
        arma_form3()

        If opc <> 214 And opc <> 221 And opc <> 222 Then
            Exit Sub
        End If

        If opc = 113 Then
            IdFuente.ReadOnly = True
        End If
        If opc = 211 Or opc = 212 Or opc = 213 Or opc = 214 Or opc = 221 Or opc = 222 Then
            BloqueaForm3()
            cmdGrabar.Visible = False
            cmdSalida.TabIndex = 0
        End If
    End Sub

    Sub OcultaForm3()
        IdFuente.Visible = True
        IdFuente.Text = ""
        Lbltit.Visible = True
        cmdSalida.Enabled = True
        Tipo.Visible = False
        Tipo.Text = ""
        Label5.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label18.Visible = False
        Label19.Visible = False
        Label20.Visible = False
        LblIdFabr.Visible = False
        Lbluso.Visible = False
        Lblusuario.Visible = False
        Label15.Visible = False
        Label16.Visible = False
        Label17.Visible = False
        Line1.Visible = False
        TxtIdFabric.Visible = False
        TxtIdFabric.Text = ""
        Lbluso.Visible = False
        LblIdFabr.Visible = False
        Clasif.Visible = False
        Clasif.Text = ""
        Origen.Visible = False
        Origen.Text = ""
        Geom.Visible = False
        Geom.Text = ""
        Dimension.Visible = False
        Dimension.Text = ""
        Unidad.Visible = False
        Unidad.Text = ""
        Estado.Visible = False
        Estado.Text = ""
        Deposito.Visible = False
        Deposito.Text = ""
        fec_ref1.Visible = False
        fec_ref1.Text = ""
        TxtProv.Visible = False
        TxtProv.Text = ""
        TxtUso.Visible = False
        TxtUso.Text = ""
        TxtUsuario.Visible = False
        TxtUsuario.Text = ""
        TxtBajaEst.Visible = False
        TxtBajaEst.Text = ""
        TxtBajaReal.Visible = False
        TxtBajaReal.Text = ""
        Lblusuario.Visible = False
        Frame1.Visible = False
        Frame2.Visible = False
        _Radio1_0.Visible = False
        _Radio1_0.Text = ""
        _Radio1_1.Visible = False
        _Radio1_1.Text = ""
        _Radio1_2.Visible = False
        _Radio1_2.Text = ""
        _Radio1_3.Visible = False
        _Radio1_3.Text = ""
        _Radio1_4.Visible = False
        _Radio1_4.Text = ""
        _Radio1_5.Visible = False
        _Radio1_5.Text = ""
        _Radio1_6.Visible = False
        _Radio1_6.Text = ""
        _Radio1_7.Visible = False
        _Radio1_7.Text = ""
        _Radio1_8.Visible = False
        _Radio1_8.Text = ""
        _Radio1_9.Visible = False
        _Radio1_9.Text = ""
        _Radio1_10.Visible = False
        _Radio1_10.Text = ""
        _Radio1_11.Visible = False
        _Radio1_11.Text = ""
        _TxtActI_0.Visible = False
        _TxtActI_0.Text = ""
        _TxtActI_1.Visible = False
        _TxtActI_1.Text = ""
        _TxtActI_2.Visible = False
        _TxtActI_2.Text = ""
        _TxtActI_3.Visible = False
        _TxtActI_3.Text = ""
        _TxtActI_4.Visible = False
        _TxtActI_4.Text = ""
        _TxtActI_5.Visible = False
        _TxtActI_5.Text = ""
        _TxtActI_6.Visible = False
        _TxtActI_6.Text = ""
        _TxtActI_7.Visible = False
        _TxtActI_7.Text = ""
        _TxtActI_8.Visible = False
        _TxtActI_8.Text = ""
        _TxtActI_9.Visible = False
        _TxtActI_9.Text = ""
        _TxtActI_10.Visible = False
        _TxtActI_10.Text = ""
        _TxtActI_11.Visible = False
        _TxtActI_11.Text = ""
        _TxtActIni_0.Visible = False
        _TxtActIni_0.Text = ""
        _TxtActIni_1.Visible = False
        _TxtActIni_1.Text = ""
        _TxtActIni_2.Visible = False
        _TxtActIni_2.Text = ""
        _TxtActIni_3.Visible = False
        _TxtActIni_3.Text = ""
        _TxtActIni_4.Visible = False
        _TxtActIni_4.Text = ""
        _TxtActIni_5.Visible = False
        _TxtActIni_5.Text = ""
        _TxtActIni_6.Visible = False
        _TxtActIni_6.Text = ""
        _TxtActIni_7.Visible = False
        _TxtActIni_7.Text = ""
        _TxtActIni_8.Visible = False
        _TxtActIni_8.Text = ""
        _TxtActIni_9.Visible = False
        _TxtActIni_9.Text = ""
        _TxtActIni_10.Visible = False
        _TxtActIni_10.Text = ""
        _TxtActIni_11.Visible = False
        _TxtActIni_11.Text = ""
        _TxtEmi_0.Visible = False
        _TxtEmi_0.Text = ""
        _TxtEmi_1.Visible = False
        _TxtEmi_1.Text = ""
        _TxtEmi_2.Visible = False
        _TxtEmi_2.Text = ""
        _TxtEmi_3.Visible = False
        _TxtEmi_3.Text = ""
        _TxtEmi_4.Visible = False
        _TxtEmi_4.Text = ""
        _TxtEmi_5.Visible = False
        _TxtEmi_5.Text = ""
        _TxtEmi_6.Visible = False
        _TxtEmi_6.Text = ""
        _TxtEmi_7.Visible = False
        _TxtEmi_7.Text = ""
        _TxtEmi_8.Visible = False
        _TxtEmi_8.Text = ""
        _TxtEmi_9.Visible = False
        _TxtEmi_9.Text = ""
        _TxtEmi_10.Visible = False
        _TxtEmi_10.Text = ""
        _TxtEmi_11.Visible = False
        _TxtEmi_11.Text = ""
        _TxtSemiper_0.Visible = False
        _TxtSemiper_0.Text = ""
        _TxtSemiper_1.Visible = False
        _TxtSemiper_1.Text = ""
        _TxtSemiper_2.Visible = False
        _TxtSemiper_2.Text = ""
        _TxtSemiper_3.Visible = False
        _TxtSemiper_3.Text = ""
        _TxtSemiper_4.Visible = False
        _TxtSemiper_4.Text = ""
        _TxtSemiper_5.Visible = False
        _TxtSemiper_5.Text = ""
        _TxtSemiper_6.Visible = False
        _TxtSemiper_6.Text = ""
        _TxtSemiper_7.Visible = False
        _TxtSemiper_7.Text = ""
        _TxtSemiper_8.Visible = False
        _TxtSemiper_8.Text = ""
        _TxtSemiper_9.Visible = False
        _TxtSemiper_9.Text = ""
        _TxtSemiper_10.Visible = False
        _TxtSemiper_10.Text = ""
        _TxtSemiper_11.Visible = False
        _TxtSemiper_11.Text = ""
        cmdBaja.Visible = False
        cmdModi.Visible = False
        Command2.Visible = False
        Command3.Visible = False
        Command4.Visible = False
        Command5.Visible = False
        cmdGrabar.Visible = False
        cmdBuscar.Visible = False
        '   LstClasif.Visible = False

    End Sub


    Sub BloqueaForm3()
        IdFuente.Enabled = False
        Tipo.Enabled = False
        TxtIdFabric.Enabled = False
        Clasif.Enabled = False
        Origen.Enabled = False
        Geom.Enabled = False
        Dimension.Enabled = False
        Unidad.Enabled = False
        Estado.Enabled = False
        Deposito.Enabled = False
        fec_ref1.Enabled = False
        TxtProv.Enabled = False
        TxtUso.Enabled = False
        TxtUsuario.Enabled = False
        TxtIdFabric.Enabled = False
        TxtBajaReal.Enabled = False
        _Radio1_0.Enabled = False
        _Radio1_1.Enabled = False
        _Radio1_2.Enabled = False
        _Radio1_3.Enabled = False
        _Radio1_4.Enabled = False
        _Radio1_5.Enabled = False
        _Radio1_6.Enabled = False
        _Radio1_7.Enabled = False
        _Radio1_8.Enabled = False
        _Radio1_9.Enabled = False
        _Radio1_10.Enabled = False
        _Radio1_11.Enabled = False
        _TxtActI_0.Enabled = False
        _TxtActI_1.Enabled = False
        _TxtActI_2.Enabled = False
        _TxtActI_3.Enabled = False
        _TxtActI_4.Enabled = False
        _TxtActI_5.Enabled = False
        _TxtActI_6.Enabled = False
        _TxtActI_7.Enabled = False
        _TxtActI_8.Enabled = False
        _TxtActI_9.Enabled = False
        _TxtActI_10.Enabled = False
        _TxtActI_11.Enabled = False
        _TxtActIni_0.Enabled = False
        _TxtActIni_1.Enabled = False
        _TxtActIni_2.Enabled = False
        _TxtActIni_3.Enabled = False
        _TxtActIni_4.Enabled = False
        _TxtActIni_5.Enabled = False
        _TxtActIni_6.Enabled = False
        _TxtActIni_7.Enabled = False
        _TxtActIni_8.Enabled = False
        _TxtActIni_9.Enabled = False
        _TxtActIni_10.Enabled = False
        _TxtActIni_11.Enabled = False
        _TxtEmi_0.Enabled = False
        _TxtEmi_1.Enabled = False
        _TxtEmi_2.Enabled = False
        _TxtEmi_3.Enabled = False
        _TxtEmi_4.Enabled = False
        _TxtEmi_5.Enabled = False
        _TxtEmi_6.Enabled = False
        _TxtEmi_7.Enabled = False
        _TxtEmi_8.Enabled = False
        _TxtEmi_9.Enabled = False
        _TxtEmi_10.Enabled = False
        _TxtEmi_11.Enabled = False
        _TxtSemiper_0.Enabled = False
        _TxtSemiper_1.Enabled = False
        _TxtSemiper_2.Enabled = False
        _TxtSemiper_3.Enabled = False
        _TxtSemiper_4.Enabled = False
        _TxtSemiper_5.Enabled = False
        _TxtSemiper_6.Enabled = False
        _TxtSemiper_7.Enabled = False
        _TxtSemiper_8.Enabled = False
        _TxtSemiper_9.Enabled = False
        _TxtSemiper_10.Enabled = False
        _TxtSemiper_11.Enabled = False

    End Sub

    Sub BorraForm3()
        IdFuente.Text = "" : Tipo.Text = "" : Clasif.Text = "" : Dimension.Text = "" : Geom.Text = ""
        Estado.Text = "" : Deposito.Text = "" : Origen.Text = "" : TxtProv.Text = "" : TxtBajaEst.Text = ""
        TxtBajaReal.Text = "" : TxtIdFabric.Text = "" : TxtUso.Text = ""
        _Radio1_0.Text = "" : _Radio1_1.Text = "" : _Radio1_2.Text = "" : _Radio1_3.Text = "" : _Radio1_4.Text = "" : _Radio1_5.Text = ""
        _Radio1_6.Text = "" : _Radio1_7.Text = "" : _Radio1_8.Text = "" : _Radio1_9.Text = "" : _Radio1_10.Text = "" : _Radio1_11.Text = ""
        _TxtActI_1.Text = "" : _TxtActI_2.Text = "" : _TxtActI_3.Text = "" : _TxtActI_4.Text = "" : _TxtActI_5.Text = "" : _TxtActI_6.Text = ""
        _TxtActI_7.Text = "" : _TxtActI_8.Text = "" : _TxtActI_9.Text = "" : _TxtActI_10.Text = "" : _TxtActI_11.Text = ""
        _TxtEmi_0.Text = "" : _TxtEmi_1.Text = "" : _TxtEmi_2.Text = "" : _TxtEmi_3.Text = "" : _TxtEmi_4.Text = "" : _TxtEmi_5.Text = "" : _TxtEmi_6.Text = ""
        _TxtEmi_7.Text = "" : _TxtEmi_8.Text = "" : _TxtEmi_9.Text = "" : _TxtEmi_10.Text = "" : _TxtEmi_11.Text = ""
        _TxtSemiper_0.Text = "" : _TxtSemiper_1.Text = "" : _TxtSemiper_2.Text = "" : _TxtSemiper_3.Text = "" : _TxtSemiper_4.Text = "" : _TxtSemiper_5.Text = ""
        _TxtSemiper_6.Text = "" : _TxtSemiper_7.Text = "" : _TxtSemiper_8.Text = "" : _TxtSemiper_9.Text = "" : _TxtSemiper_10.Text = "" : _TxtSemiper_11.Text = ""
        _TxtActIni_0.Text = "" : _TxtActIni_1.Text = "" : _TxtActIni_2.Text = "" : _TxtActIni_3.Text = "" : _TxtActIni_4.Text = "" : _TxtActIni_5.Text = ""
        _TxtActIni_6.Text = "" : _TxtActIni_7.Text = "" : _TxtActIni_8.Text = "" : _TxtActIni_9.Text = "" : _TxtActIni_10.Text = "" : _TxtActIni_11.Text = ""



    End Sub

    Sub MuestraForm3()
        Dim acti As Single, actini As Double, tiem As Integer
        Dim semi As Single
        acti = actini * (System.Math.Exp(-0.693 * (tiem / semi)))
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = True
        Label9.Visible = True
        Label10.Visible = True
        Label11.Visible = True
        '  Label12.Visible = True
        ' label13.Visible = True
        'Label14.Visible = True
        Label15.Visible = True
        Label17.Visible = True
        Line1.Visible = True
        Lbluso.Visible = True
        LblIdFabr.Visible = True
        Clasif.Visible = True
        Tipo.Visible = True
        Origen.Visible = True
        Geom.Visible = True
        Dimension.Visible = True
        Unidad.Visible = True
        Estado.Visible = True
        Estado.Enabled = True
        Deposito.Visible = True
        fec_ref1.Visible = True
        TxtProv.Visible = True
        TxtUso.Visible = True
        TxtUsuario.Visible = True
        TxtIdFabric.Visible = True
        TxtBajaReal.Visible = True
        Lblusuario.Visible = True
        Frame1.Visible = True
        cmdBaja.Visible = False
        cmdModi.Visible = False
        If opc <> 112 And opc <> 211 And opc <> 212 Then cmdGrabar.Visible = True
        cmdBuscar.Visible = False
        Lbltit.Visible = False
        _Radio1_0.Visible = True
        _Radio1_1.Visible = True
        _Radio1_2.Visible = True
        _Radio1_3.Visible = True
        _Radio1_4.Visible = True
        _Radio1_5.Visible = True
        _Radio1_6.Visible = True
        _Radio1_7.Visible = True
        _Radio1_8.Visible = True
        _Radio1_9.Visible = True
        _Radio1_10.Visible = True
        _Radio1_11.Visible = True
        _TxtActI_0.Visible = True
        _TxtActI_1.Visible = True
        _TxtActI_2.Visible = True
        _TxtActI_3.Visible = True
        _TxtActI_4.Visible = True
        _TxtActI_5.Visible = True
        _TxtActI_6.Visible = True
        _TxtActI_7.Visible = True
        _TxtActI_8.Visible = True
        _TxtActI_9.Visible = True
        _TxtActI_10.Visible = True
        _TxtActI_11.Visible = True
        _TxtActIni_0.Visible = True
        _TxtActIni_1.Visible = True
        _TxtActIni_2.Visible = True
        _TxtActIni_3.Visible = True
        _TxtActIni_4.Visible = True
        _TxtActIni_5.Visible = True
        _TxtActIni_6.Visible = True
        _TxtActIni_7.Visible = True
        _TxtActIni_8.Visible = True
        _TxtActIni_9.Visible = True
        _TxtActIni_10.Visible = True
        _TxtActIni_11.Visible = True
        _TxtEmi_0.Visible = True
        _TxtEmi_1.Visible = True
        _TxtEmi_2.Visible = True
        _TxtEmi_3.Visible = True
        _TxtEmi_4.Visible = True
        _TxtEmi_5.Visible = True
        _TxtEmi_6.Visible = True
        _TxtEmi_7.Visible = True
        _TxtEmi_8.Visible = True
        _TxtEmi_9.Visible = True
        _TxtEmi_10.Visible = True
        _TxtEmi_11.Visible = True
        _TxtSemiper_0.Visible = True
        _TxtSemiper_1.Visible = True
        _TxtSemiper_2.Visible = True
        _TxtSemiper_3.Visible = True
        _TxtSemiper_4.Visible = True
        _TxtSemiper_5.Visible = True
        _TxtSemiper_6.Visible = True
        _TxtSemiper_7.Visible = True
        _TxtSemiper_8.Visible = True
        _TxtSemiper_9.Visible = True
        _TxtSemiper_10.Visible = True
        _TxtSemiper_11.Visible = True
        'calc_int
        If opc <> 111 And opc <> 113 Then
            IdFuente.Enabled = False
            Clasif.Enabled = False
            Origen.Enabled = False
            Geom.Enabled = False
            Dimension.Enabled = False
            Unidad.Enabled = False
            Estado.Enabled = False
            Deposito.Enabled = False
            TxtUso.Enabled = False
            TxtUsuario.Enabled = False
            TxtBajaReal.Enabled = False
            Geom.Enabled = False
            Tipo.Enabled = False
            TxtBajaEst.Enabled = False
            TxtIdFabric.Enabled = False
            TxtProv.Enabled = False
            _Radio1_0.Enabled = False
            _Radio1_1.Enabled = False
            _Radio1_2.Enabled = False
            _Radio1_3.Enabled = False
            _Radio1_4.Enabled = False
            _Radio1_5.Enabled = False
            _Radio1_6.Enabled = False
            _Radio1_7.Enabled = False
            _Radio1_8.Enabled = False
            _Radio1_9.Enabled = False
            _Radio1_10.Enabled = False
            _Radio1_11.Enabled = False
            _TxtActI_0.Enabled = False
            _TxtActI_1.Enabled = False
            _TxtActI_2.Enabled = False
            _TxtActI_3.Enabled = False
            _TxtActI_4.Enabled = False
            _TxtActI_5.Enabled = False
            _TxtActI_6.Enabled = False
            _TxtActI_7.Enabled = False
            _TxtActI_8.Enabled = False
            _TxtActI_9.Enabled = False
            _TxtActI_10.Enabled = False
            _TxtActI_11.Enabled = False
            _TxtActIni_0.Enabled = False
            _TxtActIni_1.Enabled = False
            _TxtActIni_2.Enabled = False
            _TxtActIni_3.Enabled = False
            _TxtActIni_4.Enabled = False
            _TxtActIni_5.Enabled = False
            _TxtActIni_6.Enabled = False
            _TxtActIni_7.Enabled = False
            _TxtActIni_8.Enabled = False
            _TxtActIni_9.Enabled = False
            _TxtActIni_10.Enabled = False
            _TxtActIni_11.Enabled = False
            _TxtEmi_0.Enabled = False
            _TxtEmi_1.Enabled = False
            _TxtEmi_2.Enabled = False
            _TxtEmi_3.Enabled = False
            _TxtEmi_4.Enabled = False
            _TxtEmi_5.Enabled = False
            _TxtEmi_6.Enabled = False
            _TxtEmi_7.Enabled = False
            _TxtEmi_8.Enabled = False
            _TxtEmi_9.Enabled = False
            _TxtEmi_10.Enabled = False
            _TxtEmi_11.Enabled = False
            _TxtSemiper_0.Enabled = False
            _TxtSemiper_1.Enabled = False
            _TxtSemiper_2.Enabled = False
            _TxtSemiper_3.Enabled = False
            _TxtSemiper_4.Enabled = False
            _TxtSemiper_5.Enabled = False
            _TxtSemiper_6.Enabled = False
            _TxtSemiper_7.Enabled = False
            _TxtSemiper_8.Enabled = False
            _TxtSemiper_9.Enabled = False
            _TxtSemiper_10.Enabled = False
            _TxtSemiper_11.Enabled = False
            fec_ref1.Enabled = False

        Else
            _Radio1_0.Visible = True
            _Radio1_1.Visible = True
            _Radio1_2.Visible = True
            _Radio1_3.Visible = True
            _Radio1_4.Visible = True
            _Radio1_5.Visible = True
            _Radio1_6.Visible = True
            _Radio1_7.Visible = True
            _Radio1_8.Visible = True
            _Radio1_9.Visible = True
            _Radio1_10.Visible = True
            _Radio1_11.Visible = True
            _TxtActI_0.Visible = True
            _TxtActI_1.Visible = True
            _TxtActI_2.Visible = True
            _TxtActI_3.Visible = True
            _TxtActI_4.Visible = True
            _TxtActI_5.Visible = True
            _TxtActI_6.Visible = True
            _TxtActI_7.Visible = True
            _TxtActI_8.Visible = True
            _TxtActI_9.Visible = True
            _TxtActI_10.Visible = True
            _TxtActI_11.Visible = True
            _TxtActIni_0.Visible = True
            _TxtActIni_1.Visible = True
            _TxtActIni_2.Visible = True
            _TxtActIni_3.Visible = True
            _TxtActIni_4.Visible = True
            _TxtActIni_5.Visible = True
            _TxtActIni_6.Visible = True
            _TxtActIni_7.Visible = True
            _TxtActIni_8.Visible = True
            _TxtActIni_9.Visible = True
            _TxtActIni_10.Visible = True
            _TxtActIni_11.Visible = True
            _TxtEmi_0.Visible = True
            _TxtEmi_1.Visible = True
            _TxtEmi_2.Visible = True
            _TxtEmi_3.Visible = True
            _TxtEmi_4.Visible = True
            _TxtEmi_5.Visible = True
            _TxtEmi_6.Visible = True
            _TxtEmi_7.Visible = True
            _TxtEmi_8.Visible = True
            _TxtEmi_9.Visible = True
            _TxtEmi_10.Visible = True
            _TxtEmi_11.Visible = True
            _TxtSemiper_0.Visible = True
            _TxtSemiper_1.Visible = True
            _TxtSemiper_2.Visible = True
            _TxtSemiper_3.Visible = True
            _TxtSemiper_4.Visible = True
            _TxtSemiper_5.Visible = True
            _TxtSemiper_6.Visible = True
            _TxtSemiper_7.Visible = True
            _TxtSemiper_8.Visible = True
            _TxtSemiper_9.Visible = True
            _TxtSemiper_10.Visible = True
            _TxtSemiper_11.Visible = True
            If opc = 112 Then
                cmdGrabar.Visible = False
            End If
            If opc = 113 Then
                cmdModi.Visible = True
                cmdGrabar.Visible = False

            End If
        End If

    End Sub

    Private Sub IdFuente_ImeModeChanged(sender As Object, e As System.EventArgs) Handles IdFuente.ImeModeChanged

    End Sub

    Private Sub IdFuente_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles IdFuente.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            conn.Close()
            Dim canti As Integer
            IdFuente.Text = UCase(IdFuente.Text)
            IdFuente.Text = LTrim(IdFuente.Text)
            Xfuente = IdFuente.Text
            If Xfuente = "" Then Exit Sub
            Dim strConsultauna As String
            strConsultauna = "Select * from inventa where Id_fuente_radiactiva = '" + Xfuente + "'  "
            Dim commando1 As New SqlCommand(strConsultauna, conn)
            conn.Open()
            commando1.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(commando1)
            Dim ds As New DataSet()
            da.Fill(ds, "inventa")
            canti = ds.Tables("inventa").Rows.Count()
            If canti = 0 And opc = 212 Then
                MsgBox("Fuente inexistente")
                Exit Sub
            Else
                If opc = 111 Then
                    If canti = 0 Then
                        cmdGrabar.Visible = True
                        MuestraForm3()
                        Tipo.Focus()
                    Else
                        MsgBox("Fuente duplicada!! ")
                        cmdGrabar.Visible = False
                        IdFuente.Focus()
                    End If
                Else

                    Dim Dtr As DataRow
                    Dtr = ds.Tables("inventa").Rows(0)
                    ' *************** LLENO LA CABECERA ******************************
                    Tipo.Text = Dtr("TIPO_DE_FUENTE")
                    Clasif.Text = Dtr("CLASIFICACION")
                    Geom.Text = Dtr("GEOMETRIA_SOPORTE")
                    Dimension.Text = Dtr("DIMENSIONES")
                    If Dtr("ESTADO_DE_LA_FUENTE").ToString = "" Then
                        Estado.Text = ""
                    Else
                        Estado.Text = Dtr("ESTADO_DE_LA_FUENTE")
                    End If
                    Origen.Text = Dtr("FUENTE_PRIMARIA_DE_ORIGEN")
                    Unidad.Text = Dtr("UNIDAD_ACTIVIDAD")
                    Deposito.Text = Dtr("LUGAR_DEPOSITO")
                    TxtProv.Text = Dtr("PROVEEDOR_DE_ORIGEN")
                    TxtIdFabric.Text = Dtr("ID_FABRICACION")
                    TxtUso.Text = Dtr("USO_DE_ORIGEN")
                    TxtUsuario.Text = Dtr("USUARIO_PRINCIPAL")
                    If Dtr("FECHA_REFERENCIA_1").ToString = "" Then
                        fec_ref1.Text = ""
                    Else

                        fec_ref1.Text = Dtr("FECHA_REFERENCIA_1")
                    End If

                    If Dtr("FECHA_BAJA_ESTIMADA").ToString = "" Then
                        TxtBajaEst.Text = ""
                    Else
                        TxtBajaEst.Text = Dtr("FECHA_BAJA_ESTIMADA")
                    End If

                    If Dtr("BAJA_REAL").ToString = "" Then

                        TxtBajaReal.Text = ""
                    Else

                        TxtBajaReal.Text = Dtr("BAJA_REAL")

                    End If
                    '***************** FIN CABECERA ***************************************
                    '*************************** LLENO LOS RADIONUCLEIDOS ******************
                    If Dtr("RADIONUCLEIDO_1").ToString = "" Then
                        _Radio1_0.Text = ""
                    Else
                        _Radio1_0.Text = Dtr("RADIONUCLEIDO_1")
                    End If
                    If Dtr("RADIONUCLEIDO_2").ToString = "" Then
                        _Radio1_1.Text = ""
                    Else
                        _Radio1_1.Text = Dtr("RADIONUCLEIDO_2")
                    End If
                    If Dtr("RADIONUCLEIDO_3").ToString = "" Then
                        _Radio1_2.Text = ""
                    Else
                        _Radio1_2.Text = Dtr("RADIONUCLEIDO_3")
                    End If
                    If Dtr("RADIONUCLEIDO_4").ToString = "" Then
                        _Radio1_3.Text = ""
                    Else
                        _Radio1_3.Text = Dtr("RADIONUCLEIDO_4")
                    End If
                    If Dtr("RADIONUCLEIDO_5").ToString = "" Then
                        _Radio1_4.Text = ""
                    Else
                        _Radio1_4.Text = Dtr("RADIONUCLEIDO_5")
                    End If
                    If Dtr("RADIONUCLEIDO_6").ToString = "" Then
                        _Radio1_5.Text = ""
                    Else
                        _Radio1_5.Text = Dtr("RADIONUCLEIDO_6")
                    End If
                    If Dtr("RADIONUCLEIDO_7").ToString = "" Then
                        _Radio1_6.Text = ""
                    Else
                        _Radio1_6.Text = Dtr("RADIONUCLEIDO_7")
                    End If
                    If Dtr("RADIONUCLEIDO_8").ToString = "" Then
                        _Radio1_7.Text = ""
                    Else
                        _Radio1_7.Text = Dtr("RADIONUCLEIDO_8")
                    End If
                    If Dtr("RADIONUCLEIDO_9").ToString = "" Then
                        _Radio1_8.Text = ""
                    Else
                        _Radio1_8.Text = Dtr("RADIONUCLEIDO_9")
                    End If
                    If Dtr("RADIONUCLEIDO_10").ToString = "" Then
                        _Radio1_9.Text = ""
                    Else
                        _Radio1_9.Text = Dtr("RADIONUCLEIDO_10")
                    End If
                    If Dtr("RADIONUCLEIDO_11").ToString = "" Then
                        _Radio1_10.Text = ""
                    Else
                        _Radio1_10.Text = Dtr("RADIONUCLEIDO_11")
                    End If
                    If Dtr("RADIONUCLEIDO_12").ToString = "" Then
                        _Radio1_11.Text = ""
                    Else
                        _Radio1_11.Text = Dtr("RADIONUCLEIDO_12")
                    End If
                    If Dtr("ACTIVIDAD_INICIAL_1").ToString = "" Then
                        vacti = 0
                    Else
                        vacti = Dtr("ACTIVIDAD_INICIAL_1")
                    End If
                    If Dtr("ACTIVIDAD_INICIAL_2").ToString = "" Then
                        vacti_1 = 0
                    Else
                        vacti_1 = Dtr("ACTIVIDAD_INICIAL_2")
                    End If
                    If Dtr("ACTIVIDAD_INICIAL_3").ToString = "" Then
                        vacti_2 = 0
                    Else
                        vacti_2 = Dtr("ACTIVIDAD_INICIAL_3")
                    End If
                    If Dtr("ACTIVIDAD_INICIAL_4").ToString = "" Then
                        vacti_3 = 0
                    Else
                        vacti_3 = Dtr("ACTIVIDAD_INICIAL_4")
                    End If

                    If Dtr("ACTIVIDAD_INICIAL_5").ToString = "" Then
                        vacti_4 = 0
                    Else
                        vacti_4 = Dtr("ACTIVIDAD_INICIAL_5")
                    End If
                    If Dtr("ACTIVIDAD_INICIAL_6").ToString = "" Then
                        vacti_5 = 0
                    Else
                        vacti_5 = Dtr("ACTIVIDAD_INICIAL_6")
                    End If
                    If Dtr("ACTIVIDAD_INICIAL_7").ToString = "" Then
                        vacti_6 = 0
                    Else
                        vacti_6 = Dtr("ACTIVIDAD_INICIAL_7")
                    End If
                    If Dtr("ACTIVIDAD_INICIAL_8").ToString = "" Then
                        vacti_7 = 0
                    Else
                        vacti_7 = Dtr("ACTIVIDAD_INICIAL_8")
                    End If
                    If Dtr("ACTIVIDAD_INICIAL_9").ToString = "" Then
                        vacti_8 = 0
                    Else
                        vacti_8 = Dtr("ACTIVIDAD_INICIAL_9")
                    End If
                    If Dtr("ACTIVIDAD_INICIAL_10").ToString = "" Then
                        vacti_9 = 0
                    Else
                        vacti_9 = Dtr("ACTIVIDAD_INICIAL_10")
                    End If
                    If Dtr("ACTIVIDAD_INICIAL_11").ToString = "" Then
                        vacti_10 = 0
                    Else
                        vacti_10 = Dtr("ACTIVIDAD_INICIAL_11")
                    End If
                    If Dtr("ACTIVIDAD_INICIAL_12").ToString = "" Then
                        vacti_11 = 0
                    Else
                        vacti_11 = Dtr("ACTIVIDAD_INICIAL_12")
                    End If
                    If Dtr("SEMIPERIODO_1_DIAS").ToString = "" Then
                        vsemi = 0
                    Else
                        vsemi = Dtr("SEMIPERIODO_1_DIAS")
                    End If
                    If Dtr("SEMIPERIODO_2_DIAS").ToString = "" Then
                        vsemi_1 = 0
                    Else
                        vsemi_1 = Dtr("SEMIPERIODO_2_DIAS")
                    End If

                    If Dtr("SEMIPERIODO_3_DIAS").ToString = "" Then
                        vsemi_2 = 0
                    Else
                        vsemi_2 = Dtr("SEMIPERIODO_3_DIAS")
                    End If
                    If Dtr("SEMIPERIODO_4_DIAS").ToString = "" Then
                        vsemi_3 = 0
                    Else
                        vsemi_3 = Dtr("SEMIPERIODO_4_DIAS")
                    End If
                    If Dtr("SEMIPERIODO_5_DIAS").ToString = "" Then
                        vsemi_4 = 0
                    Else
                        vsemi_4 = Dtr("SEMIPERIODO_5_DIAS")
                    End If
                    If Dtr("SEMIPERIODO_6_DIAS").ToString = "" Then
                        vsemi_5 = 0
                    Else
                        vsemi_5 = Dtr("SEMIPERIODO_6_DIAS")
                    End If
                    If Dtr("SEMIPERIODO_7_DIAS").ToString = "" Then
                        vsemi_6 = 0
                    Else
                        vsemi_6 = Dtr("SEMIPERIODO_7_DIAS")
                    End If
                    If Dtr("SEMIPERIODO_8_DIAS").ToString = "" Then
                        vsemi_7 = 0
                    Else
                        vsemi_7 = Dtr("SEMIPERIODO_8_DIAS")
                    End If
                    If Dtr("SEMIPERIODO_9_DIAS").ToString = "" Then
                        vsemi_8 = 0
                    Else
                        vsemi_8 = Dtr("SEMIPERIODO_9_DIAS")
                    End If
                    If Dtr("SEMIPERIODO_10_DIAS").ToString = "" Then
                        vsemi_9 = 0
                    Else
                        vsemi_9 = Dtr("SEMIPERIODO_10_DIAS")
                    End If
                    If Dtr("SEMIPERIODO_11_DIAS").ToString = "" Then
                        vsemi_10 = 0
                    Else
                        vsemi_10 = Dtr("SEMIPERIODO_11_DIAS")
                    End If
                    If Dtr("SEMIPERIODO_12_DIAS").ToString = "" Then
                        vsemi_11 = 0
                    Else
                        vsemi_11 = Dtr("SEMIPERIODO_12_DIAS")
                    End If
                    '********************************************************************************************
                    'arma los calculos deberia pasarlo a un trigger dentro de la tabla
                    Calc_int()
                    '****************************************************************************************

                    _TxtActI_0.Text = acti ' CALCULO DE ACTIVIDAD INICIAL 
                    _TxtActIni_0.Text = actini
                    _TxtActI_1.Text = acti_1
                    _TxtActIni_1.Text = actini_1
                    _TxtActI_2.Text = acti_2
                    _TxtActIni_2.Text = actini_2
                    _TxtActI_3.Text = acti_3
                    _TxtActIni_3.Text = actini_3
                    _TxtActI_4.Text = acti_4
                    _TxtActIni_4.Text = actini_4
                    _TxtActI_5.Text = acti_5
                    _TxtActIni_5.Text = actini_5
                    _TxtActI_6.Text = acti_6
                    _TxtActIni_6.Text = actini_6
                    _TxtActI_7.Text = acti_7
                    _TxtActIni_7.Text = actini_7
                    _TxtActI_8.Text = acti_8
                    _TxtActIni_8.Text = actini_8
                    _TxtActI_9.Text = acti_9
                    _TxtActIni_9.Text = actini_9
                    _TxtActI_10.Text = acti_10
                    _TxtActIni_10.Text = actini_10
                    _TxtActI_11.Text = acti_11
                    _TxtActIni_11.Text = actini_11
                    _TxtSemiper_0.Text = semi
                    _TxtSemiper_1.Text = semi_1
                    _TxtSemiper_2.Text = semi_2
                    _TxtSemiper_3.Text = semi_3
                    _TxtSemiper_4.Text = semi_4
                    _TxtSemiper_5.Text = semi_5
                    _TxtSemiper_6.Text = semi_6
                    _TxtSemiper_7.Text = semi_7
                    _TxtSemiper_8.Text = semi_8
                    _TxtSemiper_9.Text = semi_9
                    _TxtSemiper_10.Text = semi_10
                    _TxtSemiper_11.Text = semi_11
                    If Dtr("TIPO_DE_EMISION_1").ToString = "" Then
                        _TxtEmi_0.Text = ""
                    Else
                        _TxtEmi_0.Text = Dtr("TIPO_DE_EMISION_1")
                    End If
                    If Dtr("TIPO_DE_EMISION_2").ToString = "" Then
                        _TxtEmi_1.Text = ""
                    Else
                        _TxtEmi_1.Text = Dtr("TIPO_DE_EMISION_2")
                    End If
                    If Dtr("TIPO_DE_EMISION_3").ToString = "" Then
                        _TxtEmi_2.Text = ""
                    Else
                        _TxtEmi_2.Text = Dtr("TIPO_DE_EMISION_3")
                    End If
                    If Dtr("TIPO_DE_EMISION_4").ToString = "" Then
                        _TxtEmi_3.Text = ""
                    Else
                        _TxtEmi_3.Text = Dtr("TIPO_DE_EMISION_4")
                    End If
                    If Dtr("TIPO_DE_EMISION_5").ToString = "" Then
                        _TxtEmi_4.Text = ""
                    Else
                        _TxtEmi_4.Text = Dtr("TIPO_DE_EMISION_5")
                    End If
                    If Dtr("TIPO_DE_EMISION_6").ToString = "" Then
                        _TxtEmi_5.Text = ""
                    Else
                        _TxtEmi_5.Text = Dtr("TIPO_DE_EMISION_6")
                    End If
                    If Dtr("TIPO_DE_EMISION_7").ToString = "" Then
                        _TxtEmi_6.Text = ""
                    Else
                        _TxtEmi_6.Text = Dtr("TIPO_DE_EMISION_7")
                    End If
                    If Dtr("TIPO_DE_EMISION_8").ToString = "" Then
                        _TxtEmi_7.Text = ""
                    Else
                        _TxtEmi_7.Text = Dtr("TIPO_DE_EMISION_8")
                    End If
                    If Dtr("TIPO_DE_EMISION_9").ToString = "" Then
                        _TxtEmi_8.Text = ""
                    Else
                        _TxtEmi_8.Text = Dtr("TIPO_DE_EMISION_9")
                    End If
                    If Dtr("TIPO_DE_EMISION_10").ToString = "" Then
                        _TxtEmi_9.Text = ""
                    Else
                        _TxtEmi_9.Text = Dtr("TIPO_DE_EMISION_10")
                    End If
                    If Dtr("TIPO_DE_EMISION_11").ToString = "" Then
                        _TxtEmi_10.Text = ""
                    Else
                        _TxtEmi_10.Text = Dtr("TIPO_DE_EMISION_11")
                    End If
                    If Dtr("TIPO_DE_EMISION_12").ToString = "" Then
                        _TxtEmi_11.Text = ""
                    Else
                        _TxtEmi_11.Text = Dtr("TIPO_DE_EMISION_12")
                    End If

                    'acti = actini * Exp(-0.693 * (tiem / semi))
                    '************************ FIN RADIONUCLEIDOS **************************
                    '            End If
                    ' se agrego mensaje para la opcion 212 si la fuente no existe
                    '   Else
                    If opc = 113 Then
                        If canti > 0 Then
                            cmdGrabar.Visible = False
                            cmdModi.Visible = True
                            MuestraForm3()
                            arma_form3()
                            Tipo.Focus()
                        Else
                            MsgBox("Fuente inexistente!! ")
                            'Screen.MousePointer = 0
                            cmdGrabar.Visible = False
                            cmdModi.Visible = False
                            ' borra_form3()
                        End If
                    Else
                        If opc = 112 Then
                            If canti > 0 Then
                                '       CmdGraba.Visible = True
                                Lbltit.Visible = False
                                Frame2.Visible = True
                                MuestraForm3()
                                arma_form3()
                                BloqueaForm3()
                                List1.Visible = True
                                cmdBaja.Visible = True
                            Else
                                MsgBox("Fuente inexistente!! ")
                                'Screen.MousePointer = 0
                                cmdGrabar.Visible = False
                                ' borra_form3()
                            End If
                        End If
                    End If
                    If opc = 212 Then
                        If canti > 0 Then
                            Lbltit.Visible = False
                            MuestraForm3()
                            arma_form3()
                            BloqueaForm3()
                            cmdGrabar.Visible = False
                        Else
                            MsgBox("Fuente inexistente!! ")
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub cmdSalida_Click(sender As System.Object, e As System.EventArgs) Handles cmdSalida.Click
        IdFuente.Visible = True
        IdFuente.Text = ""
        IdFuente.Enabled = True
        Lbltit.Visible = True
        cmdSalida.Enabled = True
        Tipo.Visible = False
        Tipo.Text = ""
        Label5.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label18.Visible = False
        Label19.Visible = False
        Label20.Visible = False
        LblIdFabr.Visible = False
        Lbluso.Visible = False
        Lblusuario.Visible = False
        Label15.Visible = False
        Label16.Visible = False
        Label17.Visible = False
        Line1.Visible = False
        TxtIdFabric.Visible = False
        TxtIdFabric.Text = ""
        Lbluso.Visible = False
        LblIdFabr.Visible = False
        Clasif.Visible = False
        Clasif.Text = ""
        Origen.Visible = False
        Origen.Text = ""
        Geom.Visible = False
        Geom.Text = ""
        Dimension.Visible = False
        Dimension.Text = ""
        Unidad.Visible = False
        Unidad.Text = ""
        Estado.Visible = False
        Estado.Text = ""
        Deposito.Visible = False
        Deposito.Text = ""
        fec_ref1.Visible = False
        fec_ref1.Text = ""
        TxtProv.Visible = False
        TxtProv.Text = ""
        TxtUso.Visible = False
        TxtUso.Text = ""
        TxtUsuario.Visible = False
        TxtUsuario.Text = ""
        TxtBajaEst.Visible = False
        TxtBajaEst.Text = ""
        TxtBajaReal.Visible = False
        TxtBajaReal.Text = ""
        Lblusuario.Visible = False
        Frame1.Visible = False
        Frame2.Visible = False
        _Radio1_0.Visible = False
        _Radio1_0.Text = ""
        _Radio1_1.Visible = False
        _Radio1_1.Text = ""
        _Radio1_2.Visible = False
        _Radio1_2.Text = ""
        _Radio1_3.Visible = False
        _Radio1_3.Text = ""
        _Radio1_4.Visible = False
        _Radio1_4.Text = ""
        _Radio1_5.Visible = False
        _Radio1_5.Text = ""
        _Radio1_6.Visible = False
        _Radio1_6.Text = ""
        _Radio1_7.Visible = False
        _Radio1_7.Text = ""
        _Radio1_8.Visible = False
        _Radio1_8.Text = ""
        _Radio1_9.Visible = False
        _Radio1_9.Text = ""
        _Radio1_10.Visible = False
        _Radio1_10.Text = ""
        _Radio1_11.Visible = False
        _Radio1_11.Text = ""
        _TxtActI_0.Visible = False
        _TxtActI_0.Text = ""
        _TxtActI_1.Visible = False
        _TxtActI_1.Text = ""
        _TxtActI_2.Visible = False
        _TxtActI_2.Text = ""
        _TxtActI_3.Visible = False
        _TxtActI_3.Text = ""
        _TxtActI_4.Visible = False
        _TxtActI_4.Text = ""
        _TxtActI_5.Visible = False
        _TxtActI_5.Text = ""
        _TxtActI_6.Visible = False
        _TxtActI_6.Text = ""
        _TxtActI_7.Visible = False
        _TxtActI_7.Text = ""
        _TxtActI_8.Visible = False
        _TxtActI_8.Text = ""
        _TxtActI_9.Visible = False
        _TxtActI_9.Text = ""
        _TxtActI_10.Visible = False
        _TxtActI_10.Text = ""
        _TxtActI_11.Visible = False
        _TxtActI_11.Text = ""
        _TxtActIni_0.Visible = False
        _TxtActIni_0.Text = ""
        _TxtActIni_1.Visible = False
        _TxtActIni_1.Text = ""
        _TxtActIni_2.Visible = False
        _TxtActIni_2.Text = ""
        _TxtActIni_3.Visible = False
        _TxtActIni_3.Text = ""
        _TxtActIni_4.Visible = False
        _TxtActIni_4.Text = ""
        _TxtActIni_5.Visible = False
        _TxtActIni_5.Text = ""
        _TxtActIni_6.Visible = False
        _TxtActIni_6.Text = ""
        _TxtActIni_7.Visible = False
        _TxtActIni_7.Text = ""
        _TxtActIni_8.Visible = False
        _TxtActIni_8.Text = ""
        _TxtActIni_9.Visible = False
        _TxtActIni_9.Text = ""
        _TxtActIni_10.Visible = False
        _TxtActIni_10.Text = ""
        _TxtActIni_11.Visible = False
        _TxtActIni_11.Text = ""
        _TxtEmi_0.Visible = False
        _TxtEmi_0.Text = ""
        _TxtEmi_1.Visible = False
        _TxtEmi_1.Text = ""
        _TxtEmi_2.Visible = False
        _TxtEmi_2.Text = ""
        _TxtEmi_3.Visible = False
        _TxtEmi_3.Text = ""
        _TxtEmi_4.Visible = False
        _TxtEmi_4.Text = ""
        _TxtEmi_5.Visible = False
        _TxtEmi_5.Text = ""
        _TxtEmi_6.Visible = False
        _TxtEmi_6.Text = ""
        _TxtEmi_7.Visible = False
        _TxtEmi_7.Text = ""
        _TxtEmi_8.Visible = False
        _TxtEmi_8.Text = ""
        _TxtEmi_9.Visible = False
        _TxtEmi_9.Text = ""
        _TxtEmi_10.Visible = False
        _TxtEmi_10.Text = ""
        _TxtEmi_11.Visible = False
        _TxtEmi_11.Text = ""
        _TxtSemiper_0.Visible = False
        _TxtSemiper_0.Text = ""
        _TxtSemiper_1.Visible = False
        _TxtSemiper_1.Text = ""
        _TxtSemiper_2.Visible = False
        _TxtSemiper_2.Text = ""
        _TxtSemiper_3.Visible = False
        _TxtSemiper_3.Text = ""
        _TxtSemiper_4.Visible = False
        _TxtSemiper_4.Text = ""
        _TxtSemiper_5.Visible = False
        _TxtSemiper_5.Text = ""
        _TxtSemiper_6.Visible = False
        _TxtSemiper_6.Text = ""
        _TxtSemiper_7.Visible = False
        _TxtSemiper_7.Text = ""
        _TxtSemiper_8.Visible = False
        _TxtSemiper_8.Text = ""
        _TxtSemiper_9.Visible = False
        _TxtSemiper_9.Text = ""
        _TxtSemiper_10.Visible = False
        _TxtSemiper_10.Text = ""
        _TxtSemiper_11.Visible = False
        _TxtSemiper_11.Text = ""
        cmdBaja.Visible = False
        cmdModi.Visible = False
        Command2.Visible = False
        Command3.Visible = False
        Command4.Visible = False
        Command5.Visible = False
        cmdGrabar.Visible = False
        cmdBuscar.Visible = False
        Me.Hide()
    End Sub

    Sub Calc_int()
        Dim i1 As Integer
        i1 = 0
        hoy = Date.Today()
        Dim hoy2 As String
        hoy2 = Date.Today()
        '   Do While i1 < 12
        Dim fref As String
        '________________________________--1--_____________________________

        If fec_ref1.Text <> "" And fec_ref1.Text <> "12:00:00 a.m." Then
            '(Form3.Fec_ref1.Text <> "" And Form3.Fec_ref1.Text <> "12:00:00 a.m."
            fref = fec_ref1.Text.ToString()
            tiem = DateDiff("d", fref, hoy2)
            semi = vsemi
            semi1 = tiem / semi
            actini = vacti
            acti = actini * (System.Math.Exp(-0.693 * (tiem / semi)))
            If semi1 > 2 Then
                _TxtActI_0.BackColor = Color.Yellow
            End If
            _TxtActI_0.Text = acti
        Else
            _TxtActI_0.Text = "0"
            semi = vsemi
            actini = vacti

        End If
        '___________________________________--2--_________________________________
        If fec_ref1.Text <> "" And fec_ref1.Text <> "12:00:00 a.m." Then
            fref = fec_ref1.Text.ToString()
            tiem_1 = DateDiff("d", fref, hoy2)
            semi_1 = vsemi_1
            semi1_1 = tiem_1 / semi_1
            actini_1 = vacti_1
            acti_1 = actini_1 * (System.Math.Exp(-0.693 * (tiem_1 / semi_1)))
            If semi1_1 > 2 Then
                _TxtActI_1.BackColor = Color.Yellow
            End If
            _TxtActI_1.Text = acti_1
        Else
            _TxtActI_1.Text = "0"
            semi_1 = vsemi_2
            actini_1 = vacti_1
        End If

        '____________________________________--3--________________________________
        If fec_ref1.Text <> "" And fec_ref1.Text <> "12:00:00 a.m." Then

            fref = fec_ref1.Text.ToString()
            tiem_2 = DateDiff("d", fref, hoy2)
            semi_2 = vsemi_2
            semi1_2 = tiem_2 / semi_2
            actini_2 = vacti_2
            acti_2 = actini_2 * (System.Math.Exp(-0.693 * (tiem_2 / semi_2)))
            If semi1_2 > 2 Then
                _TxtActI_2.BackColor = Color.Yellow
            End If
            _TxtActI_2.Text = acti_2
        Else
            _TxtActI_2.Text = "0"
            semi_2 = vsemi_2
            actini_2 = vacti_2
        End If

        '_____________________________________--4--_______________________________
        If fec_ref1.Text <> "" And fec_ref1.Text <> "12:00:00 a.m." Then

            fref = fec_ref1.Text.ToString()
            tiem_3 = DateDiff("d", fref, hoy2)
            semi_3 = vsemi_3
            semi1_3 = tiem_3 / semi_3
            actini_3 = vacti_3
            acti_3 = actini_3 * (System.Math.Exp(-0.693 * (tiem_3 / semi_3)))
            If semi1_3 > 2 Then
                _TxtActI_3.BackColor = Color.Yellow
            End If
            _TxtActI_3.Text = acti_3
        Else
            _TxtActI_3.Text = "0"
            semi_3 = vsemi_3
            actini_3 = vacti_3
        End If
        '_____________________________________--5--_______________________________
        If fec_ref1.Text <> "" And fec_ref1.Text <> "12:00:00 a.m." Then

            fref = fec_ref1.Text.ToString()
            tiem_4 = DateDiff("d", fref, hoy2)
            semi_4 = vsemi_4
            semi1_4 = tiem_4 / semi_4
            actini_4 = vacti_4
            acti_4 = actini_4 * (System.Math.Exp(-0.693 * (tiem_4 / semi_4)))
            If semi1_4 > 2 Then
                _TxtActI_4.BackColor = Color.Yellow
            End If
            _TxtActI_4.Text = acti_4
        Else
            _TxtActI_4.Text = "0"
            semi_4 = vsemi_4
            actini_4 = vacti_4
        End If
        '__________________________________--6--____________________________________
        If fec_ref1.Text <> "" And fec_ref1.Text <> "12:00:00 a.m." Then

            fref = fec_ref1.Text.ToString()
            tiem_5 = DateDiff("d", fref, hoy2)
            semi_5 = vsemi_5
            semi1_5 = tiem_5 / semi_5
            actini_5 = vacti_5
            acti_5 = actini_5 * (System.Math.Exp(-0.693 * (tiem_5 / semi_5)))
            If semi1_5 > 2 Then
                _TxtActI_5.BackColor = Color.Yellow
            End If
            _TxtActI_5.Text = acti_5

        Else
            _TxtActI_5.Text = "0"
            semi_5 = vsemi_5
            actini_5 = vacti_5
        End If
        '________________________________--7--____________________________________
        If fec_ref1.Text <> "" And fec_ref1.Text <> "12:00:00 a.m." Then

            fref = fec_ref1.Text.ToString()
            tiem_6 = DateDiff("d", fref, hoy2)
            semi_6 = vsemi_6
            semi1_6 = tiem_6 / semi_6
            actini_6 = vacti_6
            acti_6 = actini_6 * (System.Math.Exp(-0.693 * (tiem_6 / semi_6)))
            If semi1_6 > 2 Then
                _TxtActI_6.BackColor = Color.Yellow
            End If
            _TxtActI_6.Text = acti_6
        Else
            _TxtActI_6.Text = "0"
            semi_6 = vsemi_6
            actini_6 = vacti_6
        End If
        '_______________________________--8--__________________________________
        If fec_ref1.Text <> "" And fec_ref1.Text <> "12:00:00 a.m." Then

            fref = fec_ref1.Text.ToString()
            tiem_7 = DateDiff("d", fref, hoy2)
            semi_7 = vsemi_7
            semi1_7 = tiem_7 / semi_7
            actini_7 = vacti_7
            acti_7 = actini_7 * (System.Math.Exp(-0.693 * (tiem_7 / semi_7)))
            If semi1_7 > 2 Then
                _TxtActI_7.BackColor = Color.Yellow
            End If
            _TxtActI_7.Text = acti_7
        Else
            _TxtActI_7.Text = "0"
            semi_7 = vsemi_7
            actini_7 = vacti_7
        End If
        '______________________________--9--_________________________________
        If fec_ref1.Text <> "" And fec_ref1.Text <> "12:00:00 a.m." Then

            fref = fec_ref1.Text.ToString()
            tiem_8 = DateDiff("d", fref, hoy2)
            semi_8 = vsemi_8
            semi1_8 = tiem_8 / semi_8
            actini_8 = vacti_8
            acti_8 = actini_8 * (System.Math.Exp(-0.693 * (tiem_8 / semi_8)))
            If semi1_8 > 2 Then
                _TxtActI_8.BackColor = Color.Yellow
            End If
            _TxtActI_8.Text = acti_8
        Else
            _TxtActI_8.Text = "0"
            semi_8 = vsemi_8
            actini_8 = vacti_8
        End If
        '_____________________________--10--__________________________________
        If fec_ref1.Text <> "" And fec_ref1.Text <> "12:00:00 a.m." Then

            fref = fec_ref1.Text.ToString()
            tiem_9 = DateDiff("d", fref, hoy2)
            semi_9 = vsemi_9
            semi1_9 = tiem_9 / semi_9
            actini_9 = vacti_9
            acti_9 = actini_9 * (System.Math.Exp(-0.693 * (tiem_9 / semi_9)))
            If semi1_9 > 2 Then
                _TxtActI_9.BackColor = Color.Yellow
            End If
            _TxtActI_9.Text = acti_9
        Else
            _TxtActI_9.Text = "0"
            semi_9 = vsemi_9
            actini_9 = vacti_9
        End If
        '________________________________--11--________________________________
        If fec_ref1.Text <> "" And fec_ref1.Text <> "12:00:00 a.m." Then

            fref = fec_ref1.Text.ToString()
            tiem_10 = DateDiff("d", fref, hoy2)
            semi_10 = vsemi_10
            semi1_10 = tiem_10 / semi_10
            actini_10 = vacti_10
            acti_10 = actini_10 * (System.Math.Exp(-0.693 * (tiem_10 / semi_10)))
            If semi1_10 > 2 Then
                _TxtActI_10.BackColor = Color.Yellow
            End If
            _TxtActI_10.Text = acti_10
        Else
            _TxtActI_10.Text = "0"
            semi_10 = vsemi_10
            actini_10 = vacti_10
        End If
        '_______________________________--12--___________________________________
        If fec_ref1.Text <> "" And fec_ref1.Text <> "12:00:00 a.m." Then

            fref = fec_ref1.Text.ToString()
            tiem_11 = DateDiff("d", fref, hoy2)
            semi_11 = vsemi_11
            semi1_11 = tiem_11 / semi_11
            actini_11 = vacti_11
            acti_11 = actini_11 * (System.Math.Exp(-0.693 * (tiem_11 / semi_11)))
            If semi1_11 > 2 Then
                _TxtActI_11.BackColor = Color.Yellow
            End If
            _TxtActI_11.Text = acti_11
        Else
            _TxtActI_11.Text = "0"
            semi_11 = vsemi_11
            actini_11 = vacti_11
        End If
       
    End Sub
    Sub arma_form3()
        '   Dim i As Integer, ii As Integer
            Calc_int()
            If Estado.Text = "BAJA" Then
                Estado.BackColor = Color.Red
                If opc <> 214 Then
                MsgBox("la fuente  " + Xfuente + "  fue dada de baja el " + "'" + TxtBajaReal.Text + "'")
                cmdBaja.Enabled = False
                End If
            End If
    End Sub

    Sub CargarFormDesde()
        conn.Close()
        Dim canti As Integer
        IdFuente.Text = UCase(IdFuente.Text)
        IdFuente.Text = LTrim(IdFuente.Text)
        Xfuente = IdFuente.Text
        If Xfuente = "" Then Exit Sub
        Dim strConsultauna As String
        strConsultauna = "Select * from inventa where Id_fuente_radiactiva = '" + Xfuente + "'  "
        Dim commando1 As New SqlCommand(strConsultauna, conn)
        conn.Open()
        commando1.ExecuteNonQuery()
        Dim da As New SqlDataAdapter(commando1)
        Dim ds As New DataSet()
        da.Fill(ds, "inventa")
        canti = ds.Tables("inventa").Rows.Count()
                MuestraForm3()
        Dim Dtr As DataRow
        Dtr = ds.Tables("inventa").Rows(0)
            ' *************** LLENO LA CABECERA ******************************
            Tipo.Text = Dtr("TIPO_DE_FUENTE")
            Clasif.Text = Dtr("CLASIFICACION")
            Geom.Text = Dtr("GEOMETRIA_SOPORTE")
            Dimension.Text = Dtr("DIMENSIONES")
        If Dtr("ESTADO_DE_LA_FUENTE").ToString = "" Then
            Estado.Text = ""
        Else
            Estado.Text = Dtr("ESTADO_DE_LA_FUENTE")
        End If
        If Dtr("FUENTE_PRIMARIA_DE_ORIGEN").ToString = "" Then
            Origen.Text = ""
        Else
            Origen.Text = Dtr("FUENTE_PRIMARIA_DE_ORIGEN")
        End If
        If Dtr("UNIDAD_ACTIVIDAD").ToString = "" Then
            Unidad.Text = ""
        Else
            Unidad.Text = Dtr("UNIDAD_ACTIVIDAD")
        End If
        If Dtr("LUGAR_DEPOSITO").ToString = "" Then
            Deposito.Text = ""
        Else
            Deposito.Text = Dtr("LUGAR_DEPOSITO")
        End If
        TxtProv.Text = Dtr("PROVEEDOR_DE_ORIGEN")
        TxtIdFabric.Text = Dtr("ID_FABRICACION")
        TxtUso.Text = Dtr("USO_DE_ORIGEN")
        TxtUsuario.Text = Dtr("USUARIO_PRINCIPAL")
        If Dtr("FECHA_REFERENCIA_1").ToString = "" Then
            fec_ref1.Text = ""
        Else
            fec_ref1.Text = Dtr("FECHA_REFERENCIA_1")
        End If

        If Dtr("FECHA_BAJA_ESTIMADA").ToString = "" Then
            TxtBajaEst.Text = ""
        Else
            TxtBajaEst.Text = Dtr("FECHA_BAJA_ESTIMADA")
        End If

        If Dtr("BAJA_REAL").ToString = "" Then

            TxtBajaReal.Text = ""
        Else

            TxtBajaReal.Text = Dtr("BAJA_REAL")

        End If
        '***************** FIN CABECERA ***************************************
        '*************************** LLENO LOS RADIONUCLEIDO ******************
        If Dtr("RADIONUCLEIDO_1").ToString = "" Then
            _Radio1_0.Text = ""
        Else
            _Radio1_0.Text = Dtr("RADIONUCLEIDO_1")
        End If
        If Dtr("RADIONUCLEIDO_2").ToString = "" Then
            _Radio1_1.Text = ""
        Else
            _Radio1_1.Text = Dtr("RADIONUCLEIDO_2")
        End If
        If Dtr("RADIONUCLEIDO_3").ToString = "" Then
            _Radio1_2.Text = ""
        Else
            _Radio1_2.Text = Dtr("RADIONUCLEIDO_3")
        End If
        If Dtr("RADIONUCLEIDO_4").ToString = "" Then
            _Radio1_3.Text = ""
        Else
            _Radio1_3.Text = Dtr("RADIONUCLEIDO_4")
        End If
        If Dtr("RADIONUCLEIDO_5").ToString = "" Then
            _Radio1_4.Text = ""
        Else
            _Radio1_4.Text = Dtr("RADIONUCLEIDO_5")
        End If
        If Dtr("RADIONUCLEIDO_6").ToString = "" Then
            _Radio1_5.Text = ""
        Else
            _Radio1_5.Text = Dtr("RADIONUCLEIDO_6")
        End If
        If Dtr("RADIONUCLEIDO_7").ToString = "" Then
            _Radio1_6.Text = ""
        Else
            _Radio1_6.Text = Dtr("RADIONUCLEIDO_7")
        End If
        If Dtr("RADIONUCLEIDO_8").ToString = "" Then
            _Radio1_7.Text = ""
        Else
            _Radio1_7.Text = Dtr("RADIONUCLEIDO_8")
        End If
        If Dtr("RADIONUCLEIDO_9").ToString = "" Then
            _Radio1_8.Text = ""
        Else
            _Radio1_8.Text = Dtr("RADIONUCLEIDO_9")
        End If
        If Dtr("RADIONUCLEIDO_10").ToString = "" Then
            _Radio1_9.Text = ""
        Else
            _Radio1_9.Text = Dtr("RADIONUCLEIDO_10")
        End If
        If Dtr("RADIONUCLEIDO_11").ToString = "" Then
            _Radio1_10.Text = ""
        Else
            _Radio1_10.Text = Dtr("RADIONUCLEIDO_11")
        End If
        If Dtr("RADIONUCLEIDO_12").ToString = "" Then
            _Radio1_11.Text = ""
        Else
            _Radio1_11.Text = Dtr("RADIONUCLEIDO_12")
        End If
        If Dtr("ACTIVIDAD_INICIAL_1").ToString = "" Then
            vacti = 0
        Else
            vacti = Dtr("ACTIVIDAD_INICIAL_1")
        End If
        If Dtr("ACTIVIDAD_INICIAL_2").ToString = "" Then
            vacti_1 = 0
        Else
            vacti_1 = Dtr("ACTIVIDAD_INICIAL_2")
        End If
        If Dtr("ACTIVIDAD_INICIAL_3").ToString = "" Then
            vacti_2 = 0
        Else
            vacti_2 = Dtr("ACTIVIDAD_INICIAL_3")
        End If
        If Dtr("ACTIVIDAD_INICIAL_4").ToString = "" Then
            vacti_3 = 0
        Else
            vacti_3 = Dtr("ACTIVIDAD_INICIAL_4")
        End If

        If Dtr("ACTIVIDAD_INICIAL_5").ToString = "" Then
            vacti_4 = 0
        Else
            vacti_4 = Dtr("ACTIVIDAD_INICIAL_5")
        End If
        If Dtr("ACTIVIDAD_INICIAL_6").ToString = "" Then
            vacti_5 = 0
        Else
            vacti_5 = Dtr("ACTIVIDAD_INICIAL_6")
        End If
        If Dtr("ACTIVIDAD_INICIAL_7").ToString = "" Then
            vacti_6 = 0
        Else
            vacti_6 = Dtr("ACTIVIDAD_INICIAL_7")
        End If
        If Dtr("ACTIVIDAD_INICIAL_8").ToString = "" Then
            vacti_7 = 0
        Else
            vacti_7 = Dtr("ACTIVIDAD_INICIAL_8")
        End If
        If Dtr("ACTIVIDAD_INICIAL_9").ToString = "" Then
            vacti_8 = 0
        Else
            vacti_8 = Dtr("ACTIVIDAD_INICIAL_9")
        End If
        If Dtr("ACTIVIDAD_INICIAL_10").ToString = "" Then
            vacti_9 = 0
        Else
            vacti_9 = Dtr("ACTIVIDAD_INICIAL_10")
        End If
        If Dtr("ACTIVIDAD_INICIAL_11").ToString = "" Then
            vacti_10 = 0
        Else
            vacti_10 = Dtr("ACTIVIDAD_INICIAL_11")
        End If
        If Dtr("ACTIVIDAD_INICIAL_12").ToString = "" Then
            vacti_11 = 0
        Else
            vacti_11 = Dtr("ACTIVIDAD_INICIAL_12")
        End If
        If Dtr("SEMIPERIODO_1_DIAS").ToString = "" Then
            vsemi = 0
        Else
            vsemi = Dtr("SEMIPERIODO_1_DIAS")
        End If
        If Dtr("SEMIPERIODO_2_DIAS").ToString = "" Then
            vsemi_1 = 0
        Else
            vsemi_1 = Dtr("SEMIPERIODO_2_DIAS")
        End If

        If Dtr("SEMIPERIODO_3_DIAS").ToString = "" Then
            vsemi_2 = 0
        Else
            vsemi_2 = Dtr("SEMIPERIODO_3_DIAS")
        End If
        If Dtr("SEMIPERIODO_4_DIAS").ToString = "" Then
            vsemi_3 = 0
        Else
            vsemi_3 = Dtr("SEMIPERIODO_4_DIAS")
        End If
        If Dtr("SEMIPERIODO_5_DIAS").ToString = "" Then
            vsemi_4 = 0
        Else
            vsemi_4 = Dtr("SEMIPERIODO_5_DIAS")
        End If
        If Dtr("SEMIPERIODO_6_DIAS").ToString = "" Then
            vsemi_5 = 0
        Else
            vsemi_5 = Dtr("SEMIPERIODO_6_DIAS")
        End If
        If Dtr("SEMIPERIODO_7_DIAS").ToString = "" Then
            vsemi_6 = 0
        Else
            vsemi_6 = Dtr("SEMIPERIODO_7_DIAS")
        End If
        If Dtr("SEMIPERIODO_8_DIAS").ToString = "" Then
            vsemi_7 = 0
        Else
            vsemi_7 = Dtr("SEMIPERIODO_8_DIAS")
        End If
        If Dtr("SEMIPERIODO_9_DIAS").ToString = "" Then
            vsemi_8 = 0
        Else
            vsemi_8 = Dtr("SEMIPERIODO_9_DIAS")
        End If
        If Dtr("SEMIPERIODO_10_DIAS").ToString = "" Then
            vsemi_9 = 0
        Else
            vsemi_9 = Dtr("SEMIPERIODO_10_DIAS")
        End If
        If Dtr("SEMIPERIODO_11_DIAS").ToString = "" Then
            vsemi_10 = 0
        Else
            vsemi_10 = Dtr("SEMIPERIODO_11_DIAS")
        End If
        If Dtr("SEMIPERIODO_12_DIAS").ToString = "" Then
            vsemi_11 = 0
        Else
            vsemi_11 = Dtr("SEMIPERIODO_12_DIAS")
        End If
        Calc_int()
        'saltar a calc
        _TxtActI_0.Text = acti ' CALCULO DE ACTIVIDAD INICIAL 
        _TxtActIni_0.Text = actini
        _TxtActI_1.Text = acti_1
        _TxtActIni_1.Text = actini_1
        _TxtActI_2.Text = acti_2
        _TxtActIni_2.Text = actini_2
        _TxtActI_3.Text = acti_3
        _TxtActIni_3.Text = actini_3
        _TxtActI_4.Text = acti_4
        _TxtActIni_4.Text = actini_4
        _TxtActI_5.Text = acti_5
        _TxtActIni_5.Text = actini_5
        _TxtActI_6.Text = acti_6
        _TxtActIni_6.Text = actini_6
        _TxtActI_7.Text = acti_7
        _TxtActIni_7.Text = actini_7
        _TxtActI_8.Text = acti_8
        _TxtActIni_8.Text = actini_8
        _TxtActI_9.Text = acti_9
        _TxtActIni_9.Text = actini_9
        _TxtActI_10.Text = acti_10
        _TxtActIni_10.Text = actini_10
        _TxtActI_11.Text = acti_11
        _TxtActIni_11.Text = actini_11
        _TxtSemiper_0.Text = semi
        _TxtSemiper_1.Text = semi_1
        _TxtSemiper_2.Text = semi_2
        _TxtSemiper_3.Text = semi_3
        _TxtSemiper_4.Text = semi_4
        _TxtSemiper_5.Text = semi_5
        _TxtSemiper_6.Text = semi_6
        _TxtSemiper_7.Text = semi_7
        _TxtSemiper_8.Text = semi_8
        _TxtSemiper_9.Text = semi_9
        _TxtSemiper_10.Text = semi_10
        _TxtSemiper_11.Text = semi_11
        If Dtr("TIPO_DE_EMISION_1").ToString = "" Then
            _TxtEmi_0.Text = ""
        Else
            _TxtEmi_0.Text = Dtr("TIPO_DE_EMISION_1")
        End If
        If Dtr("TIPO_DE_EMISION_2").ToString = "" Then
            _TxtEmi_1.Text = ""
        Else
            _TxtEmi_1.Text = Dtr("TIPO_DE_EMISION_2")
        End If
        If Dtr("TIPO_DE_EMISION_3").ToString = "" Then
            _TxtEmi_2.Text = ""
        Else
            _TxtEmi_2.Text = Dtr("TIPO_DE_EMISION_3")
        End If
        If Dtr("TIPO_DE_EMISION_4").ToString = "" Then
            _TxtEmi_3.Text = ""
        Else
            _TxtEmi_3.Text = Dtr("TIPO_DE_EMISION_4")
        End If
        If Dtr("TIPO_DE_EMISION_5").ToString = "" Then
            _TxtEmi_4.Text = ""
        Else
            _TxtEmi_4.Text = Dtr("TIPO_DE_EMISION_5")
        End If
        If Dtr("TIPO_DE_EMISION_6").ToString = "" Then
            _TxtEmi_5.Text = ""
        Else
            _TxtEmi_5.Text = Dtr("TIPO_DE_EMISION_6")
        End If
        If Dtr("TIPO_DE_EMISION_7").ToString = "" Then
            _TxtEmi_6.Text = ""
        Else
            _TxtEmi_6.Text = Dtr("TIPO_DE_EMISION_7")
        End If
        If Dtr("TIPO_DE_EMISION_8").ToString = "" Then
            _TxtEmi_7.Text = ""
        Else
            _TxtEmi_7.Text = Dtr("TIPO_DE_EMISION_8")
        End If
        If Dtr("TIPO_DE_EMISION_9").ToString = "" Then
            _TxtEmi_8.Text = ""
        Else
            _TxtEmi_8.Text = Dtr("TIPO_DE_EMISION_9")
        End If
        If Dtr("TIPO_DE_EMISION_10").ToString = "" Then
            _TxtEmi_9.Text = ""
        Else
            _TxtEmi_9.Text = Dtr("TIPO_DE_EMISION_10")
        End If
        If Dtr("TIPO_DE_EMISION_11").ToString = "" Then
            _TxtEmi_10.Text = ""
        Else
            _TxtEmi_10.Text = Dtr("TIPO_DE_EMISION_11")
        End If
        If Dtr("TIPO_DE_EMISION_12").ToString = "" Then
            _TxtEmi_11.Text = ""
        Else
            _TxtEmi_11.Text = Dtr("TIPO_DE_EMISION_12")
        End If
        cmdBaja.Visible = False
        cmdGrabar.Visible = False
        Frame2.Visible = False

    End Sub

    Private Sub cmdGrabar_Click(sender As System.Object, e As System.EventArgs) Handles cmdGrabar.Click
        acticor = 0
        Try
            ' 2022-04-15
            ' fref1.ToString("yyyyMMdd")
            ' MM/dd/yyyy


            ' Dim dateString As String = fec_ref1.ToString("dd-MM-yyyy") '2001-03-06


            ' Dim dateString2 As String = fec_ref1.ToString() '2001-03-06

            'Dim formato As Date = Format(CDate(fref1), "yyyy-MM-dd")
            'fref1 = formato.ToString()

            ' Dim fecha As String = Convert.ToDateTime(DateTimePicker1.Text).ToString("yyyy-MM-dd")


            Dim fecha As String = Convert.ToDateTime(fec_ref1.Text).ToString("yyyy-MM-dd")

            Dim conn1 As New SqlConnection(Conexion.CadenaConexion)
            Dim strConsultauna As String
            strConsultauna = "INSERT INTO [inventa] ( [ID_FUENTE_RADIACTIVA], [ID_FABRICACION], [CLASIFICACION], [FUENTE_PRIMARIA_DE_ORIGEN], [TIPO_DE_FUENTE], [GEOMETRIA_SOPORTE], [DIMENSIONES], [UNIDAD_ACTIVIDAD], [RADIONUCLEIDO_1], " +
                            " [ACTIVIDAD_INICIAL_1], [TIPO_DE_EMISION_1], [SEMIPERIODO_1_DIAS], [RADIONUCLEIDO_2], [ACTIVIDAD_INICIAL_2], [TIPO_DE_EMISION_2], [SEMIPERIODO_2_DIAS], [RADIONUCLEIDO_3], [ACTIVIDAD_INICIAL_3], [TIPO_DE_EMISION_3], [SEMIPERIODO_3_DIAS], " +
                            " [RADIONUCLEIDO_4], [ACTIVIDAD_INICIAL_4], [TIPO_DE_EMISION_4], [SEMIPERIODO_4_DIAS], [RADIONUCLEIDO_5], [ACTIVIDAD_INICIAL_5], [TIPO_DE_EMISION_5], [SEMIPERIODO_5_DIAS], [RADIONUCLEIDO_6], [ACTIVIDAD_INICIAL_6], [TIPO_DE_EMISION_6], [SEMIPERIODO_6_DIAS], " +
                            " [RADIONUCLEIDO_7], [ACTIVIDAD_INICIAL_7], [TIPO_DE_EMISION_7], [SEMIPERIODO_7_DIAS], [RADIONUCLEIDO_8], [ACTIVIDAD_INICIAL_8], [TIPO_DE_EMISION_8], [SEMIPERIODO_8_DIAS], [RADIONUCLEIDO_9], [ACTIVIDAD_INICIAL_9], [TIPO_DE_EMISION_9], [SEMIPERIODO_9_DIAS], " +
                            " [RADIONUCLEIDO_10], [ACTIVIDAD_INICIAL_10], [TIPO_DE_EMISION_10], [SEMIPERIODO_10_DIAS], [RADIONUCLEIDO_11], [ACTIVIDAD_INICIAL_11], [TIPO_DE_EMISION_11], [SEMIPERIODO_11_DIAS], [RADIONUCLEIDO_12], [ACTIVIDAD_INICIAL_12], [TIPO_DE_EMISION_12], [SEMIPERIODO_12_DIAS], " +
                            " [PROVEEDOR_DE_ORIGEN], [USO_DE_ORIGEN], [USUARIO_PRINCIPAL], [FECHA_REFERENCIA_1], [ESTADO_DE_LA_FUENTE], [FECHA_BAJA_ESTIMADA], [LUGAR_DEPOSITO], [BAJA_REAL], [GENERA], [ACTIVIDAD_CORREGIDA] ) " +
                            " VALUES('" + IdFuente.Text + "', '" + TxtIdFabric.Text + "', '" + Clasif.Text + "', '" + Origen.Text + "', '" + Tipo.Text + "', '" + Geom.Text + "' , '" + Dimension.Text + "' ,'" + Unidad.Text + "', " +
                            " '" + _Radio1_0.Text + " ','" + _TxtActIni_0.Text + "' ,'" + _TxtEmi_0.Text + "', '" + _TxtSemiper_0.Text.Replace(",", ".") + "',  " +
                            " '" + _Radio1_1.Text + "', '" + _TxtActIni_1.Text + "', '" + _TxtEmi_1.Text + "', '" + _TxtSemiper_1.Text.Replace(",", ".") + "',  " +
                            " '" + _Radio1_2.Text + " ','" + _TxtActIni_2.Text + "' ,'" + _TxtEmi_2.Text + "', '" + _TxtSemiper_2.Text.Replace(",", ".") + "',  " +
                            " '" + _Radio1_3.Text + "', '" + _TxtActIni_3.Text + "', '" + _TxtEmi_3.Text + "', '" + _TxtSemiper_3.Text.Replace(",", ".") + "',  " +
                            " '" + _Radio1_4.Text + " ','" + _TxtActIni_4.Text + "' ,'" + _TxtEmi_4.Text + "', '" + _TxtSemiper_4.Text.Replace(",", ".") + "',  " +
                            " '" + _Radio1_5.Text + "', '" + _TxtActIni_5.Text + "', '" + _TxtEmi_5.Text + "', '" + _TxtSemiper_5.Text.Replace(",", ".") + "',  " +
                            " '" + _Radio1_6.Text + " ','" + _TxtActIni_6.Text + "' ,'" + _TxtEmi_6.Text + "', '" + _TxtSemiper_6.Text.Replace(",", ".") + "',  " +
                            " '" + _Radio1_7.Text + "', '" + _TxtActIni_7.Text + "', '" + _TxtEmi_7.Text + "', '" + _TxtSemiper_7.Text.Replace(",", ".") + "',  " +
                            " '" + _Radio1_8.Text + " ','" + _TxtActIni_8.Text + "' ,'" + _TxtEmi_8.Text + "', '" + _TxtSemiper_8.Text.Replace(",", ".") + "',  " +
                            " '" + _Radio1_9.Text + "', '" + _TxtActIni_9.Text + "', '" + _TxtEmi_9.Text + "', '" + _TxtSemiper_9.Text.Replace(",", ".") + "',  " +
                            " '" + _Radio1_10.Text + " ','" + _TxtActIni_10.Text + "' ,'" + _TxtEmi_10.Text + "', '" + _TxtSemiper_10.Text.Replace(",", ".") + "',  " +
                            " '" + _Radio1_11.Text + "', '" + _TxtActIni_11.Text + "', '" + _TxtEmi_11.Text + "', '" + _TxtSemiper_11.Text.Replace(",", ".") + "',  " +
                            " '" + TxtProv.Text + "', '" + TxtUso.Text + "', '" + TxtUsuario.Text + "', '" + fecha + "' , '" + Estado.Text + "' ," +
                            " '" + TxtBajaEst.Text + "', '" + Deposito.Text + "', '" + TxtBajaReal.Text + "', '" + matri.ToString() + "', '" + acticor.ToString + "' )"

            ' MsgBox(strConsultauna.ToString())
            Dim commando1 As New SqlCommand(strConsultauna, conn1)
            conn1.Open()
            commando1.ExecuteNonQuery()
            conn1.Close()
            MsgBox("Fuente dada de Alta con Exito")
            OcultaForm3()
        Catch ex As Exception
            ex.Message.ToString()

            MsgBox(ex.Message.ToString())
        End Try
        cmdSalida.Visible = False

    End Sub

    Private Sub IdFuente_TextChanged(sender As System.Object, e As System.EventArgs) Handles IdFuente.TextChanged

    End Sub

    Private Sub Clasif_Click(sender As System.Object, e As System.EventArgs) Handles Clasif.Click
        If opc = 111 Or opc = 113 Then
            LstClasif.Visible = True
            carga_LstClasif()
        Else
            LstClasif.Visible = False
        End If
    End Sub
    Private Sub Tipo_Click(sender As System.Object, e As System.EventArgs) Handles Tipo.Click
        If opc = 111 Or opc = 113 Then
            LstTipo.Visible = True
            Carga_LstTipo()
        Else
            LstTipo.Visible = False
        End If

    End Sub

    Private Sub LstClasif_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles LstClasif.SelectedIndexChanged
        Clasif.Text = LstClasif.Text
        If Clasif.Text <> "" Then
            LstClasif.Visible = False
        Else
            LstClasif.Visible = True
        End If
    End Sub

    Private Sub Unidad_Click(sender As System.Object, e As System.EventArgs) Handles Unidad.Click
        If opc = 111 Or opc = 113 Then
            LstUni.Visible = True
            Carga_LstUni()
        Else
            LstUni.Visible = False
        End If
    End Sub

    Private Sub Deposito_Click(sender As System.Object, e As System.EventArgs) Handles Deposito.Click
        If opc = 111 Or opc = 113 Then
            LstDeposito.Visible = True
            Carga_LstDeposito()
        Else
            LstDeposito.Visible = False
        End If
    End Sub

    Private Sub Deposito_TextChanged(sender As System.Object, e As System.EventArgs) Handles Deposito.TextChanged

    End Sub

    Private Sub TxtUso_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtUso.TextChanged

    End Sub

    Private Sub TxtUso_Click(sender As System.Object, e As System.EventArgs) Handles TxtUso.Click
        If opc = 111 Or opc = 113 Then
            LstUso.Visible = True
            Carga_LstUso()
        Else
            LstUso.Visible = False
        End If
    End Sub

    Private Sub LstEstado_Click(sender As System.Object, e As System.EventArgs) Handles LstEstado.Click
        If opc = 111 Or opc = 113 Then
            LstEstado.Visible = True
            Carga_LstEstado()
        Else
            LstEstado.Visible = False
        End If
    End Sub

    Private Sub Geom_TextChanged(sender As System.Object, e As System.EventArgs) Handles Geom.TextChanged

    End Sub

    Private Sub Geom_Click(sender As System.Object, e As System.EventArgs) Handles Geom.Click
        If opc = 111 Or opc = 113 Then
            LstGeom.Visible = True
            Carga_LstGeom()

        Else
            LstGeom.Visible = False
        End If
    End Sub
    Private Sub _Radio1_0_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles _Radio1_0.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If opc = 111 Or opc = 113 Then
                Radiosup.ShowDialog()
                _Radio1_0.Text = Radiosup.LstRadio.SelectedItem
            End If
        End If
    End Sub


    Private Sub _Radio1_4_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles _Radio1_4.KeyPress
       If e.KeyChar = ChrW(Keys.Enter) Then
            If opc = 111 Or opc = 113 Then
                Radiosup.ShowDialog()
                _Radio1_4.Text = Radiosup.LstRadio.SelectedItem
            End If
        End If

    End Sub

    Private Sub _Radio1_8_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles _Radio1_8.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If opc = 111 Or opc = 113 Then
                Radiosup.ShowDialog()
                _Radio1_8.Text = Radiosup.LstRadio.SelectedItem
            End If
        End If
    End Sub

    Private Sub _Radio1_1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles _Radio1_1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If opc = 111 Or opc = 113 Then
                Radiosup.ShowDialog()
                _Radio1_1.Text = Radiosup.LstRadio.SelectedItem
            End If
        End If
    End Sub

    Private Sub _Radio1_5_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles _Radio1_5.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If opc = 111 Or opc = 113 Then
                Radiosup.ShowDialog()
                _Radio1_5.Text = Radiosup.LstRadio.SelectedItem
            End If
        End If
    End Sub

    Private Sub _Radio1_9_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles _Radio1_9.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If opc = 111 Or opc = 113 Then
                   Radiosup.ShowDialog()
                _Radio1_9.Text = Radiosup.LstRadio.SelectedItem
            End If
        End If
    End Sub

    Private Sub _Radio1_2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles _Radio1_2.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If opc = 111 Or opc = 113 Then
             Radiosup.ShowDialog()
                _Radio1_2.Text = Radiosup.LstRadio.SelectedItem
            End If
        End If
    End Sub

    Private Sub _Radio1_6_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles _Radio1_6.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If opc = 111 Or opc = 113 Then
             Radiosup.ShowDialog()
                _Radio1_6.Text = Radiosup.LstRadio.SelectedItem
            End If
        End If
    End Sub

    Private Sub _Radio1_10_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles _Radio1_10.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If opc = 111 Or opc = 113 Then
          Radiosup.ShowDialog()
                _Radio1_10.Text = Radiosup.LstRadio.SelectedItem
            End If
        End If
    End Sub

    Private Sub _Radio1_3_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles _Radio1_3.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If opc = 111 Or opc = 113 Then
               Radiosup.ShowDialog()
                _Radio1_3.Text = Radiosup.LstRadio.SelectedItem
            End If
        End If
    End Sub

    Private Sub _Radio1_7_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles _Radio1_7.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If opc = 111 Or opc = 113 Then
            Radiosup.ShowDialog()
                _Radio1_7.Text = Radiosup.LstRadio.SelectedItem
            End If
        End If
    End Sub

    Private Sub _Radio1_11_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles _Radio1_11.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If opc = 111 Or opc = 113 Then
             Radiosup.ShowDialog()
                _Radio1_11.Text = Radiosup.LstRadio.SelectedItem
            End If
        End If
    End Sub

    Private Sub _TxtEmi_0_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles _TxtEmi_0.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If opc = 111 Or opc = 113 Then
                Emiup.ShowDialog()
                _TxtEmi_0.Text = Emiup.LstEmi.SelectedItem
            End If
        End If
    End Sub

    Private Sub _TxtEmi_4_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles _TxtEmi_4.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If opc = 111 Or opc = 113 Then
                Emiup.ShowDialog()
                _TxtEmi_4.Text = Emiup.LstEmi.SelectedItem
            End If
        End If
    End Sub

    Private Sub _TxtEmi_8_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles _TxtEmi_8.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If opc = 111 Or opc = 113 Then
                Emiup.ShowDialog()
                _TxtEmi_8.Text = Emiup.LstEmi.SelectedItem
            End If
        End If
    End Sub

    Private Sub _TxtEmi_1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles _TxtEmi_1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If opc = 111 Or opc = 113 Then
                Emiup.ShowDialog()
                _TxtEmi_1.Text = Emiup.LstEmi.SelectedItem
            End If
        End If
    End Sub

    Private Sub _TxtEmi_5_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles _TxtEmi_5.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If opc = 111 Or opc = 113 Then
                Emiup.ShowDialog()
                _TxtEmi_5.Text = Emiup.LstEmi.SelectedItem
            End If
        End If
    End Sub

    Private Sub _TxtEmi_9_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles _TxtEmi_9.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If opc = 111 Or opc = 113 Then
                Emiup.ShowDialog()
                _TxtEmi_9.Text = Emiup.LstEmi.SelectedItem
            End If
        End If
    End Sub

    Private Sub _TxtEmi_2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles _TxtEmi_2.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If opc = 111 Or opc = 113 Then
                Emiup.ShowDialog()
                _TxtEmi_2.Text = Emiup.LstEmi.SelectedItem
            End If
        End If
    End Sub

    Private Sub _TxtEmi_6_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles _TxtEmi_6.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If opc = 111 Or opc = 113 Then
                Emiup.ShowDialog()
                _TxtEmi_6.Text = Emiup.LstEmi.SelectedItem
            End If
        End If
    End Sub

    Private Sub _TxtEmi_10_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles _TxtEmi_10.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If opc = 111 Or opc = 113 Then
                Emiup.ShowDialog()
                _TxtEmi_10.Text = Emiup.LstEmi.SelectedItem
            End If
        End If
    End Sub

    Private Sub _TxtEmi_3_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles _TxtEmi_3.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If opc = 111 Or opc = 113 Then
                Emiup.ShowDialog()
                _TxtEmi_3.Text = Emiup.LstEmi.SelectedItem
            End If
        End If
    End Sub

    Private Sub _TxtEmi_7_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles _TxtEmi_7.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If opc = 111 Or opc = 113 Then
                Emiup.ShowDialog()
                _TxtEmi_7.Text = Emiup.LstEmi.SelectedItem
            End If
        End If
    End Sub

    Private Sub _TxtEmi_11_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles _TxtEmi_11.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If opc = 111 Or opc = 113 Then
                Emiup.ShowDialog()
                _TxtEmi_11.Text = Emiup.LstEmi.SelectedItem
            End If
        End If
    End Sub

    Private Sub Estado_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Estado.KeyPress
        If opc = 111 Or opc = 113 Then
            LstEstado.Visible = True
        Else
            LstEstado.Visible = False

        End If
    End Sub

    Private Sub Estado_TextChanged(sender As System.Object, e As System.EventArgs) Handles Estado.TextChanged

    End Sub

    Private Sub Estado_Click(sender As System.Object, e As System.EventArgs) Handles Estado.Click
        If opc = 111 Or opc = 113 Then
            LstEstado.Visible = True
            Carga_LstEstado()
        Else
            LstEstado.Visible = False
        End If
    End Sub

    Private Sub cmdBaja_Click(sender As System.Object, e As System.EventArgs) Handles cmdBaja.Click
        resp = MsgBox("¿Está seguro que quiere borrar la fuente " & idactual & "?", vbYesNo, "Baja de una fuente")
        If resp = 6 Then
            ' Frame2.Visible = True
            'List1.Visible = True
            'List1.Focus()
            If List1.SelectedItem = "" Then
                MsgBox("Debe seleccionar el motivo de la Baja")
                Exit Sub
            End If

            GrabarBaja()
        End If

    End Sub
    Sub GrabarBaja()
        Try
            Dim conex2 As New SqlConnection(Conexion.CadenaConexion)
            Dim Bfecha As Date
            Bfecha = Date.Today
            Dim SQLupdate As String
            SQLupdate = "UPDATE inventa set ESTADO_DE_LA_FUENTE = 'BAJA', BAJA_REAL = '" + Bfecha + "', RESPONSABLE = '" + matri.ToString() + "', MOTIVO_BAJA = '" + List1.SelectedItem.ToString() + "' WHERE ID_FUENTE_RADIACTIVA = '" + IdFuente.Text + "'"
            Dim comando1 As New SqlCommand(SQLupdate, conex2)
            conex2.Open()
            comando1.ExecuteNonQuery()
            conex2.Close()
            MessageBox.Show("La fuente ha sido dada de BAJA ")
        Catch ex As Exception
            ex.Message.ToString()
        End Try
    End Sub

    Private Sub cmdModi_Click(sender As System.Object, e As System.EventArgs) Handles cmdModi.Click

        If opc = 113 Then ' INGRESO POR EL MENU MODIFICAR = 113
            Calc_int()
            Try
                Dim conex3 As New SqlConnection(Conexion.CadenaConexion)
                Dim SQLupdate3 As String
                SQLupdate3 = "UPDATE inventa SET [ID_FABRICACION]= '" + TxtIdFabric.Text + "', [CLASIFICACION]= '" + Clasif.Text + "', [FUENTE_PRIMARIA_DE_ORIGEN]= '" + Origen.Text + "', [TIPO_DE_FUENTE]= '" + Tipo.Text + "', [GEOMETRIA_SOPORTE] = '" + Geom.Text + "', [DIMENSIONES] = '" + Dimension.Text + "', [UNIDAD_ACTIVIDAD]= '" + Unidad.Text + "', " +
                "[RADIONUCLEIDO_1]= '" + _Radio1_0.Text + "',  [ACTIVIDAD_INICIAL_1] = '" + _TxtActIni_0.Text.Replace(",", ".") + "', [TIPO_DE_EMISION_1]='" + _TxtEmi_0.Text + "', [SEMIPERIODO_1_DIAS]='" + _TxtSemiper_0.Text.Replace(",", ".") + "', " +
                "[RADIONUCLEIDO_2]= '" + _Radio1_1.Text + "',  [ACTIVIDAD_INICIAL_2] = '" + _TxtActIni_1.Text.Replace(",", ".") + "', [TIPO_DE_EMISION_2]='" + _TxtEmi_1.Text + "', [SEMIPERIODO_2_DIAS]='" + _TxtSemiper_1.Text.Replace(",", ".") + "', " +
                "[RADIONUCLEIDO_3]= '" + _Radio1_2.Text + "',  [ACTIVIDAD_INICIAL_3] = '" + _TxtActIni_2.Text.Replace(",", ".") + "', [TIPO_DE_EMISION_3]='" + _TxtEmi_2.Text + "', [SEMIPERIODO_3_DIAS]='" + _TxtSemiper_2.Text.Replace(",", ".") + "', " +
                "[RADIONUCLEIDO_4]= '" + _Radio1_3.Text + "',  [ACTIVIDAD_INICIAL_4] = '" + _TxtActIni_3.Text.Replace(",", ".") + "', [TIPO_DE_EMISION_4]='" + _TxtEmi_3.Text + "', [SEMIPERIODO_4_DIAS]='" + _TxtSemiper_3.Text.Replace(",", ".") + "', " +
                "[RADIONUCLEIDO_5]= '" + _Radio1_4.Text + "',  [ACTIVIDAD_INICIAL_5] = '" + _TxtActIni_4.Text.Replace(",", ".") + "', [TIPO_DE_EMISION_5]='" + _TxtEmi_4.Text + "', [SEMIPERIODO_5_DIAS]='" + _TxtSemiper_4.Text.Replace(",", ".") + "', " +
                "[RADIONUCLEIDO_6]= '" + _Radio1_5.Text + "',  [ACTIVIDAD_INICIAL_6] = '" + _TxtActIni_5.Text.Replace(",", ".") + "', [TIPO_DE_EMISION_6]='" + _TxtEmi_5.Text + "', [SEMIPERIODO_6_DIAS]='" + _TxtSemiper_5.Text.Replace(",", ".") + "', " +
                "[RADIONUCLEIDO_7]= '" + _Radio1_6.Text + "',  [ACTIVIDAD_INICIAL_7] = '" + _TxtActIni_6.Text.Replace(",", ".") + "', [TIPO_DE_EMISION_7]='" + _TxtEmi_6.Text + "', [SEMIPERIODO_7_DIAS]='" + _TxtSemiper_6.Text.Replace(",", ".") + "', " +
                "[RADIONUCLEIDO_8]= '" + _Radio1_7.Text + "',  [ACTIVIDAD_INICIAL_8] = '" + _TxtActIni_7.Text.Replace(",", ".") + "', [TIPO_DE_EMISION_8]='" + _TxtEmi_7.Text + "', [SEMIPERIODO_8_DIAS]='" + _TxtSemiper_7.Text.Replace(",", ".") + "', " +
                "[RADIONUCLEIDO_9]= '" + _Radio1_8.Text + "',  [ACTIVIDAD_INICIAL_9] = '" + _TxtActIni_8.Text.Replace(",", ".") + "', [TIPO_DE_EMISION_9]='" + _TxtEmi_8.Text + "', [SEMIPERIODO_9_DIAS]='" + _TxtSemiper_8.Text.Replace(",", ".") + "', " +
                "[RADIONUCLEIDO_10]= '" + _Radio1_9.Text + "',  [ACTIVIDAD_INICIAL_10] = '" + _TxtActIni_9.Text.Replace(",", ".") + "', [TIPO_DE_EMISION_10]='" + _TxtEmi_9.Text + "', [SEMIPERIODO_10_DIAS]='" + _TxtSemiper_9.Text.Replace(",", ".") + "', " +
                "[RADIONUCLEIDO_11]= '" + _Radio1_10.Text + "',  [ACTIVIDAD_INICIAL_11] = '" + _TxtActIni_10.Text.Replace(",", ".") + "', [TIPO_DE_EMISION_11]='" + _TxtEmi_10.Text + "', [SEMIPERIODO_11_DIAS]='" + _TxtSemiper_10.Text.Replace(",", ".") + "', " +
                "[RADIONUCLEIDO_12]= '" + _Radio1_11.Text + "',  [ACTIVIDAD_INICIAL_12] = '" + _TxtActIni_11.Text.Replace(",", ".") + "', [TIPO_DE_EMISION_12]='" + _TxtEmi_11.Text + "', [SEMIPERIODO_12_DIAS]='" + _TxtSemiper_11.Text.Replace(",", ".") + "', " +
                "[ESTADO_DE_LA_FUENTE] = '" + Estado.Text + "', [MODIFICA] = '" + matri.ToString() + "' , [LUGAR_DEPOSITO] = '" + Deposito.Text + "' WHERE ID_FUENTE_RADIACTIVA = '" + IdFuente.Text + "'; "

                Dim comando1 As New SqlCommand(SQLupdate3, conex3)
                conex3.Open()
                comando1.ExecuteNonQuery()
                conex3.Close()
                MessageBox.Show("La fuente ha sido Modificada con Exito ")
                OcultaForm3()
            Catch ex As Exception
                ex.Message.ToString()
            End Try
        End If
    End Sub

    Private Sub TxtIdFabric_LostFocus(sender As Object, e As System.EventArgs) Handles TxtIdFabric.LostFocus
        If TxtIdFabric.Text = "" Then
            MsgBox("Debe completar este campo")

        Else
            TxtUso.Focus()
        End If
    End Sub

    Private Sub fec_ref1_LostFocus(sender As Object, e As System.EventArgs) Handles fec_ref1.LostFocus
        If Trim(fec_ref1.Text) <> "" Then
            If fec_ref1.Text = "12:00:00 a.m." Then
                fref1 = CDate("01/01/1900")
            Else
                '   fref = fec_ref1.Text.ToString()

                fref1 = CDate(fec_ref1.Text.ToString())
            End If
        Else
            fref1 = CDate("01/01/1900")
            'fref1 = vbNull
        End If
        '    If fec_ref1.Text = "" Then
        'MsgBox("Debe completar este campo")
        'Else
        TxtBajaEst.Focus()
        ' End If
    End Sub


    Private Sub Dimension_LostFocus(sender As Object, e As System.EventArgs) Handles Dimension.LostFocus
        If Dimension.Text = "" Then
            MsgBox("Debe completar este campo: Dimensiones")
        Else
            Estado.Focus()

        End If
    End Sub

   
End Class