using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Quanlykhachahng.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }
        [ForeignKey("Provinces")]
        public int ProvinceId { get; set; }

        public Province Province { get; set; }
    }
}
