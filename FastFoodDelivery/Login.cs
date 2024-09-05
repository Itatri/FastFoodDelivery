using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using FastFoodDelivery.Models;
using FastFoodDelivery.Services;

namespace FastFoodDelivery
{
    public partial class Login : Form
    {
        // Khai bao User services truyen du lieu khi dang nhap
        private readonly UserService _userService;
        public Login()
        {
            InitializeComponent();
            _userService = new UserService(); // Khởi tạo UserService
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Xử lý sự kiện nhấp vào LinkLabel Chưa có tài khoản
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Tên đăng nhập không được để trống.");
                txtUser.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Mật khẩu không được để trống.");
                txtPassword.Focus();
                return;
            }

            // Truyen du lieu dang nhap 
            var user = _userService.AuthenticateUser(username, password);


            if (user != null)
            {
                MainForm mainForm = new MainForm(user);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu ! Hãy thử lại.");
            }

        }



        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
