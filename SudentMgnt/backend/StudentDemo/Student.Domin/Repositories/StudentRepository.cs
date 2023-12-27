using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Student.Application.Interfaces.RepositoryInterfaces;
using Student.Application.Interfaces.ServiceInterfaces;
using Student.Entities.Entities;

namespace Student.Domin.Repositories
{
    public class StudentRepository : IStudentRepository
    {

        private readonly IConfiguration _configure;

        public StudentRepository(IConfiguration configuration)
        {
            _configure = configuration;
        }

        public async Task AddStudentAsync(Students newStudent)
        {
            using (var connection = new SqlConnection(_configure.GetConnectionString("Default")))
            {
                connection.Open();

                // Parameterized SQL query for insertion
                var insertQuery = "INSERT INTO Students (StudentId, FullName, Faculty) VALUES (@StudentId, @FullName, @Faculty)";

                // Execute the insert query
                await connection.ExecuteAsync(insertQuery, new
                {
                    newStudent.StudentId,
                    newStudent.FullName,
                    newStudent.Faculty
                });
            }
        }

        public async Task DeleteStudentAsync(Guid Id)
        {
            using (var connection = new SqlConnection(_configure.GetConnectionString("Default")))
            {
                connection.Open();

                // Parameterized SQL query for deletion
                var deleteQuery = "DELETE FROM Students WHERE StudentId = @StudentId";

                // Execute the delete query
                await connection.ExecuteAsync(deleteQuery, new { StudentId = Id });
            }
        }

        public async Task<List<Students>> GetAllStudentsAsync()
        {

            var connection = new SqlConnection(_configure.GetConnectionString("Default"));
            var allstudents = await connection.QueryAsync<Students>("Select * from Students");
            return allstudents.ToList();
        }

        public async Task<Students> GetStudentByIdAsync(Guid Id)
        {
            using (var connection = new SqlConnection(_configure.GetConnectionString("Default")))
            {
                connection.Open();
                var response = await connection.QueryFirstOrDefaultAsync<Students>("SELECT * FROM Students WHERE StudentId = @StudentId", new { StudentId = Id });
                return response!;
            }
        }

        public async Task UpdateStudentAsync(Guid Id,Students existingStudent)
        {
            using (var connection = new SqlConnection(_configure.GetConnectionString("Default")))
            {
                connection.Open();
                // Parameterized SQL query for update
                var updateQuery = "UPDATE Students SET FullName = @FullName, Faculty = @Faculty WHERE StudentId = @StudentId";

                // Execute the update query
                await connection.ExecuteAsync(updateQuery, new
                {
                    FullName = existingStudent?.FullName,
                    Faculty = existingStudent?.Faculty,
                    StudentId = Id,
                });
            }
        }
    }
}
