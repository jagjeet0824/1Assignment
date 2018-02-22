namespace _1Assignmnet.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Defaultconnection")
        {
        }

        public virtual DbSet<Table1> Table1 { get; set; }
        public virtual DbSet<Table2_> Table2_ { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table1>()
                .Property(e => e.bike)
                .IsFixedLength();

            modelBuilder.Entity<Table1>()
                .Property(e => e.cars)
                .IsFixedLength();

            modelBuilder.Entity<Table1>()
                .Property(e => e.trains)
                .IsFixedLength();

            modelBuilder.Entity<Table2_>()
                .Property(e => e.planes)
                .IsFixedLength();

            modelBuilder.Entity<Table2_>()
                .Property(e => e.cranes)
                .IsFixedLength();
        }
    }
}
