using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CuaHangQuatMay.Models.ProductModel
{
    public class Product
    {
        [Required(ErrorMessage = "Đây là trường bắt buộc"),MaxLength(15)]
        [Display(Name = "Mã sản phẩm")]
        public string ProductId { get; set; }
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [MaxLength(300, ErrorMessage = "Fullname maximum 300 characters")]
        [Display(Name = "Tên sản phẩm")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Giá sản phẩm")]
        public long ProductPrice { get; set; }
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Tiện ích")]
        public string Utilities { get; set; }
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name ="Thương hiệu")]
        public string Brand { get; set; }
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Công suất")]
        public int Wattage { get; set; }
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Kích thước")]
        public string Size { get; set; }
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Trọng lượng")]
        public int Weight { get; set; }
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Nơi sản xuất")]
        public string Manufacturer { get; set; }
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public string ImageProduct { get; set; }
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public string ImageDetail { get; set; }

    }
}
