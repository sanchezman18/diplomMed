using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace diplomMed.Models
{
    public class CartLine
    {
        public int CartLineID { get; set; }
        public Equipment Equipment { get; set; }
        public int Quentity { get; set; }
    }
}
