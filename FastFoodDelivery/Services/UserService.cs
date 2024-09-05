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
    internal class UserService
    {
        private readonly IMongoCollection<BsonDocument> _userCollection;

        public UserService()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("fastfooddelivery");
            _userCollection = database.GetCollection<BsonDocument>("users");
        }

        // Lay thong tin tai khoan
        public UserInfo AuthenticateUser(string username, string password)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("username", username) &
                         Builders<BsonDocument>.Filter.Eq("password", password);
            var userDoc = _userCollection.Find(filter).FirstOrDefault();

            if (userDoc != null)
            {
                return new UserInfo
                {   Id = userDoc["userID"].AsString,
                    Username = userDoc["username"].AsString,
                    Name = userDoc["name"].AsString,
                    Email = userDoc["email"].AsString,
                    Phone = userDoc["phone"].AsString,
                    Address = userDoc.GetValue("address", "").AsString,
                    RegistrationDate = userDoc.GetValue("registrationDate", DateTime.MinValue).ToUniversalTime(),
                    Role = userDoc["role"].AsString,
                    AvatarPath = userDoc["avatar"].AsString
                };
            }
            return null;
        }



        public bool UpdateUserInfo(string userId, string username, string password, string name, string email, string phone, string address, string avatarPath)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("userID", userId);

            var updateDefinitions = new List<UpdateDefinition<BsonDocument>>
        {
            Builders<BsonDocument>.Update.Set("username", username),
            //Builders<BsonDocument>.Update.Set("password", password),
            Builders<BsonDocument>.Update.Set("name", name),
            Builders<BsonDocument>.Update.Set("email", email),
            Builders<BsonDocument>.Update.Set("phone", phone),
            Builders<BsonDocument>.Update.Set("address", address)
        };

            if (!string.IsNullOrEmpty(avatarPath))
            {
                updateDefinitions.Add(Builders<BsonDocument>.Update.Set("avatar", avatarPath));
            }
            // Nếu mật khẩu không phải là null, cập nhật mật khẩu
            if (!string.IsNullOrEmpty(password))
            {
                updateDefinitions.Add(Builders<BsonDocument>.Update.Set("password", password));
            }
            var update = Builders<BsonDocument>.Update.Combine(updateDefinitions);
            var result = _userCollection.UpdateOne(filter, update);

            return result.ModifiedCount > 0;
        }

        public bool UpdateUserInfoAdmin(string userId, string username, string password, string name, string email, string phone, string address, string role, string avatarPath)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("userID", userId);

            var updateDefinitions = new List<UpdateDefinition<BsonDocument>>
    {
        Builders<BsonDocument>.Update.Set("username", username),
        Builders<BsonDocument>.Update.Set("name", name),
        Builders<BsonDocument>.Update.Set("email", email),
        Builders<BsonDocument>.Update.Set("phone", phone),
        Builders<BsonDocument>.Update.Set("address", address),
        Builders<BsonDocument>.Update.Set("role", role) // Cập nhật vai trò
    };

            if (!string.IsNullOrEmpty(avatarPath))
            {
                updateDefinitions.Add(Builders<BsonDocument>.Update.Set("avatar", avatarPath));
            }

            if (!string.IsNullOrEmpty(password))
            {
                updateDefinitions.Add(Builders<BsonDocument>.Update.Set("password", password));
            }

            var update = Builders<BsonDocument>.Update.Combine(updateDefinitions);
            var result = _userCollection.UpdateOne(filter, update);

            return result.ModifiedCount > 0;
        }
        public string GetNextUserId()
        {
            var filter = Builders<BsonDocument>.Filter.Empty;
            var sort = Builders<BsonDocument>.Sort.Descending("userID");
            var lastUser = _userCollection.Find(filter).Sort(sort).Limit(1).FirstOrDefault();

            if (lastUser != null)
            {
                var lastUserId = lastUser["userID"].AsString;
                var lastNumber = int.Parse(lastUserId.Substring(2)); // Lấy số sau "TK"
                var nextNumber = lastNumber + 1;
                return $"TK{nextNumber:D4}"; // Đảm bảo định dạng 4 chữ số
            }

            return "TK0001"; // Nếu không có người dùng nào, bắt đầu từ TK0001
        }

      

        public bool CreateNewUser(string username, string password, string name, string email, string phone, string address, string role, string avatarPath)
        {
            var newUserId = GetNextUserId(); // Lấy ID mới

            var newUser = new BsonDocument
            {
                { "userID", newUserId }, // Sử dụng ID mới
                { "username", username },
                { "password", password },
                { "name", name },
                { "email", email },
                { "phone", phone },
                { "address", address },
                { "registrationDate", DateTime.UtcNow }, // Ngày đăng ký
                { "role", role },
                { "avatar", avatarPath }
            };

            _userCollection.InsertOne(newUser);
            return true;
        }

        public bool CreateNewUserShipper(string userID, string username, string password, string name, string email, string phone, string address, string role, string avatarPath)
        {

            var newUser = new BsonDocument
            {
                { "userID", userID }, // Sử dụng ID mới
                { "username", username },
                { "password", password },
                { "name", name },
                { "email", email },
                { "phone", phone },
                { "address", address },
                { "registrationDate", DateTime.UtcNow }, // Ngày đăng ký
                { "role", role },
                { "avatar", avatarPath }
            };

            _userCollection.InsertOne(newUser);
            return true;
        }
        public List<BsonDocument> GetAllUsers()
        {
            return _userCollection.Find(new BsonDocument()).ToList();
        }

        public bool DeleteUser(string userId)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("userID", userId);
            var result = _userCollection.DeleteOne(filter);
            return result.DeletedCount > 0;
        }

    }
}
