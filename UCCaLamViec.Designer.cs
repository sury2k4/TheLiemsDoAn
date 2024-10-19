namespace QuanLyCuaHang
{
    partial class CaLamViecUC
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbChooseNV = new System.Windows.Forms.ComboBox();
            this.txtMaCa = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgayLam = new System.Windows.Forms.DateTimePicker();
            this.btnAddAndUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbbCaLam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dvgCaLamViec = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCaLamViec)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbChooseNV);
            this.groupBox1.Controls.Add(this.txtMaCa);
            this.groupBox1.Controls.Add(this.dateTimePickerNgayLam);
            this.groupBox1.Controls.Add(this.btnAddAndUpdate);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cbbCaLam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(3, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 256);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // cbbChooseNV
            // 
            this.cbbChooseNV.FormattingEnabled = true;
            this.cbbChooseNV.Location = new System.Drawing.Point(113, 24);
            this.cbbChooseNV.Name = "cbbChooseNV";
            this.cbbChooseNV.Size = new System.Drawing.Size(217, 24);
            this.cbbChooseNV.TabIndex = 7;
            // 
            // txtMaCa
            // 
            this.txtMaCa.Location = new System.Drawing.Point(295, 150);
            this.txtMaCa.Name = "txtMaCa";
            this.txtMaCa.Size = new System.Drawing.Size(41, 22);
            this.txtMaCa.TabIndex = 6;
            this.txtMaCa.Visible = false;
            // 
            // dateTimePickerNgayLam
            // 
            this.dateTimePickerNgayLam.Location = new System.Drawing.Point(116, 122);
            this.dateTimePickerNgayLam.Name = "dateTimePickerNgayLam";
            this.dateTimePickerNgayLam.Size = new System.Drawing.Size(220, 22);
            this.dateTimePickerNgayLam.TabIndex = 5;
            this.dateTimePickerNgayLam.ValueChanged += new System.EventHandler(this.dateTimePickerNgayLam_ValueChanged);
            // 
            // btnAddAndUpdate
            // 
            this.btnAddAndUpdate.Location = new System.Drawing.Point(5, 206);
            this.btnAddAndUpdate.Name = "btnAddAndUpdate";
            this.btnAddAndUpdate.Size = new System.Drawing.Size(116, 33);
            this.btnAddAndUpdate.TabIndex = 4;
            this.btnAddAndUpdate.Text = "Thêm/Sửa";
            this.btnAddAndUpdate.UseVisualStyleBackColor = true;
            this.btnAddAndUpdate.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(243, 206);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(93, 33);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(127, 206);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 33);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbbCaLam
            // 
            this.cbbCaLam.FormattingEnabled = true;
            this.cbbCaLam.Location = new System.Drawing.Point(116, 74);
            this.cbbCaLam.Name = "cbbCaLam";
            this.cbbCaLam.Size = new System.Drawing.Size(220, 24);
            this.cbbCaLam.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày làm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ca làm việc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Chọn Nhân Viên";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dvgCaLamViec
            // 
            this.dvgCaLamViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCaLamViec.Location = new System.Drawing.Point(367, 32);
            this.dvgCaLamViec.Name = "dvgCaLamViec";
            this.dvgCaLamViec.RowHeadersWidth = 51;
            this.dvgCaLamViec.RowTemplate.Height = 24;
            this.dvgCaLamViec.Size = new System.Drawing.Size(742, 544);
            this.dvgCaLamViec.TabIndex = 2;
            this.dvgCaLamViec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCaLamViec_CellClick);
            // 
            // CaLamViecUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dvgCaLamViec);
            this.Name = "CaLamViecUC";
            this.Size = new System.Drawing.Size(1126, 643);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCaLamViec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dvgCaLamViec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbbCaLam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddAndUpdate;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayLam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaCa;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cbbChooseNV;
    }
}
