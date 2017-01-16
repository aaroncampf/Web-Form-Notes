using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Learn_Web_Forms.Code {
  public static class SeedData {
    public static void Seed() {
      var db = new Database.Database();
      db.Companies.RemoveRange(db.Companies);
      db.Contacts.RemoveRange(db.Contacts);
      db.Notes.RemoveRange(db.Notes);
      db.Quotes.RemoveRange(db.Quotes);
      db.QuoteLines.RemoveRange(db.QuoteLines);
      db.SaveChanges();

      db.Companies.AddRange(new[] {
        new Database.Company() { Name = "AJP Northwest", Address ="14567 Street", City="Satan City", State="OR", Zip ="666", Phone = "(666) 666-6666" },
        new Database.Company() { Name = "ANS Sales and Marketing", Address ="4566 Waring States", City="Ming City", State="OR", Zip ="5566474", Phone = "(999) 999-9999" }
      });
      db.SaveChanges();

      db.Contacts.AddRange(new[] {
        new Database.Contact() { Name = "Steven", Email = "Steven@gmail.com", Phone = "(667) 678-9876", Position ="Head of Sales", Details="Like a magic", Company = db.Companies.First() },
        new Database.Contact() { Name = "Bob", Email = "Bob@gmail.com", Phone = "(667) 678-9876", Position ="Head of Sales", Details="Like a magic", Company = db.Companies.OrderBy(x => x.ID).Skip(1).First() }
      });
      db.SaveChanges();

      db.Notes.AddRange(new[] {
        new Database.Note() { Title ="Hello World", Text = "Stuff and more stuff............", Created = DateTime.Now.AddDays(-357), Contact = db.Contacts.First() },
        new Database.Note() { Title ="Hello World", Text = "Stuff and more stuff............", Created = DateTime.Now.AddDays(-357), Contact = db.Contacts.OrderBy(x => x.ID).Skip(1).First() }

      });
      db.SaveChanges();

    }
  }
}