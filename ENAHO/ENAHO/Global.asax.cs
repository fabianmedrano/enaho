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

            Application["idVivienda"] = 0+"" ;
            Application["idhogar"] = 0 + "";
            Application["vivienda"] = new Vivienda();
            Application["hogar"] = new Hogar();
            // List<Hogar> hogares = new List<Hogar>();
            Application["PersonasHogar"] = new List<Persona>();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        void Session_Start(object sender, EventArgs e)
        {
            Session["Login"] =  new Usuario();
           
        }
    }
}