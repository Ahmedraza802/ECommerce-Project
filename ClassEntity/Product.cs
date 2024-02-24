using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ClassEntity
{
    public class Product:BaseEntity
    {
        [Required]
        public decimal Price { get; set; }
        public Category category { get; set; }

    }
}
