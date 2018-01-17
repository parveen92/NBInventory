using NBInventory.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBInventory.Services.IServices
{
   public interface IKitchenItemDetailServices
    {
    
        void Create(KitchenItemDetailDTO kitchenItemDetailDTO);
        bool Delete(int id);
        void Edit(KitchenItemDetailDTO kitchenItemDetailDTO);
        KitchenItemDetailDTO GetByID(int id);
        List<KitchenItemDetailDTO> GetKitchenItemsDetails();
    }
}
