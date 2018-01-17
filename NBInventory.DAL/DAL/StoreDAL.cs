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
    public class StoreDAL : IStoreDAL
    {
        private NBInventoryDBEntities dbcontext = new NBInventoryDBEntities();

        public void Create(StoreDTO storeDTO)
        {
            Store store = new Store();
            store.Store_Name = storeDTO.Store_Name;
            dbcontext.Stores.Add(store);
            dbcontext.SaveChanges();
        }

        public void Edit(StoreDTO storeDTO)
        {
            Store store = new Store();
            store.Store_ID = storeDTO.Store_ID;
            store.Store_Name = storeDTO.Store_Name;

            dbcontext.Entry(store).State = EntityState.Modified;
            dbcontext.SaveChanges();
        }

        public bool Delete(int id)
        {
           
            if (dbcontext.Stores.Any(s=>s.Store_ID==id))
            {
                Store store = new Store();
                store.Store_ID = id;

                dbcontext.Entry(store).State = EntityState.Deleted;
                dbcontext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }

        public StoreDTO GetbyID(int id)
        {
            StoreDTO storeDTO = null;
            var store = dbcontext.Stores.Where(s => s.Store_ID == id).FirstOrDefault();

            if (store != null)
            {
                storeDTO = new StoreDTO();
                storeDTO.Store_ID = store.Store_ID;
                storeDTO.Store_Name = store.Store_Name;
            }
            return storeDTO;
        }

        public List<StoreDTO> GetStores()
        {
            var storelist = dbcontext.Stores.ToList();

            List<StoreDTO> storeDTOlist = new List<StoreDTO>();
            if (storelist != null && storelist.Count > 0)
            {
                foreach (var item in storelist)
                {
                    StoreDTO storeDTO = new StoreDTO();

                    storeDTO.Store_ID = item.Store_ID;
                    storeDTO.Store_Name = item.Store_Name;
                    storeDTOlist.Add(storeDTO);
                }
            }

            return storeDTOlist;

        }
    }
}
