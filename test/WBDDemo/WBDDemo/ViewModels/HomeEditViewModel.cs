using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WBDDemo.ViewModels
{
    public class HomeEditViewModel:HomeCreateViewModel
    {
        public int Id { get; set; }
        public string AvataPath { get; set; }


    }
}
