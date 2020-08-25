using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyNhan.Models
{
    public class TaiKhoan: IdentityUser
    {
        [Key]
        public int MaTK { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        //[MaxLength(18, ErrorMessage = "Fullname maximum 18 characters")]
        [Display(Name = "Họ và tên")]
        public string HoTen { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "E-Mail")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",
            ErrorMessage = "Email không đúng định dạng")]
        public string Email { get; set; }
       

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Số điện thoại")]
        //[RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",
        //  ErrorMessage = "Số điện thoại không đúng.")]
        public string SoDienThoai { get; set; }


        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Mật khẩu"),DataType(DataType.Password)]
        public string MatKhau { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Xác nhận mật khẩu"), DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Mật khẩu xác nhận không chính xác")]
        public string XacnhanMatKhau { get; set; }


        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public string Tinh_Tp { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public string Quan_Huyen { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public string Phuong_Xa { get; set; }
    }
}
