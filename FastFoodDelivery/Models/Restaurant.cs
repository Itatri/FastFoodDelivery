using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDelivery.Models
{
    public class Restaurant
    {
     
        public string RestaurantId { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        //public List<string> CuisineTypes { get; set; }
        public string CuisineTypes { get; set; } // Chuyển đổi thành chuỗi
        public double Rating { get; set; }
    }
}
