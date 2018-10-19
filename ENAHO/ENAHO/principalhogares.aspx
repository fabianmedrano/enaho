<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="principalhogares.aspx.cs" Inherits="ENAHO.principalhogares" %>

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
        <!-----------------------------------------------------PARA CADA HOGAR------------------------------------------------------------->
            <div class="panel panel-default  "><!-- VIV3 -->
             <!---   <div class="panel-heading">
                    Vivienda y servicios
                </div>  -->
                <div class="panel-body">
                    <div class="col-md-12 left">
                        <div class="form-group">
                            <div class=" row">
                                <label class="control-label col-md-5">¿Todas las personas del hogar ¿viven aquí hace más de seis meses?</label>
                                 <asp:RadioButtonList runat="server" ID="rb_6_aqui_vivienda"  CssClass="col-md-7 right " AutoPostBack="True" >
                                    <asp:ListItem Text="Si" Value="1" />
                                    <asp:ListItem Text="No" Value="0" />
                                </asp:RadioButtonList>
                            </div><!--  de seis meses -->
                            <div class=" row">
                                <label class="control-label col-md-5"> Esa o esas personas ¿tienen otro lugar donde vivir?</label>
                                 <asp:RadioButtonList runat="server" ID="rb_personas_otro_lugar_vivir"  CssClass="col-md-7 right " AutoPostBack="True" >
                                    <asp:ListItem Text="Si" Value="1" />
                                    <asp:ListItem Text="No" Value="0" />
                                </asp:RadioButtonList>
                            </div><!--  tienen otro lugar donde vivirs -->
                            <div class=" row" runat="server" id="row_numero_personas_otra_vivienda"><!--  VIV4 -->
                                <label class="control-label col-md-5">¿cuántas?</label>
                                 <asp:TextBox runat="server" ID="tb_numero_personas_otra_vivienda"  CssClass="col-md-7 right top form-control" > </asp:TextBox>
                            </div><!--cantidad personas tienen otro lugar donde vivir  -->
                            <div class=" row" runat="server" ><!--  VIV5a -->
                                <label class="control-label col-md-5">Alguna persona del hogar que no haya mencionado ¿está viviendo en otra parte?</label>
                                <asp:RadioButtonList runat="server" ID="rb_personas_viviendo_otra_parte"  CssClass="col-md-7 right " AutoPostBack="True" >
                                    <asp:ListItem Text="Si" Value="1" />
                                    <asp:ListItem Text="No" Value="0" />
                                </asp:RadioButtonList>
                            </div><!-- Alguna persona del hogar que no haya mencionado ¿está viviendo en otra parte?  -->
                            <div class=" row" runat="server" ><!--  VIV5a -->
                                <label class="control-label col-md-5">Esa o esas personas ¿estarán ausentes por un periodo que en total será menos de seis meses?</label>
                                <asp:RadioButtonList runat="server" ID="rb_personas_ausentes_menos_6_meses"  CssClass="col-md-7 right " AutoPostBack="True" >
                                    <asp:ListItem Text="Si" Value="SI" />
                                    <asp:ListItem Text="No" Value="NO" />
                                </asp:RadioButtonList>
                            </div><!-- Esa o esas personas ¿estarán ausentes por un periodo que en total será menos de seis meses?  -->
                            <div class=" row" runat="server" id="row_numero_personas_ausentes_menos_6_meses"><!--  VIV4 -->
                                <label class="control-label col-md-5">¿cuántas?</label>
                                <asp:TextBox runat="server" ID="tb_personas_ausentes_menos_6_meses"  CssClass="col-md-7 right top form-control" > </asp:TextBox>
                            </div><!--cantidad personas aucentes por menos de 6 meses  -->
                            <div class=" row" runat="server" id="Div2"><!--  VIV6  encavesado-->
                                <label class="control-label col-md-5"> ¿En este hogar hay…</label>
                            </div>
                            <div class=" row" runat="server" id="Div1"><!--  VIV6 -->

                                 <div class="left  col-md-6">
                                    <label class="control-label col-md-8">…servicio doméstico que duerme en la vivienda?</label>
                                    <asp:RadioButtonList runat="server" ID="rb_servicio_domestico"  CssClass="col-md-4 right " AutoPostBack="True" >
                                        <asp:ListItem Text="Si" Value="SI" />
                                        <asp:ListItem Text="No" Value="NO" />
                                    </asp:RadioButtonList>
                                 </div><!--colmna derecha  …servicio doméstico que duerme en la vivienda -->
                                 <div class="right  col-md-6">
                                    <label class="control-label col-md-8">…personas a las que se les alquila un cuarto con o sin comida?</label>
                                    <asp:RadioButtonList runat="server" ID="rb_alquilan_carto"  CssClass="col-md-4 right " AutoPostBack="True" >
                                        <asp:ListItem Text="Si" Value="SI" />
                                        <asp:ListItem Text="No" Value="NO" />
                                    </asp:RadioButtonList>
                                </div><!--colmna izqierda  personas a las que se les alquila un cuarto con o sin comida-->
                            </div><!--cantidad personas aucentes por menos de 6 meses  -->
                            <div class="row" runat="server" id="row_servico_domestico">
                                <div class="left  col-md-6">
                                    <label class="control-label col-md-4">¿cuántas?</label>
                                    <asp:TextBox runat="server" ID="tb_servicio_domestico_cuanto"  CssClass="col-md-7 right top form-control" > </asp:TextBox>
                                </div><!--colmna derecha servicio doméstico que duerme en la vivienda -->
                                <div class="right  col-md-6">
                                    <label class="control-label col-md-4">¿cuántas?</label>
                                    <asp:TextBox runat="server" ID="TextBox1"  CssClass="col-md-7 right top form-control" > </asp:TextBox>
                                </div><!--colmna izquierda  personas a las que se les alquila un cuarto con o sin comida -->
                            </div>

                        </div><!--  From group -->
                    </div>
                </div><!--  panel body Para cada hogar -->
            </div><!-- informacion pPara cada hogar --
            <!------------------------------------------------------------------------------------------------------------------>
          
        </div><!--  contenedor principal-->
    </form>
</body>
</html>
