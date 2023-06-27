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
        public static DataTable LoadData(BookingForm_DTO BookingId)
        {
            return BookingForm_DAO.Instance.LoadData(BookingId);
        }
        public static string getGuestName(BookingForm_DTO BookingId)
        {
            return BookingForm_DAO.Instance.getGuestName(BookingId);
        }
        public static string getNumberofrooms(BookingForm_DTO BookingId)
        {
            return BookingForm_DAO.Instance.getNumberofrooms(BookingId);
        }
        public static string getNumberofcustomers(BookingForm_DTO BookingId)
        {
            return BookingForm_DAO.Instance.getNumberofcustomers(BookingId);
        }
        public static string getNoIdentity(BookingForm_DTO BookingId)
        {
            return BookingForm_DAO.Instance.getNoIdentity(BookingId);
        }
        public static string getSPRequires(BookingForm_DTO BookingId)
        {
            return BookingForm_DAO.Instance.getSPRequires(BookingId);
        } 

        public static string getPrice(BookingForm_DTO BookingId)
        {
                return BookingForm_DAO.Instance.getPrice(BookingId);
        }
        public static bool check_Booking(BookingForm_DTO BookingId)
        {
            return BookingForm_DAO.Instance.check_Booking(BookingId);
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
		/*public static string getName_Items(BookingForm_DTO BookingId)
		{
			return BookingForm_DAO.Instance.getName_Items(BookingId);
		}
		public static string getAmount_Items(BookingForm_DTO BookingId)
		{
			return BookingForm_DAO.Instance.getAmount_Items(BookingId);
		}*/

		public static List<string> cb_BookingID()
        {
            return BookingForm_DAO.Instance.getBooKingID();
        }
		public static List<string> cb_RoomID()
		{
			return BookingForm_DAO.Instance.getRoomID();
		}
		/*public static DataTable Edit_Reservation(BookingForm_DTO BookingId)//BookingForm_DTO BookingId)
		{
			return BookingForm_DAO.Instance.Edit_Reservation(BookingForm_DTO BookingId);//BookingId);
		}*/
	}
}
