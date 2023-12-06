using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServerSQLite.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Province { get; set; }
        public string? Speciality { get; set; }
        public bool? PublicProfile { get; set; }
        
        [Range(0,Double.PositiveInfinity)]
        public int? Price { get; set; }
        public bool? EverPublicProfile { get; set; }

    }
}