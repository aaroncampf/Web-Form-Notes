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
      if (int.TryParse(Request.QueryString["id"], out ID)) {
        contact = db.Contacts.Find(ID);
      }
      else {
        contact = db.Contacts.Find(1);
      }
    }
  }
}