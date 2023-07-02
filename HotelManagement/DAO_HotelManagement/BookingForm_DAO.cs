using DTO_HotelManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


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
		public DataTable loadlistOfReservation()
		{
			string query = "SELECT BF.*, C.NAME, BR.ID_ROOM, R.TYPE\r\n--INTO BOOKING_FORM_CUSTOMER_NAME\r\nFROM BOOKING_FORM BF JOIN BOOKING_ROOM BR ON BF.ID_BOOKING = BR.ID_BOOKING \r\n\t\t JOIN CUSTOMER C ON BF.CUSTOMER = C.ID_CUSTOMER \r\n\t\t JOIN ROOM R ON BR.ID_ROOM = R.ID_ROOM\r\nORDER BY ID_BOOKING ASC";
			DataTable dt = DataProvider.Instance.ExecuteQuery(query);
			return dt;
		}
		
		public DataTable loadlistOfReservation_Room(BookingForm_DTO BookingID)
		{
			string query = " SELECT * FROM BOOKING_FORM where ID_BOOKING = '" + BookingID.IdBooking + "'";
			DataTable dt = DataProvider.Instance.ExecuteQuery(query);
			return dt;
		}
		public DataTable loadlistOfReservation_Edit(BookingForm_DTO BookingID)
		{
			string query = " SELECT * FROM BOOKING_FORM where ID_BOOKING = '" + BookingID.IdBooking + "'";
			DataTable dt = DataProvider.Instance.ExecuteQuery(query);
			return dt;
		}
		public DataTable loadlistOfItems()
        {
            string query = "select distinct IR.ID_ROOM,I.NAME, IR.AMOUNT\r\nfrom ITEM I join ITEM_ROOM IR on I.ID_ITEM = IR.ID_ITEM";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public DataTable loadlistOfItems_Room(BookingForm_DTO BookingID)
        {
            string query = "select distinct IR.ID_ROOM,I.NAME, IR.AMOUNT\r\nfrom ITEM I join ITEM_ROOM IR on I.ID_ITEM = IR.ID_ITEM\r\nwhere IR.ID_ROOM = '" + BookingID.IdBooking + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        } 


		public DataTable cb_BookingID(BookingForm_DTO BookingID)
        {
            string query = "SELECT * FROM BOOKING_FORM BF WHERE BF.STATUS like N'%lý';";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
		public DataTable cb_RoomID(BookingForm_DTO BookingID)
		{
			string query = "select distinct ID_ROOM from ITEM I join ITEM_ROOM IR on I.ID_ITEM = IR.ID_ITEM";
			DataTable dt = DataProvider.Instance.ExecuteQuery(query);
			return dt;
		}
		public List<string> getBooKingID()
        {
            string query = "SELECT * FROM BOOKING_FORM\n" +
                           "ORDER BY ID_BOOKING ASC";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            List<string> roomList = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                string roomNumber = row["ID_BOOKING"].ToString();
                roomList.Add(roomNumber);
            }
            return roomList;
        }
		public List<string> getRoomID()
		{
			string query = "select * from ITEM I join ITEM_ROOM IR on I.ID_ITEM = IR.ID_ITEM order by ID_ROOM asc";
			DataTable dt = DataProvider.Instance.ExecuteQuery(query);

			List<string> roomList = new List<string>();
			foreach (DataRow row in dt.Rows)
			{
				string roomNumber = row["ID_ROOM"].ToString();
				roomList.Add(roomNumber);
			}
			return roomList;
		}
		public List<string> getRoomType()
		{
			string query = "select DISTINCT R.TYPE from BOOKING_ROOM BR JOIN ROOM R ON BR.ID_ROOM = R.ID_ROOM\r\n";
			DataTable dt = DataProvider.Instance.ExecuteQuery(query);

			List<string> roomList = new List<string>();
			foreach (DataRow row in dt.Rows)
			{
				string roomType = row["TYPE"].ToString();
				roomList.Add(roomType);
			}
			return roomList;
		}
        public DataTable Edit_Reservation(string BookingID, string name)
        {
            string query = "UPDATE BOOKING_FORM_CUSTOMER_NAME SET NAME = N'" + name + "' WHERE ID_BOOKING = '" + BookingID + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        /*public bool updateCustomer(Customer_DTO CusInfo)
		{
			string query = "UPDATE CUSTOMER \n" +
						   "SET NAME = N'" + CusInfo.Name + "' \n" +
						   "WHERE ID_CUSTOMER = N'" + CusInfo.IdCustomer + "'";
			int index = DataProvider.Instance.ExecuteNonQuery(query);
			if (index <= 0) { return false; }
			return true;
		}*/


    }
}
