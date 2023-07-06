using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO_HotelManagement
{
    public class Waiting_DAO : DataProvider
    {
        public DataTable getWaiting()
        {
            DataProvider dp = new DataProvider();
            string query = "exec usp_getWaitingList";
            return dp.ExecuteQuery(query);
        }
    }
}
