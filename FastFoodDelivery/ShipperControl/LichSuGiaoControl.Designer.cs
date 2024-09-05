namespace FastFoodDelivery.ShipperControl
{
    partial class LichSuGiaoControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.labelShipper = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "ID :";
            // 
            // labelShipper
            // 
            this.labelShipper.AutoSize = true;
            this.labelShipper.Location = new System.Drawing.Point(58, 47);
            this.labelShipper.Name = "labelShipper";
            this.labelShipper.Size = new System.Drawing.Size(87, 13);
            this.labelShipper.TabIndex = 58;
            this.labelShipper.Text = "SHIPPER CODE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(265, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(499, 31);
            this.label5.TabIndex = 56;
            this.label5.Text = "ĐƠN HÀNG ĐÃ GIAO THÀNH CÔNG";
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(16, 70);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.Size = new System.Drawing.Size(1002, 530);
            this.dataGridViewOrder.TabIndex = 55;
            this.dataGridViewOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrder_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::FastFoodDelivery.Properties.Resources.free1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(745, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 77);
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // LichSuGiaoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelShipper);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewOrder);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LichSuGiaoControl";
            this.Size = new System.Drawing.Size(1030, 615);
            this.Load += new System.EventHandler(this.LichSuGiaoControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelShipper;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
