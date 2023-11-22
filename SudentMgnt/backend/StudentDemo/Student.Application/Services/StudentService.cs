using Student.Application.Dtos;
using Student.Application.Interfaces.RepositoryInterfaces;
using Student.Application.Interfaces.ServiceInterfaces;
using Student.Entities.Entities;

namespace Student.Application.Services
{
    public class StudentService : IStudent
    {
        private readonly IStudentRepository studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public async Task AddStudentAsync(CreateStudnetDto student)
        {
            throw new NotImplementedException();
        }

        public Task DeleteStudentAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<StudentDto>> GetAllStudentsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<StudentDto> GetStudentByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateStudentAsync(UpdateStudentDto student)
        {
            throw new NotImplementedException();
        }
    }
}
