using FastFoodDelivery.Services;
using MongoDB.Bson;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;  // Để sử dụng lớp Image
using System.IO;       // Để sử dụng lớp File
using System.Collections.Generic; // Để sử dụng List<>
using FastFoodDelivery.Models;    // Để sử dụng OrderItem
using System.Linq;
using MongoDB.Bson.IO;
using Newtonsoft.Json; 



namespace FastFoodDelivery.UserControls
{
    public partial class OrdersControl : UserControl
    {
        private UserInfo currentUser;
        private OrderForm orderForm;

        private RestaurantService _restaurantService;

        private MenuItemService _menuItemService;
        // Luu tong tien chua giam gia
        private decimal totalAmountBeforeDiscount; // Biến lưu tổng tiền trước khi áp dụng voucher

 

        private VoucherService _voucherService;

        private decimal itemPrice = 0; // Biến toàn cục để lưu giá của món ăn được chọn

        private string selectedRestaurantId;

        // Danh sách tạm thời để lưu các món ăn đã chọn
        private List<OrderItem> temporaryOrderItems = new List<OrderItem>();

        public OrdersControl()
        {
            InitializeComponent();
            _restaurantService = new RestaurantService(); // Khởi tạo dịch vụ
            _menuItemService = new MenuItemService();
            _voucherService = new VoucherService();
            _voucherService = new VoucherService();
            SetupDataGridViewHoaDon();
        }

        private void OrdersControl_Load(object sender, EventArgs e)
        {
            LoadRestaurantData();
   

        }



        private void dataGridViewNhaHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có phải click vào hàng hợp lệ không
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridViewNhaHang.Rows[e.RowIndex];
                selectedRestaurantId = selectedRow.Cells["RestaurantId"].Value?.ToString(); // Giả sử cột chứa restaurantId là "RestaurantId"

