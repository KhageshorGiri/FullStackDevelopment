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
            using (var connection = new SqlConnection(_configure.GetConnectionString("Default")))
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

        public async Task DeleteCourseAsync(Guid Id)
        {
            using (var connection = new SqlConnection(_configure.GetConnectionString("Default")))
            {
                connection.Open();

                // Parameterized SQL query for deletion
                var deleteQuery = "DELETE FROM Courses WHERE CourseId = @CourseId";

                // Execute the delete query
                await connection.ExecuteAsync(deleteQuery, new { CourseId = Id });
            }


        }

        public async Task<List<Courses>> GetAllCOursesAsync()
        {
            var connection = new SqlConnection(_configure.GetConnectionString("Default"));
            var response = await connection.QueryAsync<Courses>("Select * from Courses");
            return response.ToList();
        }

        public async Task<Courses> GetCourseByIdAsync(Guid Id)
        {
            using (var connection = new SqlConnection(_configure.GetConnectionString("Default")))
            {
                connection.Open();
                var response = await connection.QueryFirstOrDefaultAsync<Courses>("SELECT * FROM Courses WHERE CourseId = @CourseId", new { CourseId = Id });
                return response!;
            }
        }


        public async Task UpdateCourseAsync(Guid Id, Courses updatedCourse)
        {
            using (var connection = new SqlConnection(_configure.GetConnectionString("Default")))
            {
                connection.Open();

                // Parameterized SQL query for update
                var updateQuery = "UPDATE Courses SET CourseTitle = @CourseTitle, CourseDescription = @CourseDescription WHERE CourseId = @CourseId";

                // Execute the update query
                await connection.ExecuteAsync(updateQuery, new
                {
                    CourseTitle = updatedCourse?.CourseTitle,
                    CourseDescription = updatedCourse?.CourseDescription,
                    CourseId = Id,
                });
            }

        }
    }
}
