using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace diplomMed.Models
{
    public class Stretcher
    {
        public int Id { get; set; }
        [Display(Name = "Разложенное состояние (мм)")]
        public string WorkingCondition { get; set; }
        [Display(Name = "Сложенное состояние (мм)")]
        public string FoldedCondition { get; set; }

        public int EquipId { get; set; }
        public Equipment Equip { get; set; }

    }
}
