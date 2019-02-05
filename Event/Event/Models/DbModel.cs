namespace Event.Models
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

        public virtual DbSet<Event_Detail> Event_Details { get; set; }
        public virtual DbSet<MyEvent> MyEvents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event_Detail>()
                .Property(e => e.Id_Number)
                .IsFixedLength();

            modelBuilder.Entity<MyEvent>()
                .Property(e => e.Event_Title)
                .IsFixedLength();

            modelBuilder.Entity<MyEvent>()
                .Property(e => e.Location)
                .IsFixedLength();
        }
    }
}
