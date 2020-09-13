using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ToKhaiYte.Models.Entities;

namespace ToKhaiYte.Models.ViewModel
{
    public class DangKyToKhai
    {
        [Required]
        public int CuaKhauId { get; set; }
        [Required]
        [Display(Name = "Họ tên"),MaxLength(100)]
        public string Hoten { get; set; }

        [Required]
        [Display(Name = "Năm sinh")]
        public int Namsinh { get; set; }
        [Required]
        [Display(Name = "Giới tính"), MaxLength(50)]
        public string Gioitinh { get; set; }
        [Required]
        [Display(Name = "Quốc tịch")]
        public int Quoctich { get; set; }
        [Required(ErrorMessage = "Chưa điền thông tin")]
        [Display(Name = "Số CMND"), MaxLength(50)]
        public string SoCMND { get; set; }

      
        [Required, MaxLength(25)]
        public string SoHieuPhuongTien { get; set; }
        [Required, MaxLength(20)]
        public string SoGhe { get; set; }
        [Required]
        public int NgayDi { get; set; }
        [Required]
        public int ThangDi { get; set; }
        [Required]
        public int NamDi { get; set; }
        [Required]
        public int NgayDen { get; set; }
        [Required]
        public int ThangDen { get; set; }
        [Required]
        public int NamDen { get; set; }
     
        [Required]
        public int QuocGiaKhoiHanh { get; set; }
        [Required, MaxLength(50)]
        public string TinhKhoiHanh { get; set; }
        [Required]
        public int QuocGiaDen { get; set; }
        [Required]
        public int TinhDen { get; set; }
        [Required, MaxLength(200)]
        public string NoiTungDen { get; set; }

        [Required]        
        public int TinhThanhId { get; set; }
    
        [Required]
        public int QuanHuyenId { get; set; }

        [Required]
        public int PhuongXaId { get; set; }

        [Required, MaxLength(50)]
        public string SoNha { get; set; }
        [Required, MaxLength(13)]
        [RegularExpression(@"(09[0|1|2|3|4|6|7|8|9]|08[1|2|3|4|5|6|8|9]|07[0|6|7|8|9]|03[2|3|4|5|6|7|8|9]|05[6|8|9])+([0-9]{7})\b")]
        public string SoDienThoai { get; set; }
        [MaxLength(150)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
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

        public List<CuaKhau> cuakhaus { get; set; }
        public List<QuocGia> quocgias { get; set; }
        public List<TinhThanh> tinhthanhs { get; set; }
        public List<QuanHuyen> quanhuyens { get; set; }
        public List<PhuongXa> phuongxas { get; set; }
        [MaxLength(20)]
        public string taubay  { get; set; }
        [MaxLength(20)]
        public string tauthuyen { get; set; }
        [MaxLength(20)]
        public string oto { get; set; }
        [MaxLength(20)]
        public string phuongtienkhac { get; set; }
        [MaxLength(50)]
        public string khac { get; set; }
        public DangKyToKhai()
        {
            cuakhaus = new List<CuaKhau>();
            quocgias = new List<QuocGia>();
            tinhthanhs = new List<TinhThanh>();
            quanhuyens = new List<QuanHuyen>();
            phuongxas = new List<PhuongXa>();
        }
    }
}
