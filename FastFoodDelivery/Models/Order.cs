using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDelivery.Models
{
    public class Order
    {
        public ObjectId Id { get; set; } // Sử dụng ObjectId cho MongoDB
        public string OrderId { get; set; }
        public string UserId { get; set; }
        //public string RestaurantId { get; set; }
        public List<OrderItem> Items { get; set; }
        public string DeliveryPersonnelId { get; set; } // Nếu cần
        public string VoucherCode { get; set; } // Nếu cần
        public decimal TotalAmount { get; set; }
        public decimal Discount { get; set; } // Nếu cần
        public decimal FinalAmount { get; set; } // Nếu cần
        public string Name { get; set; }
        public string Phone { get; set; }
        public string DeliveryAddress { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public List<StatusHistory> StatusHistory { get; set; }
        public string Status { get; set; }
        public decimal DeliveryFee { get; set; }
    }



    public class StatusHistory
    {
        public string Status { get; set; }
        public DateTime Timestamp { get; set; }
    }

}
