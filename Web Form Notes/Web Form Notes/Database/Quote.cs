namespace Learn_Web_Forms.Database {
  using System;
  using System.Collections.Generic;
  using System.ComponentModel.DataAnnotations;
  using System.ComponentModel.DataAnnotations.Schema;
  using System.Data.Entity.Spatial;

  [Table("Quote")]
  public partial class Quote {
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Quote() {
      QuoteLines = new HashSet<QuoteLine>();
    }

    public int ID { get; set; }

    [Column(TypeName = "date")]
    public DateTime Date { get; set; }

    [StringLength(50)]
    public string Name { get; set; }

    public int CompanyID { get; set; }

    public virtual Company Company { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<QuoteLine> QuoteLines { get; set; }
  }
}
