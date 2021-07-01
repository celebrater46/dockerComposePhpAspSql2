﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTest.Models
{
    public class Employee
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        public int Age { get; set; }

        public DateTime HireDate { get; set; }


    }
}
