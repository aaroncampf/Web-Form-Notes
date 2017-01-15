namespace Learn_Web_Forms.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Note")]
    public partial class Note
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [Column(TypeName = "date")]
        public DateTime Created { get; set; }

        [StringLength(50)]
        public string Text { get; set; }

        public int ContactID { get; set; }

        public virtual Contact Contact { get; set; }
    }
}
