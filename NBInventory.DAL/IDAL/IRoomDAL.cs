using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBInventory.DTO;

namespace NBInventory.DAL.IDAL
{
    public interface IRoomDAL
    {
        void Create(RoomDTO roomDTO);
        void Edit(RoomDTO roomDTO);
        bool Delete(int id);
        RoomDTO GetbyID(int id);
        List<RoomDTO> GetRooms();
    }
}
