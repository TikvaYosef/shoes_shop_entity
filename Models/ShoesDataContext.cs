using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace shoes_shop_entity.Models
{
    public partial class ShoesDataContext : DbContext
    {
        public ShoesDataContext()
            : base("name=ShoesDataContext")
        {
        }

        public virtual DbSet<Eventshoes> EventShoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
