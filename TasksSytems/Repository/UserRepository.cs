using Microsoft.EntityFrameworkCore;
using TasksSytems.Data;
using TasksSytems.Models;
using TasksSytems.Repository.Interface ;

namespace TasksSytems.Repository
{
    public class UserRepository : Interface.IUserRepository
    {
        private readonly TasksSystemsDBContext _dbContext;

        public UserRepository(TasksSystemsDBContext tasksSystemsDBContext) {
            
            _dbContext = tasksSystemsDBContext;
        }

        public async Task<UserModel> Add(UserModel user)
        {
             _dbContext.Users.Add(user);
             _dbContext.SaveChangesAsync();

            return user;
        }

        public async Task<bool> Delete(int id)
        {
            UserModel userById = await SearchById(id);

            if (userById == null)
            {
                throw new Exception($"User by ID: {id} not found in data base.");
            }

            _dbContext.Users.Remove(userById);
            _dbContext.SaveChanges();
            return true;
        }

        public async Task<List<UserModel>> SearchAllUsers()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<UserModel> SearchById(int id)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<UserModel> Update(UserModel user, int id)
        {
            UserModel userById = await SearchById(id);

            if (userById == null)
            {
                throw new Exception($"User by ID: {id} not found in data base.");
            }

            userById.Name = user.Name;
            userById.Email = user.Email;

            _dbContext.Users.Update(userById);
            _dbContext.SaveChangesAsync();

            return userById;
        }
    }
}
