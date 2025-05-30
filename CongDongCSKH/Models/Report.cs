using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CongDongCSKH.Models
{
    internal class Report
    {
        [Key]
        public int Id { get; set; }

        public int PostId { get; set; }

        public int UserId { get; set; }

        public string LyDo { get; set; }

        public DateTime ThoiGianBaoCao { get; set; }
    }
}
