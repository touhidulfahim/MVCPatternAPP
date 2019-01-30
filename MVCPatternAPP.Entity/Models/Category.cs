using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPatternAPP.Entity.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string CategoryName { get; set; }

        public string Description { get; set; }

    }
}
