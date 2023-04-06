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
        Task<Student> UpdateStudent(Guid studentId, Student request);
        Task<Student> DeleteStudentAsync(Guid studentId);
        Task<Student> AddStudent(Student request);

        Task<List<Gender>> GetGendersAsync();
        Task<bool> UpdateProfileImage(Guid studentId, string profileImageUrl);
    }
}
