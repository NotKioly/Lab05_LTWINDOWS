using System;
using System.Globalization;
using System.Windows.Forms;

namespace CourseRegistrationApp
{
    public partial class MainForm : Form
    {
        private static readonly CultureInfo ViVN = new CultureInfo("vi-VN");

        public MainForm()
        {
            InitializeComponent();
        }

        // ---------- 5.1 Form Load ----------
        private void MainForm_Load(object sender, EventArgs e)
        {
            cboKhoaHoc.Items.Add(new KhoaHoc("C# WinForms cơ bản", 800000));
            cboKhoaHoc.Items.Add(new KhoaHoc("SQL Server cơ bản", 700000));
            cboKhoaHoc.Items.Add(new KhoaHoc("Web Frontend cơ bản", 750000));
            cboKhoaHoc.Items.Add(new KhoaHoc("Lập trình Python cơ bản", 650000));
            cboKhoaHoc.SelectedIndex = 0;

            radOnline.Checked = true;

            numSoThang.Minimum = 1;
            numSoThang.Maximum = 12;
            numSoThang.Value = 1;

            CapNhatTongTien();
        }

        // ---------- Tính học phí khi đổi khóa học / số tháng ----------
        private void cboKhoaHoc_SelectedIndexChanged(object sender, EventArgs e) => CapNhatTongTien();

        private void numSoThang_ValueChanged(object sender, EventArgs e) => CapNhatTongTien();

        private decimal TinhTongTien()
        {
            if (cboKhoaHoc.SelectedItem is KhoaHoc khoa)
                return khoa.HocPhiThang * numSoThang.Value;
            return 0;
        }

        private void CapNhatTongTien()
        {
            lblTongTien.Text = DinhDangTien(TinhTongTien());
        }

        private static string DinhDangTien(decimal soTien) => soTien.ToString("N0", ViVN) + " VNĐ";

        // ---------- 5.2 Đăng ký ----------
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                BaoLoi("Vui lòng nhập họ tên.", txtHoTen);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                BaoLoi("Vui lòng nhập số điện thoại.", txtSoDienThoai);
                return;
            }
            if (!(cboKhoaHoc.SelectedItem is KhoaHoc khoa))
            {
                BaoLoi("Vui lòng chọn khóa học.", cboKhoaHoc);
                return;
            }

            string hinhThuc = radOnline.Checked ? "Online" : "Trực tiếp";
            string nhanEmail = chkNhanEmail.Checked ? "Có" : "Không";

            string phieu =
                $"Họ tên: {txtHoTen.Text.Trim()}\n" +
                $"Số điện thoại: {txtSoDienThoai.Text.Trim()}\n" +
                $"Ngày sinh: {dtpNgaySinh.Value:dd/MM/yyyy}\n" +
                $"Khóa học: {khoa.TenKhoa}\n" +
                $"Hình thức học: {hinhThuc}\n" +
                $"Số tháng: {numSoThang.Value:0}\n" +
                $"Tổng tiền: {DinhDangTien(TinhTongTien())}\n" +
                $"Nhận email thông báo: {nhanEmail}";

            MessageBox.Show(phieu, "Phiếu đăng ký khóa học", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static void BaoLoi(string noiDung, Control controlLoi)
        {
            MessageBox.Show(noiDung, "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            controlLoi.Focus();
        }

        // ---------- 5.3 Làm mới ----------
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            chkNhanEmail.Checked = false;
            cboKhoaHoc.SelectedIndex = 0;
            radOnline.Checked = true;
            numSoThang.Value = 1;
            CapNhatTongTien();
            txtHoTen.Focus();
        }

        // ---------- 5.4 Thoát ----------
        private void btnThoat_Click(object sender, EventArgs e)
        {
            var kq = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes) Close();
        }
    }
}
