using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBInventory.DTO
{
   public class KitchenDTO
    {

        [Display( Name="Kitchen ID")]     
        public int  Kitchen_ID { get; set; }

        [Required,Display(Name ="Kitchen Name")] 
        public string Kitchen_Name { get; set; }

    }
}
