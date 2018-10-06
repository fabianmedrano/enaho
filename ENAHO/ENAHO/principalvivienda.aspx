<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="principalvivienda.aspx.cs" Inherits="ENAHO.principal" MaintainScrollPositionOnPostback="true" %>

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
                                    <label class="control-label col-md-3" ">Provincia:</label>
                                    <asp:DropDownList runat="server" ID="ddl_provincia"  CssClass="col-md-7 right top form-control DDL" AutoPostBack="True" OnSelectedIndexChanged="ddl_Provincia_SelectedIndexChanged"></asp:DropDownList>
                                </div><!-- provincia-->
                                <!--  -->
                                <div class=" row">
                                    <label class="control-label col-md-3">Canton:</label>
                                    <asp:DropDownList runat="server" ID="ddl_canton"  CssClass="col-md-7 right top form-control DDL" AutoPostBack="True" OnSelectedIndexChanged="ddl_canton_SelectedIndexChanged"></asp:DropDownList>
                                </div><!-- canton-->
                                <div class=" row">
                                    <label class="control-label col-md-3">Distrito:</label>
                                    <asp:DropDownList runat="server" ID="ddl_distrito"  CssClass="col-md-7 right top form-control DDL" AutoPostBack="True" ></asp:DropDownList>
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
            <div class="panel panel-default  "><!-- v1 -->
                <div class="panel-heading">
                    Vivienda y servicios
                </div>
                <div class="panel-body">
                    <div class="col-md-12 left">
                        <div class="form-group">
                             <div class=" row">
                                <label class="control-label col-md-5">Tipo de vivienda:</label>
                                 <asp:RadioButtonList runat="server" ID="rb_tipo_vivienda"  CssClass="col-md-7 right " AutoPostBack="True" >
                                    <asp:ListItem Text="Casa en condominio o residencial cerrado" Value="1" />
                                    <asp:ListItem Text="Casa independiente" Value="2" />
                                    <asp:ListItem Text=" En fila o contigua" Value="3" />
                                    <asp:ListItem Text="En edificio (condominio vertical o apartamento)" Value="4" />
                                    <asp:ListItem Text="Cuartería" Value="5" />
                                    <asp:ListItem Text="Tugurio" Value="6" />
                                    <asp:ListItem Text="Otro" Value="OTRO" />
                                   
                                </asp:RadioButtonList>
                            </div><!-- tipo vivienda -->

                            <div class=" row" runat="server" id="row_especificar_tipo_vivienda">
                                <label class="control-label col-md-5">Especifique:</label>
                                 <asp:TextBox runat="server" ID="tb_espeficar_tipo_vivienda"  CssClass="col-md-7 right top form-control" > </asp:TextBox>
                            </div><!-- especificar tipo de vivienda -->
                              <hr />


                            <div class=" row" runat="server" id="row_mensualidad">
                                <label class="control-label col-md-5">Mensualidad:</label>
                                 <asp:TextBox runat="server" ID="tb_mensualidad"  CssClass="col-md-7 right top form-control" > </asp:TextBox>
                            </div><!-- mensualidad -->
                        </div><!--  panel Para vivienda -->
                        <!-- informacion para cada vivienda -->

                 <!------------------------------------------------------------------------------------------------------------------>
                         <div class="form-group">
                             <div class=" row">
                                <label class="control-label col-md-5">¿Esta vivienda?:</label>
                                 <asp:RadioButtonList runat="server" ID="rb_esta_vivienda"  CssClass="col-md-7 right " AutoPostBack="True" >
                                    <asp:ListItem Text="Propia totalmeente pagada" Value="1" />
                                    <asp:ListItem Text="Propia pagada a plazos" Value="2" />
                                    <asp:ListItem Text="Es alquilada" Value="3" />
                                    <asp:ListItem Text="Esta en precario" Value="4" />
                                    <asp:ListItem Text="Otra(cedida,prestada)" Value="5" />
                                   
                                </asp:RadioButtonList>
                            </div><!-- tipo vivienda -->
                            <div class=" row" runat="server" id="row_pagaria_mesualidad">
                                <label class="control-label col-md-5">Cuanto pagaria por mensalidad:</label>
                                 <asp:TextBox runat="server" ID="TextBox1"  CssClass="col-md-7 right top form-control" > </asp:TextBox>
                            </div><!-- especificar tipo de vivienda -->
                        </div>
                        <!-- informacion para cada vivienda -->
                        <!--  panel Para vivienda -->
                        <!------------------------------------------------------------------------------------------------------------------>
                        <hr/>
                        <div class="form-group">
                             <div class=" row">
                                <label class="control-label col-md-5">¿Cuál es el material predominante en las paredes exteriores?:</label>
                                 <asp:RadioButtonList runat="server" ID="rb_material_predominante_vivienda"  CssClass="col-md-7 right " AutoPostBack="True" >
                                    <asp:ListItem Text="Block o ladrillo" Value="1" />
                                    <asp:ListItem Text="Zócalo (con madera, zinc o fibrocemento)" Value="2" />
                                    <asp:ListItem Text="Madera" Value="3" />
                                    <asp:ListItem Text="Prefabricado" Value="4" />
                                    <asp:ListItem Text="Zinc" Value="5" />
                                    <asp:ListItem Text="Fibrocemento (Fibrolit, Ricalit) " Value="6" />
                                    <asp:ListItem Text="Fibras naturales (bambú, caña, chonta)" Value="7" />
                                    <asp:ListItem Text="Material de desecho" Value="0" />
                                    <asp:ListItem Text="Otro" Value="OTRO" />
                                   
                                </asp:RadioButtonList>
                            </div><!-- tipo vivienda -->
                            <div class=" row" runat="server" id="row_tb_material__predominante_vivienda">
                                <label class="control-label col-md-5">Especifique:</label>
                                 <asp:TextBox runat="server" ID="tb_material__predominante_vivienda"  CssClass="col-md-7 right top form-control" > </asp:TextBox>
                            </div><!-- especificar tipo de vivienda -->
                        </div>
                            <!------------------------------------------------------------------------------------------------------------------>
                                                <hr/>
                        <div class="form-group">
                             <div class=" row">
                                <label class="control-label col-md-5">¿Cuál es el material predominante en el techo?:</label>
                                 <asp:RadioButtonList runat="server" ID="rb_material__predominante_techo"  CssClass="col-md-7 right " AutoPostBack="True" >
                                    <asp:ListItem Text="Lámina de metal o zinc" Value="1" />
                                    <asp:ListItem Text="Fibrocemento" Value="2" />
                                    <asp:ListItem Text="Entrepiso" Value="3" />
                                    <asp:ListItem Text="Fibras naturales (bambú, caña, chonta)" Value="4" />
                                    <asp:ListItem Text="Zinc" Value="5" />
                                    <asp:ListItem Text="Material de desecho" Value="0" />
                                    <asp:ListItem Text="Otro" Value="OTRO" />
                                   
                                </asp:RadioButtonList>
                            </div><!-- material techo -->
                            <div class=" row" runat="server" id="row_material__predominante_techo">
                                <label class="control-label col-md-5">Especifique:</label>
                                 <asp:TextBox runat="server" ID="tb_material__predominante_techo"  CssClass="col-md-7 right top form-control" > </asp:TextBox>
                            </div><!-- especificar tipo de vivienda -->
                        </div>
                            <!------------------------------------------------------------------------------------------------------------------>
                      <hr/>
                        <div class="form-group">
                             <div class=" row">
                                <label class="control-label col-md-5"> ¿La vivienda tiene cielo raso?:</label>
                                 <asp:RadioButtonList runat="server" ID="RadioButtonList1"  CssClass="col-md-7 right " AutoPostBack="True" >
                                    <asp:ListItem Text="Si" Value="1" />
                                    <asp:ListItem Text="No" Value="2" />
                                </asp:RadioButtonList>
                            </div><!--cielo razo -->
                 
                        </div>
                            <!------------------------------------------------------------------------------------------------------------------>
                                                                        <hr/>
                        <div class="form-group">
                             <div class=" row">
                                <label class="control-label col-md-5">¿Cuál es el material predominante en el piso?:</label>
                                 <asp:RadioButtonList runat="server" ID="rb_material__predominante_piso"  CssClass="col-md-7 right " AutoPostBack="True" >
                                    <asp:ListItem Text="Mosaico, cerámica, terrazo" Value="1" />
                                    <asp:ListItem Text="Cemento (lujado o no)" Value="2" />
                                    <asp:ListItem Text="Madera" Value="3" />
                                    <asp:ListItem Text="Material natural (bambú, caña, chonta" Value="4" />
                                    <asp:ListItem Text="Material de desecho" Value="0" />
                                    <asp:ListItem Text="Otro" Value="OTRO" />
                                   
                                </asp:RadioButtonList>
                            </div><!-- material techo -->
                            <div class=" row" runat="server" id="row_material__predominante_piso">
                                <label class="control-label col-md-5">Especifique:</label>
                                 <asp:TextBox runat="server" ID="tb_material__predominante_piso"  CssClass="col-md-7 right top form-control" > </asp:TextBox>
                            </div><!-- especificar tipo de vivienda -->
                        </div>
                            <!------------------------------------------------------------------------------------------------------------------>
                        <hr/>
                        <div class="form-group">
                             <div class=" row">
                                <label class="control-label col-md-5">¿La vivienda se encuentra sobre pilotes?:</label>
                                 <asp:RadioButtonList runat="server" ID="RadioButtonList2"  CssClass="col-md-7 right " >
                                    <asp:ListItem Text="Si" Value="1" />
                                    <asp:ListItem Text="No" Value="2" />
                                </asp:RadioButtonList>
                            </div><!--cielo razo -->
                 
                        </div>
                            <!------------------------------------------------------------------------------------------------------------------>

                                                <hr/>
                        <div class="form-group">
                            <div class=" row">
                                <label class="control-label col-md-5">¿Cuál es el estado de...</label>
                            </div>
                                    
                             <div class=" row">
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">las paredes exteriores?</label>
                                     <asp:RadioButtonList runat="server" ID="RadioButtonList3"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="MALO" Value="1" />
                                        <asp:ListItem Text="REGULAR" Value="2" />
                                        <asp:ListItem Text="BUENO" Value="3" />
                                    </asp:RadioButtonList>
                                 </div>
                            
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">el techo?</label>
                                     <asp:RadioButtonList runat="server" ID="RadioButtonList4"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="MALO" Value="1" />
                                        <asp:ListItem Text="REGULAR" Value="2" />
                                        <asp:ListItem Text="BUENO" Value="3" />
                                    </asp:RadioButtonList>
                                 </div>
                                
                     
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">el piso?</label>
                                     <asp:RadioButtonList runat="server" ID="RadioButtonList5"  CssClass="col-md-4 right " >
                                        <asp:ListItem Text="MALO" Value="1" />
                                        <asp:ListItem Text="REGULAR" Value="2" />
                                        <asp:ListItem Text="BUENO" Value="3" />
                                    </asp:RadioButtonList>
                                 </div>
                                
                            </div><!--cielo razo -->
                 
                        </div>
                            <!------------------------------------------------------------------------------------------------------------------>
                         <hr/>
                        <div class="form-group">
                            <div class=" row" runat="server" id="Div1">
                                <label class="control-label col-md-5"> ¿Cuántos cuartos exclusivos para dormir tiene esta vivienda?</label>
                                 <asp:TextBox runat="server" ID="TextBox2"  CssClass="col-md-7 right top form-control" > </asp:TextBox>
                            </div><!-- especificar tipo de vivienda -->
                        </div>
                            <!------------------------------------------------------------------------------------------------------------------>

                        <hr/>
                        <div class="form-group">
                            <div class=" row" runat="server" id="Div2">
                                <label class="control-label col-md-13">Sin contar baños, cuarto de pilas, pasillos, garaje, ¿cuántos aposentos, en total (incluso Nº de cuartos) tiene esta vivienda?</label>
                                 <asp:TextBox runat="server" ID="TextBox3"  CssClass="col-md-7 right top form-control" > </asp:TextBox>
                            </div><!-- especificar tipo de vivienda -->
                        </div>
                            <!------------------------------------------------------------------------------------------------------------------>
                        <hr/>
                        <div class="form-group">
                             <div class=" row">
                                <label class="control-label col-md-5">Aproximadamente, ¿cuántos metros cuadrados de construcción tiene esta vivienda?:</label>
                                 <asp:RadioButtonList runat="server" ID="RadioButtonList6"  CssClass="col-md-7 right " AutoPostBack="True" >
                                    <asp:ListItem Text="Menos de 30m2" Value="1" />
                                    <asp:ListItem Text="De 30 a 40 m2" Value="2" />
                                    <asp:ListItem Text="De 41 a 60 m2" Value="3" />
                                    <asp:ListItem Text="De 61 a 100m2" Value="4" />
                                    <asp:ListItem Text="De 101 a 150m2" Value="5" />
                                    <asp:ListItem Text="De 151 a 200m2 " Value="6" />
                                    <asp:ListItem Text="Más de 200m2" Value="7" />
                                   
                                </asp:RadioButtonList>
                            </div><!-- material techo -->
           
                        </div>
                            <!------------------------------------------------------------------------------------------------------------------>
                        <hr/>
                        <div class="form-group">
                             <div class=" row">
                                <label class="control-label col-md-5"> ¿Esta vivienda se abastece de agua por...:</label>
                                 <asp:RadioButtonList runat="server" ID="RadioButtonList7"  CssClass="col-md-7 right "  >
                                    <asp:ListItem Text="tubería dentro de la vivienda?" Value="1" />
                                    <asp:ListItem Text="tubería fuera de la vivienda, pero dentro del lote o edificio?" Value="2" />
                                    <asp:ListItem Text="tubería fuera del lote o edificio?" Value="3" />
                                    <asp:ListItem Text="No tiene por tubería" Value="4" />
                                   
                                </asp:RadioButtonList>
                            </div><!-- material techo -->
           
                        </div>
                            <!------------------------------------------------------------------------------------------------------------------>
                        <hr/>
                        <div class="form-group">
                             <div class=" row">
                                <label class="control-label col-md-5">¿El agua que consumen proviene de...:</label>
                                 <asp:RadioButtonList runat="server" ID="rb_origen_agua_consumo"  CssClass="col-md-7 right " AutoPostBack="True" >
                                    <asp:ListItem Text="un acueducto del A y A?" Value="1" />
                                    <asp:ListItem Text="un acueducto rural?" Value="2" />
                                    <asp:ListItem Text="un acueducto municipal?" Value="3" />
                                    <asp:ListItem Text="una empresa o cooperativa?" Value="4" />
                                    <asp:ListItem Text="un pozo?" Value="5" />
                                    <asp:ListItem Text="un río, quebrada o naciente?" Value="" />
                                    <asp:ListItem Text="lluvia u otro?" Value="OTRO" />
                                   
                                </asp:RadioButtonList>
                            </div><!-- material techo -->
                            <div class=" row" runat="server" id="row_origen_agua_consumo">
                                <label class="control-label col-md-5">Especifique:</label>
                                 <asp:TextBox runat="server" ID="tb_origen_agua_consumo"  CssClass="col-md-7 right top form-control" > </asp:TextBox>
                            </div><!-- especificar tipo de vivienda -->
                        </div>
                          <!------------------------------------------------------------------------------------------------------------------>
                        <hr/>
                        <div class="form-group">
                             <div class=" row">
                                <label class="control-label col-md-5"> ¿Esta vivienda tiene servicio sanitario...:</label>
                                 <asp:RadioButtonList runat="server" ID="rb_servicio_sanitario"  CssClass="col-md-7 right " AutoPostBack="True" >
                                    <asp:ListItem Text="conectado a alcantarilla o cloaca?" Value="1" />
                                    <asp:ListItem Text="conectado a tanque séptico?" Value="2" />
                                    <asp:ListItem Text="conectado a tanque séptico con tratamiento (fosa biológica)?" Value="3" />
                                    <asp:ListItem Text="de hueco, pozo negro o letrina?" Value="4" />
                                    <asp:ListItem Text="No tiene" Value="0" />
                                    <asp:ListItem Text="con otro sistema?" Value="OTRO" />
                                   
                                </asp:RadioButtonList>
                            </div><!-- material techo -->
                            <div class=" row" runat="server" id="row_servicio_sanitario">
                                <label class="control-label col-md-5">Especifique:</label>
                                 <asp:TextBox runat="server" ID="tb_servicio_sanitario"  CssClass="col-md-7 right top form-control" > </asp:TextBox>
                            </div><!-- especificar tipo de vivienda -->
                        </div>
                        
                            <!------------------------------------------------------------------------------------------------------------------>
                        <hr/>
                        <div class="form-group">
                             <div class=" row">
                                <label class="control-label col-md-5"> ¿El servicio sanitario es:</label>
                                 <asp:RadioButtonList runat="server" ID="RadioButtonList8"  CssClass="col-md-7 right " AutoPostBack="True" >
                                    <asp:ListItem Text="sólo para esta vivienda?" Value="1" />
                                    <asp:ListItem Text="para esta y otras viviendas? " Value="2" />
                                </asp:RadioButtonList>
                            </div><!--cielo razo -->
                 
                        </div>
                            <!------------------------------------------------------------------------------------------------------------------>
                        <hr/>
                        <div class="form-group">
                             <div class=" row">
                                <label class="control-label col-md-5">¿Esta vivienda tiene baño?:</label>
                                 <asp:RadioButtonList runat="server" ID="rb_tiene_banos"  CssClass="col-md-7 right " AutoPostBack="True" >
                                    <asp:ListItem Text="Si" Value="1" />
                                    <asp:ListItem Text="No" Value="2" />
                                </asp:RadioButtonList>
                            </div><!-- material techo -->
                            <div class=" row" runat="server" id="row_tiene_banos">
                                <label class="control-label col-md-5">Cuantos:</label>
                                 <asp:TextBox runat="server" ID="tb_tiene_banos"  CssClass="col-md-7 right top form-control" > </asp:TextBox>
                            </div><!-- especificar tipo de vivienda -->
                        </div>
                        
                            <!------------------------------------------------------------------------------------------------------------------>
                        <hr id="line_uso_bano"/>
                        <div class="form-group">
                             <div class=" row" id="row_uso_bano">
                                <label class="control-label col-md-5">¿El uso del baño es..:</label>
                                 <asp:RadioButtonList runat="server" ID="RadioButtonList9"  CssClass="col-md-7 right "  >
                                    <asp:ListItem Text="sólo para esta vivienda?" Value="1" />
                                    <asp:ListItem Text="para esta y otras viviendas?" Value="2" />
                                </asp:RadioButtonList>
                            </div><!-- material techo -->
                        </div>
                        
                            <!------------------------------------------------------------------------------------------------------------------>
                        <hr/>
                        <div class="form-group">
                             <div class=" row">
                                <label class="control-label col-md-5">¿En esta vivienda hay luz eléctrica...:</label>
                                 <asp:RadioButtonList runat="server" ID="rb_luz_electrica"  CssClass="col-md-7 right " AutoPostBack="True" >
                                    <asp:ListItem Text="del ICE?" Value="1" />
                                    <asp:ListItem Text="de la CNFL?" Value="2" />
                                    <asp:ListItem Text="de la ESPH / JASEC?" Value="3" />
                                    <asp:ListItem Text="de una Cooperativa?" Value="4" />
                                    <asp:ListItem Text="de planta privada?" Value="5" />
                                    <asp:ListItem Text="No hay luz eléctrica" Value="0" />
                                    <asp:ListItem Text="de otra fuente?" Value="OTRO" />
                                   
                                </asp:RadioButtonList>
                            </div><!-- material techo -->
                            <div class=" row" runat="server" id="row_luz_electrica">
                                <label class="control-label col-md-5">Especifique:</label>
                                 <asp:TextBox runat="server" ID="tb_luz_electrica"  CssClass="col-md-7 right top form-control" > </asp:TextBox>
                            </div><!-- especificar tipo de vivienda -->
                        </div>
                          <!------------------------------------------------------------------------------------------------------------------>
                        <hr/>
                        <div class="form-group">
                             <div class=" row">
                                <label class="control-label col-md-5">¿Cuál es la principal fuente de energía usada para cocinar?:</label>
                                 <asp:RadioButtonList runat="server" ID="rb_energia_cosinar"  CssClass="col-md-7 right " AutoPostBack="True" >
                                    <asp:ListItem Text="Electricidad" Value="1" />
                                    <asp:ListItem Text="Gas" Value="2" />
                                    <asp:ListItem Text="Leña o carbón" Value="3" />
                                    <asp:ListItem Text="Ninguno (no cocina)" Value="0" />
                                    <asp:ListItem Text="Otro" Value="OTRO" />
                                   
                                </asp:RadioButtonList>
                            </div><!-- material techo -->
                            <div class=" row" runat="server" id="row_energia_cosinar">
                                <label class="control-label col-md-5">Especifique:</label>
                                 <asp:TextBox runat="server" ID="tb_energia_cosinar"  CssClass="col-md-7 right top form-control" > </asp:TextBox>
                            </div><!-- especificar tipo de vivienda -->
                        </div>
                          <!------------------------------------------------------------------------------------------------------------------>
                        <hr/>
                        <div class="form-group">
                             <div class=" row">
                                <label class="control-label col-md-5"> ¿La basura la eliminan principalmente...:</label>
                                 <asp:RadioButtonList runat="server" ID="rb_eliminar_basura"  CssClass="col-md-7 right " AutoPostBack="True" >
                                    <asp:ListItem Text="por camión recolector?" Value="1" />
                                    <asp:ListItem Text="la botan en hueco o entierran?" Value="2" />
                                    <asp:ListItem Text="la queman?" Value="3" />
                                    <asp:ListItem Text="la botan en río, quebrada o mar?" Value="4" />
                                    <asp:ListItem Text="Otro" Value="OTRO" />
                                   
                                </asp:RadioButtonList>
                            </div><!-- material techo -->
                            <div class=" row" runat="server" id="row_eliminar_basura">
                                <label class="control-label col-md-5">Especifique:</label>
                                 <asp:TextBox runat="server" ID="tb_eliminar_basura"  CssClass="col-md-7 right top form-control" > </asp:TextBox>
                            </div><!-- especificar tipo de vivienda -->
                        </div>
                          <!------------------------------------------------------------------------------------------------------------------>
                        <hr/>
                        <div class="form-group">
                            <div class=" row">
                                <label class="control-label col-md-5">¿Separan la basura...</label>
                            </div>
                                    
                             <div class=" row">
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">orgánica?</label>
                                     <asp:RadioButtonList runat="server" ID="RadioButtonList10"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="1" />
                                        <asp:ListItem Text="No" Value="0" />
                                    </asp:RadioButtonList>
                                 </div>
                            
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">plástica?</label>
                                     <asp:RadioButtonList runat="server" ID="RadioButtonList11"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="1" />
                                        <asp:ListItem Text="No" Value="0" />
                                    </asp:RadioButtonList>
                                 </div>
                                
                     
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">de vidrio?</label>
                                     <asp:RadioButtonList runat="server" ID="RadioButtonList12"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="1" />
                                        <asp:ListItem Text="No" Value="0" />
                                    </asp:RadioButtonList>
                                 </div>
                                
                            </div>
                            <div class=" row"><!---fila 2--->
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">de aluminio?</label>
                                     <asp:RadioButtonList runat="server" ID="RadioButtonList13"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="1" />
                                        <asp:ListItem Text="No" Value="0" />
                                    </asp:RadioButtonList>
                                 </div>
                            
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">de papel o cartón?	</label>
                                     <asp:RadioButtonList runat="server" ID="RadioButtonList14"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="1" />
                                        <asp:ListItem Text="No" Value="0" />
                                    </asp:RadioButtonList>
                                 </div>
                                
                     
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">Otro?</label>
                                     <asp:RadioButtonList runat="server" ID="RadioButtonList15"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="1" />
                                        <asp:ListItem Text="No" Value="0" />
                                    </asp:RadioButtonList>
                                 </div>
                            </div>
                        </div>
                            <!------------------------------------------------------------------------------------------------------------------>

                        <hr/>
                        <div class="form-group">
                            <div class=" row">
                                <label class="control-label col-md-5">¿Tienen en esta vivienda</label>
                            </div>
                                    
                             <div class=" row">
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">teléfono celular?</label>
                                     <asp:RadioButtonList runat="server" ID="RadioButtonList16"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="1" />
                                        <asp:ListItem Text="No" Value="0" />
                                    </asp:RadioButtonList>
                                     <asp:TextBox runat="server" ID="tb_cantidad_telefonos" CssClass="col-md-7 right top form-control" ></asp:TextBox>
                                 </div>
                            
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">teléfono residencial?</label>
                                     <asp:RadioButtonList runat="server" ID="RadioButtonList17"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="1" />
                                        <asp:ListItem Text="No" Value="0" />
                                    </asp:RadioButtonList>
                                     <asp:TextBox runat="server" ID="TextBox4" CssClass="col-md-7 right top form-control" ></asp:TextBox>
                                 </div>
                                
                     
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">computadora portátil?</label>
                                     <asp:RadioButtonList runat="server" ID="RadioButtonList18"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="1" />
                                        <asp:ListItem Text="No" Value="0" />
                                    </asp:RadioButtonList>
                                     
                                     <asp:TextBox runat="server" ID="TextBox5" CssClass="col-md-7 right top form-control" ></asp:TextBox>
                                 </div>
                                
                            </div>
                            <div class=" row"><!---fila 2--->
                                <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">computadora escritorio?</label>
                                     <asp:RadioButtonList runat="server" ID="RadioButtonList19"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="1" />
                                        <asp:ListItem Text="No" Value="0" />
                                    </asp:RadioButtonList>
                                     <asp:TextBox runat="server" ID="TextBox6" CssClass="col-md-7 right top form-control" ></asp:TextBox>
                                 </div>
                            
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">tableta?</label>
                                     <asp:RadioButtonList runat="server" ID="RadioButtonList20"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="1" />
                                        <asp:ListItem Text="No" Value="0" />
                                    </asp:RadioButtonList>
                                     <asp:TextBox runat="server" ID="TextBox7" CssClass="col-md-7 right top form-control" ></asp:TextBox>
                                 </div>
                                
                     
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">fax (no de computadora)?</label>
                                     <asp:RadioButtonList runat="server" ID="RadioButtonList21"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="1" />
                                        <asp:ListItem Text="No" Value="0" />
                                    </asp:RadioButtonList>
                                     
                                     <asp:TextBox runat="server" ID="TextBox8" CssClass="col-md-7 right top form-control" ></asp:TextBox>
                                 </div>
                            </div>
                            <div class=" row"><!---fila 3--->
                                <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">radio o equipo de sonido?</label>
                                     <asp:RadioButtonList runat="server" ID="RadioButtonList22"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="1" />
                                        <asp:ListItem Text="No" Value="0" />
                                    </asp:RadioButtonList>
                                     <asp:TextBox runat="server" ID="TextBox9" CssClass="col-md-7 right top form-control" ></asp:TextBox>
                                 </div>
                            
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">carro (no de trabajo)?</label>
                                     <asp:RadioButtonList runat="server" ID="RadioButtonList23"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="1" />
                                        <asp:ListItem Text="No" Value="0" />
                                    </asp:RadioButtonList>
                                     <asp:TextBox runat="server" ID="TextBox10" CssClass="col-md-7 right top form-control" ></asp:TextBox>
                                 </div>
                                
                     
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">moto (no  de  trabajo)?</label>
                                     <asp:RadioButtonList runat="server" ID="RadioButtonList24"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="1" />
                                        <asp:ListItem Text="No" Value="0" />
                                    </asp:RadioButtonList>
                                     
                                     <asp:TextBox runat="server" ID="TextBox11" CssClass="col-md-7 right top form-control" ></asp:TextBox>
                                 </div>
                            </div>
                            <div class=" row"><!---fila 4--->
                                <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">televisor de plasma, LCD o LED?</label>
                                     <asp:RadioButtonList runat="server" ID="RadioButtonList25"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="1" />
                                        <asp:ListItem Text="No" Value="0" />
                                    </asp:RadioButtonList>
                                     <asp:TextBox runat="server" ID="ss" CssClass="col-md-7 right top form-control" ></asp:TextBox>
                                 </div>
                            
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">televisor convencional?</label>
                                     <asp:RadioButtonList runat="server" ID="RadioButtonList26"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="1" />
                                        <asp:ListItem Text="No" Value="0" />
                                    </asp:RadioButtonList>
                                     <asp:TextBox runat="server" ID="TextBox13" CssClass="col-md-7 right top form-control" ></asp:TextBox>
                                 </div>

                            </div>
                             <div class=" row"><!---fila 5--->
                                <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">refrigeradora?</label>
                                     <asp:RadioButtonList runat="server" ID="RadioButtonList27"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="1" />
                                        <asp:ListItem Text="No" Value="0" />
                                    </asp:RadioButtonList>
                                    
                                 </div>
                            
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">sistema de agua caliente?</label>
                                     <asp:RadioButtonList runat="server" ID="RadioButtonList28"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="1" />
                                        <asp:ListItem Text="No" Value="0" />
                                    </asp:RadioButtonList>
                                 </div>
                                
                     
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">tanque para almacenar agua?</label>
                                     <asp:RadioButtonList runat="server" ID="RadioButtonList29"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="1" />
                                        <asp:ListItem Text="No" Value="0" />
                                    </asp:RadioButtonList>
                                     
                                 </div>
                            </div>
                            <div class=" row"><!---fila 6--->
                                <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">televisión por cable?</label>
                                     <asp:RadioButtonList runat="server" ID="RadioButtonList30"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="1" />
                                        <asp:ListItem Text="No" Value="0" />
                                    </asp:RadioButtonList>
                                    
                                 </div>
                            
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">televisión por satélite?</label>
                                     <asp:RadioButtonList runat="server" ID="RadioButtonList31"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="1" />
                                        <asp:ListItem Text="No" Value="0" />
                                    </asp:RadioButtonList>
                                 </div>
                                
                     
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">otro tipo de tv paga?	</label>
                                     <asp:RadioButtonList runat="server" ID="RadioButtonList32"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="1" />
                                        <asp:ListItem Text="No" Value="0" />
                                    </asp:RadioButtonList>
                                     
                                 </div>
                            </div>
                             <div class=" row" runat="server" id="Div3">
                                <label class="control-label col-md-5">Especifique:</label>
                                 <asp:TextBox runat="server" ID="TextBox12"  CssClass="col-md-7 right top form-control" > </asp:TextBox>
                            </div><!-- especificar tipo de vivienda -->
                        </div>
                        <hr />
                            <!------------------------------------------------------------------------------------------------------------------>
                         <div class="form-group">
                             <div class=" row">
                                <label class="control-label col-md-5">¿En esta vivienda tienen internet?:</label>
                                 <asp:RadioButtonList runat="server" ID="rb_internet"  CssClass="col-md-7 right " AutoPostBack="True" >
                                    <asp:ListItem Text="Si" Value="1" />
                                    <asp:ListItem Text="No" Value="2" />
                                </asp:RadioButtonList>
                            </div><!--cielo razo -->
                            <hr />
                            <!------------------------------------------------------------------------------------------------------------------>
                            <div class="form-group">
                                 <div class=" row">
                                    <label class="control-label col-md-5">¿El tipo de conexión que usan para accesar internet es...:</label>
                                     <asp:RadioButtonList runat="server" ID="RadioButtonList33"  CssClass="col-md-7 right " AutoPostBack="True" >
                                        <asp:ListItem Text=".por teléfono fijo (KÖLBI- HOGAR)?" Value="1" />
                                        <asp:ListItem Text="por cable?" Value="2" />
                                        <asp:ListItem Text="por dispositivos móviles?" Value="3" />
                                        <asp:ListItem Text="Otro" Value="OTRO" />
                                   
                                    </asp:RadioButtonList>
                                </div><!-- tipo vivienda -->
                                <div class=" row" runat="server" id="Div4">
                                    <label class="control-label col-md-5">Cuanto pagaria por mensalidad:</label>
                                     <asp:TextBox runat="server" ID="TextBox14"  CssClass="col-md-7 right top form-control" > </asp:TextBox>
                                </div><!-- especificar tipo de vivienda -->
                            </div>
                                                         <hr />
                            <!------------------------------------------------------------------------------------------------------------------>
                            <div class="form-group">
                   
                                <div class=" row" runat="server" id="Div5">
                                    <label class="control-label col-md-5">¿Qué empresa da el servicio de internet?:</label>
                                     <asp:TextBox runat="server" ID="TextBox15"  CssClass="col-md-7 right top form-control" > </asp:TextBox>
                                </div><!-- especificar tipo de vivienda -->
                            </div>
                               <!------------------------------------------------------------------------------------------------------------------>
                             <hr />
                            <!------------------------------------------------------------------------------------------------------------------>
                         <div class="form-group">
                             <div class=" row">
                                <label class="control-label col-md-5"> ¿Tiene router inalámbrico?:</label>
                                 <asp:RadioButtonList runat="server" ID="RadioButtonList34"  CssClass="col-md-7 right " >
                                    <asp:ListItem Text="Si" Value="1" />
                                    <asp:ListItem Text="No" Value="2" />
                                </asp:RadioButtonList>
                            </div><!--cielo razo -->
                            <hr />
                        </div>
                </div>
            </div>
          
        </div>

             <!--------------------------------------------------------xxxxxxxx-------------------------------------------------->
        </div><!--  contenedor principal-->
    </form>
</body>
</html>
