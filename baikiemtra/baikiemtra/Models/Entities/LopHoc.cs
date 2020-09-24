using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace baikiemtra.Models.Entities
{
    public class LopHoc
    {
        [Key]
        public int MaLop { get; set; }
        [Required(ErrorMessage = "Chưa điền họ tên")]
        [Display(Name = "Email"), MaxLength(100)]
        public string TenLop { get; set; }
        public List<HocVien> HocViens { get; set; }
    }
}