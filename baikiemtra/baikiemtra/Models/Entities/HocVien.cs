using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace baikiemtra.Models.Entities
{
    public class HocVien
    {
        [Key]
        public int MaHocVien { get; set; }
        [Required(ErrorMessage = "Chưa điền họ tên")]
        [Display(Name = "Họ và tên"), MaxLength(100)]
        public string HoTen { get; set; }
        [Required(ErrorMessage = "Chưa điền ngày sinh")]
        [Display(Name = "Ngày sinh")]
        public DateTime Ngaysinh { get; set; }
        [Required(ErrorMessage = "Chưa điền họ tên")]
        [Display(Name = "Giới tính"), MaxLength(20)]
        public string GioiTinh { get; set; }
        [Required(ErrorMessage = "Chưa điền họ tên")]
        [Display(Name = "Email"), MaxLength(100)]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        [ForeignKey("LopHocs")]
        public int MaLop { get; set; }
        public LopHoc Lophoc { get; set; }
    }
}
