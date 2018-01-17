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
    public class RoomServices : IRoomServices
    {
        private readonly IRoomDAL _db = new RoomDAL();

        public void Create(RoomDTO roomDTO)
        {
            _db.Create(roomDTO);
        }

        public bool Delete(int id)
        {
          return  _db.Delete(id);
        }

        public void Edit(RoomDTO roomDTO)
        {
            _db.Edit(roomDTO);
        }

        public RoomDTO GetbyID(int id)
        {
            return _db.GetbyID(id);
        }

        public List<RoomDTO> GetRooms()
        {
            return _db.GetRooms();
        }
    }
}
