using System.ComponentModel.DataAnnotations;

namespace LinqAssignment.Models
{
    public class Patient
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
    public string FullName { get; set; } = "";
    public int Age { get; set; }
    public double HealthScore { get; set; }  // 0-10
    public string Department { get; set; } = string.Empty;
    }
    
}
