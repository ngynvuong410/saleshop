namespace SaleShop.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Slide")]
    public partial class Slide
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Image { get; set; }

        public int? Displayorder { get; set; }

        [StringLength(50)]
        public string Link { get; set; }

        [StringLength(50)]
        public string Decription { get; set; }

        public DateTime? CreateBy { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModiedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public bool? Status { get; set; }
    }
}
