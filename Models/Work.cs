using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



namespace ApiWorks.Models
{
    public class Work
    {
        public int Id {get;set;}
        [Required]
        public string Name {get;set;}
        [Required]
        public bool Concluded {get;set;}
        public DateTime CreateAt {get;set;}
        public DateTime UpdateAt {get;set;}
    }
}