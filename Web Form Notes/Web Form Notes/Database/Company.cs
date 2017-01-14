namespace Learn_Web_Forms.Database {
  using System;
  using System.Collections.Generic;
  using System.ComponentModel.DataAnnotations;
  using System.ComponentModel.DataAnnotations.Schema;
  using System.Data.Entity.Spatial;

  [Table("Company")]
  public partial class Company {
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
  }
}
