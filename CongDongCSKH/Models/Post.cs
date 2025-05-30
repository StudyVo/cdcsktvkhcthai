using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CongDongCSKH.Models
{
    internal class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string TieuDe { get; set; }

        public string NoiDung { get; set; }

        public DateTime NgayTao { get; set; }

        public int UserId { get; set; }

        public bool BiChan { get; set; } = false;
    }
}