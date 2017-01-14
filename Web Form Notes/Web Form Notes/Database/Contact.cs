namespace Learn_Web_Forms.Database {
  using System;
  using System.Collections.Generic;
  using System.ComponentModel.DataAnnotations;
  using System.ComponentModel.DataAnnotations.Schema;
  using System.Data.Entity.Spatial;

  [Table("Contact")]
  public partial class Contact {
    public int ID { get; set; }

    [StringLength(50)]
    public string Name { get; set; }

    [StringLength(50)]
    public string Position { get; set; }

    [StringLength(50)]
    public string Phone { get; set; }

    [StringLength(50)]
    public string Email { get; set; }

    [StringLength(50)]
    public string Details { get; set; }
  }
}
