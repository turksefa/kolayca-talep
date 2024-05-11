using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Dtos
{
    public class ProductCategoryDto
    {
        public int ProductCategoryId { get; set; }
        [Required]
        [MaxLength(100)]
        public string ProductCategoryName { get; set; } = string.Empty;
    }
}
