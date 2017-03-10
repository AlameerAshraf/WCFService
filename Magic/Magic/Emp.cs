namespace Magic
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Emp : DbContext
    {
        public Emp()
            : base("name=Emp1")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<project> projects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<employee>()
                .Property(e => e.empname)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.empsalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<employee>()
                .Property(e => e.empAddress)
                .IsUnicode(false);

            modelBuilder.Entity<project>()
                .Property(e => e.projname)
                .IsUnicode(false);

            modelBuilder.Entity<project>()
                .HasMany(e => e.employees)
                .WithRequired(e => e.project)
                .HasForeignKey(e => e.PId);
        }
    }
}
