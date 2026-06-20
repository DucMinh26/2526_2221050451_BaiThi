using System.ComponentModel.DataAnnotations;

namespace MVC.Models.Entities
{
    public class NhanVien
    {
        [Key]
        [Required]
        public string MaNhanVien { get; set; }
        [Required]
        [MinLength(3)]
        public string? TenNhanVien { get; set; }
        public string MaPhongBan { get; set; }
        public PhongBan? PhongBan { get; set; }
    }
}