using DTO_HotelManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_HotelManagement
{
    public class Customer_DAO
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
        public bool updateCustomer(Customer_DTO CusInfo)
        {
            string query = "UPDATE CUSTOMER \n" +
                           "SET NAME = N'" + CusInfo.Name + "', GENDER = N'" + CusInfo.Gender + "', BIRTHDAY = N'" + CusInfo.Birthday + "', EMAIL = N'" + CusInfo.Email +
                           "', PHONE = '" + CusInfo.Phone + "', IDENTIFY_CARD = N'" + CusInfo.Identify_Card + "' \n" +
                           "WHERE ID_CUSTOMER = N'" + CusInfo.IdCustomer +"'";
            int index = DataProvider.Instance.ExecuteNonQuery(query);
            if (index <= 0){ return false;}
            return true;
        }
    }
}
