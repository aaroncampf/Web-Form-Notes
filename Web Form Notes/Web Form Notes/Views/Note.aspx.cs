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
      note = int.TryParse(RouteData.Values["id"]?.ToString(), out ID) ? db.Notes.Find(ID) : db.Notes.First();

      txtTitle.Text = txtTitle.Text == "" ? note.Title : txtTitle.Text;
      txtCreated.Text = txtCreated.Text == "" ? note.Created.ToShortDateString() : txtCreated.Text;
      txtText.Text = txtText.Text == "" ? note.Text : txtText.Text;
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
      note.Text = txtText.Text;
      db.SaveChanges();
    }

    protected void btnDelete_Click(object sender, EventArgs e) {
      Response.Redirect($"/Contact/{note.Contact.ID}", false);
      db.Notes.Remove(note);
      db.SaveChanges();     
    }

    //[System.Web.Services.WebMethod]
    //[System.Web.Script.Services.ScriptMethod]
    //protected void btnDelete_Click() {
    //  Response.Redirect($"/Contact/{note.Contact.ID}", false);
    //  db.Notes.Remove(note);
    //  db.SaveChanges();
    //}

  }
}