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
    public partial class BuyHistory : UserControl
    {
        public BuyHistory()
        {
            InitializeComponent();
        }

        private void dataGridViewDonDaGiao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SetupDataGridView()
        {
            // Xóa tất cả các cột hiện tại
            dataGridViewDonDaGiao.Columns.Clear();

            // Thêm các cột mà bạn muốn hiển thị
            dataGridViewDonDaGiao.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "OrderId",
                HeaderText = "Mã Đơn Hàng",
                DataPropertyName = "OrderId" // Liên kết với trường trong DataTable
            });
            dataGridViewDonDaGiao.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Items",
                HeaderText = "Món Đặt",
                DataPropertyName = "Items" // Liên kết với trường trong DataTable
            });
            dataGridViewDonDaGiao.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalAmount",
                HeaderText = "Tổng Tiền",
                DataPropertyName = "TotalAmount" // Liên kết với trường trong DataTable
            });
            dataGridViewDonDaGiao.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Status",
                HeaderText = "Trạng Thái ",
                DataPropertyName = "Status" // Liên kết với trường trong DataTable
            });

            dataGridViewDonDaGiao.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DeliveryAddress",
                HeaderText = "Địa Chỉ Giao Hàng",
                DataPropertyName = "DeliveryAddress" // Liên kết với trường trong DataTable
            });
            dataGridViewDonDaGiao.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "OrderDate",
                HeaderText = "Ngày Đặt",
                DataPropertyName = "OrderDate" // Liên kết với trường trong DataTable
            });
            dataGridViewDonDaGiao.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DeliveryDate",
                HeaderText = "Ngày Giao",
                DataPropertyName = "DeliveryDate" // Liên kết với trường trong DataTable
            });
            // Điều chỉnh cột để tự động điều chỉnh kích thước
            dataGridViewDonDaGiao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private UserInfo currentUser;
        public void SetUserInfo(UserInfo user)
        {
            this.currentUser = user;
        }
        private void BuyHistory_Load(object sender, EventArgs e)
        {
            if (currentUser == null)
            {
                MessageBox.Show("Người dùng chưa được đăng nhập.");
                return;
            }

            SetupDataGridView(); // Cấu hình các cột trước khi gán DataSource

            string loggedInUserId = currentUser.Id;
            var orderService = new OrderService();
            var orders = orderService.GetOrdersByStatusAndUserId("Đã giao", loggedInUserId);

            // Chuyển đổi danh sách đơn hàng thành DataTable với các cột mong muốn
            var dataTable = CreateOrderDataTable(orders);

            dataGridViewDonDaGiao.DataSource = dataTable;
        }

        private DataTable CreateOrderDataTable(IEnumerable<Order> orders)
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("OrderId", typeof(string));
            dataTable.Columns.Add("TotalAmount", typeof(decimal));
            dataTable.Columns.Add("Status", typeof(string));
            dataTable.Columns.Add("DeliveryAddress", typeof(string));
            dataTable.Columns.Add("OrderDate", typeof(DateTime));
            dataTable.Columns.Add("DeliveryDate", typeof(DateTime));
            dataTable.Columns.Add("Items", typeof(string)); // Thêm cột Items



            foreach (var order in orders)
            {
                // Kết hợp tên các món ăn thành một chuỗi
                var items = string.Join(", ", order.Items.Select(item => item.Name));  // Kết hợp tên món ăn thành chuỗi
                dataTable.Rows.Add(order.OrderId, order.TotalAmount, order.Status, order.DeliveryAddress, order.OrderDate, order.DeliveryDate, items);
            }

            return dataTable;
        }

        private void dataGridViewDonDaGiao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có nhấp vào một hàng hợp lệ không
            if (e.RowIndex >= 0)
            {
                // Lấy mã đơn hàng từ cột "OrderId" trong hàng được chọn
                var orderId = dataGridViewDonDaGiao.Rows[e.RowIndex].Cells["OrderId"].Value.ToString();
                var Items = dataGridViewDonDaGiao.Rows[e.RowIndex].Cells["Items"].Value.ToString();
                // Gán mã đơn hàng vào labelMaDH
                labelMaDH.Text = orderId;
                labelMonDat.Text = Items;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void btnGui_Click(object sender, EventArgs e)
        {
            
            // Lấy thông tin từ các điều khiển
            string orderId = labelMaDH.Text;
            string items = labelMonDat.Text;
            string userId = currentUser.Id; // Giả sử bạn đã lưu thông tin người dùng trong currentUser
            int rating = (int)numericUpDownRating.Value;
            string comment = txtNoiDungDG.Text;
            DateTime reviewDate = DateTime.UtcNow; // Lấy ngày hiện tại ở định dạng UTC

            // Tạo đối tượng Review
            var review = new Review
            {
                UserId = userId,
                Items = items,
                OrderId = orderId,
                Rating = rating,
                Comment = comment,
                ReviewDate = reviewDate
            };

            // Gọi dịch vụ để lưu đánh giá
            var reviewService = new ReviewService();
            bool success = await reviewService.AddReviewAsync(review);

            if (success)
            {
                // Thông báo thành công
                MessageBox.Show("Đánh giá của bạn đã được gửi thành công!");
            }
            else
            {
                // Thông báo đã có đánh giá
                MessageBox.Show("Đơn hàng này đã được đánh giá trước đó.");
            }
        }
    }
}
