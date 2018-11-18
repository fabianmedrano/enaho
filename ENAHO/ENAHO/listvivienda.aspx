<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listvivienda.aspx.cs" Inherits="ENAHO.listvivienda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <script src="Scripts/jquery-3.3.1.min.js"></script>
        <!--<script src="Scripts/acordeon.js"></script>-->
        <link href="Content/bootstrap.min.css" rel="stylesheet" />
        <link href="Content/principal.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="col-md-10 center-block ">
            <div class="panel panel-default  ">
                <div class="panel-heading accordion">
                    Informacion de vivienda
                </div>
                <div class="panel-body contenido">

                    <asp:GridView ID="gb_list_viviendas" CssClass=" " runat="server">
                        <Columns>
                            <asp:ButtonField ButtonType="Button" CommandName="Delete" HeaderText="Eliminar" ShowHeader="True" Text="Eliminar" />
                            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Seleccionar" ShowHeader="True" Text="Seleccionar" />
                        </Columns>
                    </asp:GridView>

                </div>
            </div>

        </div>
    </form>
</body>
</html>
