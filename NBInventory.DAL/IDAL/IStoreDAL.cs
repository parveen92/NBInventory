using NBInventory.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NBInventory.DAL.IDAL
{
    public interface IStoreDAL
    {
        void Create(StoreDTO store);
        void Edit(StoreDTO storeDTO);
        bool Delete(int id);
        StoreDTO GetbyID(int id);
        List<StoreDTO> GetStores();

    }
}
