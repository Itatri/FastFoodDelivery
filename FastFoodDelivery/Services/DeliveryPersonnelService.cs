using FastFoodDelivery.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDelivery.Services
{
    public class DeliveryPersonnelService
    {
        private readonly IMongoCollection<DeliveryPersonnel> _deliveryPersonnel;

        public DeliveryPersonnelService()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("fastfooddelivery");
            _deliveryPersonnel = database.GetCollection<DeliveryPersonnel>("deliverypersonnel");
        }

        public List<DeliveryPersonnel> GetAllDeliveryPersonnel()
        {
            return _deliveryPersonnel.Find(FilterDefinition<DeliveryPersonnel>.Empty).ToList();
        }

        public void DeleteDeliveryPersonnel(string deliveryPersonnelId)
        {
            var filter = Builders<DeliveryPersonnel>.Filter.Eq(dp => dp.DeliveryPersonnelId, deliveryPersonnelId);
            _deliveryPersonnel.DeleteOne(filter);
        }

        public void AddDeliveryPersonnel(DeliveryPersonnel newDeliveryPersonnel)
        {
            _deliveryPersonnel.InsertOne(newDeliveryPersonnel);
        }

        public void UpdateDeliveryPersonnel(DeliveryPersonnel deliveryPersonnel)
        {
            var filter = Builders<DeliveryPersonnel>.Filter.Eq(dp => dp.DeliveryPersonnelId, deliveryPersonnel.DeliveryPersonnelId);
            var update = Builders<DeliveryPersonnel>.Update
                .Set(dp => dp.Name, deliveryPersonnel.Name)
                .Set(dp => dp.Email, deliveryPersonnel.Email)
                .Set(dp => dp.Phone, deliveryPersonnel.Phone)
                .Set(dp => dp.VehicleType, deliveryPersonnel.VehicleType)
                .Set(dp => dp.LicensePlate, deliveryPersonnel.LicensePlate)
                .Set(dp => dp.Status, deliveryPersonnel.Status)
                .Set(dp => dp.Rating, deliveryPersonnel.Rating)
                .Set(dp => dp.TotalDeliveries, deliveryPersonnel.TotalDeliveries);

            _deliveryPersonnel.UpdateOne(filter, update);
        }

        public DeliveryPersonnel GetShipperByUserId(string userId)
        {
            var filter = Builders<DeliveryPersonnel>.Filter.Eq(s => s.userID, userId);
            return _deliveryPersonnel.Find(filter).FirstOrDefault();
        }
    }
}
