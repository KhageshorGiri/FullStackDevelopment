using System.ComponentModel.DataAnnotations;

namespace Student.Entities.Entities
{
    public  class Courses
    {
        public Courses()
        {
            Enrolls = new HashSet<Enroll>();
        }

        [Key]
        public Guid CourseId { get; set; }

        [Required(ErrorMessage = "Course Title Cannot be Null or Empty.")]
        [StringLength(250, ErrorMessage = "Course Title Should be of 250 Characters.")]
        public string? CourseTitle { get; set; }

        [Required(ErrorMessage = "Course Description Cannot be Null or Empty.")]
        [StringLength(250, ErrorMessage = "Course Description Should be of 500 Characters.")]
        public string? CourseDescription { get; set; }

        // relation
        public virtual IEnumerable<Enroll>? Enrolls { get; set; }
    }
}
