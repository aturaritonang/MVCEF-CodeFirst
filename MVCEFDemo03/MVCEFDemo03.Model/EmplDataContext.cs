namespace MVCEFDemo03.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EmplDataContext : DbContext
    {
        public EmplDataContext()
            : base("name=EmplDataConn")
        {
        }

        public virtual DbSet<MST_Employees> MST_Employees { get; set; }
        public virtual DbSet<MST_JobPositions> MST_JobPositions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MST_Employees>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<MST_Employees>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<MST_Employees>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<MST_Employees>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<MST_Employees>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<MST_Employees>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<MST_JobPositions>()
                .HasMany(e => e.MST_Employees)
                .WithRequired(e => e.MST_JobPositions)
                .HasForeignKey(e => e.JobPositionId);
        }
    }
}
