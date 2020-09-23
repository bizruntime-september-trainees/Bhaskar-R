using System;
using System.Collections.Generic;

namespace WebAPIWithCoreMVC.Models
{
    public partial class Products
    {
        public int prodId { get; set; }       
        public string prodName { get; set; }
        public int? prodPrice { get; set; }
        public string prodBrand { get; set; }
    }
}
