using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CuaHangQuatNuoc.Models.Products
{
    public class Image
    {

        [Key]
        public int Id { get; set; }


        [Display(Name = "Mã sản phẩm"), MaxLength(20)]
        [ForeignKey("Products")]
        public string ProductId { get; set; }

        [Required, MaxLength(100)]
        public string ImageProduct { get; set; }

        public virtual Product product { get; set; }
    }
}
