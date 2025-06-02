using System;
using System.ComponentModel.DataAnnotations;

namespace CongDongCSKH.Models
{
    internal class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string TenKhoaHoc { get; set; }

        public string MoTa { get; set; }

        public DateTime NgayTao { get; set; }

        public int UserId { get; set; }

        public bool BiChan { get; set; } = false;

        // ✅ Constructor mặc định cho Entity Framework
        public Course()
        {
        }

        // ✅ Constructor tùy chọn để dùng trong code
        public Course(int id, string name, string description)
        {
            Id = id;
            TenKhoaHoc = name;
            MoTa = description;
        }
    }
}
