using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using api.models.Vadilations;

namespace api
{
    public class Shirt
    {
        public int ShirtID { get; set; }
        [Required]
        public string? Brand { get; set; }
        [Required]
        public string? Color { get; set; }  
        [Shirt_EnsureCorrectSizing]
        public int Size { get; set; }
        [Required]
        public string? Gender { get; set; }
        public double Price { get; set; }
    }
}