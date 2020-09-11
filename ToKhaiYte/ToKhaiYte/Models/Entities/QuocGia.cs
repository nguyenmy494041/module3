using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToKhaiYte.Models.Entities
{
    public class QuocGia
    {
        [Key]
        public int QuocGiaId { get; set; }
        [Required, MaxLength(100)]
        public string TenQuocGia { get; set; }
        public List<TinhThanh> TinhThanhs { get; set; }
    }
}
