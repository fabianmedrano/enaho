<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="principalpersonas.aspx.cs" Inherits="ENAHO.principalpersonas" %>

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
                                <asp:DropDownList runat="server" ID="ddl_parentesco"  CssClass=" right top form-control   DDL col-md-5" ></asp:DropDownList>
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
                        </div>
                            <!---- cierre seccion de salto otro lugar y no habitual--------->
             
                      
                    
                </div><!--  panel body  -->
                <div class="panel-footer" >
                    <asp:Button runat="server" Text="Siguiente" CssClass=" btn btn-primary "
                        />
                </div>
            </div>
            <!------------------------------------------------------------------------------------------------------------------>
          
        </div><!--  contenedor principal-->
    </form>
</body>
</html>
