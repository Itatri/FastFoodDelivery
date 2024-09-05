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

namespace FastFoodDelivery.UserControls
{
    public partial class CartControl : UserControl
    {
        public CartControl()
        {
            InitializeComponent();
        }
        private UserInfo currentUser;
        public void SetUserInfo(UserInfo user)
        {
            this.currentUser = user;
        }

        private void CartControl_Load(object sender, EventArgs e)
        {
            if (currentUser == null)
            {
                MessageBox.Show("Người dùng chưa được đăng nhập.");
                return;
            }

            SetupDataGridView(); // Cấu hình các cột trước khi gán DataSource

            string loggedInUserId = currentUser.Id;
            var orderService = new OrderService();
            var orders = orderService.GetOrdersByStatusAndUserId("Đã đặt", loggedInUserId);

            // Chuyển đổi danh sách đơn hàng thành DataTable với các cột mong muốn
            var dataTable = CreateOrderDataTable(orders);

            dataGridViewDonDaDat.DataSource = dataTable;

        }
        private DataTable CreateOrderDataTable(IEnumerable<Order> orders)
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("OrderId", typeof(string));
            dataTable.Columns.Add("TotalAmount", typeof(decimal));
            dataTable.Columns.Add("Status", typeof(string));
            dataTable.Columns.Add("DeliveryAddress", typeof(string));
            dataTable.Columns.Add("OrderDate", typeof(DateTime));
            dataTable.Columns.Add("DeliveryDate", typeof(string));
            dataTable.Columns.Add("Items", typeof(string)); // Thêm cột Items

            

            foreach (var order in orders)
            {
                // Nếu DeliveryDate không có giá trị, hiển thị "Đang cập nhật"
                var deliveryDate = order.DeliveryDate.HasValue ? order.DeliveryDate.Value.ToString("dd/MM/yyyy") : "Đang cập nhật";
                // Kết hợp tên các món ăn thành một chuỗi
                var items = string.Join(", ", order.Items.Select(item => item.Name));  // Kết hợp tên món ăn thành chuỗi

                dataTable.Rows.Add(order.OrderId, order.TotalAmount, order.Status, order.DeliveryAddress, order.OrderDate, deliveryDate, items);
            }

            return dataTable;
        }
        private void SetupDataGridView()
        {
            // Xóa tất cả các cột hiện tại
            dataGridViewDonDaDat.Columns.Clear();

        
            // Thêm các cột mà bạn muốn hiển thị
            dataGridViewDonDaDat.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "OrderId",
                HeaderText = "Mã Đơn Hàng",
                DataPropertyName = "OrderId" // Liên kết với trường trong DataTable
            });
            dataGridViewDonDaDat.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Items",
                HeaderText = "Món Đặt",
                DataPropertyName = "Items"
            });
            dataGridViewDonDaDat.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalAmount",
                HeaderText = "Tổng Tiền",
                DataPropertyName = "TotalAmount" // Liên kết với trường trong DataTable
            });
            dataGridViewDonDaDat.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Status",
                HeaderText = "Trạng Thái ",
                DataPropertyName = "Status" // Liên kết với trường trong DataTable
            });

            dataGridViewDonDaDat.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DeliveryAddress",
                HeaderText = "Địa Chỉ Giao Hàng",
                DataPropertyName = "DeliveryAddress" // Liên kết với trường trong DataTable
            });
            dataGridViewDonDaDat.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "OrderDate",
                HeaderText = "Ngày Đặt",
                DataPropertyName = "OrderDate" // Liên kết với trường trong DataTable
            });
            dataGridViewDonDaDat.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DeliveryDate",
                HeaderText = "Ngày Giao",
                DataPropertyName = "DeliveryDate" // Liên kết với trường trong DataTable
            });

          
            // Điều chỉnh cột để tự động điều chỉnh kích thước
            dataGridViewDonDaDat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridViewDonDaDat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
