Option Strict Off
Option Explicit On
Module Fuentes
    '   Public dbInventa As DAO.Database
    '   Public tbInventa As DAO.Recordset
    '   Public tbUsuarios As DAO.Recordset
    '   Public tbmovim As DAO.Recordset
    '   Public rsInventa As DAO.Recordset
    '   Public rsmovim As DAO.Recordset
    '   Public rsinventa97 As DAO.Recordset
    Public opc, encontrado As Short
    Public idactual, usuario, marca As String
    Public marcarec As Object
    Public xconfig, nom As String
    Public matri, yerro As Short
    Public Xa, Xb As String
    Public paso As Short
    Public TxtRad As TextBox

    Property DataSet1TableAdapters As Object




    Sub busca_tipo()
        Form2.LblTipo.Visible = True
        Form2.Lblradio.Visible = True
        Form2.Txttipo.Visible = True
        Form2._TxtRad_0.Visible = True
        Form2.DataGrid1.Visible = False
        '    Form2.Command2.Visible = True
    End Sub


    Sub Crea_datagrid11()
        Form2.LblTipo.Visible = False
        Form2.Lblradio.Visible = False
        Form2.Txttipo.Visible = False
        Form2._TxtRad_0.Visible = False
        Form2._TxtRad_1.Visible = False
        Form2._TxtRad_2.Visible = False
        Form2._TxtRad_3.Visible = False
        Form2.DataGrid1.Visible = True
        '  Form2.Command2.Visible = False
        CType(Form2.Controls("DataGrid1"), Object).Col = 18
        CType(Form2.Controls("DataGrid1"), Object).Row = 1
        CType(Form2.Controls("DataGrid1"), Object).Columns(0).Width() '= VB6.TwipsToPixelsX(600)
        CType(Form2.Controls("DataGrid1"), Object).Columns(1).Width() '= VB6.TwipsToPixelsX(900)
        CType(Form2.Controls("DataGrid1"), Object).Columns(2).Width() '= VB6.TwipsToPixelsX(1200)
        CType(Form2.Controls("DataGrid1"), Object).Columns(3).Width() '= VB6.TwipsToPixelsX(1200)
        CType(Form2.Controls("DataGrid1"), Object).Columns(4).Width() '= VB6.TwipsToPixelsX(1800)
        CType(Form2.Controls("DataGrid1"), Object).Columns(5).Width() '= VB6.TwipsToPixelsX(600)
        CType(Form2.Controls("DataGrid1"), Object).Columns(6).Width() '= VB6.TwipsToPixelsX(600)
        CType(Form2.Controls("DataGrid1"), Object).Columns(7).Width() '= VB6.TwipsToPixelsX(600)
        CType(Form2.Controls("DataGrid1"), Object).Columns(8).Width() '= VB6.TwipsToPixelsX(600)
        CType(Form2.Controls("DataGrid1"), Object).Columns(9).Width() '= VB6.TwipsToPixelsX(600)
        CType(Form2.Controls("DataGrid1"), Object).Columns(10).Width() ' = VB6.TwipsToPixelsX(600)
        CType(Form2.Controls("DataGrid1"), Object).Columns(11).Width() ' = VB6.TwipsToPixelsX(600)
        CType(Form2.Controls("DataGrid1"), Object).Columns(12).Width() ' = VB6.TwipsToPixelsX(600)
        CType(Form2.Controls("DataGrid1"), Object).Columns(13).Width() ' = VB6.TwipsToPixelsX(600)
        CType(Form2.Controls("DataGrid1"), Object).Columns(14).Width() ' = VB6.TwipsToPixelsX(600)
        CType(Form2.Controls("DataGrid1"), Object).Columns(15).Width() ' = VB6.TwipsToPixelsX(600)
        CType(Form2.Controls("DataGrid1"), Object).Columns(16).Width() ' = VB6.TwipsToPixelsX(600)
        CType(Form2.Controls("DataGrid1"), Object).Columns(17).Width() ' = VB6.TwipsToPixelsX(600)
        CType(Form2.Controls("DataGrid1"), Object).Row = 0
        CType(Form2.Controls("DataGrid1"), Object).Col = 0
        CType(Form2.Controls("DataGrid1"), Object).Text = "FUENTE"
        CType(Form2.Controls("DataGrid1"), Object).Col = 1
        CType(Form2.Controls("DataGrid1"), Object).Text = "CLASIFIC."
        CType(Form2.Controls("DataGrid1"), Object).Col = 2
        CType(Form2.Controls("DataGrid1"), Object).Text = "TIPO"
        CType(Form2.Controls("DataGrid1"), Object).Col = 3
        CType(Form2.Controls("DataGrid1"), Object).Text = "GEOMETRIA"
        CType(Form2.Controls("DataGrid1"), Object).Col = 4
        CType(Form2.Controls("DataGrid1"), Object).Text = "DIMENSIONES"
        CType(Form2.Controls("DataGrid1"), Object).Col = 5
        CType(Form2.Controls("DataGrid1"), Object).Text = "RADION.1"
        CType(Form2.Controls("DataGrid1"), Object).Col = 6
        CType(Form2.Controls("DataGrid1"), Object).Text = "RADION.2"
        CType(Form2.Controls("DataGrid1"), Object).Col = 7
        CType(Form2.Controls("DataGrid1"), Object).Text = "RADION.3"
        CType(Form2.Controls("DataGrid1"), Object).Col = 8
        CType(Form2.Controls("DataGrid1"), Object).Text = "RADION.4"
        CType(Form2.Controls("DataGrid1"), Object).Col = 9
        CType(Form2.Controls("DataGrid1"), Object).Text = "RADION.5"
        CType(Form2.Controls("DataGrid1"), Object).Col = 10
        CType(Form2.Controls("DataGrid1"), Object).Text = "RADION.6"
        CType(Form2.Controls("DataGrid1"), Object).Col = 11
        CType(Form2.Controls("DataGrid1"), Object).Text = "RADION.7"
        CType(Form2.Controls("DataGrid1"), Object).Col = 12
        CType(Form2.Controls("DataGrid1"), Object).Text = "RADION.8"
        CType(Form2.Controls("DataGrid1"), Object).Col = 13
        CType(Form2.Controls("DataGrid1"), Object).Text = "RADION.9"
        CType(Form2.Controls("DataGrid1"), Object).Col = 14
        CType(Form2.Controls("DataGrid1"), Object).Text = "RADION.10"
        CType(Form2.Controls("DataGrid1"), Object).Col = 15
        CType(Form2.Controls("DataGrid1"), Object).Text = "RADION.11"
        CType(Form2.Controls("DataGrid1"), Object).Col = 16
        CType(Form2.Controls("DataGrid1"), Object).Text = "RADION.12"
    End Sub

End Module
