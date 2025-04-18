using FastFoodDelivery.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;

namespace FastFoodDelivery.Services
{
    public class ReviewService
    {
        private readonly IMongoCollection<Review> _reviews;

        public ReviewService()
        {

            var connectionString = ConfigurationManager.AppSettings["MongoDB:ConnectionString"];
            var databaseName = ConfigurationManager.AppSettings["MongoDB:DatabaseName"];
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            _reviews = database.GetCollection<Review>("reviews");
        }

        public async Task<bool> OrderIdExistsAsync(string orderId)
        {
            var filter = Builders<Review>.Filter.Eq(r => r.OrderId, orderId);
            var result = await _reviews.Find(filter).FirstOrDefaultAsync();
            return result != null;
        }

        public async Task<bool> AddReviewAsync(Review review)
        {
            if (await OrderIdExistsAsync(review.OrderId))
            {
                return false; // OrderId đã tồn tại
            }

            await _reviews.InsertOneAsync(review);
            return true; // Đã chèn thành công
        }
        // Các phương thức cập nhật và xóa có thể được thêm vào đây
        public async Task<List<Review>> GetAllReviewsAsync()
        {
            return await _reviews.Find(review => true).ToListAsync();
        }

    }
}
