using Data.DbContexts;
using Data.Entities;
using Data.Interfaces;
using System;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly AFIContext _context;

        public UserRepository(AFIContext context)
        {
            _context = context;
        }

        public async Task<int> CreateUser(string forename, string surname, DateTime? dob, string email, string referenceNumber)
        {
            var entity = new Users
            {
                Forename = forename,
                Surname = surname,
                Email = email,
                DateOfBirth = dob,
                ReferenceNumber = referenceNumber
            };

            await _context.AddAsync(entity);

            await _context.SaveChangesAsync();

            return entity.Id;
        }
    }
}
