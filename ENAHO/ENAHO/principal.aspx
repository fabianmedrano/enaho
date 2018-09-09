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
            
            <!------------------------------------------------------------------------------------------------------------------>

            <div class="panel panel-default  ">
                <div class="panel-heading">
                    Informacion de vivienda
                </div>
                <div class="panel-body">
                        <div class="col-md-5 left">
                            <div class="form-group">
                                <div class=" row">
                                    <label class="control-label col-md-3">Region:</label>
                                    <asp:TextBox runat="server" ID="tb_region"  CssClass="col-md-7 right top form-control"></asp:TextBox>
                                </div><!-- Region-->
                                <!--  -->
                                <div class=" row">
                                    <label class="control-label col-md-3">Provincia:</label>
                                    <asp:DropDownList runat="server" ID="ddl_provincia"  CssClass="col-md-7 right top form-control"></asp:DropDownList>
                                </div><!-- provincia-->
                                <!--  -->
                                <div class=" row">
                                    <label class="control-label col-md-3">Canton:</label>
                                    <asp:DropDownList runat="server" ID="ddl_canton"  CssClass="col-md-7 right top form-control"></asp:DropDownList>
                                </div><!-- canton-->
                                <div class=" row">
                                    <label class="control-label col-md-3">Distrito:</label>
                                    <asp:DropDownList runat="server" ID="ddl_distrito"  CssClass="col-md-7 right top form-control"></asp:DropDownList>
                                </div><!-- distrito-->
                            </div>
                        </div><!--  columna de izquierda-->
                        <div class="col-md-7 left" >
                            <div class="form-group">
                                <div class=" row">
                                    <label class="control-label col-md-3">Direccion:</label>
                                    <asp:TextBox runat="server" ID="tb_direccion"  CssClass="col-md-7 right top form-control"></asp:TextBox>
                                </div><!-- direccion-->
                                <div class=" row">
                                    <label class="control-label col-md-3">Telefono:</label>
                                    <asp:TextBox runat="server" ID="tb_telefono"  CssClass="col-md-7 right top form-control "></asp:TextBox>
                                </div><!-- telefono-->
                                <div class=" row">
                                    <label class="control-label col-md-12"> 
                                        ¿Se aplica en esta vivienda el Módulo de Gasto de Consumo de los Hogares?:

                                    </label>
                                    <asp:RadioButtonList runat="server" ID="rb_mgch"  CssClass="col-md-7 right  radio" AutoPostBack="True">
                                        <asp:ListItem Text="Si" Value="SI" />
                                        <asp:ListItem Text="No" Value="NO" />
                                    </asp:RadioButtonList>
                                </div><!-- modula de gastos-->

                            </div>
                        </div><!--  columna de derecha-->
                </div>
            </div><!--  panel Informacion vivienda -->
            <!------------------------------------------------------------------------------------------------------------------>
            <div class="panel panel-default  ">
                <div class="panel-heading">
                    Informacion para vivienda
                </div>
                <div class="panel-body">
                    <div class="col-md-12 left">
                        <div class="form-group">
                            <div class=" row">
                                <label class="control-label col-md-5">Numero de Personas en la vivienda:</label>
                                <asp:TextBox runat="server" ID="tb_cantidad_personas_vivienda"  CssClass="col-md-7 right top form-control"></asp:TextBox>
                            </div><!-- numero de personas vivienda-->
                             <div class=" row">
                                <label class="control-label col-md-5">Comparten mismo presupuesto:</label>
                                 <asp:RadioButtonList runat="server" ID="rb_mismo_prespuesto"  CssClass="col-md-7 right " AutoPostBack="True">
                                    <asp:ListItem Text="Si" Value="SI" />
                                    <asp:ListItem Text="No" Value="NO" />
                                </asp:RadioButtonList>
                            </div><!-- mismo presupuesto -->
                             <div class=" row" runat="server" id="row_numero_hogares_vivienda">
                                <label class="control-label col-md-5">Numero de hogares en la vivienda:</label>
                                 <asp:TextBox runat="server" ID="tb_numero_hogares_vivienda"  CssClass="col-md-7 right top form-control" > </asp:TextBox>
                            </div><!-- numero de hohares en vivienda -->
                        </div>
                    </div>
                </div><!--  panel Para vivienda -->
            </div><!--  panel Informacion para vivienda -->
        
            <!------------------------------------------------------------------------------------------------------------------>
            <div class="panel panel-default  ">
                <div class="panel-heading">
                    Informacion de Cada Hogar
                </div>
                <div class="panel-body">
                    <div class="col-md-12 left">
                        <div class="form-group">
                            <div class=" row">
                                <!------
                                    -----
                                    -----
                                    -----
                                    -----
                                    ----->
                            </div><!-- numero de hohares en vivienda -->
                        </div>
                    </div>
                </div><!--  panel Para vivienda -->
            </div><!-- informacion para cada vivienda -->
             <!------------------------------------------------------------------------------------------------------------------>
            <div class="panel panel-default  "><!-- v1 -->
                <div class="panel-heading">
                    Vivienda y servicios
                </div>
                <div class="panel-body">
                    <div class="col-md-12 left">
                        <div class="form-group">
                             <div class=" row">
                                <label class="control-label col-md-5">Tipo de vivienda:</label>
                                 <asp:RadioButtonList runat="server" ID="rb_tipo_vivienda"  CssClass="col-md-7 right " AutoPostBack="True" OnSelectedIndexChanged="rb_tipo_vivienda_SelectedIndexChanged">
                                    <asp:ListItem Text="Si" Value="SI" />
                                    <asp:ListItem Text="No" Value="NO" />
                                     <asp:ListItem Text="Si" Value="SI" />
                                    <asp:ListItem Text="No" Value="NO" />
                                    <asp:ListItem Text="Si" Value="SI" />
                                    <asp:ListItem Text="No" Value="NO" />
                                    <asp:ListItem Text="Otro" Value="OTRO" />
                                   
                                </asp:RadioButtonList>
                            </div><!-- tipo vivienda -->
                            <div class=" row" runat="server" id="row_especificar_tipo_vivienda">
                                <label class="control-label col-md-5">Tipo de vivienda:</label>
                                 <asp:TextBox runat="server" ID="tb_espeficar_tipo_vivienda"  CssClass="col-md-7 right top form-control" > </asp:TextBox>
                            </div><!-- especificar tipo de vivienda -->
                        </div>
                    </div>
                </div><!--  panel Para vivienda -->
            </div><!-- informacion para cada vivienda --
                 <!------------------------------------------------------------------------------------------------------------------>
            <div class="panel panel-default  "><!-- v1 -->
                <div class="panel-heading">
                    Vivienda y servicios
                </div>
                <div class="panel-body">
                    <div class="col-md-12 left">
                        <div class="form-group">
                             <div class=" row">
                                <label class="control-label col-md-5">¿Esta vivienda?:</label>
                                 <asp:RadioButtonList runat="server" ID="RadioButtonList1"  CssClass="col-md-7 right " AutoPostBack="True" OnSelectedIndexChanged="rb_tipo_vivienda_SelectedIndexChanged">
                                    <asp:ListItem Text="Propia totalmeente pagada" Value="1" />
                                    <asp:ListItem Text="Propia pagada a plazos" Value="2" />
                                     <asp:ListItem Text="Es alquilada" Value="3" />
                                    <asp:ListItem Text="Esta en precario" Value="4" />
                                    <asp:ListItem Text="Otra(cedida,prestada)" Value="5" />
                                   
                                </asp:RadioButtonList>
                            </div><!-- tipo vivienda -->
                            <div class=" row" runat="server" id="Div1">
                                <label class="control-label col-md-5">Cuanto pagaria por mensalidad:</label>
                                 <asp:TextBox runat="server" ID="TextBox1"  CssClass="col-md-7 right top form-control" > </asp:TextBox>
                            </div><!-- especificar tipo de vivienda -->
                        </div>
                    </div>
                </div><!--  panel Para vivienda -->
            </div><!-- informacion para cada vivienda --


             <!--------------------------------------------------------xxxxxxxx-------------------------------------------------->
        </div><!--  contenedor principal-->
    </form>
</body>
</html>
