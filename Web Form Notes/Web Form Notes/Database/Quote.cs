namespace Learn_Web_Forms.Database {
  using System;
  using System.Collections.Generic;
  using System.ComponentModel.DataAnnotations;
  using System.ComponentModel.DataAnnotations.Schema;
  using System.Data.Entity.Spatial;

  [Table("Quote")]
  public partial class Quote {
    [Key]
    [Column(Order = 0)]
    public int ID { get; set; }

    [Key]
    [Column(Order = 1, TypeName = "date")]
    public DateTime Date { get; set; }

    [StringLength(50)]
    public string Name { get; set; }
  }
}
