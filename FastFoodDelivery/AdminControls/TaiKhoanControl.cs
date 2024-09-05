using FastFoodDelivery.Models;
using FastFoodDelivery.Services;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDelivery.AdminControls
{
    public partial class TaiKhoanControl : UserControl
    {
        private UserInfo currentUser;
        private UserService userService;
        private BsonDocument selectedUser; // Biến lưu tài khoản đã chọn
        private string avatarPath;

        public void SetUserInfo(UserInfo user)
        {
            this.currentUser = user;
        }
        public TaiKhoanControl()
        {
            InitializeComponent();
            userService = new UserService();
            SetFieldsEnabled(false);
            InitializeComboBox();
            btnXoaTK.Click += btnXoaTK_Click;

        }
        private void InitializeComboBox()
        {
            comboBoxLoaiTaiKhoan.Items.Add("Khách hàng");
            comboBoxLoaiTaiKhoan.Items.Add("Shipper");
            comboBoxLoaiTaiKhoan.Items.Add("Quản lý");
        }
        private void TaiKhoanControl_Load(object sender, EventArgs e)
        {
            LoadUsers();
            dataGridViewAccount.CellClick += dataGridViewAccount_CellClick;

        }
        private void SetFieldsEnabled(bool enabled)
        {
            txtTaiKhoan.Enabled = enabled;
            txtMatKhau.Enabled = enabled;
            txtHoTen.Enabled = enabled;
            txtEmail.Enabled = enabled;
            txtAddress.Enabled = enabled;
            txtPhone.Enabled = enabled;
            comboBoxLoaiTaiKhoan.Enabled = enabled;
            btnUploadImage.Enabled = enabled;

        }

        private void LoadUsers()
        {
            var users = userService.GetAllUsers();

            dataGridViewAccount.Columns.Clear();
            dataGridViewAccount.Columns.Add("userID", "Mã khách hàng");
            dataGridViewAccount.Columns.Add("username", "Tài khoản");
            dataGridViewAccount.Columns.Add("password", "Mật Khẩu");
            dataGridViewAccount.Columns.Add("name", "Họ tên");
            dataGridViewAccount.Columns.Add("email", "Email");
            dataGridViewAccount.Columns.Add("phone", "Số Điện Thoại");
            dataGridViewAccount.Columns.Add("address", "Địa Chỉ");
            dataGridViewAccount.Columns.Add("registrationDate", "Ngày Đăng Ký");
            dataGridViewAccount.Columns.Add("role", "Vai Trò");
            dataGridViewAccount.Columns.Add("avatar", "Ảnh Đại Diện");

            foreach (var user in users)
            {
                dataGridViewAccount.Rows.Add(
                    user["userID"],
                    user["username"],
                    user["password"],
                    user["name"],
                    user["email"],
                    user["phone"],
                    user["address"],
                    user["registrationDate"],
                    user["role"],
                    user["avatar"]
                );
            }

            dataGridViewAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void dataGridViewAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra để đảm bảo không chọn cột header
            {
                DataGridViewRow row = dataGridViewAccount.Rows[e.RowIndex];
                selectedUser = new BsonDocument
        {
            { "userID", row.Cells["userID"].Value?.ToString() },
            { "username", row.Cells["username"].Value?.ToString() },
            { "password", row.Cells["password"].Value?.ToString() },
            { "name", row.Cells["name"].Value?.ToString() },
            { "email", row.Cells["email"].Value?.ToString() },
            { "phone", row.Cells["phone"].Value?.ToString() },
            { "address", row.Cells["address"].Value?.ToString() },
            { "registrationDate", row.Cells["registrationDate"].Value?.ToString() },
            { "role", row.Cells["role"].Value?.ToString() },
            { "avatar", row.Cells["avatar"].Value?.ToString() }
        };

                // Lấy giá trị từ các ô trong dòng được chọn
                txtTaiKhoan.Text = selectedUser["username"].ToString();
                txtMatKhau.Text = selectedUser["password"].ToString();
                txtHoTen.Text = selectedUser["name"].ToString();
                txtEmail.Text = selectedUser["email"].ToString();
                txtPhone.Text = selectedUser["phone"].ToString();
                txtAddress.Text = selectedUser["address"].ToString();
                comboBoxLoaiTaiKhoan.SelectedItem = selectedUser["role"].ToString();

                // Hiển thị ảnh đại diện lên pictureBoxAvatar
                string avatarPath = selectedUser["avatar"].ToString();
                if (!string.IsNullOrEmpty(avatarPath) && System.IO.File.Exists(avatarPath))
                {
                    pictureBoxAvatar.Image = Image.FromFile(avatarPath);
                }
                else
                {
                    pictureBoxAvatar.Image = null; // Nếu không có ảnh, đặt ảnh mặc định hoặc để trống
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            if (selectedUser != null)
            {
                var userId = selectedUser["userID"].ToString();

                if (!string.IsNullOrEmpty(userId))
                {
                    var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        bool isDeleted = userService.DeleteUser(userId);
                        if (isDeleted)
                        {
                            MessageBox.Show("Xóa tài khoản thành công.");
                            LoadUsers(); // Tải lại danh sách tài khoản sau khi xóa
                            selectedUser = null; // Xóa tài khoản đã chọn sau khi xóa thành công
                        }
                        else
                        {
                            MessageBox.Show("Xóa tài khoản thất bại.");
                        }
                    }
                }
            }
         
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
                // Tạo đường dẫn thư mục Images trong thư mục gốc của dự án
                string imagesFolder = Path.Combine(Application.StartupPath, "Images");

                // Tạo thư mục Images nếu chưa tồn tại
                if (!Directory.Exists(imagesFolder))
                {
                    Directory.CreateDirectory(imagesFolder);
                }

                // Lấy tên tệp từ đường dẫn ảnh
                string fileName = Path.GetFileName(openFileDialog.FileName);

                // Tạo đường dẫn tuyệt đối để lưu ảnh vào thư mục Images
                string targetFilePath = Path.Combine(imagesFolder, fileName);

                // Sao chép tệp ảnh vào thư mục Images
                File.Copy(openFileDialog.FileName, targetFilePath, true);

                // Cập nhật đường dẫn tương đối
                avatarPath = Path.Combine("Images", fileName);

                // Hiển thị ảnh trong PictureBox
                pictureBoxAvatar.Image = Image.FromFile(targetFilePath);


            }
        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            SetFieldsEnabled(true);


        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var username = txtTaiKhoan.Text;
            var password = txtMatKhau.Text;
            var name = txtHoTen.Text;
            var email = txtEmail.Text;
            var phone = txtPhone.Text;
            var address = txtAddress.Text;
            var role = comboBoxLoaiTaiKhoan.SelectedItem?.ToString();
            var avatar = avatarPath;

            // Kiểm tra các trường nhập liệu
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            if (selectedUser != null)
            {
                // Cập nhật thông tin tài khoản hiện tại
                var userId = selectedUser["userID"].ToString();

                var result = userService.UpdateUserInfoAdmin(userId, username, password, name, email, phone, address, role, avatar);

                if (result)
                {
                    MessageBox.Show("Cập nhật tài khoản thành công.");
                    LoadUsers();
                    SetFieldsEnabled(false);
                    selectedUser = null; // Đặt lại selectedUser
                }
                else
                {
                    MessageBox.Show("Cập nhật tài khoản thất bại.");
                }
            }
            else
            {
                // Tạo tài khoản mới
                var result = userService.CreateNewUser(username, password, name, email, phone, address, role, avatar);

                if (result)
                {
                    MessageBox.Show("Tạo tài khoản thành công.");
                    LoadUsers(); // Tải lại danh sách tài khoản
                    SetFieldsEnabled(false); // Vô hiệu hóa các trường sau khi lưu
                }
                else
                {
                    MessageBox.Show("Tạo tài khoản thất bại.");
                }
            }
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            SetFieldsEnabled(true); // Kích hoạt các trường nhập liệu
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            comboBoxLoaiTaiKhoan.SelectedIndex = -1; // Đặt lại chọn
            avatarPath = null; // Xóa đường dẫn avatar
        }

    }
}
