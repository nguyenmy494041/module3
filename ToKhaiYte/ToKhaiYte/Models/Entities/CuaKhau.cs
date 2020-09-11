using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToKhaiYte.Models.Entities
{
    public class CuaKhau
    {
        [Key]
        public int CuaKhauId { get; set; }


        [Required(ErrorMessage = "Chưa chọn cửa khẩu")]
        [Display(Name = "Tên cửa khẩu"), MaxLength(100)]
        public string TenCuaKhau { get; set; }

        public List<ToKhai> ToKhais { get; set; }
    }
}
