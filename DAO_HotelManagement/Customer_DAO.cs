using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO_HotelManagement;

namespace DAO_HotelManagement
{
    public class Customer_DAO : DataProvider
    {
        
        private static Customer_DAO instance;
        public static Customer_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Customer_DAO();
                return Customer_DAO.instance;
            }
            private set { Customer_DAO.instance = value; }
        }
        private Customer_DAO() { }
        public DataTable getCustomer()
        {
            DataProvider dp = new DataProvider();
            string query = "exec usp_getCustomerList";
            return dp.ExecuteQuery(query);
        }
        public bool updateCustomer(Customer_DTO CusInfo)
        {
            string query = "UPDATE CUSTOMER \n" +
                           "SET NAME = N'" + CusInfo.Name + "', GENDER = N'" + CusInfo.Gender + "', BIRTHDAY = CONVERT(DATE, '" + CusInfo.Birthday + "', 103), EMAIL = N'" + CusInfo.Email +
                           "', PHONE = '" + CusInfo.Phone + "', IDENTIFY_CARD = N'" + CusInfo.Identify_Card + "' \n" +
                           "WHERE ID_CUSTOMER = N'" + CusInfo.IdCustomer + "'";
            int index = DataProvider.Instance.ExecuteNonQuery(query);
            if (index <= 0) { return false; }
            return true;
        }
    }
}
