using DTO_HotelManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_HotelManagement
{
    public class BookingForm_DAO
    {
        //Check if customer has existed in database
        public bool checkExistedCTM(string idCard )
        {
            string query = "exec usp_checkExistedCustomer " + "'" + idCard + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            int count = 0;
            foreach (DataRow dr in dt.Rows)
            {
                count = int.Parse((dr["EXIST"]).ToString());
            }
            if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Get more Information of existed customer from database     
        public DataTable getInforExistedCTM(string idCard)
        {

            DataProvider dp = new DataProvider();
            string query = "exec usp_getExistedCustomer" + "'" + idCard + "'";
            return dp.ExecuteQuery(query);
        }
    }
}
