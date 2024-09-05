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
using System.IO;


namespace FastFoodDelivery.AdminControls
{
    public partial class ProductControl : UserControl
    {
        private UserInfo currentUser;
        private MenuItemService menuItemService;
        private RestaurantService restaurantService;
        private string selectedImagePath; // Biến lưu trữ đường dẫn hình ảnh đã chọn
        public ProductControl()
        {
            InitializeComponent();
            menuItemService = new MenuItemService();
            restaurantService = new RestaurantService();


            // Disable input fields and buttons initially
            SetFieldsEnabled(false);
        }
        private void SetFieldsEnabled(bool enabled)
        {
            txtTenMonAn.Enabled = enabled;
            txtMoTaMonAn.Enabled = enabled;
            txtGiaMonAn.Enabled = enabled;
            txtCategory.Enabled = enabled;
            comboBoxCuaHang.Enabled = enabled;
            btnUploadImage.Enabled = enabled;

        }

        public void SetUserInfo(UserInfo user)
        {
            this.currentUser = user;
        }
        private void ProductControl_Load(object sender, EventArgs e)
        {
            LoadMenuItems();
            LoadRestaurantNames(); // Gọi phương thức để tải tên cửa hàng
                                   //dataGridViewSanPham.CellClick += dataGridViewSanPham_CellClick; // Thêm sự kiện CellClick
            dataGridViewSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Đảm bảo chọn cả hàng
            dataGridViewSanPham.MultiSelect = false; // Nếu chỉ cần chọn 1 hàng tại 1 thời điểm
            dataGridViewSanPham.CellClick += dataGridViewSanPham_CellClick; // Gán sự kiện 
        }
        private void LoadMenuItems()
        {
            var menuItems = menuItemService.GetMenuItems(); // Lấy tất cả món ăn
            dataGridViewSanPham.DataSource = menuItems; // Gán nguồn dữ liệu cho DataGridView
                                                        // Điều chỉnh cột để tự động điều chỉnh kích thước
            dataGridViewSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadRestaurantNames()
        {
            var restaurants = restaurantService.GetRestaurants();
            comboBoxCuaHang.DataSource = restaurants;
            comboBoxCuaHang.DisplayMember = "Name";
            comboBoxCuaHang.ValueMember = "RestaurantId";
        }
        private void dataGridViewSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dataGridViewSanPham_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Đổi tên cột sau khi dữ liệu đã được gán
           

            if (dataGridViewSanPham.Columns["RestaurantId"] != null)
                dataGridViewSanPham.Columns["RestaurantId"].HeaderText = "Mã cửa hàng";

            if (dataGridViewSanPham.Columns["ItemId"] != null)
                dataGridViewSanPham.Columns["ItemId"].HeaderText = "Mã món ăn";

            if (dataGridViewSanPham.Columns["Name"] != null)
                dataGridViewSanPham.Columns["Name"].HeaderText = "Tên món ăn";

            if (dataGridViewSanPham.Columns["Description"] != null)
                dataGridViewSanPham.Columns["Description"].HeaderText = "Mô tả";

            if (dataGridViewSanPham.Columns["Price"] != null)
                dataGridViewSanPham.Columns["Price"].HeaderText = "Giá";

            if (dataGridViewSanPham.Columns["Category"] != null)
                dataGridViewSanPham.Columns["Category"].HeaderText = "Loại món ăn";

            if (dataGridViewSanPham.Columns["ImagePath"] != null)
                dataGridViewSanPham.Columns["ImagePath"].HeaderText = "Ảnh";

            // Điều chỉnh cột để tự động điều chỉnh kích thước
            dataGridViewSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Chọn ảnh đại diện"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagesFolder = Path.Combine(Application.StartupPath, "Images");

                if (!Directory.Exists(imagesFolder))
                {
                    Directory.CreateDirectory(imagesFolder);
                }

                string fileName = Path.GetFileName(openFileDialog.FileName);
                string targetFilePath = Path.Combine(imagesFolder, fileName);

                File.Copy(openFileDialog.FileName, targetFilePath, true);

                // Cập nhật đường dẫn tương đối và hiển thị ảnh trong pictureBoxUpLoad
                pictureBoxUpLoad.ImageLocation = Path.Combine("Images", fileName);
                pictureBoxUpLoad.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxUpLoad.Image = Image.FromFile(targetFilePath);
                selectedImagePath = Path.Combine("Images", fileName); // Cập nhật đường dẫn hình ảnh đã chọn
            }
        }

