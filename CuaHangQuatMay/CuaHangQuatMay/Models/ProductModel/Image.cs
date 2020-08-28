using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CuaHangQuatMay.Models.ProductModel
{
    public class Image
    {
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public string ProductId { get; set; }
       
    }
}
