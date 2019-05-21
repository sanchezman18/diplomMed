using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace diplomMed.Models
{
    public class Defs // Деффибрилятор
    {
        public int Id { get; set; }
          [Display(Name ="Ручной режим")]
         public string Manual { get; set; }

        [Display(Name ="Автоматический режим")]
         public string Auto { get; set; }

        [Display(Name ="Синхронизированный режим")]
         public string Synchr { get; set; }

         [Display(Name ="Голосовые подсказки")]
         public string Voice { get; set; }

          [Display(Name ="Встроенный ЭКГ")]
         public string Ekg { get; set; }

         [Display(Name ="Встроенный принтер")]
         public string Printer { get; set; }

          [Display(Name ="Встроенный пулсооксиметр")]
         public string PulsOxx { get; set; }

         [Display(Name ="Функция измерения давления")]
         public string Press { get; set; }

         [Display(Name ="Габариты (мм)")]
         public string Size { get; set; }


        

        public Equipment Equip { get; set; }
        public int EquipId { get; set; }

        
    }
}
