using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



namespace ApiWorks.Models
{
    public class User
    {
        public int Id {get;set;}
        [Required]
        public string Name {get;set;}
        [Required]
        public string Password {get;set;}
        public string Token {get;set;}
        public DateTime CreateAt {get;set;}
        public DateTime UpdateAt {get;set;}
    }
}