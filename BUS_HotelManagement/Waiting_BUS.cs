using DAO_HotelManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace BUS_HotelManagement
{
     public class Waiting_BUS
    {
        Waiting_DAO daoWaiting = new Waiting_DAO();
        public DataTable getWaiting()
        {
            return daoWaiting.getWaiting();
        }
    }
}
