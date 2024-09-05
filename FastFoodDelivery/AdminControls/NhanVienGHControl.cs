using FastFoodDelivery.Models;
using FastFoodDelivery.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Runtime.Remoting.Contexts;

namespace FastFoodDelivery.AdminControls
{
    public partial class NhanVienGHControl : UserControl
    {
        public NhanVienGHControl()
        {
            InitializeComponent();
            deliveryPersonnelService = new DeliveryPersonnelService();
            userService = new UserService();
            // Đăng ký sự kiện cho nút xóa
            btnXoaNhanVien.Click += btnXoaNhanVien_Click;
            btnSuaNhanVien.Click += btnSuaNhanVien_Click;
            btnLocNhanVien.Click += btnLocNhanVien_Click;
        }
        private UserInfo currentUser;
        private DeliveryPersonnelService deliveryPersonnelService;
        private string selectedDeliveryPersonnelId;
        private bool isEditing = false; // Biến để theo dõi trạng thái chỉnh sửa
        private UserService userService;
        public void SetUserInfo(UserInfo user)
        {
            this.currentUser = user;
        }
        private void NhanVienGHControl_Load(object sender, EventArgs e)
        {
            LoadDeliveryPersonnel();
            LoadOrderStatuses();
        }
        private void LoadOrderStatuses()
        {
                var orderStatuses = new List<string>
                {
                    "Sẵn sàng",
                    "Đang giao",
                    "Nghỉ",
                    "Chưa cập nhật"
                };

                 comboboxTrangThai.DataSource = orderStatuses;
            comboBoxLocTrangThai.DataSource = new List<string>(orderStatuses) { "Tất cả" };
        }

        private void LoadDeliveryPersonnel()
        {
            var deliveryPersonnel = deliveryPersonnelService.GetAllDeliveryPersonnel();
            dataGridViewNhanVienGiaoHang.DataSource = deliveryPersonnel;

            // Điều chỉnh cột để tự động điều chỉnh kích thước
            dataGridViewNhanVienGiaoHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Ẩn cột "_id"
            if (dataGridViewNhanVienGiaoHang.Columns.Contains("id"))
            {
                dataGridViewNhanVienGiaoHang.Columns["id"].Visible = false;
            }

            // Đổi tên các cột thành tiếng Việt
            dataGridViewNhanVienGiaoHang.Columns["DeliveryPersonnelId"].HeaderText = "Mã nhân viên";
            dataGridViewNhanVienGiaoHang.Columns["name"].HeaderText = "Tên Nhân Viên";
            dataGridViewNhanVienGiaoHang.Columns["email"].HeaderText = "Email";
            dataGridViewNhanVienGiaoHang.Columns["phone"].HeaderText = "Số Điện Thoại";
            dataGridViewNhanVienGiaoHang.Columns["vehicleType"].HeaderText = "Loại Phương Tiện";
            dataGridViewNhanVienGiaoHang.Columns["licensePlate"].HeaderText = "Biển Số Xe";
            dataGridViewNhanVienGiaoHang.Columns["status"].HeaderText = "Trạng Thái";
            dataGridViewNhanVienGiaoHang.Columns["rating"].HeaderText = "Đánh Giá";
            dataGridViewNhanVienGiaoHang.Columns["totalDeliveries"].HeaderText = "Tổng Số Giao";


            // Đặt các điều khiển không cho phép chỉnh sửa
            SetControlsReadOnly(true);
        }

        private void SetControlsReadOnly(bool isReadOnly)
        {
            txtTenNV.ReadOnly = isReadOnly;
            txtSoDT.ReadOnly = isReadOnly;
            txtPhuongTien.ReadOnly = isReadOnly;
            txtBienSo.ReadOnly = isReadOnly;
            comboboxTrangThai.Enabled = !isReadOnly;
            txtDanhGia.ReadOnly = isReadOnly;
            txtEmail.ReadOnly = isReadOnly;
        }


        private void dataGridViewNhanVienGiaoHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy thông tin của hàng được chọn
                DataGridViewRow row = dataGridViewNhanVienGiaoHang.Rows[e.RowIndex];

