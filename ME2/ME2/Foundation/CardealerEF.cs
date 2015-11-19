using Common;

namespace Foundation
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CardealerEF : DbContext
    {
        public DbSet<Address> Address { get; set; }

        public CardealerEF()
            : base("name=CardealerEF")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
