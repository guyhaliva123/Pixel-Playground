﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ShopWeb.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Required]
        public int Name { get; set; }
        public string? StreetAdress{ get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
    }
}
