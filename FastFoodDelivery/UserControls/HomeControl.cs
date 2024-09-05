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

namespace FastFoodDelivery.UserControls
{
    public partial class HomeControl : UserControl
    {
        private VoucherService _voucherService;
        private ReviewService _reviewService;
        public HomeControl()
        {
            InitializeComponent();
            _voucherService = new VoucherService();
            _reviewService = new ReviewService();
        }

        private async void HomeControl_Load(object sender, EventArgs e)
        {
            await LoadVouchersAsync();
            await LoadReviewsAsync();
        }
        private async Task LoadVouchersAsync()
        {
            List<Voucher> vouchers = await _voucherService.GetAllVouchersAsync();

            var displayVouchers = vouchers.Select(v => new
            {
                v.Code,
                v.Description,
                v.StartDate,
                v.EndDate
            }).ToList();

            dataGridViewVoucher.DataSource = displayVouchers;

            // Đặt tên cột
            dataGridViewVoucher.Columns["Code"].HeaderText = "Mã khuyến mãi";
            dataGridViewVoucher.Columns["Description"].HeaderText = "Mô tả";
            dataGridViewVoucher.Columns["StartDate"].HeaderText = "Ngày bắt đầu";
            dataGridViewVoucher.Columns["EndDate"].HeaderText = "Hết hạn";

            // Tự động điều chỉnh kích thước các cột
            dataGridViewVoucher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private async Task LoadReviewsAsync()
        {
            List<Review> reviews = await _reviewService.GetAllReviewsAsync();

            var displayReviews = reviews.Select(r => new
            {
                r.Items,
                r.Comment,
                r.Rating
            }).ToList();

            dataGridViewReview.DataSource = displayReviews;

            // Đặt tên cột
            dataGridViewReview.Columns["Items"].HeaderText = "Món đặt";
            dataGridViewReview.Columns["Comment"].HeaderText = "Bình luận";
            dataGridViewReview.Columns["Rating"].HeaderText = "Điểm";

            // Tự động điều chỉnh kích thước các cột
            dataGridViewReview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridViewVoucher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewReview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
