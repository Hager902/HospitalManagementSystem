using Microsoft.EntityFrameworkCore;
using LinqAssignment.Models;

namespace LinqAssignment.Data
{
    public class StudentPortalContext  : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=hospital.db");
        }

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Patient>()
    .Property(p => p.FullName)
    .IsRequired()
    .HasMaxLength(100);

    modelBuilder.Entity<Doctor>()
    .Property(d => d.Name)
    .IsRequired()
    .HasMaxLength(120);



    modelBuilder.Entity<Appointment>()
    .HasOne(a => a.Doctor)
    .WithMany(d => d.Appointments)
    .HasForeignKey(a => a.DoctorId)
    .OnDelete(DeleteBehavior.SetNull);
}
    }
}