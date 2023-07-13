using DAO_HotelManagement;
using DTO_HotelManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BUS_HotelManagement
{
    public class BookingForm_BUS
    {
        public bool checkExistedCTM(string idCard)
        {
            return BookingForm_DAO.Instance.checkExistedCTM(idCard);

        }
        public DataTable getInforExistedCTM(string idCard)
        {
            return BookingForm_DAO.Instance.getInforExistedCTM(idCard);
        }
        public static DataTable LoadData(BookingForm_DTO BookingId)
        {
            return BookingForm_DAO.Instance.LoadData(BookingId);
        }
        public static DataTable getListRoom(BookingForm_DTO BookingId)
        {
            return BookingForm_DAO.Instance.getListRoom(BookingId);
        }
        public static string getGuestName(BookingForm_DTO BookingId)
        {
            return BookingForm_DAO.Instance.getGuestName(BookingId);
        }
        public static string getNumberofrooms(BookingForm_DTO BookingId)
        {
            return BookingForm_DAO.Instance.getNumberofrooms(BookingId);
        }
        public static string getNoIdentity(BookingForm_DTO BookingId)
        {
            return BookingForm_DAO.Instance.getNoIdentity(BookingId);
        }
        public static string getSPRequires(BookingForm_DTO BookingId)
        {
            return BookingForm_DAO.Instance.getSPRequires(BookingId);
        }
        public static string getBillID(BookingForm_DTO BookingId)
        {
            return BookingForm_DAO.Instance.getBillID(BookingId);
        }
        public static string getPrice(BookingForm_DTO BookingId)
        {
            return BookingForm_DAO.Instance.getPrice(BookingId);
        }
        public static string getPaymenMethods(BookingForm_DTO BookingId)
        {
            return BookingForm_DAO.Instance.getPaymenMethods(BookingId);
        }
        public static bool check_Booking(BookingForm_DTO BookingId)
        {
            return BookingForm_DAO.Instance.check_Booking(BookingId);
        }
        public static bool check_BookingCheckout(BookingForm_DTO BookingId)
        {
            return BookingForm_DAO.Instance.check_BookingCheckout(BookingId);
        }
        public static DataTable loadlistOfReservation()
        {
            return BookingForm_DAO.Instance.loadlistOfReservation();
        }
		public static DataTable loadlistOfReservation_Room(BookingForm_DTO BookingId)
        {
            return BookingForm_DAO.Instance.loadlistOfReservation_Room(BookingId);
        }
        public static DataTable loadlistOfReservation_Edit(BookingForm_DTO BookingId)
        {
            return BookingForm_DAO.Instance.loadlistOfReservation_Edit(BookingId);
        }
        public static DataTable loadlistOfItems()//BookingForm_DTO BookingId)
        {
            return BookingForm_DAO.Instance.loadlistOfItems();//BookingId);
        }

        public static DataTable loadlistOfItems_Room(BookingForm_DTO BookingId)
        {
            return BookingForm_DAO.Instance.loadlistOfItems_Room(BookingId);
        }
		public static DataTable cancel_Reservation(BookingForm_DTO BookingId)
		{
			return BookingForm_DAO.Instance.cancel_Reservation(BookingId);
		}
		public static bool update_Reservation(BookingForm_DTO _idBooking, BookingForm_DTO _arrivalDate, BookingForm_DTO _departure, BookingForm_DTO _specialReq)
        {
            return BookingForm_DAO.Instance.update_Reservation(_idBooking, _arrivalDate, _departure, _specialReq);
        }

        public static List<string> cb_BookingID()
        {
            return BookingForm_DAO.Instance.getBooKingID();
        }
        public static List<string> cb_BookingID_Edit()
        {
            return BookingForm_DAO.Instance.getBooKingID();
        }
        public static List<string> cb_RoomID()
        {
            return BookingForm_DAO.Instance.getRoomID();
        }
        public static List<string> cb_RoomType()
        {
            return BookingForm_DAO.Instance.getRoomType();
        }
        

        public static DateTime getIn_Date(BookingForm_DTO BookingId)
        {
            return BookingForm_DAO.Instance.getDateIn(BookingId);
        }
        public static DateTime getOut_Date(BookingForm_DTO BookingId)
        {
            return BookingForm_DAO.Instance.getDateOut(BookingId);
        }
        public static bool Update_BookingForm(BookingForm_DTO BookingId)
        {
            return BookingForm_DAO.Instance.Update_BookingForm(BookingId);
        }
        public static bool Update_BookingFormCheckOut(BookingForm_DTO BookingId)
        {
            return BookingForm_DAO.Instance.Update_BookingFormCheckOut(BookingId);
        }
        public static List<string> getListRoomOfBooking(BookingForm_DTO BookingId)
        {
            return BookingForm_DAO.Instance.getListRoomOfBooking(BookingId);
        }
        public static string insertBookingForm(BookingForm_DTO inforBooking, Bill_DTO inforBill)
        {
            return BookingForm_DAO.Instance.insertBookingForm(inforBooking, inforBill);
        }
        public static bool insertBookingRoom(string id, List<Room_DTO> roomInfor)
        {
            return BookingForm_DAO.Instance.insertBookingRoom(id, roomInfor);
        }
        public static bool updateStatusRoomReserved(List<Room_DTO> roomInfor)
        {
            return BookingForm_DAO.Instance.updateStatusRoomReserved(roomInfor);
        }
    }
}
