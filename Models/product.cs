using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApp.Models
{
    public class Product
    {
       public int ProductId   { get; set; }
       public string  ProductName { get; set; }
       public int  CategoryId  { get; set; }
       public bool  IsActive    { get; set; }
       public bool  IsDelete    { get; set; }
       public DateTime  CreatedDate { get; set; }
       public DateTime  ModifiedDate{ get; set; }
       public string  Description { get; set; }
       public byte[]  ProductImage{ get; set; }
       public bool  IsFeatured  { get; set; }
       public int  Quantity    { get; set; }
       public virtual Category Category  { get; set; }


    }
}
