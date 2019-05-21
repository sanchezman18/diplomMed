using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace diplomMed.Models
{
    public class Reanim
    {
        public int Id { get; set; }
        [Display(Name ="Описание")]
        public string Description { get; set; }

        public Equipment Equip { get; set; }
        public int EquipId { get; set; }
    }
}
