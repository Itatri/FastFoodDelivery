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

    public class VoucherService
    {
        private readonly IMongoCollection<Voucher> _voucherCollection;

        public VoucherService()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("fastfooddelivery");
            _voucherCollection = database.GetCollection<Voucher>("promotions");
        }
        // Lay voucher dua vao voucher da nhap 
        public async Task<Voucher> GetVoucherByCodeAsync(string code)
        {
            Console.WriteLine($"Đang tìm kiếm voucher với mã: {code}");

            var filter = Builders<Voucher>.Filter.Eq(v => v.Code, code);
            var voucher = await _voucherCollection.Find(filter).FirstOrDefaultAsync();

            if (voucher == null)
            {
                Console.WriteLine("Không tìm thấy voucher.");
            }
            else
            {
                Console.WriteLine($"Tìm thấy voucher: {voucher.Code}, Giảm giá: {voucher.DiscountValue}");
            }

            return voucher;
        }
        // Kiem tra va ap dung khuyen mai cua vouvher
        public async Task<(bool IsValid, decimal DiscountAmount, string Message)> ValidateAndApplyVoucherAsync(string code, decimal totalAmount)
        {
            var voucher = await GetVoucherByCodeAsync(code);

            // Kiểm tra xem voucher có tồn tại không
            if (voucher == null)
            {
                Console.WriteLine("Voucher không tồn tại.");
                return (false, 0, "Voucher không tồn tại.");
            }

            // Kiểm tra ngày hiệu lực của voucher
            var currentDate = DateTime.UtcNow;
            if (voucher.StartDate > currentDate || voucher.EndDate < currentDate)
            {
                Console.WriteLine("Voucher đã hết hạn.");
                return (false, 0, "Voucher đã hết hạn.");
            }

            // Kiểm tra số lần sử dụng của voucher
            if (voucher.CurrentUses >= voucher.MaxUses)
            {
                Console.WriteLine("Voucher đã hết số lần sử dụng.");
                return (false, 0, "Voucher đã hết số lần sử dụng.");
            }

            // Tính toán số tiền giảm giá
            decimal discountAmount = 0;
            if (voucher.DiscountType == "Giảm % bill")
            {
                discountAmount = totalAmount * (voucher.DiscountValue / 100);
            }
            else if (voucher.DiscountType == "Giảm tiền")
            {
                discountAmount = voucher.DiscountValue;
            }

            Console.WriteLine($"Số tiền giảm giá: {discountAmount}");

            // Cập nhật số lần sử dụng voucher
            var update = Builders<Voucher>.Update.Inc(v => v.CurrentUses, 1);
            await _voucherCollection.UpdateOneAsync(v => v.Code == code, update);

            return (true, discountAmount, "Voucher hợp lệ.");
        }

        // Lấy danh sách tất cả các voucher
        public async Task<List<Voucher>> GetAllVouchersAsync()
        {
            return await _voucherCollection.Find(new BsonDocument()).ToListAsync();
        }
        public List<Voucher> GetAllVouchers()
        {
            return _voucherCollection.Find(voucher => true).ToList();
        }

        public void DeleteVoucher(string voucherCode)
        {
            _voucherCollection.DeleteOne(v => v.Code == voucherCode);
        }
        public async Task CreateVoucherAsync(Voucher newVoucher)
        {
            await _voucherCollection.InsertOneAsync(newVoucher);
        }


        public async Task UpdateVoucherAsync(Voucher updatedVoucher)
        {
            var filter = Builders<Voucher>.Filter.Eq(v => v.Code, updatedVoucher.Code);
            var update = Builders<Voucher>.Update
                .Set(v => v.Description, updatedVoucher.Description)
                .Set(v => v.DiscountType, updatedVoucher.DiscountType)
                .Set(v => v.DiscountValue, updatedVoucher.DiscountValue)
                .Set(v => v.StartDate, updatedVoucher.StartDate)
                .Set(v => v.EndDate, updatedVoucher.EndDate)
                .Set(v => v.MaxUses, updatedVoucher.MaxUses)
                .Set(v => v.CurrentUses, updatedVoucher.CurrentUses);

            await _voucherCollection.UpdateOneAsync(filter, update);
        }


    }

}
