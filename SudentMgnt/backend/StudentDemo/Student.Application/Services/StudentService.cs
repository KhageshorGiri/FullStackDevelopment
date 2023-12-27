using AutoMapper;
using Student.Application.Dtos;
using Student.Application.Interfaces.RepositoryInterfaces;
using Student.Application.Interfaces.ServiceInterfaces;
using Student.Entities.Entities;

namespace Student.Application.Services
{
    public class StudentService : IStudent
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public StudentService(IStudentRepository studentRepository, IMapper mapper)
        {
            this._studentRepository = studentRepository;
            this._mapper = mapper;
        }

        public async Task AddStudentAsync(CreateStudentDto newStudent)
        {
            var mappedStudent = _mapper.Map<Students>(newStudent);
            await _studentRepository.AddStudentAsync(mappedStudent);
        }

        public async Task DeleteStudentAsync(Guid Id)
        {
            await _studentRepository.DeleteStudentAsync(Id);
        }

        public async Task<List<StudentDto>> GetAllStudentsAsync()
        {
            var allStudents_source = await _studentRepository.GetAllStudentsAsync();
            var allStudent_final = _mapper.Map<List<StudentDto>>(allStudents_source);
            return allStudent_final;
        }

        public async Task<StudentDto> GetStudentByIdAsync(Guid Id)
        {
            var existingStudent = await _studentRepository.GetStudentByIdAsync(Id);
            return _mapper.Map<StudentDto>(existingStudent);
        }

        public async Task UpdateStudentAsync(Guid Id, UpdateStudentDto student)
        {
            var mappedStudent = _mapper.Map<Students>(student);
            await _studentRepository.UpdateStudentAsync(Id, mappedStudent);
        }
    }
}
