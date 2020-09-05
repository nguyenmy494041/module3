using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CuaHangQuatNuoc.Models.Products
{
    public class SteamFan: Product
    {
        [Required(ErrorMessage ="Chưa điền dữ liệu")]
        [Display(Name = "Chức năng"), MaxLength(200)]
        public string Dynamic { get; set; }

        [Display(Name = "Tốc độ gió"), MaxLength(200)]
        [Required(ErrorMessage = "Chưa điền dữ liệu")]
        public string WindSpeed { get; set; }

        [Display(Name = "Chế độ gió"), MaxLength(150)]
        [Required(ErrorMessage = "Chưa điền dữ liệu")]
        public string WindMode { get; set; }

        [Display(Name = "Điều khiển"), MaxLength(200)]
        [Required(ErrorMessage = "Chưa điền dữ liệu")]
        public string Control { get; set; }

        [Display(Name = "Phạm vi làm mát"), MaxLength(200)]
        [Required(ErrorMessage = "Chưa điền dữ liệu")]
        public string CollingRange { get; set; }

        [Display(Name = "Lưu lượng gió")]
        [Required(ErrorMessage = "Chưa điền dữ liệu")]
        public Nullable<int> WindFlow { get; set; }

        [Display(Name = "Loại lồng quạt"), MaxLength(100)]
        [Required(ErrorMessage = "Chưa điền dữ liệu")]
        public string FanCageType { get; set; }

        [Display(Name = "Độ ồn"), MaxLength(100)]
        [Required(ErrorMessage = "Chưa điền dữ liệu")]
        public string Noiselevel { get; set; }

        [Display(Name = "Mức tiêu thụ nước"), MaxLength(200)]
        public string WaterConsumption { get; set; }
    }
}
