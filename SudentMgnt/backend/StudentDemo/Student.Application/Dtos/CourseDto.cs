using Student.Entities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Application.Dtos
{
    public class CourseDto
    {
        public Guid CourseId { get; set; }

        [Required(ErrorMessage = "Course Title Cannot be Null or Empty.")]
        [StringLength(250, ErrorMessage = "Course Title Should be of 250 Characters.")]
        public string? CourseTitle { get; set; }

        [Required(ErrorMessage = "Course Description Cannot be Null or Empty.")]
        [StringLength(250, ErrorMessage = "Course Description Should be of 500 Characters.")]
        public string? CourseDescription { get; set; }
        
    }

    public class  CreateCourseDto
    {
        [Required(ErrorMessage = "Course Title Cannot be Null or Empty.")]
        [StringLength(250, ErrorMessage = "Course Title Should be of 250 Characters.")]
        public string? CourseTitle { get; set; }

        [Required(ErrorMessage = "Course Description Cannot be Null or Empty.")]
        [StringLength(250, ErrorMessage = "Course Description Should be of 500 Characters.")]
        public string? CourseDescription { get; set; }
    }

    public class UpdateCourseDto
    {

    }
}
