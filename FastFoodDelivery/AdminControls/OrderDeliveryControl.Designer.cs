namespace FastFoodDelivery.AdminControls
{
    partial class OrderDeliveryControl
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
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboboxTrangThai = new System.Windows.Forms.ComboBox();
            this.comboboxNhanVien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtMaDH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxLocTrangThai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxLocNguoiGiao = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTatCaDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(14, 96);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.Size = new System.Drawing.Size(1002, 374);
            this.dataGridViewOrder.TabIndex = 0;
            this.dataGridViewOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrder_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(286, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(373, 31);
            this.label5.TabIndex = 20;
            this.label5.Text = "QUẢN LÍ ĐƠN GIAO HÀNG";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboboxTrangThai);
            this.panel1.Controls.Add(this.comboboxNhanVien);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.txtMaDH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(14, 487);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 108);
            this.panel1.TabIndex = 21;
            // 
            // comboboxTrangThai
            // 
            this.comboboxTrangThai.FormattingEnabled = true;
            this.comboboxTrangThai.Location = new System.Drawing.Point(598, 44);
            this.comboboxTrangThai.Name = "comboboxTrangThai";
            this.comboboxTrangThai.Size = new System.Drawing.Size(185, 21);
            this.comboboxTrangThai.TabIndex = 37;
            this.comboboxTrangThai.SelectedIndexChanged += new System.EventHandler(this.comboboxTrangThai_SelectedIndexChanged);
            // 
            // comboboxNhanVien
            // 
            this.comboboxNhanVien.FormattingEnabled = true;
            this.comboboxNhanVien.Location = new System.Drawing.Point(314, 44);
            this.comboboxNhanVien.Name = "comboboxNhanVien";
            this.comboboxNhanVien.Size = new System.Drawing.Size(184, 21);
            this.comboboxNhanVien.TabIndex = 36;
            this.comboboxNhanVien.SelectedIndexChanged += new System.EventHandler(this.comboboxNhanVien_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(202, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nhân viên giao : ";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCapNhat.Location = new System.Drawing.Point(831, 36);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(146, 34);
            this.btnCapNhat.TabIndex = 22;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtMaDH
            // 
            this.txtMaDH.Location = new System.Drawing.Point(92, 39);
            this.txtMaDH.Multiline = true;
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.Size = new System.Drawing.Size(85, 25);
            this.txtMaDH.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(16, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Đơn hàng :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(516, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Trạng thái : ";
            // 
            // comboBoxLocTrangThai
            // 
            this.comboBoxLocTrangThai.FormattingEnabled = true;
            this.comboBoxLocTrangThai.Location = new System.Drawing.Point(138, 62);
            this.comboBoxLocTrangThai.Name = "comboBoxLocTrangThai";
            this.comboBoxLocTrangThai.Size = new System.Drawing.Size(185, 21);
            this.comboBoxLocTrangThai.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(56, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Trạng thái : ";
            // 
            // comboBoxLocNguoiGiao
            // 
            this.comboBoxLocNguoiGiao.FormattingEnabled = true;
            this.comboBoxLocNguoiGiao.Location = new System.Drawing.Point(489, 62);
            this.comboBoxLocNguoiGiao.Name = "comboBoxLocNguoiGiao";
            this.comboBoxLocNguoiGiao.Size = new System.Drawing.Size(185, 21);
            this.comboBoxLocNguoiGiao.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(360, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Người giao hàng :";
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(702, 63);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(88, 21);
            this.btnLoc.TabIndex = 42;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::FastFoodDelivery.Properties.Resources.giohang;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(648, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 34);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // btnTatCaDon
            // 
            this.btnTatCaDon.Location = new System.Drawing.Point(917, 64);
            this.btnTatCaDon.Name = "btnTatCaDon";
            this.btnTatCaDon.Size = new System.Drawing.Size(99, 21);
            this.btnTatCaDon.TabIndex = 44;
            this.btnTatCaDon.Text = "Tất cả đơn ";
            this.btnTatCaDon.UseVisualStyleBackColor = true;
            this.btnTatCaDon.Click += new System.EventHandler(this.btnTatCaDon_Click);
            // 
            // OrderDeliveryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btnTatCaDon);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.comboBoxLocNguoiGiao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxLocTrangThai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewOrder);
            this.Controls.Add(this.pictureBox1);
            this.Name = "OrderDeliveryControl";
            this.Size = new System.Drawing.Size(1034, 619);
            this.Load += new System.EventHandler(this.OrderDeliveryControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaDH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ComboBox comboboxTrangThai;
        private System.Windows.Forms.ComboBox comboboxNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxLocTrangThai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxLocNguoiGiao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTatCaDon;
    }
}
