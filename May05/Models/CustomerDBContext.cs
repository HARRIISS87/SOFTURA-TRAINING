using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ADOdotNet.Models
{
    public class CustomerDBContext:DbContext
    {
        public CustomerDBContext()
        {

        }

        public CustomerDBContext(DbContextOptions<CustomerDBContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=HARIS;Initial Catalog=HARIS;Integrated Security=True;");
        }

        public virtual DbSet<Customer> Customers { get; set; }
    }
}
