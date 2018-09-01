<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="principal.aspx.cs" Inherits="ENAHO.principal" MaintainScrollPositionOnPostback="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/principal.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/principal.css" rel="stylesheet" />
    <title>ENAHO</title>
</head>
<body>
    <form id="form" runat="server">

        <div class="col-md-7 center-block ">
            <!--  -->

            <div class="panel panel-default  ">
                <div class="panel-heading">
                    Informacion de vivienda
                </div>
                <div class="panel-body">
                        <div class="col-md-5 left">
                            <div class="form-group">
                                <div class=" row">
                                    <label class="control-label col-md-3">Region:</label>
                                    <asp:TextBox runat="server" ID="tb_region"  CssClass="col-md-7 right"></asp:TextBox>
                                </div><!-- Region-->
                                <!--  -->
                                <div class=" row">
                                    <label class="control-label col-md-3">Provincia:</label>
                                    <asp:DropDownList runat="server" ID="ddl_provincia"  CssClass="col-md-7 right"></asp:DropDownList>
                                </div><!-- provincia-->
                                <!--  -->
                                <div class=" row">
                                    <label class="control-label col-md-3">Canton:</label>
                                    <asp:DropDownList runat="server" ID="ddl_canton"  CssClass="col-md-7 right"></asp:DropDownList>
                                </div><!-- canton-->
                                <div class=" row">
                                    <label class="control-label col-md-3">Distrito:</label>
                                    <asp:DropDownList runat="server" ID="ddl_distrito"  CssClass="col-md-7 right"></asp:DropDownList>
                                </div><!-- distrito-->
                            </div>
                        </div><!--  columna de izquierda-->
                        <div class="col-md-7 left" >
                            <div class="form-group">
                                <div class=" row">
                                    <label class="control-label col-md-3">Direccion:</label>
                                    <asp:TextBox runat="server" ID="tb_direccion"  CssClass="col-md-7 right"></asp:TextBox>
                                </div><!-- direccion-->
                                <div class=" row">
                                    <label class="control-label col-md-3">Telefono:</label>
                                    <asp:TextBox runat="server" ID="tb_telefono"  CssClass="col-md-7 right"></asp:TextBox>
                                </div><!-- telefono-->
                                <div class=" row">
                                    <label class="control-label col-md-12"> 
                                        ¿Se aplica en esta vivienda el Módulo de Gasto de Consumo de los Hogares?:

                                    </label>
                                    <asp:RadioButton runat="server" ID="TextBox1"  CssClass="col-md-7 right"></asp:RadioButton>
                                </div><!-- modula de gastos-->

                            </div>
                        </div><!--  columna de derecha-->

                </div>
                   
            </div><!--  panel Informacion vivienda -->

            <div class="panel panel-default  ">
                <div class="panel-heading">
                    Informacion para vivienda
                </div>
                <div class="panel-body">
                    <div class="col-md-12 left">
                        <div class="form-group">
                            <div class=" row">
                                <label class="control-label col-md-5">Numero de Personas en la vivienda:</label>
                                <asp:TextBox runat="server" ID="tb_cantidad_personas_vivienda"  CssClass="col-md-7 right"></asp:TextBox>
                            </div><!-- numero de personas vivienda-->
                             <div class=" row">
                                <label class="control-label col-md-5">Comparten mismo presupuesto:</label>
                                 <asp:RadioButtonList runat="server" ID="rb_mismo_prespuesto"  CssClass="col-md-7 right" AutoPostBack="True">
                                    <asp:ListItem Text="Si" Value="SI" />
                                    <asp:ListItem Text="No" Value="NO" />
                                </asp:RadioButtonList>
                            </div><!-- mismo presupuesto -->
                             <div class=" row" runat="server" id="row_numero_hogares_vivienda">
                                <label class="control-label col-md-5">Numero de hogares en la vivienda:</label>
                                 <asp:TextBox runat="server" ID="tb_numero_hogares_vivienda"  CssClass="col-md-7 right" > </asp:TextBox>
                            </div><!-- numero de hohares en vivienda -->
                        </div>
                    </div>
                </div><!--  panel Para vivienda -->
            </div><!--  panel Informacion para vivienda -->
        </div><!--  contenedor principal-->
    </form>
</body>
</html>
