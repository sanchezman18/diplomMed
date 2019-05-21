using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace diplomMed.Models
{
    public class Monitor
    {
        public int Id { get; set; }
        [Display(Name="Измерение электрокардиографии")]
        public string Ekg { get; set; }
        [Display(Name ="Измерение артериального давления")]
        public string Ad { get; set; }
        [Display(Name ="Измерение капнометрии")]
        public string Kapn { get; set; }
        [Display(Name ="Измерение пульсоксиметрия")]
        public string Pulsoxxx { get; set; }
        [Display(Name ="Диагональ")]
        public string Diagonal { get; set; }
        [Display(Name ="Разрешение Экрана")]
        public string Resol { get; set; }

        public Equipment Equip { get; set; }
        public int EquipId { get; set; }
    }
}
