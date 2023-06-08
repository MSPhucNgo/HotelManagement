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
    }
}
