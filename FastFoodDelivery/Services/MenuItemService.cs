using FastFoodDelivery.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDelivery.Services
{
    public class MenuItemService
    {
        private readonly IMongoCollection<BsonDocument> _collection;

        public MenuItemService()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("fastfooddelivery");
            _collection = database.GetCollection<BsonDocument>("menuitems");
        }
        // Lay Menu Mon An 
        public List<MenuItem> GetMenuItems()
        {
            var documents = _collection.Find(new BsonDocument()).ToList();
            var menuItems = new List<MenuItem>();

            foreach (var doc in documents)
            {
                menuItems.Add(new MenuItem
                {
                    ItemId = doc["itemId"].AsString,
                    RestaurantId = doc["restaurantId"].AsString, // Thêm dòng này
                    Name = doc["name"].AsString,
                    Description = doc["description"].AsString,
                    Price = doc["price"].IsDouble ? doc["price"].AsDouble : Convert.ToDouble(doc["price"].AsInt32),
                    ImagePath = doc["image"].AsString,
                    Category = doc["category"].AsString
                });
            }

            return menuItems;
        }


    
        // Lay Munu mon an theo nha hang da chon
        public List<MenuItem> GetMenuItemsByRestaurantId(string restaurantId)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("restaurantId", restaurantId);
            var documents = _collection.Find(filter).ToList();
            var menuItems = new List<MenuItem>();

            foreach (var doc in documents)
            {
                // Xác định kiểu dữ liệu của trường price
                var priceBsonValue = doc["price"];
                double price = 0;

                // Kiểm tra kiểu dữ liệu và chuyển đổi
                if (priceBsonValue.IsDouble)
                {
                    price = priceBsonValue.AsDouble;
                }
                else if (priceBsonValue.IsInt32)
                {
                    price = priceBsonValue.AsInt32;
                }
                else if (priceBsonValue.IsInt64)
                {
                    price = priceBsonValue.AsInt64;
                }
                else
                {
                    throw new InvalidCastException("Unsupported price type in database");
                }

                menuItems.Add(new MenuItem
                {
                    ItemId = doc["itemId"].AsString,
                    RestaurantId = doc["restaurantId"].AsString, // Thêm dòng này
                    Name = doc["name"].AsString,
                    Description = doc["description"].AsString,
                    Price = price,
                    Category = doc["category"].AsString,
                      ImagePath = doc.Contains("image") ? doc["image"].AsString : string.Empty // Đảm bảo trường ImagePath được lấy đúng cách
                });
            }

            return menuItems;
        }

        public void AddMenuItem(MenuItem menuItem)
        {
                var document = new BsonDocument
                 {
                { "itemId", menuItem.ItemId },
                { "restaurantId", menuItem.RestaurantId },
                { "name", menuItem.Name },
                { "description", menuItem.Description },
                { "price", menuItem.Price },
                { "image", menuItem.ImagePath },
                { "category", menuItem.Category }
                };

                _collection.InsertOne(document);
         }
        public void UpdateMenuItem(MenuItem menuItem)
        {
            if (menuItem == null)
            {
                throw new ArgumentNullException(nameof(menuItem), "MenuItem cannot be null.");
            }

            if (string.IsNullOrEmpty(menuItem.ItemId))
            {
                throw new ArgumentException("ItemId cannot be null or empty.", nameof(menuItem.ItemId));
            }

            var filter = Builders<BsonDocument>.Filter.Eq("itemId", menuItem.ItemId);
            var update = Builders<BsonDocument>.Update
                .Set("restaurantId", menuItem.RestaurantId)
                .Set("name", menuItem.Name)
                .Set("description", menuItem.Description ?? "")
                .Set("price", menuItem.Price)
                //.Set("image", menuItem.ImagePath ?? "")
                .Set("category", menuItem.Category ?? "");
            if (!string.IsNullOrEmpty(menuItem.ImagePath))
            {
                update = update.Set("image", menuItem.ImagePath);
            }
            _collection.UpdateOne(filter, update);
        }




        public void DeleteMenuItem(string itemId)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("itemId", itemId);
            _collection.DeleteOne(filter);
        }


    }

}
