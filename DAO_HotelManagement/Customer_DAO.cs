using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAO_HotelManagement
{
    public class Customer_DAO : DataProvider
    {
        public DataTable getCustomer()
        {
            DataProvider dp = new DataProvider();
            string query = "exec usp_getCustomerList";
            return dp.ExecuteQuery(query); 
        }
    }
}
