using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDelivery.Models
{
    public class DeliveryPersonnel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("DeliveryPersonnelId")]
        public string DeliveryPersonnelId { get; set; }

        [BsonElement("userID")]
        public string userID { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("phone")]
        public string Phone { get; set; }

        [BsonElement("vehicleType")]
        public string VehicleType { get; set; }

        [BsonElement("licensePlate")]
        public string LicensePlate { get; set; }

        [BsonElement("status")]
        public string Status { get; set; }

        [BsonElement("rating")]
        public double Rating { get; set; }

        [BsonElement("totalDeliveries")]
        public int TotalDeliveries { get; set; }
    }
}
