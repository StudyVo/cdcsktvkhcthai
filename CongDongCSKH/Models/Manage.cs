using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CongDongCSKH.Models
{
    internal class Manage
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string TenNguoiDung { get; set; } // Tên người dùng (username hiển thị)

        [Required]
        [StringLength(100)]
        public string TenDn { get; set; } // Tên đăng nhập

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(200)]
        public string? MoTa { get; set; }

        [StringLength(200)]
        public string? HinhDaiDien { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(20)]
        public string? GioiTinh { get; set; } // Nam / Nữ / Không xác định / Không tiết lộ
    }
}