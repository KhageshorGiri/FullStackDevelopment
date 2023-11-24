using Student.Application.Interfaces.RepositoryInterfaces;
using Student.Entities.Entities;

namespace Student.Domin.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public Task AddStudentAsync(Students student)
        {
            throw new NotImplementedException();
        }

        public Task DeleteStudentAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Students>> GetAllStudentsAsync()
        {

            // Create a list of Student with temporary data
            List<Students> studentList = new List<Students>
                {
                    new Students
                    {
                        StudentId = Guid.NewGuid(),
                        FullName = "John Doe",
                        Faculty = "Computer Science"
                    },
                    new Students
                    {
                        StudentId = Guid.NewGuid(),
                        FullName = "Jane Doe",
                        Faculty = "Mathematics"
                    },
                    // Add more students as needed
                };
            return Task.FromResult(studentList);
        }

        public Task<Students> GetStudentByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateStudentAsync(Students student)
        {
            throw new NotImplementedException();
        }
    }
}
