using System;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IUserRepository
    {
        Task<int> CreateUser(string forename, string surname, DateTime? dob, string email, string referenceNumber, bool online);
    }
}