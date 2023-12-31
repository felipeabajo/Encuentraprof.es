﻿using Microsoft.AspNetCore.Identity;
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
        [ProtectedPersonalData]
        [Required]
        public string? Firstname { get; set; }

        [ProtectedPersonalData]
        public string? Lastname { get; set; }

        [ProtectedPersonalData]
        [Required]
        public string? Province { get; set; }

        [Required]
        public string? Speciality { get; set; }
        public bool? PublicProfile { get; set; }

        [Required]
        [Range(0,Double.PositiveInfinity)]
        public int? Price { get; set; }
        public bool? EverPublicProfile { get; set; }
    }
}