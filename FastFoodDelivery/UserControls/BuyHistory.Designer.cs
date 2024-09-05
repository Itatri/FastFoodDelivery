namespace FastFoodDelivery.UserControls
{
    partial class BuyHistory
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
            this.dataGridViewDonDaGiao = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMaDH = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoiDungDG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownRating = new System.Windows.Forms.NumericUpDown();
            this.btnGui = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labelMonDat = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonDaGiao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRating)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDonDaGiao
            // 
            this.dataGridViewDonDaGiao.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDonDaGiao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDonDaGiao.Location = new System.Drawing.Point(16, 109);
            this.dataGridViewDonDaGiao.Name = "dataGridViewDonDaGiao";
            this.dataGridViewDonDaGiao.Size = new System.Drawing.Size(997, 330);
            this.dataGridViewDonDaGiao.TabIndex = 25;
            this.dataGridViewDonDaGiao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDonDaGiao_CellClick);
            this.dataGridViewDonDaGiao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDonDaGiao_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(334, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "ĐƠN HÀNG ĐÃ GIAO THÀNH CÔNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(16, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Đơn hàng :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(12, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "ĐÁNH GIÁ DỊCH VỤ";
            // 
            // labelMaDH
            // 
            this.labelMaDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelMaDH.Location = new System.Drawing.Point(95, 13);
            this.labelMaDH.Name = "labelMaDH";
            this.labelMaDH.Size = new System.Drawing.Size(176, 16);
            this.labelMaDH.TabIndex = 28;
            this.labelMaDH.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(290, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Nội dung";
            // 
            // txtNoiDungDG
            // 
            this.txtNoiDungDG.Location = new System.Drawing.Point(376, 14);
            this.txtNoiDungDG.Multiline = true;
            this.txtNoiDungDG.Name = "txtNoiDungDG";
            this.txtNoiDungDG.Size = new System.Drawing.Size(254, 49);
            this.txtNoiDungDG.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(661, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Điểm";
            // 
            // numericUpDownRating
            // 
            this.numericUpDownRating.Location = new System.Drawing.Point(716, 14);
            this.numericUpDownRating.Name = "numericUpDownRating";
            this.numericUpDownRating.Size = new System.Drawing.Size(63, 20);
            this.numericUpDownRating.TabIndex = 32;
            // 
            // btnGui
            // 
            this.btnGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGui.Location = new System.Drawing.Point(815, 14);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(97, 30);
            this.btnGui.TabIndex = 33;
            this.btnGui.Text = "Gửi";
            this.btnGui.UseVisualStyleBackColor = true;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(16, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Món đặt :";
            // 
            // labelMonDat
            // 
            this.labelMonDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelMonDat.Location = new System.Drawing.Point(95, 47);
            this.labelMonDat.Name = "labelMonDat";
            this.labelMonDat.Size = new System.Drawing.Size(176, 54);
            this.labelMonDat.TabIndex = 35;
            this.labelMonDat.Text = "...";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtNoiDungDG);
            this.panel1.Controls.Add(this.labelMonDat);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labelMaDH);
            this.panel1.Controls.Add(this.btnGui);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numericUpDownRating);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(16, 487);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 115);
            this.panel1.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::FastFoodDelivery.Properties.Resources.Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(228, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::FastFoodDelivery.Properties.Resources.reviewstar;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(223, 444);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 37);
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // BuyHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewDonDaGiao);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "BuyHistory";
            this.Size = new System.Drawing.Size(1028, 616);
            this.Load += new System.EventHandler(this.BuyHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonDaGiao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRating)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDonDaGiao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMaDH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNoiDungDG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownRating;
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelMonDat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
