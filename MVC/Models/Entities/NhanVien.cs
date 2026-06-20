using System.ComponentModel.DataAnnotations;

namespace MVC.Models.Entities
{
    public class NhanVien
    {
        [Key]
        public string MaNhanVien { get; set; }
        public string? TenNhanVien { get; set; }
        public string MaPhongBan { get; set; }
        public PhongBan? PhongBan { get; set; }
    }
}