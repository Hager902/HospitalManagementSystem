namespace LinqAssignment.Models
{
    public class Appointment
    {
    public int Id { get; set; }
    public int? DoctorId {get; set;}
    public string PatientName { get; set; } = "";
    //public string DoctorName { get; set; }
    public DateTime AppointmentDate { get; set; }
    public double Fee { get; set; }
    public Doctor? Doctor { get; set; }
    }
    }