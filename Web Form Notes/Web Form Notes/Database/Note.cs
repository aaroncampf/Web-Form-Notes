namespace Learn_Web_Forms.Database {
  using System;
  using System.Collections.Generic;
  using System.ComponentModel.DataAnnotations;
  using System.ComponentModel.DataAnnotations.Schema;
  using System.Data.Entity.Spatial;

  [Table("Note")]
  public partial class Note {
    [Key]
    [Column(Order = 0)]
    public int ID { get; set; }

    [StringLength(50)]
    public string Title { get; set; }

    [Key]
    [Column(Order = 1, TypeName = "date")]
    public DateTime Created { get; set; }

    [StringLength(50)]
    public string Text { get; set; }
  }
}