                if (string.IsNullOrEmpty(selectedRestaurantId))
                {
                    MessageBox.Show("Vui lòng chọn một nhà hàng.");
                }
                else
                {
                    LoadMenuItemData(selectedRestaurantId);
                }
            }

        }

       

        private void LoadRestaurantData()
        {
            var restaurants = _restaurantService.GetRestaurants();

            if (restaurants.Count == 0)
            {
                MessageBox.Show("No restaurants found in the database.");
                return;
            }

            // Cấu hình DataGridView
            dataGridViewNhaHang.AutoGenerateColumns = false;
            dataGridViewNhaHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Thêm các cột vào DataGridView
            dataGridViewNhaHang.Columns.Clear();
            dataGridViewNhaHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "RestaurantId",
                HeaderText = "ID Nhà Hàng",
                DataPropertyName = "RestaurantId", // Đảm bảo cột này có dữ liệu
                Visible = false // Ẩn cột này nếu không muốn hiển thị
            });
            dataGridViewNhaHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                HeaderText = "Tên Nhà Hàng",
                DataPropertyName = "Name",
                Width = 150
            });
            dataGridViewNhaHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Address",
                HeaderText = "Địa Chỉ",
                DataPropertyName = "Address",
                Width = 200
            });
            dataGridViewNhaHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CuisineTypes",
                HeaderText = "Loại Đặc Sản",
                DataPropertyName = "CuisineTypes",
                Width = 150
            });
            dataGridViewNhaHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Rating",
                HeaderText = "Đánh Giá",
                DataPropertyName = "Rating",
                Width = 100
            });

            // Chuyển đổi danh sách nhà hàng thành dạng DataTable để gán vào DataGridView
            var dt = new DataTable();
            dt.Columns.Add("RestaurantId"); // Thêm cột ID
            dt.Columns.Add("Name");
            dt.Columns.Add("Address");
            dt.Columns.Add("CuisineTypes");
            dt.Columns.Add("Rating");

            foreach (var restaurant in restaurants)
            {
                var row = dt.NewRow();
                row["RestaurantId"] = restaurant.RestaurantId.ToString(); // Đảm bảo giá trị ID được gán đúng
                row["Name"] = restaurant.Name;
                row["Address"] = $"{restaurant.Street}, {restaurant.City}";
                row["CuisineTypes"] = string.Join(", ", restaurant.CuisineTypes);
                row["Rating"] = restaurant.Rating;
                dt.Rows.Add(row);
            }

            dataGridViewNhaHang.DataSource = dt;
        }


        private void LoadMenuItemData(string restaurantId)
        {
            var menuItems = _menuItemService.GetMenuItemsByRestaurantId(restaurantId);

            // Cấu hình DataGridView
            dataGridViewMonAn.AutoGenerateColumns = false;
            dataGridViewMonAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Thêm các cột vào DataGridView
            dataGridViewMonAn.Columns.Clear();
            dataGridViewMonAn.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "itemId",
                HeaderText = "Mã Món Ăn",
                DataPropertyName = "itemId",
                Width = 150,
                 Visible = false // Ẩn cột này nếu không muốn hiển thị
            });
            dataGridViewMonAn.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                HeaderText = "Tên Món Ăn",
                DataPropertyName = "Name",
                Width = 150
            });
            dataGridViewMonAn.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Description",
                HeaderText = "Mô Tả",
                DataPropertyName = "Description",
                Width = 250
            });
            dataGridViewMonAn.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Price",
                HeaderText = "Giá",
                DataPropertyName = "Price",
                Width = 100
            });
            dataGridViewMonAn.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Category",
                HeaderText = "Loại",
                DataPropertyName = "Category",
                Width = 150
            });
            dataGridViewMonAn.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ImagePath",
                HeaderText = "Hình Ảnh",
                DataPropertyName = "ImagePath",
                Visible = false // Ẩn cột đường dẫn hình ảnh, không cần hiển thị
            });

            // Chuyển đổi danh sách món ăn thành dạng DataTable để gán vào DataGridView
            var dt = new DataTable();
            dt.Columns.Add("itemId");
            dt.Columns.Add("Name");
            dt.Columns.Add("Description");
            dt.Columns.Add("Price");
            dt.Columns.Add("Category");
            dt.Columns.Add("ImagePath"); // Thêm cột đường dẫn hình ảnh

            foreach (var menuItem in menuItems)
            {
                var row = dt.NewRow();
                row["itemId"] = menuItem.ItemId;
                row["Name"] = menuItem.Name;
                row["Description"] = menuItem.Description;
                row["Price"] = menuItem.Price;
                row["Category"] = menuItem.Category;
                row["ImagePath"] = menuItem.ImagePath; // Lưu đường dẫn hình ảnh vào DataTable

                dt.Rows.Add(row);
            }

            dataGridViewMonAn.DataSource = dt;
        }


        private void dataGridViewMonAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridViewMonAn.Rows[e.RowIndex];

               var itemId = selectedRow.Cells["itemId"].Value?.ToString();
                var name = selectedRow.Cells["Name"].Value?.ToString();
                var description = selectedRow.Cells["Description"].Value?.ToString();
                var price = selectedRow.Cells["Price"].Value?.ToString();
                var category = selectedRow.Cells["Category"].Value?.ToString();
                var imagePath = selectedRow.Cells["ImagePath"].Value?.ToString();

                // Cập nhật các Label trên panelThongTinMonAn
                labelMaMonAN.Text = itemId ?? "Chưa có mã món ăn";
                lbTenMonAn.Text = name ?? "Chưa có tên món ăn";
                lbMoTaMonAn.Text = description ?? "Chưa có mô tả món ăn";
                lbGiaMonAn.Text = price != null ? $"{price} VND" : "Chưa có giá món ăn";
                lbCategory.Text = category ?? "Chưa có loại món ăn";

                // Cập nhật PictureBox nếu có đường dẫn hình ảnh
                if (!string.IsNullOrEmpty(imagePath))
                {
                    string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string absoluteImagePath = Path.Combine(baseDirectory, imagePath);
                    pictureBoxMonAn.SizeMode = PictureBoxSizeMode.Zoom;

                    if (File.Exists(absoluteImagePath))
                    {
                        try
                        {
                            pictureBoxMonAn.Image = Image.FromFile(absoluteImagePath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Không thể tải hình ảnh: {ex.Message}");
                            pictureBoxMonAn.Image = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Tệp hình ảnh không tồn tại tại đường dẫn: {absoluteImagePath}");
                        pictureBoxMonAn.Image = null;
                    }
                }
                else
                {
                    pictureBoxMonAn.Image = null; // Nếu không có hình ảnh
                }

                // Cập nhật giá của món ăn
                itemPrice = decimal.TryParse(price, out var parsedPrice) ? parsedPrice : 0;
            }
        }

        private void btnLocCuaHang_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridViewNhaHang_SelectionChanged(object sender, EventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelThongTinMonAn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxMonAn_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownMonAn_ValueChanged(object sender, EventArgs e)
        {
            // Tính toán thành tiền
            int quantity = (int)numericUpDownMonAn.Value;
            decimal totalPrice = itemPrice * quantity;

            // Cập nhật label hiển thị thành tiền
            lbThanhTien.Text = $"{totalPrice} VND";
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(lbTenMonAn.Text) || numericUpDownMonAn.Value <= 0)
            {
                MessageBox.Show("Vui lòng chọn món ăn và nhập số lượng hợp lệ.");
                return;
            }

            // Tính thành tiền
            var itemId = labelMaMonAN.Text;
            var quantity = numericUpDownMonAn.Value;
            var totalAmount = itemPrice * quantity;
            var itemName = lbTenMonAn.Text;

            bool itemFound = false;

            // Duyệt qua các hàng của DataGridView để kiểm tra món ăn đã tồn tại chưa
            foreach (DataGridViewRow row in dataGridViewHoaDon.Rows)
            {
                if (row.Cells["TênMónĂn"].Value?.ToString() == itemName)
                {
                    // Món ăn đã tồn tại, cập nhật số lượng và tổng tiền
                    var existingQuantity = Convert.ToDecimal(row.Cells["SốLượng"].Value);
                    var existingTotalAmount = Convert.ToDecimal(row.Cells["ThànhTiền"].Value);

                    row.Cells["SốLượng"].Value = existingQuantity + quantity;
                    row.Cells["ThànhTiền"].Value = existingTotalAmount + totalAmount;

                    itemFound = true;
                    break;
                }
            }

            // Nếu món ăn chưa có trong DataGridView, thêm mới
            if (!itemFound)
            {
                dataGridViewHoaDon.Rows.Add(itemId ,itemName, quantity, itemPrice, totalAmount);
            }

            // Reset giá trị của numericUpDownMonAn và lbThanhTien về 0
            numericUpDownMonAn.Value = 0;
            lbThanhTien.Text = "0 VND";

            // Thông báo thêm thành công
            MessageBox.Show("Thêm món ăn thành công!");

            //// Tính tổng tiền 
            CalculateTotal();

        }



       


        private async void btnApplyVoucher_Click(object sender, EventArgs e)
        {
            var voucherCode = txtVoucherCode.Text.Trim();
            Console.WriteLine($"Mã voucher nhập vào: {voucherCode}");

            if (string.IsNullOrEmpty(voucherCode))
            {
                MessageBox.Show("Vui lòng nhập mã voucher.");
                return;
            }

            try
            {
                this.totalAmountBeforeDiscount = Convert.ToDecimal(labelTongHoaDon.Text.Replace(" VND", "").Replace(",", ""));

                var result = await _voucherService.ValidateAndApplyVoucherAsync(voucherCode, this.totalAmountBeforeDiscount);

                if (!result.IsValid)
                {
                    MessageBox.Show(result.Message);
                    lblDiscountAmount.Text = "0 VND";
                    CalculateTotal();
                    return;
                }

                lblDiscountAmount.Text = $"{result.DiscountAmount:0,0} VND";
                var totalAmountAfterDiscount = this.totalAmountBeforeDiscount - result.DiscountAmount;
                labelTongHoaDon.Text = $"{totalAmountAfterDiscount:0,0} VND";

                MessageBox.Show(result.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi áp dụng voucher: {ex.Message}");
                lblDiscountAmount.Text = "0 VND";
                CalculateTotal();
            }
        }

        private void SetupDataGridViewHoaDon()
        {
            dataGridViewHoaDon.Columns.Clear();

            dataGridViewHoaDon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MãMónĂn",
                HeaderText = "Mã Món Ăn"
            });
            dataGridViewHoaDon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TênMónĂn",
                HeaderText = "Tên Món Ăn"
            });
            dataGridViewHoaDon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SốLượng",
                HeaderText = "Số Lượng"
            });
            dataGridViewHoaDon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Giá",
                HeaderText = "Giá"
            });
            dataGridViewHoaDon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ThànhTiền",
                HeaderText = "Thành Tiền"
            });


            dataGridViewHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CalculateTotal()
        {
            decimal totalBill = 0;
            foreach (DataGridViewRow row in dataGridViewHoaDon.Rows)
            {
                if (row.Cells["ThànhTiền"].Value != null)
                {
                    totalBill += Convert.ToDecimal(row.Cells["ThànhTiền"].Value);
                }
            }

            // Hiển thị tổng tiền không có voucher
            labelTongHoaDon.Text = totalBill.ToString("0,0") + " VND";

            // Hiển thị tổng tiền không có voucher
            lbTongTienHD.Text = totalBill.ToString("0,0") + " VND";


        }

        private decimal CalculateTotalAmount()
        {
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in dataGridViewHoaDon.Rows)
            {
                if (row.Cells["Giá"].Value != null && row.Cells["ThànhTiền"].Value != null)
                {
                    decimal price = Convert.ToDecimal(row.Cells["Giá"].Value);
                    int quantity = Convert.ToInt32(row.Cells["SốLượng"].Value);
                    totalAmount += price * quantity;
                }
            }

            return totalAmount;
        }


        private void dataGridViewHoaDon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridViewHoaDon_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        private void dataGridViewHoaDon_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private void btnTestVoucher_Click(object sender, EventArgs e)
        {

        }

       
        public OrdersControl(OrderForm orderForm) : this()
        {
            this.orderForm = orderForm;
        }

        public void SetUserInfo(UserInfo user)
        {
            this.currentUser = user;
        }
        private  void btnDatHang_Click(object sender, EventArgs e)
        {

            // Tạo instance của form Order
             orderForm = new OrderForm();

            // Truyền thông tin người dùng sang form Order
            orderForm.SetMaTK(currentUser.Id);
            orderForm.HoTen(currentUser.Name);
            orderForm.Phone(currentUser.Phone);
            orderForm.DiaChi(currentUser.Address);

            // Lấy giá trị từ txtVoucherCode
            string voucherCode = txtVoucherCode.Text;
            string tongTienHD = lbTongTienHD.Text;
            string discountAmount = lblDiscountAmount.Text;
            string thanhTien = labelTongHoaDon.Text;
            
            // Gọi phương thức SetVoucherCode trên form Order để truyền dữ liệu
            orderForm.SetVoucherCode(voucherCode);
            orderForm.SetTongTienHD(tongTienHD);
            orderForm.SetGiamGia(discountAmount);
            orderForm.SetThanhTien(thanhTien);
            // Tạo DataTable và thêm cột
            DataTable dataTable = new DataTable();

            // Lấy dữ liệu từ dataGridViewHoaDon
            foreach (DataGridViewColumn column in dataGridViewHoaDon.Columns)
            {
                // Kiểm tra kiểu dữ liệu của cột
                Type dataType = column.ValueType ?? typeof(string); // Sử dụng string nếu kiểu dữ liệu không xác định
                dataTable.Columns.Add(column.Name, dataType);
            }

            // Thêm hàng vào DataTable
            foreach (DataGridViewRow row in dataGridViewHoaDon.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataRow dataRow = dataTable.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dataRow[cell.ColumnIndex] = cell.Value ?? DBNull.Value; // Sử dụng DBNull.Value nếu giá trị là null
                    }
                    dataTable.Rows.Add(dataRow);
                }
            }

            // Gọi phương thức SetOrderItems trên form Order để truyền dữ liệu
            orderForm.SetOrderItems(dataTable);

            // Hiển thị form Order
            orderForm.ShowDialog();


        }

        private void dataGridViewHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbMoTaMonAn_Click(object sender, EventArgs e)
        {

        }

        private void labelMaMonAN_Click(object sender, EventArgs e)
        {

        }
    }
}
