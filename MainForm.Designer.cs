namespace CourseRegistrationApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpHocVien = new System.Windows.Forms.GroupBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.chkNhanEmail = new System.Windows.Forms.CheckBox();
            this.grpKhoaHoc = new System.Windows.Forms.GroupBox();
            this.lblKhoaHoc = new System.Windows.Forms.Label();
            this.cboKhoaHoc = new System.Windows.Forms.ComboBox();
            this.lblHinhThuc = new System.Windows.Forms.Label();
            this.radOnline = new System.Windows.Forms.RadioButton();
            this.radOffline = new System.Windows.Forms.RadioButton();
            this.lblSoThang = new System.Windows.Forms.Label();
            this.numSoThang = new System.Windows.Forms.NumericUpDown();
            this.lblTongTienTieuDe = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpHocVien.SuspendLayout();
            this.grpKhoaHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoThang)).BeginInit();
            this.SuspendLayout();
            //
            // grpHocVien
            //
            this.grpHocVien.Controls.Add(this.lblHoTen);
            this.grpHocVien.Controls.Add(this.txtHoTen);
            this.grpHocVien.Controls.Add(this.lblSoDienThoai);
            this.grpHocVien.Controls.Add(this.txtSoDienThoai);
            this.grpHocVien.Controls.Add(this.lblNgaySinh);
            this.grpHocVien.Controls.Add(this.dtpNgaySinh);
            this.grpHocVien.Controls.Add(this.chkNhanEmail);
            this.grpHocVien.Location = new System.Drawing.Point(15, 15);
            this.grpHocVien.Name = "grpHocVien";
            this.grpHocVien.Size = new System.Drawing.Size(470, 170);
            this.grpHocVien.TabIndex = 0;
            this.grpHocVien.TabStop = false;
            this.grpHocVien.Text = "Thông tin học viên";
            //
            // lblHoTen
            //
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(20, 33);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Text = "Họ tên:";
            //
            // txtHoTen
            //
            this.txtHoTen.Location = new System.Drawing.Point(150, 30);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(290, 27);
            this.txtHoTen.TabIndex = 0;
            //
            // lblSoDienThoai
            //
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Location = new System.Drawing.Point(20, 73);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Text = "Số điện thoại:";
            //
            // txtSoDienThoai
            //
            this.txtSoDienThoai.Location = new System.Drawing.Point(150, 70);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(290, 27);
            this.txtSoDienThoai.TabIndex = 1;
            //
            // lblNgaySinh
            //
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(20, 113);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Text = "Ngày sinh:";
            //
            // dtpNgaySinh
            //
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(150, 110);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(150, 27);
            this.dtpNgaySinh.TabIndex = 2;
            //
            // chkNhanEmail
            //
            this.chkNhanEmail.AutoSize = true;
            this.chkNhanEmail.Location = new System.Drawing.Point(320, 112);
            this.chkNhanEmail.Name = "chkNhanEmail";
            this.chkNhanEmail.TabIndex = 3;
            this.chkNhanEmail.Text = "Nhận email thông báo";
            this.chkNhanEmail.UseVisualStyleBackColor = true;
            //
            // grpKhoaHoc
            //
            this.grpKhoaHoc.Controls.Add(this.lblKhoaHoc);
            this.grpKhoaHoc.Controls.Add(this.cboKhoaHoc);
            this.grpKhoaHoc.Controls.Add(this.lblHinhThuc);
            this.grpKhoaHoc.Controls.Add(this.radOnline);
            this.grpKhoaHoc.Controls.Add(this.radOffline);
            this.grpKhoaHoc.Controls.Add(this.lblSoThang);
            this.grpKhoaHoc.Controls.Add(this.numSoThang);
            this.grpKhoaHoc.Controls.Add(this.lblTongTienTieuDe);
            this.grpKhoaHoc.Controls.Add(this.lblTongTien);
            this.grpKhoaHoc.Location = new System.Drawing.Point(15, 200);
            this.grpKhoaHoc.Name = "grpKhoaHoc";
            this.grpKhoaHoc.Size = new System.Drawing.Size(470, 210);
            this.grpKhoaHoc.TabIndex = 1;
            this.grpKhoaHoc.TabStop = false;
            this.grpKhoaHoc.Text = "Thông tin khóa học";
            //
            // lblKhoaHoc
            //
            this.lblKhoaHoc.AutoSize = true;
            this.lblKhoaHoc.Location = new System.Drawing.Point(20, 33);
            this.lblKhoaHoc.Name = "lblKhoaHoc";
            this.lblKhoaHoc.Text = "Khóa học:";
            //
            // cboKhoaHoc
            //
            this.cboKhoaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoaHoc.FormattingEnabled = true;
            this.cboKhoaHoc.Location = new System.Drawing.Point(150, 30);
            this.cboKhoaHoc.Name = "cboKhoaHoc";
            this.cboKhoaHoc.Size = new System.Drawing.Size(290, 28);
            this.cboKhoaHoc.TabIndex = 0;
            this.cboKhoaHoc.SelectedIndexChanged += new System.EventHandler(this.cboKhoaHoc_SelectedIndexChanged);
            //
            // lblHinhThuc
            //
            this.lblHinhThuc.AutoSize = true;
            this.lblHinhThuc.Location = new System.Drawing.Point(20, 73);
            this.lblHinhThuc.Name = "lblHinhThuc";
            this.lblHinhThuc.Text = "Hình thức học:";
            //
            // radOnline
            //
            this.radOnline.AutoSize = true;
            this.radOnline.Location = new System.Drawing.Point(150, 71);
            this.radOnline.Name = "radOnline";
            this.radOnline.TabIndex = 1;
            this.radOnline.TabStop = true;
            this.radOnline.Text = "Online";
            this.radOnline.UseVisualStyleBackColor = true;
            //
            // radOffline
            //
            this.radOffline.AutoSize = true;
            this.radOffline.Location = new System.Drawing.Point(260, 71);
            this.radOffline.Name = "radOffline";
            this.radOffline.TabIndex = 2;
            this.radOffline.Text = "Trực tiếp";
            this.radOffline.UseVisualStyleBackColor = true;
            //
            // lblSoThang
            //
            this.lblSoThang.AutoSize = true;
            this.lblSoThang.Location = new System.Drawing.Point(20, 113);
            this.lblSoThang.Name = "lblSoThang";
            this.lblSoThang.Text = "Số tháng đăng ký:";
            //
            // numSoThang
            //
            this.numSoThang.Location = new System.Drawing.Point(150, 110);
            this.numSoThang.Name = "numSoThang";
            this.numSoThang.Size = new System.Drawing.Size(80, 27);
            this.numSoThang.TabIndex = 3;
            this.numSoThang.ValueChanged += new System.EventHandler(this.numSoThang_ValueChanged);
            //
            // lblTongTienTieuDe
            //
            this.lblTongTienTieuDe.AutoSize = true;
            this.lblTongTienTieuDe.Location = new System.Drawing.Point(20, 160);
            this.lblTongTienTieuDe.Name = "lblTongTienTieuDe";
            this.lblTongTienTieuDe.Text = "Tổng học phí:";
            //
            // lblTongTien
            //
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTongTien.Location = new System.Drawing.Point(150, 156);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Text = "0 VNĐ";
            //
            // btnDangKy
            //
            this.btnDangKy.Location = new System.Drawing.Point(75, 430);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(110, 36);
            this.btnDangKy.TabIndex = 2;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            //
            // btnLamMoi
            //
            this.btnLamMoi.Location = new System.Drawing.Point(195, 430);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(110, 36);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            //
            // btnThoat
            //
            this.btnThoat.Location = new System.Drawing.Point(315, 430);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 36);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 485);
            this.Controls.Add(this.grpHocVien);
            this.Controls.Add(this.grpKhoaHoc);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG KÝ KHÓA HỌC";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpHocVien.ResumeLayout(false);
            this.grpHocVien.PerformLayout();
            this.grpKhoaHoc.ResumeLayout(false);
            this.grpKhoaHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoThang)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpHocVien;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.CheckBox chkNhanEmail;
        private System.Windows.Forms.GroupBox grpKhoaHoc;
        private System.Windows.Forms.Label lblKhoaHoc;
        private System.Windows.Forms.ComboBox cboKhoaHoc;
        private System.Windows.Forms.Label lblHinhThuc;
        private System.Windows.Forms.RadioButton radOnline;
        private System.Windows.Forms.RadioButton radOffline;
        private System.Windows.Forms.Label lblSoThang;
        private System.Windows.Forms.NumericUpDown numSoThang;
        private System.Windows.Forms.Label lblTongTienTieuDe;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThoat;
    }
}
