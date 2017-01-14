namespace Learn_Web_Forms.Database {
  using System;
  using System.Collections.Generic;
  using System.ComponentModel.DataAnnotations;
  using System.ComponentModel.DataAnnotations.Schema;
  using System.Data.Entity.Spatial;

  [Table("QuoteLine")]
  public partial class QuoteLine {
    [Key]
    [Column(Order = 0)]
    public int ID { get; set; }

    [Key]
    [Column(Order = 1)]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Display { get; set; }

    [StringLength(50)]
    public string DESC { get; set; }

    [StringLength(50)]
    public string UNIT { get; set; }

    public double? Cost { get; set; }
  }
}
