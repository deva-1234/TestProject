using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace TestProject.Models
{
    public class CustomerContext:DbContext

    {
        public CustomerContext():base()
        {

        }

        public  DbSet<Customer> customers { get; set; }
        public  DbSet<Address> Addresses { get; set; }

    }
}