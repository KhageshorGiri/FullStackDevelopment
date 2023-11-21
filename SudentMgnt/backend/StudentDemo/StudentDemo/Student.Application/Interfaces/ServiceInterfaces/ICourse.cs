using Student.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Application.Interfaces.ServiceInterfaces
{
    public interface ICourse
    {
        Task<List<Students>> GetAllCOursesAsync();
        Task<Students> GetCourseByIdAsync(Guid Id);
        Task AddCourseAsync(Courses course);
        Task UpdateCourseAsync(Courses course);
        Task DeleteCourseAsync(Guid Id);
    }
}
