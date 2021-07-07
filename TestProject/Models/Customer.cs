using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestProject.Models
{
    public enum Gender
    {
        Male,Female
    }
    public class Customer
    {
        
        public int Id { get; set; }

        [Required]
        public string  Name { get; set; }

        public string  Email { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]

        public DateTime Dob { get; set; }

        public string gender { get; set; }

        
    }
}