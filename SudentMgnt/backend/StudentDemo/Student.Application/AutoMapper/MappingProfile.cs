using AutoMapper;
using Student.Application.Dtos;
using Student.Entities.Entities;

namespace Student.Application.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Students, StudentDto>();
            // Add more mappings as needed
        }
    }
}
