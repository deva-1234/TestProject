using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestProject.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string Addrss { get; set; }
        public string  City { get; set; }
        public string state { get; set; }
        public int Pincode { get; set; }
        
        

        
    }
}