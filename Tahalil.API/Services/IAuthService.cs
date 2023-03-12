using Tahalil.Models;

namespace Tahalil.API.Services
{
    public interface IAuthService
    {
        public Task<ServiceResponse<int>> Register(User user, string password);
        public Task<bool> UserExists(string email);
        public Task<ServiceResponse<string>> LogIn(string email, string password);
        public Task<ServiceResponse<bool>> ChangePassword(int userId, string newPassword);
        public int GetUserId();
    }
}