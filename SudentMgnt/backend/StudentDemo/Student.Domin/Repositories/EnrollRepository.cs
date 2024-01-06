using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Student.Application.Interfaces.RepositoryInterfaces;
using Student.Application.Interfaces.ServiceInterfaces;
using Student.Domin.DataContext;
using Student.Domin.GenericClasses;
using Student.Entities.Entities;

namespace Student.Domin.Repositories
{
    public sealed class EnrollRepository : IEnrollRepository
    {
        private readonly IConfiguration _configure;

        public EnrollRepository(IConfiguration configuration)
        {
            _configure = configuration;
        }

        public async Task AddAsync(Enroll enroll)
        {
            using (var connection = new SqlConnection(_configure.GetConnectionString("Default")))
            {
                connection.Open();

                // Parameterized SQL query for insertion
                var insertQuery = "INSERT INTO Enrolls (Id, EnrolledDate, EnrolledBy, StudentId, CourseId) " +
                                    "VALUES (@Id, @EnrolledDate, @EnrolledBy, @StudentId, @CourseId)";

                // Execute the insert query
                await connection.ExecuteAsync(insertQuery, new
                {
                    Id = enroll.Id,
                    EnrolledDate = enroll.EnrolledDate,
                    EnrolledBy = "default user",
                    StudentId = enroll.StudentId,
                    CourseId = enroll.CourseId
                });
            }
        }

        public async Task DeleteAsync(Guid Id)
        {
            using (var connection = new SqlConnection(_configure.GetConnectionString("Default")))
            {
                connection.Open();

                // Parameterized SQL query for deletion
                var deleteQuery = "DELETE FROM Enrolls WHERE Id = @EnrollId";

                // Execute the delete query
                await connection.ExecuteAsync(deleteQuery, new { EnrollId = Id });
            }
        }

        public async Task<List<Enroll>> GetAllAsync()
        {
            var connection = new SqlConnection(_configure.GetConnectionString("Default"));
            var response = await connection.QueryAsync<Enroll>("Select * from Enrolls");
            return response.ToList();
        }

        public async Task<Enroll> GetEnrollByIdAsync(Guid Id)
        {
            using (var connection = new SqlConnection(_configure.GetConnectionString("Default")))
            {
                connection.Open();
                var response = await connection.QueryFirstOrDefaultAsync<Enroll>("SELECT * FROM Enrolls WHERE Id = @EnrollId", new { EnrollId = Id });
                return response!;
            }
        }

        public async Task UpdateAsync(Enroll enroll)
        {
            using (var connection = new SqlConnection(_configure.GetConnectionString("Default")))
            {
                connection.Open();

                // Parameterized SQL query for update
                var updateQuery = "UPDATE Enrolls SET Id = @Id, EnrolledDate = @EnrolledDate, EnrolledBy = @EnrolledBy, StudentId = @StudentId, CourseId = @CourseId";

                // Execute the update query
                await connection.ExecuteAsync(updateQuery, new
                {
                    Id = enroll.Id,
                    EnrolledDate = enroll.EnrolledDate,
                    EnrolledBy = "default user",
                    StudentId = enroll.StudentId,
                    CourseId = enroll.CourseId
                });
            }
        }
    }
}
