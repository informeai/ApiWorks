using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ApiWorks.Repositories;
using ApiWorks.Models;

namespace ApiWorks.Controllers
{
    [ApiController]
    [Route("v1/works")]
    public class WorkController: ControllerBase
    {
        
        [HttpGet("all")]
        public ActionResult<List<Work>> GetAll()
        {
            WorkRepository works = new WorkRepository();
            // Get all works from database
            return works.GetAll();
            
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            // Get work with id from repository
            return $"Get work id: {id}";
        }
        [HttpPost("new")]
        public string Create(string data)
        {
            // Create new work
            Console.WriteLine(data);
            return "create work";
        }
        [HttpPut("{id}")]
        public string Update(int id,string data)
        {
            // Update work
            return "update work";
        }
        [HttpDelete("{id}")]
        public string Delete(string data)
        {
            // Delete work
            return "delete work";
        }
    }
}