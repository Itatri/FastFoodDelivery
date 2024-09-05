using FastFoodDelivery.Models;
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
    public partial class PersonalInfoControl : UserControl
    {

        public PersonalInfoControl()
        {
            InitializeComponent();
        }

        private void PersonalInfoControl_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        // Method to load user information
        public void LoadUserInfo(UserInfo user)
        {
         
            

            lbTaiKhoanCT.Text = user.Username;
            lbHoTenCT.Text =  user.Name;
            lbEmailCT.Text =  user.Email;
            lbPhone.Text =  user.Phone;
            lbAddress.Text =  user.Address;
            lbCreateDate.Text = user.RegistrationDate.ToString("dd/MM/yyyy"); // Định dạng ngày
            labelMaTK.Text = user.Id;



            lbRole.Text =  user.Role;

            if (!string.IsNullOrEmpty(user.AvatarPath))
            {
                pictureBoxAvatarInfo.Image = Image.FromFile(user.AvatarPath);
                pictureBoxAvatarInfo.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelMaTK_Click(object sender, EventArgs e)
        {

        }

        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng của EditProfileForm
            var editProfileForm = new EditProfileForm();

            // Truyền thông tin từ PersonalInfoControl sang EditProfileForm
            editProfileForm.SetUserInfo(
                labelMaTK.Text,   // Mã tài khoản
                lbTaiKhoanCT.Text, // Tên đăng nhập
                "",                // Mật khẩu có thể để trống hoặc bạn có thể yêu cầu người dùng nhập lại
                lbHoTenCT.Text,   // Họ tên
                lbEmailCT.Text,   // Email
                lbPhone.Text,     // Số điện thoại
                lbAddress.Text    // Địa chỉ
            );

            // Hiển thị form EditProfileForm
            editProfileForm.ShowDialog();
        }

        private void pictureBoxAvatarInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
