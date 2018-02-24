using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Variables_de_Aplicación
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
        protected void Application_Start(Object sender, EventArgs e)
        {
            Application["localidad"] = "San Justo"; 
        
            Application["universidad"] = "UNLAM"; 
}

    }
}
