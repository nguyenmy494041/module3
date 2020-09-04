using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CuaHangQuatNuoc.Models.Products
{
    public class Product
    {
        [Key]
        [Required(ErrorMessage = "Chưa điền mã sản phẩm")]
        [Display(Name = "Mã sản phẩm"), MaxLength(20)]
        public string ProductId { get; set; }


        [Required(ErrorMessage = "Chưa điền tên sản phẩm")]
        [Display(Name ="Tên sản phẩm"), MaxLength(150)]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Chưa chọn loại sản phẩm")]
        [Display(Name = "Loai sản phẩm"), MaxLength(150)]
        public int CategoryId { get; set; }

        public Category category { get; set; }

        [Required(ErrorMessage = "Chưa điền giá sản phẩm")]
        [Display(Name = "Giá sản phẩm"), MaxLength(20)]
        public long Price { get; set; } 

        [Required(ErrorMessage = "Chưa điền thông số kích thước")]
        [Display(Name = "Kích thước"), MaxLength(150)]
        public string Size { get; set; }

        [Display(Name = "Cân nặng")]
        [Required(ErrorMessage = "Chưa điền thông tin cân nặng")]
        public int Weight { get; set; }

        [Display(Name = "Dung tích bình chứa")]
        [Required(ErrorMessage = "Chưa điền dung tích bình chứa")]
        public int TankCapacity { get; set; }

        [Display(Name = "Hãng"), MaxLength(50)]
        [Required(ErrorMessage = "Chưa điền tên hãng sản phẩm")]
        public string Brand { get; set; }

        [Display(Name = "Công suất")]
        [Required(ErrorMessage = "Chưa điền công suất")]
        public int Wattage { get; set; }

        [Display(Name = "Tiện ích"), MaxLength(300)]
        [Required(ErrorMessage = "Chưa điền thông tin tiện ích")]
        public string Utilities { get; set; }

        [Display(Name = "Thương hiệu của"), MaxLength(100)]
        [Required(ErrorMessage = "Chưa điền thông tin ")]
        public string Manufactures { get; set; }

        [Display(Name = "Sản xuất tại"), MaxLength(50)]
        [Required(ErrorMessage = "Chưa điền nơi sản xuất")]
        public string MadeIn { get; set; }

        [Display(Name = "Năm ra mắt")]
        [Required(ErrorMessage = "Chưa điền năm ra mắt")]
        [DataType(DataType.Date)]
        public DateTime Year { get; set; }

        [Display(Name = "Mô tả sản phẩm"), MaxLength(10000000)]
        [Required(ErrorMessage = "Chưa mô tả về sản phẩm")]
        public string Description { get; set; }

        public Specification specification { get; set; }

        public List<Image> images { get; set; }


    }
}
