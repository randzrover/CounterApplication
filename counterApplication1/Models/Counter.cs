namespace counterApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Counter")]
    public partial class Counter
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Value { get; set; }
    }
}
