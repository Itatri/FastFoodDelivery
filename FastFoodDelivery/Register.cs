using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFoodDelivery.Services;
using MongoDB.Bson;
using MongoDB.Driver;

namespace FastFoodDelivery
{
    public partial class Register : Form
    {
        // Biến lưu đường dẫn 
        private string avatarPath;
        // Kết nối tới MongoDB
        private IMongoDatabase database;
        public Register()
        {
            InitializeComponent();
            // Khởi tạo kết nối tới MongoDB
            var client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("fastfooddelivery"); 
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Xử lý sự kiện nhấp vào LinkLabel Đã có tài khoản (Chuyển sang Form Login
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các TextBox
            string username = txtUser.Text;
            string password = txtPass.Text;
            string confirmPassword = txtXacNhanMK.Text; // Mật khẩu xác nhận
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;

            // Kiểm tra có điền đủ thông tin không
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Vui lòng điền tất cả các trường.");
                return;
            }

            // Kiểm tra mật khẩu xác nhận
            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.");
                return;
            }

            // Kiểm tra định dạng email
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ.");
                return;
            }

            // Kiểm tra định dạng số điện thoại 
            if (!IsValidPhone(phone))
            {
                MessageBox.Show("Số điện thoại không hợp lệ.");
                return;
            }

            // Kiểm tra độ dài mật khẩu
            if (password.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự.");
                return;
            }

            // Kiểm tra thêm ảnh đai diện
            if (string.IsNullOrWhiteSpace(avatarPath))
            {
                MessageBox.Show("Vui lòng chọn một ảnh đại diện.");
                return;
            }

            // Tạo đối tượng UserService để lấy ID người dùng mới
            UserService userService = new UserService();
            string userId = userService.GetNextUserId(); // Lấy ID người dùng mới

            // Tạo đối tượng để lưu vào MongoDB
            var user = new BsonDocument
            {
                { "userID", userId }, // Thêm userID
                { "username", username },
                { "password", password },
                { "name", name },
                { "email", email },
                { "phone", phone },
                { "address", address },
                { "registrationDate", DateTime.UtcNow }, // Lưu ngày giờ hiện tại
                { "role", "Khách hàng" },
                { "avatar", avatarPath  }
            };

            // Lưu dữ liệu vào cơ sở dữ liệu MongoDB
            var collection = database.GetCollection<BsonDocument>("users");
            collection.InsertOne(user);

            MessageBox.Show("Đăng ký thành công!");

            // Quay lại form đăng nhập
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();

        }
        // Kiêm tra email
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private bool IsValidPhone(string phone)
        {
            // Kiểm tra xem số điện thoại có 10 chữ số không
            return Regex.IsMatch(phone, @"^\d{10}$");
        }

        // Sự kiện nút upload ảnh
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
    }
}
