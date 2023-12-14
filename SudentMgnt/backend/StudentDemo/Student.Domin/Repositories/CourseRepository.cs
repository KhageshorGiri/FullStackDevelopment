using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Student.Application.Interfaces.RepositoryInterfaces;
using Student.Entities.Entities;

namespace Student.Domin.Repositories
{
    public class CourseRepository : ICourseRepository
    {

        private readonly IConfiguration _configure;

        public CourseRepository(IConfiguration configuration)
        {
            _configure = configuration;
        }

        public Task AddCourseAsync(Courses course)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCourseAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Courses>> GetAllCOursesAsync()
        {
            var connection = new SqlConnection("Server=DESKTOP-OA4FHOO\\SQLEXPRESS;Database=SMgnt;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");
            var response = await connection.QueryAsync<Courses>("Select * from Courses");
            return response.ToList();
        }

        public Task<Courses> GetCourseByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCourseAsync(Courses course)
        {
            throw new NotImplementedException();
        }
    }
}
