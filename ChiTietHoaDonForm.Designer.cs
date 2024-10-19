namespace QuanLyCuaHang
{
    partial class ChiTietHoaDonForm
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
            this.dvgChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgChiTietHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgChiTietHoaDon
            // 
            this.dvgChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgChiTietHoaDon.Location = new System.Drawing.Point(39, 49);
            this.dvgChiTietHoaDon.Name = "dvgChiTietHoaDon";
            this.dvgChiTietHoaDon.RowHeadersWidth = 51;
            this.dvgChiTietHoaDon.RowTemplate.Height = 24;
            this.dvgChiTietHoaDon.Size = new System.Drawing.Size(869, 339);
            this.dvgChiTietHoaDon.TabIndex = 0;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(34, 9);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(206, 23);
            this.lblCustomerName.TabIndex = 8;
            // 
            // lblTongTien
            // 
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(663, 401);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(259, 40);
            this.lblTongTien.TabIndex = 10;
            // 
            // ChiTietHoaDonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 471);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.dvgChiTietHoaDon);
            this.Name = "ChiTietHoaDonForm";
            this.Text = "ChiTietHoaDonForm";
            ((System.ComponentModel.ISupportInitialize)(this.dvgChiTietHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgChiTietHoaDon;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblTongTien;
    }
}