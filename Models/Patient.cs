namespace LinqAssignment.Models
{
    public class Patient
    {
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public int Age { get; set; }
    public double HealthScore { get; set; }  // 0-10
    public string Department { get; set; } = string.Empty;
    }
    
}
