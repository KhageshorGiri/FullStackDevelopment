using System.ComponentModel.DataAnnotations;

namespace Student.Entities.Entities
{
    public class Students
    {
        public Students() 
        {
            Enrolls = new HashSet<Enroll>();
        }

        [Key]
        public Guid StudentId { get; set; }

        [Required(ErrorMessage = "Student Name Cannot be Null or Empty.")]
        [StringLength(250, ErrorMessage = "Student Name Should be of 250 Characters.")]
        public string FullName { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Faculty Name Cannot be Null or Empty.")]
        [StringLength(250, ErrorMessage = "Faculty Name Should be of 250 Characters.")]
        public string Faculty { get; set; } = string.Empty;

        // relation
        public virtual IEnumerable<Enroll>? Enrolls { get; set; }
    }
}
