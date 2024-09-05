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
    public partial class VoucherControl : UserControl
    {
        private UserInfo currentUser;
        private VoucherService voucherService;
        public VoucherControl()
        {
            InitializeComponent();
            voucherService = new VoucherService();
        }
        public void SetUserInfo(UserInfo user)
        {
            this.currentUser = user;
        }

        private void dataGridViewVoucher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewVoucher.Rows[e.RowIndex];
                txtMaVC.Text = row.Cells["VoucherCode"].Value.ToString();
                txtMotaVC.Text = row.Cells["description"].Value.ToString();
                comboBoxTypeVC.SelectedItem = row.Cells["discountType"].Value.ToString();
                txtDiscountValue.Text = row.Cells["discountValue"].Value.ToString();
                dateTimePickerStarDateVC.Value = DateTime.Parse(row.Cells["startDate"].Value.ToString());
                dateTimePickerEndDateVC.Value = DateTime.Parse(row.Cells["endDate"].Value.ToString());
                numericUpDownMaxVolumeVc.Text = row.Cells["maxUses"].Value.ToString();     
            }
        }

        private void VoucherControl_Load(object sender, EventArgs e)
        {
            LoadVouchers();
            LoadComboBoxTypeVC();
            EnableControls(false);

        }
        private void LoadComboBoxTypeVC()
        {
            comboBoxTypeVC.Items.Add("Giảm % bill");
            comboBoxTypeVC.Items.Add("Giảm tiền");
            comboBoxTypeVC.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void LoadVouchers()
        {
            var vouchers = voucherService.GetAllVouchers();
            var voucherDisplayList = vouchers.Select(v => new
            {
                VoucherCode = v.Code,
                description = v.Description,
                discountType = v.DiscountType,
                discountValue = v.DiscountValue,
                startDate = v.StartDate,
                endDate = v.EndDate,
                maxUses = v.MaxUses,
                currentUses = v.CurrentUses
            }).ToList();

            dataGridViewVoucher.DataSource = voucherDisplayList;
            dataGridViewVoucher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Đổi tên các cột thành tiếng Việt
            dataGridViewVoucher.Columns["VoucherCode"].HeaderText = "Mã Voucher";
            dataGridViewVoucher.Columns["description"].HeaderText = "Mô tả";
            dataGridViewVoucher.Columns["discountType"].HeaderText = "Loại khuyến mãi";
            dataGridViewVoucher.Columns["discountValue"].HeaderText = "Phần Trăm Giảm Giá";
            dataGridViewVoucher.Columns["startDate"].HeaderText = "Ngày Bắt Đầu";
            dataGridViewVoucher.Columns["endDate"].HeaderText = "Ngày Kết Thúc";
            dataGridViewVoucher.Columns["maxUses"].HeaderText = "Lượt sử dụng tối đa";
            dataGridViewVoucher.Columns["currentUses"].HeaderText = "Đã sử dụng";
        }

        private void comboBoxTypeVC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void EnableControls(bool enable)
        {
            txtMaVC.Enabled = enable;
            txtMotaVC.Enabled = enable;
            comboBoxTypeVC.Enabled = enable;
            txtDiscountValue.Enabled = enable;
            dateTimePickerStarDateVC.Enabled = enable;
            dateTimePickerEndDateVC.Enabled = enable;
            numericUpDownMaxVolumeVc.Enabled = enable;
        }
        private void btnThemVC_Click(object sender, EventArgs e)
        {
            EnableControls(true);
        }

        private void btnSuaVC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaVC.Text))
            {
                MessageBox.Show("Vui lòng chọn một voucher để chỉnh sửa.");
                return;
            }

            EnableControls(true); // Kích hoạt các trường thông tin để chỉnh sửa
        }

        private void btnXoaVC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaVC.Text))
            {
                MessageBox.Show("Vui lòng chọn một voucher để xóa.");
                return;
            }

            var voucherCode = txtMaVC.Text;

            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa voucher này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                voucherService.DeleteVoucher(voucherCode);
                MessageBox.Show("Voucher đã được xóa thành công.");
                LoadVouchers(); // Reload the vouchers to reflect the changes
            }
        }

        private async void btnLuuVC_Click(object sender, EventArgs e)
        {
          
            if (ValidateFields())
            {
                var voucherCode = txtMaVC.Text;
                var existingVoucher = await voucherService.GetVoucherByCodeAsync(voucherCode);

                var voucher = new Voucher
                {
                    Code = voucherCode,
                    Description = txtMotaVC.Text,
                    DiscountType = comboBoxTypeVC.SelectedItem.ToString(),
                    DiscountValue = Convert.ToDecimal(txtDiscountValue.Text),
                    StartDate = dateTimePickerStarDateVC.Value,
                    EndDate = dateTimePickerEndDateVC.Value,
                    MaxUses = Convert.ToInt32(numericUpDownMaxVolumeVc.Value),
                    CurrentUses = existingVoucher?.CurrentUses ?? 0
                };

                if (existingVoucher != null) // Nếu voucher đã tồn tại thì cập nhật
                {
                    await voucherService.UpdateVoucherAsync(voucher);
                    MessageBox.Show("Voucher đã được cập nhật thành công.");
                }
                else // Nếu voucher chưa tồn tại thì thêm mới
                {
                    await voucherService.CreateVoucherAsync(voucher);
                    MessageBox.Show("Voucher đã được tạo thành công.");
                }

                LoadVouchers(); // Reload the vouchers to reflect the changes
                EnableControls(false); // Vô hiệu hóa các trường thông tin sau khi lưu
            }
        }

        private bool ValidateFields()
        {
            // Kiểm tra các trường thông tin để đảm bảo không có trường nào bị bỏ trống
            if (string.IsNullOrEmpty(txtMaVC.Text) ||
                string.IsNullOrEmpty(txtMotaVC.Text) ||
                comboBoxTypeVC.SelectedIndex == -1 ||
                !decimal.TryParse(txtDiscountValue.Text, out _) ||
                !int.TryParse(numericUpDownMaxVolumeVc.Text, out _))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và kiểm tra định dạng.");
                return false;
            }

            // Kiểm tra ngày bắt đầu không được lớn hơn ngày kết thúc
            if (dateTimePickerStarDateVC.Value > dateTimePickerEndDateVC.Value)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc.");
                return false;
            }

            return true;
        }

    }
}
