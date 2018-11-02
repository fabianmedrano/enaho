using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace ENAHO
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {

            Application["idVivienda"] = 0 ;
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        void Session_Start(object sender, EventArgs e)
        {
            Session["Login"] =  new Usuario();
           
        }
    }
}