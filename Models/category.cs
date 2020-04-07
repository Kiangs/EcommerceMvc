using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApp.Models
{
     public class Category
    {
       public int CategoryId   { get; set; }
       public string CategoryName { get; set; }
       public bool IsActive     { get; set; }
       public bool IsDelete     { get; set; }
       public ICollection<Product> Products { get; set; }
    }
}
