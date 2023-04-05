using StudentAdminPortalAPI.DataModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentAdminPortalAPI.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudentsAsync();
        Task<Student> GetStudentAsync(Guid student);
        Task<bool> Exists(Guid studentId);
        Task<Student> UpdateStudent(Guid studentId, Student student);

        Task<List<Gender>> GetGendersAsync();
    }
}
