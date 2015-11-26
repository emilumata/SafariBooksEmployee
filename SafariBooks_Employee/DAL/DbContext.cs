using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SafariBooks_Employee.Models;


namespace SafariBooks_Employee.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("MyDBConnection")
        { }

        public System.Data.Entity.DbSet<SafariBooks_Employee.Models.ManageCustomers> Customers { get; set; }

        public System.Data.Entity.DbSet<SafariBooks_Employee.Models.Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<SafariBooks_Employee.Models.Book> Books { get; set; }

        public System.Data.Entity.DbSet<SafariBooks_Employee.Models.Login> Logins { get; set; }
    }
}