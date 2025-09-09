using System.ComponentModel.DataAnnotations;

namespace Contract_Monthly_System.Models
{
    public class Lecturer
    {
        [Required(ErrorMessage = "LectureId field must not be blank")]
        [Key]
        public int LectuerId { get; set; }
        public string LecturerName { get; set; } = "";
        public string Email { get; set; } = "";
        public double HourlyRate { get; set; }
        public List<ClaimListViewer> Claim { get; set; }

    }
}
