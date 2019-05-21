using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace diplomMed.Models
{
    public class Equipment // Деффиблитяторы
    {
        

        public int Id { get; set; }
        [Display(Name ="Вид оборудования")]
        public string EquipType { get; set; }
        [Display(Name ="Фото")]
        public byte[] Photo { get; set; }

        [Display(Name ="Производитель")]
        public string Developer { get; set; }

        [Display(Name ="Модель")]
        public string Model { get; set; }

        [Display(Name ="Страна производства")]
        public string Country { get; set; }

        //[Display(Name ="Ручной режим")]
        //public string Manual { get; set; }

       // [Display(Name ="Автоматический режим")]
       // public string Auto { get; set; }

       // [Display(Name ="Синхронизированный режим")]
       // public string Synchr { get; set; }

       // [Display(Name ="Голосовые подсказки")]
      // public string Voice { get; set; }

      //  [Display(Name ="Встроенный ЭКГ")]
       // public string Ekg { get; set; }

       // [Display(Name ="Встроенный принтер")]
      // public string Printer { get; set; }

      //  [Display(Name ="Встроенный пулсооксиметр")]
       // public string PulsOxx { get; set; }

       // [Display(Name ="Функция измерения давления")]
       // public string Press { get; set; }

      //  [Display(Name ="Габариты")]
        //public string Size { get; set; }

        [Display(Name ="Цена (Рублей)")]
        [RegularExpression(@"[0-9]*$", ErrorMessage ="Неправильно заполнено поле")]
        public decimal Price { get; set; }

       [Display(Name ="Класс 1")]
       public bool Categ1 { get; set; }
       [Display(Name ="Класс 2")]
       public bool Categ2 { get; set; }
       [Display(Name ="Класс 3")]
       public bool Categ3 { get; set; }

       public Defs Defs { get; set;}
       public Ekg Ekgs { get; set; }
       public Ivl Ivls { get; set; }
       public Monitor Monitors { get; set; }
       public Stretcher Stretchers { get; set; }
       public PulsOxx PulsOxxs { get; set; }
        public Reanim Reanims { get; set; }

       

 

        public void Getter(EquipHelpModel def)
        {
            Id = def.Id;
            EquipType = def.EquipType;
            Developer = def.Developer;
            Model = def.Model;
           Country = def.Country;
         //   Manual = def.Manual;
         //   Auto = def.Auto;
          //  Synchr = def.Synchr;
          //  Voice = def.Voice;
          //  Ekg = def.Ekg;
           // Printer = def.Printer;
           // PulsOxx = def.PulsOxx;
          //  Press = def.Press;
         //   Size = def.Size;
            Price = def.Price;

            Categ1 = def.Categ1;
            Categ2 = def.Categ2;
           Categ3 = def.Categ3;

        }


    }
}
