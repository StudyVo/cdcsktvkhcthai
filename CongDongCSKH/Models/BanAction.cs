using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CongDongCSKH.Models
{
    internal class BanAction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int AdminId { get; set; }

        public int? UserId { get; set; }
        public int? PostId { get; set; }
        public int? CourseId { get; set; }
        public int? GroupId { get; set; }

        public string LyDo { get; set; }

        public DateTime ThoiGian { get; set; }

        public bool DaBoChan { get; set; } // True nếu đã bỏ chặn
    }
}
