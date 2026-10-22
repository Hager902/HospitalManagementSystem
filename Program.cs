using System;
using System.Collections.Generic;
using System.Linq;
using LinqAssignment.Models;
using LinqAssignment.Parts;
using LinqAssignment.Data;

await using var context = new StudentPortalContext();


if (!context.Patients.Any())
{
    context.Patients.AddRange(
        new Patient { FullName = "Ahmed Hassan", Age = 45, HealthScore = 7.2, Department = "Cardiology" },
        new Patient { FullName = "Fatima Ali", Age = 32, HealthScore = 8.5, Department = "Neurology" },
        new Patient { FullName = "Mohammed Karim", Age = 58, HealthScore = 6.1, Department = "Cardiology" },
        new Patient { FullName = "Leila Mohamed", Age = 27, HealthScore = 9.0, Department = "Orthopedics" }
    );
    await context.SaveChangesAsync();
}


List<Patient> patients = new List<Patient>
{
    new Patient { Id = 1, FullName = "Ahmed Hassan", Age = 45, HealthScore = 7.2, Department = "Cardiology" },
    new Patient { Id = 2, FullName = "Fatima Ali", Age = 32, HealthScore = 8.5, Department = "Neurology" },
    new Patient { Id = 3, FullName = "Mohammed Karim", Age = 58, HealthScore = 6.1, Department = "Cardiology" },
    new Patient { Id = 4, FullName = "Leila Mohamed", Age = 27, HealthScore = 9.0, Department = "Orthopedics" },
    

};

List<Doctor> doctors = new List<Doctor>
{
    new Doctor { Id = 1, Name = "Dr. Sarah Ahmed", YearsOfExperience = 12, Specialty = "Cardiology" },
    new Doctor { Id = 2, Name = "Dr. Omar Khalil", YearsOfExperience = 8, Specialty = "Neurology" }
};

List<Appointment> appointments = new List<Appointment>
{
    new Appointment { Id = 1, PatientName = "Ahmed Hassan", DoctorId = 1, AppointmentDate = DateTime.Now.AddDays(5), Fee = 200 },
    new Appointment { Id = 2, PatientName = "Fatima Ali", DoctorId = 2, AppointmentDate = DateTime.Now.AddDays(7), Fee = 180 },
    new Appointment { Id = 3, PatientName = "Mohammed Karim", DoctorId = 1, AppointmentDate = DateTime.Now.AddDays(3), Fee = 200 }
};


doctors.Add(
    new Doctor
    { Id = 3,
    Name = "Dr. Hager Ahmed",
    YearsOfExperience = 6,
    Specialty = "Psychiatry"
    });
    Console.WriteLine("Doctors List:");
foreach (var d in doctors)
{
    Console.WriteLine($"Id: {d.Id}, Name: {d.Name}, Years of Experience: {d.YearsOfExperience}, Specialty: {d.Specialty}");
}


PartC.Run(patients);
await PartC.RunAsync(context);

PartD.Run(doctors, appointments);

await PartF.RunIncludeAsync(context);


