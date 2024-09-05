namespace FastFoodDelivery.AdminControls
{
    partial class ProductControl
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
            this.dataGridViewSanPham = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxCuaHang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.pictureBoxUpLoad = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaMonAn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMoTaMonAn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenMonAn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemMonAn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxSanPham = new System.Windows.Forms.PictureBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpLoad)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSanPham
            // 
            this.dataGridViewSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSanPham.Location = new System.Drawing.Point(20, 65);
            this.dataGridViewSanPham.Name = "dataGridViewSanPham";
            this.dataGridViewSanPham.Size = new System.Drawing.Size(683, 329);
            this.dataGridViewSanPham.TabIndex = 2;
            this.dataGridViewSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSanPham_CellClick);
            this.dataGridViewSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSanPham_CellContentClick);
            this.dataGridViewSanPham.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewSanPham_DataBindingComplete);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBoxCuaHang);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnUploadImage);
            this.panel1.Controls.Add(this.pictureBoxUpLoad);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCategory);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtGiaMonAn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMoTaMonAn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTenMonAn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(20, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 141);
            this.panel1.TabIndex = 4;
            // 
            // comboBoxCuaHang
            // 
            this.comboBoxCuaHang.FormattingEnabled = true;
            this.comboBoxCuaHang.Location = new System.Drawing.Point(548, 90);
            this.comboBoxCuaHang.Name = "comboBoxCuaHang";
            this.comboBoxCuaHang.Size = new System.Drawing.Size(177, 21);
            this.comboBoxCuaHang.TabIndex = 30;
            this.comboBoxCuaHang.SelectedIndexChanged += new System.EventHandler(this.comboBoxCuaHang_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(472, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Cửa hàng :";
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BackColor = System.Drawing.Color.White;
            this.btnUploadImage.ForeColor = System.Drawing.Color.Black;
            this.btnUploadImage.Location = new System.Drawing.Point(837, 90);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(63, 23);
            this.btnUploadImage.TabIndex = 28;
            this.btnUploadImage.Text = "Upload";
            this.btnUploadImage.UseVisualStyleBackColor = false;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // pictureBoxUpLoad
            // 
            this.pictureBoxUpLoad.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUpLoad.BackgroundImage = global::FastFoodDelivery.Properties.Resources.foodicon2;
            this.pictureBoxUpLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxUpLoad.Location = new System.Drawing.Point(914, 75);
            this.pictureBoxUpLoad.Name = "pictureBoxUpLoad";
            this.pictureBoxUpLoad.Size = new System.Drawing.Size(62, 52);
            this.pictureBoxUpLoad.TabIndex = 20;
            this.pictureBoxUpLoad.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(766, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Hình ảnh :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(837, 34);
            this.txtCategory.Multiline = true;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(142, 27);
            this.txtCategory.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(745, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Loại món ăn : ";
            // 
            // txtGiaMonAn
            // 
            this.txtGiaMonAn.Location = new System.Drawing.Point(548, 36);
            this.txtGiaMonAn.Multiline = true;
            this.txtGiaMonAn.Name = "txtGiaMonAn";
            this.txtGiaMonAn.Size = new System.Drawing.Size(177, 24);
            this.txtGiaMonAn.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(505, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Giá : ";
            // 
            // txtMoTaMonAn
            // 
            this.txtMoTaMonAn.Location = new System.Drawing.Point(284, 35);
            this.txtMoTaMonAn.Multiline = true;
            this.txtMoTaMonAn.Name = "txtMoTaMonAn";
            this.txtMoTaMonAn.Size = new System.Drawing.Size(177, 50);
            this.txtMoTaMonAn.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(229, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mô tả : ";
            // 
            // txtTenMonAn
            // 
            this.txtTenMonAn.Location = new System.Drawing.Point(102, 35);
            this.txtTenMonAn.Multiline = true;
            this.txtTenMonAn.Name = "txtTenMonAn";
            this.txtTenMonAn.Size = new System.Drawing.Size(120, 50);
            this.txtTenMonAn.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên món ăn :";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Location = new System.Drawing.Point(351, 575);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(168, 35);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa thông tin món ăn";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(627, 575);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(146, 35);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa món ăn";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemMonAn
            // 
            this.btnThemMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemMonAn.Location = new System.Drawing.Point(97, 575);
            this.btnThemMonAn.Name = "btnThemMonAn";
            this.btnThemMonAn.Size = new System.Drawing.Size(146, 35);
            this.btnThemMonAn.TabIndex = 10;
            this.btnThemMonAn.Text = "Thêm món ăn";
            this.btnThemMonAn.UseVisualStyleBackColor = true;
            this.btnThemMonAn.Click += new System.EventHandler(this.btnThemMonAn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(357, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 31);
            this.label7.TabIndex = 31;
            this.label7.Text = "QUẢN LÍ MÓN ĂN";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBoxSanPham);
            this.panel2.Location = new System.Drawing.Point(710, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 329);
            this.panel2.TabIndex = 32;
            // 
            // pictureBoxSanPham
            // 
            this.pictureBoxSanPham.BackgroundImage = global::FastFoodDelivery.Properties.Resources.foodicon1;
            this.pictureBoxSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxSanPham.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxSanPham.Name = "pictureBoxSanPham";
            this.pictureBoxSanPham.Size = new System.Drawing.Size(295, 321);
            this.pictureBoxSanPham.TabIndex = 3;
            this.pictureBoxSanPham.TabStop = false;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Location = new System.Drawing.Point(847, 575);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(146, 35);
            this.btnLuu.TabIndex = 33;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::FastFoodDelivery.Properties.Resources.pngegg;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(591, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemMonAn);
            this.Controls.Add(this.dataGridViewSanPham);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(1027, 620);
            this.Load += new System.EventHandler(this.ProductControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpLoad)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSanPham;
        private System.Windows.Forms.DataGridView dataGridViewSanPham;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemMonAn;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiaMonAn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMoTaMonAn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenMonAn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxUpLoad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.ComboBox comboBoxCuaHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
