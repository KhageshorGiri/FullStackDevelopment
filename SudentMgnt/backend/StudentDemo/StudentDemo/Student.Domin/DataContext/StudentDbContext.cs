using Microsoft.EntityFrameworkCore;
using Student.Entities.Entities;

namespace Student.Domin.DataContext
{
    public class StudentDbContext :DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options)
            : base(options)
        {

        }

        public DbSet<Students> Students { get; set; }
        public DbSet<Enroll> Enrolls { get; set; }
        public DbSet<Courses> Courses { get; set; }
    }
}
