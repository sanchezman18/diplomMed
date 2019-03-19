using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace diplomMed.Models
{
    public class Ekg// электрокардтограф экг
    {
        public int Id { get; set; }

        [Display(Name ="Передача данных на компьютер")]
        public string ConnectPc { get; set; }
        [Display(Name ="Цифровая обработка сигнала")]
        public string SignalProccesing { get; set; }
        [Display(Name ="Объем памяти ")]
        public string MemorySize { get; set; }
        [Display(Name ="Габариты")]
        public string Size { get; set; }
       // [Display(Name ="Наличие удаленного доступа")]

       

        public Equipment Equip { get; set; }
        public int EquipId { get; set; }
    }
}
