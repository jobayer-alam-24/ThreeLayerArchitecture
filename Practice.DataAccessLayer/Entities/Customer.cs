using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.DataAccessLayer.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        [Display(Name = "Customer Name"), Required(ErrorMessage = "Name is Required.")]
        public string Name { get; set; }
    }
}
