using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBInventory.DTO
{
    public class StockItemDTO
    {
        [Display(Name = "Item ID")]
        public int Item_ID { get; set; }

        [Display(Name = "Item Name")]
        public string Item_Name { get; set; }

        [Display(Name = "Quantity")]
        public int Item_Quantity { get; set; }

        [Display(Name = "Purchased Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Item_Purchased_On { get; set; }

        [Display(Name = "Disposed Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Item_Disposed_On { get; set; }

        [Display(Name = "Item Remarks")]
        public string Item_Remarks { get; set; }

        [Display(Name = "Store ID")]
        public int Store_ID { get; set; }

        [Display(Name ="Store Name")]
        public string Store_Name{get;set;}
    }
}
