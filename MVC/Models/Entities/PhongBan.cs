using System.ComponentModel.DataAnnotations;

namespace MVC.Models.Entities
{
    public class PhongBan
    {
        [Key]
        public string MaPhongBan { get; set; }
        [Required]
        public string? TenPhongBan { get; set; }
        public ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();
    }
}
