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
    public class Customer_BUS
    {
        public DataTable getCustomer()
        {
            return Customer_DAO.Instance.getCustomer();
        }

        public static bool updateCustomer(Customer_DTO Cusinfo)
        {
            return Customer_DAO.Instance.updateCustomer(Cusinfo);
        }

        public static DataTable getUsedService(Customer_DTO Cusinfo)
        {
            return Customer_DAO.Instance.getUsedService(Cusinfo);
        }
        public static string getCusID_Booking(Customer_DTO Cusinfo)
        {
            return Customer_DAO.Instance.getCusID_Booking(Cusinfo);
        }
        public static bool insertCustomer(Customer_DTO Cusinfo) {
            return Customer_DAO.Instance.insertCustomer(Cusinfo);
        }
    }


}
