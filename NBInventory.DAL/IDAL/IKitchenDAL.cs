using NBInventory.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBInventory.DAL.IDAL
{
   public interface IKitchenDAL
    {

        void Create(KitchenDTO kitchenDTO);
        void Edit(KitchenDTO kitchenDTO);
        bool Delete(int id);
        KitchenDTO GetbyID(int id);
        List<KitchenDTO> GetKitchens();

    }
}
