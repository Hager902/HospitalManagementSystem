using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using LinqAssignment.Data;
using LinqAssignment.Models;

namespace LinqAssignment.Parts
{
    public static class PartE
    {
        public static void Run(List<Patient> patients)
        {
            var filteredQuery = patients
            .Where(p => p.HealthScore > 7)
            .ToList();

            Console.WriteLine($"Patients with health score above 7:{patients.Count()}");
            foreach(var patient in filteredQuery)
            {
                Console.WriteLine($"FullName: {patient.FullName}");
            }

            var avg = filteredQuery.Average(p => p.HealthScore);
            Console.WriteLine($"Average health score of patients with health score above 7: {avg:F2}");
            

            patients.Add(
                new Patient
                {
                    Id = 5,
                    FullName = "Zeinab Samir",
                    Age = 35,
                    HealthScore = 7.8,
                    Department = "Orthopedics"
                }
            );
            Console.WriteLine("Updated Patients List:");

            int Count = filteredQuery.Count();
            Console.WriteLine($"Total number of patients with health score above 7: {Count}");


            patients.RemoveAll(p => p.FullName == "Zeinab Samir");
            Console.WriteLine("Patients List after removing Zeinab Samir:");


            var sortedPatients = patients
            .MyHealthyPatients(6.8)
            .OrderBy(p => p.FullName)
            .Select(p => p.FullName)
            .ToList();

            foreach(var name in sortedPatients)
            {
                Console.WriteLine($"Name");
            }

        }



            public static async Task LinkAppointmentAsync(StudentPortalContext context)
        {

 
            var sarah = await context.Doctors
            .FirstOrDefaultAsync(d => d.Name == "Dr. Sarah Ahmed ");

            var mohammedAppointment = await context.Appointments
            .FirstOrDefaultAsync(a => a.PatientName == "Mohammed Karim");

            if(sarah is null || mohammedAppointment is null)
            {
                Console.WriteLine($"Not Found");
                return;
            }

            mohammedAppointment.DoctorId = sarah.Id;
            await context.SaveChangesAsync();
            Console.WriteLine($"Linked appointment {mohammedAppointment.Id} to doctor {sarah.Id}.");

        }


        public static async Task ProveForeignKeyAsync(StudentPortalContext context)
        {
            try
            {
                var newPatient = new Appointment{ PatientName = "Test Patient", DoctorId = 9999, AppointmentDate = DateTime.Now, Fee = 100 };
                context.Appointments.Add(newPatient);
                await context.SaveChangesAsync();

            }
            
            catch(DbUpdateException ex)
            {
                Console.WriteLine($"Exception: {ex.GetType().Name}");
                Console.WriteLine($"Message: {ex.InnerException?.Message}");

            }
            
            }



    
       







        
        }
    }
