using FastFoodDelivery.Models;
using FastFoodDelivery.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDelivery
{
    public partial class OrderForm : Form
    {

        private readonly OrderService _orderService;
        public OrderForm()
        {
            InitializeComponent();
            _orderService = new OrderService();
            lborderDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        // Phương thức để nhận dữ liệu từ form khác
        public void SetOrderItems(DataTable orderItems)
        {
            dataGridViewMonDaDat.DataSource = orderItems;
            // Tự động điều chỉnh kích thước cột để vừa với dữ liệu
            dataGridViewMonDaDat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void SetMaTK(string maTK)
        {
            labelMaTKOrder.Text = maTK;
        }
        // Phương thức để nhận dữ liệu voucher code
        public void SetVoucherCode(string voucherCode)
        {
            if (string.IsNullOrEmpty(voucherCode))
            {
                labelVoucherSD.Text = "Không có";
            }
            else
            {
                labelVoucherSD.Text = voucherCode;
            }
          

        }
        public void SetTongTienHD(string tongTienHD)
        {
            labelTongTien.Text = tongTienHD;

        }
        public void SetGiamGia(string discountAmount)
        {
            labelGiamGia.Text = discountAmount;

        }
        public void SetThanhTien(string thanhTien)
        {
            labelThanhTien.Text = thanhTien;

        }

      
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        

        public void HoTen(string hoTen)
        {
            txtHoTen.Text = hoTen;
        }

        public void Phone(string phone)
        {
            txtPhone.Text = phone;
        }
        public void DiaChi(string diachi)
        {
            textBoxAddress.Text = diachi;
        }
        private void Order_Load(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private string GenerateOrderId()
        {
            // Lấy số lượng đơn hàng hiện tại
            var orderCount = _orderService.GetOrderCount();

            // Sinh mã đơn hàng với định dạng OD0001, OD0002, ...
            var newOrderId = $"OD{(orderCount + 1).ToString("D4")}";

            return newOrderId;
        }


        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // Loại bỏ chữ VND 
            decimal ParseMonetaryValue(string value)
            {
                // Remove any non-numeric characters (like 'VND')
                var numericValue = value.Replace("VND", "").Trim();
                decimal result;
                if (!decimal.TryParse(numericValue, out result))
                {
                    MessageBox.Show("Giá trị không hợp lệ.");
                    throw new FormatException("Giá trị không hợp lệ.");
                }
                return result;
            }

            // Parse monetary values from labels
            decimal totalAmount = ParseMonetaryValue(labelTongTien.Text);
            decimal discount = ParseMonetaryValue(labelGiamGia.Text);
            decimal finalAmount = ParseMonetaryValue(labelThanhTien.Text);

            var order = new Order
            {
                OrderId = GenerateOrderId(),
                UserId = labelMaTKOrder.Text,
                DeliveryPersonnelId = "Chưa có",
                Status = "Đã đặt",
                StatusHistory = new List<StatusHistory>
                {
                    new StatusHistory
                    {
                        Status = "Đã đặt",
                        Timestamp = DateTime.Now
                    }
                },
                TotalAmount = totalAmount,
                DeliveryFee = 0,
                VoucherCode = labelVoucherSD.Text,
                Discount = discount,
                FinalAmount = finalAmount,
                Name = txtHoTen.Text,
                Phone = txtPhone.Text,
                DeliveryAddress = textBoxAddress.Text,
                Items = _orderService.GetOrderItemsFromGrid(dataGridViewMonDaDat),
                OrderDate = DateTime.Now,
                DeliveryDate = null
            };

            _orderService.SaveOrderToDatabase(order);
            MessageBox.Show("Đơn hàng đã được đặt thành công!");

        }
    }
}
