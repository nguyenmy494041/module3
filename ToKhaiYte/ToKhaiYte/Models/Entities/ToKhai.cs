using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToKhaiYte.Models.Entities
{
    public class ToKhai
    {
        [Key ]        
        public int ToKhaiId { get; set; }

        [Required(ErrorMessage = "Chưa điện họ tên")]
        [Display(Name = "Năm sinh"),MaxLength(100)]
        public string Hoten { get; set; }

        [Required(ErrorMessage = "Chưa chọn năm sinh")]
        [Display(Name = "Năm sinh")]
        public int Namsinh { get; set; }
        [Required(ErrorMessage = "Chưa chọn giới tính")]
        [Display(Name = "Giới tính"), MaxLength(50)]
        public string Gioitinh { get; set; }
        [Required(ErrorMessage = "Chưa chọn quốc tịch")]
        [Display(Name = "Quốc tịch")]
        public int Quoctich { get; set; }
        [Required(ErrorMessage = "Chưa điền thông tin")]
        [Display(Name = "Số CMND"),MaxLength(200)]
        public string SoCMND { get; set; }   



        [Required]
        [ForeignKey("CuaKhau")]
        public int CuaKhauId { get; set; }
        public CuaKhau CuaKhau { get; set; }

        public DiaChi DiaChi { get; set; }

        public DiLai DiLai { get; set; }
       
        public SucKhoe SucKhoe { get; set; }

    }
}
