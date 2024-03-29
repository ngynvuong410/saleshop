namespace SaleShop.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Menutype")]
    public partial class Menutype
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }
    }
}
