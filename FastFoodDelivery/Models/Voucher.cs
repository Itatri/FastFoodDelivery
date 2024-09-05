using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDelivery.Models
{
    public class Voucher
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("code")]
        public string Code { get; set; }

        [BsonElement("description")]
        public string Description { get; set; } // Thêm trường này

        [BsonElement("discountType")]
        public string DiscountType { get; set; }

        [BsonElement("discountValue")]
        public decimal DiscountValue { get; set; }

        [BsonElement("startDate")]
        public DateTime StartDate { get; set; }

        [BsonElement("endDate")]
        public DateTime EndDate { get; set; }

        [BsonElement("currentUses")]
        public int CurrentUses { get; set; }

        [BsonElement("maxUses")]
        public int MaxUses { get; set; }
    }

}
