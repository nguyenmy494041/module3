using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BaiKiemTraLan3.Models.Entitiesss
{
    public class Cake
    {
        [Key]
        public int MaBanh { get; set; }



        [Required(ErrorMessage = "Chưa điền tên bánh")]
        [Display(Name = "Tên bánh"), MaxLength(100)]
        public string TenBanh { get; set; }


        [Required(ErrorMessage = "Chưa điền thành phần")]
        [Display(Name = "Thành phần"), MaxLength(100)]
        public string ThanhPhan { get; set; }


        [Required(ErrorMessage = "Chưa điền hạn sử dụng")]
        [Display(Name = "Hạn sử dụng"), MaxLength(100)]
        public string HanSuDung { get; set; }

        [Required(ErrorMessage = "Chưa chọn ngày sản xuất")]
        [Display(Name = "Ngày sản xuất")]
        public DateTime NgaySanXuat { get; set; }

        [Required(ErrorMessage = "Chưa chọn giá bán")]
        [Display(Name = "Giá bán")]
        [Range(1, int.MaxValue, ErrorMessage = "Bạn chưa chọn giá bán")]
        public int GiaBan { get; set; }

        [Required(ErrorMessage = "Chưa chọn ngày sản xuất")]
        [DefaultValue(false)]
        public bool DaXoa { get; set; }

        [Required]
        [ForeignKey("TheLoais")]
        public int MaTheLoai { get; set; }
        public Category TheLoai { get; set; }

    }
}
