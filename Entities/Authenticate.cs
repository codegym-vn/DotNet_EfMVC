﻿ 
using System.ComponentModel.DataAnnotations;
 

namespace ProductManagement.Entities
{
    public class Authenticate
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
