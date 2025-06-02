using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CongDongCSKH.Models
{
    internal class User
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string TenNguoiDung { get; set; }

        [StringLength(100)]
        public string TenDn { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(10)]
        public string? Phone { get; set; }

        [StringLength(200)]
        public string? Address { get; set; }

        [StringLength(200)]
        public string? HinhDaiDien { get; set; }

        [StringLength(200)]
        public string? MoTa { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(20)]
        public string? GioiTinh { get; set; }

        public bool BiChan { get; set; } = false; // 0: không bị chặn, 1: bị chặn
    }
}