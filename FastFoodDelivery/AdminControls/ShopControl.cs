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
    public partial class ShopControl : UserControl
    {
        public ShopControl()
        {
            InitializeComponent();
        }
        private UserInfo currentUser;
        private RestaurantService restaurantService;
        private Restaurant selectedRestaurant;

        public void SetUserInfo(UserInfo user)
        {
            this.currentUser = user;
            restaurantService = new RestaurantService();
        }
        private void LoadRestaurants()
        {
            var restaurants = restaurantService.GetRestaurants();
            dataGridViewCuaHang.DataSource = restaurants;
            //// Điều chỉnh cột để tự động điều chỉnh kích thước
            //dataGridViewCuaHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Set khong cho nhap cac truong thong tin 
            SetControlsEnabled(false);

        }
        private void ShopControl_Load(object sender, EventArgs e)
        {
            LoadRestaurants();
        }
        private void SetControlsEnabled(bool enabled)
        {
            txtTenCH.Enabled = enabled;
            txtDuong.Enabled = enabled;
            txtThanhPho.Enabled = enabled;
            txtLoaiMonAn.Enabled = enabled;
            numericUpDownDanhGia.Enabled = enabled;
        }

        private void dataGridViewCuaHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridViewCuaHang.Rows[e.RowIndex];
                selectedRestaurant = (Restaurant)selectedRow.DataBoundItem;
                txtTenCH.Text = selectedRestaurant.Name;
                txtDuong.Text = selectedRestaurant.Street;
                txtThanhPho.Text = selectedRestaurant.City;
                txtLoaiMonAn.Text = selectedRestaurant.CuisineTypes;
                numericUpDownDanhGia.Value = (decimal)selectedRestaurant.Rating;
                SetControlsEnabled(false); // Đảm bảo các điều khiển vẫn bị khóa
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewCuaHang_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Đổi tên cột sau khi dữ liệu đã được gán
            if (dataGridViewCuaHang.Columns["RestaurantId"] != null)
                dataGridViewCuaHang.Columns["RestaurantId"].HeaderText = "Mã Cửa Hàng";

            if (dataGridViewCuaHang.Columns["Name"] != null)
                dataGridViewCuaHang.Columns["Name"].HeaderText = "Tên Cửa Hàng";

            if (dataGridViewCuaHang.Columns["Street"] != null)
                dataGridViewCuaHang.Columns["Street"].HeaderText = "Đường";

            if (dataGridViewCuaHang.Columns["City"] != null)
                dataGridViewCuaHang.Columns["City"].HeaderText = "Thành Phố";

            if (dataGridViewCuaHang.Columns["CuisineTypes"] != null)
                dataGridViewCuaHang.Columns["CuisineTypes"].HeaderText = "Loại Ẩm Thực";

            if (dataGridViewCuaHang.Columns["Rating"] != null)
                dataGridViewCuaHang.Columns["Rating"].HeaderText = "Đánh Giá";

            // Điều chỉnh cột để tự động điều chỉnh kích thước
            dataGridViewCuaHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnThemCH_Click(object sender, EventArgs e)
        {
            // Reset các trường nhập liệu
            ResetInputFields();

            // Cho phép nhập vào các textbox
            txtTenCH.Enabled = true;
            txtDuong.Enabled = true;
            txtThanhPho.Enabled = true;
            txtLoaiMonAn.Enabled = true;

            // Không cho phép thao tác với numericUpDownDanhGia
            numericUpDownDanhGia.Enabled = false;

            selectedRestaurant = null; // Reset selectedRestaurant để chỉ ra rằng đang thêm cửa hàng mới


        }

        private void btnSuaCH_Click(object sender, EventArgs e)
        {
            if (selectedRestaurant == null)
            {
                MessageBox.Show("Vui lòng chọn một cửa hàng để sửa thông tin.");
                return;
            }

            // Cho phép nhập vào các textbox
            txtTenCH.Enabled = true;
            txtDuong.Enabled = true;
            txtThanhPho.Enabled = true;
            txtLoaiMonAn.Enabled = true;

            // Không cho phép thao tác với numericUpDownDanhGia
            numericUpDownDanhGia.Enabled = true;
        }

        private void btnXoaCH_Click(object sender, EventArgs e)
        {
            if (selectedRestaurant == null)
            {
                MessageBox.Show("Vui lòng chọn một cửa hàng để xóa.");
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa cửa hàng này?", "Xóa cửa hàng", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                restaurantService.DeleteRestaurant(selectedRestaurant.RestaurantId);
                ResetInputFields();
                LoadRestaurants();
                SetControlsEnabled(false);
            }
        }

        private void btnLuuCH_Click(object sender, EventArgs e)
        {
            if (selectedRestaurant == null)
            {
                // Thêm cửa hàng mới
                string restaurantId = GenerateRestaurantId();

                var newRestaurant = new Restaurant
                {
                    RestaurantId = restaurantId,
                    Name = txtTenCH.Text,
                    Street = txtDuong.Text,
                    City = txtThanhPho.Text,
                    CuisineTypes = txtLoaiMonAn.Text,
                    Rating = (double)numericUpDownDanhGia.Value
                };

                restaurantService.AddRestaurant(newRestaurant);
            }
            else
            {
                // Cập nhật cửa hàng hiện có
                selectedRestaurant.Name = txtTenCH.Text;
                selectedRestaurant.Street = txtDuong.Text;
                selectedRestaurant.City = txtThanhPho.Text;
                selectedRestaurant.CuisineTypes = txtLoaiMonAn.Text;
                selectedRestaurant.Rating = (double)numericUpDownDanhGia.Value;

                restaurantService.UpdateRestaurant(selectedRestaurant);
            }

            ResetInputFields();
            LoadRestaurants();
            SetControlsEnabled(false);
        }
        private string GenerateRestaurantId()
        {
            // Tạo mã nhà hàng tự động với tiền tố NH và số thứ tự
            int count = restaurantService.GetRestaurantCount();
            return $"NH{count + 1:D4}"; // Ví dụ: NH0001, NH0002, ...
        }

        private void ResetInputFields()
        {
            txtTenCH.Text = string.Empty;
            txtDuong.Text = string.Empty;
            txtThanhPho.Text = string.Empty;
            txtLoaiMonAn.Text = string.Empty;
            numericUpDownDanhGia.Value = 0;
        }
    }
}
