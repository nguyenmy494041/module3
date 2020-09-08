﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BaiTapLon.Models.ProductManagement
{
    public class Product
    {
        [Key]
        [Required(ErrorMessage = "Chưa điền mã sản phẩm")]
        [Display(Name = "Mã sản phẩm"), MaxLength(20)]
        public string ProductId { get; set; }


        [Required(ErrorMessage = "Chưa điền tên sản phẩm")]
        [Display(Name = "Tên sản phẩm"), MaxLength(150)]
        public string ProductName { get; set; }


        [Required(ErrorMessage = "Chưa điền giá sản phẩm")]
        [Display(Name = "Giá sản phẩm"), MaxLength(20)]
        public long ProductPrice { get; set; }

        [Required(ErrorMessage = "Chưa điền thông số kích thước")]
        [Display(Name = "Kích thước"), MaxLength(150)]
        public string Size { get; set; }

        [Display(Name = "Cân nặng")]
        [Required(ErrorMessage = "Chưa điền thông tin cân nặng")]
        public float Weight { get; set; }

        [Display(Name = "Dung tích bình chứa")]
        [Required(ErrorMessage = "Chưa điền dung tích bình chứa")]
        public int TankCapacity { get; set; }

        [Display(Name = "Hãng"), MaxLength(50)]
        [Required(ErrorMessage = "Chưa điền tên hãng sản phẩm")]
        public string Brand { get; set; }

        [Display(Name = "Công suất")]
        [Required(ErrorMessage = "Chưa điền công suất")]
        public int Wattage { get; set; }

        [Display(Name = "Tiện ích"), MaxLength(500)]
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

        public int Year { get; set; }

        [Display(Name = "Mô tả sản phẩm"), MaxLength(5000)]
        [Required(ErrorMessage = "Chưa mô tả về sản phẩm")]
        public string Description { get; set; }

        public Specification Specification { get; set; }

        [Required]
        [ForeignKey("Categories")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<Image> Images { get; set; }

    }
}
