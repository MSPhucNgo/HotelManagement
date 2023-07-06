using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_HotelManagement
{
    public class DiscountPromotion_DTO
    {
        private string idDiscount;
        private string name;
        private string startTime;
        private string endTime;
        private string description;
        private int requirement;
        private float discountRate;

        public string IdDiscount { get => idDiscount; set => idDiscount = value; }
        public string Name { get => name; set => name = value; }
        public string StartTime { get => startTime; set => startTime = value; }
        public string EndTime { get => endTime; set => endTime = value; }
        public string Description { get => description; set => description = value; }
        public int Requirement { get => requirement; set => requirement = value; }
        public float DiscountRate { get => discountRate; set => discountRate = value; }
    }
}
