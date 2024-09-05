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
using FastFoodDelivery.Models;
using FastFoodDelivery.Services;
using FastFoodDelivery.UserControls;
using FastFoodDelivery.AdminControls;

namespace FastFoodDelivery
{
    public partial class MainForm : Form
    {
        private UserInfo loggedInUser;
        private UserService _userService;


        public MainForm()
        {
            InitializeComponent();
            InitializeClock();
            _userService = new UserService(); // Khởi tạo dịch vụ



        }
        private void InitializeClock()
        {
            // Cấu hình Timer
            //timerDongHo.Interval = 1000; // Cập nhật mỗi giây
            timerDongHo.Tick += TimerDongHo_Tick;
            timerDongHo.Start(); // Bắt đầu Timer
        }

        private void TimerDongHo_Tick(object sender, EventArgs e)
        {
            // Cập nhật giờ hiện tại vào lbDongHo
            lbDongHo.Text = DateTime.Now.ToString("HH:mm:ss"); // Hiển thị giờ, phút, giây

            // Cập nhật ngày hiện tại vào lbNgayThang
            lbNgayThang.Text = DateTime.Now.ToString("dd/MM/yyyy"); // Hiển thị ngày tháng năm
        }
        public MainForm(UserInfo user) : this() // Gọi constructor mặc định trước
        {
            loggedInUser = user;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            if (loggedInUser != null)
            {
                // Hiển thị thông tin người dùng
                lbHoTen.Text = "Họ Tên: " + loggedInUser.Name;
                lbEmail.Text = "Email: " + loggedInUser.Email;
                lbPhone.Text = "Số Điện Thoại: " + loggedInUser.Phone;
                lbRole.Text = "Tài Khoản: " + loggedInUser.Role;
                labelMaKH.Text = loggedInUser.Id;

                if (!string.IsNullOrEmpty(loggedInUser.AvatarPath))
                {
                    pictureBoxAvatarLogin.Image = Image.FromFile(loggedInUser.AvatarPath);
                    pictureBoxAvatarLogin.SizeMode = PictureBoxSizeMode.Zoom;
                }

                // Kiểm tra vai trò của người dùng và hiển thị/ẩn các nút tương ứng
                if (loggedInUser.Role == "Khách hàng")
                {
                    btnHome.Visible = true;
                    btnThongTinCN.Visible = true;
                    btnDatHang.Visible = true;
                    btnGioHang.Visible = true;
                    btnLichSuMH.Visible = true;

                    btnQLSP.Visible = false;
                    btnQLDH.Visible = false;
                    btnQLCH.Visible = false;
                    btnNVGH.Visible = false;
                    btnQLTK.Visible = false;
                    buttonVoucher.Visible = false;
                    btnDonGiao.Visible = false;
                    buttonDonGiaoThanhCong.Visible = false;
                    btnThongTinTaiKhoanShipper.Visible = false;

                }
                else if (loggedInUser.Role == "Quản lý")
                {
                    btnHome.Visible = false;
                    btnThongTinCN.Visible = false;
                    btnDatHang.Visible = false;
                    btnGioHang.Visible = false;
                    btnLichSuMH.Visible = false;

                    btnQLSP.Visible = true;
                    btnQLDH.Visible = true;
                    btnQLCH.Visible = true;
                    btnNVGH.Visible = true;
                    btnQLTK.Visible = true;
                    buttonVoucher.Visible = true;
                    btnDonGiao.Visible = false;
                    buttonDonGiaoThanhCong.Visible = false;
                    btnThongTinTaiKhoanShipper.Visible = false;


                }

                else if (loggedInUser.Role == "Shipper")
                {
                    btnHome.Visible = false;
                    btnThongTinCN.Visible = true;
                    btnDatHang.Visible = false;
                    btnGioHang.Visible = false;
                    btnLichSuMH.Visible = false;

                    btnQLSP.Visible = false;
                    btnQLDH.Visible = false;
                    btnQLCH.Visible = false;
                    btnNVGH.Visible = false;
                    btnQLTK.Visible = false;
                    buttonVoucher.Visible = false;
                    btnThongTinCN.Visible=false;    
                    btnThongTinTaiKhoanShipper.Visible = true;
                    btnDonGiao.Visible = true;
                    buttonDonGiaoThanhCong.Visible = true;
                }
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Xử lý đăng xuất
            this.Close();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void btnThongTinCN_Click(object sender, EventArgs e)
        {
            ShowPersonalInfo();
        }
        // Hien thi thong tin ca nhan 
        private void ShowPersonalInfo()
        {

            panelContent.Controls.Clear(); // Clear previous controls

            var personalInfoControl = new FastFoodDelivery.UserControls.PersonalInfoControl();
            personalInfoControl.LoadUserInfo(loggedInUser);
            personalInfoControl.Dock = DockStyle.Fill;

            panelContent.Controls.Add(personalInfoControl);
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            ShowOrders();
        }
        private void ShowOrders()
        {
            panelContent.Controls.Clear(); // Xóa các điều khiển trước đó

            var ordersControl = new FastFoodDelivery.UserControls.OrdersControl();
            ordersControl.Dock = DockStyle.Fill; // Đảm bảo OrdersControl fill panelContent

            ordersControl.SetUserInfo(loggedInUser); // Thiết lập thông tin người dùng

            panelContent.Controls.Add(ordersControl);
        }

        private void pictureBoxAvatarLogin_Click(object sender, EventArgs e)
        {

        }

        private void panelTaiKhoanDN_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ShowCart()
        {

            panelContent.Controls.Clear(); // Clear previous controls

            var showCart = new FastFoodDelivery.UserControls.CartControl();
            showCart.Dock = DockStyle.Fill;
            showCart.SetUserInfo(loggedInUser); // Thiết lập thông tin người dùng sau 
            panelContent.Controls.Add(showCart);
        }
        private void btnGioHang_Click(object sender, EventArgs e)
        {
            ShowCart();
        }
        private void ShowHome()
        {

            panelContent.Controls.Clear(); // Clear previous controls

            var showHome = new FastFoodDelivery.UserControls.HomeControl();
            showHome.Dock = DockStyle.Fill;
            /*     showCart.SetUserInfo(loggedInUser);*/ // Thiết lập thông tin người dùng sau 
            panelContent.Controls.Add(showHome);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowHome();
        }
        private void ShowBuyHistory()
        {

            panelContent.Controls.Clear(); // Clear previous controls

            var showBuy = new FastFoodDelivery.UserControls.BuyHistory();
            showBuy.Dock = DockStyle.Fill;
            showBuy.SetUserInfo(loggedInUser); // Thiết lập thông tin người dùng sau 
            panelContent.Controls.Add(showBuy);
        }
        private void btnLichSuMH_Click(object sender, EventArgs e)
        {
            ShowBuyHistory();
        }
        
        private void buttonDanhGia_Click(object sender, EventArgs e)
        {
        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowProcductAdmin()
        {

            panelContent.Controls.Clear(); // Clear previous controls

            var showProcduct = new FastFoodDelivery.AdminControls.ProductControl();
            showProcduct.Dock = DockStyle.Fill;
            showProcduct.SetUserInfo(loggedInUser); // Thiết lập thông tin người dùng sau 
            panelContent.Controls.Add(showProcduct);
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            ShowProcductAdmin();
        }
        private void ShowOrderAdmin()
        {

            panelContent.Controls.Clear(); // Clear previous controls

            var showOrder = new FastFoodDelivery.AdminControls.OrderDeliveryControl();
            showOrder.Dock = DockStyle.Fill;
            showOrder.SetUserInfo(loggedInUser); // Thiết lập thông tin người dùng sau 
            panelContent.Controls.Add(showOrder);
        }

        private void btnQLDH_Click(object sender, EventArgs e)
        {
            ShowOrderAdmin();
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ShowShopAdmin()
        {

            panelContent.Controls.Clear(); // Clear previous controls

            var showShop = new FastFoodDelivery.AdminControls.ShopControl();
            showShop.Dock = DockStyle.Fill;
            showShop.SetUserInfo(loggedInUser); // Thiết lập thông tin người dùng sau 
            panelContent.Controls.Add(showShop);
        }
        private void btnQLCH_Click(object sender, EventArgs e)
        {
            ShowShopAdmin();
        }
        private void ShipperAdmin()
        {

            panelContent.Controls.Clear(); // Clear previous controls

            var showShipper = new FastFoodDelivery.AdminControls.NhanVienGHControl();
            showShipper.Dock = DockStyle.Fill;
            showShipper.SetUserInfo(loggedInUser); // Thiết lập thông tin người dùng sau 
            panelContent.Controls.Add(showShipper);
        }
        private void btnNVGH_Click(object sender, EventArgs e)
        {
            ShipperAdmin();
        }
        private void AccountAdmin()
        {

            panelContent.Controls.Clear(); // Clear previous controls

            var showAccount = new FastFoodDelivery.AdminControls.TaiKhoanControl();
            showAccount.Dock = DockStyle.Fill;
            showAccount.SetUserInfo(loggedInUser); // Thiết lập thông tin người dùng sau 
            panelContent.Controls.Add(showAccount);
        }
        private void btnQLTK_Click(object sender, EventArgs e)
        {
            AccountAdmin();
        }
        private void VoucherAdmin()
        {

            panelContent.Controls.Clear(); // Clear previous controls

            var showVoucher = new FastFoodDelivery.AdminControls.VoucherControl();
            showVoucher.Dock = DockStyle.Fill;
            showVoucher.SetUserInfo(loggedInUser); // Thiết lập thông tin người dùng sau 
            panelContent.Controls.Add(showVoucher);
        }
        private void buttonVoucher_Click(object sender, EventArgs e)
        {
            VoucherAdmin();
        }
        private void DonGiaoShipper()
        {

            panelContent.Controls.Clear(); // Clear previous controls

            var showDonGiao = new FastFoodDelivery.ShipperControl.DonGiaoControl();
            showDonGiao.Dock = DockStyle.Fill;
            showDonGiao.SetUserInfo(loggedInUser); // Thiết lập thông tin người dùng sau 
            panelContent.Controls.Add(showDonGiao);
        }
        private void btnDonGiao_Click(object sender, EventArgs e)
        {
            DonGiaoShipper();
        }
        private void DonGiaoThanhCong()
        {

            panelContent.Controls.Clear(); // Clear previous controls

            var showDonGiaoTC = new FastFoodDelivery.ShipperControl.LichSuGiaoControl();
            showDonGiaoTC.Dock = DockStyle.Fill;
            showDonGiaoTC.SetUserInfo(loggedInUser); // Thiết lập thông tin người dùng sau 
            panelContent.Controls.Add(showDonGiaoTC);
        }
        private void buttonDonGiaoThanhCong_Click(object sender, EventArgs e)
        {
            DonGiaoThanhCong();
        }

        private void btnThongTinTaiKhoanShipper_Click(object sender, EventArgs e)
        {
            ShowPersonalInfo();
        }
    }
}
