using AutoMapper;
using Student.Application.Dtos;
using Student.Application.Interfaces.RepositoryInterfaces;
using Student.Application.Interfaces.ServiceInterfaces;
using Student.Entities.Entities;

namespace Student.Application.Services
{
    public class CourseService : ICourse
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;

        public CourseService(ICourseRepository courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }

        public Task AddCourseAsync(CreateCourseDto course)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCourseAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CourseDto>> GetAllCOursesAsync()
        {
            var response = await _courseRepository.GetAllCOursesAsync();
            return _mapper.Map<List<CourseDto>>(response);
        }

        public Task<CourseDto> GetCourseByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCourseAsync(UpdateCourseDto course)
        {
            throw new NotImplementedException();
        }
    }
}
