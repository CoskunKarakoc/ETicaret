using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abc.Nrtwnd.Entities.Concrete;

namespace Abc.Nrtwnd.DataAccessLayer.Concrete.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext() : base("NorthwindContext")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
