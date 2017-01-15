namespace Learn_Web_Forms.Database {
  using System;
  using System.Collections.Generic;
  using System.ComponentModel.DataAnnotations;
  using System.ComponentModel.DataAnnotations.Schema;
  using System.Data.Entity.Spatial;

  [Table("Company")]
  public partial class Company {
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Company() {
      Contacts = new HashSet<Contact>();
      Quotes = new HashSet<Quote>();
    }

    public int ID { get; set; }

    [StringLength(50)]
    public string Name { get; set; }

    [StringLength(50)]
    public string Address { get; set; }

    [StringLength(50)]
    public string City { get; set; }

    [StringLength(50)]
    public string State { get; set; }

    [StringLength(50)]
    public string Zip { get; set; }

    [StringLength(50)]
    public string Phone { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Contact> Contacts { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Quote> Quotes { get; set; }











    static Database db = new Database();

    //Method to retrieve all the records

    public static IEnumerable<Company> GetAllCompanies() => db.Companies;

    public static void AddCompany(Company company) {
      db.Companies.Add(company);
      db.SaveChanges();
    }

    public static void UpdateCompany(Company company) {
      //TODO: Find out if I need this at all
      var ExistingCompany = db.Companies.Find(company.ID);
      ExistingCompany.Name = company.Name;
      //todo finish
      db.SaveChanges();
    }

    public static void DeleteCompany(Company company) {
      db.Companies.Remove(company);
      db.SaveChanges();
    }

  }
}
