using Microsoft.EntityFrameworkCore;
using LinqAssignment.Models;

namespace LinqAssignment.Data
{
    public class StudentPortalContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=hospital.db");
        }
    }
}