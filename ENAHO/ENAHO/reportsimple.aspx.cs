using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data;

namespace ENAHO
{
    public partial class reportsimple : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack == false)
            {
                Panel7.Visible = false;
                Panel8.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
            Panel5.Visible = false;
            Panel6.Visible = false;

            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(Server.MapPath("~/ReportesSinParametros/No_personas.rpt"));

            CrystalReportViewer1.ReportSource = cryRpt;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
            Panel3.Visible = false;
            Panel4.Visible = false;
            Panel5.Visible = false;
            Panel6.Visible = false;
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(Server.MapPath("~/ReportesSinParametros/No_canton.rpt"));
            CrystalReportViewer2.ReportSource = cryRpt;
           
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = true;
            Panel4.Visible = false;
            Panel5.Visible = false;
            Panel6.Visible = false;
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(Server.MapPath("~/ReportesSinParametros/Personas.rpt"));
            CrystalReportViewer3.ReportSource = cryRpt;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = true;
            Panel5.Visible = false;
            Panel6.Visible = false;
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(Server.MapPath("~/ReportesSinParametros/Registros_provincia.rpt"));
            CrystalReportViewer4.ReportSource = cryRpt;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
            Panel5.Visible = true;
            Panel6.Visible = false;
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(Server.MapPath("~/ReportesSinParametros/despues9.rpt"));
            CrystalReportViewer5.ReportSource = cryRpt;
        }
        



        protected void Button6_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
            Panel5.Visible = false;
            Panel6.Visible = true;
            ReportDocument cryRpt = new ReportDocument();

            cryRpt.Load(Server.MapPath("~/ReportesSinParametros/viviendas_persona.rpt"));
            CrystalReportViewer6.ReportSource = cryRpt;
        }




        protected void Button7_Click(object sender, EventArgs e)
        {
            Panel7.Visible = true;
            Panel8.Visible = false;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Panel7.Visible = false;
            Panel8.Visible = true;
        }
        protected void Button9_Click(object sender, EventArgs e)
        {
            Panel9.Visible = true;
            Panel10.Visible = false;
            Panel11.Visible = false;
            Panel12.Visible = false;
            Panel13.Visible = false;


            ReportDocument cryRpt = new ReportDocument();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;
            cryRpt.Load(Server.MapPath("~/ReportesconParametros/filtrofuncionario.rpt"));
            cryRpt.SetParameterValue("@id", 1);
            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "EncuestaHogares";
            crConnectionInfo.UserID = "sa";
            crConnectionInfo.Password = "123";
            CrTables = cryRpt.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }
            CrystalReportViewer7.ReportSource = cryRpt;
            CrystalReportViewer7.RefreshReport();
            /*
                        ReportDocument reportDocument = new ReportDocument();
                        ParameterField paramField = new ParameterField();
                        ParameterFields paramFields = new ParameterFields();
                        ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

                        //Set instances for input parameter 1 -  @CustomerID
                        paramField.Name = "@id";

                        /*  if (ddlCustomer.SelectedValue == "All")
                              paramDiscreteValue.Value = string.Empty;
                          else
                        paramDiscreteValue.Value = 1;
                        paramField.CurrentValues.Add(paramDiscreteValue);
                        paramFields.Add(paramField);

                        paramFields.Add(paramField);

                        CrystalReportViewer1.ParameterFieldInfo = paramFields;


                        reportDocument.Load(Server.MapPath("~/ReportesconParametros/filtrofuncionario.rpt"));
                        CrystalReportViewer7.ReportSource = reportDocument;



                        */
        }
        protected void Button10_Click(object sender, EventArgs e)
        {
            Panel9.Visible = false;
            Panel10.Visible = true;
            Panel11.Visible = false;
            Panel12.Visible = false;
            Panel13.Visible = false;

            //Instantiate variables
            ReportDocument reportDocument = new ReportDocument();
            ParameterField paramField = new ParameterField();
            ParameterFields paramFields = new ParameterFields();
            ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

            //Set instances for input parameter 1 -  @CustomerID
            paramField.Name = "@id";

            /*  if (ddlCustomer.SelectedValue == "All")
                  paramDiscreteValue.Value = string.Empty;
              else*/
            //paramDiscreteValue.Value = ddlCustomer.SelectedValue;
            paramDiscreteValue.Value =1;
            paramField.CurrentValues.Add(paramDiscreteValue);
            paramFields.Add(paramField);

            //Add the paramField to paramFields
            paramFields.Add(paramField);

            CrystalReportViewer1.ParameterFieldInfo = paramFields;

  
            reportDocument.Load(Server.MapPath("~/ReportesconParametros/filtrofuncionario.rpt"));
            CrystalReportViewer8.ReportSource = reportDocument;

        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Panel9.Visible = false;
            Panel10.Visible = false;
            Panel11.Visible = true;
            Panel12.Visible = false;
            Panel13.Visible = false;
            ReportDocument reportDocument = new ReportDocument();
            ParameterField paramField = new ParameterField();
            ParameterFields paramFields = new ParameterFields();
            ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

            //Set instances for input parameter 1 -  @CustomerID
            paramField.Name = "@id";

            /*  if (ddlCustomer.SelectedValue == "All")
                  paramDiscreteValue.Value = string.Empty;
              else*/
            //paramDiscreteValue.Value = ddlCustomer.SelectedValue;
            paramDiscreteValue.Value = 1;
            paramField.CurrentValues.Add(paramDiscreteValue);
            paramFields.Add(paramField);

            //Add the paramField to paramFields
            paramFields.Add(paramField);

            CrystalReportViewer1.ParameterFieldInfo = paramFields;


            reportDocument.Load(Server.MapPath("~/ReportesconParametros/filtrofuncionario.rpt"));
            CrystalReportViewer9.ReportSource = reportDocument;
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            Panel9.Visible = false;
            Panel10.Visible = false;
            Panel11.Visible = false;
            Panel12.Visible = true;
            Panel13.Visible = false;

            ReportDocument reportDocument = new ReportDocument();
            ParameterField paramField = new ParameterField();
            ParameterFields paramFields = new ParameterFields();
            ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

            //Set instances for input parameter 1 -  @CustomerID
            paramField.Name = "@id";

            /*  if (ddlCustomer.SelectedValue == "All")
                  paramDiscreteValue.Value = string.Empty;
              else*/
            //paramDiscreteValue.Value = ddlCustomer.SelectedValue;
            paramDiscreteValue.Value = 1;
            paramField.CurrentValues.Add(paramDiscreteValue);
            paramFields.Add(paramField);

            //Add the paramField to paramFields
            paramFields.Add(paramField);

            CrystalReportViewer1.ParameterFieldInfo = paramFields;


            reportDocument.Load(Server.MapPath("~/ReportesconParametros/filtrofuncionario.rpt"));
            CrystalReportViewer10.ReportSource = reportDocument;
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            Panel9.Visible = false;
            Panel10.Visible = false;
            Panel11.Visible = false;
            Panel12.Visible = false;
            Panel13.Visible = true;

            ReportDocument reportDocument = new ReportDocument();
            ParameterField paramField = new ParameterField();
            ParameterFields paramFields = new ParameterFields();
            ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

            //Set instances for input parameter 1 -  @CustomerID
            paramField.Name = "@id";

            /*  if (ddlCustomer.SelectedValue == "All")
                  paramDiscreteValue.Value = string.Empty;
              else*/
            //paramDiscreteValue.Value = ddlCustomer.SelectedValue;
            paramDiscreteValue.Value = 1;
            paramField.CurrentValues.Add(paramDiscreteValue);
            paramFields.Add(paramField);

            //Add the paramField to paramFields
            paramFields.Add(paramField);

            CrystalReportViewer1.ParameterFieldInfo = paramFields;


            reportDocument.Load(Server.MapPath("~/ReportesconParametros/filtrofuncionario.rpt"));
            CrystalReportViewer11.ReportSource = reportDocument;
        }
    }
}