using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using ApiWorks.Models;

namespace ApiWorks.Repositories.Context
{
    public class ApiContext: DbContext
    {
        public DbSet<User> Users {get;set;}
        public DbSet<Work> Works {get;set;}

        private IConfiguration _configuration {get; set;}

        public ApiContext(IConfiguration configuration)
        {
            _configuration = configuration; 
        }
        public ApiContext()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlite(_configuration.GetSection("ConnectionStrings").GetValue<string>("ApiConnection"));

        }
    }
}