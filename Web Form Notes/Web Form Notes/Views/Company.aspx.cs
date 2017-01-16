using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Learn_Web_Forms.Views {
  public partial class Company : System.Web.UI.Page {
    public Database.Database db = new Database.Database();
    public Database.Company company = null; //TODO Add Error handling for when no company is found

    protected void Page_Load(object sender, EventArgs e) {
      int ID;
      company = db.Companies.Find(int.TryParse(RouteData.Values["id"]?.ToString(), out ID) ? ID : 1);

      txtName.Text = txtName.Text == "" ? company.Name : txtName.Text;
      txtAddress.Text = txtAddress.Text == "" ? company.Address : txtAddress.Text;
      txtCity.Text = txtCity.Text == "" ? company.City : txtCity.Text;
      txtState.Text = txtState.Text == "" ? company.State : txtState.Text;
      txtZip.Text = txtZip.Text == "" ? company.Zip : txtZip.Text;
      txtPhone.Text = txtPhone.Text == "" ? company.Phone : txtPhone.Text;

      //DetailsView1.DataSource = new[] { company };
      //DetailsView1.DataBind();

      //txtName.Text = company.Name;
    }

    protected void txtName_TextChanged(object sender, EventArgs e) {
      company.Name = txtName.Text;
      db.SaveChanges();
    }

    protected void txtAddress_TextChanged(object sender, EventArgs e) {
      company.Address = txtAddress.Text;
      db.SaveChanges();
    }

    protected void txtCity_TextChanged(object sender, EventArgs e) {
      company.City = txtCity.Text;
      db.SaveChanges();
    }

    protected void txtState_TextChanged(object sender, EventArgs e) {
      company.State = txtState.Text;
      db.SaveChanges();
    }

    protected void txtZip_TextChanged(object sender, EventArgs e) {
      company.Zip = txtZip.Text;
      db.SaveChanges();
    }

    protected void txtPhone_TextChanged(object sender, EventArgs e) {
      company.Phone = txtPhone.Text;
      db.SaveChanges();
    }
  }
}