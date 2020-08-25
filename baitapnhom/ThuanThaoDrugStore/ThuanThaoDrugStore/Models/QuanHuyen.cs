using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThuanThaoDrugStore.Models
{
    public class QuanHuyen
    {
        [Key]
        public int Id_QuanHuyen { get; set; }
        [Required, MaxLength(100)]
        public string TenQuanHuyen { get; set; }
        [Required, MaxLength(20)]
        public string MaQuanHuyen { get; set; }
        [Required]
        public int Id_TinhThanh { get; set; }

    }
}
