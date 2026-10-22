using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LinqAssignment.Data;
using LinqAssignment.Models;

namespace LinqAssignment.Parts
{
    public static class PartF
    {
        public static async Task RunIncludeAsync(StudentPortalContext context)
        {

              var doctors = await context.Doctors
                    .Include(d => d.Appointments)
                    .ToListAsync();

                    foreach(var d in doctors)
                    {
                        Console.WriteLine($"Doctor Appointments Count Is : {d.Appointments.Count}");
                    }




        }

          public static async Task RunAppointmentsAsync(StudentPortalContext context)
          {

          
            var sarah = await context.Doctors
            .FirstOrDefaultAsync(d => d.Name == "Dr. Sarah Ahmed");
            
            if(sarah is null)
            {
                Console.WriteLine($"Not Found");
                return;
            }

            context.Appointments.AddRange(
                new Appointment{PatientName = "Ahmed Hassan",  DoctorId = sarah.Id, AppointmentDate = DateTime.Now.AddDays(10), Fee = 200 },
                new Appointment { PatientName = "Fatima Ali",    DoctorId = sarah.Id, AppointmentDate = DateTime.Now.AddDays(12), Fee = 200 }
                );
                    
                await context.SaveChangesAsync();
                Console.WriteLine($"Added 2 extra appointments.");


                var summary = await context.Doctors
                .Select(d => new {d.Name, Count = d.Appointments.Count()})
                .ToListAsync();

          }

          public static async Task RunCollectionAsync(StudentPortalContext context)
          {
            var doctor = await context.Doctors
            .FirstOrDefaultAsync(d => d.Name == "Dr. Sarah Ahmed");

            if(doctor is null)
            {
                Console.WriteLine($"Not Found");
                return;
            }

            Console.WriteLine($"Before Loading : {doctor.Appointments.Count}");

      
            await context.Entry(doctor).Collection(d => d.Appointments).LoadAsync();

            Console.WriteLine($"The Count Is : {doctor.Appointments.Count}");
          }


          public static async Task RunPatientsAsync(StudentPortalContext context)
          {
            var patients = await context.Patients
            .AsNoTracking()
            .ToListAsync();

          }


    }
}