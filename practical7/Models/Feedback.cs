
using System.ComponentModel.DataAnnotations;

namespace practical7.Models
{
    public class Feedback
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "Please enter email")]
        [EmailAddress(ErrorMessage = "Enter valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please select rating")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Please enter feedback")]
        [StringLength(500, MinimumLength = 5,
            ErrorMessage = "Feedback must be 5 to 500 characters")]
        public string Comments { get; set; }
    }
}
