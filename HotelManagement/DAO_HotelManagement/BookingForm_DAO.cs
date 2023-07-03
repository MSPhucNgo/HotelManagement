﻿using DTO_HoTelManagement;
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
            string query = "SELECT R.* \n" +
                           "FROM BOOKING_FORM BF \n" +
                           "JOIN BOOKING_ROOM BR ON BF.ID_BOOKING = BR.ID_BOOKING \n" +
                           "JOIN ROOM R ON R.ID_ROOM = BR.ID_ROOM \n" +
                           "WHERE BF.ID_BOOKING = '" + BookingID.IdBooking + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public string getGuestName(BookingForm_DTO BookingID)
        {
            string query = "SELECT C.NAME\n" +
                           "FROM BOOKING_FORM BF\n" +
                           "JOIN CUSTOMER C \n" +
                           "ON BF.CUSTOMER = C.ID_CUSTOMER\n" +
                           "WHERE BF.ID_BOOKING = '" + BookingID.IdBooking + "'";
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
            string query = "SELECT COUNT(*) as Amount \n" +
                           "FROM BOOKING_FORM BF\n" +
                           "JOIN BOOKING_ROOM BR\n" +
                           "ON BF.ID_BOOKING = BR.ID_BOOKING\n" +
                           "WHERE BF.ID_BOOKING = '" + BookingID.IdBooking + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string username;
            foreach (DataRow dr in dt.Rows)
            {
                username = dr["Amount"].ToString();
                return username;
            }
            return null;
        }
        public string getPaymenMethods(BookingForm_DTO BookingID)
        {
            string query = "SELECT PAYMENT_METHODS\n" +
                           "FROM BOOKING_FORM BF\n" +
                           "WHERE BF.ID_BOOKING = '" + BookingID.IdBooking + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string methods;
            foreach (DataRow dr in dt.Rows)
            {
                methods = dr["PAYMENT_METHODS"].ToString();
                return methods;
            }
            return null;
        }
        public string getNoIdentity(BookingForm_DTO BookingID)
        {
            string query = "SELECT C.IDENTIFY_CARD \n" +
                           "FROM BOOKING_FORM BF \n" +
                           "JOIN CUSTOMER C \n" +
                           "ON BF.CUSTOMER = C.ID_CUSTOMER \n" +
                           "WHERE BF.ID_BOOKING = '" + BookingID.IdBooking + "'";
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
            string query = "SELECT SPECIAL_REQUIREMENTS \n" +
                           "FROM BOOKING_FORM BF \n" +
                           "WHERE BF.ID_BOOKING = '" + BookingID.IdBooking + "'";
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
            string query = "SELECT PRICE \n" +
                           "FROM BOOKING_FORM BF\n" +
                           "WHERE BF.ID_BOOKING = '" + BookingID.IdBooking + "'";
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
            string query = "select distinct IR.ID_ROOM, I.ID_ITEM, I.NAME,IR.AMOUNT, I.TYPE, I.STORAGE_LOCATION, I.CHECKOUT_DATE, I.MANAGER from ITEM I join ITEM_ROOM IR on I.ID_ITEM = IR.ID_ITEM ORDER BY IR.ID_ROOM ASC ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public DataTable loadlistOfItems_Room(BookingForm_DTO BookingID)
        {
            string query = "select distinct IR.ID_ROOM, I.ID_ITEM, I.NAME,IR.AMOUNT, I.TYPE, I.STORAGE_LOCATION, I.CHECKOUT_DATE, I.MANAGER from ITEM I join ITEM_ROOM IR on I.ID_ITEM = IR.ID_ITEM WHERE IR.ID_ROOM = '" + BookingID.IdBooking + "'";
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


        public DateTime getDateIn(BookingForm_DTO BookingID)
        {
            string query = "SELECT ARRIVAL_DATE \n" +
                           "FROM BOOKING_FORM BF \n" +
                           "WHERE BF.ID_BOOKING = '" + BookingID.IdBooking + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            DateTime inDate;
            foreach (DataRow dr in dt.Rows)
            {
                inDate = Convert.ToDateTime(dr["ARRIVAL_DATE"]);
                return inDate;
            }
            return DateTime.Today;
        }
        public DateTime getDateOut(BookingForm_DTO BookingID)
        {
            string query = "SELECT DEPARTURE_DATE \n" +
                           "FROM BOOKING_FORM BF \n" +
                           "WHERE BF.ID_BOOKING = '" + BookingID.IdBooking + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            DateTime inDate;
            foreach (DataRow dr in dt.Rows)
            {
                inDate = Convert.ToDateTime(dr["DEPARTURE_DATE"]);
                return inDate;
            }
            return DateTime.Today.AddMonths(1);
        }

        public bool Update_BookingForm(BookingForm_DTO BookingID)
        {
            string query = "UPDATE BOOKING_FORM\n" +
                           "SET STATUS = N'Đã xử lý', SPECIAL_REQUIREMENTS = N'" + BookingID.SpecialRequirement + "', PAYMENT_METHODS = N'" + BookingID.PaymentMethods + "'\n" +
                           "WHERE ID_BOOKING = '" + BookingID.IdBooking + "'";
            int index = DataProvider.Instance.ExecuteNonQuery(query);
            if (index > 0) return true;
            return false;
        }
        public DataTable getListRoom(BookingForm_DTO BookingID)
        {
            string query = "SELECT R.NAME, R.PRICE, R.TYPE FROM BOOKING_FORM BF \n" +
                           "JOIN BOOKING_ROOM BR ON BF.ID_BOOKING = BR.ID_BOOKING \n" +
                           "JOIN ROOM R ON R.ID_ROOM = BR.ID_ROOM \n" +
                           "WHERE BF.ID_BOOKING = N'" + BookingID.IdBooking + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }
        public List<string> getListRoomOfBooking(BookingForm_DTO BookingID)
        {
            string query = "SELECT R.NAME FROM BOOKING_FORM BF \n" +
                           "JOIN BOOKING_ROOM BR ON BF.ID_BOOKING = BR.ID_BOOKING \n" +
                           "JOIN ROOM R ON R.ID_ROOM = BR.ID_ROOM \n" +
                           "WHERE BF.ID_BOOKING = N'" + BookingID.IdBooking + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            List<string> listRoom = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                string roomName = dr["Name"].ToString();
                listRoom.Add(roomName);
            }
            return listRoom;
        }
        public string getBillID(BookingForm_DTO BookingID)
        {
            string query = "SELECT B.ID_BILL \n" +
                           "FROM BILL B \n" +
                           "WHERE B.ID_BOOKING = N'" + BookingID.IdBooking + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string idBill;
            foreach (DataRow dr in dt.Rows)
            {
                idBill = dr["ID_BILL"].ToString();
                return idBill;
            }
            return null;
        }
    }
}
