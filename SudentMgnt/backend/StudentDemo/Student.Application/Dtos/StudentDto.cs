using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Application.Dtos
{
    public class StudentDto
    {
        public Guid StudentId { get; set; }

        [Required(ErrorMessage = "Student Name Cannot be Null or Empty.")]
        [StringLength(250, ErrorMessage = "Student Name Should be of 250 Characters.")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Faculty Name Cannot be Null or Empty.")]
        [StringLength(250, ErrorMessage = "Faculty Name Should be of 250 Characters.")]
        public string Faculty { get; set; } = string.Empty;
    }

    public class CreateStudnetDto
    {
        [Required(ErrorMessage = "Student Name Cannot be Null or Empty.")]
        [StringLength(250, ErrorMessage = "Student Name Should be of 250 Characters.")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Faculty Name Cannot be Null or Empty.")]
        [StringLength(250, ErrorMessage = "Faculty Name Should be of 250 Characters.")]
        public string Faculty { get; set; } = string.Empty;
    }

    public class UpdateStudentDto
    {

    }
}
