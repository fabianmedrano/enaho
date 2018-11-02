<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="principalhogares.aspx.cs" Inherits="ENAHO.principalhogares" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/principal.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/principal.css" rel="stylesheet" />
    <link href="Content/nav.css" rel="stylesheet" />
    <title>ENAHO</title>
</head>
<body>
    <form id="form" runat="server">
       
  <nav class="navbar navbar-inverse" style="margin-top:initial"  role="navigation">
 
    <div class="navbar-header">
      <a class="navbar-brand" href="#">Inicio</a>
    </div>

    <!-- Collect the nav links, forms, and other content for toggling -->
    <div class="collapse navbar-collapse ">
      <ul class="nav navbar-nav">
        <li><a href="#">Agregar Hogar</a></li>
        <li><a href="#">Lista de  Hogares</a></li>
      </ul>
    </div>
  </nav>

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
                <div class="panel-footer" >
                    <asp:Button runat="server" Text="Siguiente" CssClass=" btn btn-primary " OnClick="btn_siguiente_hogares" />
                </div>
            </div><!-- informacion pPara cada hogar --
            <!------------------------------------------------------------------------------------------------------------------>
             <div class="panel panel-default  "><!-- VIV3 -->
               <div class="panel-heading">
                   Bono de Vivienda
                </div>  
                <div class="panel-body">
                    <div class="col-md-12 left">
                        <div class="form-group">
                            <div class=" row">
                                <label class="control-label col-md-5">¿Este hogar recibió bono de vivienda?</label>
                                 <asp:RadioButtonList runat="server" ID="RadioButtonList1"  CssClass="col-md-7 right " AutoPostBack="True" >
                                    <asp:ListItem Text="Si" Value="true" />
                                    <asp:ListItem Text="No" Value="false" />
                                </asp:RadioButtonList>
                            </div>
                            <div class=" row" runat="server" id="Div3"><!--  VIV4 -->
                                <label class="control-label col-md-5">En que año</label>
                                 <asp:TextBox runat="server" ID="tb_ano_bono"  CssClass="col-md-7 right top form-control" > </asp:TextBox>
                            </div>
                            <div class=" row">
                                <label class="control-label col-md-5">¿De qué tipo?</label>
                                 <asp:RadioButtonList runat="server" ID="RadioButtonList2"  CssClass="col-md-7 right " AutoPostBack="True" >
                                    <asp:ListItem Text="Compra de vivienda existente" Value="1" />
                                    <asp:ListItem Text="Compra de lote y construcción" Value="2" />
                                    <asp:ListItem Text="Compra de lote" Value="3" />
                                    <asp:ListItem Text=" Construcción de vivienda en terreno propio " Value="4" />
                                    <asp:ListItem Text="Mejora ampliación o terminación de vivienda" Value="5" />
                                    <asp:ListItem Text="No ha recibido" Value="6" />
                                </asp:RadioButtonList>
                            </div><!--  tienen otro lugar donde vivirs -->
                        </div>

                        <div class="form-group">
                            <div class=" row">
                                <label class="control-label col-md-5"> ¿Ha solicitado bono de vivienda?</label>
                                 <asp:RadioButtonList runat="server" ID="RadioButtonList3"  CssClass="col-md-7 right " AutoPostBack="True" >
                                    <asp:ListItem Text="Si" Value="true" />
                                    <asp:ListItem Text="No" Value="false" />
                                </asp:RadioButtonList>
                            </div>
                            <div class=" row">
                                <label class="control-label col-md-5">¿Por qué razón no lo ha recibido?</label>
                                 <asp:RadioButtonList runat="server" ID="RadioButtonList4"  CssClass="col-md-7 right " AutoPostBack="True" >
                                    <asp:ListItem Text="Está en estudio o trámite" Value="1" />
                                    <asp:ListItem Text="Lo rechazaron" Value="2" />
                                     <asp:ListItem Text="Otro" Value="OTRO" />
                                </asp:RadioButtonList>
                            </div>
                            <div class=" row">
                                <label class="control-label col-md-5">Espesifique</label>
                                 <asp:TextBox runat="server" ID="TextBox2"  CssClass="col-md-7 right top form-control" > </asp:TextBox>
                            </div>
                        </div>

                         <div class="form-group">
                            <div class=" row">
                                <label class="control-label col-md-5">¿La razón de no haberlo solicitado es porque</label>
                                 <asp:RadioButtonList runat="server" ID="RadioButtonList5"  CssClass="col-md-7 right " AutoPostBack="True" >
                                    <asp:ListItem Text=" no lo necesita o nocalifica?" Value="1" />
                                    <asp:ListItem Text="no conoce el programa o no sabe cómo solicitarlo?" Value="2" />
                                    <asp:ListItem Text="los trámites son complicados?" Value="3" />
                                    <asp:ListItem Text="no tiene papeles (no tiene residencia)?" Value="4" />
                                    <asp:ListItem Text="el programa no existe cerca de donde vive?" Value="5" />
                                    <asp:ListItem Text="Otro" Value="OTRO" />
                                </asp:RadioButtonList>
                            </div>
                            <div class=" row">
                                <label class="control-label col-md-5">Espesifique</label>
                                 <asp:TextBox runat="server" ID="TextBox3"  CssClass="col-md-7 right top form-control" > </asp:TextBox>
                            </div>
                        </div>
                     </div>
                </div>
                <div class="panel-footer" >
                    <asp:Button runat="server" Text="Siguiente" CssClass=" btn btn-primary " OnClick="btn_siguiente_hogares" />
                </div>
            </div>
               <!-------------------------------------------------------------------------------------------------------------->
        </div><!--  contenedor principal-->
    </form>
</body>
</html>
