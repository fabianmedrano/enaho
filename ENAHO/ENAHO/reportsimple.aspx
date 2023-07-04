<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reportsimple.aspx.cs" Inherits="ENAHO.reportsimple" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <asp:Button ID="Button7" runat="server" Text="Sin parametros" OnClick="Button7_Click" />
            <asp:Button ID="Button8" runat="server" Text="Con parametros" OnClick="Button8_Click" />
 
        </div>

        <asp:Panel ID="Panel7" runat="server">


                <div>
                    <asp:Button ID="Button1" runat="server" Text="No personas" OnClick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" Text="No canton" OnClick="Button2_Click" />
                    <asp:Button ID="Button3" runat="server" Text="Personas" OnClick="Button3_Click" />
                    <asp:Button ID="Button4" runat="server" Text="Registros Provincias" OnClick="Button4_Click" />
                    <asp:Button ID="Button5" runat="server" Text="despues 9" OnClick="Button5_Click" />
                    <asp:Button ID="Button6" runat="server" Text="Por funcionarios" OnClick="Button6_Click" />


                </div>

                <asp:Panel ID="Panel1" runat="server">
                    <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" />
                </asp:Panel>

                <asp:Panel ID="Panel2" runat="server">
                    <CR:CrystalReportViewer ID="CrystalReportViewer2" runat="server" AutoDataBind="true"  />
                </asp:Panel>

                <asp:Panel ID="Panel3" runat="server">
            
                    <CR:CrystalReportViewer ID="CrystalReportViewer3" runat="server" AutoDataBind="true" />
                </asp:Panel>

                <asp:Panel ID="Panel4" runat="server">
            
                    <CR:CrystalReportViewer ID="CrystalReportViewer4" runat="server" AutoDataBind="true"  />
                </asp:Panel>

                <asp:Panel ID="Panel5" runat="server">
                    <CR:CrystalReportViewer ID="CrystalReportViewer5" runat="server" AutoDataBind="true"  />
                </asp:Panel>

                <asp:Panel ID="Panel6" runat="server">
                    <CR:CrystalReportViewer ID="CrystalReportViewer6" runat="server" AutoDataBind="true"  />
                </asp:Panel>
            </asp:Panel>





            <asp:Panel ID="Panel8" runat="server">


                <div>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:Button ID="Button9" runat="server" Text="ver fechas" OnClick="Button9_Click" />
                    <asp:Button ID="Button10" runat="server" Text="Funcionalrio" OnClick="Button10_Click"  />
                    <asp:Button ID="Button11" runat="server" Text="Personas" OnClick="Button11_Click"  />
                    <asp:Button ID="Button12" runat="server" Text="Registros Provincias" OnClick="Button12_Click"  />
                    <asp:Button ID="Button13" runat="server" Text="despues 9" OnClick="Button13_Click"  />


                </div>

                <asp:Panel ID="Panel9" runat="server">
                    <CR:CrystalReportViewer ID="CrystalReportViewer7" runat="server" AutoDataBind="true" />
                </asp:Panel>

                <asp:Panel ID="Panel10" runat="server">
                    <CR:CrystalReportViewer ID="CrystalReportViewer8" runat="server" AutoDataBind="true"  />
                </asp:Panel>

                <asp:Panel ID="Panel11" runat="server">
            
                    <CR:CrystalReportViewer ID="CrystalReportViewer9" runat="server" AutoDataBind="true" />
                </asp:Panel>

                <asp:Panel ID="Panel12" runat="server">
            
                    <CR:CrystalReportViewer ID="CrystalReportViewer10" runat="server" AutoDataBind="true"  />
                </asp:Panel>

                <asp:Panel ID="Panel13" runat="server">
                    <CR:CrystalReportViewer ID="CrystalReportViewer11" runat="server" AutoDataBind="true"  />
                </asp:Panel>

            </asp:Panel>
    </form>
</body>
</html>
