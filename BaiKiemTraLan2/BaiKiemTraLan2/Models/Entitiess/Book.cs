using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BaiKiemTraLan2.Models.Entitiess
{
    public class Book
    {
        [Key]
        public int MaSach { get; set; }


        [Required(ErrorMessage = "Chưa điền tên sách")]
        [Display(Name = "Tên sách"), MaxLength(100)]
        public string TenSach { get; set; }


        [Required(ErrorMessage = "Chưa điền tên tác giả")]
        [Display(Name = "Tên tác giả"), MaxLength(100)]
        public string TenTacGia { get; set; }

        [Required(ErrorMessage = "Chưa điền phần mô tả")]
        [Display(Name = "Mô tả"), MaxLength(200)]
        public string MoTa { get; set; }

        [Display(Name = "Năm xuất bản")]
        [Required(ErrorMessage = "Chưa chọn năm xuất bản")]
        [Range(1, int.MaxValue, ErrorMessage = "Bạn điền thông tin chưa đúng")]
        public int NamXuatBan { get; set; }

        [Display(Name = "Số lượng")]
        [Required(ErrorMessage = "Chưa chọn số lượng")]
        [Range(1, int.MaxValue, ErrorMessage = "Bạn điền thông tin chưa đúng")]
        public int Soluong { get; set; }

        [Required]
        [ForeignKey("TheLoais")]
        public int MaTheLoai { get; set; }
        public Category TheLoai { get; set; }

    }
}
