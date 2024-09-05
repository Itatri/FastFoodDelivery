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
    public partial class DonGiaoControl : UserControl
    {
        private UserInfo currentUser;
        private OrderService orderService;
        private DeliveryPersonnelService shipperService;
        private List<string> orderStatuses;
        public DonGiaoControl()
        {
            InitializeComponent();
            orderService = new OrderService();
            shipperService = new DeliveryPersonnelService();
            LoadOrderStatuses();
        }
        private void LoadOrderStatuses()
        {
            orderStatuses = new List<string>
            {   "Đã đặt",
                "Xác nhận",
                "Đang chuẩn bị",
                "Đang giao hàng",
                "Đã giao"
            };
            comboboxTrangThai.DataSource = orderStatuses;
    
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
        private void DonGiaoControl_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }
        private void LoadOrders()
        {
       

            var orders = orderService.GetAllOrders();
            var filteredOrders = orders.Where(o => o.DeliveryPersonnelId == labelShipper.Text && o.Status != "Đã giao").ToList();
            var orderDisplayList = filteredOrders.Select(o => new
            {
                OrderId = o.OrderId,
                //DeliveryPersonnelId = o.DeliveryPersonnelId,
                Name = o.Name,
                Phone = o.Phone,
                DeliveryAddress = o.DeliveryAddress,
                DeliveryFee = o.DeliveryFee,
                OrderDate = o.OrderDate,
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
            dataGridViewOrder.Columns["DeliveryFee"].HeaderText = "Phí Giao";
            dataGridViewOrder.Columns["TotalAmount"].HeaderText = "Tổng Tiền";
            dataGridViewOrder.Columns["Discount"].HeaderText = "Giảm Giá";
            dataGridViewOrder.Columns["FinalAmount"].HeaderText = "Số Tiền Cuối Cùng";
            dataGridViewOrder.Columns["VoucherCode"].HeaderText = "Mã Voucher";
            dataGridViewOrder.Columns["Status"].HeaderText = "Trạng Thái";
        }

        private void dataGridViewOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy thông tin của hàng được chọn
                DataGridViewRow row = dataGridViewOrder.Rows[e.RowIndex];
                string orderId = row.Cells["OrderId"].Value.ToString();
                //string deliveryPersonnelId = row.Cells["DeliveryPersonnelId"].Value.ToString();
                string status = row.Cells["Status"].Value.ToString();

                // Cập nhật các điều khiển với thông tin từ hàng được chọn
                txtMaDH.Text = orderId;
                UpdateOrderStatusComboBox(status);
            }
        }

        private void UpdateOrderStatusComboBox(string status)
        {
            // Tìm trạng thái tương ứng trong danh sách
            if (orderStatuses.Contains(status))
            {
                comboboxTrangThai.SelectedItem = status;
            }
            else
            {
                // Nếu không tìm thấy trạng thái, có thể chọn mục mặc định hoặc xóa chọn
                comboboxTrangThai.SelectedIndex = -1; // Xóa chọn
            }
        }

        private void labelShipper_Click(object sender, EventArgs e)
        {

        }

        private void comboboxTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDH.Text))
            {
                MessageBox.Show("Vui lòng chọn một đơn hàng để cập nhật.");
                return;
            }

            // Lấy thông tin từ các điều khiển
            string orderId = txtMaDH.Text;
            //string newDeliveryPersonnelId = comboboxNhanVien.SelectedValue.ToString();
            string newStatus = comboboxTrangThai.SelectedItem.ToString();

            // Lấy thông tin đơn hàng hiện tại
            var order = orderService.GetOrderById(orderId);
            if (order == null)
            {
                MessageBox.Show("Đơn hàng không tồn tại.");
                return;
            }


            // Cập nhật Status và StatusHistory
            order.Status = newStatus;

            var newStatusHistory = new StatusHistory
            {
                Status = newStatus,
                Timestamp = DateTime.UtcNow
            };
            order.StatusHistory.Add(newStatusHistory);

            // Nếu trạng thái là "Đã giao", cập nhật DeliveryDate và tăng totalDeliveries của nhân viên giao hàng
            if (newStatus == "Đã giao")
            {
                order.DeliveryDate = DateTime.UtcNow;

                // Tăng giá trị totalDeliveries của nhân viên giao hàng
                var deliveryPersonnel = shipperService.GetAllDeliveryPersonnel()
                    .FirstOrDefault(dp => dp.DeliveryPersonnelId == labelShipper.Text);

                if (deliveryPersonnel != null)
                {
                    deliveryPersonnel.TotalDeliveries += 1;
                    shipperService.UpdateDeliveryPersonnel(deliveryPersonnel);
                }
            }

            // Cập nhật đơn hàng vào cơ sở dữ liệu
            var updateSuccess = orderService.UpdateOrder(order);
            if (updateSuccess)
            {
                MessageBox.Show("Cập nhật đơn hàng thành công.");
                LoadOrders(); // Tải lại danh sách đơn hàng
            }
            else
            {
                MessageBox.Show("Cập nhật đơn hàng thất bại.");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
