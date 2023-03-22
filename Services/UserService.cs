using Microsoft.EntityFrameworkCore;
using UserRegistrationForm.Configuration;
using UserRegistrationForm.Interfaces;
using UserRegistrationForm.Models;

namespace UserRegistrationForm.Services
{
    public class UserService : IUser
    {
        private readonly DbContextModel _dbContext;
        public UserService(DbContextModel dbContext)
        {
            _dbContext= dbContext;
        }
        public  async Task<bool> Register(UserRegistration userRegistration)
        {
            await _dbContext.Users.AddAsync(userRegistration);
           return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}
