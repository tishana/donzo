using System.Threading.Tasks;
using DonzoApp.API.Models;

namespace DonzoApp.API.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password); // registering the user

        Task<User> Login(string username, string password);// metheod for user to login to API

        Task<bool> UserExists(string username);// check if does user exist
    }
}