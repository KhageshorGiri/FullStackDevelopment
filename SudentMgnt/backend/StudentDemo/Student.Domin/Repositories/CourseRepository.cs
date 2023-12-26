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

        public async Task AddCourseAsync(Courses course)
        {
            using (var connection = new SqlConnection("Server=DESKTOP-OA4FHOO\\SQLEXPRESS;Database=SMgnt;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;"))
            {
                connection.Open();
                
                // Parameterized SQL query for insertion
                var insertQuery = "INSERT INTO Courses (CourseId, CourseTitle, CourseDescription) VALUES (@CourseId, @CourseTitle, @CourseDescription)";

                // Execute the insert query
                await connection.ExecuteAsync(insertQuery, new
                {
                    course.CourseId,
                    course.CourseTitle,
                    course.CourseDescription
                });
            }
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

        public async Task<Courses> GetCourseByIdAsync(Guid Id)
        {
            using (var connection = new SqlConnection("Server=DESKTOP-OA4FHOO\\SQLEXPRESS;Database=SMgnt;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;"))
            {
                connection.Open();
                var response = await connection.QueryFirstOrDefaultAsync<Courses>("SELECT * FROM Courses WHERE CourseId = @CourseId", new { CourseId = Id });
                return response;
            }
        }


        public Task UpdateCourseAsync(Courses course)
        {
            throw new NotImplementedException();
        }
    }
}
