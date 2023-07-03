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

        public DataTable getUsedService(Customer_DTO CusInfo)
        {
            string query = "SELECT SF.NAME, SB.USED_DATE, SF.PRICE, SF.AMOUNT, SB.DISCOUNT, SB.TOTAL_PRICE FROM CUSTOMER C \n" +
                           "JOIN SERVICE_FORM SF ON C.ID_CUSTOMER = SF.CUSTOMER \n" +
                           "JOIN SERVICE_BILL SB ON SB.ID_SERVICE_FORM = SF.ID_SERVICE_FORM \n" +
                           "WHERE C.NAME = N'" + CusInfo.Name + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public string getCusID_Booking(Customer_DTO cusInfo)
        {
            string query = "SELECT BF.ID_BOOKING FROM BOOKING_FORM BF \n" +
                           "JOIN CUSTOMER C ON C.ID_CUSTOMER = BF.CUSTOMER " +
                           "WHERE C.NAME = N'" + cusInfo.Name + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string idBooking;
            foreach (DataRow dr in dt.Rows)
            {
                idBooking = dr["ID_BOOKING"].ToString();
                return idBooking;
            }
            return null;
        }

        public bool insertCustomer(Customer_DTO CusInfo)
        {
            string query = "DECLARE @BIRTHDAY_CONVERTED DATE;\r\n SET @BIRTHDAY_CONVERTED = CONVERT(DATE, '"+ CusInfo.Birthday + "', 103);\n" +
               "EXEC USP_AddCUSTOMER @NAME = N'" + CusInfo.Name + "', @GENDER = N'" + CusInfo.Gender + "', @BIRTHDAY = @BIRTHDAY_CONVERTED, @EMAIL = N'" + CusInfo.Email + "', @PHONE = '" + CusInfo.Phone + "', @IDENTIFY_CARD = N'" + CusInfo.Identify_Card + "'";
            //string query = "EXEC USP_AddCUSTOMER @NAME = N'" + CusInfo.Name + "', @GENDER = N'" + CusInfo.Gender + "', @BIRTHDAY = CONVERT(DATE, '" + CusInfo.Birthday + "', 103)', @EMAIL = N'" + CusInfo.Email + "', @PHONE = '" + CusInfo.Phone + "', @IDENTIFY_CARD = N'" + CusInfo.Identify_Card + "'";

            int index = DataProvider.Instance.ExecuteNonQuery(query);
            if (index <= 0) { return false; }
            return true;
        }

    }
}
