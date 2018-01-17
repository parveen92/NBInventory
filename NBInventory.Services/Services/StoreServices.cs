using NBInventory.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBInventory.DTO;
using NBInventory.DAL;
using NBInventory.DAL.IDAL;
using NBInventory.DAL.DAL;

namespace NBInventory.Services.Services
{
    public class StoreServices : IStoreServices
    {
        private readonly IStoreDAL _db;
        public StoreServices()
        {
            _db = new StoreDAL();
        }

        public void Create(StoreDTO store)
        {
            _db.Create(store);
        }

        public void Edit(StoreDTO store)
        {
            _db.Edit(store);
        }

        public bool Delete(int id)
        {
           return _db.Delete(id);
        }


        public StoreDTO GetbyID(int id)
        {
           return _db.GetbyID(id);
        }

        public List<StoreDTO> GetStores()
        {
           return _db.GetStores();
        }
    }
}
