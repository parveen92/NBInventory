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
    public class StockItemServices : IStockItemServices
    {
        private readonly IStockItemDAL  _db;
        public StockItemServices()
        {
            _db = new StockItemDAL();
        }
        public void Create(StockItemDTO stockItemDTO)
        {
            _db.Create(stockItemDTO);
        }

        public bool Delete(int id)
        {
           return _db.Delete(id);
        }

        public void Edit(StockItemDTO stockItemDTO)
        {
            _db.Edit(stockItemDTO);
        }

        public StockItemDTO GetbyID(int id)
        {
            return _db.GetbyID(id);
        }

        public List<StockItemDTO> GetStockItems()
        {
           return _db.GetStockItems();
        }
    }
}
