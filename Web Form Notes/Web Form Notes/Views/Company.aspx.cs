using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Learn_Web_Forms.Views {
  public partial class Company : System.Web.UI.Page {
    Database.Database db = new Database.Database();
    Database.Company company = null; //TODO Add Error handling for when no company is found


    protected void Page_Load(object sender, EventArgs e) {
      int ID;
      if (int.TryParse(Request.QueryString["id"], out ID)) {
        company = db.Companies.Find(ID);
      }

      txtName.
      //txtName.Text = company.Name;
    }


    protected override void OnInitComplete(EventArgs e) {
      base.OnInitComplete(e);

      txtName.Text = company.Name;
    }



    protected void txtName_TextChanged(object sender, EventArgs e) {
      company.Name = txtName.Text;
    }
  }
}