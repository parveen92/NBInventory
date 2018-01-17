using NBInventory.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBInventory.DTO;
using NBInventory.DAL.IDAL;
using NBInventory.DAL.DAL;

namespace NBInventory.Services.Services
{
    public class KitchenServices : IKitchenServices
    {

        private readonly IKitchenDAL _db;
        public KitchenServices()
        {
            _db = new KitchenDAL();
        }
        public void Create(KitchenDTO kitchenDTO)
        {
            _db.Create(kitchenDTO);
        }

        public bool Delete(int id)
        {
           
            return _db.Delete(id);

        }

        public void Edit(KitchenDTO kitchenDTO)
        {
            _db.Edit(kitchenDTO);      

        }

        public KitchenDTO GetbyID(int id)
        {
           return _db.GetbyID(id);
        }

        public List<KitchenDTO> GetKitchens()
        {
            return _db.GetKitchens();
        }
    }
}
