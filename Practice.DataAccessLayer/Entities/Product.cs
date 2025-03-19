using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.DataAccessLayer.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required"), Display(Name = "Product Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is Required"), Display(Name = "Product Description")]
        public string Description { get; set; }
    }
}
