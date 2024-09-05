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

namespace FastFoodDelivery.AdminControls
{
    public partial class OrderDeliveryControl : UserControl
    {
        private UserInfo currentUser;
        private OrderService orderService;
        private DeliveryPersonnelService deliveryPersonnelService;
        private List<string> orderStatusesInVietnamese;
        public OrderDeliveryControl()
        {
            InitializeComponent();
            orderService = new OrderService();
            deliveryPersonnelService = new DeliveryPersonnelService();
            LoadDeliveryPersonnel();
            LoadOrderStatuses();

        }
   
        public void SetUserInfo(UserInfo user)
        {
            this.currentUser = user;
        }
        private void OrderDeliveryControl_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }
        private void LoadOrderStatuses()
        {
            orderStatusesInVietnamese = new List<string>
            {   "Đã đặt",
                "Xác nhận",
                "Đang chuẩn bị",
                "Đang giao hàng",
                "Đã giao"
            };
            comboboxTrangThai.DataSource = orderStatusesInVietnamese;
            // Nạp dữ liệu vào comboBoxLocTrangThai
            comboBoxLocTrangThai.DataSource = new List<string>(orderStatusesInVietnamese);
        }
        private void LoadDeliveryPersonnel()
        {
            var deliveryPersonnel = deliveryPersonnelService.GetAllDeliveryPersonnel();

            // Nạp dữ liệu vào comboboxNhanVien
            comboboxNhanVien.DataSource = deliveryPersonnel;
            comboboxNhanVien.DisplayMember = "name";
            comboboxNhanVien.ValueMember = "DeliveryPersonnelId";


            // Nạp dữ liệu vào comboBoxLocNguoiGiao
            comboBoxLocNguoiGiao.DataSource = deliveryPersonnel;
            comboBoxLocNguoiGiao.DisplayMember = "name";
            comboBoxLocNguoiGiao.ValueMember = "DeliveryPersonnelId";
        }

