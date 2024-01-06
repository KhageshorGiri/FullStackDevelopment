using Student.Entities.Entities;
using System.ComponentModel.DataAnnotations;

namespace Student.Application.Dtos
{
    public class EnrollDto
    {
        public Guid Id { get; set; }
        public DateTime EnrolledDate { get; set; }
        public string? EnrolledBy { get; set; }
        public List<Students>? Students { get; set; }
        public List<Courses>? Courses { get; set; }
    }

    public class EnrollStudentDto
    {
        [Required]
        public DateTime EnrolledDate { get; set; }

        [Required]
        public string? EnrolledBy { get; set; }

        [Required]
        public Guid StudentId { get; set; }

        [Required]
        public Guid CoursesId { get; set; }
    }

    public class UpdateEnrollDto
    {
        [Required]
        public DateTime EnrolledDate { get; set; }

        [Required]
        public string? EnrolledBy { get; set; }

        [Required]
        public Guid StudentId { get; set; }

        [Required]
        public Guid CoursesId { get; set; }
    }
}
