using AutoMapper;
using Student.Application.Dtos;
using Student.Application.Interfaces.RepositoryInterfaces;
using Student.Application.Interfaces.ServiceInterfaces;

namespace Student.Application.Services
{
    public class StudentService : IStudent
    {
        private readonly IStudentRepository studentRepository;
        private readonly IMapper _mapper;

        public StudentService(IStudentRepository studentRepository, IMapper mapper)
        {
            this.studentRepository = studentRepository;
            this._mapper = mapper;
        }

        public Task AddStudentAsync(CreateStudentDto student)
        {
            throw new NotImplementedException();
        }

        public Task DeleteStudentAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<StudentDto>> GetAllStudentsAsync()
        {
            var allStudents_source = await studentRepository.GetAllStudentsAsync();
            var allStudent_final = _mapper.Map<List<StudentDto>>(allStudents_source);
            return allStudent_final;
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
