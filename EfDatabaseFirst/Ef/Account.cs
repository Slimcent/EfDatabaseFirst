namespace EfDatabaseFirst.Ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Account
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int Account_Number { get; set; }

        public decimal Balance { get; set; }

        public virtual User User { get; set; }
    }
}
