using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Learn_Web_Forms.Views {
  public partial class WebForm1 : System.Web.UI.Page {
    public Database.Database db = new Database.Database();
    public Database.Note note = null; //TODO Add Error handling for when no company is found

    protected void Page_Load(object sender, EventArgs e) {
      int ID;
      note = db.Notes.Find(int.TryParse(RouteData.Values["id"]?.ToString(), out ID) ? ID : 1);
    }

    protected void txtTitle_TextChanged(object sender, EventArgs e) {
      note.Title = txtTitle.Text;
      db.SaveChanges();
    }

    protected void txtCreated_TextChanged(object sender, EventArgs e) {
      DateTime Value;
      if (DateTime.TryParse(txtCreated.Text, out Value)) {
        note.Created = Value;
        db.SaveChanges();
      }
    }

    protected void txtText_TextChanged(object sender, EventArgs e) {
      note.Title = txtTitle.Text;
      db.SaveChanges();
    }
  }
}