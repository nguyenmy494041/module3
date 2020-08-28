using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CuaHangQuatMay.Models.ProductModel
{
    public class ElectricFan:Product
    {
      
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Chức năng")]
        public string Dynamic { get; set; }
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Đường kính cánh quạt")]
        public string ImpellerDiameter { get; set; }
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Số cánh quạt")]
        public string NumberPropellers { get; set; }
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Tốc độ gió")]
        public string WindSpeed { get; set; }
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Chế độ gió")]
        public string WindMode { get; set; }
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Loại motor ")]
        public string MotorType { get; set; }
       
        
    }
}
