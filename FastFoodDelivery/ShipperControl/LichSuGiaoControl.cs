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

namespace FastFoodDelivery.ShipperControl
{
    public partial class LichSuGiaoControl : UserControl
    {
        private OrderService orderService;
        private UserInfo currentUser;
        private DeliveryPersonnelService shipperService;
        public LichSuGiaoControl()
        {
            InitializeComponent();
            shipperService = new DeliveryPersonnelService();
            orderService = new OrderService();
     
        }
        public void SetUserInfo(UserInfo user)
        {
            this.currentUser = user;


            // Lấy thông tin Shipper dựa trên userID và gán DeliveryPersonnelId vào labelShipper
            var shipper = shipperService.GetShipperByUserId(currentUser.Id);
            if (shipper != null)
            {
                labelShipper.Text = shipper.DeliveryPersonnelId;
            }
            else
            {
                labelShipper.Text = "Shipper không tồn tại";
            }
        }
        private void LoadOrders()
        {


            var orders = orderService.GetAllOrders();
            var filteredOrders = orders.Where(o => o.DeliveryPersonnelId == labelShipper.Text && o.Status == "Đã giao").ToList();
            var orderDisplayList = filteredOrders.Select(o => new
            {
                OrderId = o.OrderId,
                //DeliveryPersonnelId = o.DeliveryPersonnelId,
                Name = o.Name,
                Phone = o.Phone,
                DeliveryAddress = o.DeliveryAddress,
                DeliveryFee = o.DeliveryFee,
                OrderDate = o.OrderDate,
                DeliveryDate = o.DeliveryDate,
                TotalAmount = o.TotalAmount,
                Discount = o.Discount,
                FinalAmount = o.FinalAmount,
                VoucherCode = o.VoucherCode,
                Status = o.Status
            }).ToList();

            dataGridViewOrder.DataSource = orderDisplayList;
            dataGridViewOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Đổi tên các cột thành tiếng Việt
            dataGridViewOrder.Columns["OrderId"].HeaderText = "Mã Đơn Hàng";
            dataGridViewOrder.Columns["Name"].HeaderText = "Tên Khách Hàng";
            dataGridViewOrder.Columns["Phone"].HeaderText = "Điện Thoại";
            dataGridViewOrder.Columns["DeliveryAddress"].HeaderText = "Địa Chỉ Giao";
            dataGridViewOrder.Columns["OrderDate"].HeaderText = "Ngày Đặt Hàng";
            dataGridViewOrder.Columns["DeliveryDate"].HeaderText = "Ngày Giao Hàng";
            dataGridViewOrder.Columns["DeliveryFee"].HeaderText = "Phí Giao";
            dataGridViewOrder.Columns["TotalAmount"].HeaderText = "Tổng Tiền";
            dataGridViewOrder.Columns["Discount"].HeaderText = "Giảm Giá";
            dataGridViewOrder.Columns["FinalAmount"].HeaderText = "Số Tiền Cuối Cùng";
            dataGridViewOrder.Columns["VoucherCode"].HeaderText = "Mã Voucher";
            dataGridViewOrder.Columns["Status"].HeaderText = "Trạng Thái";
        }
        private void dataGridViewOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LichSuGiaoControl_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }
    }
}
