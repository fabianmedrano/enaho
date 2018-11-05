<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="principalvivienda.aspx.cs" Inherits="ENAHO.principal" MaintainScrollPositionOnPostback="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/jquery.mask.min.js"></script>
    <script src="Scripts/principal.js"></script>
    <script src="Scripts/mascaras.js"></script>
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
                             <!--   <div class=" row">
                                    <label class="control-label col-md-3">Region:</label>
                                    <asp:TextBox runat="server" ID="tb_region"  CssClass="col-md-7 right top form-control"></asp:TextBox>
                                </div><!-- Region-->
                               
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
                                    <asp:TextBox runat="server" ID="tb_direccion"  CssClass="col-md-7 right top form-control alfanumerico"></asp:TextBox>
                                </div><!-- direccion-->
                                <div class=" row">
                                    <label class="control-label col-md-3">Telefono:</label>
                                    <asp:TextBox runat="server" ID="tb_telefono"  CssClass="col-md-7 right top form-control telefono "></asp:TextBox>
                                </div><!-- telefono-->
                                <div class=" row">
                                    <label class="control-label col-md-12"> 
                                        ¿Se aplica en esta vivienda el Módulo de Gasto de Consumo de los Hogares?:

                                    </label>
                                    <asp:RadioButtonList runat="server" ID="rb_mgch"  CssClass="col-md-7 right  radio" >
                                        <asp:ListItem Text="Si" Value="true" />
                                        <asp:ListItem Text="No" Value="false" />
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
                                <asp:TextBox runat="server" ID="tb_cantidad_personas_vivienda"  CssClass="col-md-7 right top form-control numero"></asp:TextBox>
                            </div><!-- numero de personas vivienda-->
                             <div class=" row">
                                <label class="control-label col-md-5">Comparten mismo presupuesto:</label>
                                 <asp:RadioButtonList runat="server" ID="rb_mismo_prespuesto"  CssClass="col-md-7 right " AutoPostBack="True">
                                    <asp:ListItem Text="Si" Value="true" />
                                    <asp:ListItem Text="No" Value="false" />
                                </asp:RadioButtonList>
                            </div><!-- mismo presupuesto -->
                             <div class=" row" runat="server" id="row_numero_hogares_vivienda">
                                <label class="control-label col-md-5">Numero de hogares en la vivienda:</label>
                                 <asp:TextBox runat="server" ID="tb_numero_hogares_vivienda"  CssClass="col-md-7 right top form-control numero" > </asp:TextBox>
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
                                    <asp:ListItem Text="Otra(cedida,prestada)" Value="OTRO" />
                                   
                                </asp:RadioButtonList>
                            </div><!-- tipo vivienda -->
                            <div class=" row" runat="server" id="row_pagaria_mesualidad">
                                <label class="control-label col-md-5">Cuanto pagaria por mensalidad:</label>
                                 <asp:TextBox runat="server" ID="tb_pagaria_mesualidad"  CssClass="col-md-7 right top form-control montos" > </asp:TextBox>
                            </div><!-- especificar tipo de vivienda -->
                               <div class=" row" runat="server" id="row_mensualidad">
                                <label class="control-label col-md-5">Mensualidad:</label>
                                 <asp:TextBox runat="server" ID="tb_mensualidad"  CssClass="col-md-7 right top form-control montos" > </asp:TextBox>
                            </div><!-- mensualidad -->
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
                                    <asp:ListItem Text="Material de desecho" Value="7" />
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
                                    <asp:ListItem Text="Material de desecho" Value="6" />
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
                                 <asp:RadioButtonList runat="server" ID="rb_cielo_raso"  CssClass="col-md-7 right " >
                                    <asp:ListItem Text="Si" Value="true" />
                                    <asp:ListItem Text="No" Value="false" />
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
                                    <asp:ListItem Text="Material de desecho" Value="5" />
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
                                 <asp:RadioButtonList runat="server" ID="rb_sobre_pilotes"  CssClass="col-md-7 right " >
                                    <asp:ListItem Text="Si" Value="true" />
                                    <asp:ListItem Text="No" Value="false" />
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
                                     <asp:RadioButtonList runat="server" ID="rb_estado_paredes"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="MALO" Value="1" />
                                        <asp:ListItem Text="REGULAR" Value="2" />
                                        <asp:ListItem Text="BUENO" Value="3" />
                                    </asp:RadioButtonList>
                                 </div>
                            
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">el techo?</label>
                                     <asp:RadioButtonList runat="server" ID="rb_estado_techo"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="MALO" Value="1" />
                                        <asp:ListItem Text="REGULAR" Value="2" />
                                        <asp:ListItem Text="BUENO" Value="3" />
                                    </asp:RadioButtonList>
                                 </div>
                                
                     
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">el piso?</label>
                                     <asp:RadioButtonList runat="server" ID="rb_estado_piso"  CssClass="col-md-4 right " >
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
                                 <asp:TextBox runat="server" ID="tb_cuartos_dormir"  CssClass="col-md-7 right top form-control" > </asp:TextBox>
                            </div><!-- especificar tipo de vivienda -->
                        </div>
                            <!------------------------------------------------------------------------------------------------------------------>

                        <hr/>
                        <div class="form-group">
                            <div class=" row" runat="server" id="Div2">
                                <label class="control-label col-md-13">Sin contar baños, cuarto de pilas, pasillos, garaje, ¿cuántos aposentos, en total (incluso Nº de cuartos) tiene esta vivienda?</label>
                                 <asp:TextBox runat="server" ID="tb_aposentos"  CssClass="col-md-7 right top form-control" > </asp:TextBox>
                            </div><!-- especificar tipo de vivienda -->
                        </div>
                            <!------------------------------------------------------------------------------------------------------------------>
                        <hr/>
                        <div class="form-group">
                             <div class=" row">
                                <label class="control-label col-md-5">Aproximadamente, ¿cuántos metros cuadrados de construcción tiene esta vivienda?:</label>
                                 <asp:RadioButtonList runat="server" ID="rb_cantidad_metros"  CssClass="col-md-7 right "  >
                                    <asp:ListItem Text="Menos de 30m2" Value="1" />
                                    <asp:ListItem Text="De 30 a 40 m2" Value="2" />
                                    <asp:ListItem Text="De 41 a 60 m2" Value="3" />
                                    <asp:ListItem Text="De 61 a 100m2" Value="4" />
                                    <asp:ListItem Text="De 101 a 150m2" Value="5" />
                                    <asp:ListItem Text="De 151 a 200m2 " Value="6" />
                                    <asp:ListItem Text="Más de 200m2" Value="7" />
                                   
                                </asp:RadioButtonList>
                            </div><!-- metros cuadrados -->
           
                        </div>
                            <!------------------------------------------------------------------------------------------------------------------>
                        <hr/>
                        <div class="form-group">
                             <div class=" row">
                                <label class="control-label col-md-5"> ¿Esta vivienda se abastece de agua por...:</label>
                                 <asp:RadioButtonList runat="server" ID="rb_abastecimiento_agua"  CssClass="col-md-7 right "  >
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
                                    <asp:ListItem Text="un río, quebrada o naciente?" Value="6" />
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
                                 <asp:RadioButtonList runat="server" ID="rb_servicio_sanitario_es"  CssClass="col-md-7 right " >
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
                                    <asp:ListItem Text="Si" Value="true" />
                                    <asp:ListItem Text="No" Value="false" />
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
                                 <asp:RadioButtonList runat="server" ID="rb_uso_bano"  CssClass="col-md-7 right "  >
                                    <asp:ListItem Text="sólo para esta vivienda?" Value="true" />
                                    <asp:ListItem Text="para esta y otras viviendas?" Value="false" />
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
                                     <asp:RadioButtonList runat="server" ID="rb_separacion_organica"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="true" />
                                        <asp:ListItem Text="No" Value="false" />
                                    </asp:RadioButtonList>
                                 </div>
                            
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">plástica?</label>
                                     <asp:RadioButtonList runat="server" ID="rb_separacion_plastico"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="true" />
                                        <asp:ListItem Text="No" Value="false" />
                                    </asp:RadioButtonList>
                                 </div>
                                
                     
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">de vidrio?</label>
                                     <asp:RadioButtonList runat="server" ID="rb_separacion_vidrio"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="true" />
                                        <asp:ListItem Text="No" Value="false" />
                                    </asp:RadioButtonList>
                                 </div>
                                
                            </div>
                            <div class=" row"><!---fila 2--->
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">de aluminio?</label>
                                     <asp:RadioButtonList runat="server" ID="rb_separacion_alminio"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="true" />
                                        <asp:ListItem Text="No" Value="false" />
                                    </asp:RadioButtonList>
                                 </div>
                            
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">de papel o cartón?	</label>
                                     <asp:RadioButtonList runat="server" ID="rb_separacion_papel"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="true" />
                                        <asp:ListItem Text="No" Value="false" />
                                    </asp:RadioButtonList>
                                 </div>
                                
                     
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">Otro?</label>
                                     <asp:RadioButtonList runat="server" ID="rb_separacion_otro"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="true" />
                                        <asp:ListItem Text="No" Value="false" />
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
                                     <asp:RadioButtonList runat="server" ID="rb_telefono_celular"  CssClass="col-md-4 right " AutoPostBack="true"  >
                                        <asp:ListItem Text="Si" Value="true" />
                                        <asp:ListItem Text="No" Value="false" />
                                    </asp:RadioButtonList>
                                     <asp:TextBox runat="server" ID="tb_cantidad_telefonos" CssClass="col-md-7 right top form-control" ></asp:TextBox>
                                 </div>
                            
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">teléfono residencial?</label>
                                     <asp:RadioButtonList runat="server" ID="rb_telefono_recidencia"  CssClass="col-md-4 right " AutoPostBack="true"  >
                                        <asp:ListItem Text="Si" Value="true" />
                                        <asp:ListItem Text="No" Value="false" />
                                    </asp:RadioButtonList>
                                     <asp:TextBox runat="server" ID="tb_telefono_recidencia_cantidad" CssClass="col-md-7 right top form-control" ></asp:TextBox>
                                 </div>
                                
                     
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">computadora portátil?</label>
                                     <asp:RadioButtonList runat="server" ID="rb_pc_portatil"  CssClass="col-md-4 right "  AutoPostBack="true" >
                                        <asp:ListItem Text="Si" Value="true" />
                                        <asp:ListItem Text="No" Value="false" />
                                    </asp:RadioButtonList>
                                     
                                     <asp:TextBox runat="server" ID="tb_pc_portatil_cantidad" CssClass="col-md-7 right top form-control" ></asp:TextBox>
                                 </div>
                                
                            </div>
                            <div class=" row"><!---fila 2--->
                                <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">computadora escritorio?</label>
                                     <asp:RadioButtonList runat="server" ID="rb_pc_escritorio"  CssClass="col-md-4 right "  AutoPostBack="true" >
                                        <asp:ListItem Text="Si" Value="true" />
                                        <asp:ListItem Text="No" Value="false" />
                                    </asp:RadioButtonList>
                                     <asp:TextBox runat="server" ID="tb_pc_escritorio_cantidad" CssClass="col-md-7 right top form-control" ></asp:TextBox>
                                 </div>
                            
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">tableta?</label>
                                     <asp:RadioButtonList runat="server" ID="rb_tableta"  CssClass="col-md-4 right "  AutoPostBack="true" >
                                        <asp:ListItem Text="Si" Value="true" />
                                        <asp:ListItem Text="No" Value="false" />
                                    </asp:RadioButtonList>
                                     <asp:TextBox runat="server" ID="tb_tableta_cantidad" CssClass="col-md-7 right top form-control" ></asp:TextBox>
                                 </div>
                                
                     
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">fax (no de computadora)?</label>
                                     <asp:RadioButtonList runat="server" ID="rb_fax"  CssClass="col-md-4 right "  AutoPostBack="true" >
                                        <asp:ListItem Text="Si" Value="true" />
                                        <asp:ListItem Text="No" Value="false" />
                                    </asp:RadioButtonList>
                                     
                                     <asp:TextBox runat="server" ID="tb_fax_cantidad" CssClass="col-md-7 right top form-control" ></asp:TextBox>
                                 </div>
                            </div>
                            <div class=" row"><!---fila 3--->
                                <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">radio o equipo de sonido?</label>
                                     <asp:RadioButtonList runat="server" ID="rb_radio"  CssClass="col-md-4 right "  AutoPostBack="true" >
                                        <asp:ListItem Text="Si" Value="true" />
                                        <asp:ListItem Text="No" Value="false" />
                                    </asp:RadioButtonList>
                                     <asp:TextBox runat="server" ID="tb_radio_cantidad" CssClass="col-md-7 right top form-control" ></asp:TextBox>
                                 </div>
                            
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">carro (no de trabajo)?</label>
                                     <asp:RadioButtonList runat="server" ID="rb_carro"  CssClass="col-md-4 right "  AutoPostBack="true" >
                                        <asp:ListItem Text="Si" Value="true" />
                                        <asp:ListItem Text="No" Value="false" />
                                    </asp:RadioButtonList>
                                     <asp:TextBox runat="server" ID="tb_carro_cantidad" CssClass="col-md-7 right top form-control" ></asp:TextBox>
                                 </div>
                                
                     
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">moto (no  de  trabajo)?</label>
                                     <asp:RadioButtonList runat="server" ID="rb_moto"  CssClass="col-md-4 right "  AutoPostBack="true" >
                                        <asp:ListItem Text="Si" Value="true" />
                                        <asp:ListItem Text="No" Value="false" />
                                    </asp:RadioButtonList>
                                     
                                     <asp:TextBox runat="server" ID="tb_moto_cantidad" CssClass="col-md-7 right top form-control" ></asp:TextBox>
                                 </div>
                            </div>
                            <div class=" row"><!---fila 4- por aq-->
                                <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">televisor de plasma, LCD o LED?</label>
                                     <asp:RadioButtonList runat="server" ID="rb_tv"  CssClass="col-md-4 right "   AutoPostBack="true">
                                        <asp:ListItem Text="Si" Value="true" />
                                        <asp:ListItem Text="No" Value="false" />
                                    </asp:RadioButtonList>
                                     <asp:TextBox runat="server" ID="tb_tv_cantidad" CssClass="col-md-7 right top form-control" ></asp:TextBox>
                                 </div>
                            
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">televisor convencional?</label>
                                     <asp:RadioButtonList runat="server" ID="rb_tv_convencional"  CssClass="col-md-4 right "  AutoPostBack="true" >
                                        <asp:ListItem Text="Si" Value="true" />
                                        <asp:ListItem Text="No" Value="false" />
                                    </asp:RadioButtonList>
                                     <asp:TextBox runat="server" ID="tb_tv_convencional_cantidad" CssClass="col-md-7 right top form-control" ></asp:TextBox>
                                 </div>

                            </div>
                             <div class=" row"><!---fila 5--->
                                <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">refrigeradora?</label>
                                     <asp:RadioButtonList runat="server" ID="rb_refrigeradora"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="true" />
                                        <asp:ListItem Text="No" Value="false" />
                                    </asp:RadioButtonList>
                                    
                                 </div>
                            
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">sistema de agua caliente?</label>
                                     <asp:RadioButtonList runat="server" ID="rb_agua_caliente"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="true" />
                                        <asp:ListItem Text="No" Value="false" />
                                    </asp:RadioButtonList>
                                 </div>
                                
                     
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">tanque para almacenar agua?</label>
                                     <asp:RadioButtonList runat="server" ID="rb_tanque_agua"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="true" />
                                        <asp:ListItem Text="No" Value="false" />
                                    </asp:RadioButtonList>
                                     
                                 </div>
                            </div>
                            <div class=" row"><!---fila 6--->
                                <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">televisión por cable?</label>
                                     <asp:RadioButtonList runat="server" ID="rb_televisor_cable"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="true" />
                                        <asp:ListItem Text="No" Value="false" />
                                    </asp:RadioButtonList>
                                    
                                 </div>
                            
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">televisión por satélite?</label>
                                     <asp:RadioButtonList runat="server" ID="rb_satelital"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="true" />
                                        <asp:ListItem Text="No" Value="false" />
                                    </asp:RadioButtonList>
                                 </div>
                                
                     
                                 <div class="col-md-4 box">
                                     <label class="control-label col-md-7 ">otro tipo de tv paga?	</label>
                                     <asp:RadioButtonList runat="server" ID="rb_otro_tipo_paga"  CssClass="col-md-4 right "  >
                                        <asp:ListItem Text="Si" Value="true" />
                                        <asp:ListItem Text="No" Value="false" />
                                    </asp:RadioButtonList>
                                     
                                 </div>
                            </div>
                             <div class=" row" runat="server" id="row_otro_tv_paga">
                                <label class="control-label col-md-5">Especifique:</label>
                                 <asp:TextBox runat="server" ID="tb_otro_tv_paga"  CssClass="col-md-7 right top form-control" > </asp:TextBox>
                            </div><!-- especificar tipo de vivienda -->
                        </div>
                        <hr />
                            <!------------------------------------------------------------------------------------------------------------------>
                         <div class="form-group">
                             <div class=" row">
                                <label class="control-label col-md-5">¿En esta vivienda tienen internet?:</label>
                                 <asp:RadioButtonList runat="server" ID="rb_internet"  CssClass="col-md-7 right "  AutoPostBack="true">
                                    <asp:ListItem Text="Si" Value="true" />
                                    <asp:ListItem Text="No" Value="false" />
                                </asp:RadioButtonList>
                            </div><!--cielo razo -->
                            
                            <!------------------------------------------------------------------------------------------------------------------>
                            <div class="form-group" id="seccion_tipo_coneccion">
                                <hr />
                                 <div class=" row">
                                    <label class="control-label col-md-5">¿El tipo de conexión que usan para accesar internet es...:</label>
                                     <asp:RadioButtonList runat="server" ID="rb_tipo_coneccion"  CssClass="col-md-7 right " AutoPostBack="True" >
                                        <asp:ListItem Text="por teléfono fijo (KÖLBI- HOGAR)?" Value="1" />
                                        <asp:ListItem Text="por cable?" Value="2" />
                                        <asp:ListItem Text="por dispositivos móviles?" Value="3" />
                                        <asp:ListItem Text="Otro" Value="OTRO" />
                                   
                                    </asp:RadioButtonList>
                                </div><!-- tipo vivienda -->
                                <div class=" row" runat="server" id="row_tipo_coneccion">
                                    <label class="control-label col-md-5">especifique:</label>
                                     <asp:TextBox runat="server" ID="tb_otro_tipo_coneccion"  CssClass="col-md-7 right top form-control" > </asp:TextBox>
                                </div><!-- especificar tipo de vivienda -->
                            </div>
                                                         
                            <!------------------------------------------------------------------------------------------------------------------>
                            <div class="form-group" id="seccion_empresa_internet">
                            <hr />
                                <div class=" row" runat="server" id="Div5">
                                    <label class="control-label col-md-5">¿Qué empresa da el servicio de internet?:</label>
                                     <asp:TextBox runat="server" ID="tb_empresa_internet"  CssClass="col-md-7 right top form-control" > </asp:TextBox>
                                </div><!-- especificar tipo de vivienda -->
                            </div>
                               <!------------------------------------------------------------------------------------------------------------------>
                             
                            <!------------------------------------------------------------------------------------------------------------------>
                         <div class="form-group" id="seccion_router">
                             <hr />
                             <div class=" row">
                                <label class="control-label col-md-5"> ¿Tiene router inalámbrico?:</label>
                                 <asp:RadioButtonList runat="server" ID="rb_router"  CssClass="col-md-7 right " >
                                    <asp:ListItem Text="Si" Value="true" />
                                    <asp:ListItem Text="No" Value="false" />
                                </asp:RadioButtonList>
                            </div><!--cielo razo -->
                            <hr />
                        </div>


                </div>
            </div>
            </div><!--  panel body-->
                <div class="panel-footer" >
                    <asp:Button runat="server" Text="Guardar" CssClass=" btn btn-primary" OnClick="btn_Guardar_vivienda" />
                </div>

             <!--------------------------------------------------------xxxxxxxx-------------------------------------------------->
        </div><!--  contenedor principal-->
        </div>
    </form>
</body>
</html>

