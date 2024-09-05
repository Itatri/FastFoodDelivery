using FastFoodDelivery.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDelivery.Services
{
   public class OrderService
    {
        private readonly IMongoCollection<Order> _orders;

        public OrderService()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("fastfooddelivery");
            _orders = database.GetCollection<Order>("orders");
        }

 
        public List<OrderItem> GetOrderItemsFromGrid(DataGridView dataGridView)
        {
            var orderItems = new List<OrderItem>();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["TênMónĂN"].Value != null) // Khớp với tên cột trong SetupDataGridViewHoaDon
                {

                    var unitPrice = Convert.ToDecimal(row.Cells["Giá"].Value);
                    var quantity = Convert.ToInt32(row.Cells["SốLượng"].Value);

                    var orderItem = new OrderItem
                    {
                        itemId = row.Cells["MãMónĂn"].Value.ToString(),
                        Name = row.Cells["TênMónĂN"].Value.ToString(),
                        Quantity = quantity,
                        UnitPrice = unitPrice,
                        Price = unitPrice * quantity // Tính toán giá
                    };

                    orderItems.Add(orderItem);
                }
            }
            return orderItems;
        }
        // Generate Ma Order
        public int GetOrderCount()
        {
            // Lấy tổng số lượng đơn hàng từ cơ sở dữ liệu
            return (int)_orders.CountDocuments(FilterDefinition<Order>.Empty);
        }


        public void SaveOrderToDatabase(Order order)
        {
            _orders.InsertOne(order);
        }

        // Lay danh sach don hang cho Gio Hang
        public List<Order> GetOrdersByStatusAndUserId(string status, string userId)
        {
            var filter = Builders<Order>.Filter.Eq(o => o.Status, status) &
                         Builders<Order>.Filter.Eq(o => o.UserId, userId);

            return _orders.Find(filter).ToList();
        }
        // Lay danh sach don hang cho LichSuMuaHang
        public List<Order> GetHistoryOrdersByStatusAndUserId(string status, string userId)
        {
            var filter = Builders<Order>.Filter.Eq(o => o.Status, status) &
                         Builders<Order>.Filter.Eq(o => o.UserId, userId);

            return _orders.Find(filter).ToList();
        }
        public List<Order> GetAllOrders()
        {
            return _orders.Find(FilterDefinition<Order>.Empty).ToList();
        }
        public Order GetOrderById(string orderId)
        {
            var filter = Builders<Order>.Filter.Eq(o => o.OrderId, orderId);
            return _orders.Find(filter).FirstOrDefault();
        }
        public bool UpdateOrder(Order updatedOrder)
        {
            var filter = Builders<Order>.Filter.Eq(o => o.OrderId, updatedOrder.OrderId);

            var update = Builders<Order>.Update
                .Set(o => o.DeliveryPersonnelId, updatedOrder.DeliveryPersonnelId)
                .Set(o => o.Status, updatedOrder.Status)
                .Set(o => o.StatusHistory, updatedOrder.StatusHistory)
                .Set(o => o.DeliveryDate, updatedOrder.DeliveryDate);

            var result = _orders.UpdateOne(filter, update);
            return result.ModifiedCount > 0;
        }


    }
}
