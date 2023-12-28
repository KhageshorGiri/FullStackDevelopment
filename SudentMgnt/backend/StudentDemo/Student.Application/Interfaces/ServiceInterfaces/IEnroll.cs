using Student.Application.Dtos;
using System.Threading.Tasks;

namespace Student.Application.Interfaces.ServiceInterfaces
{
    public interface IEnroll
    {
        Task<List<EnrollDto>> GetAllEnrollListAsync();
        Task<EnrollDto> GetEnrollByIdAsync(Guid Id);
        Task AddEnrollAsync(EnrollStudentDto course);
        Task UpdateEnrollAsync(Guid Id, UpdateEnrollDto course);
        Task DeleteEnrollAsync(Guid Id);
    }
}
