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
        public static string BookingID;
        
     
        private static BookingForm_DAO instance;
        public static BookingForm_DAO Instance
        {
            get
            {
                if (instance == null) instance = new BookingForm_DAO();
                return BookingForm_DAO.instance;
            }
            private set { BookingForm_DAO.instance = value; }
        }
        private BookingForm_DAO() { }
        public bool check_Booking(BookingForm_DTO BookingID)
        {
            string query = "SELECT * FROM BOOKING_FORM WHERE ID_BOOKING = '" + BookingID.IdBooking + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count <= 0)
            {
                return false;
            }
            else return true;
        }
        public DataTable LoadData(BookingForm_DTO BookingID)
        {  
            string query = "SELECT * FROM BOOKING_FORM WHERE ID_BOOKING = '" + BookingID.IdBooking + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public string getGuestName(BookingForm_DTO BookingID)
        {
            string query = "SELECT C.NAME" +
                           " FROM BOOKING_FORM BF" +
                           " JOIN CUSTOMER C " +
                           " ON BF.CUSTOMER = C.ID_CUSTOMER" +
                           " WHERE BF.ID_BOOKING = '" + BookingID.IdBooking + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string username;
            foreach (DataRow dr in dt.Rows)
            {
                username = dr["NAME"].ToString();
                return username;
            }
            return null;
        }
        public string getNumberofrooms(BookingForm_DTO BookingID)
        {
            string query = "SELECT COUNT(*) as Amount " +
                            " FROM BOOKING_FORM BF" +
                            " JOIN BOOKING_ROOM BR" +
                            " ON BF.ID_BOOKING = BR.ID_BOOKING" +
                            " WHERE BF.ID_BOOKING = '" + BookingID.IdBooking + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string username;
            foreach (DataRow dr in dt.Rows)
            {
                username = dr["Amount"].ToString();
                return username;
            }
            return null;
        }
        public string getNumberofcustomers(BookingForm_DTO BookingID)
        {
            string query = "SELECT COUNT(*) as Amount " +
                            " FROM BOOKING_FORM BF" +
                            " JOIN CUSTOMER C" +
                            " ON BF.CUSTOMER = C.ID_CUSTOMER" +
                            " WHERE BF.ID_BOOKING = '" + BookingID.IdBooking + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string username;
            foreach (DataRow dr in dt.Rows)
            {
                username = dr["Amount"].ToString();
                return username;
            }
            return null;
        }
        public string getNoIdentity(BookingForm_DTO BookingID)
        {
            string query = "SELECT C.IDENTIFY_CARD" +
                            " FROM BOOKING_FORM BF" +
                            " JOIN CUSTOMER C" +
                            " ON BF.CUSTOMER = C.ID_CUSTOMER" +
                            " WHERE BF.ID_BOOKING = '" + BookingID.IdBooking + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string username;
            foreach (DataRow dr in dt.Rows)
            {
                username = dr["IDENTIFY_CARD"].ToString();
                return username;
            }
            return null;
        }
        public string getSPRequires(BookingForm_DTO BookingID)
        {
            string query = "SELECT SPECIAL_REQUIREMENTS " +
                            " FROM BOOKING_FORM BF" +
                            " WHERE BF.ID_BOOKING = '" + BookingID.IdBooking + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string username;
            foreach (DataRow dr in dt.Rows)
            {
                username = dr["SPECIAL_REQUIREMENTS"].ToString();
                return username;
            }
            return null;
        }
        public string getPrice(BookingForm_DTO BookingID)
        {
            string query = "SELECT PRICE " +
                            " FROM BOOKING_FORM BF" +
                            " WHERE BF.ID_BOOKING = '" + BookingID.IdBooking + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string username;
            foreach (DataRow dr in dt.Rows)
            {
                username = dr["PRICE"].ToString();
                return username;
            }
            return null;
        }
    }
}
