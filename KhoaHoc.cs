namespace CourseRegistrationApp
{
    /// <summary>Khóa học và học phí mỗi tháng.</summary>
    public class KhoaHoc
    {
        public string TenKhoa { get; }
        public decimal HocPhiThang { get; }

        public KhoaHoc(string tenKhoa, decimal hocPhiThang)
        {
            TenKhoa = tenKhoa;
            HocPhiThang = hocPhiThang;
        }

        // ComboBox hiển thị tên khóa học
        public override string ToString() => TenKhoa;
    }
}
