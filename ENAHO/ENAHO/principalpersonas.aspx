<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="principalpersonas.aspx.cs" Inherits="ENAHO.principalpersonas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/principal.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <link href="Content/principal.css" rel="stylesheet" />
    <link href="Content/nav.css" rel="stylesheet" />
    <script src="Scripts/nav.js"></script>
    <title>ENAHO</title>
</head>
<body>
       <form id="form" runat="server">

           <div id="sidebar-wrapper">
            <nav id="spy">
                <ul class="sidebar-nav nav">
                    <li class="sidebar-brand">
                        <a href="principalhogares.aspx"><span class="fa fa-home solo">Home</span></a>
                    </li>
                    <li class="">
                       
                            <a href="#" data-toggle="modal" data-target="#Modalpersonas">Lista Hogares</a>
                        
                    </li>
                    <li class="active">
                            <a href="principalpersonas.aspx">Nuevo Hogar</a>
                    </li>

                </ul>
            </nav>
        </div>

        <div class="col-md-7 center-block ">
          <div class="panel panel-default  "><!-- VIV3 -->
                <div class="panel-body">
                    <div class=" page-header">Persona miembro del hogar</div>
                    <div class="col-md-12 left">
                        <div class="form-group">

                            <div class=" row">
                                <label class="control-label col-md-5">Nombre:</label>
                                <asp:TextBox runat="server" ID="tb_nombre"  CssClass="col-md-7 right top form-control "></asp:TextBox>
                            </div>
                             <div class=" row">
                                <label class="control-label col-md-5">vive aquí hace más de 6 meses?:</label>
                                 <asp:RadioButtonList runat="server" ID="rb_mas_6_meses_viviendo"  CssClass="col-md-7 right">
                                    <asp:ListItem Text="Si" Value="true" />
                                    <asp:ListItem Text="No" Value="false" />
                                </asp:RadioButtonList>
                            </div>
                              <div class=" row">
                                <label class="control-label col-md-5">¿Piensa quedarse viviendo aquí?:</label>
                                 <asp:RadioButtonList runat="server" ID="rb_continuara_viviendo"  CssClass="col-md-7 right ">
                                    <asp:ListItem Text="Si" Value="true" />
                                    <asp:ListItem Text="No" Value="false" />
                                </asp:RadioButtonList>
                            </div>
                            <!------------ si no es habitual  y tiene otro lugar donde vivir hasta la pregunta A 23   ------------------>

                            <!----seccion de salto otro lugar y no habitual--------->
                               
                            <div class=" row  seccion_no_habirual_otro_lugar">
                                <label class="control-label col-md-5 left">¿Cuál es el parentesco  con la persona jefe del hogar?:</label>
                                <asp:DropDownList runat="server" ID="ddl_parentesco"  CssClass=" right top form-control   DDL col-md-5" >
                                    <asp:ListItem Text=" Jefa o jefe" Value="1" />

                                    <asp:ListItem Text="Esposo(a) ocompañero(a)" Value="2" />
                                    <asp:ListItem Text="Hijo(a)" Value="3" />
                                    <asp:ListItem Text="Hijastro(a)" Value="4" />
                                    <asp:ListItem Text="Yerno o nuera" Value="5" />
                                    <asp:ListItem Text="Nieto(a)" Value="6" />
                                    <asp:ListItem Text="Padre, madre" Value="7" />
                                    <asp:ListItem Text="Suegro(a)" Value="8" />
                                    <asp:ListItem Text="Hermano(a)" Value="9" />
                                    <asp:ListItem Text="Cuñado(a)" Value="10" />
                                    <asp:ListItem Text="Otro familiar" Value="11" />
                                    <asp:ListItem Text="Otro no familiar" Value="12" />
                                    <asp:ListItem Text="Servicio domésticoo su familiar" Value="13" />
                                    <asp:ListItem Text="Pensionista o su familiar(inquilino)" Value="14" />
                                </asp:DropDownList>
                               
                            </div>


                        </div>
                        <!------- form group---------->
                        <div class="form-group">
                            <div class=" row">
                             <label class="control-label col-md-5">Sexo:</label>
                                 <asp:RadioButtonList runat="server" ID="rb_sexo"  CssClass="col-md-7 right ">
                                    <asp:ListItem Text="Hombre" Value="true" />
                                    <asp:ListItem Text="Mujer" Value="false" />
                                </asp:RadioButtonList>
                            </div>

                           <div class=" row">
                                <label class="control-label col-md-5">¿Cuántos años cumplidos tiene :</label>
                                <asp:TextBox runat="server" ID="tb_años_cumplidos"  CssClass="col-md-7 right top form-control "></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class ="row"> <label class=" control-label " >lugar de nacimienrto</label></div>
                           
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

                                <div class=" row">
                                    <label class="control-label col-md-5">Estado conyugal:</label>
                                    <asp:DropDownList runat="server" ID="ddl_estadoConyugal"  CssClass=" right top form-control   DDL col-md-5" >
                                        <asp:ListItem Text="En unión libre o Juntado(a)" Value="1" />
                                        <asp:ListItem Text="Casado (a)" Value="2" />
                                        <asp:ListItem Text="Divorciado(a)" Value="3" />
                                        <asp:ListItem Text="Separado(a)" Value="4" />
                                        <asp:ListItem Text="Viudo(a)" Value="5" />
                                        <asp:ListItem Text="Soltero(a)" Value="6" />
                                        <asp:ListItem Text="Menor de 10 años" Value="7" />
                                    </asp:DropDownList>
                                </div>
                            <div class=" row">
                                    <label class="control-label col-md-5">¿Qué tipo de Seguro Social, tiene?:</label>
                                    <asp:DropDownList runat="server" ID="ddl_tipo_seguro"  CssClass=" right top form-control   DDL col-md-5" >
                                        <asp:ListItem Text="Asalariado" Value="1" />
                                        <asp:ListItem Text="Mediante convenio,(asociaciones, sindicatos cooperativas,etc)" Value="2" />
                                      <asp:ListItem Text="Voluntario" Value="13" />
                                        <asp:ListItem Text="Trabajador independiente" Value="14" />
                                        <asp:ListItem Text="Por el Estado (Incluye al familiar de asegura por el Estado)" Value="4" />
                                        <asp:ListItem Text="Familiar de aseguradodirecto (asalariado, mediante convenio, voluntario)" Value="5" />
                                        <asp:ListItem Text="Pensionado del régimenno contributivo monto básico" Value="6" />
                                        <asp:ListItem Text="Pensionado del régimen no contributivo de Gracia o Guerra" Value="7" />

                                        <asp:ListItem Text="Pensionado del régimen de IVM de la CCSS" Value="8" />
                                        <asp:ListItem Text="Pensionado del régimen del Magisterio, Poder Judicial, Hacienda, otro" Value="9" />
                                        <asp:ListItem Text="Familiar de pensionado" Value="10" />
                                        <asp:ListItem Text="Otras formas (seguro de estudiante, de refugiado y otros)" Value="11" />
                                        <asp:ListItem Text="Seguro privado o del extranjero" Value="12" />
                                        <asp:ListItem Text="No asegurado" Value="3" />
                                    </asp:DropDownList>
                            </div>
                           <!-- <div class=" row">
                                 <label class="control-label col-md-5"> presenta alguna limitación que le dificulte o impida permanentemente:</label>
                                <asp:CheckBoxList ID="CheckBoxList1" runat="server"   CssClass="col-md-7 right ">
                                    <asp:ListItem Text="ver aún con los anteojos o lentes puestos?" Value="1"></asp:ListItem>
                                     <asp:ListItem Text="oír?" Value="2"></asp:ListItem>
                                      <asp:ListItem Text="hablar?" Value="3"></asp:ListItem>
                                      <asp:ListItem Text="caminar o subir gradas?" Value="4"></asp:ListItem>
                                      <asp:ListItem Text="utilizar brazos y manos?" Value="5"></asp:ListItem>
                                      <asp:ListItem Text="de tipo intelectual? (retardo, Síndrome de Down, otros)" Value="6"></asp:ListItem>
                                     <asp:ListItem Text="de tipo mental? (bipolar, esquizofrenia, otros)?" Value="7"></asp:ListItem>
                                </asp:CheckBoxList>
                            </div>-->
                        </div>
                            <!---- cierre seccion de salto otro lugar y no habitual--------->
             
                      
                    
            </div><!--  panel body  -->
                <div class="panel-footer" >
                    <asp:Button runat="server" Text="Siguiente" CssClass=" btn btn-primary " OnClick="Unnamed1_Click"
                        />
                     <asp:Button runat="server" Text="Terminar" CssClass=" btn btn-primary left" OnClick="Unnamed2_Click" 
                        />
                    
                </div>
            </div>
            <!------------------------------------------------------------------------------------------------------------------>
          </div>
        </div>

                 <!-----------------MODAL-------------------->
       
        <div id="Modalpersonas" class="modal fade" role="dialog">
            <div class="modal-dialog">

                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">Hogares de Vivienda</h4>
                    </div>
                    <div class="modal-body">

                            <asp:GridView ID="gb_personas"  CssClass="table table-bordered" runat="server">
                            </asp:GridView>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class=" btn btn-primary" data-dismiss="modal">Close</button>
                    </div>
                </div>
           </div>
        </div>

    </form>
</body>
</html>
