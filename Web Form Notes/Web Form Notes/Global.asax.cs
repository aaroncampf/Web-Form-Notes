using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Learn_Web_Forms {
  public class Global : HttpApplication {
    void Application_Start(object sender, EventArgs e) {

      RouteTable.Routes.MapPageRoute("", "About", "~/Views/About.aspx");
      RouteTable.Routes.MapPageRoute("", "Contact/{id}", "~/Views/Contact.aspx");
      RouteTable.Routes.MapPageRoute("", "Companies", "~/Views/Companies.aspx");
      RouteTable.Routes.MapPageRoute("", "Company/{id}", "~/Views/Company.aspx");
      RouteTable.Routes.MapPageRoute("", "Contacts", "~/Views/Contacts.aspx");
      RouteTable.Routes.MapPageRoute("", "Note/{id}", "~/Views/Note.aspx");

      // Code that runs on application startup
      RouteConfig.RegisterRoutes(RouteTable.Routes);
      BundleConfig.RegisterBundles(BundleTable.Bundles);
    }
  }
}