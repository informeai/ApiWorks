using System;
using System.Collections.Generic;
using ApiWorks.Models;

namespace ApiWorks.Interfaces
{
    public interface IUser
    {
        List<User> GetAll();
        User Get(int id);
        User Create(User user);
        User Update(int id);
        bool Delete(int id);

    }
}