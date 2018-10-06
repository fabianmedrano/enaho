<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menu.aspx.cs" Inherits="ENAHO.menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/menu.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <!--
        <nav class="navbar navbar-inverse">
          <div class="container-fluid">
               <div class="navbar-text"><label id="Label1" runat="server">Cerrar Sesion</label></div>

              <div class="navbar-text"><label id="usuario" runat="server"></label></div>
         

               <span aria-hidden="true" class="glyphicon glyphicon-"></span>
              
          
          </div>
        </nav> 
        -->
        <div class="container col-md-7">
                <div class="row">
                    <div class="col-md-4">
                        <div class="panel panel-default">
                            <!-- user--->
                            <asp:LinkButton runat="server" CssClass="opciones " OnClick="Unnamed1_Click" >
                                <div class="contenedor-opciones">
                                    <div class="row ">
                                        <span aria-hidden="true" class="glyphicon glyphicon-user"></span>
                                    </div>
                                    <div class="row">
                                        Usuarios
                                    </div>
                                </div>
                            </asp:LinkButton>
                            <!----------->
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="panel panel-default">
                            <!-- hogares--->
                            <asp:LinkButton runat="server" CssClass="opciones "  OnClick="Unnamed2_Click">
                                <div class="contenedor-opciones">
                                    <div class="row ">
                                        <span aria-hidden="true" class="glyphicon glyphicon-home"></span>
                                    </div>
                                    <div class="row">
                                        Hogares
                                    </div>
                                </div>
                            </asp:LinkButton>
                            <!----------->
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="panel panel-default">
                             <!-- reportes--->
                            <asp:LinkButton runat="server" CssClass="opciones " OnClick="Unnamed3_Click" >
                                <div class="contenedor-opciones">
                                    <div class="row ">
                                        <span aria-hidden="true" class="glyphicon glyphicon-book"></span>
                                    </div>
                                    <div class="row">
                                        Reportes
                                    </div>
                                </div>
                            </asp:LinkButton>
                            <!----------->
                        </div>
                    </div>
                </div>

            
        </div><!--  contenedor  --->

     
    </form>
</body>
</html>
