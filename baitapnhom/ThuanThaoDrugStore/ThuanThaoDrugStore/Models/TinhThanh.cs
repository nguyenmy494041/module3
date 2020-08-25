using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThuanThaoDrugStore.Models
{
    public class TinhThanh
    {
        [Key]
        public int Id_TinhThanh { get; set; }
        [Required,MaxLength(50)]
        public string TenTinhThanh { get; set; }
        [Required, MaxLength(20)]
        public string MaTinhThanh { get; set; }
    }
}
