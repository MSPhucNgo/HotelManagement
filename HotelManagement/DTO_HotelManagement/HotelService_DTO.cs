using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_HotelManagement
{
    public class HotelService_DTO
    {
        public string idService;
        public string name;
        public string description;
        public int price;
        public string unit;
        private string status;

        public string IdService { get => idService; set => idService = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int Price { get => price; set => price = value; }
        public string Unit { get => unit; set => unit = value; }
        public string Status { get => status; set => status = value; }

        public HotelService_DTO() { }
        public HotelService_DTO(string idService, string name, string description, int price, string unit, string status)
        {
            IdService = idService;
            Name = name;
            Description = description;
            Price = price;
            Unit = unit;
            Status = status;
        }   
        public HotelService_DTO(string idService)
        {
            IdService = idService;
        }
    }
}

