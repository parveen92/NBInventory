using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBInventory.DTO
{
    public class KitchenItemDetailDTO

    {
        [Required, Display(Name ="Kitchen Item Detail ID") ]
        public int Kitchen_ItemDetail_ID{ get; set; }

        [Required, Display(Name ="Kitchen ID")]
        public int Kitchen_ID { get; set; }

        [Required,Display(Name ="Item ID")]
        public int Kitchen_ItemID { get; set; }

        [Required,Display(Name ="Quantity")]
        public int Kitchen_ItemQuantity { get; set; }

        [Required,Display(Name ="Purchased Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="dd.mm.yyyy",ApplyFormatInEditMode =true)]
        public DateTime Kitchen_ItemDate { get; set; }

        [Display(Name = "Kitchen Store ID")]
        public int Kitchen_StoreID{ get; set; }
    }
}
