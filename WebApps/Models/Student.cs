using System;
using System.ComponentModel.DataAnnotations;

namespace WebApps.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [StringLength(20), Required]
        public string Name { get; set; }

        [Range(0, 100)]
        public int Mark { get; set; }
    }
}

