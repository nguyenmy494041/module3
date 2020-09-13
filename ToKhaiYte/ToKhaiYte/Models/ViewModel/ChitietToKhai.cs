using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToKhaiYte.Models.ViewModel
{
    public class ChitietToKhai
    {
        public int STT { get; set; }
        [Display(Name = "Cửa khẩu"), MaxLength(100)]
        public string TenCuaKhau { get; set; }
        [Required(ErrorMessage = "Chưa điện họ tên")]
        [Display(Name = "Năm sinh"), MaxLength(100)]
        public string Hoten { get; set; }

        [Required(ErrorMessage = "Chưa chọn năm sinh")]
        [Display(Name = "Năm sinh")]
        public int Namsinh { get; set; }
        [Required(ErrorMessage = "Chưa chọn giới tính")]
        [Display(Name = "Giới tính"), MaxLength(50)]
        public string Gioitinh { get; set; }
        [Required(ErrorMessage = "Chưa chọn quốc tịch")]
        [Display(Name = "Quốc tịch")]
        public string Quoctich { get; set; }
        [Required(ErrorMessage = "Chưa điền thông tin")]
        [Display(Name = "Số CMND"), MaxLength(200)]
        public string SoCMND { get; set; }
        public bool Ho { get; set; }
        [Required]
        public bool Sot { get; set; }
        [Required]
        public bool KhoTho { get; set; }
        [Required]
        public bool DauHong { get; set; }
        [Required]
        public bool BuonNon { get; set; }
        [Required]
        public bool TieuChay { get; set; }
        [Required]
        public bool XuatHuyetNgoaiDa { get; set; }
        [Required]
        public bool NoiBanNgoaiDa { get; set; }
        [Required, MaxLength(200)]
        public string DanhSachVacxin { get; set; }
        [Required]
        public bool TiepXucDongVat { get; set; }
        [Required]
        public bool TiepXucNguoiBenh { get; set; }
        [Required, MaxLength(300)]
        public string PhuongTienDiLai { get; set; }
        [Required, MaxLength(100)]
        public string SoHieuPhuongTien { get; set; }
        [Required, MaxLength(50)]
        public string SoGhe { get; set; }
        [Required]
        public DateTime NgayKhoiHanh { get; set; }
        [Required]
        public DateTime NgayNhapCanh { get; set; }
        [Required]
        public int QuocGiaKhoiHanh { get; set; }
        [Required, MaxLength(100)]
        public string TinhKhoiHanh { get; set; }
        [Required]
        public int QuocGiaDen { get; set; }
        [Required]
        public string TinhDen { get; set; }
        [Required, MaxLength(500)]
        public string NoiTungDen { get; set; }
        [Required]       
        public string TinhThanh { get; set; }
     
        [Required]

        public string QuanHuyen { get; set; }

        [Required]

        public string PhuongXa{ get; set; }


        [Required, MaxLength(150)]
        public string SoNha { get; set; }
        [Required, MaxLength(13)]
        public string SoDienThoai { get; set; }
        [MaxLength(150)]
        [EmailAddress]
        public string Email { get; set; }
    }
}
