using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Learn_Web_Forms {
  public partial class Contact : Page {
    public Database.Database db = new Database.Database();
    public Database.Contact contact = null; //TODO Add Error handling for when no company is found

    protected void Page_Load(object sender, EventArgs e) {
      int ID;
      contact = db.Contacts.Find(int.TryParse(RouteData.Values["id"]?.ToString(), out ID) ? ID : 1);

      txtName.Text = txtName.Text == "" ? contact.Name : txtName.Text;
      txtPosition.Text = txtPosition.Text == "" ? contact.Position : txtPosition.Text;
      txtPhone.Text = txtPhone.Text == "" ? contact.Phone : txtPhone.Text;
      txtEmail.Text = txtEmail.Text == "" ? contact.Email : txtEmail.Text;
      txtDetails.Text = txtDetails.Text == "" ? contact.Details : txtDetails.Text;
    }

    protected void txtName_TextChanged(object sender, EventArgs e) {
      contact.Name = txtName.Text;
      db.SaveChanges();
    }

    protected void txtPosition_TextChanged(object sender, EventArgs e) {
      contact.Position = txtPosition.Text;
      db.SaveChanges();
    }

    protected void txtPhone_TextChanged(object sender, EventArgs e) {
      contact.Phone = txtPhone.Text;
      db.SaveChanges();
    }

    protected void txtEmail_TextChanged(object sender, EventArgs e) {
      contact.Email = txtEmail.Text;
      db.SaveChanges();
    }

    protected void txtDetails_TextChanged(object sender, EventArgs e) {
      contact.Details = txtDetails.Text;
      db.SaveChanges();
    }
  }
}