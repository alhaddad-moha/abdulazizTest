using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }

        [Required]
        [DisplayName("Name: ")]
        public String name{ get; set; }
        [Range(1,10)]
        public int displayOrder { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
