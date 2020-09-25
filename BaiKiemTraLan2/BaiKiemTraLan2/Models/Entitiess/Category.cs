using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BaiKiemTraLan2.Models.Entitiess
{
    public class Category
    {
        [Key]
        public int MaTheLoai { get; set; }

        [Required(ErrorMessage = "Chưa điền tên thể loại sách")]
        [Display(Name = "Thể loại sách"), MaxLength(100)]
        public string TenTheLoai { get; set; }
        public List<Book> Sachs { get; set; }
    }
}
