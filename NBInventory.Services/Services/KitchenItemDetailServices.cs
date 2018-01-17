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
    public class KitchenItemDetailServices : IKitchenItemDetailServices
    {
        private readonly IKitchenItemDetailDAL _db;
        public KitchenItemDetailServices()
        {

            _db = new KitchenItemDetailDAL();
        }
        public void Create(KitchenItemDetailDTO kitchenItemDetailDTO)
        {
            _db.Create(kitchenItemDetailDTO);
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
            return _db.GetKitchenItemsDetails();
        }
    }
}
