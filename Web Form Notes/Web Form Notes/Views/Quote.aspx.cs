using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Learn_Web_Forms.Views {
  public partial class Quote : System.Web.UI.Page {
    public Database.Database db = new Database.Database();
    public Database.Quote quote = null; //TODO Add Error handling for when no company is found

    protected void Page_Load(object sender, EventArgs e) {
      int ID;
      //company = db.Companies.Find(int.TryParse(RouteData.Values["id"]?.ToString(), out ID) ? ID : 1);
      quote = int.TryParse(RouteData.Values["id"]?.ToString(), out ID) ? db.Quotes.Find(ID) : db.Quotes.First();


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
  }
}