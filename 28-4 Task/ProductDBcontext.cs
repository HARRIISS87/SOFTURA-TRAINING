using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFcore2.Models
{
    public class ProductDBcontext:DbContext
    {
        public ProductDBcontext()
        {

        }
        public ProductDBcontext(DbContextOptions<ProductDBcontext> options):base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=HARIS;Initial Catalog=HARIS;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
        }
        public virtual DbSet<Product> Products { get; set; }
        
    }
}