        private void LoadOrders()
        {
            var orders = orderService.GetAllOrders();
            var orderDisplayList = orders.Select(o => new
            {
                OrderId = o.OrderId,
                //UserId = o.UserId,
                DeliveryPersonnelId = o.DeliveryPersonnelId,
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
            //dataGridViewOrder.Columns["UserId"].HeaderText = "Mã Khách Hàng";
            dataGridViewOrder.Columns["Name"].HeaderText = "Tên Khách Hàng";
            dataGridViewOrder.Columns["Phone"].HeaderText = " Điện Thoại";
            dataGridViewOrder.Columns["DeliveryAddress"].HeaderText = "Địa Chỉ Giao ";
            dataGridViewOrder.Columns["OrderDate"].HeaderText = "Ngày Đặt Hàng";
            dataGridViewOrder.Columns["DeliveryPersonnelId"].HeaderText = "Nhân viên giao ";
            dataGridViewOrder.Columns["DeliveryFee"].HeaderText = "Phí Giao ";
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
                string deliveryPersonnelId = row.Cells["DeliveryPersonnelId"].Value.ToString();
                string status = row.Cells["Status"].Value.ToString();

                // Cập nhật các điều khiển với thông tin từ hàng được chọn
                txtMaDH.Text = orderId;
                UpdateDeliveryPersonnelComboBox(deliveryPersonnelId);
                UpdateOrderStatusComboBox(status);
            }
        }
        private void UpdateDeliveryPersonnelComboBox(string deliveryPersonnelId)
        {
            // Lấy danh sách tất cả nhân viên giao hàng
            var deliveryPersonnelList = deliveryPersonnelService.GetAllDeliveryPersonnel();

            // Tìm nhân viên giao hàng tương ứng với deliveryPersonnelId
            var selectedDeliveryPersonnel = deliveryPersonnelList.FirstOrDefault(dp => dp.DeliveryPersonnelId == deliveryPersonnelId);

            if (selectedDeliveryPersonnel != null)
            {
                // Chọn item tương ứng trong combobox
                comboboxNhanVien.SelectedValue = selectedDeliveryPersonnel.DeliveryPersonnelId;
            }
            else
            {
                // Nếu không tìm thấy nhân viên, có thể chọn mục mặc định hoặc xóa chọn
                comboboxNhanVien.SelectedIndex = -1; // Xóa chọn
            }
        }


        private void UpdateOrderStatusComboBox(string status)
        {
            // Tìm trạng thái tương ứng trong danh sách
            if (orderStatusesInVietnamese.Contains(status))
            {
                comboboxTrangThai.SelectedItem = status;
            }
            else
            {
                // Nếu không tìm thấy trạng thái, có thể chọn mục mặc định hoặc xóa chọn
                comboboxTrangThai.SelectedIndex = -1; // Xóa chọn
            }
        }



        private void comboboxNhanVien_SelectedIndexChanged(object sender, EventArgs e)
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
            string newDeliveryPersonnelId = comboboxNhanVien.SelectedValue.ToString();
            string newStatus = comboboxTrangThai.SelectedItem.ToString();

            // Lấy thông tin đơn hàng hiện tại
            var order = orderService.GetOrderById(orderId);
            if (order == null)
            {
                MessageBox.Show("Đơn hàng không tồn tại.");
                return;
            }

            // Cập nhật DeliveryPersonnelId
            order.DeliveryPersonnelId = newDeliveryPersonnelId;

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
                var deliveryPersonnel = deliveryPersonnelService.GetAllDeliveryPersonnel()
                    .FirstOrDefault(dp => dp.DeliveryPersonnelId == newDeliveryPersonnelId);

                if (deliveryPersonnel != null)
                {
                    deliveryPersonnel.TotalDeliveries += 1;
                    deliveryPersonnelService.UpdateDeliveryPersonnel(deliveryPersonnel);
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

        private void btnLoc_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ các ComboBox lọc
                var selectedStatus = comboBoxLocTrangThai.SelectedItem?.ToString();
                var selectedDeliveryPersonnelId = comboBoxLocNguoiGiao.SelectedValue?.ToString();

                // Lấy tất cả đơn hàng từ dịch vụ
                var allOrders = orderService.GetAllOrders();

                // Lọc đơn hàng dựa trên các giá trị đã chọn
                var filteredOrders = allOrders.AsQueryable();

                if (!string.IsNullOrEmpty(selectedStatus))
                {
                    filteredOrders = filteredOrders.Where(o => o.Status == selectedStatus);
                }

                if (!string.IsNullOrEmpty(selectedDeliveryPersonnelId))
                {
                    filteredOrders = filteredOrders.Where(o => o.DeliveryPersonnelId == selectedDeliveryPersonnelId);
                }

                // Chuyển đổi danh sách đơn hàng đã lọc thành danh sách để hiển thị trên DataGridView
                var orderDisplayList = filteredOrders.Select(o => new
                {
                    OrderId = o.OrderId,
                    DeliveryPersonnelId = o.DeliveryPersonnelId,
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

                // Hiển thị danh sách đơn hàng đã lọc lên DataGridView
                dataGridViewOrder.DataSource = orderDisplayList;

                if (!orderDisplayList.Any())
                {
                    MessageBox.Show("Không có đơn hàng phù hợp với bộ lọc.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình lọc: " + ex.Message);
            }
        }

        private void btnTatCaDon_Click(object sender, EventArgs e)
        {
              try
            {
                

                // Lấy tất cả đơn hàng từ dịch vụ
                var allOrders = orderService.GetAllOrders();

                // Lọc đơn hàng dựa trên các giá trị đã chọn
                var filteredOrders = allOrders;

            
                // Chuyển đổi danh sách đơn hàng đã lọc thành danh sách để hiển thị trên DataGridView
                var orderDisplayList = filteredOrders.Select(o => new
                {
                    OrderId = o.OrderId,
                    DeliveryPersonnelId = o.DeliveryPersonnelId,
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

                // Hiển thị danh sách đơn hàng đã lọc lên DataGridView
                dataGridViewOrder.DataSource = orderDisplayList;

                if (!orderDisplayList.Any())
                {
                    MessageBox.Show("Không có đơn hàng phù hợp với bộ lọc.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình lọc: " + ex.Message);
            }
        }
    }
}
