using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToKhaiYte.Models.Entities
{
    public class DiaChi
    {
        [Key]
        public int DiaChiId { get; set; }
        [Required]
        [ForeignKey("TinhThanh")]
        public int TinhThanhId { get; set; }
        public TinhThanh TinhThanh { get; set; }
        [Required]
     
        public int QuanHuyenId { get; set; }
       
        [Required]
      
        public int PhuongXaId { get; set; }
      

        [Required, MaxLength(150)]
        public string SoNha { get; set; }
        [Required, MaxLength(13)]
        public string SoDienThoai { get; set; }
        [MaxLength(150)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [ForeignKey("ToKhai")]
        public int ToKhaiId { get; set; }

        public ToKhai ToKhai { get; set; }
    }
}
