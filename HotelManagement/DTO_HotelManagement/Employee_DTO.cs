using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_HotelManagement
{
    public class Employee_DTO
    {
        public string idEmp;
        public string name;
        public string birthDay;
        public string email;
        public string address;
        public string phone;
        public string identityCard;
        public string role;

        public string IdEmp { get => idEmp; set => idEmp = value; }
        public string Name { get => name; set => name = value; }
        public string BirthDay { get => birthDay; set => birthDay = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public string IdentityCard { get => identityCard; set => identityCard = value; }
        public string Role { get => role; set => role = value; }
        
        public Employee_DTO(string idemp, string name, string birthday, string email, string phone, string identityCard, string role)
        {
            this.IdEmp = idemp;
            this.Name = name;
            this.BirthDay = birthday;
            this.Email = email;
            this.Phone = phone;
            this.IdentityCard = identityCard;
            this.Role = role;

        }
        public Employee_DTO(string idemp)
        {
            this.IdEmp = idemp;

        }
    }

}


