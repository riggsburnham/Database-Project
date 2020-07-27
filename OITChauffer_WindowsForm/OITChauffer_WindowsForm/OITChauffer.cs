namespace OITChauffer_WindowsForm
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using OITChauffer_WindowsForm.Models;

    public partial class OITChauffer : DbContext
    {
        public OITChauffer()
            : base("name=OITChauffer")
        {
        }

        public virtual DbSet<Chauffer> Chauffers { get; set; }
        public virtual DbSet<Rider> Riders { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<RideRequest> RideRequests { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<SystemAdmin> SystemAdmins { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
