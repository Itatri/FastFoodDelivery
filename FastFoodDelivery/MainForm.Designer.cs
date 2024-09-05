namespace FastFoodDelivery
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxAvatarLogin = new System.Windows.Forms.PictureBox();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.panelTaiKhoanDN = new System.Windows.Forms.Panel();
            this.labelMaKH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.btnThongTinTaiKhoanShipper = new System.Windows.Forms.Button();
            this.buttonDonGiaoThanhCong = new System.Windows.Forms.Button();
            this.btnQLSP = new System.Windows.Forms.Button();
            this.btnDonGiao = new System.Windows.Forms.Button();
            this.buttonVoucher = new System.Windows.Forms.Button();
            this.btnQLTK = new System.Windows.Forms.Button();
            this.btnNVGH = new System.Windows.Forms.Button();
            this.btnQLCH = new System.Windows.Forms.Button();
            this.btnQLDH = new System.Windows.Forms.Button();
            this.btnLichSuMH = new System.Windows.Forms.Button();
            this.btnGioHang = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnDatHang = new System.Windows.Forms.Button();
            this.btnThongTinCN = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.lbDongHo = new System.Windows.Forms.Label();
            this.lbNgayThang = new System.Windows.Forms.Label();
            this.timerDongHo = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatarLogin)).BeginInit();
            this.panelTaiKhoanDN.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatarLogin
            // 
            this.pictureBoxAvatarLogin.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAvatarLogin.BackgroundImage = global::FastFoodDelivery.Properties.Resources.account;
            this.pictureBoxAvatarLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxAvatarLogin.Location = new System.Drawing.Point(9, 12);
            this.pictureBoxAvatarLogin.Name = "pictureBoxAvatarLogin";
            this.pictureBoxAvatarLogin.Size = new System.Drawing.Size(74, 80);
            this.pictureBoxAvatarLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatarLogin.TabIndex = 0;
            this.pictureBoxAvatarLogin.TabStop = false;
            this.pictureBoxAvatarLogin.Click += new System.EventHandler(this.pictureBoxAvatarLogin_Click);
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.BackColor = System.Drawing.Color.Transparent;
            this.lbHoTen.ForeColor = System.Drawing.Color.White;
            this.lbHoTen.Location = new System.Drawing.Point(92, 14);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(74, 13);
            this.lbHoTen.TabIndex = 1;
            this.lbHoTen.Text = "Họ tên : None";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.BackColor = System.Drawing.Color.Transparent;
            this.lbPhone.ForeColor = System.Drawing.Color.White;
            this.lbPhone.Location = new System.Drawing.Point(92, 37);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(73, 13);
            this.lbPhone.TabIndex = 2;
            this.lbPhone.Text = "Phone : None";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbEmail.ForeColor = System.Drawing.Color.White;
            this.lbEmail.Location = new System.Drawing.Point(92, 59);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(67, 13);
            this.lbEmail.TabIndex = 3;
            this.lbEmail.Text = "Email : None";
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.BackColor = System.Drawing.Color.Transparent;
            this.lbRole.ForeColor = System.Drawing.Color.White;
            this.lbRole.Location = new System.Drawing.Point(92, 81);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(72, 13);
            this.lbRole.TabIndex = 4;
            this.lbRole.Text = "Vai trò : None";
            // 
            // panelTaiKhoanDN
            // 
            this.panelTaiKhoanDN.BackColor = System.Drawing.Color.Black;
            this.panelTaiKhoanDN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTaiKhoanDN.Controls.Add(this.labelMaKH);
            this.panelTaiKhoanDN.Controls.Add(this.pictureBoxAvatarLogin);
            this.panelTaiKhoanDN.Controls.Add(this.lbRole);
            this.panelTaiKhoanDN.Controls.Add(this.lbHoTen);
            this.panelTaiKhoanDN.Controls.Add(this.lbEmail);
            this.panelTaiKhoanDN.Controls.Add(this.lbPhone);
            this.panelTaiKhoanDN.Location = new System.Drawing.Point(12, 12);
            this.panelTaiKhoanDN.Name = "panelTaiKhoanDN";
            this.panelTaiKhoanDN.Size = new System.Drawing.Size(252, 117);
            this.panelTaiKhoanDN.TabIndex = 5;
            this.panelTaiKhoanDN.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTaiKhoanDN_Paint);
            // 
            // labelMaKH
            // 
            this.labelMaKH.BackColor = System.Drawing.Color.Transparent;
            this.labelMaKH.ForeColor = System.Drawing.Color.White;
            this.labelMaKH.Location = new System.Drawing.Point(9, 94);
            this.labelMaKH.Name = "labelMaKH";
            this.labelMaKH.Size = new System.Drawing.Size(74, 13);
            this.labelMaKH.TabIndex = 5;
            this.labelMaKH.Text = "KH001";
            this.labelMaKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("ArcadeClassic", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(758, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 87);
            this.label1.TabIndex = 6;
            this.label1.Text = "GOOD FOOD";
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.Transparent;
            this.PanelMenu.Controls.Add(this.btnThongTinTaiKhoanShipper);
            this.PanelMenu.Controls.Add(this.buttonDonGiaoThanhCong);
            this.PanelMenu.Controls.Add(this.btnQLSP);
            this.PanelMenu.Controls.Add(this.btnDonGiao);
            this.PanelMenu.Controls.Add(this.buttonVoucher);
            this.PanelMenu.Controls.Add(this.btnQLTK);
            this.PanelMenu.Controls.Add(this.btnNVGH);
            this.PanelMenu.Controls.Add(this.btnQLCH);
            this.PanelMenu.Controls.Add(this.btnQLDH);
            this.PanelMenu.Controls.Add(this.btnLichSuMH);
            this.PanelMenu.Controls.Add(this.btnGioHang);
            this.PanelMenu.Controls.Add(this.btnHome);
            this.PanelMenu.Controls.Add(this.btnDatHang);
            this.PanelMenu.Controls.Add(this.btnThongTinCN);
            this.PanelMenu.Location = new System.Drawing.Point(12, 132);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(251, 634);
            this.PanelMenu.TabIndex = 7;
            this.PanelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMenu_Paint);
            // 
            // btnThongTinTaiKhoanShipper
            // 
            this.btnThongTinTaiKhoanShipper.BackColor = System.Drawing.Color.White;
            this.btnThongTinTaiKhoanShipper.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThongTinTaiKhoanShipper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongTinTaiKhoanShipper.ForeColor = System.Drawing.Color.Black;
            this.btnThongTinTaiKhoanShipper.Location = new System.Drawing.Point(0, 3);
            this.btnThongTinTaiKhoanShipper.Name = "btnThongTinTaiKhoanShipper";
            this.btnThongTinTaiKhoanShipper.Size = new System.Drawing.Size(250, 50);
            this.btnThongTinTaiKhoanShipper.TabIndex = 13;
            this.btnThongTinTaiKhoanShipper.Text = "Thông tin tài khoản";
            this.btnThongTinTaiKhoanShipper.UseVisualStyleBackColor = false;
            this.btnThongTinTaiKhoanShipper.Click += new System.EventHandler(this.btnThongTinTaiKhoanShipper_Click);
            // 
            // buttonDonGiaoThanhCong
            // 
            this.buttonDonGiaoThanhCong.BackColor = System.Drawing.Color.White;
            this.buttonDonGiaoThanhCong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDonGiaoThanhCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonDonGiaoThanhCong.ForeColor = System.Drawing.Color.Black;
            this.buttonDonGiaoThanhCong.Location = new System.Drawing.Point(0, 115);
            this.buttonDonGiaoThanhCong.Name = "buttonDonGiaoThanhCong";
            this.buttonDonGiaoThanhCong.Size = new System.Drawing.Size(250, 50);
            this.buttonDonGiaoThanhCong.TabIndex = 12;
            this.buttonDonGiaoThanhCong.Text = "Đơn giao thành công";
            this.buttonDonGiaoThanhCong.UseVisualStyleBackColor = false;
            this.buttonDonGiaoThanhCong.Click += new System.EventHandler(this.buttonDonGiaoThanhCong_Click);
            // 
            // btnQLSP
            // 
            this.btnQLSP.BackColor = System.Drawing.Color.White;
            this.btnQLSP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQLSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLSP.ForeColor = System.Drawing.Color.Black;
            this.btnQLSP.Location = new System.Drawing.Point(0, 59);
            this.btnQLSP.Name = "btnQLSP";
            this.btnQLSP.Size = new System.Drawing.Size(251, 50);
            this.btnQLSP.TabIndex = 5;
            this.btnQLSP.Text = "Quản lý món ăn";
            this.btnQLSP.UseVisualStyleBackColor = false;
            this.btnQLSP.Click += new System.EventHandler(this.btnQLSP_Click);
            // 
            // btnDonGiao
            // 
            this.btnDonGiao.BackColor = System.Drawing.Color.White;
            this.btnDonGiao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDonGiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDonGiao.ForeColor = System.Drawing.Color.Black;
            this.btnDonGiao.Location = new System.Drawing.Point(0, 59);
            this.btnDonGiao.Name = "btnDonGiao";
            this.btnDonGiao.Size = new System.Drawing.Size(250, 50);
            this.btnDonGiao.TabIndex = 11;
            this.btnDonGiao.Text = "Đơn giao";
            this.btnDonGiao.UseVisualStyleBackColor = false;
            this.btnDonGiao.Click += new System.EventHandler(this.btnDonGiao_Click);
            // 
            // buttonVoucher
            // 
            this.buttonVoucher.BackColor = System.Drawing.Color.White;
            this.buttonVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonVoucher.ForeColor = System.Drawing.Color.Black;
            this.buttonVoucher.Location = new System.Drawing.Point(1, 283);
            this.buttonVoucher.Name = "buttonVoucher";
            this.buttonVoucher.Size = new System.Drawing.Size(250, 50);
            this.buttonVoucher.TabIndex = 10;
            this.buttonVoucher.Text = "Quản lí voucher";
            this.buttonVoucher.UseVisualStyleBackColor = false;
            this.buttonVoucher.Click += new System.EventHandler(this.buttonVoucher_Click);
            // 
            // btnQLTK
            // 
            this.btnQLTK.BackColor = System.Drawing.Color.White;
            this.btnQLTK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQLTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLTK.ForeColor = System.Drawing.Color.Black;
            this.btnQLTK.Location = new System.Drawing.Point(1, 227);
            this.btnQLTK.Name = "btnQLTK";
            this.btnQLTK.Size = new System.Drawing.Size(250, 50);
            this.btnQLTK.TabIndex = 9;
            this.btnQLTK.Text = "Quản lí tài khoản";
            this.btnQLTK.UseVisualStyleBackColor = false;
            this.btnQLTK.Click += new System.EventHandler(this.btnQLTK_Click);
            // 
            // btnNVGH
            // 
            this.btnNVGH.BackColor = System.Drawing.Color.White;
            this.btnNVGH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNVGH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNVGH.ForeColor = System.Drawing.Color.Black;
            this.btnNVGH.Location = new System.Drawing.Point(0, 171);
            this.btnNVGH.Name = "btnNVGH";
            this.btnNVGH.Size = new System.Drawing.Size(251, 50);
            this.btnNVGH.TabIndex = 8;
            this.btnNVGH.Text = "Quản lí nhân viên giao hàng";
            this.btnNVGH.UseVisualStyleBackColor = false;
            this.btnNVGH.Click += new System.EventHandler(this.btnNVGH_Click);
            // 
            // btnQLCH
            // 
            this.btnQLCH.BackColor = System.Drawing.Color.White;
            this.btnQLCH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQLCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLCH.ForeColor = System.Drawing.Color.Black;
            this.btnQLCH.Location = new System.Drawing.Point(0, 3);
            this.btnQLCH.Name = "btnQLCH";
            this.btnQLCH.Size = new System.Drawing.Size(251, 50);
            this.btnQLCH.TabIndex = 7;
            this.btnQLCH.Text = "Quản lí cửa hàng";
            this.btnQLCH.UseVisualStyleBackColor = false;
            this.btnQLCH.Click += new System.EventHandler(this.btnQLCH_Click);
            // 
            // btnQLDH
            // 
            this.btnQLDH.BackColor = System.Drawing.Color.White;
            this.btnQLDH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQLDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLDH.ForeColor = System.Drawing.Color.Black;
            this.btnQLDH.Location = new System.Drawing.Point(0, 115);
            this.btnQLDH.Name = "btnQLDH";
            this.btnQLDH.Size = new System.Drawing.Size(251, 50);
            this.btnQLDH.TabIndex = 6;
            this.btnQLDH.Text = "Quản lí đơn hàng";
            this.btnQLDH.UseVisualStyleBackColor = false;
            this.btnQLDH.Click += new System.EventHandler(this.btnQLDH_Click);
            // 
            // btnLichSuMH
            // 
            this.btnLichSuMH.BackColor = System.Drawing.Color.White;
            this.btnLichSuMH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLichSuMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLichSuMH.ForeColor = System.Drawing.Color.Black;
            this.btnLichSuMH.Location = new System.Drawing.Point(0, 227);
            this.btnLichSuMH.Name = "btnLichSuMH";
            this.btnLichSuMH.Size = new System.Drawing.Size(251, 50);
            this.btnLichSuMH.TabIndex = 4;
            this.btnLichSuMH.Text = "Lịch sử mua hàng";
            this.btnLichSuMH.UseVisualStyleBackColor = false;
            this.btnLichSuMH.Click += new System.EventHandler(this.btnLichSuMH_Click);
            // 
            // btnGioHang
            // 
            this.btnGioHang.BackColor = System.Drawing.Color.White;
            this.btnGioHang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGioHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGioHang.ForeColor = System.Drawing.Color.Black;
            this.btnGioHang.Location = new System.Drawing.Point(0, 171);
            this.btnGioHang.Name = "btnGioHang";
            this.btnGioHang.Size = new System.Drawing.Size(251, 50);
            this.btnGioHang.TabIndex = 3;
            this.btnGioHang.Text = "Giỏ hàng";
            this.btnGioHang.UseVisualStyleBackColor = false;
            this.btnGioHang.Click += new System.EventHandler(this.btnGioHang_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Location = new System.Drawing.Point(0, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(251, 50);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnDatHang
            // 
            this.btnDatHang.BackColor = System.Drawing.Color.White;
            this.btnDatHang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDatHang.ForeColor = System.Drawing.Color.Black;
            this.btnDatHang.Location = new System.Drawing.Point(0, 115);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(251, 50);
            this.btnDatHang.TabIndex = 1;
            this.btnDatHang.Text = "Đặt món";
            this.btnDatHang.UseVisualStyleBackColor = false;
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // btnThongTinCN
            // 
            this.btnThongTinCN.BackColor = System.Drawing.Color.White;
            this.btnThongTinCN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThongTinCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongTinCN.ForeColor = System.Drawing.Color.Black;
            this.btnThongTinCN.Location = new System.Drawing.Point(0, 59);
            this.btnThongTinCN.Name = "btnThongTinCN";
            this.btnThongTinCN.Size = new System.Drawing.Size(251, 50);
            this.btnThongTinCN.TabIndex = 0;
            this.btnThongTinCN.Text = "Thông tin tài khoản";
            this.btnThongTinCN.UseVisualStyleBackColor = false;
            this.btnThongTinCN.Click += new System.EventHandler(this.btnThongTinCN_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(742, 775);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(123, 40);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.Transparent;
            this.panelContent.Location = new System.Drawing.Point(270, 135);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1032, 631);
            this.panelContent.TabIndex = 9;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // lbDongHo
            // 
            this.lbDongHo.AutoSize = true;
            this.lbDongHo.BackColor = System.Drawing.Color.Transparent;
            this.lbDongHo.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDongHo.ForeColor = System.Drawing.Color.Black;
            this.lbDongHo.Location = new System.Drawing.Point(68, 32);
            this.lbDongHo.Name = "lbDongHo";
            this.lbDongHo.Size = new System.Drawing.Size(54, 20);
            this.lbDongHo.TabIndex = 12;
            this.lbDongHo.Text = "00:00";
            // 
            // lbNgayThang
            // 
            this.lbNgayThang.AutoSize = true;
            this.lbNgayThang.BackColor = System.Drawing.Color.Transparent;
            this.lbNgayThang.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayThang.ForeColor = System.Drawing.Color.Black;
            this.lbNgayThang.Location = new System.Drawing.Point(217, 32);
            this.lbNgayThang.Name = "lbNgayThang";
            this.lbNgayThang.Size = new System.Drawing.Size(99, 20);
            this.lbNgayThang.TabIndex = 13;
            this.lbNgayThang.Text = "00/00/0000";
            // 
            // timerDongHo
            // 
            this.timerDongHo.Interval = 1000;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lbDongHo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbNgayThang);
            this.panel1.Location = new System.Drawing.Point(270, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 117);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::FastFoodDelivery.Properties.Resources.date;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(164, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 35);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FastFoodDelivery.Properties.Resources.clockicon1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(6, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 52);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FastFoodDelivery.Properties.Resources.nenmain;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1306, 824);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTaiKhoanDN);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatarLogin)).EndInit();
            this.panelTaiKhoanDN.ResumeLayout(false);
            this.panelTaiKhoanDN.PerformLayout();
            this.PanelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatarLogin;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Panel panelTaiKhoanDN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button btnThongTinCN;
        private System.Windows.Forms.Button btnDatHang;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnGioHang;
        private System.Windows.Forms.Label lbDongHo;
        private System.Windows.Forms.Label lbNgayThang;
        private System.Windows.Forms.Timer timerDongHo;
        private System.Windows.Forms.Label labelMaKH;
        private System.Windows.Forms.Button btnLichSuMH;
        private System.Windows.Forms.Button btnQLDH;
        private System.Windows.Forms.Button btnQLSP;
        private System.Windows.Forms.Button btnQLCH;
        private System.Windows.Forms.Button btnNVGH;
        private System.Windows.Forms.Button btnQLTK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonVoucher;
        private System.Windows.Forms.Button btnDonGiao;
        private System.Windows.Forms.Button buttonDonGiaoThanhCong;
        private System.Windows.Forms.Button btnThongTinTaiKhoanShipper;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}