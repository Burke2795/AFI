using Business.Interfaces;
using Business.Models;
using Data.Interfaces;
using System;
using System.Threading.Tasks;

namespace Business.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<int> CreateUser(UserModel model)
        {
            var referenceNumber = GenerateReferenceNumber();

            return await _userRepository.CreateUser(model.Forename, model.Surname, model.DateofBirth, model.Email, referenceNumber);
        }

        private string GenerateReferenceNumber()
        {
            var numberSection = GenerateRandomNumbers(6);

            return $"{GenerateRandomCharacter()}{GenerateRandomCharacter()}-{numberSection}";
        }

        private string GenerateRandomNumbers(int length)
        {
            var randomyNumber = new Random();
            return randomyNumber.Next(0, 1000000).ToString($"D{length}");
        }

        private char GenerateRandomCharacter()
        {
            var rnd = new Random();
            var character = (char)rnd.Next('a', 'z');
            return char.ToUpper(character);
        }
    }
}
