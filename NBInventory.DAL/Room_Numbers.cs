//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NBInventory.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Room_Numbers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Room_Numbers()
        {
            this.Rooms_Item_Detail = new HashSet<Rooms_Item_Detail>();
        }
    
        public int Room_NumberID { get; set; }
        public string Room_Type { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rooms_Item_Detail> Rooms_Item_Detail { get; set; }
    }
}
