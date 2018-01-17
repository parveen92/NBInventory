using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NBInventory.DTO
{
    public class StoreDTO
    {
        [Display(Name ="Store ID")]
        public int Store_ID { get; set; }

        [Display(Name ="Store Name")]
        public string Store_Name { get; set; }

    }
}
