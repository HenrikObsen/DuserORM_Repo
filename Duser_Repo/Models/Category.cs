using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Duser
{
    public class Category
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Sorting { get; set; }
    }
}