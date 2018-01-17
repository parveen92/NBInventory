using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBInventory.DTO
{
    public class RoomDTO
    {
        [Required,Display(Name ="Room Number")]
        public int Room_NumberID { get; set; }

        [Required, Display(Name = "Room Type")]
        public string Room_Type { get; set; }
    }
}
