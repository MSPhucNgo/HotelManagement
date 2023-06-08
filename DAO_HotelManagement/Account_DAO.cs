using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_HotelManagement
{
    public class Account_DAO
    {
        public static string username;
        public static string id;
        private static Account_DAO instance;

        public static Account_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Account_DAO();
                return Account_DAO.instance;
            }
            private set { Account_DAO.instance = value; }
        }
        private Account_DAO() { }

        public bool Login(string name, string password)
        {
            string query = "exec sp_loginuser " + name + "," + password;
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                username = dr["Username"].ToString();
                id = dr["UserID"].ToString();
                return true;
            }
            return false;
        }
    }
    
}
