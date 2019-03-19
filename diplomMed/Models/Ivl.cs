using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace diplomMed.Models
{
    public class Ivl
    {
        public int Id { get; set; }
        [Display(Name ="Время работы")]
        public string Time { get; set; }
        [Display(Name ="Тип питания")]
        public string BatteryType { get; set; }
        [Display(Name="Время зарядки")]
        public string TimeCharging { get; set; }
        [Display(Name ="Режимы работы")]
        public string WorkModes { get; set; }
       
        public Equipment Equip { get; set; }
        public int EquipId { get; set; }
    }
}
