using System;
using System.Collections.Generic;
using System.Linq;
using LinqAssignment.Models;

namespace LinqAssignment.Parts
{
    public static class PartC
    {
        public static void Run(List<Patient> patients)
        {
            double threshold = 6.8; 

int totalCount = patients.Count();
Console.WriteLine($"Total number of patients: {totalCount}");

int countAboveThreshold = patients.Count(p => p.HealthScore > threshold);
Console.WriteLine($"Number of patients with health score above {threshold}: {countAboveThreshold}");


double avgHealthScore = patients.Average(p => p.HealthScore);
Console.WriteLine($"Average health score: {avgHealthScore :F2}");

double maxHealthScore = patients.Max(p => p.HealthScore);
Console.WriteLine($"Maximum health score: {maxHealthScore}");

double minHealthScore = patients.Min(p => p.HealthScore);
Console.WriteLine($"Minimum health score: {minHealthScore}");

bool anyBelow5 = patients.Any(p => p.HealthScore < 5);
Console.WriteLine($"Number of patients with health score below 5: {anyBelow5}");

bool allAtOrAbove5 = patients.All(p => p.HealthScore >= 5);
Console.WriteLine($"All patients have health score at or above 5: {allAtOrAbove5}");


var byDepartment = patients.GroupBy(p => p.Department);
foreach (var group in byDepartment)
{
    Console.WriteLine($"DepartmentName : {group.Key}, Count: {group.Count()}");
    foreach (var patient in group)
    {
        Console.WriteLine($" - {patient.FullName}, HealthScore: {patient.HealthScore}");
    }
}

var byHealth = patients.GroupBy(p => p.HealthScore >= threshold ? "Above Threshold" : "Below Threshold");
foreach (var group in byHealth)
{
    Console.WriteLine($"GroupName : {group.Key}, Count: {group.Count()}, Members: {group.Select(p => p.FullName).ToList()}");
}


var SortedGroups = patients
.GroupBy(p =>p.Department)
.OrderBy(g => g.Key);
foreach (var group in SortedGroups)
{
    Console.WriteLine($"GroupName : {group.Key}, Count: {group.Count()}, patients: {group.Select(p => p.FullName).ToList()}");

    foreach (var patient in group)
    {
        Console.WriteLine($" HealthScore: {patient.HealthScore}");
    }
}


        }
    }
}

