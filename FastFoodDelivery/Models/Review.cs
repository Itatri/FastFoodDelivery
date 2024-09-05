using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDelivery.Models
{
    public class Review
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public string UserId { get; set; }
        public string Items { get; set; }
        public string OrderId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }
    }
}
