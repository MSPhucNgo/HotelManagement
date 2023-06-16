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
    public class Services_for_customer_BUS
    {
        //public Services_for_customer_BUS() { }

        public static DataTable usp_SearchRoomByID_svs(Room_DTO roomId)
        {
            return Services_for_customer_DAO.Instance.usp_SearchRoomByID_svs(roomId);
        }
        public static DataTable usp_getServicesOfRoom_svs(Room_DTO roomId)
        {
            return Services_for_customer_DAO.Instance.usp_getServicesOfRoom_svs(roomId);
        }

        public static HotelService_DTO usp_getDetailOfService_svs (HotelService_DTO hotelService)
        {
            return Services_for_customer_DAO.Instance.usp_getDetailOfService_svs(hotelService);
        }
        public static DataTable usp_getDiscountOfService_svs(HotelService_DTO hotelService)
        {
            return Services_for_customer_DAO.Instance.usp_getDiscountOfService_svs(hotelService);
        }


    }
}
