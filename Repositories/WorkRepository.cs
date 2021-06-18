using System;
using System.Linq;
using System.Collections.Generic;
using ApiWorks.Repositories.Context;
using ApiWorks.Interfaces;
using ApiWorks.Models;

namespace ApiWorks.Repositories
{
    public class WorkRepository: IWork
    {
        public static ApiContext context = new ApiContext();
        public List<Work> GetAll()
        {
            // Get all works
            try
            {

                var works = context.Works.ToList<Work>();
                if(works.Count > 0 && works != null){
                    return works;
                }
                    
                
            }
            catch(Exception e)
            {
                Console.WriteLine($"error: {e}");
            }
            
            return new List<Work>();
        }
        public Work Get(int id)
        {
            // Get work with id from database
            try
            {
                
            }
            catch(Exception e)
            {
                Console.WriteLine($"Error -> {e}");
            }
            return new Work();

        }
        public Work Create(Work work)
        {
            // Create work
            try
            {

            }
            catch(Exception e)
            {
                Console.WriteLine($"Error -> {e}");
            }
            return new Work();
        }
        public Work Update(int id)
        {
            // Update work
            try
            {

            }
            catch(Exception e)
            {
                Console.WriteLine($"Error -> {e}");
            }
            return new Work();
        }
        public bool Delete(int id)
        {
            // Delete work
            try
            {

            }
            catch(Exception e)
            {
                Console.WriteLine($"Error -> {e}");
            }
            return true;
        }
    }
}