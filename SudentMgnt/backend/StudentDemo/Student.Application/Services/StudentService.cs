﻿using Student.Application.Interfaces.ServiceInterfaces;
using Student.Entities.Entities;

namespace Student.Application.Services
{
    public class StudentService : IStudentRepository
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
            throw new NotImplementedException();
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
