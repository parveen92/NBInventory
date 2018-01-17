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
    public class StockItemDAL : IStockItemDAL
    {
        private readonly NBInventoryDBEntities dbcontext;
        public StockItemDAL()
        {
            dbcontext = new NBInventoryDBEntities();
        }

        public void Create(StockItemDTO stockItemDTO)
        {
            Item_Stock item_Stock = new Item_Stock();

            item_Stock.Item_Name = stockItemDTO.Item_Name;
            item_Stock.Item_Quantity = stockItemDTO.Item_Quantity;
            item_Stock.Item_Disposed_On = stockItemDTO.Item_Disposed_On;
            item_Stock.Item_Purchased_On = stockItemDTO.Item_Purchased_On;
            item_Stock.Item_Remarks = stockItemDTO.Item_Remarks;
            item_Stock.Store_ID = stockItemDTO.Store_ID;

            dbcontext.Item_Stock.Add(item_Stock);
            dbcontext.SaveChanges();

        }

        public bool Delete(int id)
        {
            if (dbcontext.Item_Stock.Any(i=>i.Item_ID==id))
            {
                Item_Stock item_Stock = new Item_Stock();
                item_Stock.Item_ID = id;
                dbcontext.Entry(item_Stock).State = EntityState.Deleted;
                dbcontext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Edit(StockItemDTO stockItemDTO)
        {
            Item_Stock item_Stock = new Item_Stock();

            item_Stock.Item_ID = stockItemDTO.Item_ID;
            item_Stock.Item_Name = stockItemDTO.Item_Name;
            item_Stock.Item_Quantity = stockItemDTO.Item_Quantity;
            item_Stock.Item_Purchased_On = stockItemDTO.Item_Purchased_On;
            item_Stock.Item_Disposed_On = stockItemDTO.Item_Disposed_On;
            item_Stock.Item_Remarks = stockItemDTO.Item_Remarks;
            item_Stock.Store_ID = stockItemDTO.Store_ID;

            dbcontext.Entry(item_Stock).State = EntityState.Modified;
            dbcontext.SaveChanges();

        }

        public StockItemDTO GetbyID(int id)
        {
            var Item = dbcontext.Item_Stock.Where(i => i.Item_ID == id).FirstOrDefault();
            StockItemDTO stockItemDTO = new StockItemDTO();
            if (Item != null)
            {
                stockItemDTO.Item_ID = Item.Item_ID;
                stockItemDTO.Item_Name = Item.Item_Name;
                stockItemDTO.Item_Quantity = Item.Item_Quantity;
                stockItemDTO.Item_Purchased_On = Item.Item_Purchased_On;
                stockItemDTO.Item_Disposed_On = Item.Item_Disposed_On;
                stockItemDTO.Item_Remarks = Item.Item_Remarks;
                stockItemDTO.Store_ID = Item.Store_ID;
            }
            return stockItemDTO;

        }

        public List<StockItemDTO> GetStockItems()
        {
            var itemlist = dbcontext.Item_Stock.ToList();
            List<StockItemDTO> stockItemDTOList = new List<StockItemDTO>();

            if (itemlist != null && itemlist.Count > 0)
            {

                foreach (var item in itemlist)
                {
                    StockItemDTO stockItemDTO = new StockItemDTO();

                    stockItemDTO.Item_ID = item.Item_ID;
                    stockItemDTO.Item_Name = item.Item_Name;
                    stockItemDTO.Item_Quantity = item.Item_Quantity;
                    stockItemDTO.Item_Purchased_On = item.Item_Purchased_On;
                    stockItemDTO.Item_Disposed_On = item.Item_Disposed_On;
                    stockItemDTO.Item_Remarks = item.Item_Remarks;
                    //stockItemDTO.Store_ID = item.Store_ID;

                    //Only for Display Store Name
                    stockItemDTO.Store_Name = dbcontext.Stores.Where(s => s.Store_ID == item.Store_ID).FirstOrDefault().Store_Name;

                    stockItemDTOList.Add(stockItemDTO);
                }
                return stockItemDTOList;
            }
            else
            {
                return stockItemDTOList;
            }

        }
    }
}
