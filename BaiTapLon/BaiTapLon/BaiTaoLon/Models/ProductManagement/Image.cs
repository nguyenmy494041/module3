using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BaiTapLon.Models.ProductManagement
{
    public class Image
    {

        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string ImageName { get; set; }
        [Required]
        [ForeignKey("Products")]
        public string ProductId { get; set; }
        public Product Product { get; set; }
    }
}