        private void comboBoxCuaHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {



          
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridViewSanPham.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cột
                var name = selectedRow.Cells["Name"].Value?.ToString();
                var description = selectedRow.Cells["Description"].Value?.ToString();
                var price = selectedRow.Cells["Price"].Value?.ToString();
                var category = selectedRow.Cells["Category"].Value?.ToString();
                var imagePath = selectedRow.Cells["ImagePath"].Value?.ToString();
                var restaurantId = selectedRow.Cells["RestaurantId"].Value?.ToString();

                // Cập nhật các Label trên panelThongTinMonAn (Nếu có)
                txtTenMonAn.Text = name ?? "Chưa có tên món ăn";
                txtMoTaMonAn.Text = description ?? "Chưa có mô tả món ăn";
                txtGiaMonAn.Text = price != null ? $"{price}" : "Chưa có giá món ăn";
                txtCategory.Text = category ?? "Chưa có loại món ăn";

                // Cập nhật PictureBox nếu có đường dẫn hình ảnh
                if (!string.IsNullOrEmpty(imagePath))
                {
                    string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string absoluteImagePath = Path.Combine(baseDirectory, imagePath);
                    pictureBoxSanPham.SizeMode = PictureBoxSizeMode.Zoom;

                    if (File.Exists(absoluteImagePath))
                    {
                        try
                        {
                            pictureBoxSanPham.Image = Image.FromFile(absoluteImagePath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Không thể tải hình ảnh: {ex.Message}");
                            pictureBoxSanPham.Image = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Tệp hình ảnh không tồn tại tại đường dẫn: {absoluteImagePath}");
                        pictureBoxSanPham.Image = null;
                    }
                }
                else
                {
                    pictureBoxSanPham.Image = null; // Nếu không có hình ảnh
                }

                // Cập nhật combobox với restaurantId
                SetComboBoxSelectedRestaurant(restaurantId);

                // Cập nhật currentItemId
                currentItemId = selectedRow.Cells["ItemId"].Value?.ToString();
            }
        }

    
        private void SetComboBoxSelectedRestaurant(string restaurantId)
        {
            if (comboBoxCuaHang.Items.Count > 0)
            {
                comboBoxCuaHang.SelectedValue = restaurantId;
            }
        }

        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
           

            // Làm trống các trường nhập liệu
            txtTenMonAn.Text = "";
            txtMoTaMonAn.Text = "";
            txtGiaMonAn.Text = "";
            txtCategory.Text = "";
            pictureBoxUpLoad.Image = null; // Xóa hình ảnh trong PictureBox
            selectedImagePath = null; // Xóa đường dẫn hình ảnh đã chọn
            comboBoxCuaHang.SelectedIndex = -1; // Bỏ chọn combobox

            SetFieldsEnabled(true);
            currentItemId = null; // Đảm bảo currentItemId là null khi thêm mới
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           

            var restaurantId = comboBoxCuaHang.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(restaurantId))
            {
                MessageBox.Show("Vui lòng chọn cửa hàng.");
                return;
            }

            if (!string.IsNullOrEmpty(currentItemId))
            {
                // Nếu currentItemId không null thì thực hiện cập nhật
                var menuItem = new FastFoodDelivery.Models.MenuItem
                {
                    ItemId = currentItemId,
                    RestaurantId = restaurantId,
                    Name = txtTenMonAn.Text,
                    Description = txtMoTaMonAn.Text,
                    Price = decimal.TryParse(txtGiaMonAn.Text, out decimal price) ? (double)price : 0,
                    Category = txtCategory.Text,
                    ImagePath = selectedImagePath
                };

                try
                {
                    menuItemService.UpdateMenuItem(menuItem);
                    LoadMenuItems();
                    MessageBox.Show("Cập nhật món ăn thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi cập nhật món ăn: {ex.Message}");
                }
            }
            else
            {
                // Nếu currentItemId là null thì thực hiện thêm mới
                var itemCount = menuItemService.GetMenuItems().Count();
                var itemId = "SP" + (itemCount + 1).ToString("D3");

                var menuItem = new FastFoodDelivery.Models.MenuItem
                {
                    ItemId = itemId,
                    RestaurantId = restaurantId,
                    Name = txtTenMonAn.Text,
                    Description = txtMoTaMonAn.Text,
                    Price = decimal.TryParse(txtGiaMonAn.Text, out decimal price) ? (double)price : 0,
                    Category = txtCategory.Text,
                    ImagePath = selectedImagePath
                };

                try
                {
                    menuItemService.AddMenuItem(menuItem);
                    LoadMenuItems();
                    MessageBox.Show("Thêm món ăn thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thêm món ăn: {ex.Message}");
                }
            }

            SetFieldsEnabled(false);
            currentItemId = null; // Reset currentItemId sau khi lưu
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewSanPham.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewSanPham.SelectedRows[0];
                var itemId = selectedRow.Cells["ItemId"].Value?.ToString();

                if (!string.IsNullOrEmpty(itemId))
                {
                    var result = MessageBox.Show("Bạn có chắc chắn muốn xóa món ăn này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            menuItemService.DeleteMenuItem(itemId);
                            LoadMenuItems();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi xóa món ăn: {ex.Message}");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Chọn món ăn để xóa.");
                }
            }
            else
            {
                MessageBox.Show("Chọn món ăn để xóa.");
            }
        }
        private string currentItemId; // Biến để lưu trữ ItemId của món ăn đang chỉnh sửa

        private void btnSua_Click(object sender, EventArgs e)
        {
           
            SetFieldsEnabled(true);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
