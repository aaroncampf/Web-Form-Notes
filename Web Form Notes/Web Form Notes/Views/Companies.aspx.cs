using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Learn_Web_Forms.Views {
  public partial class Companies : Page {
    private Database.Database db = new Database.Database();

    protected void Page_Load(object sender, EventArgs e) {
    }

    protected void btnQuotes_OnClick(object sender, EventArgs e) {
      //Response.Redirect($"/Company?id={}");
    }

    protected void btnAdd_Click(object sender, EventArgs e) {
      var Company = new Database.Company();
      db.Companies.Add(Company);
      db.SaveChanges();
      Response.Redirect($"/Company/{Company.ID}", false);
    }
  }
}