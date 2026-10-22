using System.ComponentModel.DataAnnotations;

namespace LinqAssignment.Models

{
    public class Doctor
    {
    public int Id { get; set; }

    [Required]
    [MaxLength(120)]
    public string Name { get; set; } = "";
    public int YearsOfExperience { get; set; }
    public string Specialty { get; set; } = "";
    public List<Appointment> Appointments {get; set; } = [];
    }
}
