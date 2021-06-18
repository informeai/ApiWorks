using System;
using System.Text;
using System.Text.Json;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ApiWorks.Repositories;
using ApiWorks.Models;

namespace ApiWorks.Controllers
{
    [ApiController]
    [Route("/v1/users")]
    public class UserController: ControllerBase
    {
        [HttpGet]
        public string GetAll(string data)
        {
            // Get all users from repository
            return "all user";
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            // Get user with id from repository
            return $"get user id: {id}";
        }
        [HttpPost("new")]
        public ActionResult<User> Create([FromBody]JsonElement data)
        {
            // Create new user
            
            if(data.TryGetProperty("name", out var name) && data.TryGetProperty("password", out var password)){
                User user = new User();
                user.Name = data.GetProperty("name").ToString();
                user.Password = data.GetProperty("password").ToString();
                user.CreateAt = DateTime.Now;
                // Set in repository
                UserRepository createUser = new UserRepository();
                User newUser = createUser.Create(user);
                return newUser;

                
            }else{
            return new User();
            }
            
        }
        [HttpPut("{id}")]
        public string Update(int id,string data)
        {
            // Update user
            return "update user";
        }
        [HttpDelete("{id}")]
        public string Delete(string data)
        {
            // Delete user
            return "delete user";
        }
    }
}