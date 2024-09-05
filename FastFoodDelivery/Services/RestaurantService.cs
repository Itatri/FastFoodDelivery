using FastFoodDelivery.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDelivery.Services
{
   
    public class RestaurantService
    {
        private readonly IMongoCollection<BsonDocument> _collection;

        public RestaurantService()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("fastfooddelivery");
            _collection = database.GetCollection<BsonDocument>("restaurents");
        }

        public void AddRestaurant(Restaurant restaurant)
        {
            var doc = new BsonDocument
            {
                { "restaurantId", restaurant.RestaurantId },
                { "name", restaurant.Name },
                { "address", new BsonDocument { { "street", restaurant.Street }, { "city", restaurant.City } } },
                { "cuisineTypes", new BsonArray(restaurant.CuisineTypes.Split(',').Select(ct => ct.Trim())) },
                { "rating", BsonNull.Value } // Để giá trị rating là null
            };
            _collection.InsertOne(doc);
        }

        public void UpdateRestaurant(Restaurant updatedRestaurant)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("restaurantId", updatedRestaurant.RestaurantId);
            var update = Builders<BsonDocument>.Update
                .Set("name", updatedRestaurant.Name)
                .Set("address.street", updatedRestaurant.Street)
                .Set("address.city", updatedRestaurant.City)
                .Set("cuisineTypes", new BsonArray(updatedRestaurant.CuisineTypes.Split(',').Select(ct => ct.Trim())))
                .Set("rating", updatedRestaurant.Rating);

            _collection.UpdateOne(filter, update);
        }

        public int GetRestaurantCount()
        {
            return (int)_collection.CountDocuments(new BsonDocument());
        }

        public List<Restaurant> GetRestaurants()
        {
            var documents = _collection.Find(new BsonDocument()).ToList();
            var restaurants = new List<Restaurant>();

            foreach (var doc in documents)
            {
                var cuisineTypes = doc["cuisineTypes"].AsBsonArray.Select(x => x.AsString).ToList();
                var cuisineTypesString = string.Join(", ", cuisineTypes); // Chuyển đổi danh sách thành chuỗi

                restaurants.Add(new Restaurant
                {
                    RestaurantId = doc["restaurantId"].ToString(),
                    Name = doc["name"].AsString,
                    Street = doc["address"]["street"].AsString,
                    City = doc["address"]["city"].AsString,
                    CuisineTypes = cuisineTypesString,
                    Rating = doc["rating"].IsBsonNull ? 0 : doc["rating"].AsDouble // Đổi null thành 0 để tránh lỗi
                });
            }

            return restaurants;
        }

        public void DeleteRestaurant(string restaurantId)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("restaurantId", restaurantId);
            _collection.DeleteOne(filter);
        }

    }
}
