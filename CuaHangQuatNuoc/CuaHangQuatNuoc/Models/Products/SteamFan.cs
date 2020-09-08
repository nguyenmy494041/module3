using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CuaHangQuatNuoc.Models.Products
{
    public class SteamFan
    {
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

        public int CategoryId { get; set; }
     


        [Display(Name = "Chức năng"), MaxLength(200)]
        public string Dynamic { get; set; }

        [Display(Name = "Tốc độ gió"), MaxLength(200)]
        public string WindSpeed { get; set; }

        [Display(Name = "Chế độ gió"), MaxLength(150)]
        public string WindMode { get; set; }

        [Display(Name = "Điều khiển"), MaxLength(200)]
        public string Control { get; set; }

        [Display(Name = "Phạm vi làm mát"), MaxLength(200)]
        public string CollingRange { get; set; }

        [Display(Name = "Lưu lượng gió")]
        public Nullable<int> WindFlow { get; set; }

        [Display(Name = "Loại lồng quạt"), MaxLength(100)]
        public string FanCageType { get; set; }

        [Display(Name = "Độ ồn"), MaxLength(100)]
        public string Noiselevel { get; set; }

        [Display(Name = "Mức tiêu thụ nước"), MaxLength(200)]
        public string WaterConsumption { get; set; }

        [Display(Name = "Kiểu máy"), MaxLength(150)]
        public string MachineModel { get; set; }

        [Display(Name = "Công nghệ lọc"), MaxLength(200)]
        public string FilterTechnology { get; set; }

        [Display(Name = "Số lượng lõi lọc")]
        public Nullable<int> NumberFilterCores { get; set; }

        [Display(Name = "Công suất lọc nước")]
        public Nullable<int> FilterCapacity { get; set; }

        [Display(Name = "Hệ thống bơm"), MaxLength(200)]
        public string Pumping { get; set; }


        [Display(Name = "Chế độ an toàn"), MaxLength(200)]
        public string Safemode { get; set; }


        [Display(Name = "Tùy chỉnh nhiệt độ"), MaxLength(100)]
        public string Temperature { get; set; }


        [Display(Name = "Áp lực nước")]
        public Nullable<float> WaterPressure { get; set; }

        [Display(Name = "Thời gian đun nóng")]
        public Nullable<int> WarmUpTime { get; set; }

        [Display(Name = "Nhiệt độ tối đa")]
        public Nullable<int> MaxTemperature { get; set; }
    }
}
