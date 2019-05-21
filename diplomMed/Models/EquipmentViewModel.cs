using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace diplomMed.Models
{
    public class EquipmentViewModel
    {
         public List<Equipment> Equips;
        
        public SelectList Countries;
        public string DefCountry { get; set; }
        public string SearchString { get; set; }
        [RegularExpression(@"[0-9]*$", ErrorMessage = "Неправильно заполнено поле")]
        public string numOne { get; set; }
        [RegularExpression(@"[0-9]*$", ErrorMessage = "Неправильно заполнено поле")]
        public string numTwo { get; set; }
        public bool Categ1 { get; set; }
        public bool Categ2 { get; set; }
        public bool Categ3 { get; set; }
        public SelectList Categs;
        public string defCateg { get; set; }
        public SelectList EquipTypes;
        public string EquipType { get; set; }

        
    }
}
