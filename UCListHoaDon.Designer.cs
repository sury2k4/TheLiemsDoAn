namespace QuanLyCuaHang
{
    partial class UCListHoaDon
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
            this.dvgListHoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttRefresh = new System.Windows.Forms.Button();
            this.bttFind = new System.Windows.Forms.Button();
            this.dateTimePickerNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerPhoneNumer = new System.Windows.Forms.TextBox();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListHoaDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgListHoaDon
            // 
            this.dvgListHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgListHoaDon.Location = new System.Drawing.Point(327, 39);
            this.dvgListHoaDon.Name = "dvgListHoaDon";
            this.dvgListHoaDon.RowHeadersWidth = 51;
            this.dvgListHoaDon.RowTemplate.Height = 24;
            this.dvgListHoaDon.Size = new System.Drawing.Size(781, 567);
            this.dvgListHoaDon.TabIndex = 0;
            this.dvgListHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgListHoaDon_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttRefresh);
            this.groupBox1.Controls.Add(this.bttFind);
            this.groupBox1.Controls.Add(this.dateTimePickerNgayLap);
            this.groupBox1.Controls.Add(this.txtCustomerPhoneNumer);
            this.groupBox1.Controls.Add(this.txtSoHD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 209);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // bttRefresh
            // 
            this.bttRefresh.Location = new System.Drawing.Point(146, 155);
            this.bttRefresh.Name = "bttRefresh";
            this.bttRefresh.Size = new System.Drawing.Size(130, 34);
            this.bttRefresh.TabIndex = 3;
            this.bttRefresh.Text = "Làm mới";
            this.bttRefresh.UseVisualStyleBackColor = true;
            this.bttRefresh.Click += new System.EventHandler(this.bttRefresh_Click);
            // 
            // bttFind
            // 
            this.bttFind.Location = new System.Drawing.Point(9, 155);
            this.bttFind.Name = "bttFind";
            this.bttFind.Size = new System.Drawing.Size(117, 34);
            this.bttFind.TabIndex = 3;
            this.bttFind.Text = "Tìm";
            this.bttFind.UseVisualStyleBackColor = true;
            this.bttFind.Click += new System.EventHandler(this.bttFind_Click);
            // 
            // dateTimePickerNgayLap
            // 
            this.dateTimePickerNgayLap.Location = new System.Drawing.Point(123, 117);
            this.dateTimePickerNgayLap.Name = "dateTimePickerNgayLap";
            this.dateTimePickerNgayLap.Size = new System.Drawing.Size(168, 22);
            this.dateTimePickerNgayLap.TabIndex = 2;
            this.dateTimePickerNgayLap.ValueChanged += new System.EventHandler(this.dateTimePickerNgayLap_ValueChanged);
            // 
            // txtCustomerPhoneNumer
            // 
            this.txtCustomerPhoneNumer.Location = new System.Drawing.Point(123, 68);
            this.txtCustomerPhoneNumer.Name = "txtCustomerPhoneNumer";
            this.txtCustomerPhoneNumer.Size = new System.Drawing.Size(169, 22);
            this.txtCustomerPhoneNumer.TabIndex = 1;
            // 
            // txtSoHD
            // 
            this.txtSoHD.Location = new System.Drawing.Point(123, 32);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(169, 22);
            this.txtSoHD.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Lập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "SDT Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Hóa Đơn";
            // 
            // UCListHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dvgListHoaDon);
            this.Name = "UCListHoaDon";
            this.Size = new System.Drawing.Size(1135, 648);
            ((System.ComponentModel.ISupportInitialize)(this.dvgListHoaDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgListHoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.Button bttRefresh;
        private System.Windows.Forms.Button bttFind;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayLap;
        private System.Windows.Forms.TextBox txtCustomerPhoneNumer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
