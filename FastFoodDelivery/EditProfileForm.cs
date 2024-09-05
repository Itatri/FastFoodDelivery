using FastFoodDelivery.Services;
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

namespace FastFoodDelivery
{
    public partial class EditProfileForm : Form
    {
        private string avatarPath;
        public EditProfileForm()
        {
            InitializeComponent();
        }

        // Các thuộc tính để lưu thông tin từ PersonalInfoControl
        public string MaTK
        {
            get { return txtMaTK.Text; }
            set { txtMaTK.Text = value; }
        }

        public string User
        {
            get { return txtUser.Text; }
            set { txtUser.Text = value; }
        }

        public string Pass
        {
            get { return txtPass.Text; }
            set { txtPass.Text = value; }
        }

        public new string Name
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public string Email
        {
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }

        public string Phone
        {
            get { return txtPhone.Text; }
            set { txtPhone.Text = value; }
        }

        public string Address
        {
            get { return txtAddress.Text; }
            set { txtAddress.Text = value; }
        }

        

        // Phương thức để thiết lập thông tin từ PersonalInfoControl
        public void SetUserInfo(string maTK, string user, string pass, string name, string email, string phone, string address)
        {
            txtMaTK.Text = maTK;
            txtUser.Text = user;
            txtPass.Text = pass;
            txtName.Text = name;
            txtEmail.Text = email;
            txtPhone.Text = phone;
            txtAddress.Text = address;
        }

        private void EditProfileForm_Load(object sender, EventArgs e)
        {

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

                // Cập nhật đường dẫn tương đối và hiển thị ảnh
                pictureBoxAvatar.ImageLocation = Path.Combine("Images", fileName);
                pictureBoxAvatar.Image = Image.FromFile(targetFilePath);
            }
        }

        private void btnCapNhatThongTIn_Click(object sender, EventArgs e)
        {
            
            string userId = txtMaTK.Text;
            string username = txtUser.Text;
            string password = txtPass.Text;
            string confirmPassword = txtNhapLaiMatKhau.Text; // Mật khẩu xác nhận
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;

            // Lấy đường dẫn ảnh từ PictureBox
            string avatarPath = pictureBoxAvatar.ImageLocation;

            // Nếu không có ảnh mới, giữ nguyên giá trị hiện tại
            if (string.IsNullOrEmpty(avatarPath))
            {
                avatarPath = null;
            }

            var userService = new UserService();
            bool isUpdated = userService.UpdateUserInfo(userId, username, password, name, email, phone, address, avatarPath);
            // Kiểm tra mật khẩu mới và mật khẩu xác nhận
            if (!string.IsNullOrWhiteSpace(password) && password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp với mật khẩu mới.");
                return;
            }

            if (isUpdated)
            {
                MessageBox.Show("Cập nhật thông tin thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại!");
            }
        }

        private void pictureBoxAvatar_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
