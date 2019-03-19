using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace diplomMed.Models
{
    public class PulsOxx
    {
        public int Id { get; set; }

        [Display(Name="Объем памяти")]
        public string Memory { get; set; }

        [Display(Name ="Дисплей")]
        public string Display { get; set; }

        [Display(Name ="Работа от батареек")]
        public string Batteries { get; set; }
        [Display(Name ="Работа от встроенного аккумулятора")]
        public string Battery { get; set; }

        public Equipment Equip { get; set; }
        public int EquipId { get; set; }
    }
}
