
namespace TH2_ADONET
{
    partial class Bai02
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
            if (disposing)
            {
                if (components != null) components.Dispose();
                if (connection != null) connection.Dispose();
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
            this.grbThongTinChiTiet = new System.Windows.Forms.GroupBox();
            this.cbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.cbLoaiSanPham = new System.Windows.Forms.ComboBox();
            this.lbNhaCungCap = new System.Windows.Forms.Label();
            this.lbLoaiSanPham = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.lbTenSP = new System.Windows.Forms.Label();
            this.lbDanhMucSP = new System.Windows.Forms.Label();
            this.txtTimTenSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.gbThongTinChung = new System.Windows.Forms.GroupBox();
            this.dgvThongTinChung = new System.Windows.Forms.DataGridView();
            this.grbThongTinChiTiet.SuspendLayout();
            this.gb.SuspendLayout();
            this.gbThongTinChung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinChung)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongTinChiTiet
            // 
            this.grbThongTinChiTiet.Controls.Add(this.cbNhaCungCap);
            this.grbThongTinChiTiet.Controls.Add(this.cbLoaiSanPham);
            this.grbThongTinChiTiet.Controls.Add(this.lbNhaCungCap);
            this.grbThongTinChiTiet.Controls.Add(this.lbLoaiSanPham);
            this.grbThongTinChiTiet.Controls.Add(this.txtDonGia);
            this.grbThongTinChiTiet.Controls.Add(this.lbDonGia);
            this.grbThongTinChiTiet.Controls.Add(this.txtSoLuong);
            this.grbThongTinChiTiet.Controls.Add(this.lbSoLuong);
            this.grbThongTinChiTiet.Controls.Add(this.txtTenSP);
            this.grbThongTinChiTiet.Controls.Add(this.lbTenSP);
            this.grbThongTinChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinChiTiet.Location = new System.Drawing.Point(12, 67);
            this.grbThongTinChiTiet.Name = "grbThongTinChiTiet";
            this.grbThongTinChiTiet.Size = new System.Drawing.Size(776, 219);
            this.grbThongTinChiTiet.TabIndex = 0;
            this.grbThongTinChiTiet.TabStop = false;
            this.grbThongTinChiTiet.Text = "Thông tin chi tiết";
            // 
            // cbNhaCungCap
            // 
            this.cbNhaCungCap.FormattingEnabled = true;
            this.cbNhaCungCap.Location = new System.Drawing.Point(548, 121);
            this.cbNhaCungCap.Name = "cbNhaCungCap";
            this.cbNhaCungCap.Size = new System.Drawing.Size(158, 28);
            this.cbNhaCungCap.TabIndex = 9;
            // 
            // cbLoaiSanPham
            // 
            this.cbLoaiSanPham.FormattingEnabled = true;
            this.cbLoaiSanPham.Location = new System.Drawing.Point(548, 44);
            this.cbLoaiSanPham.Name = "cbLoaiSanPham";
            this.cbLoaiSanPham.Size = new System.Drawing.Size(158, 28);
            this.cbLoaiSanPham.TabIndex = 8;
            // 
            // lbNhaCungCap
            // 
            this.lbNhaCungCap.AutoSize = true;
            this.lbNhaCungCap.Location = new System.Drawing.Point(391, 121);
            this.lbNhaCungCap.Name = "lbNhaCungCap";
            this.lbNhaCungCap.Size = new System.Drawing.Size(111, 20);
            this.lbNhaCungCap.TabIndex = 7;
            this.lbNhaCungCap.Text = "Nhà cung cấp:";
            // 
            // lbLoaiSanPham
            // 
            this.lbLoaiSanPham.AutoSize = true;
            this.lbLoaiSanPham.Location = new System.Drawing.Point(391, 44);
            this.lbLoaiSanPham.Name = "lbLoaiSanPham";
            this.lbLoaiSanPham.Size = new System.Drawing.Size(117, 20);
            this.lbLoaiSanPham.TabIndex = 6;
            this.lbLoaiSanPham.Text = "Loại sản phẩm:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(166, 181);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(145, 26);
            this.txtDonGia.TabIndex = 5;
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Location = new System.Drawing.Point(32, 184);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(68, 20);
            this.lbDonGia.TabIndex = 4;
            this.lbDonGia.Text = "Đơn giá:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(166, 115);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(145, 26);
            this.txtSoLuong.TabIndex = 3;
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Location = new System.Drawing.Point(32, 118);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(76, 20);
            this.lbSoLuong.TabIndex = 2;
            this.lbSoLuong.Text = "Số lượng:";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(166, 38);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(145, 26);
            this.txtTenSP.TabIndex = 1;
            // 
            // lbTenSP
            // 
            this.lbTenSP.AutoSize = true;
            this.lbTenSP.Location = new System.Drawing.Point(32, 41);
            this.lbTenSP.Name = "lbTenSP";
            this.lbTenSP.Size = new System.Drawing.Size(114, 20);
            this.lbTenSP.TabIndex = 0;
            this.lbTenSP.Text = "Tên sản phẩm:";
            // 
            // lbDanhMucSP
            // 
            this.lbDanhMucSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhMucSP.ForeColor = System.Drawing.Color.Red;
            this.lbDanhMucSP.Location = new System.Drawing.Point(283, 24);
            this.lbDanhMucSP.Name = "lbDanhMucSP";
            this.lbDanhMucSP.Size = new System.Drawing.Size(234, 40);
            this.lbDanhMucSP.TabIndex = 1;
            this.lbDanhMucSP.Text = "Danh mục sản phẩm";
            // 
            // txtTimTenSP
            // 
            this.txtTimTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimTenSP.Location = new System.Drawing.Point(189, 327);
            this.txtTimTenSP.Name = "txtTimTenSP";
            this.txtTimTenSP.Size = new System.Drawing.Size(161, 26);
            this.txtTimTenSP.TabIndex = 11;
            this.txtTimTenSP.TextChanged += new System.EventHandler(this.txtTimTenSP_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tìm tên sản phẩm:";
            // 
            // gb
            // 
            this.gb.Controls.Add(this.btnThoat);
            this.gb.Controls.Add(this.btnSua);
            this.gb.Controls.Add(this.btnXoa);
            this.gb.Controls.Add(this.btnThem);
            this.gb.Location = new System.Drawing.Point(407, 292);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(381, 100);
            this.gb.TabIndex = 12;
            this.gb.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(300, 19);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 57);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(206, 19);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 57);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(105, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 57);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(6, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 57);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gbThongTinChung
            // 
            this.gbThongTinChung.Controls.Add(this.dgvThongTinChung);
            this.gbThongTinChung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTinChung.Location = new System.Drawing.Point(12, 397);
            this.gbThongTinChung.Name = "gbThongTinChung";
            this.gbThongTinChung.Size = new System.Drawing.Size(776, 198);
            this.gbThongTinChung.TabIndex = 13;
            this.gbThongTinChung.TabStop = false;
            this.gbThongTinChung.Text = "Thông tin chung";
            // 
            // dgvThongTinChung
            // 
            this.dgvThongTinChung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinChung.Location = new System.Drawing.Point(6, 25);
            this.dgvThongTinChung.Name = "dgvThongTinChung";
            this.dgvThongTinChung.Size = new System.Drawing.Size(764, 167);
            this.dgvThongTinChung.TabIndex = 0;
            this.dgvThongTinChung.SelectionChanged += new System.EventHandler(this.dgvThongTinChung_SelectionChanged);
            // 
            // Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 607);
            this.Controls.Add(this.gbThongTinChung);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.txtTimTenSP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDanhMucSP);
            this.Controls.Add(this.grbThongTinChiTiet);
            this.Name = "Bai02";
            this.Text = "Bai02";
            this.Load += new System.EventHandler(this.Bai02_Load);
            this.grbThongTinChiTiet.ResumeLayout(false);
            this.grbThongTinChiTiet.PerformLayout();
            this.gb.ResumeLayout(false);
            this.gbThongTinChung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinChung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTinChiTiet;
        private System.Windows.Forms.Label lbDanhMucSP;
        private System.Windows.Forms.ComboBox cbNhaCungCap;
        private System.Windows.Forms.ComboBox cbLoaiSanPham;
        private System.Windows.Forms.Label lbNhaCungCap;
        private System.Windows.Forms.Label lbLoaiSanPham;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label lbTenSP;
        private System.Windows.Forms.TextBox txtTimTenSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox gbThongTinChung;
        private System.Windows.Forms.DataGridView dgvThongTinChung;
    }
}