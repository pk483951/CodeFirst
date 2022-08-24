using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data.Entity;

namespace CodeFirst.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        [Required(ErrorMessage ="Product Name is Required")]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "CategoryId is Required")]
        public string CategoryId { get; set; }
        [Required(ErrorMessage = "Category Name is Required")]
        [DisplayName("Category Name")]
        public string CategoryName { get; set; }
    }
    public class EFCodeFirstEntieis : DbContext
    {
        public DbSet<Products>products { get; set; }
    }
}