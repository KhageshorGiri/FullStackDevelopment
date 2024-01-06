using AutoMapper;
using Student.Application.Dtos;
using Student.Application.Interfaces.RepositoryInterfaces;
using Student.Application.Interfaces.ServiceInterfaces;
using Student.Entities.Entities;

namespace Student.Application.Services
{
    public class Enrollservice : IEnroll
    {

        protected readonly IEnrollRepository _enrollRepository;
        protected readonly IMapper _mapper;

        public Enrollservice(IEnrollRepository enrollRepository, IMapper mapper)
        {
            _enrollRepository = enrollRepository;
            _mapper = mapper;
        }

        public async Task AddEnrollAsync(EnrollStudentDto course)
        {
            var mappedValue = _mapper.Map<Enroll>(course);
             await _enrollRepository.AddAsync(mappedValue);
        }

        public async Task DeleteEnrollAsync(Guid Id)
        {
            var existingValue = GetEnrollByIdAsync(Id);
            await _enrollRepository.DeleteAsync(Id);
        }

        public async Task<List<EnrollDto>> GetAllEnrollListAsync()
        {
            var enrollDetails = await _enrollRepository.GetAllAsync();
            return _mapper.Map<List<EnrollDto>>(enrollDetails);
        }

        public async Task<EnrollDto> GetEnrollByIdAsync(Guid Id)
        {
            var existing = await _enrollRepository.GetEnrollByIdAsync(Id);
            return _mapper.Map<EnrollDto>(existing);
        }

        public async Task UpdateEnrollAsync(Guid Id, UpdateEnrollDto course)
        {
            var existingValue = GetEnrollByIdAsync(Id);
            await _enrollRepository.UpdateAsync(_mapper.Map<Enroll>(existingValue));
        }
    }
}
