using ClassEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Context
{
    public class ClassContext :DbContext
    {
        public ClassContext():base("DefaultConnection")
        {
                
        }
        public DbSet<Product> Products  { get; set; }
        public DbSet<Category> categories  { get; set; }
    }
}
