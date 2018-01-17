using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBInventory.DAL.IDAL;
using NBInventory.DTO;
using System.Data.Entity;

namespace NBInventory.DAL.DAL
{
   public class KitchenDAL: IKitchenDAL
    {
        private readonly NBInventoryDBEntities dbcontext;
        public KitchenDAL()
        {
            dbcontext = new NBInventoryDBEntities();

        }
            
        public void Create(KitchenDTO kitchenDTO)
        {
            Kitchen kitchen = new Kitchen();
            kitchen.Kitchen_ID = kitchenDTO.Kitchen_ID;
            kitchen.Kitchen_Name = kitchenDTO.Kitchen_Name;
            dbcontext.Entry(kitchen).State = EntityState.Added;
            dbcontext.SaveChanges();
                }

        public void Edit(KitchenDTO kitchenDTO)
        {
            Kitchen kitchen = new Kitchen();

            if (kitchenDTO.Kitchen_ID > 0)
            {
                kitchen.Kitchen_ID = kitchenDTO.Kitchen_ID;
                kitchen.Kitchen_Name = kitchenDTO.Kitchen_Name;
                dbcontext.Entry(kitchen).State = EntityState.Modified;
                dbcontext.SaveChanges();

            }
        }

        public bool Delete(int id)
        {
             if(dbcontext.Kitchens.Any(x =>x.Kitchen_ID == id))
            {
                Kitchen kitchen = new Kitchen();
                kitchen.Kitchen_ID = id;
                dbcontext.Entry(kitchen).State = EntityState.Deleted;
                dbcontext.SaveChanges();
                return true;
                
            }
            else
            { 
                return false;
            }
            
        }

        public KitchenDTO GetbyID(int id)
        {
            KitchenDTO kitchenDTO = new KitchenDTO();
            var item = dbcontext.Kitchens.Where(x => x.Kitchen_ID == id).FirstOrDefault();
            kitchenDTO.Kitchen_ID = item.Kitchen_ID;
            kitchenDTO.Kitchen_Name = item.Kitchen_Name;
            return kitchenDTO;
        }

        public List<KitchenDTO> GetKitchens()
        {
            List<KitchenDTO> kitchenlistDTO = new List<KitchenDTO>();
            var room = dbcontext.Kitchens.ToList();
            if(room != null)
            {
                foreach(var item in room)
                {
                    KitchenDTO kitchen = new KitchenDTO();
                    kitchen.Kitchen_ID = item.Kitchen_ID;
                    kitchen.Kitchen_Name = item.Kitchen_Name;
                    kitchenlistDTO.Add(kitchen);
                }


            }
            return kitchenlistDTO;
        }

        
    }
}
