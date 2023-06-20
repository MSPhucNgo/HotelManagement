using DTO_HotelManagement;
using DTO_HoTelManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_HotelManagement
{
    public class Services_for_customer_DAO
    {
        public static Services_for_customer_DAO instance;

        public static Services_for_customer_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Services_for_customer_DAO();
                return Services_for_customer_DAO.instance;
            }
            private set { Services_for_customer_DAO.instance = value; }
        }
        public Services_for_customer_DAO() { }

        public DataTable usp_SearchRoomByID_svs(Room_DTO roomId)
        {
            string query ="exec usp_SearchRoomByID_svs '" + roomId.IdRoom + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;

        }
        public DataTable usp_getServicesOfRoom_svs(Room_DTO roomId, HotelService_DTO hotelService_)
        {
            string query;
            if (hotelService_ == null)
            {
                query = "exec usp_getServicesOfRoom_svs '" + roomId.IdRoom + "', N'"  + "'";
            }
            query = "exec usp_getServicesOfRoom_svs '" + roomId.IdRoom + "', N'"+hotelService_.name+ "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public HotelService_DTO usp_getDetailOfService_svs (HotelService_DTO hotelService)
        {
            string query = "exec usp_getDetailOfService_svs '" + hotelService.IdService + "'";
            HotelService_DTO hotelService_ = new HotelService_DTO();
            DataTable dt  = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow dr in dt.Rows)
            {
                hotelService_.IdService = dr["ID_SERVICE"].ToString();
                hotelService_.Name = dr["NAME"].ToString();
                hotelService_.Price = Int32.Parse(dr["PRICE"].ToString());
                hotelService_.Unit = dr["UNIT"].ToString();
                hotelService_.Description = dr["DESCRIPTION"].ToString();
                hotelService_.Status = dr["STATUS"].ToString();
                return hotelService_;
            }
            return null;
        }
        public DataTable usp_getDiscountOfService_svs(HotelService_DTO hotelService)
        {
            string query = "exec usp_getDiscountOfService_svs '" + hotelService.idService + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }
        public DataTable usp_getAllServices_svs(HotelService_DTO hotelService_)
        {
            string query = "exec usp_getAllServices_svs N'" + hotelService_.Name + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public int usp_AddServiceCoupon(Service_Form_DTO service_Form, Service_Bill_DTO service_Bill)
        {
            string query = "exec usp_AddServiceCoupon '" + service_Form.Customer + "', N'" + service_Form.Name + "', '" + service_Form.IdService + "', N'" + service_Form.Description + "', " + service_Form.Price + ", " + service_Form.Amount + ", '" + service_Form.FormCreator + "', " + service_Bill.TotalPrice + ", '" + service_Bill.UsedDate + "', " + service_Bill.Discount +", '"+ service_Bill.IdServiceBill+"'";
            int index = DataProvider.Instance.ExecuteNonQuery(query);
            return 1;
        }

    }
}
