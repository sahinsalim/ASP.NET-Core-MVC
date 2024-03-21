using System.ComponentModel.DataAnnotations;

namespace ThirdPart.Models
{
    public class Candidate
    {
        [Required(ErrorMessage = "Email is required.")]
        public String? Email { get; set; }
        
        [Required(ErrorMessage = "FirstName is required.")]
        public String? FirstName { get; set; }
        
        [Required(ErrorMessage = "LastName is required.")]
        public String? LastName { get; set; }
        
        public String? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int? Age { get; set; }
        public String? SelectedCourse { get; set; }
        public DateTime ApplyAt { get; set; }

        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }

    }
}
