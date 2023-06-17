using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_HotelManagement;
using DTO_HotelManagement;
using System.Data;

namespace BUS_HotelManagement
{
    public class BookingForm_BUS
    {
        BookingForm_DAO daoBookingForm = new BookingForm_DAO();
        public bool checkExistedCTM(string idCard)
        {
            return daoBookingForm.checkExistedCTM(idCard);
        }
        public DataTable getInforExistedCTM(string idCard)
        {
            return daoBookingForm.getInforExistedCTM(idCard);
        }
    }
}
