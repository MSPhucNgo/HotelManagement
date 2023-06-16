using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_HotelManagement
{
    public class HotelService_DTO
    {
        private string idService;
        private string name;
        private string description;
        private int price;
        private string unit;

        public string IdService { get => idService; set => idService = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int Price { get => price; set => price = value; }
        public string Unit { get => unit; set => unit = value; }
    }
}

