namespace FastFoodDelivery.AdminControls
{
    partial class ShopControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewCuaHang = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDownDanhGia = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLoaiMonAn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThanhPho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenCH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSuaCH = new System.Windows.Forms.Button();
            this.btnXoaCH = new System.Windows.Forms.Button();
            this.btnThemCH = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLuuCH = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuaHang)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDanhGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCuaHang
            // 
            this.dataGridViewCuaHang.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCuaHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCuaHang.Location = new System.Drawing.Point(25, 81);
            this.dataGridViewCuaHang.Name = "dataGridViewCuaHang";
            this.dataGridViewCuaHang.Size = new System.Drawing.Size(973, 352);
            this.dataGridViewCuaHang.TabIndex = 0;
            this.dataGridViewCuaHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCuaHang_CellContentClick);
            this.dataGridViewCuaHang.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewCuaHang_DataBindingComplete);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.numericUpDownDanhGia);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtLoaiMonAn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtThanhPho);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDuong);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTenCH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, 457);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 106);
            this.panel1.TabIndex = 1;
            // 
            // numericUpDownDanhGia
            // 
            this.numericUpDownDanhGia.Location = new System.Drawing.Point(812, 69);
            this.numericUpDownDanhGia.Name = "numericUpDownDanhGia";
            this.numericUpDownDanhGia.Size = new System.Drawing.Size(141, 20);
            this.numericUpDownDanhGia.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(739, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Đánh giá : ";
            // 
            // txtLoaiMonAn
            // 
            this.txtLoaiMonAn.Location = new System.Drawing.Point(812, 22);
            this.txtLoaiMonAn.Multiline = true;
            this.txtLoaiMonAn.Name = "txtLoaiMonAn";
            this.txtLoaiMonAn.Size = new System.Drawing.Size(141, 25);
            this.txtLoaiMonAn.TabIndex = 7;
            this.txtLoaiMonAn.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(717, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Loại ẩm thực : ";
            // 
            // txtThanhPho
            // 
            this.txtThanhPho.Location = new System.Drawing.Point(568, 23);
            this.txtThanhPho.Multiline = true;
            this.txtThanhPho.Name = "txtThanhPho";
            this.txtThanhPho.Size = new System.Drawing.Size(134, 50);
            this.txtThanhPho.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(485, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thành phố :";
            // 
            // txtDuong
            // 
            this.txtDuong.Location = new System.Drawing.Point(302, 21);
            this.txtDuong.Multiline = true;
            this.txtDuong.Name = "txtDuong";
            this.txtDuong.Size = new System.Drawing.Size(177, 52);
            this.txtDuong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(244, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đường :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTenCH
            // 
            this.txtTenCH.Location = new System.Drawing.Point(106, 21);
            this.txtTenCH.Multiline = true;
            this.txtTenCH.Name = "txtTenCH";
            this.txtTenCH.Size = new System.Drawing.Size(120, 52);
            this.txtTenCH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên cửa hàng :";
            // 
            // btnSuaCH
            // 
            this.btnSuaCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaCH.Location = new System.Drawing.Point(301, 578);
            this.btnSuaCH.Name = "btnSuaCH";
            this.btnSuaCH.Size = new System.Drawing.Size(182, 35);
            this.btnSuaCH.TabIndex = 4;
            this.btnSuaCH.Text = "Sửa thông tin cửa hàng";
            this.btnSuaCH.UseVisualStyleBackColor = true;
            this.btnSuaCH.Click += new System.EventHandler(this.btnSuaCH_Click);
            // 
            // btnXoaCH
            // 
            this.btnXoaCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaCH.Location = new System.Drawing.Point(572, 578);
            this.btnXoaCH.Name = "btnXoaCH";
            this.btnXoaCH.Size = new System.Drawing.Size(168, 35);
            this.btnXoaCH.TabIndex = 3;
            this.btnXoaCH.Text = "Xóa cửa hàng";
            this.btnXoaCH.UseVisualStyleBackColor = true;
            this.btnXoaCH.Click += new System.EventHandler(this.btnXoaCH_Click);
            // 
            // btnThemCH
            // 
            this.btnThemCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemCH.Location = new System.Drawing.Point(40, 578);
            this.btnThemCH.Name = "btnThemCH";
            this.btnThemCH.Size = new System.Drawing.Size(173, 35);
            this.btnThemCH.TabIndex = 2;
            this.btnThemCH.Text = "Thêm cửa hàng";
            this.btnThemCH.UseVisualStyleBackColor = true;
            this.btnThemCH.Click += new System.EventHandler(this.btnThemCH_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(338, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 31);
            this.label5.TabIndex = 19;
            this.label5.Text = "QUẢN LÍ CỬA HÀNG";
            // 
            // btnLuuCH
            // 
            this.btnLuuCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuuCH.Location = new System.Drawing.Point(828, 578);
            this.btnLuuCH.Name = "btnLuuCH";
            this.btnLuuCH.Size = new System.Drawing.Size(156, 35);
            this.btnLuuCH.TabIndex = 20;
            this.btnLuuCH.Text = "Lưu";
            this.btnLuuCH.UseVisualStyleBackColor = true;
            this.btnLuuCH.Click += new System.EventHandler(this.btnLuuCH_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::FastFoodDelivery.Properties.Resources.cuahang;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(615, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 41);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // ShopControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btnLuuCH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSuaCH);
            this.Controls.Add(this.btnXoaCH);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThemCH);
            this.Controls.Add(this.dataGridViewCuaHang);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ShopControl";
            this.Size = new System.Drawing.Size(1023, 625);
            this.Load += new System.EventHandler(this.ShopControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuaHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDanhGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCuaHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTenCH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoaiMonAn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThanhPho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThemCH;
        private System.Windows.Forms.Button btnXoaCH;
        private System.Windows.Forms.Button btnSuaCH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownDanhGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLuuCH;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
