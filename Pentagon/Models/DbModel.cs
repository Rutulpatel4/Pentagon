namespace Pentagon.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbModel : DbContext
    {
        public DbModel()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<key> keys { get; set; }
        public virtual DbSet<userInfo> userInfoes { get; set; }
        public virtual DbSet<vehicle> vehicles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<vehicle>()
                .HasMany(e => e.keys)
                .WithRequired(e => e.vehicle)
                .WillCascadeOnDelete(false);
        }
    }
}
