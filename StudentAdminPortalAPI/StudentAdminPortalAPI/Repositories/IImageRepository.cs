using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace StudentAdminPortalAPI.Repositories
{
    public interface IImageRepository
    {
        Task<string> Upload(IFormFile file, string fileName);
    }
}
