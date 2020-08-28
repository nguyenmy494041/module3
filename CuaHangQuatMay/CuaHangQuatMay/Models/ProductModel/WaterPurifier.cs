using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CuaHangQuatMay.Models.ProductModel
{
    public class WaterPurifier:Product
    {
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Kiểu máy")]
        public string MachineModel { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Công nghệ lọc")]
        public string FilterTechnology { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Số lượng lõi lọc")]
        public string NumberFilterCores { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Dung tích bình chứa")]
        public string TankCapacity { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Công suất lọc nước")]
        public string WaterFiltrationCapacity { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Hệ thống bơm")]
        public string PumpingSystem { get; set; }
    }
}
