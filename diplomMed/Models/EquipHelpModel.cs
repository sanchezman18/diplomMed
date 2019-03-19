using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace diplomMed.Models
{
    public class EquipHelpModel 
    {
        public IFormFile Photo { get; set; }

        public string EquipType { get; set; }
        
        public string Developer { get; set; }

       
        public string Model { get; set; }

        public string Country { get; set; }

        public bool Categ1 { get; set; }
        public bool Categ2 { get; set; }
        public bool Categ3 { get; set; }
     
      

    
        public decimal Price { get; set; }
        public int Id { get; set; }
       

    }
}
