using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBInventory.DAL.DAL;
using NBInventory.DAL.IDAL;
using NBInventory.DTO;
using System.Data.Entity;

namespace NBInventory.DAL.DAL
{
    public class RoomDAL : IRoomDAL
    {
        private readonly NBInventoryDBEntities dbcontext;
        public RoomDAL()
        {
            dbcontext = new NBInventoryDBEntities();
        }

        public void Create(RoomDTO roomDTO)
        {
            Room_Numbers room = new Room_Numbers();
            room.Room_NumberID = roomDTO.Room_NumberID;
            room.Room_Type = roomDTO.Room_Type;
            dbcontext.Entry(room).State = EntityState.Added;
            dbcontext.SaveChanges();
        }

        public bool Delete(int id)
        {
            if (dbcontext.Room_Numbers.Any(r => r.Room_NumberID == id))
            {
                Room_Numbers room = new Room_Numbers();
                room.Room_NumberID = id;
                dbcontext.Entry(room).State = EntityState.Deleted;
                dbcontext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }


        }
        
        public void Edit(RoomDTO roomDTO)
        {
            Room_Numbers room = new Room_Numbers();
            room.Room_NumberID = roomDTO.Room_NumberID;
            room.Room_Type = roomDTO.Room_Type;
            dbcontext.Entry(room).State = EntityState.Modified;
            dbcontext.SaveChanges();
        }
        
        public RoomDTO GetbyID(int id)
        {
            RoomDTO roomDTO = new RoomDTO();
            var room = dbcontext.Room_Numbers.Where(r => r.Room_NumberID == id).FirstOrDefault();
            roomDTO.Room_NumberID = room.Room_NumberID;
            roomDTO.Room_Type = room.Room_Type;
            return roomDTO;
        }

        public List<RoomDTO> GetRooms()
        {
            List<RoomDTO> roomlistDto = new List<RoomDTO>();
            var roomlist = dbcontext.Room_Numbers.ToList();
            if (roomlist != null)
            {
                foreach (var item in roomlist)
                {
                    RoomDTO room = new RoomDTO();
                    room.Room_NumberID = item.Room_NumberID;
                    room.Room_Type = item.Room_Type;

                    roomlistDto.Add(room);
                }

            }
            return roomlistDto;
        }
    }
}
