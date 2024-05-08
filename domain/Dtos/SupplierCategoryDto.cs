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
        [Required]
        [MaxLength(100)]
        public string SupplierCategoryName { get; set; } = string.Empty;
    }
}
