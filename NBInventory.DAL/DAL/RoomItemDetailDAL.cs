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
    public class RoomItemDetailDAL : IRoomItemDetailDAL
    {
        private readonly NBInventoryDBEntities dbcontext;
        public RoomItemDetailDAL()
        {
            dbcontext = new NBInventoryDBEntities();
        }


        public void Create(RoomItemDetailDTO roomItemDetailDTO)
        {
            Rooms_Item_Detail rooms_Item_Detail = new Rooms_Item_Detail();

            //rooms_Item_Detail.Rooms_Item_Detail_ID = roomItemDetailDTO.Rooms_Item_Detail_ID;
            rooms_Item_Detail.ItemDate = roomItemDetailDTO.ItemDate;
            rooms_Item_Detail.ItemID = roomItemDetailDTO.ItemID;
            rooms_Item_Detail.ItemQuantity = roomItemDetailDTO.ItemQuantity;
            rooms_Item_Detail.Room_NumberID = roomItemDetailDTO.Room_NumberID;
            rooms_Item_Detail.StoreID = roomItemDetailDTO.StoreID;

            dbcontext.Entry(rooms_Item_Detail).State = EntityState.Added;
            dbcontext.SaveChanges();

        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(RoomItemDetailDTO roomItemDetailDTO)
        {
            throw new NotImplementedException();
        }

        public RoomItemDetailDTO GetbyID(int id)
        {
            RoomItemDetailDTO roomItemDetailDTO = new RoomItemDetailDTO();
            var roomItemDetail = dbcontext.Rooms_Item_Detail.Where(r => r.Rooms_Item_Detail_ID == id).FirstOrDefault();
            if (roomItemDetail != null)
            {
                roomItemDetailDTO.Rooms_Item_Detail_ID = roomItemDetail.Rooms_Item_Detail_ID;
                roomItemDetailDTO.ItemDate = roomItemDetail.ItemDate;
                roomItemDetailDTO.ItemID = roomItemDetail.ItemID;
                roomItemDetailDTO.ItemQuantity = roomItemDetail.ItemQuantity;
                roomItemDetailDTO.Room_NumberID = roomItemDetail.Room_NumberID;
                roomItemDetailDTO.StoreID = roomItemDetail.StoreID;

            }
            return roomItemDetailDTO;

        }


        public List<RoomItemDetailDTO> GetRoomItemDetails()
        {
            List<RoomItemDetailDTO> list = new List<RoomItemDetailDTO>();
            var roomItemDetails = dbcontext.Rooms_Item_Detail.ToList();

            if (roomItemDetails != null)
            {
                foreach (var item in roomItemDetails)
                {
                    RoomItemDetailDTO roomItemDetailDTO = new RoomItemDetailDTO();
                    roomItemDetailDTO.Rooms_Item_Detail_ID = item.Rooms_Item_Detail_ID;
                    roomItemDetailDTO.ItemDate = item.ItemDate;
                    roomItemDetailDTO.ItemID = item.ItemID;
                    roomItemDetailDTO.ItemQuantity = item.ItemQuantity;
                    roomItemDetailDTO.Room_NumberID = item.Room_NumberID;
                    roomItemDetailDTO.StoreID = item.StoreID;

                    //Get Item NAME to display
                    var getItemName = dbcontext.Item_Stock.Where(i => i.Item_ID == item.ItemID).FirstOrDefault();
                    roomItemDetailDTO.Item_Name = getItemName.Item_Name;
                    //Get Store Name to display
                    var getStoreName = dbcontext.Stores.Where(s => s.Store_ID == item.StoreID).FirstOrDefault();
                    roomItemDetailDTO.Store_Name = getStoreName.Store_Name;





                    list.Add(roomItemDetailDTO);

                }

                //NOT Working //Get ITemNameLIST to display
                //roomItemDetailDTO.ItemList = dbcontext.Item_Stock.Select(i => i.Item_Name).Distinct().ToList();


            }
            return list;

        }

    }
}
