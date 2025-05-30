using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CongDongCSKH.Models
{
    internal class MessageNT
    {
        [Key]
        public int Id { get; set; }

        public int NguoiGuiId { get; set; }

        public int NguoiNhanId { get; set; }

        public string NoiDung { get; set; }

        public DateTime ThoiGianGui { get; set; }
    }
}
