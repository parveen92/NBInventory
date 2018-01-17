using NBInventory.DAL.DAL;
using NBInventory.DTO;
using NBInventory.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBInventory.Services.Services
{
    public class RoomItemDetailServices : IRoomItemDetailServices
    {
        private readonly RoomItemDetailDAL _db;
        public RoomItemDetailServices()
        {
            _db = new RoomItemDetailDAL();
        }
        public void Create(RoomItemDetailDTO roomItemDetailDTO)
        {
            _db.Create(roomItemDetailDTO);
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
            return _db.GetbyID(id);
        }

        public List<RoomItemDetailDTO> GetRoomItemDetails()
        {
          return  _db.GetRoomItemDetails();
        }
    }
}
