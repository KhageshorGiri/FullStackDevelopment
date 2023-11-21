using Student.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Application.Interfaces.ServiceInterfaces
{
    public interface IStudent
    {
        Task<List<Students>> GetAllStudentsAsync();
        Task<Students> GetStudentByIdAsync(Guid Id);
        Task AddStudentAsync(Students student);
        Task UpdateStudentAsync(Students student);
        Task DeleteStudentAsync(Guid Id);
    }
}
