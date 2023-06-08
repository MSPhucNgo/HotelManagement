using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_HotelManagement;
using DTO_HotelManagement;
using System.Data;


namespace BUS_HotelManagement
{
    public class Room_BUS
    {
        Room_DAO daoRoom = new Room_DAO();
        public DataTable getRoom()
        {
            return daoRoom.getRoom();
        }
    }
}
