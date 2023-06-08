using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DTO_HotelManagement;
using System.Data.SqlClient;
using System.Data;
namespace DAO_HotelManagement
{
    public class Room_DAO : DataProvider
    {
        public DataTable getRoom()
        {
            DataProvider dp = new DataProvider();
            string query = "exec usp_getRoomList";
            return dp.ExecuteQuery(query);

        }
    }
}
