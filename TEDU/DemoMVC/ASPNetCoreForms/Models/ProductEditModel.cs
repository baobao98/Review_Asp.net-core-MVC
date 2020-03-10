using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreForms.Models
{
    public class ProductEditModel
    {
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public int Rating { get; set; }
    }
}
