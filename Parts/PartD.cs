using System;
using System.Collections.Generic;
using System.Linq;
using LinqAssignment.Models;

namespace LinqAssignment.Parts
{
    public static class PartD
    {
        public static void Run(List<Doctor> doctors, List<Appointment> appointments)
        {
            var joined = doctors
            .Join(
                appointments,
                d => d.Name,
                a => a.DoctorName,
                (d, a) => new
                {
                    DoctorName = d.Name,
                    PatientName = a.PatientName,
                    AppointmentFee = a.Fee,
                }
            )
            .ToList();

            foreach (var item in joined)
            {
                Console.WriteLine($"Doctor: {item.DoctorName}, Patient: {item.PatientName}, Fee: {item.AppointmentFee}");
            }

            var joinedQuery = (from d in doctors
                              join a in appointments on d.Name equals a.DoctorName
                              select new
                              {
                                    DoctorName = d.Name,
                                    PatientName = a.PatientName,
                                    AppointmentFee = a.Fee,
                              })
            .ToList();

            foreach (var item in joinedQuery)
            {
                Console.WriteLine($"Doctor: {item.DoctorName}, Patient: {item.PatientName}, Fee: {item.AppointmentFee}");
            }

            Console.WriteLine($"Total number of doctors: {doctors.Count()}");
            Console.WriteLine($"Rows in join result: {joined.Count}");
           
        }
    }
}

