using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CuaHangQuatNuoc.Models.Products
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }


        [Required(ErrorMessage = "Chưa chọn tên loại hàng")]
        [Display(Name = "Tên loại hàng"), MaxLength(150)]
        public string CategoryName { get; set; }

        public virtual List<Product> products { get; set; }

        public Category()
        {
            this.products = new List<Product>();
        }

    }
}
