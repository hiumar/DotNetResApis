using UserRegistrationForm.Models;

namespace UserRegistrationForm.Interfaces
{
    public interface IUser
    {
        Task<bool> Register(UserRegistration userRegistration);
    }
}
