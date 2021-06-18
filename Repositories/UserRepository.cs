using System.Linq;
using System.Collections.Generic;
using ApiWorks.Repositories.Context;
using ApiWorks.Interfaces;
using ApiWorks.Models;

namespace ApiWorks.Repositories
{
    public class UserRepository: IUser
    {
        public static ApiContext context = new ApiContext();
        public List<User> GetAll()
        {
            // Get all users
            return new List<User>();
        }
        public User Get(int id)
        {
            // Get user with id from database
            return new User();
        }
        public User Create(User user)
        {
            // Create user
            context.Users.Add(user);
            context.SaveChanges();
            
            return user;

        }
        public User Update(int id)
        {
            // Update user
            return new User();
        }
        public bool Delete(int id)
        {
            // Delete user
            return true;
        }
    }
}