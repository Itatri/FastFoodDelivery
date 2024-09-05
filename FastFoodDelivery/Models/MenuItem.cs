using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDelivery.Models
{
    public class MenuItem
    {
        public string ItemId { get; set; }
        public string RestaurantId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImagePath { get; set; }
        public string Category { get; set; }
    }
}
