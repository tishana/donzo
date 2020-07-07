using System.Collections.Generic;
using System.Threading.Tasks;
using DonzoApp.API.Models;

namespace DonzoApp.API.Data
{
    public interface IUserRepository
    {
        void Add<T>(T entity) where T : class; //add a User or a Workout
        void Delete<T>(T entity) where T : class; // remove a User or a Workout
        Task<bool> SaveAll(); // either 0 changes OR more than 0 changes to save to db
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);
    }
}