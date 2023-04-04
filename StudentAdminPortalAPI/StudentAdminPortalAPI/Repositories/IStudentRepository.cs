using StudentAdminPortalAPI.DataModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentAdminPortalAPI.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudentsAsync();
    }
}
