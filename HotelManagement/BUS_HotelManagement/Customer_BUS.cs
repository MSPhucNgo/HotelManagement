using DAO_HotelManagement;
using DTO_HotelManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_HotelManagement
{
    public class Customer_BUS
    {
        public static bool updateCustomer(Customer_DTO Cusinfo)
        {
            return Customer_DAO.Instance.updateCustomer(Cusinfo);
        }
    }
}
