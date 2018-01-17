using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBInventory.DTO;

namespace NBInventory.Services.IServices
{
   public interface IStockItemServices
    {
        void Create(StockItemDTO stockItemDTO);
        void Edit(StockItemDTO stockItemDTO);
        bool Delete(int id);
        StockItemDTO GetbyID(int id);
        List<StockItemDTO> GetStockItems();
    }
}
