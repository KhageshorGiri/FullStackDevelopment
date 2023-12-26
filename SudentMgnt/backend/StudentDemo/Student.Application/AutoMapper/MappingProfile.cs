using AutoMapper;
using Student.Application.Dtos;
using Student.Entities.Entities;

namespace Student.Application.AutoMapper
{

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Mapping from Students to StudentDto
            CreateMap<Students, StudentDto>()
                .ForMember(dest => dest.StudentId, opt => opt.MapFrom(src => src.StudentId))
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FullName))
                .ForMember(dest => dest.Faculty, opt => opt.MapFrom(src => src.Faculty));

            // Mapping from CreateStudentDto to Students
            CreateMap<CreateStudentDto, Students>()
                .ForMember(dest => dest.StudentId, opt => opt.MapFrom(src => Guid.NewGuid())) // Assuming you generate a new GUID for each new student
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FullName))
                .ForMember(dest => dest.Faculty, opt => opt.MapFrom(src => src.Faculty));


            // Mapping from Courses to CoursesDto
            CreateMap<Courses, CourseDto>();

            // Mapping from CoursesDto to courses
            CreateMap<CreateCourseDto, Courses>()
                .ForMember(m => m.CourseId, opt => opt.MapFrom(src=> Guid.NewGuid()));

        }
    }

}
