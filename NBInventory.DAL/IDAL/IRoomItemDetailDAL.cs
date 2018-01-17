using NBInventory.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBInventory.DAL.IDAL
{
    public interface IRoomItemDetailDAL
    {
        void Create(RoomItemDetailDTO roomItemDetailDTO);
        void Edit(RoomItemDetailDTO roomItemDetailDTO);
        bool Delete(int id);
        RoomItemDetailDTO GetbyID(int id);
        List<RoomItemDetailDTO> GetRoomItemDetails();
    }
}
