using Business.Models;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IUserService
    {
        Task<int> CreateUser(UserModel model, bool online = true);
    }
}