                // Lưu thông tin của nhân viên đã chọn vào biến
                selectedDeliveryPersonnelId = row.Cells["DeliveryPersonnelId"].Value?.ToString();

                // Gán giá trị từ các ô của hàng được chọn vào các điều khiển
                txtTenNV.Text = row.Cells["name"].Value?.ToString();
                txtSoDT.Text = row.Cells["phone"].Value?.ToString();
                txtPhuongTien.Text = row.Cells["vehicleType"].Value?.ToString();
                txtBienSo.Text = row.Cells["licensePlate"].Value?.ToString();
                txtDanhGia.Text = row.Cells["rating"].Value?.ToString();
                txtEmail.Text = row.Cells["email"].Value?.ToString();

                // Đặt giá trị cho comboboxTrangThai
                var status = row.Cells["status"].Value?.ToString();
                if (comboboxTrangThai.Items.Contains(status))
                {
                    comboboxTrangThai.SelectedItem = status;
                }
                else
                {
                    comboboxTrangThai.SelectedIndex = -1; // Xóa chọn nếu trạng thái không có trong danh sách
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Cho phép nhập dữ liệu vào các trường
            SetControlsReadOnly(false);

            comboboxTrangThai.Enabled = false;
            txtDanhGia.ReadOnly = true;

            // Đặt giá trị cho comboboxTrangThai và txtDanhGia
            comboboxTrangThai.SelectedIndex = -1; // Đặt trạng thái thành null
            txtDanhGia.Text = ""; // Đặt đánh giá mặc định là 
        }


        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có thông tin nhân viên đã chọn
            if (!string.IsNullOrEmpty(selectedDeliveryPersonnelId))
            {
                // Xác nhận việc xóa
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xóa Nhân Viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Gọi phương thức xóa từ dịch vụ
                        deliveryPersonnelService.DeleteDeliveryPersonnel(selectedDeliveryPersonnelId);

                        // Tải lại danh sách nhân viên giao hàng
                        LoadDeliveryPersonnel();

                        // Xóa thông tin lưu tạm sau khi xóa
                        selectedDeliveryPersonnelId = null;

                        MessageBox.Show("Nhân viên đã được xóa.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Đã xảy ra lỗi khi xóa nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
           
        }
     
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrEmpty(txtTenNV.Text) ||
                string.IsNullOrEmpty(txtSoDT.Text) ||
                string.IsNullOrEmpty(txtPhuongTien.Text) ||
                string.IsNullOrEmpty(txtBienSo.Text) ||
                string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (isEditing)
            {
                // Cập nhật thông tin nhân viên
                var updatedDeliveryPersonnel = new DeliveryPersonnel
                {
                    DeliveryPersonnelId = selectedDeliveryPersonnelId,
                    Name = txtTenNV.Text,
                    Email = txtEmail.Text,
                    Phone = txtSoDT.Text,
                    VehicleType = txtPhuongTien.Text,
                    LicensePlate = txtBienSo.Text,
                    Status = comboboxTrangThai.SelectedItem?.ToString(),
                    Rating = int.TryParse(txtDanhGia.Text, out var rating) ? rating : 0,
                    TotalDeliveries = 0 // Hoặc bạn có thể cập nhật số lượng giao hàng nếu cần
                };

                try
                {
                    // Gọi phương thức cập nhật từ dịch vụ
                    deliveryPersonnelService.UpdateDeliveryPersonnel(updatedDeliveryPersonnel);

                    // Tải lại danh sách nhân viên giao hàng
                    LoadDeliveryPersonnel();

                    // Thông báo thành công
                    MessageBox.Show("Thông tin nhân viên đã được cập nhật.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Đặt lại trạng thái của các điều khiển
                    SetControlsReadOnly(true);
                    isEditing = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi cập nhật thông tin nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                var getuserid = userService.GetNextUserId();
                // Thêm nhân viên mới
                var newDeliveryPersonnel = new DeliveryPersonnel
                {
                    DeliveryPersonnelId = GenerateNewDeliveryPersonnelId(),
                    userID = getuserid,
                    Name = txtTenNV.Text,
                    Email = txtEmail.Text,
                    Phone = txtSoDT.Text,
                    VehicleType = txtPhuongTien.Text,
                    LicensePlate = txtBienSo.Text,
                    Status = "Chưa cập nhật",
                    Rating = int.TryParse(txtDanhGia.Text, out var rating) ? rating : 0,
                    TotalDeliveries = 0 // Hoặc bạn có thể đặt giá trị mặc định khác nếu cần
                };
                // Tạo tài khoản mới
                var userID = getuserid;
                var username = "Chưa cập nhật";
                var password = "Chưa cập nhật";
                var name = txtTenNV.Text;
                var email = txtEmail.Text;
                var phone = txtSoDT.Text;
                var address = "Chưa cập nhật";
                var role = "Shipper";
                var avatar = "Chưa cập nhật";
                var result = userService.CreateNewUserShipper(userID, username, password, name, email, phone, address, role, avatar);

                if (result)
                {
                    MessageBox.Show("Nhân viên vừa được tạo tài khoản, hãy cập nhật thông tin đăng nhập");
                
         
                }
                else
                {
                    MessageBox.Show("Tạo tài khoản thất bại.");
                }
                try
                {
                    // Gọi phương thức thêm từ dịch vụ
                    deliveryPersonnelService.AddDeliveryPersonnel(newDeliveryPersonnel);

                    // Tải lại danh sách nhân viên giao hàng
                    LoadDeliveryPersonnel();

                    // Thông báo thành công
                    MessageBox.Show("Nhân viên đã được thêm.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Đặt lại trạng thái của các điều khiển
                    SetControlsReadOnly(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi thêm nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ClearInputFields()
        {
            txtTenNV.Text = "";
            txtSoDT.Text = "";
            txtPhuongTien.Text = "";
            txtBienSo.Text = "";
            comboboxTrangThai.SelectedIndex = -1;
            txtDanhGia.Text = "";
        }

        private string GenerateNewDeliveryPersonnelId()
        {
            // Lấy danh sách tất cả nhân viên giao hàng từ cơ sở dữ liệu
            var allDeliveryPersonnel = deliveryPersonnelService.GetAllDeliveryPersonnel();

            // Tìm mã nhân viên lớn nhất hiện có
            var maxId = allDeliveryPersonnel
                .Select(dp => dp.DeliveryPersonnelId)
                .Where(id => id.StartsWith("SHIP"))
                .Select(id => int.Parse(id.Substring(4)))
                .DefaultIfEmpty(0)
                .Max();

            // Tạo mã nhân viên mới với số thứ tự tiếp theo
            return $"SHIP{maxId + 1:D3}"; // Đảm bảo số thứ tự luôn có 3 chữ số
        }
        
        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có thông tin nhân viên đã chọn
            if (!string.IsNullOrEmpty(selectedDeliveryPersonnelId))
            {
                // Cho phép nhập dữ liệu vào các trường
                SetControlsReadOnly(false);
                comboboxTrangThai.Enabled = true;
                txtDanhGia.ReadOnly = false;

                // Đánh dấu chế độ chỉnh sửa
                isEditing = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để chỉnh sửa.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLocNhanVien_Click(object sender, EventArgs e)
        {
            var selectedStatus = comboBoxLocTrangThai.SelectedItem?.ToString();

            // Lấy tất cả nhân viên giao hàng từ dịch vụ
            var allDeliveryPersonnel = deliveryPersonnelService.GetAllDeliveryPersonnel();

            // Lọc danh sách theo trạng thái được chọn
            var filteredDeliveryPersonnel = selectedStatus == "Tất cả"
                ? allDeliveryPersonnel
                : allDeliveryPersonnel.Where(dp => dp.Status == selectedStatus).ToList();

            // Cập nhật dataGridViewNhanVienGiaoHang với danh sách đã lọc
            dataGridViewNhanVienGiaoHang.DataSource = filteredDeliveryPersonnel;
        }
    }
}
