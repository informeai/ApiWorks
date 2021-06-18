using System;
using System.Collections.Generic;
using ApiWorks.Models;

namespace ApiWorks.Interfaces
{
    public interface IWork
    {
        List<Work> GetAll();
        Work Get(int id);
        Work Create(Work work);
        Work Update(int id);
        bool Delete(int id);

    }
}