namespace Learn_Web_Forms.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuoteLine")]
    public partial class QuoteLine
    {
        public int ID { get; set; }

        public int Display { get; set; }

        [StringLength(50)]
        public string DESC { get; set; }

        [StringLength(50)]
        public string UNIT { get; set; }

        public double? Cost { get; set; }

        public int QuoteID { get; set; }

        public virtual Quote Quote { get; set; }
    }
}
