using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace NBInventory.DTO
{
    public class RoomItemDetailDTO
    {

        [Display(Name = "Room Item Detail ID")]
        public int Rooms_Item_Detail_ID { get; set; }

        [Display(Name = "Room Number")]
        public int Room_NumberID { get; set; }

        [Display(Name = "Item ID")]
        public int ItemID { get; set; }

        [Display(Name = "Quantity")]
        public int ItemQuantity { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ItemDate { get; set; }

        [Display(Name = "Store ID")]
        public int StoreID { get; set; }

        [Display(Name = "Item Name")] //Only for Display
        public string Item_Name { get; set; }

        [Display(Name = "Store Name")] //Only for Display
        public string Store_Name { get; set; }

        public List<string> ItemList { get; set; }

    }
}
