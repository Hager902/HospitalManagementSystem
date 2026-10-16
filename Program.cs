using System;
using System.Collections.Generic;
using System.Linq;
using LinqAssignment.Models;
using LinqAssignment.Parts;

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
    new Appointment { Id = 1, PatientName = "Ahmed Hassan", DoctorName = "Dr. Sarah Ahmed", AppointmentDate = DateTime.Now.AddDays(5), Fee = 200 },
    new Appointment { Id = 2, PatientName = "Fatima Ali", DoctorName = "Dr. Omar Khalil", AppointmentDate = DateTime.Now.AddDays(7), Fee = 180 },
    new Appointment { Id = 3, PatientName = "Mohammed Karim", DoctorName = "Dr. Sarah Ahmed", AppointmentDate = DateTime.Now.AddDays(3), Fee = 200 }
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
PartD.Run(doctors, appointments);

