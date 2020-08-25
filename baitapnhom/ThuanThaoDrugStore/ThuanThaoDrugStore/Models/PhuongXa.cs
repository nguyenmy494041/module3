using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThuanThaoDrugStore.Models
{
    public class PhuongXa
    {
        [Key]
        public int Id_PhuongXa { get; set; }
        [Required, MaxLength(50)]
        public string TenPhuongXa { get; set; }
        [Required, MaxLength(20)]
        public string MaPhuongXa { get; set; }
        [Required]
        public int Id_TinhThanh { get; set; }
        [Required]
        public int Id_QuanHuyen { get; set; }
    }
}
