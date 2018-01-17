using NBInventory.DAL.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBInventory.DTO;
using System.Data.Entity;

namespace NBInventory.DAL.DAL
{
    public class KitchenItemDetailDAL : IKitchenItemDetailDAL
    {
        private readonly NBInventoryDBEntities dbcontext;

        public KitchenItemDetailDAL()
        {


            dbcontext = new NBInventoryDBEntities();

        }

        public void Create(KitchenItemDetailDTO kitchenItemDetailDTO)
        {
            Kitchen_Item_Detail detail = new Kitchen_Item_Detail();
            detail.Kitchen_ItemDetail_ID = kitchenItemDetailDTO.Kitchen_ItemDetail_ID;
            detail.Kitchen_ID = kitchenItemDetailDTO.Kitchen_ID;
            detail.Kitchen_ItemID = kitchenItemDetailDTO.Kitchen_ItemID;
            detail.Kitchen_ItemQuantity = kitchenItemDetailDTO.Kitchen_ItemQuantity;
            detail.Kitchen_ItemDate = kitchenItemDetailDTO.Kitchen_ItemDate;
            detail.Kitchen_StoreID = kitchenItemDetailDTO.Kitchen_StoreID;
            dbcontext.Entry(detail).State = EntityState.Added;
            dbcontext.SaveChanges();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(KitchenItemDetailDTO kitchenItemDetailDTO)
        {
            throw new NotImplementedException();
        }

        public KitchenItemDetailDTO GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<KitchenItemDetailDTO> GetKitchenItemsDetails()
        {
            List<KitchenItemDetailDTO> kitchenItemDetailsDTO = new List<KitchenItemDetailDTO>();
            var Kitchenitem =dbcontext.Kitchen_Item_Detail.ToList();
            if (Kitchenitem != null)
            {
                foreach (var item in Kitchenitem)
                {
                    KitchenItemDetailDTO details = new KitchenItemDetailDTO();
                    details.Kitchen_ItemDetail_ID = item.Kitchen_ItemDetail_ID;
                    details.Kitchen_ID = item.Kitchen_ID;
                    details.Kitchen_ItemID = item.Kitchen_ItemID;
                    details.Kitchen_ItemQuantity = item.Kitchen_ItemQuantity;
                    details.Kitchen_StoreID = item.Kitchen_StoreID;
                    details.Kitchen_ItemDate = item.Kitchen_ItemDate;
                    kitchenItemDetailsDTO.Add(details);
                }

            }
            return kitchenItemDetailsDTO;
        }
    }
}
