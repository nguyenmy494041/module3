using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CuaHangQuatMay.Models.ProductModel
{
    public class SteamFan:Product
    {
       
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Chức năng")]
        public string Dynamic { get; set; }
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Tốc độ gió")]
        public string WindSpeed { get; set; }
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Chế độ gió")]
        public string WindMode { get; set; }
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Điều khiển")]
        public string Control { get; set; }
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Phạm vi làm mát")]
        public string CollingRange { get; set; }
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Mức độ ồn")]
        public string NoiseLevel { get; set; }
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Lưu lượng gió")]
        public int WindFlow { get; set; }
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Loại lồng quạt")]
        public string FanCageType { get; set; }
       
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Mức tiêu thụ nước")]
        public string WaterConsumption { get; set; }
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Dung tích bình chứa")]
        public int TankCapacity { get; set; }
       
       
    }
}
