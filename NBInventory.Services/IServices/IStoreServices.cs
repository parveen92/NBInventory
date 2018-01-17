using NBInventory.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBInventory.Services.IServices
{
    public interface IStoreServices
    {
        void Create(StoreDTO store);
        void Edit(StoreDTO store);
        bool Delete(int id);
        StoreDTO GetbyID(int id);
        List<StoreDTO> GetStores();
    }
}
