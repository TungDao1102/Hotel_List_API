﻿using System.ComponentModel.DataAnnotations;

namespace Hotel_List_API.Configuration.Models.User
{
    public class ApiUserDTO : LoginDTO
    {
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }
        
       
    }
}
