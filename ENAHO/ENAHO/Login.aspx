<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ENAHO.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/login.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/login.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       
        <div class="col-md-3 center-block ">
            <div class="panel panel-default  ">
                <div class="panel-heading text-center">
                    Inicio De Seccion
                </div>
                <div class="panel-body">
                        <div class="form-group">
                            <div class="row" >
                                <label class="control-label">Usuario</label>
                            </div>
                            <div class=" row">
                                <asp:TextBox runat="server" ID="tb_usuario"  CssClass="top form-control"></asp:TextBox>
                            </div>
                               
                            <div class=" row">
                                <label class="control-label ">Contraseña</label>
                            </div>
                            <div class="row">
                                <asp:TextBox runat="server" ID="tb_pass"   CssClass="top form-control"></asp:TextBox>
                            </div>
                            <div class="row">
                                <asp:Button ID="bt_login" runat="server" Text="Entrar" CssClass="btn btn-primary  btn-block" OnClick="bt_login_Click" OnClientClick="btn_entrar" />
                            </div>
                            <div class="row mensaje">
                                <asp:Label ID="l_login" runat="server" CssClass="alert alert-danger text-center ">Datos incorrectos</asp:Label>
                                
                            </div>                          
                        </div>
                    </div>
            </div>
        </div>
    </form>
</body>
</html>
