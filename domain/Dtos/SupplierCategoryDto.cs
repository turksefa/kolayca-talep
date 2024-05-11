using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Dtos
{
    public class SupplierCategoryDto
    {
        public int SupplierCategoryId { get; set; }
        [Required]
        [MaxLength(100)]
        public string SupplierCategoryName { get; set; } = string.Empty;
    }
}
