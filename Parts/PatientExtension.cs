using System;
using System.Collections.Generic;
using System.Linq;
using LinqAssignment.Models;

namespace LinqAssignment.Parts
{
 
 public static class PatientExtensions{


           public static List<Patient> MyHealthyPatients(this List<Patient> Source, double threshold)
           {
              return Source.Where(p => p.HealthScore >= threshold)
              .ToList();
           }

 }

}
