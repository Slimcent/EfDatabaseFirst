namespace EfDatabaseFirst.Ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transaction
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        [Required]
        [StringLength(10)]
        public string Mode { get; set; }

        public decimal Amount { get; set; }

        public DateTime Time { get; set; }

        public virtual User User { get; set; }
    }
}
