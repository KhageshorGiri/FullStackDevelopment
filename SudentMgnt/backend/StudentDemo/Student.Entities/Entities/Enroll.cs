using System.ComponentModel.DataAnnotations;

namespace Student.Entities.Entities
{
    public class Enroll
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Enrolled Date Cannot be Null or Empty.")]
        public DateTime EnrolledDate { get; set; }

        [Required(ErrorMessage = "Enroll By Cannot be Null or Empty.")]
        public string? EnrolledBy { get; set; }

        // adding relation
        public Guid? StudentId { get; set; }
        public virtual Students? Students { get; set; }
        public string? CourseId { get; set; }
        public virtual Courses? Courses { get; set; }
    }
}
