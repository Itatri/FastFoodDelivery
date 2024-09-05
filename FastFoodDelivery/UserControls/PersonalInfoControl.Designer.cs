namespace FastFoodDelivery.UserControls
{
    partial class PersonalInfoControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMaTK = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbCreateDate = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbEmailCT = new System.Windows.Forms.Label();
            this.lbHoTenCT = new System.Windows.Forms.Label();
            this.lbTaiKhoanCT = new System.Windows.Forms.Label();
            this.btnEditInfo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxAvatarInfo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatarInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(348, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(14, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài khoản :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(14, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(15, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(14, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điện thoại : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(14, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Địa chỉ :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(14, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày tạo :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(14, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Loại tài khoản :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.labelMaTK);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lbRole);
            this.panel1.Controls.Add(this.lbCreateDate);
            this.panel1.Controls.Add(this.lbAddress);
            this.panel1.Controls.Add(this.lbPhone);
            this.panel1.Controls.Add(this.lbEmailCT);
            this.panel1.Controls.Add(this.lbHoTenCT);
            this.panel1.Controls.Add(this.lbTaiKhoanCT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(41, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 407);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelMaTK
            // 
            this.labelMaTK.AutoSize = true;
            this.labelMaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelMaTK.Location = new System.Drawing.Point(158, 351);
            this.labelMaTK.Name = "labelMaTK";
            this.labelMaTK.Size = new System.Drawing.Size(57, 24);
            this.labelMaTK.TabIndex = 16;
            this.labelMaTK.Text = "None";
            this.labelMaTK.Click += new System.EventHandler(this.labelMaTK_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(14, 351);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 24);
            this.label11.TabIndex = 15;
            this.label11.Text = "Mã tài khoản : ";
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbRole.Location = new System.Drawing.Point(171, 298);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(57, 24);
            this.lbRole.TabIndex = 14;
            this.lbRole.Text = "None";
            // 
            // lbCreateDate
            // 
            this.lbCreateDate.AutoSize = true;
            this.lbCreateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCreateDate.Location = new System.Drawing.Point(124, 250);
            this.lbCreateDate.Name = "lbCreateDate";
            this.lbCreateDate.Size = new System.Drawing.Size(57, 24);
            this.lbCreateDate.TabIndex = 13;
            this.lbCreateDate.Text = "None";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAddress.Location = new System.Drawing.Point(106, 202);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(57, 24);
            this.lbAddress.TabIndex = 12;
            this.lbAddress.Text = "None";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPhone.Location = new System.Drawing.Point(159, 157);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(57, 24);
            this.lbPhone.TabIndex = 11;
            this.lbPhone.Text = "None";
            // 
            // lbEmailCT
            // 
            this.lbEmailCT.AutoSize = true;
            this.lbEmailCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbEmailCT.Location = new System.Drawing.Point(95, 115);
            this.lbEmailCT.Name = "lbEmailCT";
            this.lbEmailCT.Size = new System.Drawing.Size(57, 24);
            this.lbEmailCT.TabIndex = 10;
            this.lbEmailCT.Text = "None";
            // 
            // lbHoTenCT
            // 
            this.lbHoTenCT.AutoSize = true;
            this.lbHoTenCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHoTenCT.Location = new System.Drawing.Point(104, 65);
            this.lbHoTenCT.Name = "lbHoTenCT";
            this.lbHoTenCT.Size = new System.Drawing.Size(57, 24);
            this.lbHoTenCT.TabIndex = 9;
            this.lbHoTenCT.Text = "None";
            // 
            // lbTaiKhoanCT
            // 
            this.lbTaiKhoanCT.AutoSize = true;
            this.lbTaiKhoanCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTaiKhoanCT.Location = new System.Drawing.Point(134, 20);
            this.lbTaiKhoanCT.Name = "lbTaiKhoanCT";
            this.lbTaiKhoanCT.Size = new System.Drawing.Size(57, 24);
            this.lbTaiKhoanCT.TabIndex = 8;
            this.lbTaiKhoanCT.Text = "None";
            // 
            // btnEditInfo
            // 
            this.btnEditInfo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnEditInfo.BackColor = System.Drawing.Color.White;
            this.btnEditInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEditInfo.ForeColor = System.Drawing.Color.Black;
            this.btnEditInfo.Location = new System.Drawing.Point(698, 48);
            this.btnEditInfo.Name = "btnEditInfo";
            this.btnEditInfo.Size = new System.Drawing.Size(123, 31);
            this.btnEditInfo.TabIndex = 16;
            this.btnEditInfo.Text = "Chỉnh sửa";
            this.btnEditInfo.UseVisualStyleBackColor = false;
            this.btnEditInfo.Click += new System.EventHandler(this.btnEditInfo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::FastFoodDelivery.Properties.Resources.account1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(236, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxAvatarInfo
            // 
            this.pictureBoxAvatarInfo.BackgroundImage = global::FastFoodDelivery.Properties.Resources.account;
            this.pictureBoxAvatarInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxAvatarInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxAvatarInfo.Location = new System.Drawing.Point(619, 116);
            this.pictureBoxAvatarInfo.Name = "pictureBoxAvatarInfo";
            this.pictureBoxAvatarInfo.Size = new System.Drawing.Size(336, 407);
            this.pictureBoxAvatarInfo.TabIndex = 9;
            this.pictureBoxAvatarInfo.TabStop = false;
            this.pictureBoxAvatarInfo.Click += new System.EventHandler(this.pictureBoxAvatarInfo_Click);
            // 
            // PersonalInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEditInfo);
            this.Controls.Add(this.pictureBoxAvatarInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "PersonalInfoControl";
            this.Size = new System.Drawing.Size(996, 594);
            this.Load += new System.EventHandler(this.PersonalInfoControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatarInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxAvatarInfo;
        private System.Windows.Forms.Label lbTaiKhoanCT;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Label lbCreateDate;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbEmailCT;
        private System.Windows.Forms.Label lbHoTenCT;
        private System.Windows.Forms.Button btnEditInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelMaTK;
        private System.Windows.Forms.Label label11;
    }
}
